using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FA_S3_CALCULAR_AREA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ej1();
            Ej2();
            Ej3();
        }
        static void Ej1()//FA_S3_CALCULAR_ÁREA
        {
            Console.WriteLine("\nEjercicio 1");
            //Entrada
            Console.Write("Valor de a="); //pedir valor con write
            int a = int.Parse(Console.ReadLine());
            Console.Write("Valor de b=");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Valor de c=");
            int c = int.Parse(Console.ReadLine());
            //Proceso
            double semi = (a + b + c) / 2;
            double area = Math.Sqrt(semi * (semi - a) * (semi - b) * (semi - c));
            //Salida
            Console.WriteLine("El área es: " + area);
        }
        static void Ej2()//FA_S3_ESTRUCTURA_SECUENCIAL_VOLUMEN_CONO
        {
            Console.WriteLine("\nEjercicio 2");
            //Entrada
            Console.Write("Radio mayor= ");
            int r1=int.Parse(Console.ReadLine());
            Console.Write("Radio menor= ");
            int r2 = int.Parse(Console.ReadLine());
            Console.Write("Altura= ");
            int h = int.Parse(Console.ReadLine());
            //Proceso
            double s1 = Math.PI*Math.Pow(r1,2);
            double s2 = Math.PI * Math.Pow(r2, 2);
            double Vol = (h * (s1 + s2 + Math.Sqrt(s1 * s2)))/3;
            //Salida
            Console.WriteLine("El volumenen es:" + Vol);
            //345.423
        }
        static void Ej3()
        {
            //Entrada
            Console.Write("T1=");
            int t1=int.Parse(Console.ReadLine());
            Console.Write("T2=");
            int t2 = int.Parse(Console.ReadLine());
            Console.Write("T3=");
            int t3 = int.Parse(Console.ReadLine());
            Console.Write("EF=");
            int ef = int.Parse(Console.ReadLine());
            //Proceso
            double prom = prom = t1 * 0.1 + t2 * 0.2 + t3 * 0.3 + ef * 0.4;
            //Salida
        }
    }
}
