using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using COM.Controller;
using COM.View;

namespace COM.Model
{
    public class Datamanipulation : IModel
    {
        // EVENT!
        public event ModelHandler<IModel> modelChanged;

        private string _customerFilePath, _orderFilePath;
        public string CustomerFilePath
        {
            get { return this._customerFilePath; }
        }
        public string OrderFilePath
        {
            get { return this._orderFilePath; }
        }

        private List<Customer> _customersList;
        public List<Customer> CustomersList
        {
            get { return this._customersList; }
            set
            {
                if (value != null)
                    this._customersList = value;
                else
                    throw new Exception("Trying to set local customer's list to null!");
            }
        }

        private List<Order> _ordersList;
        public List<Order> OrdersList
        {
            get { return this._ordersList; }
            set
            {
                if (value != null)
                    this._ordersList = value;
                else
                    throw new Exception("Trying to set local order's list to null!");

            }
        }

        public Datamanipulation()
        {
            this._customerFilePath = "customers.txt";
            this._orderFilePath = "orders.txt";
            

        }



        public void Subscribe(MainForm myView)
        {
            modelChanged += new ModelHandler<IModel>(myView.ModelChangedEvent);
        }



        #region ================================================|  Data Functions  |=========

        public void LoadFiles()
        {
            if (File.Exists(CustomerFilePath) && File.Exists(OrderFilePath))
            {
                this.CustomersList = this.FetchCustomerList();
                this.OrdersList = this.FetchOrderList();
            }
            else
                throw new Exception("FNF");
        }

        public void SaveData()
        {
            // Sort the local lists:
            List<Customer> custSorted = this.CustomersList.OrderBy(o => o.ID).ToList();
            List<Order> ordSorted = this.OrdersList.OrderBy(o => o.OrderID).ToList();

            StreamWriter custAuthor = new StreamWriter(this.CustomerFilePath);
            foreach (Customer cust in custSorted)
            {
                string customerLine = cust.ID.ToString() + "." + cust.Name + "." + cust.Phone.ToString() + "." + cust.Address;
                custAuthor.WriteLine(customerLine);
            }

            StreamWriter ordAuthor = new StreamWriter(this.OrderFilePath);
            foreach (Order ord in ordSorted)
            {
                string orderLine = ord.OrderID.ToString() + "." + ord.CustomerID.ToString() + "." + ord.Details;
                ordAuthor.WriteLine(orderLine);
            }

            custAuthor.Close();
            ordAuthor.Close();
        }


        #endregion ==========================================================================



        #region =======================================|  Customer Data Functions  |=========

        // Method that populates the local Customer's List with data from the source file.
        public List<Customer> FetchCustomerList()
        {
            List<Customer> dataList = new List<Customer>();
            StreamReader sr = new StreamReader(_customerFilePath);
            string[] aLine;

            do
            {
                aLine = sr.ReadLine().Split('.');
                dataList.Add(new Customer(int.Parse(aLine[0]), aLine[1], long.Parse(aLine[2]), aLine[3]));
            } while (sr.Peek() != -1);

            sr.Close();

            // Sort the list (not obligatory)
            //dataList = dataList.OrderBy(o => o.ID).ToList();

            return dataList;
        }

        // Method that adds a Customer to the list.
        public void CreateCustomer(Customer customerToCreate)
        {
            this.CustomersList.Add(customerToCreate);

            // Fire Event:
            modelChanged(this, new myModelEventArgs(customerToCreate, null));

            // Save data to files:
            this.SaveData();
        }

        // Method that searches the list for a customer. Returns the customer object if he is found,
        // or else null.
        public Customer FindCustomer(Customer customerToFind)
        {
            Customer customer = null;

            foreach (Customer cust in this.CustomersList)
            {
                if (cust.ID == customerToFind.ID)
                    return cust;
            }

            return customer;
        }

        // Method that updates an existing customer's info.
        public void UpdateCustomer(Customer customerToUpdate)
        {
            Customer oldCustomer = this.FindCustomer(customerToUpdate);
            if (oldCustomer != null)
            {
                oldCustomer.ID = customerToUpdate.ID;
                oldCustomer.Name = customerToUpdate.Name;
                oldCustomer.Phone = customerToUpdate.Phone;
                oldCustomer.Address = customerToUpdate.Address;

                // Fire event:
                modelChanged(this, new myModelEventArgs(customerToUpdate, null));

                // Save data to files:
                this.SaveData();
            }
        }

        // Method that removes a Customer from the list.

        public void DeleteCustomer(Customer customerToDelete)
        {
            this.CustomersList.Remove(customerToDelete);

            // Fire Event:
            modelChanged(this, new myModelEventArgs(customerToDelete, null));

            // Save data to files:
            this.SaveData();
        }

        #endregion ==========================================================================



        #region ==========================================|  Order Data Functions  |=========

        // Method that populates the local Order's List with data from the source file.
        public List<Order> FetchOrderList()
        {
            List<Order> dataList = new List<Order>();
            StreamReader sr = new StreamReader(_orderFilePath);
            string[] aLine;

            do
            {
                aLine = sr.ReadLine().Split('.');
                dataList.Add(new Order(int.Parse(aLine[0]), int.Parse(aLine[1]), aLine[2]));
            } while (sr.Peek() != -1);

            sr.Close();

            // Sort the list (not obligatory)
            //dataList = dataList.OrderBy(o => o.ID).ToList();

            return dataList;
        }

        #endregion ==========================================================================

    }
}
