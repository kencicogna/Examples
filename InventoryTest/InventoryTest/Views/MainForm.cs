using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryTest.Views;
using InventoryTest.Presenters;

namespace InventoryTest
{
    public interface IMainFormView
    {
        //        event EventHandler Load;
        //        event HelpEventHandler HelpRequested;
        //        event KeyEventHandler KeyUp;

        void ShowSearchView();
        void ShowproductView();
    }

    public partial class MainForm : Form, IMainFormView
    {
        // Backer Variables
        private readonly Control searchView;
        private readonly Control productView;
        private readonly MainFormPresenter presenter;

        // Properties

        public MainForm(Control sv, Control pv)
        {
            InitializeComponent();
            this.searchView = sv;
            this.productView = pv;
            searchView.Dock = DockStyle.Fill;
            productView.Dock = DockStyle.Fill;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // this will probably be moved to presenter layer
            ShowSearchView();
            ShowproductView();
        }

        public void ShowSearchView()
        {
            pnlSearchContainer.Controls.Clear();
            pnlSearchContainer.Controls.Add(searchView);
        }

        public void ShowproductView()
        {
            pnlProductDetailsContainer.Controls.Clear();
            pnlProductDetailsContainer.Controls.Add(productView);
        }

    }
}
