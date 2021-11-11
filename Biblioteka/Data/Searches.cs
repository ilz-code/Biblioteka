using System;
using System.Linq;
using Biblioteka.Models;

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
            Console.WriteLine("Nosaukums" + new string(' ', 21) + "Autors" + new string(' ', 24) + "Gads   Lappuses");
            foreach (var r in res)
            {
                int n1 = 30 - r.Nosaukums.Length;
                int n2 = 30 - r.Vards.Length;
                Console.WriteLine(r.Nosaukums + new string(' ', n1) + r.Vards + new string(' ', n2) + r.Gads + "   " + r.Lpp);
            }
            Console.WriteLine();
        }

        public static void SearchAuthors(BiblDbContext context)
        {
            Console.WriteLine("Autors: ");
            string autors = Console.ReadLine();
            foreach (Autors aut in context.Autors)
            {
                if (aut.Vards.Contains(autors))
                    autors = aut.Vards;
            }
            
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

            Console.WriteLine("Nosaukums" + new string(' ', 21) + "Autors" + new string(' ', 24) + "Gads   Lappuses");
            foreach (var r in res)
            {
                int n1 = 30 - r.Nosaukums.Length;
                int n2 = 30 - r.Vards.Length;
                Console.WriteLine(r.Nosaukums + new string(' ', n1) + r.Vards + new string(' ', n2) + r.Gads + "   " + r.Lpp);
            }
            Console.WriteLine();
        }
    }
}
