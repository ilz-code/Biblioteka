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
        public static void SearchYear(BiblDbContext context)
        {
            int year = 1966;
            var res = context.Gramatas.
                Where(g => g.Gads == year);
            
            Console.WriteLine("Nosaukums\tGads\tLappuses");
            foreach (var gr in res)
            {
                Console.WriteLine(gr.Nosaukums + "\t" + gr.Gads + "\t" + gr.Lpp);
            }
            Console.WriteLine();
        }

        public static void SearchAuthors(BiblDbContext context)
        {
            string autors;
            var res = context.Gramatas.FromSqlRaw(
                "SELECT Gramatas.Nosaukums as Nosaukums, Autors.Vards as Vards " +
                "FROM Gramatas " +
                "JOIN Autors On Autors.Id = Gramatas.AutoraId" +
                "WHERE Autors.Vards = 'A. Konans Doils'");
            Console.WriteLine(res);
            Console.WriteLine();
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
