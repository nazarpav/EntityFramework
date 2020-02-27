namespace _25._02._2020
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SNModel : DbContext
    {
        // Контекст настроен для использования строки подключения "SNModel" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "_25._02._2020.SNModel" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "SNModel" 
        // в файле конфигурации приложения.
        public SNModel()
            : base("name=SNModel")
        {
        }




        public class Shop
        {
            int Id;
            string Name;
            string Address;
            float ParkingArea;
            int City_Id;
        }
        public class Workers
        {
            int Id;
            string Name;
            string Surname;
            string Phone;
            int Shop_Id;
            int Type_Id;
        }
        public class WorkersTypes
        {
            int Id;
            string Name;
            bool IsStaticSalary;
        }
        public class Cities
        {
            int Id;
            string Name;
            int Country_id;
        }
        public class Countries
        {
            int Id;
            string Name;
        }
        public class Products
        {
            int Id;
            string Name;
            int Category_Id;
            decimal Price;
            int Amounth;
            bool IsInStook;
        }
        public class Direetors
        {
            int Id;
            string FurstName;
        }
        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}