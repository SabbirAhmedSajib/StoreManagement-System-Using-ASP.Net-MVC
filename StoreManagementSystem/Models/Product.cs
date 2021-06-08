using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreManagementSystem.Models
{
    public class Product
    {   
        
        [Key]
        public int ProductId { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public DateTime ExpiredDate { get; set; }
    }
}