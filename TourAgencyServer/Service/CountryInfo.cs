using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TourAgencyServer.Models;

namespace TourAgencyServer.Service
{
    public class CountryInfo
    {
        public int IdCountry { get; set; }
        public string Name { get; set; }
        public CountryInfo(country c)
        {
            IdCountry = c.IdСountry;
            Name = c.Name;
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