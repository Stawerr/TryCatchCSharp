using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0; 
            bool flag = false;
            Console.WriteLine("Digite o montante:"); 
            do
            {
                try
                {
                    x = double.Parse(Console.ReadLine()); 
                    flag = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message); 
                }
            } while (!flag);
        }
    }
}
