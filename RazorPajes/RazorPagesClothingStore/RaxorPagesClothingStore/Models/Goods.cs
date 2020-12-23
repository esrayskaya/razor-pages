using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesClothingStore.Models
{
    public class Goods
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
    }
}
