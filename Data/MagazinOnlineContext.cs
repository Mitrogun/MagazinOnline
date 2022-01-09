using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MagazinOnline.Models;

namespace MagazinOnline.Data
{
    public class MagazinOnlineContext : DbContext
    {
        internal object MarketCap;

        public MagazinOnlineContext (DbContextOptions<MagazinOnlineContext> options)
            : base(options)
        {
        }

        public DbSet<MagazinOnline.Models.Cryptocurrency> Cryptocurrency { get; set; }

        public DbSet<MagazinOnline.Models.Seller> Seller { get; set; }

        public DbSet<MagazinOnline.Models.CryptoMarketCap> CryptoMarketCap { get; set; }
    }
}
