using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM.Model
{
    public class Order 
    {
        private int _id;
        public int OrderID
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

        private int _custId;
        public int CustomerID
        {
            get { return this._custId; }
            set
            {
                if (value < int.MinValue || value > int.MaxValue)
                    Console.WriteLine("ID value out of range!");
                else
                    this._custId = value;
            }
        }

        private string _details;
        public string Details
        {
            get { return this._details; }
            set
            {
                if (value.Length > 500)
                    Console.WriteLine("Address value is too long!");
                else
                    this._details = value;
            }
        }
        public Order(int orderId, int customerId, string details)
        {
            this.OrderID = orderId;
            this.CustomerID = customerId;
            this.Details = details;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Order))
                return false;
            return this._id == ((Order)obj)._id &&
                    this._custId == ((Order)obj)._custId &&
                    this._details == ((Order)obj)._details;
        }
    }
}
