using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._03._2020.DataModel
{
    public class VisitingArchive
    {
        [Key]
        public int Id { get; set; }
        public int? ServiceId { get; set; }
        public virtual Services Service { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }
        public int? CustomerId { get; set; }
        public virtual Customers Customer { get; set; }
        public int? FeedbackId { get; set; }
        public virtual Feedbacks Feedback { get; set; }
        public int? BarberId { get; set; }
        public virtual Barbers Barber { get; set; }
        public int? EstimationId { get; set; }
        public Estimations Estimation { get; set; }
    }
}
