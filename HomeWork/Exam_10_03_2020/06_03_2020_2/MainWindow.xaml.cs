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
using DALnamespace;
using BLL;
using System.Collections.ObjectModel;

namespace MFluentApi
{
    enum Obj
    {
        Worker, Product, Director, Shop, NONE
    }
    public partial class MainWindow : Window
    {
        Obj SelecterObj = Obj.NONE;
        BLL.BLL BLL_ = null;
        public MainWindow()
        {
            InitializeComponent();
            BLL_ = new BLL.BLL();
        }

        private void Workers_Click(object sender, RoutedEventArgs e)
        {
            UpdateButton();
            switch (((Button)sender).Content)
            {
                case "Workers":
                    SelecterObj = Obj.Worker;
                    break;
                case "Products":
                    SelecterObj = Obj.Product;
                    break;
                case "Directors":
                    SelecterObj = Obj.Director;
                    break;
                case "Shops":
                    SelecterObj = Obj.Shop;
                    break;
                default:
                    MessageBox.Show("Eror Invalit type");
                    break;
            }
            ((Button)sender).Background = new SolidColorBrush(Color.FromRgb(0, 185, 126));//#FF00B97E
            LoadData(SelecterObj);
        }
        private void UpdateButton()
        {
            Workers.Background = new SolidColorBrush(Color.FromRgb(238, 162, 0));//"#FFEEA200"
            Products.Background = new SolidColorBrush(Color.FromRgb(238, 162, 0));//"#FFEEA200"
            Directors.Background = new SolidColorBrush(Color.FromRgb(238, 162, 0));//"#FFEEA200"
            Shops.Background = new SolidColorBrush(Color.FromRgb(238, 162, 0));//"#FFEEA200"
        }
        private void LoadData(Obj SelecterObj_)
        {
            switch (SelecterObj_)
            {
                case Obj.Worker:
                    ObservableCollection<WorkerDG> workerDGs = new ObservableCollection<WorkerDG>();
                    foreach (var item in BLL_.GetAllWorkers())
                    {
                        workerDGs.Add(WorkerDG.Convert(item));
                    }
                    DG.ItemsSource = workerDGs;
                    break;
                case Obj.Product:
                    ObservableCollection<ProductDG> productDGs = new ObservableCollection<ProductDG>();
                    foreach (var item in BLL_.GetAllProducts())
                    {
                        productDGs.Add(ProductDG.Convert(item));
                    }
                    DG.ItemsSource = productDGs;
                    break;
                case Obj.Director:
                    ObservableCollection<DirectorDG> directorDGs = new ObservableCollection<DirectorDG>();
                    foreach (var item in BLL_.GetAllDirectors())
                    {
                        directorDGs.Add(DirectorDG.Convert(item));
                    }
                    DG.ItemsSource = directorDGs;
                    break;
                case Obj.Shop:
                    ObservableCollection<ShopDG> shopDGs = new ObservableCollection<ShopDG>();
                    foreach (var item in BLL_.GetAllShops())
                    {
                        shopDGs.Add(ShopDG.Convert(item));
                    }
                    DG.ItemsSource = shopDGs;
                    break;
                case Obj.NONE:
                    MessageBox.Show("NoNe");
                    return;
                default:
                    break;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //create
            switch (SelecterObj)
            {
                case Obj.Worker:
                    WorkerWindow workerWindow = new WorkerWindow(new WorkersDTO(), BLL_);
                    workerWindow.Show();
                    workerWindow.Closing += Window_Closed;
                    break;
                case Obj.Product:
                    ProductWindow productWindow = new ProductWindow(new ProductsDTO(), BLL_);
                    productWindow.Show();
                    productWindow.Closing += Window_Closed;
                    break;
                case Obj.Director:
                    DirectorWindow directorWindow = new DirectorWindow(new DirectorsDTO(), BLL_);
                    directorWindow.Show();
                    directorWindow.Closing += Window_Closed;
                    break;
                case Obj.Shop:
                    ShopWindow_ shopWindow = new ShopWindow_(new ShopsDTO(), BLL_);
                    shopWindow.Show();
                    shopWindow.Closing += Window_Closed;
                    break;
                case Obj.NONE:
                    MessageBox.Show("NoNe");
                    return;
                default:
                    break;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //update
            switch (SelecterObj)
            {
                case Obj.Worker:
                    foreach (var item in DG.SelectedItems)
                    {
                        WorkerWindow workerWindow = new WorkerWindow((WorkersDTO)item,BLL_);
                        workerWindow.Show();
                        workerWindow.Closing += Window_Closed;
                    }
                    break;
                case Obj.Product:
                    foreach (var item in DG.SelectedItems)
                    {
                        ProductWindow productWindow = new ProductWindow(ProductDG.ConvertToDTO((ProductDG)item), BLL_);
                        productWindow.Show();
                        productWindow.Closing += Window_Closed;
                    }
                    break;
                case Obj.Director:
                    foreach (var item in DG.SelectedItems)
                    {
                        DirectorWindow directorWindow = new DirectorWindow((DirectorsDTO)item, BLL_);
                        directorWindow.Show();
                        directorWindow.Closing += Window_Closed;
                    }
                    break;
                case Obj.Shop:
                    foreach (var item in DG.SelectedItems)
                    {
                        ShopWindow_ shopWindow = new ShopWindow_((ShopsDTO)item, BLL_);
                        shopWindow.Show();
                        shopWindow.Closing += Window_Closed;
                    }
                    break;
                case Obj.NONE:
                    MessageBox.Show("NoNe");
                    return;
                default:
                    break;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //delete
            switch (SelecterObj)
            {
                case Obj.Worker:
                    foreach (var item in DG.SelectedItems)
                    {
                        BLL_.DeleteWorker(((WorkerDG)item).Id);
                    }
                    break;
                case Obj.Product:
                    foreach (var item in DG.SelectedItems)
                    {
                        BLL_.DeleteProduct(((ProductDG)item).Id);
                    }
                    break;
                case Obj.Director:
                    foreach (var item in DG.SelectedItems)
                    {
                        BLL_.DeleteDirector(((DirectorDG)item).Id);
                    }
                    break;
                case Obj.Shop:
                    foreach (var item in DG.SelectedItems)
                    {
                        BLL_.DeleteShop(((ShopDG)item).DirectorId);
                    }
                    break;
                case Obj.NONE:
                    MessageBox.Show("NoNe");
                    return;
                default:
                    break;
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            LoadData(SelecterObj);
        }
    }
    public class DirectorDG
    {
        public DirectorDG(int Id, string FirstName, string LastName, bool? Education, string Phone, string Email)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Education = Education;
            this.Phone = Phone;
            this.Email = Email;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? Education { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public static DirectorDG Convert(DirectorsDTO directorsDTO)
        {
            return new DirectorDG(directorsDTO.Id, directorsDTO.FirstName, directorsDTO.LastName, directorsDTO.Education, directorsDTO.Phone, directorsDTO.Email);
        }
        public static DirectorsDTO ConvertToDTO(DirectorDG directorsDTO)
        {
            return new DirectorsDTO(directorsDTO.Id, directorsDTO.FirstName, directorsDTO.LastName, directorsDTO.Education, directorsDTO.Phone, directorsDTO.Email);
        }
    }
    public class WorkerDG
    {
        public WorkerDG(int Id, string Name, string Surname, string Phone, int ShopId, int WorkerTypeId)
        {
            this.Id = Id;
            this.Name = Name;
            this.Surname = Surname;
            this.Phone = Phone;
            this.ShopId = ShopId;
            this.WorkerTypeId = WorkerTypeId;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public int ShopId { get; set; }
        public int WorkerTypeId { get; set; }
        public static WorkerDG Convert(WorkersDTO workersDTO)
        {
            return new WorkerDG(workersDTO.Id, workersDTO.Name, workersDTO.Surname, workersDTO.Phone, workersDTO.ShopId, workersDTO.WorkerTypeId);
        }
        public static WorkersDTO ConvertToDTO(WorkerDG workersDTO)
        {
            return new WorkersDTO(workersDTO.Id, workersDTO.Name, workersDTO.Surname, workersDTO.Phone, workersDTO.ShopId, workersDTO.WorkerTypeId);
        }
    }
    public class ProductDG
    {
        public ProductDG(int Id, string FirstName, int CategoryId, int Price, int? Discount, bool IsInStook)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.CategoryId = CategoryId;
            this.Price = Price;
            this.Discount = Discount;
            this.IsInStook = IsInStook;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public int CategoryId { get; set; }
        public int Price { get; set; }
        public int? Discount { get; set; }
        public bool IsInStook { get; set; }
        public static ProductDG Convert(ProductsDTO productsDTO)
        {
            return new ProductDG(productsDTO.Id, productsDTO.FirstName, productsDTO.CategoryId, productsDTO.Price, productsDTO.Discount, productsDTO.IsInStook);
        }
        public static ProductsDTO ConvertToDTO(ProductDG productsDTO)
        {
            return new ProductsDTO(productsDTO.Id, productsDTO.FirstName, productsDTO.CategoryId, productsDTO.Price, productsDTO.Discount, productsDTO.IsInStook);
        }
    }
    public class ShopDG
    {
        public ShopDG(string Name, string Address, bool? ParkingArea, int CityId, int DirectorId)
        {
            this.Name = Name;
            this.Address = Address;
            this.ParkingArea = ParkingArea;
            this.CityId = CityId;
            this.DirectorId = DirectorId;
        }
        public string Name { get; set; }
        public string Address { get; set; }
        public bool? ParkingArea { get; set; }
        public int CityId { get; set; }
        public int DirectorId { get; set; }
        public static ShopDG Convert(ShopsDTO shopsDTO)
        {
            return new ShopDG(shopsDTO.Name, shopsDTO.Address, shopsDTO.ParkingArea, shopsDTO.CityId, shopsDTO.DirectorId);
        }
        public static ShopsDTO ConvertToDTO(ShopDG shopsDTO)
        {
            return new ShopsDTO( shopsDTO.Name, shopsDTO.Address, shopsDTO.ParkingArea, shopsDTO.CityId, shopsDTO.DirectorId);
        }
    }
}
