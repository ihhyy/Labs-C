using System;
using System.Text.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;
using System.Xml.Serialization;


namespace lab13
{
    static class SerializeMethods
    {
        public static void ConvertToBinnary(Example ex)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("Example.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, ex);
            }
        }

        public static void RestoredFromBinnary(string link)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream($"{link}", FileMode.OpenOrCreate))
            {
                Example restoredEx = (Example)formatter.Deserialize(fs);
            }
        }


        public static void ConvertToJSON(Example ex)
        {
            string jsonString = JsonSerializer.Serialize<Example>(ex);
            File.WriteAllText("Example.json", jsonString);
        }

        public static void RestoredFromJSON(string link)
        {
            var file = File.ReadAllText($"{link}");
            var exr = JsonSerializer.Deserialize<Example>(file);
            Console.WriteLine(exr);
        }

        public static void ConvertToSoap(Example ex)
        {
            SoapFormatter formatter = new SoapFormatter();

            using (FileStream fs = new FileStream("Example.soap", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, ex);
                Console.WriteLine(formatter);
            }
        }

        public static void RestoredFromBSoap(string link)
        {
            SoapFormatter formatter = new SoapFormatter();
            using (FileStream fs = new FileStream($"{link}", FileMode.OpenOrCreate))
            {
                Example restoredEx = (Example)formatter.Deserialize(fs);
                Console.WriteLine(restoredEx.Tool);
            }
        }

        public static void ConvertToXML(Example ex)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Example));

            using (FileStream fs = new FileStream("example.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, ex);
            }
        }

        public static void RestoredFromXML(Example ex)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Example));
            using (FileStream fs = new FileStream("example.xml", FileMode.OpenOrCreate))
            {
                Example newPerson = (Example)formatter.Deserialize(fs);
            }
        }
    }
}
