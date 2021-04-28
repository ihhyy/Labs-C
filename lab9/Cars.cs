using System;
using System.Collections.Generic;
using System.Text;

namespace lab10
{
    public class Cars<TKey, TValue> : IList<TKey, TValue>
    {
        public delegate void ChangeCollection();
        public event ChangeCollection Adding;
        public event ChangeCollection Removing;


        Dictionary<TKey, TValue> cars = new Dictionary<TKey, TValue>();

        public void Add(TKey key, TValue value)
        {
            cars.Add(key, value);
            if(Adding != null)
            {
                Adding();
            }
                
        }


        public void Display()
        {
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }

        public void Remove(TKey key)
        {
            cars.Remove(key);
            if (Removing != null)
            {
                Removing();
            }
        }

        public void Search(TKey key)
        {
            if (cars.ContainsKey(key))
            {
                Console.WriteLine(cars[key]);
            }

            else
            {
                throw new Exception("not found");
            }
        }

        public void Change()
        {
            Console.WriteLine("data changed");
        }
    }
}
