using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM.Model
{
    public delegate void ModelHandler<IModel>(IModel sender, myModelEventArgs e);

    public class myModelEventArgs: EventArgs
    {
        Customer _passingCustomer;
        Order _passingOrder;

        public myModelEventArgs(Customer cust, Order ord)
        {
            this._passingCustomer = cust;
            this._passingOrder = ord;
        }
    }

    public interface IModel
    {
        void LoadFiles();
        void SaveData();
    }
}
