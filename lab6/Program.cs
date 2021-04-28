using System;

namespace train7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Book c = new Book("www", 2000);

                Juornal j = new Juornal("eee", 2000);
                j.SetPages(8);
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    class Library
    {
        public int year;
        public string author;

        public string Author
        {
            get { return author; }
            set 
            { 
                if(value.Length <= 1)
                {
                    throw new Exception("name is too short");
                }

                else
                {
                    author = value;
                }
            }
        }

        public int Year
        {
            get { return year; }
            set 
            { 
                if(value < 1990)
                {
                    throw  new Exception("too old");
                }

                else
                {
                    year = value;
                }
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{Year} {Author}");
        }
    }

    class Book : Library
    {
        public int cost;

        public int Cost 
        {
            get { return cost; }
            set 
            { 
                if(value > 500)
                {
                    throw new Exception("too expersive");
                }
                else
                {
                    cost = value;
                }
            }
        }

        public Book(string author, int year)
        {
            Author = author;
            Year = year;
        }


        public void SetCost(int _cost)
        {
            Cost = _cost;
        }

        public new void ShowInfo()
        {
            Console.WriteLine($"{Year} {Author} {cost}");
        }
        
    }

    class Juornal : Library
    {
        public int pages;

        public int Pages
        {
            get { return pages; }
            set 
            {
                if(pages < 10)
                {
                    throw new Exception("too short");
                }

                else
                {
                    pages = value;
                }
            }
        }

        public Juornal(string author, int year)
        {
            Author = author;
            Year = year;
        }

        public void SetPages(int _pages)
        {
            Pages = _pages;
        }

        public new void ShowInfo()
        {
            Console.WriteLine($"{Year} {Author} {pages}");
        }

    }
}
