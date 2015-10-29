using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using COM.Controller;
using COM.View;
using COM.Model;

namespace COM.View
{
    public delegate void ViewHandler<IView>(IView sender, myViewEventArgs e);

    public class myViewEventArgs : EventArgs
    {
        Customer _passingCustomer;
        Order _passingOrder;
        public myViewEventArgs(Customer cust, Order ord)
        {
            this._passingCustomer = cust;
            this._passingOrder = ord;
        }
    }

    public interface IView
    {
        void SetController(ComController controller);
        event ViewHandler<IView> viewChanged;
    }
}
