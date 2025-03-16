using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastyEating.Models
{
    public class MyDbContext: DbContext
    {
        private static MyDbContext _instance = null;
        public static User LocalUser { get; set; }

        public static MyDbContext Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MyDbContext();

                return _instance;
            }
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<DishInOrder> DishesInOrders { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DishInOrder>()
                .HasKey(f => new { f.OrderId, f.DishId });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=cfif31.ru;user id=test;password=test;database=test", new MySqlServerVersion("8.0.41"));
        }
    }
}
