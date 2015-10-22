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
        IModel _passingObject;
        public myViewEventArgs(IModel value)
        {
            this._passingObject = value;
        }
    }

    public interface IView
    {
        void SetController(ComController controller);
        event ViewHandler<IView> changed;
    }
}
