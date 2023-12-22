using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppCodeFirstMVC.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public string ProductName { get; set; }
        public double  ProductPrice { get; set; }
        public DateTime MfgDate { get; set; }
        public DateTime ExpDate { get; set; }
    }
}