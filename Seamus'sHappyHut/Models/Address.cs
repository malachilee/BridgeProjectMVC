using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seamus_sHappyHut.Models
{
    public class Address
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Customer")]
        public int StreetAddress { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zipcode { get; set; }
        public virtual Customer Customer { get; set; }



    }
}