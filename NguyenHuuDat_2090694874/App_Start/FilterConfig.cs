﻿using System.Web;
using System.Web.Mvc;

namespace NguyenHuuDat_2090694874
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
