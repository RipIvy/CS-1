using System;
using System.Linq;
using System.IO;
using System.Xml.Linq;

namespace ConvertCSVtoXML
{
    class Program
    {
        static void Converter(string fileNameOpen, string fileNameSave)
        {
            string[] lines = File.ReadAllLines(fileNameOpen);
            string[] headers = { "FirstName", "SecondName", "University", "Faculty", "Department", "Age", "Course", "Group", "City" };

            var xml = new XElement("Students",
               lines.Where((line, index) => index > 0).Select(line => new XElement("StudentInfo",
                  line.Split(',').Select((column, index) => new XElement(headers[index], column)))));

            xml.Save(fileNameSave);
        }

        static void Main(string[] args)
        {
            Converter("..\\..\\students.csv", "..\\..\\students.xml");

            Console.WriteLine("Работа программы завершена!");
            Console.ReadKey();
        }
    }
}
