using System;
using System.Collections.Generic;
using static lab10.Program;

namespace lab10
{

    public class Program
    {

        static void Main(string[] args)
        {
           
            var cars1 = new Cars<int, string>();

            cars1.Adding += cars1.Change;

            cars1.Add(1, "qqq");
            cars1.Add(2, "www");
            cars1.Add(3, "eee");

            var cars2 = new Cars<int, string>();
            cars2.Add(1, "qqq");
            cars2.Add(2, "www");
            cars2.Add(3, "eee");
            cars2.Display();
            cars2.Remove(2);
            cars2.Display();
            cars2.Search(3);

            var h1 = new Handler();
            h1.Add(cars1);
            h1.Add(cars2);
            h1.Display();
            h1.Search(cars1);



        }
    }
}
