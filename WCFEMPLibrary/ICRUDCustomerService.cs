using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFEMPLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICRUDCustomerService" in both code and config file together.
    [ServiceContract]
    public interface ICRUDCustomerService
    {
        [OperationContract]
        Customer getCustomer(int IDClient);

        [OperationContract]
        void UpdateLastReading(int IDClient, int newReading);
    }

    [DataContract]
    public class Customer
    {
        [DataMember]
        public int IDClient { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public int LastReading { get; set; }
        [DataMember]
        public bool Read { get; set; }
    }
}
