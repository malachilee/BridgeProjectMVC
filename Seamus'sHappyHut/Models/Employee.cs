using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Seamus_sHappyHut.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public int CustomerPhone { get; set; }
        public int EmployeeNum { get; set; }
        public string EmployeeContactName { get; set; }
        public int EmployeeContactNumber { get; set; }



    }
}