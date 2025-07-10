using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblio_EM
{
    public class SVentas_EM
    {
        string[] Articulos = new string[] { "Auriculares", "Fuente Poder", "Mouse", "Teclado", "Tarjeta Grafica","Procesador","Monitor"};
        int[,] MatrizArticulos = new int[7, 7];
        string[] Art = new string[7];
        public void MostrarArticulos() 
        {
            for (int i = 0; i < Articulos.Length; i++)
            {
                Art[i]= Articulos[i];
            }
        }
        public void GVentasLunes() 
        {
            int columna = 0;
            Random r = new Random();
            Console.WriteLine("LUNES");
            for (int i = 0; i < MatrizArticulos.GetLength(0); i++)
            {
                int VentasDia = r.Next(0,201);
                Console.WriteLine(Art[i] + " :" + VentasDia);
                MatrizArticulos[i, columna] = VentasDia;
                Thread.Sleep(150);
            }
        }
        public void GVentasMartes()
        {
            int columna = 1;
            Random r = new Random();
            Console.WriteLine("MARTES");
            for (int i = 0; i < MatrizArticulos.GetLength(0); i++)
            {
                int VentasDia = r.Next(0, 201);
                Console.WriteLine(Art[i] + " :" + VentasDia);
                MatrizArticulos[i, columna] = VentasDia;
                Thread.Sleep(150);
            }
        }
        public void GVentasMiercoles()
        {
            int columna = 2;
            Random r = new Random();
            Console.WriteLine("MIERCOLES");
            for (int i = 0; i < MatrizArticulos.GetLength(0); i++)
            {
                int VentasDia = r.Next(0, 201);
                Console.WriteLine(Art[i] + " :" + VentasDia);
                MatrizArticulos[i, columna] = VentasDia;
                Thread.Sleep(150);
            }
        }
        public void GVentasJueves()
        {
            int columna = 3;
            Random r = new Random();
            Console.WriteLine("JUEVES");
            for (int i = 0; i < MatrizArticulos.GetLength(0); i++)
            {
                int VentasDia = r.Next(0, 201);
                Console.WriteLine(Art[i] + " :" + VentasDia);
                MatrizArticulos[i, columna] = VentasDia;
                Thread.Sleep(150);
            }
        }
        public void GVentasViernes()
        {
            int columna = 4;
            Random r = new Random();
            Console.WriteLine("VIERNES");
            for (int i = 0; i < MatrizArticulos.GetLength(0); i++)
            {
                int VentasDia = r.Next(0, 201);
                Console.WriteLine(Art[i] + " :" + VentasDia);
                MatrizArticulos[i, columna] = VentasDia;
                Thread.Sleep(150);
            }
        }
        public void GVentasSabado()
        {
            int columna = 5;
            Random r = new Random();
            Console.WriteLine("SABADO");
            for (int i = 0; i < MatrizArticulos.GetLength(0); i++)
            {
                int VentasDia = r.Next(0, 201);
                Console.WriteLine(Art[i] + " :" + VentasDia);
                MatrizArticulos[i, columna] = VentasDia;
                Thread.Sleep(150);
            }
        }
        public void GVentasDomingo()
        {
            int columna = 6;
            Random r = new Random();
            Console.WriteLine("DOMINGO");
            for (int i = 0; i < MatrizArticulos.GetLength(0); i++)
            {
                int VentasDia = r.Next(0, 201);
                Console.WriteLine(Art[i] + " :" + VentasDia);
                MatrizArticulos[i, columna] = VentasDia;
                Thread.Sleep(150);
            }
        }
        public void MostrarTabla() 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                                     ANALISIS SEMANAL DE VENTA DE ARTICULOS   +Elvis Mosqueira+");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Artículos\tLUNES\t\tMARTES\t\tMIÉRCOLES\tJUEVES\t\tVIERNES\t\tSÁBADO\t\tDOMINGO");
            Console.ForegroundColor = ConsoleColor.Gray;
            for (int i = 0; i < MatrizArticulos.GetLength(0); i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                if (Articulos[i].Length < 8)
                {
                    Console.Write(Articulos[i] + "\t\t");
                }
                else
                {
                    Console.Write(Articulos[i] + "\t");
                }
                Console.ForegroundColor = ConsoleColor.Gray;
                for (int j = 0; j < MatrizArticulos.GetLength(1); j++)
                {
                    Console.Write(MatrizArticulos[i, j] + "\t\t");
                }
                Console.WriteLine();
            }
        }
        public void SumaSemanal()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("░░░░░░░░░VENTA TOTAL POR SEMANA░░░░░░░░░░");
            Console.ForegroundColor = ConsoleColor.Gray;
            for (int i = 0; i < MatrizArticulos.GetLength(0); i++)
            {
                int suma = 0;
                for (int j = 0; j < MatrizArticulos.GetLength(1); j++)
                {
                    suma += MatrizArticulos[i, j];
                }
                if (Articulos[i].Length >= 9)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(Articulos[i] + "\t");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(Articulos[i] + "\t\t");
                    Console.ResetColor();
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(suma);
                Console.ResetColor();
            }
            Console.WriteLine();
        }
        public void VentaMinyMax()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("░░░VENTA MINIMA Y MAXIMA POR ARTICULO░░░");
            Console.ForegroundColor = ConsoleColor.Gray;
            for (int i = 0; i < MatrizArticulos.GetLength(0); i++)
            {
                int minimo = MatrizArticulos[i, 0];
                int maximo = MatrizArticulos[i, 0];
                for (int j = 1; j < MatrizArticulos.GetLength(1); j++)
                {
                    if (MatrizArticulos[i, j] < minimo)
                    {
                        minimo = MatrizArticulos[i, j];
                    }

                    if (MatrizArticulos[i, j] > maximo)
                    {
                        maximo = MatrizArticulos[i, j];
                    }
                }
                if (Articulos[i].Length >= 9) //para alinear
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(Articulos[i] + "\t");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(Articulos[i] + "\t\t");
                }
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Min: " + minimo + "\tMax: " + maximo);
                Console.ResetColor();

            }
        }
        public void SumaPorDia()
        {
            string[] dias = { "LUNES", "MARTES", "MIERCOLES", "JUEVES", "VIERNES", "SABADO", "DOMINGO" };
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("░░░░░░░░░SUMA DE VENTAS POR DIA░░░░░░░░░");
            Console.ForegroundColor = ConsoleColor.Gray;
            int sumatotal = 0;
            for (int j = 0; j < MatrizArticulos.GetLength(1); j++)
            {
                int suma = 0;
                for (int i = 0; i < MatrizArticulos.GetLength(0); i++)
                {
                    suma += MatrizArticulos[i, j];
                }
                if (dias[j].Length >= 9)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(dias[j] + "\t");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(dias[j] + "\t\t");
                }
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(suma);
                Console.ResetColor();
                sumatotal += suma;
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("SUMA TOTAL:\t");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(sumatotal);
            Console.ResetColor();
            Console.WriteLine();

        }
        public void Promedio()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("░░░░░░░░░░░░PROMEDIO SEMANAL░░░░░░░░░░░░");
            Console.ForegroundColor = ConsoleColor.Gray;
            for (int i = 0; i < MatrizArticulos.GetLength(0); i++)
            {
                float suma = 0;
                for (int j = 0; j < MatrizArticulos.GetLength(1); j++)
                {
                    suma += MatrizArticulos[i, j];
                }
                float promedio = suma / 7;

                if (Articulos[i].Length >= 9)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(Articulos[i] + "\t");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(Articulos[i] + "\t\t");
                }
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(Articulos[i]+":"+ promedio);
                Console.ResetColor();
            }
            Console.WriteLine();
        }

    }
}
