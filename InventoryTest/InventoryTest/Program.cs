using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryTest.Presenters;
using InventoryTest.Views;

namespace InventoryTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Views
            var searchView = new SearchView();
            var productView = new ProductView();

            //productView.Title = "my title";
            //productView.SKU = "123";
            //productView.BinRack = "A-1-B";

            // Dependancies (other objects needed to support functionality)
            //     there class will be in the BusinessLogic folder

            // Main Form
            var mainForm = new MainForm(searchView,productView);
            mainForm.Tag = new MainFormPresenter(mainForm);

            // Create and assign Presenters
            searchView.Tag = new SearchPresenter(searchView);
            productView.Tag = new ProductPresenter(productView);

            Application.Run(mainForm);
        }
    }
}
