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
using System.Drawing;
using System.IO;

namespace CS_EVE_XML_API
{
    /// <summary>
    /// Thread-safe singleton allows the user to interface with the EVE Online<para/>
    /// Developer API with a light-weight dynamically-linked library.
    /// </summary>
    public class EVEXMLAPI
    {
        static EVEXMLAPI _self = null;
        string _keyID = null;
        string _vCode = null;
        string _characterID = null;

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

        /// <summary>
        /// Stores the API key for a character for use in parameterless<para/>
        /// functions - an alternative to passing data in each function call.
        /// </summary>
        /// <param name="keyID">Key ID associated with the character.</param>
        /// <param name="vCode">Verification code associated with the character.</param>
        /// <param name="characterID">Character ID associated with the character.</param>
        public void SetInfo(string keyID, string vCode, string characterID)
        {
            _keyID = keyID;
            _vCode = vCode;
            _characterID = characterID;
        }

        /// <summary>
        /// Sets the Key ID.
        /// </summary>
        /// <param name="keyID">Key ID associated with the character.</param>
        public void SetKeyID(string keyID)
        {
            _keyID = keyID;
        }

        /// <summary>
        /// Sets the Verification Code.
        /// </summary>
        /// <param name="vCode">Verification Code associated with the character.</param>
        public void SetVCode(string vCode)
        {
            _vCode = vCode;
        }

        /// <summary>
        /// Sets the Character ID.
        /// </summary>
        /// <param name="characterID">Character ID associated with the character.</param>
        public void SetCharID(string characterID)
        {
            _characterID = characterID;
        }

        /*
         * Account API Endpoints
         */

