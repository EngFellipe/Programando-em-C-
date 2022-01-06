using System; 

namespace Dio{
    class QuadradoPares {

        static void Main(string[] args)
        { 
            int i;
            double q;
            System.Console.Write("Digite um número inteiro: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(i=1; i<=n; i++)
            {
                if (i % 2 == 0)
                {
                    q = Math.Pow(i, 2);
                    System.Console.WriteLine("{0}^2 = {1}", i, q);
                        
                }
            }

        }

    }
}
