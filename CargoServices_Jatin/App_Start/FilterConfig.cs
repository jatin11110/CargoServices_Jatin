﻿using System.Web;
using System.Web.Mvc;

namespace CargoServices_Jatin
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
