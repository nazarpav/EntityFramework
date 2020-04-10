using MFluentApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategiriesDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class CitiesDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
    }
    public class CountriesDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class DirectorsDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? Education { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string FullName { get { return FirstName + " " + LastName; } }
        public DirectorsDTO(int Id, string FirstName, string LastName, bool? Education, string Phone, string Email)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Education = Education;
            this.Phone = Phone;
            this.Email = Email;
        }
        public DirectorsDTO()
        {

        }
        public static DirectorsDTO Convert(Directors directorsDTO)
        {
            return new DirectorsDTO(directorsDTO.Id, directorsDTO.FirstName, directorsDTO.LastName, directorsDTO.Education, directorsDTO.Phone, directorsDTO.Email);
        }
    }
    public class ProductsDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public int CategoryId { get; set; }
        public int Price { get; set; }
        public int? Discount { get; set; }
        public bool IsInStook { get; set; }
        public ProductsDTO()
        {

        }
        public ProductsDTO(int Id, string FirstName, int CategoryId, int Price, int? Discount, bool IsInStook)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.CategoryId = CategoryId;
            this.Price = Price;
            this.Discount = Discount;
            this.IsInStook = IsInStook;
        }
        public static ProductsDTO Convert(Products productsDTO)
        {
            return new ProductsDTO(productsDTO.Id, productsDTO.FirstName, productsDTO.CategoryId, productsDTO.Price, productsDTO.Discount, productsDTO.IsInStook);
        }
    }
    public class ShopsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public bool? ParkingArea { get; set; }
        public int CityId { get; set; }
        public int DirectorId { get; set; }
        public ShopsDTO()
        {

        }
        public ShopsDTO(string Name, string Address, bool? ParkingArea, int CityId, int DirectorId)
        {
            this.Name = Name;
            this.Address = Address;
            this.ParkingArea = ParkingArea;
            this.CityId = CityId;
            this.DirectorId = DirectorId;
        }
        public static ShopsDTO Convert(Shops shopsDTO)
        {
            return new ShopsDTO(shopsDTO.Name, shopsDTO.Address, shopsDTO.ParkingArea, shopsDTO.CityId, shopsDTO.DirectorId);
        }
    }
    public class WorkersDTO
    {
        public WorkersDTO()
        {

        }
        public WorkersDTO(int Id, string Name, string Surname, string Phone, int ShopId, int WorkerTypeId)
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
        public static WorkersDTO Convert(Workers workersDTO)
        {
            return new WorkersDTO(workersDTO.Id, workersDTO.Name, workersDTO.Surname, workersDTO.Phone, workersDTO.ShopId, workersDTO.WorkerTypeId);
        }
    }
    public class WorkerTypesDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? IsStaticSalary { get; set; }
    }
}
