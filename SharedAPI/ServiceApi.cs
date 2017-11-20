using SharedAPI.Interfaces;
using SharedAPI.Repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SharedAPI.Applications
{
    public class ServiceApi : IGetMessage
    {
        LogFile log = new LogFile();
        public ServiceApi()
        {
            log.Write("Calling service..." + DateTime.Now.ToString());
            //OR Log to Database
        }

        public async Task<string> GetMessage()
        {
            log.Write("-->GetMessage... " + DateTime.Now.ToString());
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            Uri baseUri = GetUri();
            HttpResponseMessage response = await client.GetAsync(baseUri).ConfigureAwait(false);
            var replyMessage = response.Content.ReadAsStringAsync();
            log.Write("<--GetMessage...");
            return replyMessage.Result;
        }

        public Uri GetUri()
        {
            log.Write("-->GetMessage...");
            string serverString = ConfigurationManager.AppSettings["ServiceUri"];
            Uri serviceUri = new Uri(serverString);
            log.Write("<--GetMessage...");
            return serviceUri;
        }
    }
}
