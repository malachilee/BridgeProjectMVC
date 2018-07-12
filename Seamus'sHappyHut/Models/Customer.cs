using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Seamus_sHappyHut.Models
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public int CustomerPhone { get; set; }
        public string FavDrink { get; set; }
        public string FavMeal { get; set; }
        public double LargestBill { get; set; }
    }
}