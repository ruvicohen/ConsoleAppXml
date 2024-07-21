using System.Xml;
using System.Xml.Linq;

namespace ConsoleAppXml
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            XMLService xmlService = new XMLService("data.xml");
            var doc = xmlService.ReadXML();
            Console.WriteLine(@"1.Create questions
                                2.Answer Questions");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine(@"
                                    - Type your question
                                    - Type the answer");
                string question = Console.ReadLine();
                string answer = Console.ReadLine();
                XmlElement item = doc.CreateElement("Item1");
                XmlElement question1 = doc.CreateElement("Question");
                question1.InnerText = question;
                XmlElement answer1 = doc.CreateElement("Answer");
                answer1.InnerText = answer;
                item.AppendChild(question1);
                item.AppendChild(answer1);
                doc.DocumentElement.AppendChild(item);
                doc.Save("data.xml");

                var node = xmlService.GetNodeByName("Data.Item1");
                Console.WriteLine(node.InnerText);


            }
            //else if (choice == "2") {

            //var node = xmlService.GetNodeByName("Data.Item.Answer");
            //node.InnerText = "lll";
            //Console.WriteLine(node.InnerText);
            //var foo = 0;
        }
    }
}
