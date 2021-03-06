using System.Collections.Generic;
using System.Linq;
using Trupja_ASP_React_Redux_App.Data.Models;

namespace Trupja_ASP_React_Redux_App.Data.Services
{
    public class TripService : ITripServices
    {
        public List<Trip> GetAllTrips() => Data.Trips.ToList();

        public Trip GetTripById(int tripId) => Data.Trips.FirstOrDefault(n => n.Id == tripId);
        public void UpdateTrip(int tripId, Trip trip)
        {
            var oldTrip = Data.Trips.FirstOrDefault(n => n.Id == tripId);

            if (oldTrip != null)
            {
                oldTrip.Name = trip.Name;
                oldTrip.Description = trip.Description;
                oldTrip.DateStarted = trip.DateStarted;
                oldTrip.DateCompleted = trip.DateCompleted;
            }
        }
        public void DeleteTrip(int tripId)
        {
            var trip = Data.Trips.FirstOrDefault(n => n.Id == tripId);
            if (trip != null)
            {
                Data.Trips.Remove(trip);
            }
        }
        public void AddTrip(Trip trip)
        {
            Data.Trips.Add(trip);
        }
    }
}
