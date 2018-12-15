﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TourAgencyServer.Models;

namespace TourAgencyServer.Service
{
    public class CityInfo
    {
        TourContext db = new TourContext();
        public city City { get; set; }
        public List<ImageInfo> Images { get; set; }

        public CityInfo(int idCity)
        {
            city c = db.cities.SingleOrDefault<city>(m => m.IdCity == idCity);
            City = c;
            Images = ImageInfo.GetImagesForElem("city", City.IdCity);
        }

        public static List<CityInfo> GetListCityByCountry(int idCountry)
        {
            TourContext db = new TourContext();
            List<CityInfo> result = new List<CityInfo>();
            country c = db.countries.Find(idCountry);
            List<city> cities = (from city in db.cities where city.IdСountry == c.IdСountry select city).ToList<city>();
            foreach (city city in cities)
            {
                CityInfo nCityInfo = new CityInfo(city.IdCity);
                result.Add(nCityInfo);
            }
            return result;
        }
    }
}