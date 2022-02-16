using AirplaneReservationSystem.Domain.Identity;
using AirplaneReservationSystem.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirplaneReservationSystem.Repository.Implementation
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext context;
        private DbSet<FlightAppUser> entities;
        string errorMessage = string.Empty;

        public UserRepository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<FlightAppUser>();
        }
        public IEnumerable<FlightAppUser> GetAll()
        {
            return entities.AsEnumerable();
        }

        public FlightAppUser Get(string id)
        {
            return entities
               .Include(z => z.UserShoppingCart)
               .Include("UserShoppingCart.FlightTicketInShoppingCarts")
               .Include("UserShoppingCart.FlightTicketInShoppingCarts.SelectedFlight")
               .SingleOrDefault(s => s.Id == id);
        }
        public void Insert(FlightAppUser entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Update(FlightAppUser entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Update(entity);
            context.SaveChanges();
        }

        public void Delete(FlightAppUser entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }
    }
}
