using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            string[] mercadoria;
            double[] precoCompra, precoVenda;

            N = int.Parse(Console.ReadLine());
            mercadoria = new string[N];
            precoCompra = new double[N];
            precoVenda = new double[N];

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                mercadoria[i] = s[0];
                precoCompra[i] = double.Parse(s[1]);
                precoVenda[i] = double.Parse(s[2]);
            }

            double[] lucro = new double[N];
            for (int i = 0; i < N; i++)
            {
                lucro[i] = (precoVenda[i] - precoCompra[i]) / precoCompra[i] * 100;
            }

            int contMenos = 0;
            int cont = 0;
            int contMais = 0;
            for (int i = 0; i < N; i++)
            {
                if (lucro[i] < 10)
                {                   
                    contMenos++;                 
                }
                else if (lucro[i] >= 10.0 && lucro[i] <= 20.0)
                {

                    cont++;
                    
                }
                else if (lucro[i] > 20.0)
                {
                    contMais++;
                }
            }
            Console.WriteLine($"Lucro abaixo de 10%: {contMenos}");
            Console.WriteLine($"Lucro entre 10% e 20%: {cont}"); 
            Console.WriteLine($"Lucro acima de 20%: {contMais}");

            double somaCompra = 0.0;
            for (int i = 0; i < N; i++)
            {
                somaCompra = somaCompra + precoCompra[i];
            }
            Console.WriteLine($"Valor total da compra: {somaCompra.ToString("F2")}");

            double somaVenda = 0.0;
            for (int i = 0; i < N; i++)
            {
                somaVenda = somaVenda + precoVenda[i];
            }
            Console.WriteLine($"Valor total de venda: {somaVenda.ToString("F2")}");

            double lucroTotal = somaVenda - somaCompra;
            Console.WriteLine($"Lucro Total : {lucroTotal.ToString("F2")}");
            Console.ReadKey();
        }
    }
}
