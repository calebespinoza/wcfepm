using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EPMWebClient2.AuthenticationReference;

namespace EPMWebClient2
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            AuthenticationServiceClient au = new AuthenticationServiceClient();
            string user = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            bool autenticacion = au.ValidateUser(user, password);
            if (!autenticacion)
            {
                lblError.Visible = true;
                lblError.Text ="ERROR: Username or Password incorrect";
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
                return;
            }
            Session["User"] = user;
            Response.Redirect("Readings.aspx");
            
        }
    }
}