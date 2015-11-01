﻿/*******************************************************************************
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
using System.Drawing;
using System.IO;

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

        /// <summary>
        /// Returns the ISK balance of a corporation.
        /// </summary>
        /// <param name="keyID">UserID of account for authentication.</param>
        /// <param name="vCode">Full access API key of account.</param>
        /// <param name="characterID">Character ID of a char with junior
        /// accountant or higher access in the corp you want the balances 
        /// for.</param>
        /// <returns></returns>
        public XmlDocument corpAccountBalance(string keyID, string vCode, string characterID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/AccountBalance.xml.aspx?")
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
        /// Returns a list of assets owned by the corp.
        /// </summary>
        /// <param name="keyID">UserID of account for authentication.</param>
        /// <param name="vCode">Full access API key of account.</param>
        /// <param name="characterID">ID of the character with permission to
        /// access the asset list.</param>
        /// <returns></returns>
        public XmlDocument corpAssetList(string keyID, string vCode, string characterID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/AssetList.xml.aspx?")
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
        /// Returns a list of corp contacts. This is accessible to any character
        /// in any corporation. This call gives standings that the corp has set
        /// towards other characters and entities.
        /// </summary>
        /// <param name="keyID">UserID of account for authentication.</param>
        /// <param name="vCode">Full access API key of account.</param>
        /// <param name="characterID">ID of the character making the request.</param>
        /// <returns></returns>
        public XmlDocument corpContactList(string keyID, string vCode, string characterID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/ContactList.xml.aspx?")
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
        /// Shows corp container Audit Log.
        /// </summary>
        /// <param name="keyID">UserID of account for authentication.</param>
        /// <param name="vCode">Full access API key of account.</param>
        /// <param name="characterID">ID of the character making the request.</param>
        /// <returns></returns>
        public XmlDocument corpContainerLog(string keyID, string vCode, string characterID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/ContainerLog.xml.aspx?")
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
        /// Lists contracts issued within the last month as well as all 
        /// contracts marked as outstanding or in-progress.
        /// </summary>
        /// <param name="keyID">UserID of account for authentication.</param>
        /// <param name="vCode">Full access API key of account.</param>
        /// <param name="characterID">ID of the character making the request.</param>
        /// <returns></returns>
        public XmlDocument corpContracts(string keyID, string vCode, string characterID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/Contracts.xml.aspx?")
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
        /// Lists items that a specified contract contains, use the contractID 
        /// parameter to specify the contract.
        /// </summary>
        /// <param name="keyID">UserID of account for authentication.</param>
        /// <param name="vCode">Full access API key of account.</param>
        /// <param name="characterID">ID of the character making the request.</param>
        /// <param name="contractID">ID of the specified contract.</param>
        /// <returns></returns>
        public XmlDocument corpContractItems(string keyID, string vCode, string characterID, string contractID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/ContractItems.xml.aspx?")
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
        /// Returns a list of contract bids made by the corp.
        /// </summary>
        /// <param name="keyID">UserID of account for authentication.</param>
        /// <param name="vCode">Full access API key of account.</param>
        /// <param name="characterID">ID of the character making the request.</param>
        /// <returns></returns>
        public XmlDocument corpContractBids(string keyID, string vCode, string characterID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/ContractBids.xml.aspx?")
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
        /// Returns attributes relating to a specific corporation.
        /// </summary>
        /// <param name="corporationID">Corporation ID to retrieve information
        /// for.</param>
        /// <param name="keyID">Optional - API Key ID. Must be a corporation 
        /// access key. If not supplied, will return limited info.</param>
        /// <param name="vCode">Optional - API verification code. If not
        /// supplied, will return limited info.</param>
        /// <returns></returns>
        public XmlDocument corpCorporationSheet(string corporationID, string keyID = null, string vCode = null)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/CorporationSheet.xml.aspx?")
                .Append("&corporationID=").Append(corporationID);

            if (keyID != null && vCode != null)
            {
                sb.Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode);
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
        /// If the corporation is enlisted in Factional Warfare, this will 
        /// return the faction the corporation is enlisted in, the current rank 
        /// and the highest rank the corporation ever had attained, and how many
        /// kills and victory points the corporation obtained yesterday, in the
        /// last week, and total. Otherwise returns an error code (125).
        /// </summary>
        /// <param name="keyID">UserID of account for authentication.</param>
        /// <param name="vCode">Full access API key of account.</param>
        /// <param name="characterID">ID of the character making the request.</param>
        /// <returns></returns>
        public XmlDocument corpFacWarStats(string keyID, string vCode, string characterID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/FacWarStats.xml.aspx?")
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
        /// Returns a list of corp industry jobs.
        /// </summary>
        /// <param name="keyID">UserID of account for authentication.</param>
        /// <param name="vCode">Full access API key of account.</param>
        /// <param name="characterID">ID of the character making the request.</param>
        /// <returns></returns>
        public XmlDocument corpIndustryJobs(string keyID, string vCode, string characterID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/IndustryJobs.xml.aspx?")
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
        /// Returns the most recent 100 kills made by players in the corp.
        /// </summary>
        /// <param name="keyID">UserID of account for authentication.</param>
        /// <param name="vCode">Full access API key of account.</param>
        /// <param name="characterID">ID of the character making the request.</param>
        /// <param name="beforeKillID">Optional - Returns kills before the
        /// specified ID.</param>
        /// <returns></returns>
        public XmlDocument corpKillLog(string keyID, string vCode, string characterID, string beforeKillID = null)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/KillLog.xml.aspx?")
                .Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode)
                .Append("&characterID=").Append(characterID);

            if (beforeKillID != null)
            {
                sb.Append(beforeKillID);
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
        /// Call will return the items name (or its type name if no user defined 
        /// name exists) as well as their x,y,z coordinates. Coordinates should
        /// all be 0 for valid locations located inside of stations.
        /// </summary>
        /// <param name="keyID">UserID of account for authentication.</param>
        /// <param name="vCode">Full access API key of account.</param>
        /// <param name="characterID">ID of the character making the request.</param>
        /// <param name="IDs">Comma-separated list of itemIDs.</param>
        /// <returns></returns>
        public XmlDocument corpLocations(string keyID, string vCode, string characterID, string IDs)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/Locations.xml.aspx?")
                .Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode)
                .Append("&characterID=").Append(characterID)
                .Append("IDs=").Append(IDs);

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
        /// Returns a list of market orders that are either not expired or have
        /// expired in the past week (at most).
        /// </summary>
        /// <param name="keyID">UserID of account for authentication.</param>
        /// <param name="vCode">Full access API key of account.</param>
        /// <param name="characterID">ID of the character making the request.</param>
        /// <param name="orderID">Optional - market order ID to fetch an order
        /// that is no longer open.</param>
        /// <returns></returns>
        public XmlDocument corpMarketOrders(string keyID, string vCode, string characterID, string orderID = null)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/MarketOrders.xml.aspx?")
                .Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode)
                .Append("&characterID=").Append(characterID);

            if (orderID != null)
            {
                sb.Append("orderID=").Append(orderID);
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
        /// Returns a list of medals created by this corporation.
        /// </summary>
        /// <param name="keyID">UserID of account for authentication.</param>
        /// <param name="vCode">Full access API key of account.</param>
        /// <param name="characterID">ID of the character making the request.</param>
        /// <returns></returns>
        public XmlDocument corpMedals(string keyID, string vCode, string characterID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/Medals.xml.aspx?")
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
        /// Returns a list of medals issued to members.
        /// </summary>
        /// <param name="keyID">UserID of account for authentication.</param>
        /// <param name="vCode">Limited access API key of account.</param>
        /// <param name="characterID">ID of the character making the request.</param>
        /// <returns></returns>
        public XmlDocument corpMemberMedals(string keyID, string vCode, string characterID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/MemberMedals.xml.aspx?")
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
        /// Returns the security roles of members in a corporation.
        /// </summary>
        /// <param name="keyID">UserID of account for authentication.</param>
        /// <param name="vCode">Full access API key of account.</param>
        /// <param name="characterID">ID of the character making the request.</param>
        /// <returns></returns>
        public XmlDocument corpMemberSecurity(string keyID, string vCode, string characterID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/MemberSecurity.xml.aspx?")
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
        /// Returns info about corporation role changes for members and who did it.
        /// </summary>
        /// <param name="keyID">UserID of account for authentication.</param>
        /// <param name="vCode">Full access API key of account.</param>
        /// <param name="characterID">ID of the character making the request.</param>
        /// <returns></returns>
        public XmlDocument corpMemberSecurityLog(string keyID, string vCode, string characterID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/MemberSecurityLog.xml.aspx?")
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
        /// For player corps this returns the member list (same as in game). 
        /// Otherwise returns an error code (207).
        /// </summary>
        /// <param name="keyID">UserID of account for authentication.</param>
        /// <param name="vCode">Full access API key of account.</param>
        /// <param name="extendedVersion">Optional - pass true for the extended
        /// version.</param>
        /// <returns></returns>
        public XmlDocument corpMemberTracking(string keyID, string vCode, bool extendedVersion = false)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/MemberTracking.xml.aspx?")
                .Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode);

            if (extendedVersion == true)
            {
                sb.Append("&extended=1");
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
        /// Returns information about the corporation’s outposts, which will
        /// require a full API key from the a director(or CEO) of the 
        /// corporation which the outpost belongs to.
        /// </summary>
        /// <param name="keyID">UserID of account for authentication.</param>
        /// <param name="vCode">Full access API key of account.</param>
        /// <param name="characterID">ID of the character making the request.</param>
        /// <returns></returns>
        public XmlDocument corpOutpostList(string keyID, string vCode, string characterID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/OutpostList.xml.aspx?")
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
        /// If a service has default values, they will not be shown.
        /// </summary>
        /// <param name="keyID">UserID of account for authentication.</param>
        /// <param name="vCode">Full access API key of account.</param>
        /// <param name="characterID">ID of the character making the request.</param>
        /// <param name="itemID">Item ID of the outpost listed in OutpostList 
        /// API call.</param>
        /// <returns></returns>
        public XmlDocument corpOutpostServiceDetail(string keyID, string vCode, string characterID, string itemID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/OutpostServiceDetail.xml.aspx?")
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
        /// Returns the character and corporation share holders of a corporation.
        /// </summary>
        /// <param name="keyID">UserID of account for authentication.</param>
        /// <param name="vCode">Full access API key of account.</param>
        /// <param name="characterID">ID of the Director or CEO making the request.</param>
        /// <returns></returns>
        public XmlDocument corpShareholders(string keyID, string vCode, string characterID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/Shareholders.xml.aspx?")
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
        /// Returns the standings from NPC corporations and factions as well 
        /// as agents.
        /// </summary>
        /// <param name="keyID">UserID of account for authentication.</param>
        /// <param name="vCode">Full access API key of account.</param>
        /// <param name="characterID">ID of the Director or CEO making the request.</param>
        /// <returns></returns>
        public XmlDocument corpStandings(string keyID, string vCode, string characterID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/Standings.xml.aspx?")
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
        /// Shows the settings and fuel status of a POS.
        /// </summary>
        /// <param name="keyID">API key ID (must be director's Corporation key)</param>
        /// <param name="vCode">Verification code.</param>
        /// <param name="itemID">ItemID of the POS as given in the starbase list.</param>
        /// <returns></returns>
        public XmlDocument corpStarbaseDetail(string keyID, string vCode, string itemID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/StarbaseDetail.xml.aspx?")
                .Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode)
                .Append("&itemID=").Append(itemID);

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
        /// Returns the list and states of POSs.
        /// </summary>
        /// <param name="keyID">API Key ID (must be a Corporation key).</param>
        /// <param name="vCode">API Verification Code.</param>
        /// <returns></returns>
        public XmlDocument corpStarbaseList(string keyID, string vCode)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/StarbaseList.xml.aspx?")
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
        /// Returns the titles of a corporation.
        /// </summary>
        /// <param name="keyID">UserID of account for authentication.</param>
        /// <param name="vCode">Full access API key of account.</param>
        /// <param name="characterID">ID of the Director or CEO making the request.</param>
        /// <returns></returns>
        public XmlDocument corpTitles(string keyID, string vCode, string characterID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/Titles.xml.aspx?")
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
        /// Returns a list of journal transactions for corporation.
        /// </summary>
        /// <param name="keyID">UserID of account for authentication.</param>
        /// <param name="vCode">Full access API key of account.</param>
        /// <param name="characterID">ID of the character making the request.</param>
        /// <param name="accountKey">For corps, first wallet starts at 1000.</param>
        /// <param name="fromID">Optional - specify a journal entry to retrieve
        /// previous listings from.</param>
        /// <param name="rowCount">Optional - default is 50, up to 2560.</param>
        /// <returns></returns>
        public XmlDocument corpWalletJournal(string keyID, string vCode, string characterID,
            string accountKey, string fromID = null, int rowCount = 50)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            if (rowCount > 2560)
            {
                rowCount = 2560;
            }

            sb.Append("https://api.eveonline.com/corp/WalletJournal.xml.aspx?")
                .Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode)
                .Append("&characterID=").Append(characterID)
                .Append("&accountKey=").Append(accountKey)
                .Append("&rowCount=").Append(rowCount.ToString());

            if (fromID != null)
            {
                sb.Append("&fromID=").Append(fromID);
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
        /// Returns wallet transactions for a corp.
        /// </summary>
        /// <param name="keyID">UserID of account for authentication.</param>
        /// <param name="vCode">Full access API key of account.</param>
        /// <param name="characterID">ID of the character making the request.</param>
        /// <param name="accountKey">For corps, first wallet starts at 1000.</param>
        /// <param name="fromID">Optional - specify a journal entry to retrieve
        /// previous listings from.</param>
        /// <param name="rowCount">Optional - default is 50, up to 2560.</param>
        /// <returns></returns>
        public XmlDocument corpWalletTransactions(string keyID, string vCode, string characterID,
            string accountKey, string fromID = null, int rowCount = 50)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            if (rowCount > 2560)
            {
                rowCount = 2560;
            }

            sb.Append("https://api.eveonline.com/corp/WalletTransactions.xml.aspx?")
                .Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode)
                .Append("&characterID=").Append(characterID)
                .Append("&accountKey=").Append(accountKey)
                .Append("&rowCount=").Append(rowCount);

            if (fromID != null)
            {
                sb.Append("&fromID=").Append(fromID);
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
         * EVE API Endpoints
         */

        /// <summary>
        /// Returns a list of alliances in EVE.
        /// </summary>
        /// <param name="alliancesOnly">Optional - pass in true for a list of
        /// alliances without member corps.</param>
        /// <returns></returns>
        public XmlDocument AllianceList(bool alliancesOnly = false)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/eve/AllianceList.xml.aspx?");

            if (alliancesOnly == true)
            {
                sb.Append("version=1");
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
        /// Returns a list of certificates in EVE.
        /// </summary>
        /// <returns></returns>
        public XmlDocument CertificateTree()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/eve/CertificateTree.xml.aspx");

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
        /// Returns the ownerID for a given character, faction, alliance or 
        /// corporation name, or the typeID for other objects such as stations,
        /// solar systems, planets, etc.
        /// </summary>
        /// <param name="names">Comma-separated list of character names
        /// to query.</param>
        /// <returns></returns>
        public XmlDocument CharacterID(string names)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/eve/CertificateTree.xml.aspx?")
                .Append("names=").Append(names);

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
        /// Without a supplied API key it will return the same data as a show 
        /// info call on the character would do in the client. With a limited 
        /// API key it will add total skill points as well as the current ship
        /// you are in and its name. Supplied with a full API key your account 
        /// balance and your last known location (cached) will be added to the 
        /// return.
        /// </summary>
        /// <param name="characterID">Character ID of the player.</param>
        /// <param name="keyID">Optional - Key ID of account for authentication.
        /// </param>
        /// <param name="vCode">Optional - Limited or Full access API key of 
        /// account.</param>
        /// <returns></returns>
        public XmlDocument CharacterInfo(string characterID, string keyID = null, string vCode = null)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/eve/CharacterInfo.xml.aspx?")
                .Append("&characterID=").Append(characterID);

            if (keyID != null && vCode != null)
            {
                sb.Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode);
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
        /// Returns the name associated with an characterID.
        /// </summary>
        /// <param name="ids">Comma-separated list of ownerIDs (characterID, 
        /// agentID, corporationID, allianceID, or factionID) and typeIDs to 
        /// query. A hard maximum of 250 IDs passed in. Might change in the 
        /// future depending on live results. Any instances of repeated ids in 
        /// the string will throw immediate errors with no returns. If an ID is
        /// passed into the call that does not resolve the call will not return 
        /// any results regardless of the validity of other ids. Trailing commas
        /// on the ids input will throw now errors.</param>
        /// <returns></returns>
        public XmlDocument CharacterName(string ids)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/eve/CharacterName.xml.aspx?")
                .Append("ids=").Append(ids);

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
        /// Returns a list of conquerable stations.
        /// </summary>
        /// <returns></returns>
        public XmlDocument ConquerableStationList()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/eve/ConquerableStationList.xml.aspx?");

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
        /// Returns a list of error codes that can be returned by the EVE API 
        /// servers. Error types are broken into the following categories 
        /// according to their first digit:
        /// 1xx - user input
        /// 2xx - authentication
        /// 5xx - server
        /// 9xx - miscellaneous
        /// </summary>
        /// <returns></returns>
        public XmlDocument ErrorList()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/eve/ErrorList.xml.aspx?");

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
        /// Returns global stats on the factions in factional warfare including
        /// the number of pilots in each faction, the number of systems they 
        /// control, and how many kills and victory points each and all factions
        /// obtained yesterday, in the last week, and total.
        /// </summary>
        /// <returns></returns>
        public XmlDocument FacWarStats()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/eve/FacWarStats.xml.aspx?");

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
        /// Returns Factional Warfare Top 100 Stats.
        /// </summary>
        /// <returns></returns>
        public XmlDocument FacWarTopStats()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/eve/FacWarTopStats.xml.aspx?");

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
        /// Returns a list of transaction types used in the Journal Entries.
        /// </summary>
        /// <returns></returns>
        public XmlDocument RefTypes()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/eve/RefTypes.xml.aspx?");

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
        /// XML of currently in-game skills (including unpublished skills).
        /// </summary>
        /// <returns></returns>
        public XmlDocument SkillTree()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/eve/SkillTree.xml.aspx?");

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
        /// Returns the name associated with a typeID.
        /// </summary>
        /// <param name="ids">Comma-separated list of typeIDs to query
        /// A hard maximum of 250 IDs passed in. Any instances of repeated ids 
        /// in the string will throw immediate errors with no returns. If an ID
        /// is passed into the call that does not resolve the call will not 
        /// return any results regardless of the validity of other ids. Trailing 
        /// commas on the ids input will throw now errors.</param>
        /// <returns></returns>
        public XmlDocument TypeName(string ids)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/eve/TypeName.xml.aspx?")
                .Append("ids=").Append(ids);

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
         * Map API Endpoints
         */

        /// <summary>
        /// Returns a list of solarsystems and what faction or 
        /// alliance controls them.
        /// </summary>
        /// <returns></returns>
        public XmlDocument Sovereignty()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/map/Sovereignty.xml.aspx");

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
        /// Returns the number of kills in solarsystems within the last hour. 
        /// Only solar system where kills have been made are listed, so assume 
        /// zero in case the system is not listed.
        /// </summary>
        /// <returns></returns>
        public XmlDocument Kills()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/map/Kills.xml.aspx");

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
        /// Only systems with jumps are shown, if the system has no jumps, it's
        /// not listed.
        /// </summary>
        /// <returns></returns>
        public XmlDocument Jumps()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/map/Jumps.xml.aspx");

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
        /// Returns a list of contestable solarsystems and the NPC faction
        /// currently occupying them. It should be noted that this file 
        /// only returns a non-zero ID if the occupying faction is not the 
        /// sovereign faction.
        /// </summary>
        /// <returns></returns>
        public XmlDocument FacWarSystems()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/map/FacWarSystems.xml.aspx");

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
         * Misc API Endpoints
         */

        /// <summary>
        /// Returns the System.Drawing.Image of the specified inventory item.
        /// Requires adding the System.Drawing assembly and namespace.
        /// </summary>
        /// <param name="typeID">ID of the inventory item.</param>
        /// <param name="size">Size of the image. Valid values are 30, 32, 
        /// 64, 128, 256, and 512.</param>
        /// <returns></returns>
        public Image ImageRender(string typeID, int size)
        {
            Image img = null;
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();

            sb.Append("http://image.eveonline.com/Render/")
                .Append(typeID).Append("_").Append(size.ToString())
                .Append(".png");

            try
            {
                web.Proxy = WebRequest.DefaultWebProxy;
                byte[] ba = web.DownloadData(sb.ToString());
                img = Image.FromStream(new MemoryStream(ba));
            }
            catch (Exception ex)
            {

            }

            return img;
        }

        /// <summary>
        /// Returns the System.Drawing.Image of the specified inventory item.
        /// Requires adding the System.Drawing assembly and namespace.
        /// </summary>
        /// <param name="typeID">ID of the inventory item.</param>
        /// <param name="size">Size of the portrait. Valid values are 32, and 64.</param>
        /// <returns></returns>
        public Image ImageTypeIcon(string typeID, int size)
        {
            Image img = null;
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();

            sb.Append("http://image.eveonline.com/InventoryType/")
                .Append(typeID).Append("_").Append(size.ToString())
                .Append(".png");

            try
            {
                web.Proxy = WebRequest.DefaultWebProxy;
                byte[] ba = web.DownloadData(sb.ToString());
                img = Image.FromStream(new MemoryStream(ba));
            }
            catch (Exception ex)
            {

            }
            return img;
        }

        /// <summary>
        /// Returns the System.Drawing.Image of the specified alliance.
        /// Requires adding the System.Drawing assembly and namespace.
        /// </summary>
        /// <param name="allianceID">ID of the alliance.</param>
        /// <param name="size">Size of the portrait. Valid values are 30, 32, 
        /// 64, 128.</param>
        /// <returns></returns>
        public Image ImageAlliance(string allianceID, int size)
        {
            Image img = null;
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();

            sb.Append("http://image.eveonline.com/Alliance/")
                .Append(allianceID).Append("_").Append(size.ToString())
                .Append(".png");

            try
            {
                web.Proxy = WebRequest.DefaultWebProxy;
                byte[] ba = web.DownloadData(sb.ToString());
                img = Image.FromStream(new MemoryStream(ba));
            }
            catch (Exception ex)
            {

            }
            return img;
        }

        /// <summary>
        /// Returns the System.Drawing.Image of the specified corporation.
        /// Requires adding the System.Drawing assembly and namespace.
        /// </summary>
        /// <param name="corporationID">ID of the corporation.</param>
        /// <param name="size">Size of the portrait. Valid values are 30, 32, 
        /// 64, 128, 256.</param>
        /// <returns></returns>
        public Image ImageCorporation(string corporationID, int size)
        {
            Image img = null;
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();

            sb.Append("http://image.eveonline.com/Corporation/")
                .Append(corporationID).Append("_").Append(size.ToString())
                .Append(".png");

            try
            {
                web.Proxy = WebRequest.DefaultWebProxy;
                byte[] ba = web.DownloadData(sb.ToString());
                img = Image.FromStream(new MemoryStream(ba));
            }
            catch (Exception ex)
            {

            }
            return img;
        }
                
        /// <summary>
        /// Returns the System.Drawing.Image of the specified character.
        /// Requires adding the System.Drawing assembly and namespace.
        /// </summary>
        /// <param name="characterID">ID of the character.</param>
        /// <param name="size">Valid sizes are 30, 32, 64, 128, 200, 
        /// 256, 512, or 1024.</param>
        /// <returns></returns>
        public Image ImageCharacter(string characterID, int size)
        {
            Image img = null;
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();

            sb.Append("http://image.eveonline.com/Character/")
                .Append(characterID).Append("_").Append(size.ToString())
                .Append(".jpg");

            try
            {
                web.Proxy = WebRequest.DefaultWebProxy;
                byte[] ba = web.DownloadData(sb.ToString());
                img = Image.FromStream(new MemoryStream(ba));
            }
            catch (Exception ex)
            {

            }
            return img;
        }

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
