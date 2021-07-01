using System;
using System.Xml;
namespace XMLProject
{

    class Program
    {
        static void Main(string[] args)
        {
          CreateXMLFiles();
      
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


            xmldoc.Save(@"C:\Users\win\Desktop\team.xml");
            Console.WriteLine(xmldoc.InnerText);
        }
       
    }
}
