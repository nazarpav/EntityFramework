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

namespace _10_03_2020
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

        private void Workers_Click(object sender, RoutedEventArgs e)
        {
            UpdateButton();
            ((Button)sender).Background = new SolidColorBrush(Color.FromRgb(0, 185, 126));//#FF00B97E
        }
        private void UpdateButton()
        {
            Workers.Background = new SolidColorBrush(Color.FromRgb(238,162,0));//"#FFEEA200"
            Products.Background = new SolidColorBrush (Color.FromRgb(238, 162, 0));//"#FFEEA200"
            Directors.Background = new SolidColorBrush(Color.FromRgb(238, 162, 0));//"#FFEEA200"
            Shops.Background = new SolidColorBrush(Color.FromRgb(238, 162, 0));//"#FFEEA200"
        }
    }
}
