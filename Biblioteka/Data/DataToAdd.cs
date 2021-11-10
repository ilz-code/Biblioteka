using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteka.Models;
using Microsoft.EntityFrameworkCore;

namespace Biblioteka.Data
{
    public class DataToAdd
    {
        public static void AditionalData(BiblDbContext context)
        {
            
            var aut = new Autors[]
            {
                new Autors{ Vards = "Aleksandrs Grīns"},
                new Autors{ Vards = "A. Dž. Kronins"},
                new Autors{ Vards = "Žils Verns"},
                new Autors{ Vards = "Franss G. Bengtsons"},
                new Autors{ Vards = "V. Kolinss"},
                new Autors{ Vards = "Raiders Hegards"},
                new Autors{ Vards = "A. Konans Doils"},
                new Autors{ Vards = "Gregorijs Deivids Robertss"},
                new Autors{ Vards = "Veronika Rota"},
                new Autors{ Vards = "Makss Forens"},
                new Autors{ Vards = "Bernārs Verbērs"},
                new Autors{ Vards = "Marks Elperts"}
            };
            
            foreach (Autors a in aut)
            {
                context.Autors.Add(a);
            }
            context.SaveChanges();
        }
    }
}
