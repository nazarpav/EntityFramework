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

namespace _27._02._2020
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        USER_Entities c;
        public MainWindow()
        {
            InitializeComponent();
            c = new USER_Entities();
        }

        private async void TCreateBCreate_Click(object sender, RoutedEventArgs e)
        {
            if(TCreateTLogin.Text!=""&&
                TCreateTPassword.Text != "" &&
                TCreateTAddress.Text != "" &&
                TCreateTPhone.Text != ""
                )
            {
                User u = new User
                {
                    Address = TCreateTAddress.Text,
                    Login = TCreateTLogin.Text,
                    Password = TCreateTPassword.Text,
                    Phone = TCreateTPhone.Text,
                    IsAdmin = (bool)TCreateTIsAdmin.IsChecked
                };
                c.Users.Add(u);
                await c.SaveChangesAsync();
            }
            else
            {
                MessageBox.Show("Incorrect entered data");
            }
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            TabCntrol_.SelectedIndex = 0;
            Operation_Name.Text = "Create";
        }
        private void Read_Click(object sender, RoutedEventArgs e)
        {
            TabCntrol_.SelectedIndex = 1;
            Operation_Name.Text = "Read";
        }
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            TabCntrol_.SelectedIndex = 2;
            Operation_Name.Text = "Update";
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            TabCntrol_.SelectedIndex = 3;
            Operation_Name.Text = "Delete";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Load_ListBoxRead();
        }
        private void Load_ListBoxRead()
        {
            ListBoxRead.Items.Clear();
            foreach (var i in c.Users)
            {
                ListBoxRead.Items.Add(i.);
            }
        }
        private void UpdatedId_TextChanged(object sender, TextChangedEventArgs e)
        {
            int res;
            if (int.TryParse(UpdatedId.Text, out res))
            {
                User u = c.Users.Find(res);
                if (u == null) return;
                TUpdateTLogin.Text = u.Login;
                TUpdateTPassword.Text = u.Password;
                TUpdateTAddress.Text = u.Address;
                TUpdateTPhone.Text = u.Phone;
                TUpdateTIsAdmin.IsChecked = u.IsAdmin;
            }
        }

        private async void TUpdateBUpdate_Click(object sender, RoutedEventArgs e)
        {
            int res;
            if (int.TryParse(UpdatedId.Text, out res))
            {
                User u = c.Users.Find(res);
                if (u == null) return;
                u.Login = TUpdateTLogin.Text;
                u.Password = TUpdateTPassword.Text;
                u.Address = TUpdateTAddress.Text;
                u.Phone = TUpdateTPhone.Text;
                u.IsAdmin = (bool)TUpdateTIsAdmin.IsChecked;
                await c.SaveChangesAsync();
            }
        }

        private async void TDeleteBDelete_Click(object sender, RoutedEventArgs e)
        {
            int res;
            if (int.TryParse(DeletedId.Text, out res))
            {
                User u = c.Users.Find(res);
                if (u == null) return;
                c.Users.Remove(c.Users.Find(res));
                await c.SaveChangesAsync();
            }
        }

        private void DeletedId_TextChanged(object sender, TextChangedEventArgs e)
        {
            ListBoxDeletedElem.Items.Clear();
            int res;
            if (int.TryParse(DeletedId.Text, out res))
            {
                User u = c.Users.Find(res);
                if (u == null) return;
                ListBoxDeletedElem.Items.Add(u);
            }
        }
    }
}
