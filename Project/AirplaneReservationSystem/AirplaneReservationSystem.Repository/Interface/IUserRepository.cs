using AirplaneReservationSystem.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirplaneReservationSystem.Repository.Interface
{
    public interface IUserRepository
    {
        IEnumerable<FlightAppUser> GetAll();
        FlightAppUser Get(string id);
        void Insert(FlightAppUser entity);
        void Update(FlightAppUser entity);
        void Delete(FlightAppUser entity);
    }
}
