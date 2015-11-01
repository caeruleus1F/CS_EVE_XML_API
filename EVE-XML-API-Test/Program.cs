using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

using CS_EVE_XML_API;

namespace EVE_XML_API_Test
{
    class Program
    {
        Program p = new Program();

        static void Main(string[] args)
        {
            string keyID = "3890775";
            string vCode = "8w2EoSi0UyXXiSaagZnUN1ep2B6bkcFFCNd5CBsMnE7X5CHB3iHqYxEGubzBWP3c";
            string characterID = "91810030";
            XmlDocument xmldoc = new XmlDocument();

            Console.Clear();
            xmldoc = EVEXMLAPI.getInstance().AccountBalance(keyID, vCode, characterID);
            Console.Write(xmldoc.InnerXml);

            Console.Clear();
            xmldoc = EVEXMLAPI.getInstance().AccountStatus(keyID, vCode);
            Console.Write(xmldoc.InnerXml);

            Console.Clear();
            xmldoc = EVEXMLAPI.getInstance().APIKeyInfo(keyID, vCode);
            Console.Write(xmldoc.InnerXml);

            Console.Clear();
            xmldoc = EVEXMLAPI.getInstance().AssetList(keyID, vCode, characterID);
            Console.Write(xmldoc.InnerXml);

            Console.Clear();//
            xmldoc = EVEXMLAPI.getInstance().CalendarEventAttendees(keyID, vCode, characterID, "");
            Console.Write(xmldoc.InnerXml);

            Console.Clear();
            xmldoc = EVEXMLAPI.getInstance().CallList();
            Console.Write(xmldoc.InnerXml);

            Console.Clear();
            xmldoc = EVEXMLAPI.getInstance().Characters(keyID, vCode);
            Console.Write(xmldoc.InnerXml);

            Console.Clear();
            xmldoc = EVEXMLAPI.getInstance().CharacterSheet(keyID, vCode, characterID);
            Console.Write(xmldoc.InnerXml);

            Console.Clear();
            xmldoc = EVEXMLAPI.getInstance().ContactList(keyID, vCode, characterID);
            Console.Write(xmldoc.InnerXml);

            Console.Clear();
            xmldoc = EVEXMLAPI.getInstance().ContactNotifications(keyID, vCode, characterID);
            Console.Write(xmldoc.InnerXml);

            Console.Clear();
            xmldoc = EVEXMLAPI.getInstance().ContractBids(keyID, vCode, characterID);
            Console.Write(xmldoc.InnerXml);

            Console.Clear();
            xmldoc = EVEXMLAPI.getInstance().ContractItems(keyID, vCode, characterID, "");
            Console.Write(xmldoc.InnerXml);

            Console.Clear();
            xmldoc = EVEXMLAPI.getInstance().Contracts(keyID, vCode, characterID);
            Console.Write(xmldoc.InnerXml);

            Console.Clear();
            xmldoc = EVEXMLAPI.getInstance().FacWarStats(keyID, vCode, characterID);
            Console.Write(xmldoc.InnerXml);

            Console.Clear();
            xmldoc = EVEXMLAPI.getInstance().IndustryJobs(keyID, vCode, characterID);
            Console.Write(xmldoc.InnerXml);

            Console.Clear();
            xmldoc = EVEXMLAPI.getInstance().KillLog(keyID, vCode, characterID);
            Console.Write(xmldoc.InnerXml);

            Console.Clear();//
            xmldoc = EVEXMLAPI.getInstance().Locations(keyID, vCode, characterID, "");
            Console.Write(xmldoc.InnerXml);

            Console.Clear();
            xmldoc = EVEXMLAPI.getInstance().MailingLists(keyID, vCode, characterID);
            Console.Write(xmldoc.InnerXml);

            Console.Clear();
            xmldoc = EVEXMLAPI.getInstance().MailMessages(keyID, vCode, characterID);
            Console.Write(xmldoc.InnerXml);

            Console.Clear();//
            xmldoc = EVEXMLAPI.getInstance().MailBodies(keyID, vCode, characterID, "");
            Console.Write(xmldoc.InnerXml);

            Console.Clear();
            xmldoc = EVEXMLAPI.getInstance().MarketOrders(keyID, vCode, characterID);
            Console.Write(xmldoc.InnerXml);

            Console.Clear();
            xmldoc = EVEXMLAPI.getInstance().Medals(keyID, vCode, characterID);
            Console.Write(xmldoc.InnerXml);

            Console.Clear();
            xmldoc = EVEXMLAPI.getInstance().Notifications(keyID, vCode, characterID);
            Console.Write(xmldoc.InnerXml);

            Console.Clear();//
            xmldoc = EVEXMLAPI.getInstance().NotificationTexts(keyID, vCode, characterID, "");
            Console.Write(xmldoc.InnerXml);

            Console.Clear();
            xmldoc = EVEXMLAPI.getInstance().Research(keyID, vCode, characterID);
            Console.Write(xmldoc.InnerXml);

            Console.Clear();
            xmldoc = EVEXMLAPI.getInstance().SkillInTraining(keyID, vCode, characterID);
            Console.Write(xmldoc.InnerXml);

            Console.Clear();
            xmldoc = EVEXMLAPI.getInstance().SkillQueue(keyID, vCode, characterID);
            Console.Write(xmldoc.InnerXml);

            Console.Clear();
            xmldoc = EVEXMLAPI.getInstance().Standings(keyID, vCode, characterID);
            Console.Write(xmldoc.InnerXml);

            Console.Clear();
            xmldoc = EVEXMLAPI.getInstance().UpcomingCalendarEvents(keyID, vCode, characterID);
            Console.Write(xmldoc.InnerXml);

            Console.Clear();
            xmldoc = EVEXMLAPI.getInstance().WalletJournal(keyID, vCode, characterID);
            Console.Write(xmldoc.InnerXml);

            Console.Clear();
            xmldoc = EVEXMLAPI.getInstance().WalletTransactions(keyID, vCode, characterID);
            Console.Write(xmldoc.InnerXml);
        }
    }
}
