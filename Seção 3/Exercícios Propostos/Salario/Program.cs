using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            int ID, hora;
            float valor, salario;

            ID = int.Parse(Console.ReadLine());
            hora = int.Parse(Console.ReadLine());
            valor = float.Parse(Console.ReadLine());
            Console.WriteLine("NÚMERO = " + ID);
            salario = hora * valor;
            Console.WriteLine("SALÁRIO = U$ " + salario.ToString("F2"));
            Console.ReadKey();
        }
    }
}
