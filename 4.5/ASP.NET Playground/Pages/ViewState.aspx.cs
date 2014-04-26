using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_Playground.Pages
{
    public partial class ViewState : System.Web.UI.Page
    {
        public int Count
        {
            get { return (int)ViewState["count"]; }
            set { ViewState["count"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Count = 0;
            }
            else
            {
                Count++;
            }
            lblCounter.Text = string.Format("You've postbacked {0} times", Count);
        }

        protected void btnPost_Click(object sender, EventArgs e)
        {
        }
    }
}