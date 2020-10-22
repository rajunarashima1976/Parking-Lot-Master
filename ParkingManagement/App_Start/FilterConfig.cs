﻿using System.Web;
using System.Web.Mvc;
using ParkingManagement.Core.Model;

namespace ParkingManagement
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new CustomActionFilter());
        }
    }
}
