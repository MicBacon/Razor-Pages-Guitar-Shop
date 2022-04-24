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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesGuitarShop.Data.RazorPagesGuitarShopContext _context;

        public IndexModel(RazorPagesGuitarShop.Data.RazorPagesGuitarShopContext context)
        {
            _context = context;
        }

        public IList<Guitar> Guitar { get;set; }

        public async Task OnGetAsync()
        {
            Guitar = await _context.Guitar.ToListAsync();
        }
    }
}
