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

        public static void SearchAuthors(BiblDbContext context)
        {
            string autors;
            var res = context.Gramatas.FromSqlRaw(
                "SELECT * FROM Gramatas " +
                "JOIN Autors On Gramatas.AutoraId = Autors.Id " +
                "WHERE Autors.Vards = ");
            //var res = from g in context.Gramatas
            //    join a in context.Autors 
            //        on g.AutoraId equals a.Id into dept
            //    from department in dept.DefaultIfEmpty()
            //    select new
            //    {
            //        Nosaukums = g.Nosaukums,
            //        Autors = a.
            //        Gads = g.Gads,
            //        Lappuses = g.Lpp;
            //    };
            //Console.WriteLine("Employee Code\tEmployee Name\tDepartment Name");
            //foreach (var data in leftOuterJoin)
            //{
            //    Console.WriteLine(data.EmployeeCode + "\t\t" + data.EmployeeName + "\t" + data.DepartmentName);
            //}
            //context.Gramatas;
            //return res;
        }
    }
}
