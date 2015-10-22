using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using COM.Controller;
using COM.View;
using COM.Model;

namespace COM
{
    /*
     * COM project: Customers-Orders Management.
     * 
     * Implementing MVC.
     * 
     */
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MainForm StartForm = new MainForm();

            ComController myController = new ComController(StartForm, new Datamanipulation());
            StartForm.SetController(myController);
            StartForm.ShowDialog();
            
        }
    }
}
