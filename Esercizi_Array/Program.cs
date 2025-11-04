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
                Console.WriteLine(num[i]);
            }
            Console.WriteLine("-------------------------------------------");
            // es n:2
            int[] num2 = { 1, 113, 4, 6, 7, 8, 100 };
            for(int a = 2; a <= 0; a++) 
            {
                Console.WriteLine(num2[a]);
            
            
            }
        }
    }
}
