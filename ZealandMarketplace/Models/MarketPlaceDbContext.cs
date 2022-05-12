using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ZealandMarketplace.Models;

namespace ZealandMarketplace.Models;

public class MarketPlaceDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
{
    public MarketPlaceDbContext()
    {
    }

    public MarketPlaceDbContext(DbContextOptions<MarketPlaceDbContext> options)
        : base(options)
    {
    }

    public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    public DbSet<IdentityUserClaim<string>> IdentityUserClaims { get; set; }
    public DbSet<IdentityUserRole<string>> IdentityUserRoles { get; set; }

}