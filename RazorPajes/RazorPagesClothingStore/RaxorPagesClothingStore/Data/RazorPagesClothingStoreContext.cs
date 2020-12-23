using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesClothingStore.Models;

namespace RazorPagesClothingStore.Data
{
    public class RazorPagesClothingStoreContext : DbContext
    {
        public RazorPagesClothingStoreContext (DbContextOptions<RazorPagesClothingStoreContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesClothingStore.Models.Goods> Goods { get; set; }
    }
}
