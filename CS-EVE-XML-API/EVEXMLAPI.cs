/*******************************************************************************
 * Author: Garrett Bates
 * IGN: Thirtyone Organism
 * Last Mod: Oct 31, 2015
 * Library: EVE XML API for C#
 * 
 * Note: This library was made using the information available from
 * http://wiki.eve-id.net/
 * and many comments have been ripped directly from there for my own
 * convenience.
 ******************************************************************************/

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

        /// <summary>
        /// Private ctor as part of the Singleton pattern.
        /// </summary>
        private EVEXMLAPI()
        {

        }

        /// <summary>
        /// getInstance method as part of the Singleton pattern.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Returns basic account information including when the subscription 
        /// lapses, total play time in minutes, total times logged on and date 
        /// of account creation. In the case of game time code accounts it will 
        /// also look for available offers of time codes.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for 
        /// authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification Code for the Customizable API Key.</param>
        /// <returns></returns>
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

            }

            return xmldoc;
        }

        /// <summary>
        /// Returns information about the API key and a list of the characters 
        /// exposed by it.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification Code for the Customizable API Key.</param>
        /// <returns></returns>
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

            }

            return xmldoc;
        }

        /// <summary>
        /// Returns a list of all characters on an account.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification Code for the Customizable API Key.</param>
        /// <returns></returns>
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

            }

            return xmldoc;
        }

        /*
         * API API Endpoints
         */

        /// <summary>
        /// Returns the mask and groupings for calls under the new Customizable 
        /// API Keys authentication method.
        /// </summary>
        /// <returns></returns>
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

            }

            return xmldoc;
        }

        /*
         * Character API Endpoints
         */

        /// <summary>
        /// Returns the ISK balance of a character.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <returns></returns>
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

            }

            return xmldoc;
        }

        /// <summary>
        /// Returns a list of assets owned by a character.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <returns></returns>
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

            }

            return xmldoc;
        }

        /// <summary>
        /// Returns a list of all invited attendees for a given event.
        /// A call to Upcoming Calendar Events must be made prior to calling 
        /// this API. Otherwise you will receive an error.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <param name="eventID">The ID of the event to list.</param>
        /// <returns></returns>
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

            }

            return xmldoc;
        }

        /// <summary>
        /// Returns attributes relating to a specific character.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <returns></returns>
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

            }

            return xmldoc;
        }

        /// <summary>
        /// Returns the character's contact and watch lists, incl. agents and 
        /// respective standings set by the character. Also includes that 
        /// character's corporation and/or alliance contacts.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <returns></returns>
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

            }

            return xmldoc;
        }

        /// <summary>
        /// Lists the notifications received about having been added to someone's contact list.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <returns></returns>
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

            }

            return xmldoc;
        }

        /// <summary>
        /// Lists the personal contracts for a character.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <param name="contractID">Optional - The ID of a specific contract.</param>
        /// <returns></returns>
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

            }

            return xmldoc;
        }

        /// <summary>
        /// Lists items that a specified contract contains.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <param name="contractID">The ID of contract to be listed.</param>
        /// <returns></returns>
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

            }

            return xmldoc;
        }

        /// <summary>
        /// Lists the latest bids that have been made to any recent auctions.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <returns></returns>
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

            }

            return xmldoc;
        }

        /// <summary>
        /// If the character is enlisted in Factional Warfare, this will return 
        /// the faction the character is enlisted in, the current rank and the 
        /// highest rank the character ever had attained, and how many kills 
        /// and victory points the character obtained yesterday, in the last 
        /// week, and total. Otherwise returns an error code.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <returns></returns>
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

            }

            return xmldoc;
        }

        /// <summary>
        /// Returns a list of industry jobs.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <returns></returns>
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

            }

            return xmldoc;
        }

        /// <summary>
        /// Returns a list of kills where this character received the final 
        /// blow and losses of this character. For characters, returns the 
        /// most recent 25, for corporations, the most recent 100. You can 
        /// scroll back with the beforeKillID parameter.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <param name="beforeKillID">Optional - if present, return the most 
        /// recent kills before the specified killID.</param>
        /// <returns></returns>
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

            }

            return xmldoc;
        }

        /// <summary>
        /// Call will return the items name (or its type name if no user 
        /// defined name exists) as well as their x,y,z coordinates. 
        /// Coordinates should all be 0 for valid locations located inside of 
        /// stations.
        /// These can ONLY be valid locationIDs (that is items which have 
        /// meaningful location coordinates. (0, 0, 0) returned for items in 
        /// hangars that could have valid coordinates) and must be owned by the 
        /// character or corporation associated with the key. Any attempts at 
        /// illegal input will result in a completely empty return. This is 
        /// done to avoid any sort of scraping or giving out more information 
        /// than is appropriate (f.e. validating that a given itemID is indeed 
        /// a valid location but does not belong to the owner associated with 
        /// the key). To differentiate this form of invalid input from other 
        /// invalid input error code 135 will be thrown for this error.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <param name="IDs">Comma separated list of itemIDs</param>
        /// <returns></returns>
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

            }

            return xmldoc;
        }

        /// <summary>
        /// Returns the bodies of headers that have already been fetched with 
        /// the MailMessages call. It will also return a list of missing IDs 
        /// that could not be accessed. Bodies cannot be accessed if you have 
        /// not called for their headers recently.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <param name="IDs">Comma-separated list of IDs obtained from the MailMessages endpoint.</param>
        /// <returns></returns>
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

            }

            return xmldoc;
        }

        /// <summary>
        /// Returns a listing all mailing lists the character is currently a 
        /// member of.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <returns></returns>
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

            }

            return xmldoc;
        }

        /// <summary>
        /// Returns the message headers for mail.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <returns></returns>
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

            }

            return xmldoc;
        }

        /// <summary>
        /// Returns a list of market orders for the character.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <param name="orderID">Optional - returns info on a specific order ID.</param>
        /// <returns></returns>
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

            }

            return xmldoc;
        }

        /// <summary>
        /// Returns a list of medals the character has.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <returns></returns>
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

            }

            return xmldoc;
        }

        /// <summary>
        /// Returns the message headers for notifications.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <returns></returns>
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

            }

            return xmldoc;
        }

        /// <summary>
        /// Returns the message bodies for notifications. Headers need to be 
        /// requested via /char/Notifications.xml.aspx first.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <param name="IDs">Comma-separated list of notification IDs.</param>
        /// <returns></returns>
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

            }

            return xmldoc;
        }

        /// <summary>
        /// Returns information about agents character is doing research with.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <returns></returns>
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

            }

            return xmldoc;
        }

        /// <summary>
        /// Returns the skill the character is currently training.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <returns></returns>
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

            }

            return xmldoc;
        }

        /// <summary>
        /// Returns the skill queue of the character.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <returns></returns>
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

            }

            return xmldoc;
        }

        /// <summary>
        /// Returns the standings towards a character from agents, NPC 
        /// corporations and factions.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <returns></returns>
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

            }
            return xmldoc;
        }

        /// <summary>
        /// Returns a list of all upcoming calendar events for a given character.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <returns></returns>
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

            }

            return xmldoc;
        }

        /// <summary>
        /// Returns a list of wallet journal transactions for character.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <param name="accountKey">Optional - for corp wallets with first wallet starting at 1000.</param>
        /// <param name="fromID">Optional - for transactions originating from a specific ID.</param>
        /// <param name="rowCount">Optional - specifies the amount of rows to return, up to 2560. Default 50.</param>
        /// <returns></returns>
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

            }

            return xmldoc;
        }

        /// <summary>
        /// Returns market transactions for a character.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <param name="accountKey">Optional - for corp wallets with first wallet starting at 1000.</param>
        /// <param name="fromID">Optional - for transactions originating from a specific ID.</param>
        /// <param name="rowCount">Optional - specifies the amount of rows to return, up to 2560. Default 1000.</param>
        /// <returns></returns>
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

            }

            return xmldoc;
        }

        /*
         * Corporation API Endpoints
         */

        /*
         * EVE API Endpoints
         */

        /*
         * Map API Endpoints
         */

        /*
         * Misc API Endpoints
         */

        /*
         * Server API Endpoints
         */

        /// <summary>
        /// Returns current Tranquility status and number of players online.
        /// </summary>
        /// <returns></returns>
        public XmlDocument ServerStatus()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/server/ServerStatus.xml.aspx");

            try
            {
                web.Proxy = WebRequest.DefaultWebProxy;
                response = web.DownloadString(sb.ToString());
                xmldoc.LoadXml(response);
            }
            catch (Exception ex)
            {

            }

            return xmldoc;
        }
    }
}
