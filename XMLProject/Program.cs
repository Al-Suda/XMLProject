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
            
            XmlElement member = xmldoc.CreateElement("member");
            XmlText memberName = xmldoc.CreateTextNode("Fatimah");
            root.AppendChild(member);
            member.AppendChild(memberName);
            
            xmldoc.Save(@"/Users/maryam/Desktop/team.xml");
            Console.WriteLine(xmldoc.InnerText);
        }
       
    }
}
