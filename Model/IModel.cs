using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM.Model
{
    public delegate void ModelHandler<IView>(IView sender, myModelEventArgs e);

    public class myModelEventArgs: EventArgs
    {
        IModel _passingobject;
        public myModelEventArgs(IModel obj)
        {
            this._passingobject = obj;
        }
    }

    public interface IModel
    {
        void SaveData();
    }
}
