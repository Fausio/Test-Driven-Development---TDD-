﻿using System.Web;
using System.Web.Mvc;

namespace Problema_de_Numeros_romanos_TDD
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}