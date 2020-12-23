using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesClothingStore.Data;
using RazorPagesClothingStore.Models;

namespace RazorPagesClothingStore.Pages.Goods
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesClothingStore.Data.RazorPagesClothingStoreContext _context;

        public CreateModel(RazorPagesClothingStore.Data.RazorPagesClothingStoreContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public RazorPagesClothingStore.Models.Goods Goods { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Goods.Add(Goods);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
