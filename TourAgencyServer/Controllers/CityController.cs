using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TourAgencyServer.Service;

namespace TourAgencyServer.Controllers
{
    public class CityController : ApiController
    {
        [Route("api/cities/{id}")]
        public CityInfo GetCityById(int id)
        {
            return new CityInfo(id);
        }
    }
}
