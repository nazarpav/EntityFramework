using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLClass
    {
        public DallClass DAL;
        public BLLClass()
        {
            DAL = new DallClass();

        }
        public IEnumerable<WorkerDTO> GetAllWorkers()
        {
            var result = DAL.GetAllWorkers().Select(a => new WorkerDTO()
            {
                Id = a.Id,
                Name = a.Name,
                Phone = a.Phone,
                ShopId = a.ShopId,
                Surname = a.Surname,
                WorkerTypeId = a.WorkerTypeId

            });

            foreach (var a in result)
            {
                yield return new WorkerDTO()
                {
                    Id = a.Id,
                    Name = a.Name,
                    Phone = a.Phone,
                    ShopId = a.ShopId,
                    Surname = a.Surname,
                    WorkerTypeId = a.WorkerTypeId
                };
            }
        }
        public WorkerDTO GetWorkerById(int Id)
        {
            Worker worker = DAL.GetWorkerById(Id);
            return new WorkerDTO()
            {
                Id = worker.Id,
                Name = worker.Name,
                Phone = worker.Phone,
                ShopId = worker.ShopId,
                Surname = worker.Surname,
                WorkerTypeId = worker.WorkerTypeId
            };

        }
        public void DeleteWorkerById(int idToDelete)
        {
            DAL.DeleteWorkerById(idToDelete);
        }
        public void AddNewWorker(WorkerDTO worker)
        {
            DAL.AddWorker(new Worker()
            {
                Id = worker.Id,
                Name = worker.Name,
                Phone = worker.Phone,
                ShopId = worker.ShopId,
                Surname = worker.Surname,
                WorkerTypeId = worker.WorkerTypeId
            }
            );
        }
        public void UpdateWorker(WorkerDTO worker)
        {
            DAL.UpdateWorker(new Worker()
            {
                Id = worker.Id,
                Name = worker.Name,
                Phone = worker.Phone,
                ShopId = worker.ShopId,
                Surname = worker.Surname,
                WorkerTypeId = worker.WorkerTypeId
            }
                  );
        }

        public IEnumerable<ShopDTO> GetAllShops()
        {

            var result = DAL.GetAllShops().Select(a => new ShopDTO()
            {
                Name = a.Name,
                Adress = a.Adress,
                CityId = a.CityId,
                Id = a.Id,
                ParkingArea = a.ParkingArea
            });

            foreach (var a in result)
            {
                yield return new ShopDTO()
                {
                    Name = a.Name,
                    Adress = a.Adress,
                    CityId = a.CityId,
                    Id = a.Id,
                    ParkingArea = a.ParkingArea
                };
            }
        }
        public void DeleteShopById(int idToDelete)
        {
            DAL.DeleteShopByID(idToDelete);
        }
        public void AddNewShop(ShopDTO shop)
        {
            DAL.AddShop(new Shop()
            {
                Id = shop.Id,
                Name = shop.Name,
                Adress = shop.Adress,
                CityId = shop.CityId,
                ParkingArea = shop.ParkingArea
            }
            );
        }
        public void UpdateShop(ShopDTO shop)
        {
            DAL.UpdateShop(new Shop()
            {
                Id = shop.Id,
                Name = shop.Name,
                Adress = shop.Adress,
                CityId = shop.CityId,
                ParkingArea = shop.ParkingArea
            }
         );
        }

        public IEnumerable<ProductDTO> GetAllProducts()
        {
            var result = DAL.GetAllProducts().Select(a => new ProductDTO()
            {
                Id = a.Id,
                Name = a.Name,
                IsOnStock = a.IsOnStock,
                Price = a.Price,
                Discount = a.Discount,
                CategoryId = a.CategoryId,
                Amount = a.Amount
            }
        );
            foreach (var a in result)
            {
                yield return new ProductDTO()
                {
                    Id = a.Id,
                    Name = a.Name,
                    IsOnStock = a.IsOnStock,
                    Price = a.Price,
                    Discount = a.Discount,
                    CategoryId = a.CategoryId,
                    Amount = a.Amount
                };
            }

        }
        public void DeleteProductById(int idToDelete)
        {
            DAL.DeleteProductById(idToDelete);
        }
        public void AddNewProduct(ProductDTO product)
        {
            DAL.AddProduct(new Product()
            {
                Id = product.Id,
                Name = product.Name,
                Amount = product.Amount,
                CategoryId = product.CategoryId,
                Discount = product.Discount,
                IsOnStock = product.IsOnStock,
                Price = product.Price
            }
            );
        }
        public void UpdateProduct(ProductDTO product)
        {
            DAL.UpdateProduct(new Product()
            {
                Id = product.Id,
                Name = product.Name,
                Amount = product.Amount,
                CategoryId = product.CategoryId,
                Discount = product.Discount,
                IsOnStock = product.IsOnStock,
                Price = product.Price
            }
           );
        }

        public IEnumerable<DirectorDTO> GetAllDirectors()
        {
            var result = DAL.GetAllDirectors().Select(a => new DirectorDTO()
            {
                Id = a.Id,
                Name = a.Name,
                Phone = a.Phone,
                Surname = a.Surname,
                Email = a.Email,
                Education = a.Education
            }
        );
            foreach (var a in result)
            {
                yield return new DirectorDTO()
                {
                    Id = a.Id,
                    Name = a.Name,
                    Phone = a.Phone,
                    Surname = a.Surname,
                    Email = a.Email,
                    Education = a.Education
                };
            }

        }
        public void DeleteDirectorById(int idToDelete)
        {
            DAL.DeleteDirectorById(idToDelete);
        }
        public void AddNewDirector(DirectorDTO director)
        {
            DAL.AddDirector(new Director()
            {
                Id = director.Id,
                Name = director.Name,
                Education = director.Education,
                Email = director.Email,
                Phone = director.Phone,
                Surname = director.Surname
            }
            );
        }
        public void UpdateDirector(DirectorDTO director)
        {
            DAL.UpdateDirector(new Director()
            {
                Id = director.Id,
                Name = director.Name,
                Education = director.Education,
                Email = director.Email,
                Phone = director.Phone,
                Surname = director.Surname
            }
           );
        }



    }
