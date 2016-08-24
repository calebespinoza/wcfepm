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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CRUDCustomerService" in both code and config file together.
    public class CRUDCustomerService : ICRUDCustomerService
    {

        public Customer getCustomer(int IDClient)
        {
            Customer customerData = new Customer();
            string query = "SELECT * FROM Clientes WHERE IDCliente = @IDClient";
            SqlConnection cnn = new SqlConnection(Properties.Settings.Default.EPMConectionString);
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.Add(new SqlParameter("@IDClient", IDClient));
            cnn.Open();
            SqlDataReader CustomerReader = cmd.ExecuteReader();
            if (!CustomerReader.Read())
            {
                return null;
            }
            else
            {
                customerData.IDClient = CustomerReader.GetInt32(0);
                customerData.Phone = CustomerReader.GetString(1);
                customerData.LastReading = CustomerReader.GetInt32(2);
                customerData.Read = CustomerReader.GetBoolean(3);
                return customerData;
            }
        }


        public void UpdateLastReading(int IDClient, int newReading)
        {
            string query = "UPDATE Clientes SET UltimaLectura = @NewReading, Leido = 1 WHERE IDCliente = @IDClient";
            SqlConnection cnn = new SqlConnection(Properties.Settings.Default.EPMConectionString);
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.Add(new SqlParameter("@IDClient", IDClient));
            cmd.Parameters.Add(new SqlParameter("@NewReading", newReading));
            cnn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
