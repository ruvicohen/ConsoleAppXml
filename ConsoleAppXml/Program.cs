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
                XElement element = new XElement("item1",
                        new XElement("question", question),
                        new XElement("answer", answer));
                doc.;
                var node = xmlService.GetNodeByName("Data.Item1.answer");
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
