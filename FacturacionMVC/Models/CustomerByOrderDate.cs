using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FacturacionMVC.Models
{
    public class CustomerByOrderDate
    {
        public string name { get; set; }
        public int age { get; set; }
        public DateTime date_order { get; set; }
    }
}