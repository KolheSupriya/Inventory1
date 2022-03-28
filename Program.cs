using Microsoft.EntityFrameworkCore;
using System;

namespace InventoryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class MyDebContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server =.; Database = AngularReact; Trusted_Connection = True; ");
            optionsBuilder.UseSqlServer(@"Server =SUPRIYAKOL-VD\SQL2017; Database=InventoryMgtSystem; User ID=sa; Password=cybage@123456;");
        }
        public virtual DbSet<USERS> USERS { get; set; }
        public virtual DbSet<INVOICE> INVOICE_DATA { get; set; }
        public virtual DbSet<ProductCategories> PRODUCT_CATEGORIES { get; set; }
        //public virtual DbSet<STORAGE> STORAGES { get; set; }
        public virtual DbSet<Products> PRODUCTS { get; set; }
        public virtual DbSet<ROLE> ROLES { get; }
        public virtual DbSet<SHIPPING> SHIPPING { get; set; }

    }
}
