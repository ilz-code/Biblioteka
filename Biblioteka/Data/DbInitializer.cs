using System.Linq;
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
                new Gramata{AutoraId=1, Gads = 1942, Nosaukums = "Zemes atjaunotāji", Lpp = 443},
                new Gramata{AutoraId=2, Gads = 1969, Nosaukums = "Jaunības gadi", Lpp=580},
                new Gramata{AutoraId=2, Gads = 1966, Nosaukums = "Cepurnieka pils", Lpp = 400},
                new Gramata{AutoraId=3, Gads = 1978, Nosaukums = "Noslēpumu sala", Lpp=555},
                new Gramata{AutoraId=4, Gads = 1991, Nosaukums = "Sarkanais pūķis", Lpp=458},
                new Gramata{AutoraId=5, Gads = 1974, Nosaukums = "Mēness akmens", Lpp=523},
                new Gramata{AutoraId=6, Gads = 1967, Nosaukums = "Montesumas meita",Lpp=339},
                new Gramata{AutoraId=7, Gads = 1989, Nosaukums = "Marakota bezdibenis", Lpp=346},
                new Gramata{AutoraId=8, Gads = 2014, Nosaukums = "Šāntarāms", Lpp=943},
                new Gramata{AutoraId=7, Gads = 1966, Nosaukums = "Etīde purpura toņos",Lpp = 400},
                new Gramata{AutoraId=9, Gads = 2013, Nosaukums = "Citādie", Lpp=412},
                new Gramata{AutoraId=10, Gads = 2007, Nosaukums = "Madonnas saraksts", Lpp=429},
                new Gramata{AutoraId=11, Gads = 2010, Nosaukums = "Tanatonauti", Lpp=637},
                new Gramata{AutoraId=12, Gads = 2008, Nosaukums = "Fināla teorija", Lpp=430}
            };
            foreach (Gramata g in gramata)
            {
                context.Gramatas.Add(g);
            }
            context.SaveChanges();

            var aut = new Autors[12];

            aut[0] = new Autors { Vards = "Aleksandrs Grīns" };
            aut[1] = new Autors { Vards = "A. Dž. Kronins" };
            aut[2] = new Autors { Vards = "Žils Verns" };
            aut[3] = new Autors { Vards = "Franss G. Bengtsons" };
            aut[4] = new Autors { Vards = "V. Kolinss" };
            aut[5] = new Autors { Vards = "Raiders Hegards" };
            aut[6] = new Autors { Vards = "A. Konans Doils" };
            aut[7] = new Autors { Vards = "Gregorijs Deivids Robertss" };
            aut[8] = new Autors { Vards = "Veronika Rota" };
            aut[9] = new Autors { Vards = "Makss Forens" };
            aut[10] = new Autors { Vards = "Bernārs Verbērs" };
            aut[11] = new Autors { Vards = "Marks Elperts" };
            
            for (int i=0; i<12; i++)
            {
                context.Autors.Add(aut[i]);
                context.SaveChanges();
            }
            
        }
    }
}
    
