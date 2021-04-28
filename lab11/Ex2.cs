using System;
using System.Collections.Generic;
using System.Text;

namespace lab12
{
    class Ex2
    {
        public int Version { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public Ex2(int _Version, string _Name, string _Type)
        {
            Version = _Version;
            Name = _Name;
            Type = _Type;
        }
    }
}
