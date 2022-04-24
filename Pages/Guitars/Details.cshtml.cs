#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesGuitarShop.Data;
using RazorPagesGuitarShop.Models;

namespace RazorPagesGuitarShop.Pages.Guitars
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesGuitarShop.Data.RazorPagesGuitarShopContext _context;

        public DetailsModel(RazorPagesGuitarShop.Data.RazorPagesGuitarShopContext context)
        {
            _context = context;
        }

        public Guitar Guitar { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Guitar = await _context.Guitar.FirstOrDefaultAsync(m => m.ID == id);

            if (Guitar == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
