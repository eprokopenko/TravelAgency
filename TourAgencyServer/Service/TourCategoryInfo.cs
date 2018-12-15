using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TourAgencyServer.Models;

namespace TourAgencyServer.Service
{
    public class TourCategoryInfo
    {
        public tourcategory TourCategory { get; set; }
        public List<ImageInfo> Images { get; set; }

        public TourCategoryInfo(tourcategory cat)
        {
            TourCategory = cat;
            Images = ImageInfo.GetImagesForElem("category", TourCategory.IdTourCategory);
        }

        public static List<TourCategoryInfo> GetCategories()
        {
            TourContext db = new TourContext();
            List<TourCategoryInfo> result = new List<TourCategoryInfo>();
            foreach (tourcategory cat in db.tourcategories)
            {
                TourCategoryInfo nCat = new TourCategoryInfo(cat);
                result.Add(nCat);
            } 
            return result;
        }

    }
}