using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MFluentApi
{
    public partial class ProductWindow : Window
    {
        ProductsDTO product = null;
        BLL.BLL BLL_ = new BLL.BLL();
        public ProductWindow(ProductsDTO product, BLL.BLL BLL_)
        {
            InitializeComponent();
            LoadData(product);
            this.product = product;
            this.BLL_ = BLL_;
        }
        private void LoadData(ProductsDTO product)
        {
            if (product.FirstName == null)
            {
                Create_Update.Content = "Create";
            }
            else
            {
                Create_Update.Content = "Update";
            }

            FirstName.Text = product.FirstName;
            CategoryId.Text = product.CategoryId.ToString();
            Discount.Text = product.Discount.ToString();
            IsInStook.IsChecked = product.IsInStook;
            Price.Text = product.Price.ToString();
        }
        private void Create_Update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                product.FirstName = FirstName.Text;
                product.CategoryId = int.Parse(CategoryId.Text);
                product.Discount = int.Parse(Discount.Text);
                product.IsInStook = (bool)IsInStook.IsChecked;
                product.Price = int.Parse(Price.Text);
                if (Create_Update.Content.ToString() == "Create")
                {
                    BLL_.CreateProduct(product);
                }
                else
                {
                    BLL_.UpdateProduct(product);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " || Invalid input(s) values");
                return;
            }
        }
    }
}
