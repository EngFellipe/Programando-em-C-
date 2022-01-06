using System; 

namespace DIO
{
    class VaiTerCopa
    {

        static void Main(string[] args) 
        {
            
            string str;
            while((str = Console.ReadLine())!= null)
            {
                if (str == "")
                {
                    System.Console.WriteLine("Digite um valor entre 0 e 100.");
                }
                else          //Escreva o seu código nos espaços em branco
                { 
                    int x = int.Parse(str);
                    if (x == 0)
                    {
                    Console.WriteLine("vai ter copa!"); 
                    }
                    else
                    {
                        Console.WriteLine("vai ter duas!");
                    }
                }
            }
                
        }

    }
}