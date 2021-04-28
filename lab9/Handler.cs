using System;
using System.Collections.Generic;
using System.Text;

namespace lab10
{
    class Handler : Ilists<Cars<int, string>>
    {
        List<Cars<int, string>> full_list = new List<Cars<int, string>>();

        public void Add(Cars<int, string> Cars)
        {
            full_list.Add(Cars);
        }

        public void Display()
        {
            foreach (var list in full_list)
            {
                list.Display();
            }
        }

        public void Remove(Cars<int, string> Cars)
        {
            full_list.Remove(Cars);
        }

        public void Search(Cars<int, string> Cars)
        {
            for(int i = 0; i < full_list.Count; i++)
            {
                if (full_list[i].Equals(Cars))
                {
                    Console.WriteLine($"index of that dictionary is {i}");
                }
            }
        }

    }
}
