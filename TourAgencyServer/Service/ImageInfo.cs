﻿using System;
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
        public image ImageElem { get; set; }
        public string ImageFile { get; set; }

        public ImageInfo(image im)
        {
            ImageElem = im;
            ImageFile = GetFileByString(im);
        }

        public static List<ImageInfo> GetImagesForElem(string typeElem, int idElem)
        {
            TourContext db = new TourContext();
            List<ImageInfo> result = new List<ImageInfo>();
            switch (typeElem)
            {
                case "category":
                    {
                        tourcategory cat = db.tourcategories.Find(idElem);
                        List<image> images = GetImagesForCategory(cat);
                        foreach (image im in images)
                        {
                            ImageInfo nImageInfo = new ImageInfo(im);
                            result.Add(nImageInfo);
                        }
                        break;
                    }
            }
            return result;
        }

        static List<image> GetImagesForCategory(tourcategory cat)
        {
            TourContext db = new TourContext();
            List<image> result = (from image in db.images where image.IdTourCategory == cat.IdTourCategory select image).ToList<image>();
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