using System;
using System.Collections.Generic;
using System.Text;

namespace Dio
{
    class Xenlongao
    {
        static void Main(string[] args)
        {
            //Fonte:https://github.hode.uk/shyoutarou/desafios-DIO/blob/master/Desafios/C%20Sharp/Programando%20em%20C%23/Xenlong%C3%A3o/solution..cs

            // System.Console.Write("Digite o número de testes: ");
            // var testes = int.Parse(Console.ReadLine());

            // for (int i = 0; i < testes; i++)
            // {
            //      System.Console.Write("Digite o número de esferas do dragão: ");
            //      var esferas = int.Parse(Console.ReadLine());

            //      System.Console.Write("Número de esferas que Kogu precisa encontrar: ");
            //      Console.WriteLine(esferas - Math.Floor(Math.Sqrt(esferas)));
            // }

            
            // int i;
            // double c =0;

            // System.Console.Write("Digite um número intero: ");
            // var num = int.Parse(Console.ReadLine());
            
            // for (i=1; i<(Math.Floor(Math.Sqrt(num)))+1; i++)
            //     {
            //         if(num%i == 0)
            //         {
            //             c += (num/i == i) ? 1 : 2;
            //         }
            //     }
           
            // System.Console.WriteLine("O número {0} possui {1} divisores.", num, c);
        

            int i, n;
            double y;
            double c = 0;

            System.Console.Write("Digite um número intero: ");
            var num = int.Parse(Console.ReadLine());
            
            for (n = 1; n <= num; n++)
            {
                c = 0;
                for (i=1; i<(Math.Floor(Math.Sqrt(n)))+1; i++)
                {
                    if(n%i == 0)
                    {
                        c += (n/i) == i ? 1 : 2;
                    }
                }
                System.Console.WriteLine("O número {0} possui {1} divisores.", n, c);
            }
        }
    }
}

