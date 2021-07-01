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
        static void CreateXMLFiles()
        {
            XmlDocument xmldoc = new XmlDocument();
            XmlElement root = xmldoc.CreateElement("team");
            xmldoc.AppendChild(root);
            
            XmlElement leader = xmldoc.CreateElement("leader");
            XmlText leaderName = xmldoc.CreateTextNode("Ahmed Alzubaidi");
            root.AppendChild(leader);
            leader.AppendChild(leaderName);
            XmlElement memberOne = xmldoc.CreateElement("member");
            XmlText memberNameOne = xmldoc.CreateTextNode("Fatimah Alqhtany");
            root.AppendChild(memberOne);
            memberOne.AppendChild(memberNameOne);
            XmlElement memberTwo = xmldoc.CreateElement("member");
            XmlText memberNameTwo = xmldoc.CreateTextNode("Maryam Alraddadi");
            root.AppendChild(memberTwo);
            memberTwo.AppendChild(memberNameTwo);
            XmlElement memberTree = xmldoc.CreateElement("member");
            XmlText memberNameTree = xmldoc.CreateTextNode("Abdulaziz Alasmari");
            root.AppendChild(memberTree);
            memberTree.AppendChild(memberNameTree);
            XmlElement memberForth = xmldoc.CreateElement("member");
            XmlText memberNameForth = xmldoc.CreateTextNode("Mansour Aldundur");
            root.AppendChild(memberForth);
            memberForth.AppendChild(memberNameForth);


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
