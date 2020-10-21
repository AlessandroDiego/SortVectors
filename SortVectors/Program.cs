using System;

namespace SortVectors
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vettore;

            vettore = new int[10] { 4,-1,100,-85,4,6,77,-35,2,0};
            Array.Sort(vettore);
            int max = Massimo(vettore);
            Console.WriteLine("il valore massimo è: " + max);
            for (int i=0; i < vettore.Length; i++)
            {
                
                Console.Write(vettore[i] +" | ");
              
            }
            

            Console.ReadKey();
        }

        static int Massimo(int[] v)
        {
            return v[9];
        }
    }
}
