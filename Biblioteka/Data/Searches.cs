using System;
using System.Linq;

namespace Biblioteka.Data
{
    public class Searches
    {
        public static void SearchYear(BiblDbContext context)
        {
            Console.WriteLine("Gads: ");
            int gads = Int32.Parse(Console.ReadLine());

            var res = (from gr in context.Gramatas
                join a in context.Autors
                    on gr.AutoraId equals a.Id
                where gr.Gads == gads
                select new
                {
                    Id = gr.Id,
                    Nosaukums = gr.Nosaukums,
                    AutId = gr.AutoraId,
                    Gads = gr.Gads,
                    Lpp = gr.Lpp,
                    Vards = a.Vards
                }).ToList();

            //var res = context.Gramatas.
            //    Where(g => g.Gads == gads);

            Console.WriteLine("Nosaukums\t\tAutors\tGads\tLappuses");
            foreach (var gr in res)
            {
                Console.WriteLine(gr.Nosaukums + "\t" + gr.Gads + "\t" + gr.Lpp);
            }
            Console.WriteLine();
        }

        public static void SearchAuthors(BiblDbContext context)
        {
            Console.WriteLine("Autors: ");
            string autors = Console.ReadLine();
            
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

            Console.WriteLine("Nosaukums\t\tAutors\tGads\tLpp");
            foreach (var r in res)
            {
                Console.WriteLine(r.Nosaukums + "\t" + r.Gads + "\t" + r.Vards);
            }
            Console.WriteLine();
        }
    }
}
