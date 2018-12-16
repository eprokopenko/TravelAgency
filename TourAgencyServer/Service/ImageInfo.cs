using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Text;
using TourAgencyServer.Models;

namespace TourAgencyServer.Service
{
    public class ImageInfo
    {
        public int IdImage { get; set; }
        public string Imagecol { get; set; }
        public string ImageFile { get; set; }

        public ImageInfo(image im)
        {
            IdImage = im.IdImage;
            Imagecol = im.Imagecol;
            ImageFile = GetFileByString(im);
        }

        public static List<ImageInfo> GetImagesForElem(string typeElem, int idElem)
        {
            TourContext db = new TourContext();
            List<ImageInfo> result = new List<ImageInfo>();
            List<image> images = new List<image>();
            switch (typeElem)
            {
                case "category":
                    {
                        tourcategory cat = db.tourcategories.Find(idElem);
                        images = GetImagesForCategory(cat);
                        break;
                    }
                case "tour":
                    {
                        tour t = db.tours.SingleOrDefault<tour>(m => m.IdTour == idElem);
                        images = GetImagesForTour(t);
                        break;
                    }
                case "city":
                    {
                        city c = db.cities.SingleOrDefault<city>(m => m.IdCity == idElem);
                        images = GetImagesForCity(c);
                        break;
                    }
            }
            foreach (image im in images)
            {
                ImageInfo nImageInfo = new ImageInfo(im);
                result.Add(nImageInfo);
            }
            return result;
        }

        static List<image> GetImagesForCategory(tourcategory cat)
        {
            TourContext db = new TourContext();
            List<image> result = (from image in db.images where image.IdTourCategory == cat.IdTourCategory select image).ToList<image>();
            return result;
        }
        static List<image> GetImagesForTour(tour t)
        {
            TourContext db = new TourContext();
            List<image> result = (from image in db.images where image.IdTour == t.IdTour select image).ToList<image>();
            return result;
        }
        static List<image> GetImagesForCity(city c)
        {
            TourContext db = new TourContext();
            List<image> result = (from image in db.images where image.IdCity == c.IdCity select image).ToList<image>();
            return result;
        }

        string GetFileByString(image im)
        {
            Image image = Image.FromFile(im.Path);
            Encoding enc = Encoding.Default;
            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
            image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] b = memoryStream.ToArray();
            return enc.GetString(b);
        }
    }
}