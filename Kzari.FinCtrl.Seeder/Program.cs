using System;
using System.Linq;
using Kzari.Finctrl.Domain.Entities;
using Kzari.FinCtrl.Infra.Data;

namespace Kzari.FinCtrl.Seeder
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new FinCtrlContext();
            
            if(context.Categorias.Any(a => a.Nome == "Mercado"))
                context.Categorias.Add(new Categoria("Mercado"));
            context.Categorias.Add(new Categoria("Compras"));

            context.SaveChanges();

            Console.WriteLine("Hello World!");
        }
    }
}
