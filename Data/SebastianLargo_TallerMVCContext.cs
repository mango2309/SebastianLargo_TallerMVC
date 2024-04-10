using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SebastianLargo_TallerMVC.Models;

namespace SebastianLargo_TallerMVC.Data
{
    public class SebastianLargo_TallerMVCContext : DbContext
    {
        public SebastianLargo_TallerMVCContext (DbContextOptions<SebastianLargo_TallerMVCContext> options)
            : base(options)
        {
        }

        public DbSet<SebastianLargo_TallerMVC.Models.Burguer> Burguer { get; set; } = default!;
    }
}
