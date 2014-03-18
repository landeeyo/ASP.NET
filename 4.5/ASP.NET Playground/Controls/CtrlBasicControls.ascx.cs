using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_Playground.Controls
{
    public partial class CtrlBasicControls : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblLabel.Text = "Label";
                txtTextBox.Text = "TextBox";

                var items =
                    new ListItemCollection { 
                    new ListItem { Text = "First", Value = "1" }, 
                    new ListItem { Text = "Second", Value = "2" }, 
                    new ListItem { Text = "Third", Value = "3" } };
                ddlDropDownList.DataSource = items;
                ddlDropDownList.DataBind();

                rblRadioButtonList.DataSource = items;
                rblRadioButtonList.DataBind();

                lbtLinkButton.Text = "Link button";
                btnButton.Text = "Button";
            }
        }

        protected void lbtLinkButton_Click(object sender, EventArgs e)
        {
            btnButton.Visible = !btnButton.Visible;
        }

        protected void btnButton_Click(object sender, EventArgs e)
        {
            lblUpdatePanelLabel.Text = DateTime.Now.ToString();
        }        
    }
}