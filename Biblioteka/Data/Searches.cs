using System;
using System.Linq;

namespace Biblioteka.Data
{
    public class Searches
    {
        public static void SearchYear(BiblDbContext context)
        {
            int year = 1966;
            var res = context.Gramatas.
                Where(g => g.Gads == year);
            
            Console.WriteLine("Nosaukums\t\tGads\tLappuses");
            foreach (var gr in res)
            {
                Console.WriteLine(gr.Nosaukums + "\t" + gr.Gads + "\t" + gr.Lpp);
            }
            Console.WriteLine();
        }

        public static void SearchAuthors(BiblDbContext context)
        {
            string autors = "A. Konans Doils";
            
            var res = (from gr in context.Gramatas
                    join a in context.Autors
                        on gr.AutoraId equals a.Id
                       where a.Vards == autors
                       select new
                       {
                          Id = gr.Id,
                          Nosaukums = gr.Nosaukums,
                          AutId = gr.AutoraId,
                          Gads = gr.Gads,
                          Lpp = gr.Lpp,
                          Vards = a.Vards
                       }).ToList();

            Console.WriteLine("Nosaukums\t\tGads\tAutors");
            foreach (var r in res)
            {
                Console.WriteLine(r.Nosaukums + "\t" + r.Gads + "\t" + r.Vards);
            }
            Console.WriteLine();
        }
    }
}
