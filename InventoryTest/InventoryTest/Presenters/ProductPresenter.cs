using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryTest.Views;
using InventoryTest.Events;
using System.Drawing;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Threading;

namespace InventoryTest.Presenters
{
    class ProductPresenter
    {
        private IProductView productView;

        public ProductPresenter(IProductView pv)
        {
            productView = pv;
            EventAggregator.Instance.Subscribe<ProductSearch>(OnSearchTextChanged);
        }

        public void OnSearchTextChanged(ProductSearch ps)
        {
            if (ps.SearchString.Length == 0)
                return;

            var tempfile = @"..\..\Resources\temp.jpg";
            using (SqlConnection conn = new SqlConnection())
            {
                // Create the connectionString
                // Trusted_Connection is used to denote the connection uses Windows Authentication
                conn.ConnectionString = "Server=KEN-LAPTOP\\SQLEXPRESS;Database=BTData;Trusted_Connection=true";
                conn.Open();

                // Create the command
                SqlCommand command = new SqlCommand("SELECT top 1 sku, title, variation, cost, Location as binrack, image_url FROM Inventory WHERE title like @titleSearch or sku like @skuSearch", conn);

                // Add the parameters.
                command.Parameters.Add(new SqlParameter("titleSearch", "%"+ps.SearchString+"%"));
                command.Parameters.Add(new SqlParameter("skuSearch", "%"+ps.SearchString+"%"));

                // Execute command and read results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        productView.SKU = reader[0].ToString();
                        productView.Title = reader[1].ToString();
                        productView.Variations = reader[2].ToString();
                        productView.BinRack = reader[3].ToString();
                        productView.Cost = reader[4].ToString();

                        var url = reader[5].ToString();

                        using (var wc = new WebClient())
                        {
                            // Don't keep reloading the picture
                            productView.Title = "Picture loading...";
                            Thread.Sleep(2000);

                            wc.DownloadFile(url,tempfile);
                            using (Image tempimg = Image.FromFile(tempfile))
                            {
                                productView.PrimaryPicture = new Bitmap(tempimg);
                                productView.Title = reader[1].ToString();
                            }
                        }

                    } // while(reader.Read()))
                } // using( SQLDataReader

            } // sqlconnection
            System.IO.File.Delete(tempfile);
        } // OnSearchTextChanged

    } // end class
} // end namespace
