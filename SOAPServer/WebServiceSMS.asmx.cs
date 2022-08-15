using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SOAPServer
{
    /// <summary>
    /// Summary description for WebServiceSMS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceSMS : System.Web.Services.WebService
    {

        [WebMethod]
        public string SendSMS(string text, string number)
        {
            //
            //
            return "Sent sms successfuly";
        }
    }
}
