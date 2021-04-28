using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] _months =
            {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };

            var months = new Months(_months);
            //months.SortMonthsByLength(6);
            //months.SortMonthsByABC();
            //months.SelectWinterMonths();
            //months.SelectSummerMonths();

            //months.Method(6);


            var list = new List<Vector>();
            int[] arr1 = { 5551, 2, 3, 900, 123, 54 };
            int[] arr2 = { 1, 29, -3, 0, 7 };
            int[] arr3 = { 1, -2, 3, 60 };
            int[] arr4 = { 1, 2, 38 };

            var v1 = new Vector(arr1, true, arr1.Length);
            var v2 = new Vector(arr2, true, arr2.Length);
            var v3 = new Vector(arr3, true, arr3.Length);
            var v4 = new Vector(arr4, true, arr4.Length);

            list.Add(v1);
            list.Add(v2);
            list.Add(v3);
            list.Add(v4);

            var Methods = new VectorMethods();

            //Methods.Sqrt(list);
            //Methods.Check(list);
            //Methods.MaxVector(list);
            //Methods.SortLenghts(list);
            //Methods.SearchForNegative(list);
            //Methods.Sort(list);
            //Methods.Example(list, list);

        }


    }
}
