using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Drawing;

using CS_EVE_XML_API;

namespace EVE_XML_API_Test
{
    class Program
    {

        static void Main(string[] args)
        {
            string keyID = "3890775";
            string vCode = "8w2EoSi0UyXXiSaagZnUN1ep2B6bkcFFCNd5CBsMnE7X5CHB3iHqYxEGubzBWP3c";
            string characterID = "91810030";
            XmlDocument xmldoc = new XmlDocument();
            string typeid = "42";

            Console.Clear();
            xmldoc = EVEXMLAPI.getInstance().Kills();
            Console.Write(xmldoc.InnerXml);
        }
    }
}
