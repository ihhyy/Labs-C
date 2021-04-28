using System;

namespace lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Reflector.GetMethods()); 
            //Reflector.GetName();
            //Reflector.GetConstructors();
            //Reflector.GetChosenMethods(typeof(int), "Ex1");
            //Reflector.Invoke();
            Object[] values = { "q" };
            Console.WriteLine(Creator.Info(values)); 
        }
    }
}
