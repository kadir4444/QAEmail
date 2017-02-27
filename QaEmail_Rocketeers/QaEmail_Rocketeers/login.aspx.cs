using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QaEmail_Rocketeers
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["Email_Address"] != null && Request.Cookies["Password"] != null)
                {
                    TextBox3.Text = Request.Cookies["Email_Address"].Value;
                    TextBox4.Attributes["value"] = Request.Cookies["Password"].Value;
                }
            }
        
    }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(rememberMe.Checked)
            {
                Response.Cookies["Email_Address"].Expires = DateTime.Now.AddDays(30);
                Response.Cookies["Password"].Expires = DateTime.Now.AddDays(30);
            }
            else
            {
                Response.Cookies["Email_Address"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["Password"].Expires = DateTime.Now.AddDays(-1);

            }
            Response.Cookies["Email_Address"].Value = TextBox1.Text.Trim();
            Response.Cookies["Password"].Value = TextBox2.Text.Trim();

        }
    }
}