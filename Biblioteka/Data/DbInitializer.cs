using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteka.Models;

namespace Biblioteka.Data
{
    public class DbInitializer
    {
        public static void Initialize(BiblDbContext context)
        {
            context.Database.EnsureCreated();
            
            if (context.Gramatas.Any())
            {
                return;   
            }

            var gramata = new Gramata[]
            {
                new Gramata{AutorsId=1, Gads = 1942, Nosaukums = "Zemes atjaunotāji", Lpp = 443},
                new Gramata{AutorsId=2, Gads = 1969, Nosaukums = "Jaunības gadi", Lpp=580},
                new Gramata{AutorsId=2, Gads = 1966, Nosaukums = "Cepurnieka pils", Lpp = 400},
                new Gramata{AutorsId=3, Gads = 1978, Nosaukums = "Noslēpumu sala", Lpp=555},
                new Gramata{AutorsId=4, Gads = 1991, Nosaukums = "Sarkanais pūķis", Lpp=458},
                new Gramata{AutorsId=5, Gads = 1974, Nosaukums = "Mēness akmens", Lpp=523},
                new Gramata{AutorsId=6, Gads = 1967, Nosaukums = "Montesumas meita",Lpp=339},
                new Gramata{AutorsId=7, Gads = 1989, Nosaukums = "Marakota bezdibenis", Lpp=346},
                new Gramata{AutorsId=8, Gads = 2014, Nosaukums = "Šāntarāms", Lpp=943},
                new Gramata{AutorsId=7, Gads = 1966, Nosaukums = "Etīde purpura toņos",Lpp = 400},
                new Gramata{AutorsId=9, Gads = 2013, Nosaukums = "Citādie", Lpp=412},
                new Gramata{AutorsId=10, Gads = 2007, Nosaukums = "Madonnas saraksts", Lpp=429},
                new Gramata{AutorsId=11, Gads = 2010, Nosaukums = "Tanatonauti", Lpp=637},
                new Gramata{AutorsId=12, Gads = 2008, Nosaukums = "Fināla teorija", Lpp=430}
            };
            foreach (Gramata g in gramata)
            {
                context.Gramatas.Add(g);
            }
            context.SaveChanges();

            var aut = new Autors[]
            {
                new Autors{AutorsId=1, Vards = "Aleksandrs Grīns"},
                new Autors{AutorsId=2, Vards = "A. Dž. Kronins"},
                new Autors{AutorsId=3, Vards = "Žils Verns"},
                new Autors{AutorsId=4, Vards = "Franss G. Bengtsons"},
                new Autors{AutorsId=4, Vards = "Franss G. Bengtsons"},
                new Autors{AutorsId=5, Vards = "V. Kolinss"},
                new Autors{AutorsId=6, Vards = "Raiders Hegards"},
                new Autors{AutorsId=7, Vards = "A. Konans Doils"},
                new Autors{AutorsId=8, Vards = "Gregorijs Deivids Robertss"},
                new Autors{AutorsId=9, Vards = "Veronika Rota"},
                new Autors{AutorsId=10, Vards = "Makss Forens"},
                new Autors{AutorsId=11, Vards = "Bernārs Verbērs"},
                new Autors{AutorsId=12, Vards = "Marks Elperts"}
            };
            foreach (Autors a in aut)
            {
                context.Autors.Add(a);
            }
            context.SaveChanges();
        }
    }
}
    
