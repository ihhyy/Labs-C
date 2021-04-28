using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Runtime.Serialization.Formatters.Binary;

namespace lab13
{
    [Serializable]
    public class Example
    {
        public string Language { get; set; }
        public string Tool { get; set; }

        public Example()
        {

        }

        public virtual void Display()
        {
            Console.WriteLine($"Used + {Tool}");
            Console.WriteLine($"Used + {Language}");
        }
    }

    class Virus : Example
    {
        public int harm;

        public Virus(string _t, int _h)
        {
            Harm = _h;
        }

        public int Harm
        {
            get { return harm; }
            set { harm = value; }
        }

        public override void Display()
        {
            Console.WriteLine($"Harm is + {harm}");
        }
    }

    sealed class Game : Example
    {
        public string genre;

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public Game(string _t, string g)
        {
            genre = g;
        }

        public void _Display()
        {
            Console.WriteLine($"{genre}");
        }
    }
}
