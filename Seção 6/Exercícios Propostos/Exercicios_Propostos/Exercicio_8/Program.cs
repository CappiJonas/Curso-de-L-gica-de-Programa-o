using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            string[] sexo;
            double[] altura;

            N = int.Parse(Console.ReadLine());
            sexo = new string[N];
            altura = new double[N];

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                altura[i] = double.Parse(s[0]);
                sexo[i] = s[1];
            }

            double menorAltura = 10.0;
            for (int i = 0; i < N; i++)
            {
                if (menorAltura > altura[i])
                {
                    menorAltura = altura[i];
                }
            }
            Console.WriteLine($"Menor Altura = {menorAltura}");

            double maiorAltura = 0.0;
            for (int i = 0; i < N; i++)
            {
                if (maiorAltura < altura[i])
                {
                    maiorAltura = altura[i];
                }
            }
            Console.WriteLine($"Maior Altura = {maiorAltura}");

            int cont = 0;
            double somaAlturaMulheres = 0.0;
            double media = 0.0;
            for (int i = 0; i < N; i++)
            {
                if (sexo[i] == "F")
                {
                    somaAlturaMulheres = somaAlturaMulheres + altura[i];
                    cont++;
                }
            }
            media = somaAlturaMulheres / cont;
            Console.WriteLine($"Média das alturas das mulheres = {media.ToString("F2")}");

            int contHomem = 0;
            for (int i = 0; i < N; i++)
            {
                if (sexo[i] == "M")
                {
                    contHomem++;
                }
            }
            Console.WriteLine($"Número de Homens = {contHomem}");
            Console.ReadKey();
        }
    }
}
