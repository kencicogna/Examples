using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryTest.Events;

namespace InventoryTest.Views
{
    public interface ISearchView
    {
        String searchString { get; set; }
    }

    public partial class SearchView : UserControl, ISearchView
    {
        public String searchString { get; set; }
        Timer timer;
        private int ticker = 0;
        private int tickerLimit = 2;
        private bool readyToSearch = false;
        
        public SearchView()
        {
            InitializeComponent();

            timer = new Timer { Interval = 1000 };
            timer.Tick += TimerOnTick;
            timer.Start();
        }

        private void TimerOnTick(object sender, EventArgs eventArgs)
        {
            if (ticker < 100)
                ticker++;

            if (readyToSearch && ticker >= tickerLimit )
            {
                EventAggregator.Instance.Publish(new ProductSearch {SearchString=tbSearch.Text});
                readyToSearch = false;
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            ticker = 0;
            if (tbSearch.Text.Length>0 )
                readyToSearch = true;
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tbSearch.Text.Length>0 && readyToSearch)
            {
                EventAggregator.Instance.Publish(new ProductSearch {SearchString=tbSearch.Text});
                readyToSearch = false;
            }
        }
    }
}
