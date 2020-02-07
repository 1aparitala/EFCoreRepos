
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore
{
    public class DatabaseContext:DbContext
 //   public class DatabaseContext : IdentityDbContext<User, Roles, int>

    {

        public DbSet<Category>Categories { get; set; }
        public DbSet<Product> Products{ get; set; }
        public DbSet<User> Users{ get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>().ToTable("Users").HasKey(u => u.UserId);
            modelBuilder.Entity<User>().Property(u => u.Name).HasColumnType("Varchar(50)").IsRequired();
            modelBuilder.Entity<User>().Property(u => u.Contact).IsUnicode(false).IsRequired();



            base.OnModelCreating(modelBuilder);



        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    // Customize the ASP.NET Identity model and override the defaults if needed.
        //    modelBuilder.Entity<Microsoft.AspNetCore.Identity.IdentityUserRole<int>>(i =>
        //    {
        //        i.HasKey(x => new { x.RoleId, x.UserId });
        //    });
        //    modelBuilder.Entity<Microsoft.AspNetCore.Identity.IdentityUserLogin<int>>(i =>
        //    {
        //        i.HasIndex(x => new { x.ProviderKey, x.LoginProvider });
        //    });
        //    modelBuilder.Entity<IdentityRoleClaim<int>>(i =>
        //    {
        //        i.HasKey(x => x.Id);
        //    });
        //    modelBuilder.Entity<Microsoft.AspNetCore.Identity.IdentityUserClaim<int>>(i =>
        //    {
        //        i.HasKey(x => x.Id);
        //    });
        //    modelBuilder.Entity<IdentityUserToken<int>>(i =>
        //    {
        //        i.HasKey(x => x.UserId);
        //    });

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer(@"Data Source=DOTNET18;Initial Catalog=EFCoreCGI;Integrated Security=True");
            
            //optionsBuilder.UseSqlServer(@"data source=dotnet18\SqlExpress;initial catalog=EFCoreCGI;persist security info=True;");
        }







    }
}
