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
using COM.Model;

namespace COM.View
{
    public partial class MainForm : Form
    {
        private ComController _controller;

        public MainForm()
        {
            InitializeComponent();
        }


        #region ====================================|  Data Functions  |=========

        private void populateDgv()
        {
            if (this._controller.CustomersList != null)
                this.customersDgv.DataSource = this._controller.CustomersList;
            else
                throw new Exception("Local customer's list is null.");
        }


        #endregion ==============================================================


        #region =======================================|  Form events  |=========

        private void MainForm_Load(object sender, EventArgs e)
        {
            _controller = new ComController();
            _controller.LoadFiles();

            this.populateDgv();
        }

        // Menu Quit button:
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                // SAVE
                Application.Exit();
            }
        }

        // Populates the data of the selected customer GroupBox:
        private void customersDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.customersDgv.Rows[e.RowIndex];

                this.selectedCustIdTxt.Text = row.Cells["ID"].Value.ToString();
                this.selectedCustNameTxt.Text = row.Cells["Name"].Value.ToString();
                this.selectedCustPhoneTxt.Text = row.Cells["Phone"].Value.ToString();
                this.selectedCustAddressTxt.Text = row.Cells["Address"].Value.ToString();

                this.selectedOperationsGb.Enabled = true;
            }
        }

        // Create new Customer Button:
        private void selOpsCreateBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.selectedCustIdTxt.Text)
                && !string.IsNullOrWhiteSpace(this.selectedCustNameTxt.Text)
                && !string.IsNullOrWhiteSpace(this.selectedCustPhoneTxt.Text)
                && !string.IsNullOrWhiteSpace(this.selectedCustAddressTxt.Text))
            {
                Customer newCust = new Customer(int.Parse(this.selectedCustIdTxt.Text),
                                                                this.selectedCustNameTxt.Text,
                                                                int.Parse(this.selectedCustPhoneTxt.Text),
                                                                this.selectedCustAddressTxt.Text);

                if (this._controller.FindCustomer(newCust) == null)
                {
                    this.responceLbl.ForeColor = System.Drawing.Color.Black;
                    this.responceLbl.Text = "";

                    MessageBox.Show("New customer created: \n\r    - ID: " + newCust.ID
                                                         + "\n\r    - Name: " + newCust.Name
                                                         + "\n\r    - Phone: " + newCust.Phone
                                                         + "\n\r    - Address: " + newCust.Address
                                                         + "\n\r", "Success!");

                    // CALL the controller's Create-Customer Function:
                    this._controller.CreateCustomer(newCust);
                }
                else
                {
                    this.responceLbl.ForeColor = System.Drawing.Color.Red;
                    this.responceLbl.Text = "Customer with this ID already exists!";
                }
            }
            else
            {
                this.responceLbl.ForeColor = System.Drawing.Color.Red;
                this.responceLbl.Text = "No fields should be blank!";
            }
        }

        // Update Customer Button:
        private void selOpsUpdateBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.selectedCustIdTxt.Text)
                && !string.IsNullOrWhiteSpace(this.selectedCustNameTxt.Text)
                && !string.IsNullOrWhiteSpace(this.selectedCustPhoneTxt.Text)
                && !string.IsNullOrWhiteSpace(this.selectedCustAddressTxt.Text))
            {
                Customer cust = new Customer(int.Parse(this.selectedCustIdTxt.Text),
                                                                this.selectedCustNameTxt.Text,
                                                                int.Parse(this.selectedCustPhoneTxt.Text),
                                                                this.selectedCustAddressTxt.Text);
                if (this._controller.FindCustomer(cust) != null)
                {
                    if (MessageBox.Show("Are you sure you want to Update this customer?\n\r    - ID: " + cust.ID
                                                                                    + "\n\r    - Name: " + cust.Name
                                                                                    + "\n\r    - Phone: " + cust.Phone
                                                                                    + "\n\r    - Address: " + cust.Address
                                                                                    + "\n\r",
                            "Attention!",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // CALL the controller's Update-Customer Function:
                        this._controller.UpdateCustomer(cust);
                    }
                }
                else
                {
                    this.responceLbl.ForeColor = System.Drawing.Color.Red;
                    this.responceLbl.Text = "Customer with this ID does not exist!";
                }
            }
            else
            {
                this.responceLbl.ForeColor = System.Drawing.Color.Red;
                this.responceLbl.Text = "No fields should be blank!";
            }
        }

        // Delete Customer Button:
        private void selOpsDeleteBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.selectedCustIdTxt.Text)
                && !string.IsNullOrWhiteSpace(this.selectedCustNameTxt.Text)
                && !string.IsNullOrWhiteSpace(this.selectedCustPhoneTxt.Text)
                && !string.IsNullOrWhiteSpace(this.selectedCustAddressTxt.Text))
            {
                Customer oldCust = new Customer(int.Parse(this.selectedCustIdTxt.Text),
                                                                this.selectedCustNameTxt.Text,
                                                                int.Parse(this.selectedCustPhoneTxt.Text),
                                                                this.selectedCustAddressTxt.Text);

                if (this._controller.FindCustomer(oldCust) != null)
                {
                    this.responceLbl.ForeColor = System.Drawing.Color.Black;
                    this.responceLbl.Text = "";
                    
                    if (MessageBox.Show("Are you sure you want to delete this customer?\n\r    - ID: " + oldCust.ID 
                                                                                    + "\n\r    - Name: " + oldCust.Name
                                                                                    + "\n\r    - Phone: " + oldCust.Phone
                                                                                    + "\n\r    - Address: " + oldCust.Address
                                                                                    + "\n\r",
                            "Attention!",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // CALL the controller's Customer-Delete function:
                        this._controller.DeleteCustomer(oldCust);
                    }
                }
                else
                {
                    this.responceLbl.ForeColor = System.Drawing.Color.Red;
                    this.responceLbl.Text = "Customer with this ID does not exist!";
                }
            }
            else
            {
                this.responceLbl.ForeColor = System.Drawing.Color.Red;
                this.responceLbl.Text = "No fields should be blank!";
            }
        }


        #endregion ==============================================================
        
    }
}
