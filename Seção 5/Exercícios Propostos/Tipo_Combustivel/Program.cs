using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipo_Combustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int combustivel, contAlcool, contGasolina, contDiesel;

            Console.WriteLine("Muito obrigado");

            contAlcool = 0;
            contGasolina = 0;
            contDiesel = 0;
            combustivel = int.Parse(Console.ReadLine());

            while (combustivel != 4)
            {
                if (combustivel == 1)
                {
                    contAlcool = contAlcool + 1;
                    combustivel = int.Parse(Console.ReadLine());
                }
                else if (combustivel == 2)
                {
                    contGasolina = contGasolina + 1;
                    combustivel = int.Parse(Console.ReadLine());
                }
                else if (combustivel == 3)
                {
                    contDiesel = contDiesel + 1;
                    combustivel = int.Parse(Console.ReadLine());
                }
                else
                {
                    combustivel = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Álcool: " + contAlcool);
            Console.WriteLine("Gasolina: " + contGasolina);
            Console.WriteLine("Diesel: " + contDiesel);
            Console.ReadKey();
        }
    }
}
