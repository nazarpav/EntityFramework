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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MFluentApi
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            using (Model.ShopNetwork ctx = new Model.ShopNetwork())
            {
                ctx.Categiries.Add(new Model.Categiries() { Name="C9"});
                //ctx.Cities.Add(new Model.Cities() { CountryId =1,Name="fddf"});
                ctx.SaveChanges();
            }
        }
    }
}
