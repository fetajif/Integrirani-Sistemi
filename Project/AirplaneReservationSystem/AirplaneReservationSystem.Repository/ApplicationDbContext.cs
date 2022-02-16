using AirplaneReservationSystem.Domain.DomainModels;
using AirplaneReservationSystem.Domain.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
namespace AirplaneReservationSystem.Repository
{
    public class ApplicationDbContext : IdentityDbContext<FlightAppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Flight> Flights { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public virtual DbSet<FlightTicketInShoppingCart> FlightTicketInShoppingCarts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<FlightTicketInOrder> FlightTicketInOrders { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Flight>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<ShoppingCart>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<FlightTicketInShoppingCart>()
                .HasOne(z => z.SelectedFlight)
                .WithMany(z => z.FlightTicketInShoppingCarts)
                .HasForeignKey(z => z.ShoppingCartId);

            builder.Entity<FlightTicketInShoppingCart>()
                .HasOne(z => z.ShoppingCart)
                .WithMany(z => z.FlightTicketInShoppingCarts)
                .HasForeignKey(z => z.FlightId);

            builder.Entity<ShoppingCart>()
                .HasOne<FlightAppUser>(z => z.Owner)
                .WithOne(z => z.UserShoppingCart)
                .HasForeignKey<ShoppingCart>(z => z.OwnerId);

            builder.Entity<Order>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<FlightTicketInOrder>()
                .HasOne(z => z.SelectedFlight)
                .WithMany(z => z.FlightTicketInOrders)
                .HasForeignKey(z => z.OrderId);

            builder.Entity<FlightTicketInOrder>()
                .HasOne(z => z.UserOrder)
                .WithMany(z => z.FlightTicketInOrders)
                .HasForeignKey(z => z.FlightId);
        }
    }
}
