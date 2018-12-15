using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TourAgencyServer.Models;

namespace TourAgencyServer.Service
{
    public class CountryInfo
    {
        public country Country { get; set; }
        public CountryInfo(country c)
        {
            Country = c;
        }
        public static List<CountryInfo> GetCountries()
        {
            TourContext db = new TourContext();
            List<CountryInfo> result = new List<CountryInfo>();
            foreach (country c in db.countries)
            {
                CountryInfo nCountry = new CountryInfo(c);
                result.Add(nCountry);
            }
            return result;
        }
    }
}