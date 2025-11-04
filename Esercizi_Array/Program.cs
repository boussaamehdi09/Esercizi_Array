namespace Esercizi_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // es n:1
            int[] num = { 1, 54, 7, 4, 3 };
            for (int i = num.Length - 1; i >= 0; i--) 
            {
                Console.WriteLine("[" + num[i] + "]");
            }
            Console.WriteLine("-------------------------------------------");
            // es n:2
            int[] nP = { 1, 54, 7, 4, 3 };
            for (int i = 0; i < nP.length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("[" + nP[i] + "]");
                }
            }
            Console.WriteLine("-------------------------------------------");
            int[] nD = { 1, 54, 7, 4, 3 };
            for (int i = 0; i < nD.length; i++)
            {
                if (nD[i] % 2 == 1)
                {
                    Console.WriteLine("[" + nD[i] + "]");
                }
            }

        }
    }
}
