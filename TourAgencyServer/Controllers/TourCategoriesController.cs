using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TourAgencyServer.Models;
using TourAgencyServer.Service;
using System.Data.Entity;

namespace TourAgencyServer.Controllers
{
    public class TourCategoriesController : ApiController
    {
        TourContext db = new TourContext();

        public List<TourCategoryInfo> GetAllCategories()
        {
            return TourCategoryInfo.GetCategories();
        }


        [HttpPost]
        public void CreateTourCategory([FromBody]tourcategory tourCategory)
        {
            db.tourcategories.Add(tourCategory);
            db.SaveChanges();
        }

        [HttpPut]
        public void EditTourCategory(int id, [FromBody]tourcategory tourCategory)
        {
            if (id == tourCategory.IdTourCategory)
            {
                db.Entry(tourCategory).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        [HttpDelete]
        public void DeleteTourCategory(int id)
        {
            tourcategory tourCategory = db.tourcategories.Find(id);
            if (tourCategory != null)
            {
                db.tourcategories.Remove(tourCategory);
                db.SaveChanges();
            }
        }

        [Route("api/tourcategories/{id}")]
        public TourCategoryInfo GetTourcategory(int id)
        {
            return new TourCategoryInfo(id);
        }

        [Route("api/tourcategories/{id}/tours")]
        public List<TourInfo> GetListTourInfoByTourcategory(int id)
        {
            return TourInfo.GetListTourByCategory(id);
        }
    }
}
