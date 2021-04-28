using System;

namespace train2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[,] arr = { { 20, 15 }, { 54, 1 }, { 1, 60 } };
                var vector = new Vector(arr);
                vector.Sum(2);
                vector.Multiply(3);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}