using System;

namespace lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            //var user1 = new User(10, "qqq");
            //var user2 = new User(15, "www");
            //var user3 = new User(20, "eee");
            //var user4 = new User(25, "rrr");
            Action<string> _RemoveCommas1;
            Func<string, string> _RemoveCommas2;

            //user1.Moving += user1.Message;
            //user1.Reducing += user1.Message;

            //user2.Moving += user2.Message;

            //user3.Reducing += user3.Message;

            //user1.Reduce(3);
            //user1.Move("www");


            _RemoveCommas1 = Method.RemoveCommas1;
            _RemoveCommas1("qw e r");
            _RemoveCommas1 = Method.RemoveSpaces1;
            _RemoveCommas1("qw,e,r");

            _RemoveCommas2 = Method.RemoveSpaces2;
            Console.WriteLine(_RemoveCommas2("qw e r"));
        }
    }

}
