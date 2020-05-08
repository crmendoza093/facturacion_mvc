using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FacturacionMVC.Models
{
    public class ProductsInStock
    {
        public string product_name { get; set; }
        public double price { get; set; }
        public int stock1 { get; set; }
    }
}