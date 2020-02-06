using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore
{
    class DatabaseContext:DbContext
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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer(@"Data Source=DOTNET18;Initial Catalog=EFCoreCGI;Integrated Security=True");
            
            //optionsBuilder.UseSqlServer(@"data source=dotnet18\SqlExpress;initial catalog=EFCoreCGI;persist security info=True;");
        }
    }
}
