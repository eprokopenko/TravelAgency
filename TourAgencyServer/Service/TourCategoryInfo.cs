using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TourAgencyServer.Models;

namespace TourAgencyServer.Service
{
    public class TourCategoryInfo
    {
        public int IdTourCategory { get; set; }
        public string Name { get; set; }
        public List<ImageInfo> Images { get; set; }
        TourContext db = new TourContext();
        public TourCategoryInfo(int idCategory)
        {
            tourcategory t = db.tourcategories.Find(idCategory);
            IdTourCategory = idCategory;
            Name = t.Name;
            Images = ImageInfo.GetImagesForElem("category", IdTourCategory);
        }

        public static List<TourCategoryInfo> GetCategories()
        {
            TourContext db = new TourContext();
            List<TourCategoryInfo> result = new List<TourCategoryInfo>();
            foreach (tourcategory cat in db.tourcategories)
            {
                TourCategoryInfo nCat = new TourCategoryInfo(cat.IdTourCategory);
                result.Add(nCat);
            } 
            return result;
        }

    }
}