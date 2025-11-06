using Microsoft.Win32.SafeHandles;

namespace Esercizi_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // es n:1
            Console.WriteLine("----------------------es n:1----------------------");
            int[] num = { 1, 54, 7, 4, 3 };
            for (int i = num.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("[" + num[i] + "]");
            }
            Console.WriteLine("----------------------es n:2----------------------");
            // es n:2
            int[] nP = { 1, 54, 7, 4, 3 };
            for (int i = 0; i < nP.Length; i++)
            {
                if (nP[i] % 2 == 0)
                {
                    Console.WriteLine("[" + nP[i] + "]");
                }
            }
            // es n:3
            Console.WriteLine("----------------------es n:3----------------------");
            int[] nD = { 1, 54, 7, 4, 3 };
            for (int i = 0; i < nD.Length; i++)
            {
                if (nD[i] % 2 == 1)
                {
                    Console.WriteLine("[" + nD[i] + "]");
                }
            }
            // es n:6
            Console.WriteLine("----------------------es n:4----------------------");
            int[] v1 = { 1, 54, 7, 4, 3 };
            int x = 5, cMag = 0, cMin = 0;
            for (int i = 0; i < v1.Length; i++)
            {
                if (v1[i] <= x)
                {
                    cMin = cMin + 1;
                }
                else
                {
                    cMag = cMag + 1;
                }
            }
            int[] v2 = new int[cMin];
            int[] v3 = new int[cMag];
            int iMag = 0, iMin = 0;
            for (int i = 0; i < v1.Length; i++)
            {
                if (v1[i] < x)
                {
                    v2[iMin] = v1[i];
                    iMin = iMin + 1;
                }
                else
                {
                    v3[iMag] = v1[i];
                    iMag = iMag + 1;
                }
            }
            for (int i = 0; i < v2.Length; i++)
            {
                Console.WriteLine($"[{v2[i]}]");
            }
            Console.WriteLine("----");
            for (int i = 0; i < v3.Length; i++)
            {
                Console.WriteLine($"[{v3[i]}]");
            }
            // es n:medio
            Console.WriteLine("----------------------es n:medio----------------------");
            int[] vet1 = { 1, 2, 3, 4, 5 };
            int[] vet2 = { 6, 7, 8, 9, 10 };
            int[] vU = new int [vet1.Length + vet2.Length];

            for (int i = 0; i < vet1.Length; i++)
            {
               .
            }
            for (int i = 0; i < vet2.Length; i++)
            {
                .
            }
            for (int i = 0; i < vU.Length; i++)
            {
                .
            }
            // es n:facile
            Console.WriteLine("----------------------es n:facile----------------------");
            int[] vitt1 = { 1, 54, 7, 4, 3 };
            int sV = 0;
            int min = vitt1[0];
            int max = vitt1[0];
            int iMax = 0;
            int iMIn = 0;



        }
    }
}
