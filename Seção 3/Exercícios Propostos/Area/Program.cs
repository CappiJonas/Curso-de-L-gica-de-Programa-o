using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, pi, triangulo, circulo, trapezio, quadrado, retangulo;

            pi = 3.14159; 
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());

            triangulo = A * C / 2.0;
            circulo = pi * Math.Pow(C, 2.0);
            trapezio = ((A + B) * C) / 2.0;
            quadrado = Math.Pow(B, 2.0);
            retangulo = A * B;

            Console.WriteLine("Triangulo: " + triangulo.ToString("F3"));
            Console.WriteLine("Círculo: " + circulo.ToString("F3"));
            Console.WriteLine("Trapézio: " + trapezio.ToString("F3"));
            Console.WriteLine("Quadrado: " + quadrado.ToString("F3"));
            Console.WriteLine("Retângulo: " + retangulo.ToString("F3"));
            Console.ReadKey();
        }
    }
}
