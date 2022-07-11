using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;


namespace Exersice1 {
    class Program {
        static void Main(string[] args) {

            var file = "sample.xml";
            
            Exercise1_1(file);
            Console.WriteLine();
            Exercise1_2(file);
            Console.WriteLine();
            Exercise1_3(file);
            Console.WriteLine();

            var newfile = "sports.xml";
            Exercise1_4(file, newfile);

            var text = File.ReadAllText(newfile);
            Console.WriteLine(text);
        }

        private static void Exercise1_1(string file) {
            var xdoc = XDocument.Load("sample.xml");
            var BallSports = xdoc.Root.Elements().Select(x => new {
                Name = (string)x.Element("name"),
                Members = (string)x.Element("teammembers")
            });
            foreach(var date in BallSports) {
                Console.WriteLine("{0} {1}",date.Name,date.Members);
            }
        }
        private static void Exercise1_2(string file) {
            var xdoc = XDocument.Load("sample.xml");
            var BallSports = xdoc.Root.Elements().Select(x => new {
                FirstPlayed = (string)x.Element("firstplayed"),
                Kanji = (string)x.Element("name").Attribute("kanji")
            });
            foreach (var date in BallSports.OrderBy(x => x.FirstPlayed)) {
                Console.WriteLine("{0} ({1})",date.FirstPlayed,date.Kanji);
            }
        }
        private static void Exercise1_3(string file) {
            var xdoc = XDocument.Load("sample.xml");
            var BallSports = xdoc.Root.Elements().Select(x => new {
                Name = (string)x.Element("name"),
                Members = (string)x.Element("teammembers")
            }).OrderByDescending(x => int.Parse(x.Members)).First();
            Console.WriteLine("{0} ({1}人)", BallSports.Name, BallSports.Members);
        }

        private static void Exercise1_4(string file, string newfile) {
            var element = new XElement("ballsports",
                          new XElement("name", "サッカーボール",
                          new XAttribute("kanji", "蹴球")),
                          new XElement("teammembers", "11"),
                          new XElement("firstplayed", "1863"));

            var xdoc = XDocument.Load(file); 
            xdoc.Root.Add(element);
            xdoc.Save(newfile);
           
          








        }
    }
}
