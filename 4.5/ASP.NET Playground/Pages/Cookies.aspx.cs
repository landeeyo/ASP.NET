using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_Playground.Pages
{
    public partial class Cookies : System.Web.UI.Page
    {
        public string Message { get { return "You're last visit datetime: " + LastVisit; } }

        public string LastVisit
        {
            get
            {
                if (Request.Cookies["StudentCookies"] != null && Request.Cookies["StudentCookies"].Value != null)
                {
                    return Request.Cookies["StudentCookies"].Value.ToString();
                }
                else
                {
                    return "It's your first visit";
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            lblCounter.Text = Message;
            Response.Cookies["StudentCookies"].Value = DateTime.Now.ToString();
            Response.Cookies["StudentCookies"].Expires = DateTime.Now.AddDays(1);
        }
    }
}