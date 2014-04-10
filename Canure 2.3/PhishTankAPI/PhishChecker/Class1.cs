// PhishTank API
// Written for use in Canure 
//
// --- Developer Information --->
// Developer: Antwan Kakki
// Designation: Developer - Canure 2.3/2.4
// Company: Blix Corporation
// <-- Developer Information ---
//
// This code is not licensed under GNU or any other open source license so you're not allowed to use it without permission from Blix Corporation or the developer. This library and code is a property of Blix Corporation

// Import required libs
using System.Net;
using System.Xml.Linq;

namespace PhishtankAPI
{
    public class PhishChecker
    {
        // Create a new WebClient for downloading data
        WebClient x = new WebClient();

        public bool CheckUrl(string url)
        {
            // Download data regarding the URL
            string xml = x.DownloadString("http://checkurl.phishtank.com/checkurl/index.php?format=xml&app_key="YOUR API KEY"&url=" + url);
            // Parse the XML data
            XDocument doc = XDocument.Parse(xml);

            // CHeck if the Node value is True Or False
            if (doc.ToString().Contains("true"))
            {
                // Its true, that means it a phish.
                return true;
            }
            else
            {
                // Not a phish
                return false;
            }
        }
    }
}