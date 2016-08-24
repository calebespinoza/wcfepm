using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EPMCliente1.AuthenticactionServiceReference;

namespace EPMCliente1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            AuthenticationServiceClient au = new AuthenticationServiceClient();
            string usuario = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();
            bool autenticacion = au.ValidateUser(usuario, password);
            if (!autenticacion)
            {
                MessageBox.Show("Username or Password incorrect", "ERROR");
                txtUserName.Text = "";
                txtPassword.Text = "";
                txtUserName.Focus();
                return;
            }
            this.Hide();
            frmReadings formReadings = new frmReadings();
            formReadings.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
