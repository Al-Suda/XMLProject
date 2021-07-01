using System;
using System.Threading;
using System.Xml;
namespace XMLProject
{

    class Program
    {
        static void Main(string[] args)
        {
            Thread writeThread = new Thread(CreateXMLFiles);
            Thread readThread = new Thread(ReadXMLFile);
            writeThread.Start();
            writeThread.Join();
            readThread.Start();
            readThread.Join();
        }

        private static void SetColor(ConsoleColor textColor) => Console.ForegroundColor = textColor;
        private static XmlElement CreateXmlElement(XmlDocument xmldoc, string name) => xmldoc.CreateElement(name);
        private static XmlText CreateXmlText(XmlDocument xmldoc, string name) => xmldoc.CreateTextNode(name);
        static void CreateXMLFiles()
        {
            XmlDocument xmldoc = new XmlDocument();
            XmlElement team = xmldoc.CreateElement("team");
            xmldoc.AppendChild(team);
            var leader = CreateXmlElement(xmldoc, "leader");
            team.AppendChild(leader).AppendChild(CreateXmlText(xmldoc, "Ahmed Alzubaidi"));
            var member1 = CreateXmlElement(xmldoc, "member");
            team.AppendChild(member1).AppendChild(CreateXmlText(xmldoc, "Fatimah Alqhtany"));
            var member2 = CreateXmlElement(xmldoc, "member");
            team.AppendChild(member2).AppendChild(CreateXmlText(xmldoc, "Maryam Alraddadi"));
            var member3 = CreateXmlElement(xmldoc, "member");
            team.AppendChild(member3).AppendChild(CreateXmlText(xmldoc, "Abdulaziz Alasmari"));
            var member4 = CreateXmlElement(xmldoc, "member");
            team.AppendChild(member4).AppendChild(CreateXmlText(xmldoc, "Mansour Aldundur"));
            xmldoc.Save(@"team.xml");
        }

        static void ReadXMLFile()
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(@"team.xml");
            Console.Clear();
            foreach (XmlNode node in xmldoc.DocumentElement.ChildNodes)
            {
                SetColor(ConsoleColor.Cyan);
                Console.WriteLine(" {0} : ",node.Name);
                SetColor(ConsoleColor.Yellow);
                Console.WriteLine("  {0} ",node.InnerText);
            }
        }

    }
}
