using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALnamespace;
using MFluentApi.Model;
//categiries
//cities
//countries
//directors+===============
//products+===============
//shops+===============
//workers+===============
//workertypes
namespace BLL
{
    public class BLL
    {
        public DAL DAL_;
        public BLL()
        {
            DAL_ = new DAL();
        }
        public IEnumerable<DirectorsDTO> GetAllDirectors()
        {
            var result = DAL_.GetAllDirector().Select(a => new DirectorsDTO()
            {
                Id = a.Id,
                FirstName = a.FirstName,
                Phone = a.Phone,
                LastName = a.LastName,
                Email = a.Email,
                Education = a.Education
            }
        );
            foreach (var a in result)
            {
                yield return new DirectorsDTO()
                {
                    Id = a.Id,
                    FirstName = a.FirstName,
                    Phone = a.Phone,
                    LastName = a.LastName,
                    Email = a.Email,
                    Education = a.Education
                };
            }

        }
        public void DeleteDirector(int id_)
        {
            DAL_.DeleteDirector(id_);
        }
        public void CreateDirector(DirectorsDTO director)
        {
            DAL_.CreateDirector(new Directors()
            {
                Id = director.Id,
                FirstName = director.FirstName,
                LastName = director.LastName,
                Education = director.Education,
                Email = director.Email,
                Phone = director.Phone
            }
            );
        }
        public void UpdateDirector(DirectorsDTO director)
        {
            DAL_.UpdateDirector(new Directors()
            {
                Id = director.Id,
                FirstName = director.FirstName,
                Education = director.Education,
                Email = director.Email,
                Phone = director.Phone,
                LastName = director.LastName
            }
           );
        }


        public IEnumerable<WorkersDTO> GetAllWorkers()
        {
            var result = DAL_.GetAllWorker().Select(a => new WorkersDTO()
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
                yield return new WorkersDTO()
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
        public WorkersDTO GetWorker(int Id_)
        {
            Workers worker = DAL_.GetAllWorker().Where(q => q.Id == Id_).FirstOrDefault();
            return new WorkersDTO()
            {
                Id = worker.Id,
                Name = worker.Name,
                Phone = worker.Phone,
                ShopId = worker.ShopId,
                Surname = worker.Surname,
                WorkerTypeId = worker.WorkerTypeId
            };

        }
        public void DeleteWorker(int id_)
        {
            DAL_.DeleteWorker(id_);
        }
        public void CreateWorker(WorkersDTO worker)
        {
            DAL_.CreateWorker(new Workers()
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
        public void UpdateWorker(WorkersDTO worker)
        {
            DAL_.UpdateWorker(new Workers()
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
        public IEnumerable<ShopsDTO> GetAllShops()
        {

            var result = DAL_.GetAllShop().Select(a => new ShopsDTO()
            {
                Name = a.Name,
                Address = a.Address,
                CityId = a.CityId,
                DirectorId = a.DirectorId,
                ParkingArea = a.ParkingArea
            });

            foreach (var a in result)
            {
                yield return new ShopsDTO()
                {
                    Name = a.Name,
                    Address = a.Address,
                    CityId = a.CityId,
                    DirectorId = a.DirectorId,
                    ParkingArea = a.ParkingArea
                };
            }
        }
        public void DeleteShop(int d_)
        {
            DAL_.DeleteShop(d_);
        }
        public void CreateShop(ShopsDTO shop)
        {
            DAL_.CreateShop(new Shops()
            {
                DirectorId = shop.DirectorId,
                Name = shop.Name,
                Address = shop.Address,
                CityId = shop.CityId,
                ParkingArea = shop.ParkingArea
            }
            );
        }
        public void UpdateShop(ShopsDTO shop)
        {
            DAL_.UpdateShop(new Shops()
            {
                DirectorId = shop.DirectorId,
                Name = shop.Name,
                Address = shop.Address,
                CityId = shop.CityId,
                ParkingArea = shop.ParkingArea
            }
         );
        }

        public IEnumerable<ProductsDTO> GetAllProducts()
        {
            var result = DAL_.GetAllProduct().Select(a => new ProductsDTO()
            {
                Id = a.Id,
                FirstName = a.FirstName,
                IsInStook = a.IsInStook,
                Price = a.Price,
                Discount = a.Discount,
                CategoryId = a.CategoryId
            }
        );
            foreach (var a in result)
            {
                yield return new ProductsDTO()
                {
                    Id = a.Id,
                    FirstName = a.FirstName,
                    IsInStook = a.IsInStook,
                    Price = a.Price,
                    Discount = a.Discount,
                    CategoryId = a.CategoryId
                };
            }

        }
        public void DeleteProduct(int idToDelete)
        {
            DAL_.DeleteProduct(idToDelete);
        }
        public void CreateProduct(ProductsDTO product)
        {
            DAL_.CreateProduct(new Products()
            {
                Id = product.Id,
                FirstName = product.FirstName,
                CategoryId = product.CategoryId,
                Discount = product.Discount,
                IsInStook = product.IsInStook,
                Price = product.Price
            }
            );
        }
        public void UpdateProduct(ProductsDTO product)
        {
            DAL_.UpdateProduct(new Products()
            {
                Id = product.Id,
                FirstName = product.FirstName,
                CategoryId = product.CategoryId,
                Discount = product.Discount,
                IsInStook = product.IsInStook,
                Price = product.Price
            }
           );
        }

    }
}
