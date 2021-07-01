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

        private static XmlElement CreateXmlElement(XmlDocument xmldoc, string name)
        {
            return xmldoc.CreateElement(name);
        }

        private static XmlText CreateXmlText(XmlDocument xmldoc, string name)
        {
            return xmldoc.CreateTextNode(name);
        }

        static void CreateXMLFiles()
        {
            XmlDocument xmldoc = new XmlDocument();
            XmlElement root = xmldoc.CreateElement("team");
            xmldoc.AppendChild(root);

            var element = CreateXmlElement(xmldoc, "leader");
            root.AppendChild(element).AppendChild(CreateXmlText(xmldoc, "Ahmed Alzubaidi"));
            var element2 = CreateXmlElement(xmldoc, "member");
            root.AppendChild(element2).AppendChild(CreateXmlText(xmldoc, "Fatimah Alqhtany"));
            var element3 = CreateXmlElement(xmldoc, "member");
            root.AppendChild(element3).AppendChild(CreateXmlText(xmldoc, "Maryam Alraddadi"));
            var element4 = CreateXmlElement(xmldoc, "member");
            root.AppendChild(element4).AppendChild(CreateXmlText(xmldoc, "Abdulaziz Alasmari"));
            var element5 = CreateXmlElement(xmldoc, "member");
            root.AppendChild(element5).AppendChild(CreateXmlText(xmldoc, "Mansour Aldundur"));
            
            xmldoc.Save(@"team.xml");
            Console.WriteLine(xmldoc.InnerText);
        }
        static void ReadXMLFile()
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(@"team.xml");
            foreach (XmlNode node in xmldoc.DocumentElement.ChildNodes)
            {
                string element = node.Name;
                Console.WriteLine(element + ": ");
                string text = node.InnerText;
                Console.WriteLine(text);
            }
        }
       
    }
}
