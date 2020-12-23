using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesClothingStore.Data;
using RazorPagesClothingStore.Models;

namespace RazorPagesClothingStore.Pages.Goods
{
    public class EditModel : PageModel
    {
        private readonly RazorPagesClothingStore.Data.RazorPagesClothingStoreContext _context;

        public EditModel(RazorPagesClothingStore.Data.RazorPagesClothingStoreContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Goods).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GoodsExists(Goods.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool GoodsExists(int id)
        {
            return _context.Goods.Any(e => e.ID == id);
        }
    }
}
