﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TourAgencyServer.Models;

namespace TourAgencyServer.Service
{
    public class TourInfo
    {
        TourContext db = new TourContext();
        public tour Tour { get; set; }
        public List<DateTime> StartDates { get; set; }
        public hotel Hotel { get; set; }
        public city City { get; set; }
        public country Country { get; set; }
        public List<ImageInfo> Images { get; set; }

        public TourInfo(int idTour)
        {
            tour t = db.tours.SingleOrDefault<tour>(m => m.IdTour == idTour);
            Tour = t;
            StartDates = (from tourInstance in db.tourinstances where tourInstance.IdTour == t.IdTour select tourInstance.StartDate).ToList<DateTime>();
            Hotel = db.hotels.SingleOrDefault<hotel>(m => m.IdHotel == t.IdHotel);
            City = db.cities.SingleOrDefault<city>(m => m.IdCity == Hotel.IdCity);
            Country = db.countries.SingleOrDefault<country>(m => m.IdСountry == City.IdСountry);
            Images = ImageInfo.GetImagesForElem("tour", Tour.IdTourCategory);
        }

        public static List<TourInfo> GetListTourByCategory(int idCategory)
        {
            TourContext db = new TourContext();
            List<TourInfo> result = new List<TourInfo>();
            tourcategory tourCategory = db.tourcategories.Find(idCategory);
            List<tour> tours = tourCategory.tours.ToList<tour>();
            foreach (tour t in tours)
            {
                TourInfo nTourInfo = new TourInfo(t.IdTour);
                result.Add(nTourInfo);
            }
            return result;
        }
}
}