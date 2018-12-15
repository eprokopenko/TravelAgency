using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TourAgencyServer.Service;

namespace TourAgencyServer.Controllers
{
    public class ToursController : ApiController
    {
        [Route("api/tours/{id}")]
        public TourInfo GetTourById(int id)
        {
            return new TourInfo(id);
        }
    }
}
