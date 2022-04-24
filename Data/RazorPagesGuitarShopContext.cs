#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesGuitarShop.Models;

namespace RazorPagesGuitarShop.Data
{
    public class RazorPagesGuitarShopContext : DbContext
    {
        public RazorPagesGuitarShopContext (DbContextOptions<RazorPagesGuitarShopContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesGuitarShop.Models.Guitar> Guitar { get; set; }
    }
}
