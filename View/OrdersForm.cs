using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using COM.Controller;

namespace COM.View
{
    public partial class OrdersForm : Form
    {
        ComController _controller;
        public OrdersForm()
        {
            InitializeComponent();
        }
        
        public OrdersForm(ComController cont) : this()
        {
            this._controller = cont;
        }
        


        private void populateDgv()
        {
            if (this._controller.ReturnOrderList() != null)
                this.ordersDgv.DataSource = this._controller.ReturnOrderList();
            else
                throw new Exception("Local order's list is null.");
        }
    }
}
