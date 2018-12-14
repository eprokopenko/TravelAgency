using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TourAgencyServer.Models;
using System.Data.Entity;

namespace TourAgencyServer.Controllers
{
    public class TourCategoriesController : ApiController
    {
        TourModel db = new TourModel();

        public IEnumerable<tourcategory> GetAllCategories()
        {
            return db.tourcategories;
        }

        public tourcategory GetTourCategory(int id)
        {
            tourcategory tourCategory = db.tourcategories.Find(id);
            return tourCategory;
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
    }
}
