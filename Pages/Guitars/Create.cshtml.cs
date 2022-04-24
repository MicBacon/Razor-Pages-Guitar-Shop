#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesGuitarShop.Data;
using RazorPagesGuitarShop.Models;

namespace RazorPagesGuitarShop.Pages.Guitars
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesGuitarShop.Data.RazorPagesGuitarShopContext _context;

        public CreateModel(RazorPagesGuitarShop.Data.RazorPagesGuitarShopContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Guitar Guitar { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Guitar.Add(Guitar);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
