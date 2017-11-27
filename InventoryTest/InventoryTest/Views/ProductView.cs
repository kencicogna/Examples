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
    public interface IProductView
    {
        String BinRack { get; set; }
        String Cost { get; set; }
        Image PrimaryPicture { get; set; }
        String PrimaryPictureURL { get; }
        String SKU { get; set; }
        String Title { get; set; }
        String Variations { get; set; }
    }

    public partial class ProductView : UserControl, IProductView
    {
        public ProductView()
        {
            InitializeComponent();
            tbBinRack.Text = "bin";
            tbCost.Text = "$5";
            tbSKU.Text = "12345";
            iboxProduct.Image = Image.FromFile(@"..\..\Resources\missing.png");
        }

        public string BinRack
        {
            get { return tbBinRack.Text; }
            set { tbBinRack.Text = value; }
        }

        public string Cost
        {
            get { return tbCost.Text; }
            set { tbCost.Text = value; }
        }

        public Image PrimaryPicture
        {
            get { return iboxProduct.Image; }
            set
            {
                iboxProduct.Image = value;
                lblPicturURL.Text = iboxProduct.ImageLocation;
            }
        }

        public string PrimaryPictureURL
        {
            get { return PrimaryPictureURL; }
        }

        public string SKU
        {
            get { return tbSKU.Text; }
            set { tbSKU.Text = value; }
        }

        public string Title
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; lblTitle.Refresh(); }
        }

        public string Variations
        {
            get { return clbVariations.Text; }
            set { clbVariations.Text = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EventAggregator.Instance.Publish(new ProductSearch { SearchString = "Save button" });
        }
    }
}
