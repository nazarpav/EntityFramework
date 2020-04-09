using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MFluentApi.Model;

namespace MFluentApi.DAL
{
    class DALClass
    {
        Model.ShopNetwork ctx = null;
        public DALClass()
        {
            ctx = new Model.ShopNetwork();
        }
        //Categories
        public void CreateCategory(Categiries c)
        {
            ctx.Categiries.Add(c);
            ctx.SaveChanges();
        }
        public void UpdateCategory(Categiries obj)
        {
            var newObj = ctx.Categiries.Where(q => q.Id == obj.Id).FirstOrDefault();
            newObj.Name = obj.Name;
            ctx.SaveChanges();
        }
        public void DeleteCategory(int id)
        {
            Categiries obj = ctx.Categiries.Where(q => q.Id == id).FirstOrDefault();
            ctx.Categiries.Remove(obj);
            ctx.Entry(obj).State = System.Data.Entity.EntityState.Deleted;
            ctx.SaveChanges();
        }
        public IQueryable<Categiries> GetAllCategories()
        {
            return ctx.Categiries;
        }
        //cities
        public void CreateCity(Cities c)
        {
            ctx.Cities.Add(c);
            ctx.SaveChanges();
        }
        public void UpdateCity(Cities obj)
        {
            var newObj = ctx.Cities.Where(q => q.Id == obj.Id).FirstOrDefault();
            newObj.Name = obj.Name;
            newObj.CountryId = obj.CountryId;
            ctx.SaveChanges();
        }
        public void DeleteCity(int id)
        {
            Cities obj = ctx.Cities.Where(q => q.Id == id).FirstOrDefault();
            ctx.Cities.Remove(obj);
            ctx.Entry(obj).State = System.Data.Entity.EntityState.Deleted;
            ctx.SaveChanges();
        }
        public IQueryable<Cities> GetAllCity()
        {
            return ctx.Cities;
        }
        //Countries
        public void CreateCountry(Countries c)
        {
            ctx.Countries.Add(c);
            ctx.SaveChanges();
        }
        public void UpdateCountry(Countries obj)
        {
            var newObj = ctx.Countries.Where(q => q.Id == obj.Id).FirstOrDefault();
            newObj.Name = obj.Name;
            ctx.SaveChanges();
        }
        public void DeleteCountry(int id)
        {
            Countries obj = ctx.Countries.Where(q => q.Id == id).FirstOrDefault();
            ctx.Countries.Remove(obj);
            ctx.Entry(obj).State = System.Data.Entity.EntityState.Deleted;
            ctx.SaveChanges();
        }
        public IQueryable<Countries> GetAllCountry()
        {
            return ctx.Countries;
        }
        //Categories
        public void CreateDirector(Directors c)
        {
            ctx.Directors.Add(c);
            ctx.SaveChanges();
        }
        public void UpdateDirector(Directors obj)
        {
            var newObj = ctx.Directors.Where(q => q.Id == obj.Id).FirstOrDefault();
            newObj.FirstName = obj.FirstName;
            newObj.LastName = obj.LastName;
            newObj.Education = obj.Education;
            newObj.Phone = obj.Phone;
            newObj.Email = obj.Email;
            ctx.SaveChanges();
        }
        public void DeleteDirector(int id)
        {
            Directors obj = ctx.Directors.Where(q => q.Id == id).FirstOrDefault();
            ctx.Directors.Remove(obj);
            ctx.Entry(obj).State = System.Data.Entity.EntityState.Deleted;
            ctx.SaveChanges();
        }
        public IQueryable<Directors> GetAllDirector()
        {
            return ctx.Directors;
        }
        //Products
        public void CreateProduct(Products c)
        {
            ctx.Products.Add(c);
            ctx.SaveChanges();
        }
        public void UpdateProduct(Products obj)
        {
            var newObj = ctx.Products.Where(q => q.Id == obj.Id).FirstOrDefault();
            newObj.FirstName = obj.FirstName;
            newObj.CategoryId = obj.CategoryId;
            newObj.Price = obj.Price;
            newObj.Discount = obj.Discount;
            newObj.IsInStook = obj.IsInStook;
            ctx.SaveChanges();
        }
        public void DeleteProduct(int id)
        {
            Products obj = ctx.Products.Where(q => q.Id == id).FirstOrDefault();
            ctx.Products.Remove(obj);
            ctx.Entry(obj).State = System.Data.Entity.EntityState.Deleted;
            ctx.SaveChanges();
        }
        public IQueryable<Products> GetAllProduct()
        {
            return ctx.Products;
        }
        //Shops
        public void CreateShop(Shops c)
        {
            ctx.Shops.Add(c);
            ctx.SaveChanges();
        }
        public void UpdateShop(Shops obj)
        {
            var newObj = ctx.Shops.Where(q => q.Id == obj.Id).FirstOrDefault();
            newObj.Id = obj.Id;
            newObj.Name = obj.Name;
            newObj.Address = obj.Address;
            newObj.ParkingArea = obj.ParkingArea;
            newObj.CityId = obj.CityId;
            ctx.SaveChanges();
        }
        public void DeleteShop(int id)
        {
            Shops obj = ctx.Shops.Where(q => q.Id == id).FirstOrDefault();
            ctx.Shops.Remove(obj);
            ctx.Entry(obj).State = System.Data.Entity.EntityState.Deleted;
            ctx.SaveChanges();
        }
        public IQueryable<Shops> GetAllShop()
        {
            return ctx.Shops;
        }
        //Workers
        public void CreateWorker(Model.Workers c)
        {
            ctx.Workers.Add(c);
            ctx.SaveChanges();
        }
        public void UpdateWorker(Workers obj)
        {
            var newObj = ctx.Workers.Where(q => q.Id == obj.Id).FirstOrDefault();
            newObj.Name = obj.Name;
            newObj.Surname = obj.Surname;
            newObj.Phone = obj.Phone;
            newObj.ShopId = obj.ShopId;
            newObj.WorkerTypeId = obj.WorkerTypeId;
            ctx.SaveChanges();
        }
        public void DeleteWorker(int id)
        {
            Workers obj = ctx.Workers.Where(q => q.Id == id).FirstOrDefault();
            ctx.Workers.Remove(obj);
            ctx.Entry(obj).State = System.Data.Entity.EntityState.Deleted;
            ctx.SaveChanges();
        }
        public IQueryable<Workers> GetAllWorker()
        {
            return ctx.Workers;
        }
        //WorkerTypes
        public void CreateWorkerType(Model.WorkerTypes c)
        {
            ctx.WorkerTypes.Add(c);
            ctx.SaveChanges();
        }
        public void UpdateWorkerType(WorkerTypes obj)
        {
            var newObj = ctx.WorkerTypes.Where(q => q.Id == obj.Id).FirstOrDefault();
            newObj.Name = obj.Name;
            newObj.IsStaticSalary = obj.IsStaticSalary;
            ctx.SaveChanges();
        }
        public void DeleteWorkerType(int id)
        {
            WorkerTypes obj = ctx.WorkerTypes.Where(q => q.Id == id).FirstOrDefault();
            ctx.WorkerTypes.Remove(obj);
            ctx.Entry(obj).State = System.Data.Entity.EntityState.Deleted;
            ctx.SaveChanges();
        }
        public IQueryable<WorkerTypes> GetAllWorkerType()
        {
            return ctx.WorkerTypes;
        }
    }
}
