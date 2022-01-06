using System; 

namespace DIO{
    class SequenciaIJ {

        static void Main(string[] args) { 
        
        int i;
        int j;
        for(i=1; i<=9; i++)
            {
                if (i%2 != 0)
                {
                    for(j=7; j>=5; j--)    //escreva seu código nos espaços em branco
                    {
                        Console.WriteLine("I={0} J={1}", i, j);
                    }
                }
            }
        }

    }
}
