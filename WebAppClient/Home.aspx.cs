using SharedAPI;
using SharedAPI.Applications;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppClient
{
    public partial class Home : System.Web.UI.Page
    {
        ServiceApi api = null;
        public Home()
        {
            api = new ServiceApi(); 
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Task<string> result = api.GetMessage();
            Response.Write(result.Result);
        }
    }
}