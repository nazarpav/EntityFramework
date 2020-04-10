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
    public partial class ShopWindow_ : Window
    {
        ShopsDTO shop = null;
        BLL.BLL BLL_ = new BLL.BLL();
        public ShopWindow_(ShopsDTO shop, BLL.BLL BLL_)
        {
            InitializeComponent();
            LoadData(shop);
            this.shop = shop;
            this.BLL_ = BLL_;
        }
        private void LoadData(ShopsDTO shop)
        {
            if (shop.Name == null)
            {
                Create_Update.Content = "Create";
            }
            else
            {
                Create_Update.Content = "Update";
            }

            Name.Text = shop.Name;
            Address.Text = shop.Address;
            CityId.Text = shop.CityId.ToString();
            ParkingArea.IsChecked = shop.ParkingArea;
            DirectorId.Text = shop.DirectorId.ToString();
        }
        private void Create_Update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                shop.Name = Name.Text;
                shop.Address = Address.Text;
                shop.CityId = int.Parse(CityId.Text);
                shop.ParkingArea = (bool)ParkingArea.IsChecked;
                shop.DirectorId = int.Parse(DirectorId.Text);
                if (Create_Update.Content.ToString() == "Create")
                {
                    BLL_.CreateShop(shop);
                }
                else
                {
                    BLL_.UpdateShop(shop);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+" || Invalid input(s) values");
                return;
            }
        }
    }
}
