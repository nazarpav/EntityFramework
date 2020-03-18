using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
    public class CityDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CountryId { get; set; }
    }
    public class CountryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class DirectorDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool? Education { get; set; }


        public string FullName { get { return Name + " " + Surname; } }
    }
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        public decimal? Discount { get; set; }
        public bool IsOnStock { get; set; }

        public int CategoryId { get; set; }
    }
    public class ShopDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public int? ParkingArea { get; set; }
        public int CityId { get; set; }
    }
    public class WorkerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public int ShopId { get; set; }
        public int WorkerTypeId { get; set; }

    }
    public class WorkerTypeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool isStaticSalary { get; set; }
    }
}
