namespace _02._03._2020.DataModel
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BarbersDB_Model : DbContext
    {
        public BarbersDB_Model()
            : base("name=BarbersDB_Model")
        {
        }
        public virtual DbSet<VisitingArchive> VisitingArchives { get; set; }
        public virtual DbSet<Positions> Positions { get; set; }
        public virtual DbSet<Barbers> Barbers { get; set; }
        public virtual DbSet<EstimationsTypes> EstimationsTypes { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Estimations> Estimations { get; set; }
        public virtual DbSet<Feedbacks> Feedbacks { get; set; }
        public virtual DbSet<Records> Records { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<BarbersServices> BarbersServices { get; set; }
        public virtual DbSet<Shedule> Shedules { get; set; }
    }
}