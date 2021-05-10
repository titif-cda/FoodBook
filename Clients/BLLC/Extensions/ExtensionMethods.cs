﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BLLC.Extensions
{
    public static class ExtensionMethods
    {

        public static string ToUriQuery(this object obj)
        {
            var properties = from p in obj.GetType().GetProperties()
                             where p.GetValue(obj, null) != null
                             select p.Name + "=" + HttpUtility.UrlEncode(p.GetValue(obj, null).ToString());
            return "?" + String.Join("&", properties.ToArray());
        }


    }
}
