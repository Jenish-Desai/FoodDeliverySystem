using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace FoodDeliverySystem.Models
{
    public class FoodDeliveryAppDbContext : IdentityDbContext<ApplicationUser>
    {
        public FoodDeliveryAppDbContext(DbContextOptions<FoodDeliveryAppDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //.OnDelete(DeleteBehavior.Cascade)
            builder.Entity<ApplicationUser>()
                                                                .Ignore(u => u.AccessFailedCount);
            builder.Entity<ApplicationUser>()
                                            .Ignore(u => u.ConcurrencyStamp);
            builder.Entity<ApplicationUser>()
                                            .Ignore(u => u.LockoutEnabled);
            builder.Entity<ApplicationUser>()
                                            .Ignore(u => u.LockoutEnd);
            builder.Entity<ApplicationUser>()
                                            .Ignore(u => u.NormalizedEmail);
            builder.Entity<ApplicationUser>()
                                            .Ignore(u => u.NormalizedUserName);
            //builder.Entity<ApplicationUser>()
            //                                .Ignore(u => u.SecurityStamp);     
            builder.Entity<ApplicationUser>()
                                            .Ignore(u => u.TwoFactorEnabled);
            builder.Entity<ApplicationUser>()
                                            .Ignore(u => u.UserName);


        }
    }
}
