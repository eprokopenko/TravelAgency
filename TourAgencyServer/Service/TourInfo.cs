using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TourAgencyServer.Models;

namespace TourAgencyServer
{
    public class TourService
    {
        TourContext db = new TourContext();
        public tour tour { get; set;  }
        public List<DateTime> startDates { get; set; }
        public hotel hotel { get; set; }
        public city city { get; set; }
        public country country { get; set; }

        public TourService(tour t)
        {
            tour = t;
            startDates = (from tourInstance in db.tourinstances where tourInstance.IdTour == t.IdTour select tourInstance.StartDate).ToList<DateTime>();
            hotel = db.hotels.SingleOrDefault<hotel>(m => m.IdHotel == t.IdHotel);
            city = db.cities.SingleOrDefault<city>(m => m.IdCity == hotel.IdCity);
            country = db.countries.SingleOrDefault<country>(m => m.IdСountry == city.IdСountry);
        }
    }
}