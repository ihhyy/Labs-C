using System;
using System.Collections;

namespace train3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = { 1, 2, 3, -1,-2,-29 };
            int[] a2 = { 1, 2, 3, -4 };
            Arr arr = new Arr();
            arr.DeleteNum(a1);
        }
    }

    class Arr
    {

        public void Mult(int[] arr1, int[] arr2)
        {
            if (arr1.Length == arr2.Length)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    arr1[i] *= arr2[i];
                    Console.WriteLine(arr1[i]);
                }

            }
        }

        public void Mult(int[] arr)
        {
            bool status = true;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    status = false;
                }

                else
                {
                    status = true;
                }
            }

            Console.WriteLine(status);
        }

        public void Int(int[] arr)
        {
            Console.WriteLine(arr.Length);
        }

        public void Int(int[] arr1, int[] arr2)
        {
            if(arr1.Length == arr2.Length)
            {
                for(int i = 0; i < arr1.Length; i++)
                {
                    if(arr1[i] > arr2[i])
                    {
                        Console.WriteLine("a > b");
                    }

                    else if(arr1[i] == arr2[i])
                    {
                        Console.WriteLine("a = b");
                    }

                    else
                    {
                        Console.WriteLine("a < b");
                    }
                }
            }

            else
            {
                Console.WriteLine("error");
            }
            
        }

        public void Check(int[] arr, int num)
        {
            int q = Array.IndexOf(arr, num);

            if(q > -1)
            {
                Console.WriteLine("found");
            }
        }

        public void DeleteNum(int[] arr)
        {
            ArrayList list = new ArrayList(arr);
            int listLength = list.Count;
            int counter = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] < 0)
                {
                    counter++;
                }
            }
            list.Sort();
            list.RemoveRange(0, counter);

            for(int q = 0; q < listLength - counter; q++)
            {
                Console.WriteLine(list[q]);
            }
        }
    }
}
