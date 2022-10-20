using DemoExamApp.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExamApp.DB
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }

        [Column(TypeName ="money")]
        public decimal Price { get; set; }
        public double Sale { get; set; }
        public string ImagePath { get; set; }
    }
}
