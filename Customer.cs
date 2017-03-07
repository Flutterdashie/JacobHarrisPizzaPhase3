using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JacobHarrisPizzaPhase1
{
    public class Customer
    {
        private string custPhone;
        private string custName;
        private string custAddr1;
        private string custAddr2;
        private string custCity;
        private string custState;
        private string custZip;

        public Customer()
        {

        }
        public Customer(string phone, string name, string addr1, string addr2, string city, string state, string zip)
        {
            this.Phone = phone;
            this.Name = name;
            this.Addr1 = addr1;
            this.Addr2 = addr2;
            this.City = city;
            this.State = state;
            this.Zip = zip;
        }
        public string Phone
        {
            get
            {
                return custPhone;
            }
            set
            {
                custPhone = value;
            }
        }
        public string Name
        {
            get
            {
                return custName;
            }
            set
            {
                custName = value;
            }
        }
        public string Addr1
        {
            get
            {
                return custAddr1;
            }
            set
            {
                custAddr1 = value;
            }
        }
        public string Addr2
        {
            get
            {
                return custAddr2;
            }
            set
            {
                custAddr2 = value;
            }
        }
        public string City
        {
            get
            {
                return custCity;
            }
            set
            {
                custCity = value;
            }
        }
        public string State
        {
            get
            {
                return custState;
            }
            set
            {
                custState = value;
            }
        }
        public string Zip
        {
            get
            {
                return custZip;
            }
            set
            {
                custZip = value;
            }
        }
    }
}
