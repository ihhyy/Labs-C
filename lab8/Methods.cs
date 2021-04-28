using System;
namespace lab9
{
    class Method
    {
        public string currentPlace;
        public int num;

        public delegate void Handler1(double _num);
        public delegate void Handler2(string _currentPlace);
        public delegate double Example(double res);

        public event Handler1 Reducing;
        public event Handler2 Moving;

        public void Reduce(double reducer)
        {
            Example ex = result => result /= reducer;

            if (ex(num) >= 1)
            {
                Reducing(ex(num));
            }

            else
            {
                throw new Exception("number is too low");
            }
        }

        public void Move(string _currentPlace)
        {
            if (_currentPlace != currentPlace)
            {
                Moving(_currentPlace);
            }

            else
            {
                throw new Exception("bases have the same value");
            }
        }

        public void Message(double num)
        {
            Handler1 h1 = str => Console.WriteLine(str);
            h1(num);
        }

        public void Message(string value)
        {
            Handler2 h2 = str => Console.WriteLine(str);
            h2(value);
        }

        public static void RemoveCommas1(string obj)
        {
            obj = obj.Replace(" ", "");
            Console.WriteLine(obj);
        }

        public static void RemoveSpaces1(string obj)
        {
            obj = obj.Replace(",", "");

            Console.WriteLine(obj);
        }

        public static string RemoveSpaces2(string obj)
        {
            return obj = obj.Replace(" ", "");
        }
    }
}

