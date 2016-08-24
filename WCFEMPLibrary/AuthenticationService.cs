using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WCFEMPLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class AuthenticationService : IAuthenticationService
    {

        public bool ValidateUser(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = '" + username + "' AND Clave = '" + password + "'";
            Object contador;
            int nroFilas;

            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.EPMConectionString);
            SqlCommand cmd = new SqlCommand(query, conexion);
            conexion.Open();
            contador = cmd.ExecuteScalar();
            nroFilas = int.Parse(contador.ToString());
            if (nroFilas == 1)
            {
                return true;
            }
            return false;
        }
    }
}
