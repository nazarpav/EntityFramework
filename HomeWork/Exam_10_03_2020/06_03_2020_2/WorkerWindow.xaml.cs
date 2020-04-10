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
    public partial class WorkerWindow : Window
    {
        WorkersDTO worker = null;
        BLL.BLL BLL_ = new BLL.BLL();
        public WorkerWindow(WorkersDTO worker, BLL.BLL BLL_)
        {
            InitializeComponent();
            LoadData(worker);
            this.worker = worker;
            this.BLL_ = BLL_;
        }
        private void LoadData(WorkersDTO worker)
        {
            if (worker.Name == null)
            {
                Create_Update.Content = "Create";
            }
            else
            {
                Create_Update.Content = "Update";
            }

            Name.Text = worker.Name;
            Phone.Text = worker.Phone;
            ShopId.Text = worker.ShopId.ToString();
            Surname.Text = worker.Surname;
            WorkerTypeId.Text = worker.WorkerTypeId.ToString();
        }
        private void Create_Update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                worker.Name = Name.Text;
                worker.ShopId = int.Parse(ShopId.Text);
                worker.WorkerTypeId = int.Parse(WorkerTypeId.Text);
                worker.Phone = Phone.Text;
                worker.Surname = Surname.Text;
                if (Create_Update.Content.ToString() == "Create")
                {
                    BLL_.CreateWorker(worker);
                }
                else
                {
                    BLL_.UpdateWorker(worker);
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
