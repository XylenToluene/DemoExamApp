using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExamApp.View
{
    public class ProductView
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public double Sale { get; set; }
        public string ImagePath { get; set; }
        public decimal PriceWithSale { get; set; }
        public bool SaleFill { get; set; }
    }
}
