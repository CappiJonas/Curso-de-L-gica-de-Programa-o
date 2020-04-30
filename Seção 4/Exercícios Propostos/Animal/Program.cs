using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            string A, B, C;

            A = Console.ReadLine();
            B = Console.ReadLine();
            C = Console.ReadLine();
             
            if (A == "vertebrado")
            {
                if(B == "ave")
                {
                    if(C == "carnívoro")
                    {
                        Console.WriteLine("águia");
                    }
                    else if(C == "onívoro")
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else if(B == "mamífero")
                {
                    if(C == "onívoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else if(C == "herbívoro")
                    {
                        Console.WriteLine("vaca");
                    }
                }
                   
            }
            else if (A == "invertebrado")
            {
                if (B == "inseto")
                {
                    if (C == "hematófago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else if (C == "herbívoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else if (B == "anelídeo")
                {
                    if (C == "hematófago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else if(C == "onívoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
