using SocialSlider.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SocialSlider.Core.Servants
{
    class InstagramServant : IInstagramServant
    {
        // TOOD:
        private string searchByTagUrlPattern = "https://api.instagram.com/v1/tags/{0}/media/recent?client_id={1}";
        private string clientID = "b87c4abd8bff4dfda3299f64031f82c7";

        public InstagramServant()
        {
        }

        /// <summary>
        /// Search by tag
        /// </summary>
        /// <param name="tagName"></param>
        public void SearchByTag(string tagName)
        {
            string reQuestUrl = String.Format(searchByTagUrlPattern, tagName, clientID);

            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(reQuestUrl);
            
            request.Method = "GET";
            string result = String.Empty;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                result = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
            }

            // return
        }
   
    }
}
