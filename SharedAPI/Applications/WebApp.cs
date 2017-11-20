using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedAPI.Applications
{
    public class WebApp : IWriteMessage
    {
        public void WriteText(string message)
        {
            System.Web.HttpContext.Current.Response.Write("<h1 style='color:red;'>" + message + "</h1>"); 
        }
    }
}
