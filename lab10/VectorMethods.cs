using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace lab11
{
    class VectorMethods
    {
        public void Check(List <Vector> list)
        {
            var vectors = from v1 in list
                          select v1.arr;

            var nums = (vectors.Where(v1 => v1.Min() == 0)).Count();

            Console.WriteLine(nums);
        }

        public IEnumerable<int[]> Sqrt(List<Vector> list)
        {
            var row = from v in list
                          orderby v.arr.Sum(v => Math.Sqrt(v))
                          select v.arr;
            return row;
        }

        public IEnumerable<int> MaxVector(List<Vector> list)
        {
            var row = from v in list
                      orderby v.arr.Sum()
                      select v.arr.Max();
            return row;
        }

        public void SortLenghts(List<Vector> list)
        {
            var row = from v in list
                      where v.arr.Length == 3 || v.arr.Length == 5 || v.arr.Length == 7
                      select v.arr;

            foreach(int[] v1 in row)
            {
                for(int i = 0; i < v1.Length; i++)
                {
                    Console.WriteLine(v1[i]);
                }
            } 
        }

        public int[] SearchForNegative(List<Vector> list)
        {
            var vectors = from v1 in list
                          select v1.arr;

            var nums = (vectors.Where(v1 => v1.Min() < 0)).First();
            return nums;
        }

        public IEnumerable<int[]> Sort(List<Vector> list)
        {
            var sorted = from s in list
                         orderby s.arr.Length
                         select s.arr;

            return sorted;
        }

        public void Example(List<Vector> list1, List<Vector> list2)
        {
            var example = from ex in list1
                          where ex.arr.Length > 3
                          join l2 in list2 on ex.status equals l2.status
                          orderby ex.arr.Length
                          select ex.length; 
        }
    }
}
