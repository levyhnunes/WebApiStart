using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiStart.Application.AutoMapper
{
    public static class AutoMapperHelper
    {
        public static R Map<T, R>(this T obj)
        {
            R result = Mapper.Map<R>(obj);
            return result;
        }

        public static IEnumerable<R> Map<T, R>(this IEnumerable<T> obj)
        {
            IEnumerable<R> result = Mapper.Map<IEnumerable<R>>(obj);
            return result;
        }

        public static List<R> MapToList<T, R>(this List<T> obj)
        {
            List<R> result = Mapper.Map<List<R>>(obj);
            return result;
        }
    }
}
