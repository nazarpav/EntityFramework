using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MFluentApi;
using MFluentApi.Model;
namespace DALnamespace
{
    public class Model1Initializer : CreateDatabaseIfNotExists<ShopNetwork>
    {
        protected override void Seed(ShopNetwork ctx)
        {
            ctx.Countries.Add(new Countries() { Name = "KNDR" });
            ctx.Countries.Add(new Countries() { Name = "USA" });
            ctx.Countries.Add(new Countries() { Name = "Ukraine" });
            ctx.Countries.Add(new Countries() { Name = "Moldova" });
            ctx.SaveChanges();
            ctx.Categiries.Add(new Categiries() { Name = "Category1" });
            ctx.Categiries.Add(new Categiries() { Name = "Category2" });
            ctx.Categiries.Add(new Categiries() { Name = "Category3" });
            ctx.Categiries.Add(new Categiries() { Name = "Category4" });
            ctx.Categiries.Add(new Categiries() { Name = "Category5" });
            ctx.SaveChanges();
            ctx.WorkerTypes.Add(new WorkerTypes() { IsStaticSalary = false, Name = "Type1" });
            ctx.WorkerTypes.Add(new WorkerTypes() { IsStaticSalary = true, Name = "Type2" });
            ctx.WorkerTypes.Add(new WorkerTypes() { IsStaticSalary = true, Name = "Type3" });
            ctx.WorkerTypes.Add(new WorkerTypes() { IsStaticSalary = false, Name = "Type4" });
            ctx.SaveChanges();
            ctx.Cities.Add(new Cities() { Name = "kiiv", CountryId = 1 });
            ctx.Cities.Add(new Cities() { Name = "kishnev", CountryId = 1 });
            ctx.Cities.Add(new Cities() { Name = "newyork", CountryId = 1 });
            ctx.Cities.Add(new Cities() { Name = "phenyan", CountryId = 1 });
            ctx.SaveChanges();
        }
    }
}
