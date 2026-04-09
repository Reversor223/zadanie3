using System;
using System.IO;
using System.Xml.Serialization;

namespace zadanie3
{ 
    public partial class xmlclass : Form2
{
        [Serializable]
        public class Person
        {
            public string Imie { get; set; }
            public string Nazwisko { get; set; }
            public int Wiek { get; set; }
            public Person(string firstname, string lastname, int age)
            {
                Imie = firstname;
                Nazwisko = lastname;
                Wiek = age;
            }
            public void SerializeToXML(string fileName)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Person));
                using (TextWriter writer = new StreamWriter(fileName))
                {
                    serializer.Serialize(writer, this);
                }
                Console.WriteLine("Obiekt zostal zserializowany do pliku XML");
            }

            public static Person DeserializeFromXML(string fileName)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Person));
                using (TextReader reader = new StreamReader(fileName))
                {
                    Person person = (Person)serializer.Deserialize(reader);
                    Console.WriteLine("Obiekt zostal odczytany z pliku XML.");
                    return person;
                }
            }
            public void DisplayInfo()
            {
                Console.WriteLine("Imie: " + Imie);
                Console.WriteLine("Nazwisko: " + Nazwisko);
                Console.WriteLine("Wiek: " + Wiek);
            }
           /* public static void Main(string[] args)
            {
                Person person1 = new Person("Jan", "Kowalski", 30);
                person1.SerializeToXML("person.xml");
                Person person2 = Person.DeserializeFromXML("person.xml");

                if (person2 == null)
                {
                    person2.DisplayInfo();
                }
            }*/
        }
    }
}
