using _02._03._2020.DataModel;
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

namespace _02._03._2020
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (BarbersDB_Model c = new BarbersDB_Model())
            {
                Positions position = new Positions();
                //position.Name = "ADMIN";
                //position.Name = "ADMIN2";
                position.Name = "DataAnnotations";
                c.Positions.Add(position);
                c.SaveChanges();
            }
        }
    }
}
