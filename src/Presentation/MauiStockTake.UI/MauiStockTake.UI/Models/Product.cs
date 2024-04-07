using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiStockTake.UI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ManufactureId { get; set; }
        public string ManufactureName { get; set; }
    }
}
