using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Net;

namespace CS_EVE_XML_API
{
    /// <summary>
    /// Thread-safe singleton allows the user to interface with the EVE Online
    /// Developer API with a light-weight dynamically-linked library.
    /// </summary>
    public class EVEXMLAPI
    {
        static EVEXMLAPI _self = null;

        private EVEXMLAPI()
        {

        }

        public static EVEXMLAPI getInstance()
        {
            if (_self == null)
            {
                lock (new object())
                {
                    if (_self == null)
                    {
                        _self = new EVEXMLAPI();
                    }
                }
            }

            return _self;
        }

        /*
         * Account API Endpoints
         */

        public XmlDocument AccountStatus(string keyID, string vCode)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/account/AccountStatus.xml.aspx?")
                .Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode);

            try
            {
                web.Proxy = WebRequest.DefaultWebProxy;
                response = web.DownloadString(sb.ToString());
                xmldoc.LoadXml(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine("AccountStatus exception.");
            }

            return xmldoc;
        }

        public XmlDocument APIKeyInfo(string keyID, string vCode)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/account/APIKeyInfo.xml.aspx?")
                .Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode);

            try
            {
                web.Proxy = WebRequest.DefaultWebProxy;
                response = web.DownloadString(sb.ToString());
                xmldoc.LoadXml(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine("APIKeyInfo exception.");
            }

            return xmldoc;
        }

        public XmlDocument Characters(string keyID, string vCode)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/account/Characters.xml.aspx?")
                .Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode);

            try
            {
                web.Proxy = WebRequest.DefaultWebProxy;
                response = web.DownloadString(sb.ToString());
                xmldoc.LoadXml(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Characters exception.");
            }

            return xmldoc;
        }

        public XmlDocument CallList()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/api/CallList.xml.aspx");

            try
            {
                web.Proxy = WebRequest.DefaultWebProxy;
                response = web.DownloadString(sb.ToString());
                xmldoc.LoadXml(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine("CallList exception.");
            }

            return xmldoc;
        }

        /*
         * Character API Endpoints
         */

        public XmlDocument AccountBalance(string keyID, string vCode, string characterID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/AccountBalance.xml.aspx?")
                .Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode)
                .Append("&characterID=").Append(characterID);

            try
            {
                web.Proxy = WebRequest.DefaultWebProxy;
                response = web.DownloadString(sb.ToString());
                xmldoc.LoadXml(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine("AccountBalance exception.");
            }

            return xmldoc;
        }

        public XmlDocument AssetList(string keyID, string vCode, string characterID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/AssetList.xml.aspx?")
                .Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode)
                .Append("&characterID=").Append(characterID);

            try
            {
                web.Proxy = WebRequest.DefaultWebProxy;
                response = web.DownloadString(sb.ToString());
                xmldoc.LoadXml(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine("AssetList exception.");
            }

            return xmldoc;
        }

        public XmlDocument CalendarEventAttendees(string keyID, string vCode, string characterID, string eventID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/CalendarEventAttendees.xml.aspx?")
                .Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode)
                .Append("&characterID=").Append(characterID)
                .Append("&eventIDs=").Append(eventID);

            try
            {
                web.Proxy = WebRequest.DefaultWebProxy;
                response = web.DownloadString(sb.ToString());
                xmldoc.LoadXml(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine("CalendarEventAttendees exception.");
            }

            return xmldoc;
        }

        public XmlDocument CharacterSheet(string keyID, string vCode, string characterID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/CharacterSheet.xml.aspx?")
                .Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode)
                .Append("&characterID=").Append(characterID);

            try
            {
                web.Proxy = WebRequest.DefaultWebProxy;
                response = web.DownloadString(sb.ToString());
                xmldoc.LoadXml(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine("CharacterSheet exception.");
            }

            return xmldoc;
        }

        public XmlDocument ContactList(string keyID, string vCode, string characterID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/ContactList.xml.aspx?")
                .Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode)
                .Append("&characterID=").Append(characterID);

            try
            {
                web.Proxy = WebRequest.DefaultWebProxy;
                response = web.DownloadString(sb.ToString());
                xmldoc.LoadXml(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ContactList exception.");
            }

            return xmldoc;
        }

        public XmlDocument ContactNotifications(string keyID, string vCode, string characterID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/ContactNotifications.xml.aspx?")
                .Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode)
                .Append("&characterID=").Append(characterID);

            try
            {
                web.Proxy = WebRequest.DefaultWebProxy;
                response = web.DownloadString(sb.ToString());
                xmldoc.LoadXml(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ContactNotifications exception.");
            }

            return xmldoc;
        }

        public XmlDocument Contracts(string keyID, string vCode, string characterID, string contractID = null)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/Contracts.xml.aspx?")
                .Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode)
                .Append("&characterID=").Append(characterID);

            if (contractID != null)
            {
                sb.Append("&contractID=").Append(contractID);
            }

            try
            {
                web.Proxy = WebRequest.DefaultWebProxy;
                response = web.DownloadString(sb.ToString());
                xmldoc.LoadXml(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Contracts exception.");
            }

            return xmldoc;
        }

        public XmlDocument ContractItems(string keyID, string vCode, string characterID, string contractID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/ContractItems.xml.aspx?")
                .Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode)
                .Append("&characterID=").Append(characterID)
                .Append("&contractID=").Append(contractID);

            try
            {
                web.Proxy = WebRequest.DefaultWebProxy;
                response = web.DownloadString(sb.ToString());
                xmldoc.LoadXml(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ContractItems exception.");
            }

            return xmldoc;
        }

        public XmlDocument ContractBids(string keyID, string vCode, string characterID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/ContractBids.xml.aspx?")
                .Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode)
                .Append("&characterID=").Append(characterID);

            try
            {
                web.Proxy = WebRequest.DefaultWebProxy;
                response = web.DownloadString(sb.ToString());
                xmldoc.LoadXml(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ContractBids exception.");
            }

            return xmldoc;
        }

        public XmlDocument FacWarStats(string keyID, string vCode, string characterID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/FacWarStats.xml.aspx?")
                .Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode)
                .Append("&characterID=").Append(characterID);

            try
            {
                web.Proxy = WebRequest.DefaultWebProxy;
                response = web.DownloadString(sb.ToString());
                xmldoc.LoadXml(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine("FacWarStats exception.");
            }

            return xmldoc;
        }

        public XmlDocument IndustryJobs(string keyID, string vCode, string characterID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/IndustryJobs.xml.aspx?")
                .Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode)
                .Append("&characterID=").Append(characterID);

            try
            {
                web.Proxy = WebRequest.DefaultWebProxy;
                response = web.DownloadString(sb.ToString());
                xmldoc.LoadXml(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine("IndustryJobs exception.");
            }

            return xmldoc;
        }

        public XmlDocument KillLog(string keyID, string vCode, string characterID, string beforeKillID = null)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/KillLog.xml.aspx?")
                .Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode)
                .Append("&characterID=").Append(characterID);

            if (beforeKillID != null)
            {
                sb.Append("&beforeKillID=").Append(beforeKillID);
            }

            try
            {
                web.Proxy = WebRequest.DefaultWebProxy;
                response = web.DownloadString(sb.ToString());
                xmldoc.LoadXml(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine("KillLog exception.");
            }

            return xmldoc;
        }

        public XmlDocument Locations(string keyID, string vCode, string characterID, string IDs)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/Locations.xml.aspx?")
                .Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode)
                .Append("&characterID=").Append(characterID)
                .Append("&IDs=").Append(IDs);

            try
            {
                web.Proxy = WebRequest.DefaultWebProxy;
                response = web.DownloadString(sb.ToString());
                xmldoc.LoadXml(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Locations exception.");
            }

            return xmldoc;
        }

        public XmlDocument MailBodies(string keyID, string vCode, string characterID, string IDs)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/MailBodies.xml.aspx?")
                .Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode)
                .Append("&characterID=").Append(characterID)
                .Append("&ids=").Append(IDs);

            try
            {
                web.Proxy = WebRequest.DefaultWebProxy;
                response = web.DownloadString(sb.ToString());
                xmldoc.LoadXml(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine("MailBodies exception.");
            }

            return xmldoc;
        }

        public XmlDocument MailingLists(string keyID, string vCode, string characterID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/MailingLists.xml.aspx?")
                .Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode)
                .Append("&characterID=").Append(characterID);

            try
            {
                web.Proxy = WebRequest.DefaultWebProxy;
                response = web.DownloadString(sb.ToString());
                xmldoc.LoadXml(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine("MailingLists exception.");
            }

            return xmldoc;
        }

        public XmlDocument MailMessages(string keyID, string vCode, string characterID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/MailMessages.xml.aspx?")
                .Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode)
                .Append("&characterID=").Append(characterID);

            try
            {
                web.Proxy = WebRequest.DefaultWebProxy;
                response = web.DownloadString(sb.ToString());
                xmldoc.LoadXml(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine("MailMessages exception.");
            }

            return xmldoc;
        }

        public XmlDocument MarketOrders(string keyID, string vCode, string characterID, string orderID = null)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/MarketOrders.xml.aspx?")
                .Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode)
                .Append("&characterID=").Append(characterID);

            if (orderID != null)
            {
                sb.Append("&orderID=").Append(orderID);
            }

            try
            {
                web.Proxy = WebRequest.DefaultWebProxy;
                response = web.DownloadString(sb.ToString());
                xmldoc.LoadXml(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine("MarketOrders exception.");
            }

            return xmldoc;
        }

        public XmlDocument Medals(string keyID, string vCode, string characterID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/Medals.xml.aspx?")
                .Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode)
                .Append("&characterID=").Append(characterID);

            try
            {
                web.Proxy = WebRequest.DefaultWebProxy;
                response = web.DownloadString(sb.ToString());
                xmldoc.LoadXml(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Medals exception.");
            }

            return xmldoc;
        }

        public XmlDocument Notifications(string keyID, string vCode, string characterID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/Notifications.xml.aspx?")
                .Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode)
                .Append("&characterID=").Append(characterID);

            try
            {
                web.Proxy = WebRequest.DefaultWebProxy;
                response = web.DownloadString(sb.ToString());
                xmldoc.LoadXml(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Notifications exception.");
            }

            return xmldoc;
        }

        public XmlDocument NotificationTexts(string keyID, string vCode, string characterID, string IDs)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/NotificationTexts.xml.aspx?")
                .Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode)
                .Append("&characterID=").Append(characterID)
                .Append("&IDs=").Append(IDs);

            try
            {
                web.Proxy = WebRequest.DefaultWebProxy;
                response = web.DownloadString(sb.ToString());
                xmldoc.LoadXml(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine("NotificationTexts exception.");
            }

            return xmldoc;
        }

        public XmlDocument Research(string keyID, string vCode, string characterID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/Research.xml.aspx?")
                .Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode)
                .Append("&characterID=").Append(characterID);

            try
            {
                web.Proxy = WebRequest.DefaultWebProxy;
                response = web.DownloadString(sb.ToString());
                xmldoc.LoadXml(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Research exception.");
            }

            return xmldoc;
        }

        public XmlDocument SkillInTraining(string keyID, string vCode, string characterID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/SkillInTraining.xml.aspx?")
                .Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode)
                .Append("&characterID=").Append(characterID);

            try
            {
                web.Proxy = WebRequest.DefaultWebProxy;
                response = web.DownloadString(sb.ToString());
                xmldoc.LoadXml(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine("SkillInTraining exception.");
            }

            return xmldoc;
        }

        public XmlDocument SkillQueue(string keyID, string vCode, string characterID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/SkillQueue.xml.aspx?")
                .Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode)
                .Append("&characterID=").Append(characterID);

            try
            {
                web.Proxy = WebRequest.DefaultWebProxy;
                response = web.DownloadString(sb.ToString());
                xmldoc.LoadXml(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine("SkillQueue exception.");
            }

            return xmldoc;
        }

        public XmlDocument Standings(string keyID, string vCode, string characterID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/Standings.xml.aspx?")
                .Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode)
                .Append("&characterID=").Append(characterID);

            try
            {
                web.Proxy = WebRequest.DefaultWebProxy;
                response = web.DownloadString(sb.ToString());
                xmldoc.LoadXml(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Standings exception.");
            }

            return xmldoc;
        }

        public XmlDocument UpcomingCalendarEvents(string keyID, string vCode, string characterID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/UpcomingCalendarEvents.xml.aspx?")
                .Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode)
                .Append("&characterID=").Append(characterID);

            try
            {
                web.Proxy = WebRequest.DefaultWebProxy;
                response = web.DownloadString(sb.ToString());
                xmldoc.LoadXml(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine("UpcomingCalendarEvents exception.");
            }

            return xmldoc;
        }

        public XmlDocument WalletJournal(string keyID, string vCode, string characterID,
            int accountKey = 0, long fromID = 0, int rowCount = 50)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/WalletJournal.xml.aspx?")
                .Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode)
                .Append("&characterID=").Append(characterID);

            if (accountKey >= 1000 && accountKey <= 1006)
            {
                sb.Append("&accountKey=").Append(accountKey.ToString());
            }

            if (fromID != 0)
            {
                sb.Append("&fromID=").Append(fromID.ToString());
            }

            if (rowCount > 2560)
            {
                rowCount = 2560;
            }

            if (rowCount != 50)
            {
                sb.Append("&rowCount=").Append(rowCount.ToString());
            }

            try
            {
                web.Proxy = WebRequest.DefaultWebProxy;
                response = web.DownloadString(sb.ToString());
                xmldoc.LoadXml(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine("WalletJournal exception.");
            }

            return xmldoc;
        }

        public XmlDocument WalletTransactions(string keyID, string vCode, string characterID,
            int accountKey = 0, long fromID = 0, int rowCount = 1000)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/WalletTransactions.xml.aspx?")
                .Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode)
                .Append("&characterID=").Append(characterID);

            if (accountKey >= 1000 && accountKey <= 1006)
            {
                sb.Append("&accountKey=").Append(accountKey.ToString());
            }

            if (fromID != 0)
            {
                sb.Append("&fromID=").Append(fromID.ToString());
            }

            if (rowCount > 2560)
            {
                rowCount = 2560;
            }

            if (rowCount != 1000)
            {
                sb.Append("&rowCount=").Append(rowCount.ToString());
            }

            try
            {
                web.Proxy = WebRequest.DefaultWebProxy;
                response = web.DownloadString(sb.ToString());
                xmldoc.LoadXml(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine("WalletTransactions exception.");
            }

            return xmldoc;
        }

    }
}
