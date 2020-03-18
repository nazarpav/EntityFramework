using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class Initializer : CreateDatabaseIfNotExists<FluentApiAndEtc>
    {
        protected override void Seed(FluentApiAndEtc context)
        {
            base.Seed(context);
            context.WorkerTypes.AddRange(new List<WorkerType>()
            {
                new WorkerType() { isStaticSalary =true,Name = "Cleaner"},
                new WorkerType() { isStaticSalary = false, Name = "Seller" },
                new WorkerType() { isStaticSalary = false, Name = "Manager" },
                new WorkerType() { isStaticSalary = true, Name = "Guard" },
                new WorkerType() { isStaticSalary = true, Name = "Watcher" }
            }
            );
            context.SaveChanges();

            context.Categories.AddRange(new List<Category>()
             {
                 new Category() {  Name = "Fruits"},
                      new Category() {  Name = "Mech"},
                           new Category() {  Name = "Tech"},
                                new Category() {  Name = "Eco"},
                                     new Category() {  Name = "Materials"}
             }
      );
            context.SaveChanges();

            context.Countries.AddRange(new List<Country>()
            {
                new Country(){Name = "Ukraine"},
                 new Country(){Name = "Spain"},
                  new Country(){Name = "Belarus"},
                   new Country(){Name = "France"},
                    new Country(){Name = "Deught"},
            }
            );
            context.SaveChanges();

            context.Cities.AddRange(new List<City>()
            {
                new City(){Name = "Kiev",CountryId = 1},
                  new City(){Name = "Barselona",CountryId = 2},
                 new City(){Name = "Minsk",CountryId = 3},
                   new City(){Name = "Paris",CountryId = 4},
                    new City(){Name = "Lamburgh",CountryId = 5}
            }
           );
            context.SaveChanges();



            context.Products.AddRange(new List<Product>()
                    {
                        new Product() {  Name = "Apple",Amount=30,CategoryId=1,Discount=0,IsOnStock=true,Price=20},
                          new Product() {  Name = "Orange",Amount=33,CategoryId=1,Discount=0,IsOnStock=true,Price=12},
                            new Product() {  Name = "Melon",Amount=25,CategoryId=1,Discount=0,IsOnStock=true,Price=32},
                              new Product() {  Name = "Pear",Amount=36,CategoryId=1,Discount=0,IsOnStock=true,Price=41},
                                new Product() {  Name = "Banana",Amount=123,CategoryId=1,Discount=0,IsOnStock=true,Price=32},
                                  new Product() {  Name = "Apple Red",Amount=66,CategoryId=1,Discount=0,IsOnStock=true,Price=22},
                                    new Product() {  Name = "Pear",Amount=46,CategoryId=1,Discount=0,IsOnStock=true,Price=53},
                                      new Product() {  Name = "Apricote",Amount=76,CategoryId=1,Discount=0,IsOnStock=true,Price=11},
                                        new Product() {  Name = "Mango",Amount=34,CategoryId=1,Discount=0,IsOnStock=true,Price=23},
                                          new Product() {  Name = "Kiwi",Amount=23,CategoryId=1,Discount=0,IsOnStock=true,Price=123},
                                            new Product() {  Name = "Plum",Amount=13,CategoryId=1,Discount=0,IsOnStock=true,Price=12},
                                              new Product() {  Name = "Avocado",Amount=14,CategoryId=1,Discount=0,IsOnStock=true,Price=53},
                                                new Product() {  Name = "Lime",Amount=15,CategoryId=1,Discount=0,IsOnStock=true,Price=12},
                                                  new Product() {  Name = "Nectarine",Amount=54,CategoryId=1,Discount=0,IsOnStock=true,Price=33},
                                                    new Product() {  Name = "Coconut",Amount=75,CategoryId=1,Discount=0,IsOnStock=true,Price=11},
                                                      new Product() {  Name = "Fig",Amount=34,CategoryId=1,Discount=0,IsOnStock=true,Price=19},
                                                        new Product() {  Name = "Papaya",Amount=37,CategoryId=1,Discount=0,IsOnStock=true,Price=15},
                                                          new Product() {  Name = "Pineapple",Amount=34,CategoryId=1,Discount=0,IsOnStock=true,Price=25},
                                                            new Product() {  Name = "Persimmon",Amount=54,CategoryId=1,Discount=0,IsOnStock=true,Price=15},
                                                              new Product() {  Name = "Passionfruit",Amount=46,CategoryId=1,Discount=0,IsOnStock=true,Price=36},
                                                                new Product() {  Name = "Kumquat",Amount=46,CategoryId=1,Discount=0,IsOnStock=false,Price=64},
                                                                  new Product() {  Name = "Guava",Amount=23,CategoryId=1,Discount=0,IsOnStock=true,Price=23},
                                                                    new Product() {  Name = "Durian",Amount=12,CategoryId=1,Discount=0,IsOnStock=true,Price=12},
                                                                      new Product() {  Name = "Carob",Amount=11,CategoryId=1,Discount=0,IsOnStock=true,Price=45},
                                                                        new Product() {  Name = "Red Banana",Amount=35,CategoryId=1,Discount=0,IsOnStock=true,Price=65},
                                                                          new Product() {  Name = "Capers",Amount=34,CategoryId=1,Discount=0,IsOnStock=true,Price=23},
                                                                            new Product() {  Name = "Annona",Amount=34,CategoryId=1,Discount=0,IsOnStock=false,Price=23},
                                                                              new Product() {  Name = "Temarillo",Amount=34,CategoryId=1,Discount=0,IsOnStock=false,Price=12},
                                                                                new Product() {  Name = "Jackfruit",Amount=34,CategoryId=1,Discount=0,IsOnStock=true,Price=54},
                                                                                  new Product() {  Name = "Starfruit",Amount=34,CategoryId=1,Discount=0,IsOnStock=true,Price=65},
                                                                                   new Product() {  Name = "Granadefruit",Amount=56,CategoryId=1,Discount=0,IsOnStock=true,Price=34},
                                                                                     new Product() {  Name = "Quince",Amount=56,CategoryId=1,Discount=0,IsOnStock=true,Price=65}
                    }
     );
            context.SaveChanges();

            context.Shops.AddRange(new List<Shop>()
            {
                new Shop() {Id = 1, Adress = "PT 15 ", CityId =1,ParkingArea =12,  Name = "Novus"},
                new Shop() {Id = 2,Adress = "EG 25 ", CityId =2,  Name = "Fresh" },
                new Shop() {Id = 3,Adress = "SA 22 ", CityId =3,ParkingArea =8,   Name = "Arsen" }
            }
       );
            context.SaveChanges();

            context.Directors.AddRange(new List<Director>()
             {
                 new Director() {Id = 1,  Name = "Dmitro", Surname = "Amibovich", Phone ="38012312412",Education=true,Email="fafaf@mail.com"},
                 new Director() {Id = 2,  Name = "Vasil", Surname = "Popov", Phone ="38012312412",Education=true,Email="fgfd@mail.com"},
                 new Director() {Id = 3,  Name = "Oleg", Surname = "Kasad", Phone ="38012312412",Education=true,Email="asd@mail.com"}
             }
      );
            context.SaveChanges();



            context.Workers.AddRange(new List<Worker>()
             {
                 new Worker() {  Name = "Dmitro", Surname = "Amibovich", Phone ="38012312412",ShopId=1,WorkerTypeId=1},
                 new Worker() {  Name = "Dmitro", Surname = "Pidkapotniy", Phone ="38052354326" ,ShopId=1,WorkerTypeId=2},
                 new Worker() {  Name = "Anton", Surname = "Masluk", Phone ="38053252345",ShopId=1 ,WorkerTypeId=3},
                 new Worker() {  Name = "Anna", Surname = "Minska", Phone ="380754745733" ,ShopId=1,WorkerTypeId=4},
                 new Worker() {  Name = "Nastya", Surname = "Stookach", Phone ="38056572342",ShopId=1,WorkerTypeId=5 }
             }
         );
            context.SaveChanges();


        }

    }
}
