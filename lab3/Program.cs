using System;

namespace train5
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations o = new Operations();
            o.Display("anime");
            Virus v = new Virus("anime", 9999);
            Operations op = new Operations();
            Sapper s = new Sapper("game_over");

            v.Display();
            op.Display("sum");
            s.DisplayGame("game_over");
        }
    }

    class Soft
    {
        public string language { get; set; }
        public int users { get; set; }
        public string functions { get; set; }

        public virtual void Display(string property)
        {
            Console.WriteLine(property);
        }

    }

    class Operations : Soft
    {
        public string calc;

        public string Calc
        {
            get { return calc; }
            set { calc = value; }
        }

        public override void Display(string calc)
        {
            Console.WriteLine(calc);
        }
    }

    interface ITextProcessor
    {
        string Text { get; }
        void File(string text);
    }

    class Word : ITextProcessor
    {
        string _text;
        public string Text { get { return _text; } }

        public void File(string text)
        {
            _text += text;
        }
    }

    abstract class Developer
    {
        private string tools;
        private string language;

        public string Language 
        {
            get {return language; }
            set { language = value; } 
        }

        public Developer(string t)
        {
            tools = t;
        }


        public virtual void Display()
        {
            Console.WriteLine($"Used + {tools}");
            Console.WriteLine($"Used + {Language}");
        }
    }

    class Virus : Developer
    {
        private int harm;

        public Virus(string _t, int _h) 
            : base(_t)
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

    sealed class Game : Developer
    {
        public string genre;

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public Game(string _t, string g) 
            : base(_t)
        {
            genre = g;
        }

        public void _Display()
        {
            Console.WriteLine($"{genre}");
        }
    }

    class Sapper : Developer
    {
        string g;
        public  Sapper(string game) : base(game)
        {
            g = game;
        }

        public void DisplayGame(string game)
        {
            Console.WriteLine(g);
        }
    }

}
