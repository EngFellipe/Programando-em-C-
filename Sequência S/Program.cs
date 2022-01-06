using System;
class DIO
{
    static void Main(String[] args)
    {
        double c, S=0;
            for (double a = 1; a <= 100; a++)
            {
                c = (1 / a);
                S += c;
            }
            var x=Math.Round(S, 2);
            System.Console.WriteLine(x);
    }
}