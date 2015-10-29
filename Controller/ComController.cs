using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using COM.Model;
using COM.View;

namespace COM.Controller
{
    public class ComController
    {
        IView _myView; Datamanipulation _myModel;

        public ComController(IView view, Datamanipulation model)
        {
            this._myView = view;
            this._myModel = model;

            _myView.SetController(this);
            
            // Need to cast IView v TO MainForm. What for orders form ? =======
            this._myModel.Subscribe((MainForm)view);

            // Notify if the view is changed: 
            this._myView.viewChanged += new ViewHandler<IView>(this.ViewChangeDetected);

            // ???
            // view.changed += new ViewHandler<IView>(this.CustomerAdded);
        }


        public void ViewChangeDetected(IView sender, myViewEventArgs info)
        {
            // NEED new func for different view changes (create, delete).
            // update list ?
            
        }

        public void LoadFiles()
        {
            this._myModel.LoadFiles();
        }

        // Method that saves any changes to our local lists to the source files.
        public void SaveData()
        {
            this._myModel.SaveData();
        }

        public List<Customer> ReturnCustomerList()
        {
            return this._myModel.CustomersList;
        }
        public List<Order> ReturnOrderList()
        {
            return this._myModel.OrdersList;
        }

        public void CreateCustomer(Customer c)
        {
            this._myModel.CreateCustomer(c);
        }
        public void UpdateCustomer(Customer c)
        {
            this._myModel.UpdateCustomer(c);
        }
        public Customer FindCustomer(Customer c)
        {
            return this._myModel.FindCustomer(c);
        }
        public void DeleteCustomer(Customer c)
        {
            this._myModel.DeleteCustomer(c);
        }
    }
}
