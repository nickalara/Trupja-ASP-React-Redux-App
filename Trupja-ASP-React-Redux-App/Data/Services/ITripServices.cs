using System.Collections.Generic;
using Trupja_ASP_React_Redux_App.Data.Models;

namespace Trupja_ASP_React_Redux_App.Data.Services
{
    public interface ITripServices
    {
        List<Trip> GetAllTrips();
        Trip GetTripById(int tripId);
        void UpdateTrip(int tripId, Trip trip);
        void DeleteTrip(int tripId);
        void AddTrip(Trip trip);
    }
}
