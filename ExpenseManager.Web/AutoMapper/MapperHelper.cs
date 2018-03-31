using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;

namespace ExpenseManager.Web.AutoMapper
{
    public static class MapperHelper
    {
        public static U To<T, U>(T from, U to)
        {
            return Mapper.Map<T, U>(from, to);
        }

        public static T To<T>(this Object from)
        {
            return Mapper.Map<T>(from);
        }
    }
}