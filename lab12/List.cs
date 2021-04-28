using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace lab13
{
    [Serializable]
    public class List
    {
        public void Create(int[] arr)
        {
            var list = new List<int[]>();
            list.Add(arr);

            XmlSerializer formatter = new XmlSerializer(typeof(List<int[]>));
            using (FileStream fs = new FileStream("Example.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, list);
            }
        }
    }
}
