using System;
using System.Collections;
using System.Text;
using System.Linq;

namespace lab11
{
    class Methods
    {
        public string[] months;

        public Methods(string[] _months)
        {
            months = _months;
        }

        public void SortMonthsByLength(int num)
        {
            var sortedMonths = months.Where(m => m.Length < num);
            foreach (string m in sortedMonths)
            {
                Console.WriteLine(m);
            }
        }

        public void SortMonthsByABC()
        {
            var sortedMonths = from m in months
                               orderby m
                               select m;

            foreach (string m in sortedMonths)
            {
                Console.WriteLine(m);
            }
        }

        public void SelectWinterMonths()
        {
            var winter = from m in months
                         where m.StartsWith("Jan") || m.StartsWith("Feb") || m.StartsWith("Dec")
                         select m;
            foreach(string m in winter)
            {
                Console.WriteLine(m);
            }
        }

        public void SelectSummerMonths()
        {
            var winter = from m in months
                         where m.StartsWith("Jun") || m.StartsWith("Jul") || m.StartsWith("Aug")
                         select m;
            foreach (string m in winter)
            {
                Console.WriteLine(m);
            }
        }

        public void Method(int num)
        {
            var sortedMonths = from m in months
                               where m.Length == num && m.Length > 4 &&
                               m.StartsWith("Jan") || m.StartsWith("Feb") || m.StartsWith("Dec") ||
                               m.StartsWith("Jun") || m.StartsWith("Jul") || m.StartsWith("Aug")
                               orderby m
                               select m;

            foreach(string m in sortedMonths)
            {
                if (m.Contains("u"))
                {
                    Console.WriteLine(m);
                }  
            }
        }
    }
}
