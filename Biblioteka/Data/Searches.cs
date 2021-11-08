using System;
using System.Linq;
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
                "JOIN Autors On Autors.Id = Gramatas.AutoraId " +
                "WHERE Autors.Vards = 'A. Konans Doils'");

            Console.WriteLine(res);
        }
    }
}
