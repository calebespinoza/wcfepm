using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EPMCliente1.CRUDCustomerReferences;

namespace EPMCliente1
{
    public partial class frmReadings : Form
    {
        public frmReadings()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
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
            Customer dataCustomer = search.getCustomer(IDClient);
            if (dataCustomer == null)
            {
                txtIDClient.Text = "";
                txtPhone.Text = "";
                txtCurrentReading.Text = "";
                txtIDClient.Focus();
                MessageBox.Show("ID not exist!", "ERROR");
                txtNewReading.Enabled = false;
                btnUpdate.Enabled = false;
                chbRead.Checked = false;
                return;
            }
            txtPhone.Text = dataCustomer.Phone;
            txtCurrentReading.Text = dataCustomer.LastReading.ToString();
            chbRead.Checked = dataCustomer.Read;

            if (!dataCustomer.Read)
            {
                txtNewReading.Enabled = true;
                btnUpdate.Enabled = true;
                txtNewReading.Text = "";
                txtNewReading.Focus();
            }
            else
            {
                txtNewReading.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
                CurrentReading = Convert.ToInt32(txtCurrentReading.Text);
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
                MessageBox.Show("The NEW reading can't be smaller to the CURRENT reading.", "ERROR");
                return;
            }
            update.UpdateLastReading(IDClient, NewReading);
            MessageBox.Show("Updating Succesfull!", "MESSAGE");
            txtIDClient.Text = "";
            txtPhone.Text = "";
            txtCurrentReading.Text = "";
            txtNewReading.Text = "";
            chbRead.Checked = false;
            txtNewReading.Enabled = false;
            btnUpdate.Enabled = false;
            txtIDClient.Focus();
        }
    }
}
