using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesClothingStore.Data;
using RazorPagesClothingStore.Models;

namespace RazorPagesClothingStore.Pages.Goods
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesClothingStore.Data.RazorPagesClothingStoreContext _context;

        //конструктор добавляет на страницу RazorPagesMovieContext
        public IndexModel(RazorPagesClothingStore.Data.RazorPagesClothingStoreContext context)
        {
            _context = context;
        }

        public IList<RazorPagesClothingStore.Models.Goods> Goods { get;set; }

        public async Task OnGetAsync()
        {
            Goods = await _context.Goods.ToListAsync();
        }
    }
}
