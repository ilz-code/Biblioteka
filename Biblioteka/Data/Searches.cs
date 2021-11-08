using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteka.Models;
using Microsoft.EntityFrameworkCore;

namespace Biblioteka.Data
{
    public class Searches
    {
        public static string SearchYear(BiblDbContext context)
        {
            int year = 1966;
            var res = context.Gramatas.
                Where(g => g.Gads == year).FirstOrDefault();
            return res.Nosaukums;
            //FromSqlRaw(
            //"SELECT * FROM Gramatas" +
             //   "WHERE ")
        }

        public static List<Gramata> SearchAuthors(BiblDbContext context)
        {
            string autors;
            List<Gramata> res = null;
            //context.Gramatas;
            return res;
        }
    }
}
