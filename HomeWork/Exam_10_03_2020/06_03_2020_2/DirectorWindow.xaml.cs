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
    public partial class DirectorWindow : Window
    {
        DirectorsDTO director = null;
        BLL.BLL BLL_ = new BLL.BLL();
        public DirectorWindow(DirectorsDTO director, BLL.BLL BLL_)
        {
            InitializeComponent();
            LoadData(director);
            this.director = director;
            this.BLL_ = BLL_;
        }
        private void LoadData(DirectorsDTO director)
        {
            if (director.FirstName == null)
            {
                Create_Update.Content = "Create";
            }
            else
            {
                Create_Update.Content = "Update";
            }

            FirstName.Text = director.FirstName;
            LastName.Text = director.LastName;
            Education.IsChecked = director.Education;
            Email.Text = director.Email;
            Phone.Text = director.Phone;
        }
        private void Create_Update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                director.FirstName = FirstName.Text;
                director.LastName = LastName.Text;
                director.Email = Email.Text;
                director.Education = (bool)Education.IsChecked;
                director.Phone = Phone.Text;
                if (Create_Update.Content.ToString() == "Create")
                {
                    BLL_.CreateDirector(director);
                }
                else
                {
                    BLL_.UpdateDirector(director);
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
