using System;
using System.Collections.Generic;

namespace train6
{
    class Program
    {
        static void Main(string[] args)
        {
            Q q = new Q();
            q.Add("txt", 123, "qqq");
            q.Add("game", 321, "www"); 
            q.Add("game", 111, "eee");
        } 
    }


    abstract class Computer
    {
        List <Soft> software = new List<Soft>();

        public void Get(string name, int version)
        {
            int num = -1;
            for(int i = 0; i < software.Count; i++)
            {
                if(software[i].Name == name && software[i].Version == version)
                {
                    num = i;
                }
            }
            
            if(num == 0)
            {
                Console.WriteLine(123);
            }

            else
            {
                Errors err = new Errors();
                err.Error();
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

        public void Add(string type,  int version, string name)
        {
            software.Add(new Soft() { Version = version, Name = name, Type = type });
        }

        public void Delete(string name, int version)
        {
            for(int i = 0; i < software.Count; i++)
            {
                if(software[i].Name == name && software[i].Version == version)
                {
                    software.RemoveAt(i);
                }
            }
        }

        public void Display()
        {
            for(int i = 0; i < software.Count; i++)
            {
                Console.WriteLine($" name: {software[i].Name} version: {software[i].Version} type: {software[i].Type}");
            }
        }
    }

    class Soft
    {
        public int Version { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }

    class Errors
    {
        public void Error()
        {
            Console.WriteLine("object not found");
        }
    }

    class Q : Computer
    {

    }
}
