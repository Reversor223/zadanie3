using System;
using System.IO;
using System.Xml.Serialization;

namespace zadanie3
{


    [Serializable]
    public class Person
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Wiek { get; set; }

        public Person()
        {

        }
    }
}