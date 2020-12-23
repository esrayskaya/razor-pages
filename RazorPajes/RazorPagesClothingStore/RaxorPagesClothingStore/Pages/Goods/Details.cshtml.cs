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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesClothingStore.Data.RazorPagesClothingStoreContext _context;

        public DetailsModel(RazorPagesClothingStore.Data.RazorPagesClothingStoreContext context)
        {
            _context = context;
        }

        public RazorPagesClothingStore.Models.Goods Goods { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Goods = await _context.Goods.FirstOrDefaultAsync(m => m.ID == id);

            if (Goods == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
