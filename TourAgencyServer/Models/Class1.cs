using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace TourAgencyServer.Models
{
    public class TourDataBaseInit
    {
        protected MySqlConnection conn;
        public TourDataBaseInit()
        {
            conn = new MySqlConnection("server=localhost;UserId=root;Password=root;database=travelagency;");
        }
    }
}