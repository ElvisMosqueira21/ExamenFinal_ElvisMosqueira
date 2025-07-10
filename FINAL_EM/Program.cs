using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Biblio_EM;

namespace FINAL_EM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SVentas_EM misventas = new SVentas_EM();

            misventas.MostrarArticulos();
            misventas.GVentasLunes();
            Console.Clear();
            misventas.MostrarArticulos();
            misventas.GVentasMartes();
            Console.Clear();
            misventas.MostrarArticulos();
            misventas.GVentasMiercoles();
            Console.Clear();
            misventas.MostrarArticulos();
            misventas.GVentasJueves();
            Console.Clear();
            misventas.MostrarArticulos();
            misventas.GVentasViernes();
            Console.Clear();
            misventas.MostrarArticulos();
            misventas.GVentasSabado();
            Console.Clear();
            misventas.MostrarArticulos();
            misventas.GVentasDomingo();
            Console.Clear();
            misventas.MostrarTabla();
            Thread.Sleep(700);
            Console.WriteLine("=======================================");
            misventas.SumaSemanal();
            Thread.Sleep(700);
            Console.WriteLine("=======================================");
            misventas.VentaMinyMax();
            Thread.Sleep(700);
            Console.WriteLine("=======================================");
            misventas.SumaPorDia();
            Thread.Sleep(700);
            Console.WriteLine("=======================================");
            misventas.Promedio();

        }
    }
}