        /// <summary>
        /// Returns basic account information including when the subscription<para/> 
        /// lapses, total play time in minutes, total times logged on and date <para/>
        /// of account creation. In the case of game time code accounts it will <para/>
        /// also look for available offers of time codes.
        /// </summary>
        /// <returns></returns>
        public XmlDocument acctAccountStatus()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/account/AccountStatus.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode);

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
        /// Returns basic account information including when the subscription<para/> 
        /// lapses, total play time in minutes, total times logged on and date <para/>
        /// of account creation. In the case of game time code accounts it will <para/>
        /// also look for available offers of time codes.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for 
        /// authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification Code for<para/>
        /// the Customizable API Key.</param>
        /// <returns></returns>
        public XmlDocument acctAccountStatus(string keyID, string vCode)
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
        /// Returns information about the API key and a list of the characters <para/>
        /// exposed by it.
        /// </summary>
        /// <returns></returns>
        public XmlDocument acctAPIKeyInfo()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/account/APIKeyInfo.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode);

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
        /// Returns information about the API key and a list of the characters <para/>
        /// exposed by it.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification Code<para/>
        /// for the Customizable API Key.</param>
        /// <returns></returns>
        public XmlDocument acctAPIKeyInfo(string keyID, string vCode)
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
        /// <returns></returns>
        public XmlDocument acctCharacters()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/account/Characters.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode);

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
        /// <param name="vCode">The user defined or CCP generated Verification<para/>
        /// Code for the Customizable API Key.</param>
        /// <returns></returns>
        public XmlDocument acctCharacters(string keyID, string vCode)
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
        /// Returns the mask and groupings for calls under the new Customizable <para/>
        /// API Keys authentication method.
        /// </summary>
        /// <returns></returns>
        public XmlDocument apiCallList()
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
        /// <returns></returns>
        public XmlDocument charAccountBalance()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/AccountBalance.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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
        /// Returns the ISK balance of a character.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification<para/>
        /// Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <returns></returns>
        public XmlDocument charAccountBalance(string keyID, string vCode, string characterID)
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
        /// <returns></returns>
        public XmlDocument charAssetList()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/AssetList.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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
        /// <param name="vCode">The user defined or CCP generated Verification<para/>
        /// Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <returns></returns>
        public XmlDocument charAssetList(string keyID, string vCode, string characterID)
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
        /// Returns a list of all invited attendees for a given event.<para/>
        /// A call to Upcoming Calendar Events must be made prior to calling <para/>
        /// this API. Otherwise you will receive an error.
        /// </summary>
        /// <param name="eventID">The ID of the event to list.</param>
        /// <returns></returns>
        public XmlDocument charCalendarEventAttendees(string eventID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/CalendarEventAttendees.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID)
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
        /// Returns a list of all invited attendees for a given event.<para/>
        /// A call to Upcoming Calendar Events must be made prior to calling <para/>
        /// this API. Otherwise you will receive an error.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification<para/>
        /// Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <param name="eventID">The ID of the event to list.</param>
        /// <returns></returns>
        public XmlDocument charCalendarEventAttendees(string keyID, string vCode, string characterID, string eventID)
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
        /// <returns></returns>
        public XmlDocument charCharacterSheet()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/CharacterSheet.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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
        /// <param name="vCode">The user defined or CCP generated Verification<para/>
        /// Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <returns></returns>
        public XmlDocument charCharacterSheet(string keyID, string vCode, string characterID)
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
        /// Returns the character's contact and watch lists, incl. agents and <para/>
        /// respective standings set by the character. Also includes that <para/>
        /// character's corporation and/or alliance contacts.
        /// </summary>
        /// <returns></returns>
        public XmlDocument charContactList()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/ContactList.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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
        /// Returns the character's contact and watch lists, incl. agents and <para/>
        /// respective standings set by the character. Also includes that <para/>
        /// character's corporation and/or alliance contacts.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification<para/>
        /// Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <returns></returns>
        public XmlDocument charContactList(string keyID, string vCode, string characterID)
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
        /// Lists the notifications received about having been added to someone's<para/>
        /// contact list.
        /// </summary>
        /// <returns></returns>
        public XmlDocument charContactNotifications()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/ContactNotifications.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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
        /// Lists the notifications received about having been added to someone's<para/>
        /// contact list.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification<para/>
        /// Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <returns></returns>
        public XmlDocument charContactNotifications(string keyID, string vCode, string characterID)
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
        /// <param name="contractID">Optional - The ID of a specific contract.</param>
        /// <returns></returns>
        public XmlDocument charContracts(string contractID = null)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/Contracts.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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
        /// Lists the personal contracts for a character.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification Code<para/>
        /// for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <param name="contractID">Optional - The ID of a specific contract.</param>
        /// <returns></returns>
        public XmlDocument charContracts(string keyID, string vCode, string characterID, string contractID = null)
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
        /// <param name="contractID">The ID of contract to be listed.</param>
        /// <returns></returns>
        public XmlDocument charContractItems(string contractID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/ContractItems.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID)
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
        /// Lists items that a specified contract contains.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification<para/>
        /// Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <param name="contractID">The ID of contract to be listed.</param>
        /// <returns></returns>
        public XmlDocument charContractItems(string keyID, string vCode, string characterID, string contractID)
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
        /// <returns></returns>
        public XmlDocument charContractBids()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/ContractBids.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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
        /// <param name="vCode">The user defined or CCP generated Verification<para/>
        /// Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <returns></returns>
        public XmlDocument charContractBids(string keyID, string vCode, string characterID)
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
        /// If the character is enlisted in Factional Warfare, this will return <para/>
        /// the faction the character is enlisted in, the current rank and the <para/>
        /// highest rank the character ever had attained, and how many kills <para/>
        /// and victory points the character obtained yesterday, in the last <para/>
        /// week, and total. Otherwise returns an error code.
        /// </summary>
        /// <returns></returns>
        public XmlDocument charFacWarStats()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/FacWarStats.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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
        /// If the character is enlisted in Factional Warfare, this will return <para/>
        /// the faction the character is enlisted in, the current rank and the <para/>
        /// highest rank the character ever had attained, and how many kills <para/>
        /// and victory points the character obtained yesterday, in the last <para/>
        /// week, and total. Otherwise returns an error code.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification<para/>
        /// Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <returns></returns>
        public XmlDocument charFacWarStats(string keyID, string vCode, string characterID)
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
        /// <returns></returns>
        public XmlDocument charIndustryJobs()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/IndustryJobs.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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
        /// <param name="vCode">The user defined or CCP generated Verification<para/>
        /// Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <returns></returns>
        public XmlDocument charIndustryJobs(string keyID, string vCode, string characterID)
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
        /// Returns a list of kills where this character received the final <para/>
        /// blow and losses of this character. For characters, returns the <para/>
        /// most recent 25, for corporations, the most recent 100. You can <para/>
        /// scroll back with the beforeKillID parameter.
        /// </summary>
        /// <param name="beforeKillID">Optional - if present, return the most <para/>
        /// recent kills before the specified killID.</param>
        /// <returns></returns>
        public XmlDocument charKillLog(string beforeKillID = null)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/KillLog.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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
        /// Returns a list of kills where this character received the final <para/>
        /// blow and losses of this character. For characters, returns the <para/>
        /// most recent 25, for corporations, the most recent 100. You can <para/>
        /// scroll back with the beforeKillID parameter.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification<para/>
        /// Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <param name="beforeKillID">Optional - if present, return the most <para/>
        /// recent kills before the specified killID.</param>
        /// <returns></returns>
        public XmlDocument charKillLog(string keyID, string vCode, string characterID, string beforeKillID = null)
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
        /// Call will return the items name (or its type name if no user <para/>
        /// defined name exists) as well as their x,y,z coordinates. <para/>
        /// Coordinates should all be 0 for valid locations located inside of <para/>
        /// stations.<para/>
        /// These can ONLY be valid locationIDs (that is items which have <para/>
        /// meaningful location coordinates. (0, 0, 0) returned for items in <para/>
        /// hangars that could have valid coordinates) and must be owned by the <para/>
        /// character or corporation associated with the key. Any attempts at <para/>
        /// illegal input will result in a completely empty return. This is <para/>
        /// done to avoid any sort of scraping or giving out more information <para/>
        /// than is appropriate (f.e. validating that a given itemID is indeed <para/>
        /// a valid location but does not belong to the owner associated with <para/>
        /// the key). To differentiate this form of invalid input from other <para/>
        /// invalid input error code 135 will be thrown for this error.
        /// </summary>
        /// <param name="IDs">Comma separated list of itemIDs.</param>
        /// <returns></returns>
        public XmlDocument charLocations(string IDs)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/Locations.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID)
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
        /// Call will return the items name (or its type name if no user <para/>
        /// defined name exists) as well as their x,y,z coordinates. <para/>
        /// Coordinates should all be 0 for valid locations located inside of <para/>
        /// stations.<para/>
        /// These can ONLY be valid locationIDs (that is items which have <para/>
        /// meaningful location coordinates. (0, 0, 0) returned for items in <para/>
        /// hangars that could have valid coordinates) and must be owned by the <para/>
        /// character or corporation associated with the key. Any attempts at <para/>
        /// illegal input will result in a completely empty return. This is <para/>
        /// done to avoid any sort of scraping or giving out more information <para/>
        /// than is appropriate (f.e. validating that a given itemID is indeed <para/>
        /// a valid location but does not belong to the owner associated with <para/>
        /// the key). To differentiate this form of invalid input from other <para/>
        /// invalid input error code 135 will be thrown for this error.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification<para/>
        /// Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <param name="IDs">Comma separated list of itemIDs.</param>
        /// <returns></returns>
        public XmlDocument charLocations(string keyID, string vCode, string characterID, string IDs)
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
        /// Returns the bodies of headers that have already been fetched with <para/>
        /// the MailMessages call. It will also return a list of missing IDs <para/>
        /// that could not be accessed. Bodies cannot be accessed if you have <para/>
        /// not called for their headers recently.
        /// </summary>
        /// <param name="IDs">Comma-separated list of IDs obtained from the<para/>
        /// MailMessages endpoint.</param>
        /// <returns></returns>
        public XmlDocument charMailBodies(string IDs)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/MailBodies.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID)
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
        /// Returns the bodies of headers that have already been fetched with <para/>
        /// the MailMessages call. It will also return a list of missing IDs <para/>
        /// that could not be accessed. Bodies cannot be accessed if you have <para/>
        /// not called for their headers recently.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification<para/>
        /// Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <param name="IDs">Comma-separated list of IDs obtained from the<para/>
        /// MailMessages endpoint.</param>
        /// <returns></returns>
        public XmlDocument charMailBodies(string keyID, string vCode, string characterID, string IDs)
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
        /// Returns a listing all mailing lists the character is currently a <para/>
        /// member of.
        /// </summary>
        /// <returns></returns>
        public XmlDocument charMailingLists()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/MailingLists.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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
        /// Returns a listing all mailing lists the character is currently a <para/>
        /// member of.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification<para/>
        /// Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <returns></returns>
        public XmlDocument charMailingLists(string keyID, string vCode, string characterID)
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
        /// <returns></returns>
        public XmlDocument charMailMessages()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/MailMessages.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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
        /// <param name="vCode">The user defined or CCP generated Verification<para/>
        /// Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <returns></returns>
        public XmlDocument charMailMessages(string keyID, string vCode, string characterID)
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
        /// <param name="orderID">Optional - returns info on a specific order ID.</param>
        /// <returns></returns>
        public XmlDocument charMarketOrders(string orderID = null)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/MarketOrders.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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
        /// Returns a list of market orders for the character.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification<para/>
        /// Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <param name="orderID">Optional - returns info on a specific order ID.</param>
        /// <returns></returns>
        public XmlDocument charMarketOrders(string keyID, string vCode, string characterID, string orderID = null)
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
        /// <returns></returns>
        public XmlDocument charMedals()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/Medals.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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
        /// <param name="vCode">The user defined or CCP generated Verification<para/>
        /// Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <returns></returns>
        public XmlDocument charMedals(string keyID, string vCode, string characterID)
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
        /// <returns></returns>
        public XmlDocument charNotifications()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/Notifications.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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
        /// <param name="vCode">The user defined or CCP generated Verification<para/>
        /// Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <returns></returns>
        public XmlDocument charNotifications(string keyID, string vCode, string characterID)
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
        /// Returns the message bodies for notifications. Headers need to be <para/>
        /// requested via /char/Notifications.xml.aspx first.
        /// </summary>
        /// <param name="IDs">Comma-separated list of notification IDs.</param>
        /// <returns></returns>
        public XmlDocument charNotificationTexts(string IDs)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/NotificationTexts.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID)
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
        /// Returns the message bodies for notifications. Headers need to be <para/>
        /// requested via /char/Notifications.xml.aspx first.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification<para/>
        /// Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <param name="IDs">Comma-separated list of notification IDs.</param>
        /// <returns></returns>
        public XmlDocument charNotificationTexts(string keyID, string vCode, string characterID, string IDs)
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
        /// <returns></returns>
        public XmlDocument charResearch()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/Research.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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
        /// <param name="vCode">The user defined or CCP generated Verification<para/>
        /// Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <returns></returns>
        public XmlDocument charResearch(string keyID, string vCode, string characterID)
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
        /// <returns></returns>
        public XmlDocument charSkillInTraining()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/SkillInTraining.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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
        /// <param name="vCode">The user defined or CCP generated Verification<para/>
        /// Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <returns></returns>
        public XmlDocument charSkillInTraining(string keyID, string vCode, string characterID)
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
        /// <returns></returns>
        public XmlDocument charSkillQueue()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/SkillQueue.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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
        /// <param name="vCode">The user defined or CCP generated Verification<para/>
        /// Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <returns></returns>
        public XmlDocument charSkillQueue(string keyID, string vCode, string characterID)
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
        /// Returns the standings towards a character from agents, NPC <para/>
        /// corporations and factions.
        /// </summary>
        /// <returns></returns>
        public XmlDocument charStandings()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/Standings.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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
        /// Returns the standings towards a character from agents, NPC <para/>
        /// corporations and factions.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification<para/>
        /// Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <returns></returns>
        public XmlDocument charStandings(string keyID, string vCode, string characterID)
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
        /// <returns></returns>
        public XmlDocument charUpcomingCalendarEvents()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/UpcomingCalendarEvents.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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
        /// <param name="vCode">The user defined or CCP generated Verification<para/>
        /// Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <returns></returns>
        public XmlDocument charUpcomingCalendarEvents(string keyID, string vCode, string characterID)
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
        /// <param name="fromID">Optional - for returning transactions before a specific ID.</param>
        /// <param name="rowCount">Optional - specifies the amount of rows to return, up to 2560. Default 50.</param>
        /// <returns></returns>
        public XmlDocument charWalletJournal(long fromID = 0, int rowCount = 50)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/WalletJournal.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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
        /// Returns a list of wallet journal transactions for character.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification<para/>
        /// Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <param name="fromID">Optional - for returning transactions before a specific ID.</param>
        /// <param name="rowCount">Optional - specifies the amount of rows to return, up to 2560. Default 50.</param>
        /// <returns></returns>
        public XmlDocument charWalletJournal(string keyID, string vCode, string characterID, 
            long fromID = 0, int rowCount = 50)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/WalletJournal.xml.aspx?")
                .Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode)
                .Append("&characterID=").Append(characterID);

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
        /// <param name="fromID">Optional - for transactions originating from a specific ID.</param>
        /// <param name="rowCount">Optional - specifies the amount of rows to <para/>
        /// return, up to 2560. Default 1000.</param>
        /// <returns></returns>
        public XmlDocument charWalletTransactions(long fromID = 0, int rowCount = 1000)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/WalletTransactions.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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

        /// <summary>
        /// Returns market transactions for a character.
        /// </summary>
        /// <param name="keyID">The ID of the Customizable API Key for authentication.</param>
        /// <param name="vCode">The user defined or CCP generated Verification<para/>
        /// Code for the Customizable API Key.</param>
        /// <param name="characterID">The ID of the character for the requested data.</param>
        /// <param name="fromID">Optional - for transactions originating from a specific ID.</param>
        /// <param name="rowCount">Optional - specifies the amount of rows to <para/>
        /// return, up to 2560. Default 1000.</param>
        /// <returns></returns>
        public XmlDocument charWalletTransactions(string keyID, string vCode, string characterID,
            long fromID = 0, int rowCount = 1000)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/char/WalletTransactions.xml.aspx?")
                .Append("keyID=").Append(keyID)
                .Append("&vCode=").Append(vCode)
                .Append("&characterID=").Append(characterID);

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
        /// <returns></returns>
        public XmlDocument corpAccountBalance()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/AccountBalance.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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
        /// Returns the ISK balance of a corporation.
        /// </summary>
        /// <param name="keyID">UserID of account for authentication.</param>
        /// <param name="vCode">Full access API key of account.</param>
        /// <param name="characterID">Character ID of a char with junior<para/>
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
        /// <returns></returns>
        public XmlDocument corpAssetList()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/AssetList.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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
        /// <param name="characterID">ID of the character with permission to<para/>
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
        /// Returns a list of corp contacts. This is accessible to any character<para/>
        /// in any corporation. This call gives standings that the corp has set<para/>
        /// towards other characters and entities.
        /// </summary>
        /// <returns></returns>
        public XmlDocument corpContactList()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/ContactList.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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
        /// Returns a list of corp contacts. This is accessible to any character<para/>
        /// in any corporation. This call gives standings that the corp has set<para/>
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
        /// <returns></returns>
        public XmlDocument corpContainerLog()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/ContainerLog.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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
        /// Lists contracts issued within the last month as well as all <para/>
        /// contracts marked as outstanding or in-progress.
        /// </summary>
        /// <returns></returns>
        public XmlDocument corpContracts()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/Contracts.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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
        /// Lists contracts issued within the last month as well as all <para/>
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
        /// Lists items that a specified contract contains, use the contractID <para/>
        /// parameter to specify the contract.
        /// </summary>
        /// <param name="contractID">ID of the specified contract.</param>
        /// <returns></returns>
        public XmlDocument corpContractItems(string contractID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/ContractItems.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID)
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
        /// Lists items that a specified contract contains, use the contractID <para/>
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
        /// <returns></returns>
        public XmlDocument corpContractBids()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/ContractBids.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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
        /// <param name="corporationID">Corporation ID to retrieve information<para/>
        /// for.</param>
        /// <returns></returns>
        public XmlDocument corpCorporationSheet(string corporationID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/CorporationSheet.xml.aspx?")
                .Append("&corporationID=").Append(corporationID);

            if (_keyID != null && _vCode != null)
            {
                sb.Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode);
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
        /// Returns attributes relating to a specific corporation.
        /// </summary>
        /// <param name="corporationID">Corporation ID to retrieve information<para/>
        /// for.</param>
        /// <param name="keyID">Optional - API Key ID. Must be a corporation <para/>
        /// access key. If not supplied, will return limited info.</param>
        /// <param name="vCode">Optional - API verification code. If not<para/>
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
        /// If the corporation is enlisted in Factional Warfare, this will <para/>
        /// return the faction the corporation is enlisted in, the current rank <para/>
        /// and the highest rank the corporation ever had attained, and how many<para/>
        /// kills and victory points the corporation obtained yesterday, in the<para/>
        /// last week, and total. Otherwise returns an error code (125).
        /// </summary>
        /// <returns></returns>
        public XmlDocument corpFacWarStats()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/FacWarStats.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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
        /// If the corporation is enlisted in Factional Warfare, this will <para/>
        /// return the faction the corporation is enlisted in, the current rank <para/>
        /// and the highest rank the corporation ever had attained, and how many<para/>
        /// kills and victory points the corporation obtained yesterday, in the<para/>
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
        /// <returns></returns>
        public XmlDocument corpIndustryJobs()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/IndustryJobs.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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
        /// <param name="beforeKillID">Optional - Returns kills before the
        /// specified ID.</param>
        /// <returns></returns>
        public XmlDocument corpKillLog(string beforeKillID = null)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/KillLog.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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
        /// Call will return the items name (or its type name if no user defined <para/>
        /// name exists) as well as their x,y,z coordinates. Coordinates should<para/>
        /// all be 0 for valid locations located inside of stations.
        /// </summary>
        /// <param name="IDs">Comma-separated list of itemIDs.</param>
        /// <returns></returns>
        public XmlDocument corpLocations(string IDs)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/Locations.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID)
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
        /// Call will return the items name (or its type name if no user defined <para/>
        /// name exists) as well as their x,y,z coordinates. Coordinates should<para/>
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
        /// Returns a list of market orders that are either not expired or have<para/>
        /// expired in the past week (at most).
        /// </summary>
        /// <param name="orderID">Optional - market order ID to fetch an order<para/>
        /// that is no longer open.</param>
        /// <returns></returns>
        public XmlDocument corpMarketOrders(string orderID = null)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/MarketOrders.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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
        /// Returns a list of market orders that are either not expired or have<para/>
        /// expired in the past week (at most).
        /// </summary>
        /// <param name="keyID">UserID of account for authentication.</param>
        /// <param name="vCode">Full access API key of account.</param>
        /// <param name="characterID">ID of the character making the request.</param>
        /// <param name="orderID">Optional - market order ID to fetch an order<para/>
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
        /// <returns></returns>
        public XmlDocument corpMedals()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/Medals.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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
        /// <returns></returns>
        public XmlDocument corpMemberMedals()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/MemberMedals.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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
        /// <returns></returns>
        public XmlDocument corpMemberSecurity()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/MemberSecurity.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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
        /// <returns></returns>
        public XmlDocument corpMemberSecurityLog()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/MemberSecurityLog.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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
        /// For player corps this returns the member list (same as in game). <para/>
        /// Otherwise returns an error code (207).
        /// </summary>
        /// <param name="extendedVersion">Optional - pass true for the extended<para/>
        /// version.</param>
        /// <returns></returns>
        public XmlDocument corpMemberTracking(bool extendedVersion = false)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/MemberTracking.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode);

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
        /// For player corps this returns the member list (same as in game). <para/>
        /// Otherwise returns an error code (207).
        /// </summary>
        /// <param name="keyID">UserID of account for authentication.</param>
        /// <param name="vCode">Full access API key of account.</param>
        /// <param name="extendedVersion">Optional - pass true for the extended<para/>
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
        /// Returns information about the corporation’s outposts, which will<para/>
        /// require a full API key from the a director(or CEO) of the <para/>
        /// corporation which the outpost belongs to.
        /// </summary>
        /// <returns></returns>
        public XmlDocument corpOutpostList()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/OutpostList.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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
        /// Returns information about the corporation’s outposts, which will<para/>
        /// require a full API key from the a director(or CEO) of the <para/>
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
        /// <param name="itemID">Item ID of the outpost listed in OutpostList 
        /// API call.</param>
        /// <returns></returns>
        public XmlDocument corpOutpostServiceDetail(string itemID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/OutpostServiceDetail.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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
        /// <returns></returns>
        public XmlDocument corpShareholders()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/Shareholders.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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
        /// Returns the standings from NPC corporations and factions as well <para/>
        /// as agents.
        /// </summary>
        /// <returns></returns>
        public XmlDocument corpStandings()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/Standings.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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
        /// Returns the standings from NPC corporations and factions as well <para/>
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
        /// <param name="itemID">ItemID of the POS as given in the starbase list.</param>
        /// <returns></returns>
        public XmlDocument corpStarbaseDetail(string itemID)
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/StarbaseDetail.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
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
        /// <returns></returns>
        public XmlDocument corpStarbaseList()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/StarbaseList.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode);

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
        /// <returns></returns>
        public XmlDocument corpTitles()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/corp/Titles.xml.aspx?")
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID);

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
        /// <param name="accountKey">For corps, first wallet starts at 1000.</param>
        /// <param name="fromID">Optional - specify a journal entry to retrieve<para/>
        /// previous listings from.</param>
        /// <param name="rowCount">Optional - default is 50, up to 2560.</param>
        /// <returns></returns>
        public XmlDocument corpWalletJournal(int accountKey = 1000, string fromID = null, int rowCount = 50)
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
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID)
                .Append("&accountKey=").Append(accountKey.ToString())
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
        /// Returns a list of journal transactions for corporation.
        /// </summary>
        /// <param name="keyID">UserID of account for authentication.</param>
        /// <param name="vCode">Full access API key of account.</param>
        /// <param name="characterID">ID of the character making the request.</param>
        /// <param name="accountKey">For corps, first wallet starts at 1000.</param>
        /// <param name="fromID">Optional - specify a journal entry to retrieve<para/>
        /// previous listings from.</param>
        /// <param name="rowCount">Optional - default is 50, up to 2560.</param>
        /// <returns></returns>
        public XmlDocument corpWalletJournal(string keyID, string vCode, string characterID,
            int accountKey = 1000, string fromID = null, int rowCount = 50)
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
        /// <param name="accountKey">For corps, first wallet starts at 1000.</param>
        /// <param name="fromID">Optional - specify a journal entry to retrieve<para/>
        /// previous listings from.</param>
        /// <param name="rowCount">Optional - default is 50, up to 2560.</param>
        /// <returns></returns>
        public XmlDocument corpWalletTransactions(int accountKey = 1000, string fromID = null, int rowCount = 50)
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
                .Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode)
                .Append("&characterID=").Append(_characterID)
                .Append("&accountKey=").Append(accountKey.ToString())
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

        /// <summary>
        /// Returns wallet transactions for a corp.
        /// </summary>
        /// <param name="keyID">UserID of account for authentication.</param>
        /// <param name="vCode">Full access API key of account.</param>
        /// <param name="characterID">ID of the character making the request.</param>
        /// <param name="accountKey">For corps, first wallet starts at 1000.</param>
        /// <param name="fromID">Optional - specify a journal entry to retrieve<para/>
        /// previous listings from.</param>
        /// <param name="rowCount">Optional - default is 50, up to 2560.</param>
        /// <returns></returns>
        public XmlDocument corpWalletTransactions(string keyID, string vCode, string characterID,
            int accountKey, string fromID = null, int rowCount = 50)
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
                .Append("&accountKey=").Append(accountKey.ToString())
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
        /// <param name="alliancesOnly">Optional - pass in true for a list of<para/>
        /// alliances without member corps.</param>
        /// <returns></returns>
        public XmlDocument eveAllianceList(bool alliancesOnly = false)
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
        public XmlDocument eveCertificateTree()
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
        /// Returns the ownerID for a given character, faction, alliance or <para/>
        /// corporation name, or the typeID for other objects such as stations,<para/>
        /// solar systems, planets, etc.
        /// </summary>
        /// <param name="names">Comma-separated list of character names<para/>
        /// to query.</param>
        /// <returns></returns>
        public XmlDocument eveCharacterID(string names)
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
        /// Without a supplied API key it will return the same data as a show <para/>
        /// info call on the character would do in the client. With a limited <para/>
        /// API key it will add total skill points as well as the current ship<para/>
        /// you are in and its name. Supplied with a full API key your account <para/>
        /// balance and your last known location (cached) will be added to the <para/>
        /// return.
        /// </summary>
        /// <returns></returns>
        public XmlDocument eveCharacterInfo()
        {
            XmlDocument xmldoc = new XmlDocument();
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();
            string response = null;

            sb.Append("https://api.eveonline.com/eve/CharacterInfo.xml.aspx?")
                .Append("&characterID=").Append(_characterID);

            if (_keyID != null && _vCode != null)
            {
                sb.Append("keyID=").Append(_keyID)
                .Append("&vCode=").Append(_vCode);
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
        /// Without a supplied API key it will return the same data as a show <para/>
        /// info call on the character would do in the client. With a limited <para/>
        /// API key it will add total skill points as well as the current ship<para/>
        /// you are in and its name. Supplied with a full API key your account <para/>
        /// balance and your last known location (cached) will be added to the <para/>
        /// return.
        /// </summary>
        /// <param name="characterID">Character ID of the player.</param>
        /// <param name="keyID">Optional - Key ID of account for authentication.
        /// </param>
        /// <param name="vCode">Optional - Limited or Full access API key of <para/>
        /// account.</param>
        /// <returns></returns>
        public XmlDocument eveCharacterInfo(string characterID, string keyID = null, string vCode = null)
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
        /// <param name="ids">Comma-separated list of ownerIDs (characterID, <para/>
        /// agentID, corporationID, allianceID, or factionID) and typeIDs to <para/>
        /// query. A hard maximum of 250 IDs passed in. Might change in the <para/>
        /// future depending on live results. Any instances of repeated ids in <para/>
        /// the string will throw immediate errors with no returns. If an ID is<para/>
        /// passed into the call that does not resolve the call will not return <para/>
        /// any results regardless of the validity of other ids. Trailing commas<para/>
        /// on the ids input will throw now errors.</param>
        /// <returns></returns>
        public XmlDocument eveCharacterName(string ids)
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
        public XmlDocument eveConquerableStationList()
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
        /// Returns a list of error codes that can be returned by the EVE API <para/>
        /// servers. Error types are broken into the following categories <para/>
        /// according to their first digit:<para/>
        /// 1xx - user input<para/>
        /// 2xx - authentication<para/>
        /// 5xx - server<para/>
        /// 9xx - miscellaneous
        /// </summary>
        /// <returns></returns>
        public XmlDocument eveErrorList()
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
        /// Returns global stats on the factions in factional warfare including<para/>
        /// the number of pilots in each faction, the number of systems they <para/>
        /// control, and how many kills and victory points each and all factions<para/>
        /// obtained yesterday, in the last week, and total.
        /// </summary>
        /// <returns></returns>
        public XmlDocument eveFacWarStats()
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
        public XmlDocument eveFacWarTopStats()
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
        public XmlDocument eveRefTypes()
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
        public XmlDocument eveSkillTree()
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
        /// <param name="ids">Comma-separated list of typeIDs to query<para/>
        /// A hard maximum of 250 IDs passed in. Any instances of repeated ids <para/>
        /// in the string will throw immediate errors with no returns. If an ID<para/>
        /// is passed into the call that does not resolve the call will not <para/>
        /// return any results regardless of the validity of other ids. Trailing <para/>
        /// commas on the ids input will throw now errors.</param>
        /// <returns></returns>
        public XmlDocument eveTypeName(string ids)
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
        public XmlDocument mapSovereignty()
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
        /// Returns the number of kills in solarsystems within the last hour. <para/>
        /// Only solar system where kills have been made are listed, so assume <para/>
        /// zero in case the system is not listed.
        /// </summary>
        /// <returns></returns>
        public XmlDocument mapKills()
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
        /// Only systems with jumps are shown, if the system has no jumps, it's<para/>
        /// not listed.
        /// </summary>
        /// <returns></returns>
        public XmlDocument mapJumps()
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
        /// Returns a list of contestable solarsystems and the NPC faction<para/>
        /// currently occupying them. It should be noted that this file <para/>
        /// only returns a non-zero ID if the occupying faction is not the <para/>
        /// sovereign faction.
        /// </summary>
        /// <returns></returns>
        public XmlDocument mapFacWarSystems()
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
        /// Returns the System.Drawing.Image of the specified inventory item.<para/>
        /// Requires adding the System.Drawing assembly and namespace.
        /// </summary>
        /// <param name="typeID">ID of the inventory item.</param>
        /// <param name="size">Size of the image. Valid values are 30, 32, <para/>
        /// 64, 128, 256, and 512.</param>
        /// <returns></returns>
        public Image imageRender(string typeID, int size)
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
        /// Returns the System.Drawing.Image of the specified inventory item.<para/>
        /// Requires adding the System.Drawing assembly and namespace.
        /// </summary>
        /// <param name="typeID">ID of the inventory item.</param>
        /// <param name="size">Size of the portrait. Valid values are 32, and 64.</param>
        /// <returns></returns>
        public Image imageTypeIcon(string typeID, int size)
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
        /// Returns the System.Drawing.Image of the specified alliance.<para/>
        /// Requires adding the System.Drawing assembly and namespace.
        /// </summary>
        /// <param name="allianceID">ID of the alliance.</param>
        /// <param name="size">Size of the portrait. Valid values are 30, 32, <para/>
        /// 64, 128.</param>
        /// <returns></returns>
        public Image imageAlliance(string allianceID, int size)
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
        /// Returns the System.Drawing.Image of the specified corporation.<para/>
        /// Requires adding the System.Drawing assembly and namespace.
        /// </summary>
        /// <param name="corporationID">ID of the corporation.</param>
        /// <param name="size">Size of the portrait. Valid values are 30, 32, <para/>
        /// 64, 128, 256.</param>
        /// <returns></returns>
        public Image imageCorporation(string corporationID, int size)
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
        /// Returns the System.Drawing.Image of the specified character.<para/>
        /// Requires adding the System.Drawing assembly and namespace.
        /// </summary>
        /// <param name="size">Valid sizes are 30, 32, 64, 128, 200, <para/>
        /// 256, 512, or 1024.</param>
        /// <returns></returns>
        public Image imageCharacter(int size)
        {
            Image img = null;
            WebClient web = new WebClient();
            StringBuilder sb = new StringBuilder();

            sb.Append("http://image.eveonline.com/Character/")
                .Append(_characterID).Append("_").Append(size.ToString())
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

        /// <summary>
        /// Returns the System.Drawing.Image of the specified character.<para/>
        /// Requires adding the System.Drawing assembly and namespace.
        /// </summary>
        /// <param name="characterID">ID of the character.</param>
        /// <param name="size">Valid sizes are 30, 32, 64, 128, 200, <para/>
        /// 256, 512, or 1024.</param>
        /// <returns></returns>
        public Image imageCharacter(string characterID, int size)
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
        public XmlDocument serverStatus()
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
