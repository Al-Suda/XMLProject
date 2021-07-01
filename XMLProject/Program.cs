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
            XmlElement element1 = xmldoc.CreateElement("member");
            XmlText text1 = xmldoc.CreateTextNode("Fatimah");
            XmlAttribute Attribute1 = xmldoc.CreateAttribute("first-name");
            Attribute1.Value = "Fatimah";
            root.AppendChild(element1);
            element1.AppendChild(text1);
            xmldoc.Save(@"C:\Users\win\Desktop\TeamMembers.xml");
            Console.WriteLine(xmldoc.InnerText);
        }
       
    }
}
