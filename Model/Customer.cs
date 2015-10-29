using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM.Model
{
    public class Customer
    {
        private int _id;
        public int ID
        {
            get { return this._id; }
            set
            {
                if (value < int.MinValue || value > int.MaxValue)
                    Console.WriteLine("ID value out of range!");
                else
                    this._id = value;
            }
        }

        private string _name;
        public string Name
        {
            get { return this._name; }
            set
            {
                if (value.Length > 100)
                    Console.WriteLine("Name value is too long!");
                else
                    this._name = value;
            }
        }

        private long _phone;
        public long Phone
        {
            get { return this._phone; }
            set
            {
                if (value < long.MinValue || value > long.MaxValue)
                    Console.WriteLine("Phone value out of range!");
                else
                    this._phone = value;
            }
        }

        private string _address;
        public string Address
        {
            get { return this._address; }
            set
            {
                if (value.Length > 200)
                    Console.WriteLine("Address value is too long!");
                else
                    this._address = value;
            }
        }

        public Customer(int customerID, string customerName, long customerPhone, string customerAddress)
        {
            this.ID = customerID;
            this.Name = customerName;
            this.Phone = customerPhone;
            this.Address = customerAddress;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Customer))
                return false;
            return this._id == ((Customer)obj)._id &&
                    this._name == ((Customer)obj)._name &&
                    this._phone == ((Customer)obj)._phone &&
                    this._address == ((Customer)obj)._address;
        }
    }
}
