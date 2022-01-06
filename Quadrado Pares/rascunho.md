using System; 

namespace DIO{
    class QuadradoPares {

        static void Main(string[] args)
        { 
            int i;
            double q;
            int n = int.Parse(Console.ReadLine());
            for(i=1; i<=n; i++)
            {
                if (n % 2 == 0)
                {
                    q = Math.Pow(i, 2);
                    System.Console.WriteLine("{0}^2 = {1}", i, q);
                }
                //System.Console.WriteLine("{0}^2 = {1}", i, q);
            }
            //System.Console.WriteLine("{0}^2 = {1}", i, q);

        }

    }
}
