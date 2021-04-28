using System;
using System.Collections.Generic;
using System.Text;

namespace lab12
{
    abstract class Ex1
    {
        string ex;

        public static int value1 = 5;
        public static int value2 = 55;

        public Ex1(string _ex)
        {
            ex = _ex;
        }

        List<Ex2> software = new List<Ex2>();

        public void Get(string name, int version)
        {
            int num = -1;
            for (int i = 0; i < software.Count; i++)
            {
                if (software[i].Name == name && software[i].Version == version)
                {
                    num = i;
                }
            }

            if (num == 0)
            {
                Console.WriteLine(123);
            }
        }

        public void Set(string name, string _name, int _version, string _type)
        {
            for (int i = 0; i < software.Count; i++)
            {
                if (software[i].Name == name)
                {
                    software[i].Name = _name;
                    software[i].Version = _version;
                    software[i].Type = _type;
                }
            }
        }

        public void Add(string type, int version, string name)
        {
            software.Add(new Ex2(version, name, type) { Version = version, Name = name, Type = type });
        }

        public void Delete(string name, int version)
        {
            for (int i = 0; i < software.Count; i++)
            {
                if (software[i].Name == name && software[i].Version == version)
                {
                    software.RemoveAt(i);
                }
            }
        }

        public void Display()
        {
            for (int i = 0; i < software.Count; i++)
            {
                Console.WriteLine($" name: {software[i].Name} version: {software[i].Version} type: {software[i].Type}");
            }
        }
    }
}
