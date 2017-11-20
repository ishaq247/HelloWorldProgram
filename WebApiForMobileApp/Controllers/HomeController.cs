using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiForMobileApp.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetText()
        {
            try
            {
                var message = Request.CreateResponse(HttpStatusCode.OK, "Hello World");
                message.Headers.Location = new Uri(Request.RequestUri.ToString());
                return message;
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
