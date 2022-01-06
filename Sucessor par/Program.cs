using System;
class DIO
{
    static void Main(String[] args)
    {
        int x = int.Parse(Console.ReadLine());
        
        if (x % 2 == 0)
        {
            x = x + 2;
            //System.Console.WriteLine(x);
        }
        else
        {
            x = x + 1;
            //System.Console.WriteLine(x);
        }
        System.Console.WriteLine(x);
    }
}
