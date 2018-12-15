using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TourAgencyServer.Service;

namespace TourAgencyServer.Controllers
{
    public class CountriesController : ApiController
    {
        public List<CountryInfo> GetAllCountries()
        {
            return CountryInfo.GetCountries();
        }

        [Route("api/countries/{id}/cities")]
        public List<CityInfo> GetListCitiesInfoByCountry(int id)
        {
            return CityInfo.GetListCityByCountry(id);
        }
    }
}
