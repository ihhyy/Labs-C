using System;
using System.IO;
using System.Text.Json;
using System.Runtime.Serialization.Formatters.Binary;

namespace lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            var ex = new Example { Language = "qwer", Tool = "qqqq" };

            //SerializeMethods.ConvertToBinnary(ex);
            //SerializeMethods.ConvertToJSON(ex);
            //SerializeMethods.ConvertToXML(ex);
            //SerializeMethods.ConvertToSoap(ex);

            //SerializeMethods.RestoredFromBinnary("Example.dat");
            //SerializeMethods.RestoredFromBSoap("Example.soap");
            //SerializeMethods.RestoredFromXML(ex);
            //SerializeMethods.RestoredFromJSON();

            //var l1 = new List();
            //int[] arr = { 1, 2, 3, 4, 5 };
            //l1.Create(arr);
        }
    }
}
