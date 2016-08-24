using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EPMWebClient2.CRUDCustomerReference;

namespace EPMWebClient2
{
    public partial class Readings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblUser.Text = Session["User"] + "";
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            CRUDCustomerServiceClient search = new CRUDCustomerServiceClient();
            
            int IDClient;
            try
            {
                IDClient = Convert.ToInt32(txtIDClient.Text);
            }
            catch (Exception)
            {
                IDClient = 0;
            }

            Customer customer = search.getCustomer(IDClient);
            lblError.Text = "";
            if (customer == null)
            {
                lblError.Text = "ERROR. ID not exist!!!";

                Label2.Visible = false;
                lblPhone.Visible = false;

                Label3.Visible = false;
                lblCurrentReadings.Visible = false;

                chbRead.Visible = false;

                Label4.Visible = false;
                txtNewReading.Visible = false;
                btnUpdate.Visible = false;
                txtIDClient.Focus();
                return;
            }
            lblPhone.Text = customer.Phone;
            lblCurrentReadings.Text = customer.LastReading.ToString();
            chbRead.Checked = customer.Read;

            Label2.Visible = true;
            lblPhone.Visible = true;

            Label3.Visible = true;
            lblCurrentReadings.Visible = true;

            chbRead.Visible = true;

            if (!customer.Read)
            {
                Label4.Visible = true;
                txtNewReading.Visible = true;
                btnUpdate.Visible = true;
                txtNewReading.Focus();
            }
            else
            {
                Label4.Visible = false;
                txtNewReading.Visible = false;
                btnUpdate.Visible = false;
            }

        }

        protected void lbtnLogOut_Click(object sender, EventArgs e)
        {
            Session["User"] = null;
            Response.Redirect("index.aspx");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            CRUDCustomerServiceClient update = new CRUDCustomerServiceClient();
            int IDClient;
            try
            {
                IDClient = Convert.ToInt32(txtIDClient.Text);
            }
            catch (Exception)
            {
                IDClient = 0;
            }

            int CurrentReading;
            try
            {
                CurrentReading = Convert.ToInt32(lblCurrentReadings.Text);
            }
            catch (Exception)
            {
                CurrentReading = 0;
            }

            int NewReading;
            try
            {
                NewReading = Convert.ToInt32(txtNewReading.Text);
            }
            catch (Exception)
            {
                NewReading = 0;
            }

            if (NewReading < CurrentReading)
            {
                txtNewReading.Text = "";
                txtNewReading.Focus();
                lblError.Text = "ERROR. The NEW reading can't be smaller to the CURRENT reading.";
                return;
            }

            update.UpdateLastReading(IDClient, NewReading);
            lblError.Text = "MESSAGE. Updating Succesfull!";

            Label2.Visible = false;
            lblPhone.Visible = false;

            Label3.Visible = false;
            lblCurrentReadings.Visible = false;

            chbRead.Visible = false;

            Label4.Visible = false;
            txtNewReading.Visible = false;
            btnUpdate.Visible = false;
            txtIDClient.Focus();

        }
    }
}