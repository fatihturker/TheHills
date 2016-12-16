using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace The_Hills
{
    public class Requester
    {
        public string GetWebRequest(string address)
        {
            WebRequest request = WebRequest.Create(address);
            HttpWebRequest webRequest = request as HttpWebRequest;
            string responseText = string.Empty;
            if (webRequest != null)
            {
                WebResponse response = webRequest.GetResponse();
                using (var reader = new System.IO.StreamReader(response.GetResponseStream()))
                {
                    responseText = reader.ReadToEnd();
                }
            }
            return responseText;
        }
    }
}
