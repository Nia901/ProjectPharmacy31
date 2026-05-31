using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
   public class PharmecyContext:DbContext
   {
        public PharmecyContext()
        {

        }
        public PharmecyContext(DbContextOptions<PharmecyContext> options) : base(options)
        {
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Questions> Questions { get; set; }
        public DbSet<Specialists> Spetialists { get; set; }
        public DbSet<User1> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder();
                builder.AddJsonFile("appconnections.json");
                var config = builder.Build();
                string conString = config.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(conString);
            }
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ConfigureUsers(modelBuilder);
            //modelBuilder.Entity<Admin>().HasKey(x => x.Id);
            modelBuilder.Entity<Admin>().Property(x => x.FirstName)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<Admin>().Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<Admin>().Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(50);
            //modelBuilder.Entity<Admin>().HasIndex(x=>x.Email).HasFilter("[Email] IS NOT NULL").IsUnique();
            //modelBuilder.Entity<Admin>().Property(x => x.Password)
            //    .IsRequired();

            //modelBuilder.Entity<Customer>().HasKey(x => x.Id);
            //modelBuilder.Entity<Customer>().Property(x => x.Username)
            //    .IsRequired()
            //    .HasMaxLength(50);
            //modelBuilder.Entity<Customer>().HasIndex(x => x.Username).IsUnique();
            //modelBuilder.Entity<Customer>().Property(x => x.Password)
            //    .IsRequired();
            modelBuilder.Entity<Customer>().Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(50);
            //modelBuilder.Entity<Customer>().HasIndex(x => x.Email).HasFilter("[Email] IS NOT NULL").IsUnique();
            modelBuilder.Entity<Customer>().Property(x => x.Age)
                .IsRequired();
            modelBuilder.Entity<Customer>().ToTable(x => x.HasCheckConstraint("CK_Age", "[Age] >= 18 AND [Age] < 150"));

            modelBuilder.Entity<Order>().HasKey(x => x.Id);
            modelBuilder.Entity<Order>().HasOne(x=>x.Product)
                .WithMany(x=>x.Orders)
                .HasForeignKey(x=>x.ProductId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Order>().HasOne(x => x.Customer)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.CustomerId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Order>().Property(x => x.OrderDate)
                .IsRequired()
                .HasColumnType("datetime");
            modelBuilder.Entity<Order>().Property(x => x.Quantity)
                .IsRequired();
            modelBuilder.Entity<Order>().Property(x => x.TotalPrice)
                .IsRequired();
            modelBuilder.Entity<Order>().ToTable(x => x.HasCheckConstraint("CK_Quantity2", "[Quantity] > -1"));
            modelBuilder.Entity<Order>().ToTable(x => x.HasCheckConstraint("CK_TotalPrice2", "[TotalPrice] > -1"));

            modelBuilder.Entity<Product>().HasKey(x => x.Id);
            modelBuilder.Entity<Product>().Property(x=>x.Name)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<Product>().Property(x => x.Brand)
                .IsRequired()
                .HasMaxLength(150);
            modelBuilder.Entity<Product>().Property(x => x.Category)
               .IsRequired().HasConversion<string>();
            modelBuilder.Entity<Product>().Property(x => x.ProductType)
                .IsRequired()
                .HasMaxLength(150);
            modelBuilder.Entity<Product>().Property(x => x.Price)
                .IsRequired();
            modelBuilder.Entity<Product>().Property(x => x.Quantity)
                .IsRequired();
            modelBuilder.Entity<Product>().ToTable(x => x.HasCheckConstraint("CK_Quantity", "[Quantity] > -1"));
            modelBuilder.Entity<Product>().ToTable(x => x.HasCheckConstraint("CK_Price", "[Price] > -1"));

            modelBuilder.Entity<Questions>().HasKey(x => x.Id);
            modelBuilder.Entity<Questions>().HasOne(x => x.Specialist)
                .WithMany(x => x.Questions)
                .HasForeignKey(x => x.SpecialistId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Questions>().HasOne(x => x.Customer)
                .WithMany(x => x.Questions)
                .HasForeignKey(x => x.CustomerId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Questions>().Property(x=>x.Description)
                .HasMaxLength(500)
                .IsRequired(false);
            modelBuilder.Entity<Questions>().Property(x => x.ConsultationDate)
                .IsRequired()
                .HasColumnType("datetime");

            //modelBuilder.Entity<Specialists>().HasKey(x => x.Id);
            modelBuilder.Entity<Specialists>().Property(x => x.FirstName)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<Specialists>().Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<Specialists>().Property(x => x.ProField)
                .HasConversion<string>();
        }
        private void ConfigureUsers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User1>()
                .HasDiscriminator<string>("RoleType")
                .HasValue<Admin>("Admin")
                .HasValue<Customer>("Customer")
                .HasValue<Specialists>("Specialist");

            modelBuilder.Entity<User1>().HasKey(x => x.Id);
            modelBuilder.Entity<User1>().Property(x => x.Password)
                .IsRequired();
            modelBuilder.Entity<User1>().Property(x => x.Username)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<User1>().HasIndex(x => x.Username).IsUnique();
        }
    }
}
