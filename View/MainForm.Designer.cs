namespace COM.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quiteToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.customersGb = new System.Windows.Forms.GroupBox();
            this.customersDgv = new System.Windows.Forms.DataGridView();
            this.selecterCustGb = new System.Windows.Forms.GroupBox();
            this.selectedCustAddressTxt = new System.Windows.Forms.TextBox();
            this.selectedCustPhoneTxt = new System.Windows.Forms.TextBox();
            this.selectedCustNameTxt = new System.Windows.Forms.TextBox();
            this.selectedCustIdTxt = new System.Windows.Forms.TextBox();
            this.selectedOperationsGb = new System.Windows.Forms.GroupBox();
            this.selOpsCreateBtn = new System.Windows.Forms.Button();
            this.selOpsDeleteBtn = new System.Windows.Forms.Button();
            this.selOpsUpdateBtn = new System.Windows.Forms.Button();
            this.selectedCustOrderGroup = new System.Windows.Forms.GroupBox();
            this.SelectedCustomerOrders = new System.Windows.Forms.Button();
            this.selectedAddressLbl = new System.Windows.Forms.Label();
            this.selectedPhoneLbl = new System.Windows.Forms.Label();
            this.selectedNameLbl = new System.Windows.Forms.Label();
            this.selectedIdLbl = new System.Windows.Forms.Label();
            this.responceLbl = new System.Windows.Forms.Label();
            this.mainMenu.SuspendLayout();
            this.customersGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDgv)).BeginInit();
            this.selecterCustGb.SuspendLayout();
            this.selectedOperationsGb.SuspendLayout();
            this.selectedCustOrderGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.orderToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(988, 24);
            this.mainMenu.TabIndex = 10;
            this.mainMenu.Text = "Menu";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.quiteToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // quiteToolStripMenuItem
            // 
            this.quiteToolStripMenuItem.Name = "quiteToolStripMenuItem";
            this.quiteToolStripMenuItem.Size = new System.Drawing.Size(94, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCustomerToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.deleteToolStripMenuItem1});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // newCustomerToolStripMenuItem
            // 
            this.newCustomerToolStripMenuItem.Name = "newCustomerToolStripMenuItem";
            this.newCustomerToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.newCustomerToolStripMenuItem.Text = "Create";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem.Text = "Read";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.deleteToolStripMenuItem.Text = "Update";
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.readToolStripMenuItem,
            this.updateToolStripMenuItem1,
            this.deleteToolStripMenuItem2});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.orderToolStripMenuItem.Text = "Orders";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.readToolStripMenuItem.Text = "Read";
            // 
            // updateToolStripMenuItem1
            // 
            this.updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            this.updateToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem1.Text = "Update";
            // 
            // deleteToolStripMenuItem2
            // 
            this.deleteToolStripMenuItem2.Name = "deleteToolStripMenuItem2";
            this.deleteToolStripMenuItem2.Size = new System.Drawing.Size(112, 22);
            this.deleteToolStripMenuItem2.Text = "Delete";
            // 
            // customersGb
            // 
            this.customersGb.AutoSize = true;
            this.customersGb.Controls.Add(this.customersDgv);
            this.customersGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersGb.Location = new System.Drawing.Point(12, 44);
            this.customersGb.Name = "customersGb";
            this.customersGb.Size = new System.Drawing.Size(614, 528);
            this.customersGb.TabIndex = 11;
            this.customersGb.TabStop = false;
            this.customersGb.Text = "Customer\'s List:";
            // 
            // customersDgv
            // 
            this.customersDgv.AllowUserToResizeColumns = false;
            this.customersDgv.AllowUserToResizeRows = false;
            this.customersDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDgv.Location = new System.Drawing.Point(8, 19);
            this.customersDgv.Name = "customersDgv";
            this.customersDgv.ReadOnly = true;
            this.customersDgv.RowHeadersVisible = false;
            this.customersDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customersDgv.Size = new System.Drawing.Size(600, 490);
            this.customersDgv.TabIndex = 0;
            this.customersDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersDgv_CellClick);
            // 
            // selecterCustGb
            // 
            this.selecterCustGb.Controls.Add(this.selectedCustAddressTxt);
            this.selecterCustGb.Controls.Add(this.selectedCustPhoneTxt);
            this.selecterCustGb.Controls.Add(this.selectedCustNameTxt);
            this.selecterCustGb.Controls.Add(this.selectedCustIdTxt);
            this.selecterCustGb.Controls.Add(this.selectedOperationsGb);
            this.selecterCustGb.Controls.Add(this.selectedCustOrderGroup);
            this.selecterCustGb.Controls.Add(this.selectedAddressLbl);
            this.selecterCustGb.Controls.Add(this.selectedPhoneLbl);
            this.selecterCustGb.Controls.Add(this.selectedNameLbl);
            this.selecterCustGb.Controls.Add(this.selectedIdLbl);
            this.selecterCustGb.Location = new System.Drawing.Point(665, 44);
            this.selecterCustGb.Name = "selecterCustGb";
            this.selecterCustGb.Size = new System.Drawing.Size(288, 286);
            this.selecterCustGb.TabIndex = 12;
            this.selecterCustGb.TabStop = false;
            this.selecterCustGb.Text = "Selected Customer\'s Info:";
            // 
            // selectedCustAddressTxt
            // 
            this.selectedCustAddressTxt.Location = new System.Drawing.Point(72, 117);
            this.selectedCustAddressTxt.Name = "selectedCustAddressTxt";
            this.selectedCustAddressTxt.Size = new System.Drawing.Size(182, 20);
            this.selectedCustAddressTxt.TabIndex = 16;
            // 
            // selectedCustPhoneTxt
            // 
            this.selectedCustPhoneTxt.Location = new System.Drawing.Point(72, 86);
            this.selectedCustPhoneTxt.Name = "selectedCustPhoneTxt";
            this.selectedCustPhoneTxt.Size = new System.Drawing.Size(114, 20);
            this.selectedCustPhoneTxt.TabIndex = 15;
            // 
            // selectedCustNameTxt
            // 
            this.selectedCustNameTxt.Location = new System.Drawing.Point(72, 56);
            this.selectedCustNameTxt.Name = "selectedCustNameTxt";
            this.selectedCustNameTxt.Size = new System.Drawing.Size(167, 20);
            this.selectedCustNameTxt.TabIndex = 14;
            // 
            // selectedCustIdTxt
            // 
            this.selectedCustIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedCustIdTxt.Location = new System.Drawing.Point(72, 26);
            this.selectedCustIdTxt.Name = "selectedCustIdTxt";
            this.selectedCustIdTxt.Size = new System.Drawing.Size(69, 20);
            this.selectedCustIdTxt.TabIndex = 13;
            // 
            // selectedOperationsGb
            // 
            this.selectedOperationsGb.Controls.Add(this.selOpsCreateBtn);
            this.selectedOperationsGb.Controls.Add(this.selOpsDeleteBtn);
            this.selectedOperationsGb.Controls.Add(this.selOpsUpdateBtn);
            this.selectedOperationsGb.Location = new System.Drawing.Point(13, 157);
            this.selectedOperationsGb.Name = "selectedOperationsGb";
            this.selectedOperationsGb.Size = new System.Drawing.Size(262, 54);
            this.selectedOperationsGb.TabIndex = 12;
            this.selectedOperationsGb.TabStop = false;
            this.selectedOperationsGb.Text = "Customer Operations:";
            // 
            // selOpsCreateBtn
            // 
            this.selOpsCreateBtn.Location = new System.Drawing.Point(13, 19);
            this.selOpsCreateBtn.Name = "selOpsCreateBtn";
            this.selOpsCreateBtn.Size = new System.Drawing.Size(75, 23);
            this.selOpsCreateBtn.TabIndex = 2;
            this.selOpsCreateBtn.Text = "Create";
            this.selOpsCreateBtn.UseVisualStyleBackColor = true;
            this.selOpsCreateBtn.Click += new System.EventHandler(this.selOpsCreateBtn_Click);
            // 
            // selOpsDeleteBtn
            // 
            this.selOpsDeleteBtn.Location = new System.Drawing.Point(175, 19);
            this.selOpsDeleteBtn.Name = "selOpsDeleteBtn";
            this.selOpsDeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.selOpsDeleteBtn.TabIndex = 1;
            this.selOpsDeleteBtn.Text = "Delete";
            this.selOpsDeleteBtn.UseVisualStyleBackColor = true;
            this.selOpsDeleteBtn.Click += new System.EventHandler(this.selOpsDeleteBtn_Click);
            // 
            // selOpsUpdateBtn
            // 
            this.selOpsUpdateBtn.Location = new System.Drawing.Point(94, 19);
            this.selOpsUpdateBtn.Name = "selOpsUpdateBtn";
            this.selOpsUpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.selOpsUpdateBtn.TabIndex = 0;
            this.selOpsUpdateBtn.Text = "Update";
            this.selOpsUpdateBtn.UseVisualStyleBackColor = true;
            this.selOpsUpdateBtn.Click += new System.EventHandler(this.selOpsUpdateBtn_Click);
            // 
            // selectedCustOrderGroup
            // 
            this.selectedCustOrderGroup.Controls.Add(this.SelectedCustomerOrders);
            this.selectedCustOrderGroup.Cursor = System.Windows.Forms.Cursors.Default;
            this.selectedCustOrderGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectedCustOrderGroup.Location = new System.Drawing.Point(22, 217);
            this.selectedCustOrderGroup.Name = "selectedCustOrderGroup";
            this.selectedCustOrderGroup.Size = new System.Drawing.Size(247, 53);
            this.selectedCustOrderGroup.TabIndex = 7;
            this.selectedCustOrderGroup.TabStop = false;
            this.selectedCustOrderGroup.Text = "Show Customer\'s Orders";
            // 
            // SelectedCustomerOrders
            // 
            this.SelectedCustomerOrders.Location = new System.Drawing.Point(137, 19);
            this.SelectedCustomerOrders.Name = "SelectedCustomerOrders";
            this.SelectedCustomerOrders.Size = new System.Drawing.Size(104, 23);
            this.SelectedCustomerOrders.TabIndex = 0;
            this.SelectedCustomerOrders.Text = "Show Orders";
            this.SelectedCustomerOrders.UseVisualStyleBackColor = true;
            // 
            // selectedAddressLbl
            // 
            this.selectedAddressLbl.AutoSize = true;
            this.selectedAddressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedAddressLbl.Location = new System.Drawing.Point(10, 120);
            this.selectedAddressLbl.Name = "selectedAddressLbl";
            this.selectedAddressLbl.Size = new System.Drawing.Size(56, 13);
            this.selectedAddressLbl.TabIndex = 7;
            this.selectedAddressLbl.Text = "Address:";
            // 
            // selectedPhoneLbl
            // 
            this.selectedPhoneLbl.AutoSize = true;
            this.selectedPhoneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedPhoneLbl.Location = new System.Drawing.Point(19, 89);
            this.selectedPhoneLbl.Name = "selectedPhoneLbl";
            this.selectedPhoneLbl.Size = new System.Drawing.Size(47, 13);
            this.selectedPhoneLbl.TabIndex = 6;
            this.selectedPhoneLbl.Text = "Phone:";
            // 
            // selectedNameLbl
            // 
            this.selectedNameLbl.AutoSize = true;
            this.selectedNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedNameLbl.Location = new System.Drawing.Point(23, 59);
            this.selectedNameLbl.Name = "selectedNameLbl";
            this.selectedNameLbl.Size = new System.Drawing.Size(43, 13);
            this.selectedNameLbl.TabIndex = 5;
            this.selectedNameLbl.Text = "Name:";
            // 
            // selectedIdLbl
            // 
            this.selectedIdLbl.AutoSize = true;
            this.selectedIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedIdLbl.Location = new System.Drawing.Point(42, 29);
            this.selectedIdLbl.Name = "selectedIdLbl";
            this.selectedIdLbl.Size = new System.Drawing.Size(24, 13);
            this.selectedIdLbl.TabIndex = 4;
            this.selectedIdLbl.Text = "ID:";
            // 
            // responceLbl
            // 
            this.responceLbl.AutoSize = true;
            this.responceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.responceLbl.Location = new System.Drawing.Point(675, 333);
            this.responceLbl.Name = "responceLbl";
            this.responceLbl.Size = new System.Drawing.Size(92, 17);
            this.responceLbl.TabIndex = 14;
            this.responceLbl.Text = "RESPONCE";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 566);
            this.Controls.Add(this.responceLbl);
            this.Controls.Add(this.selecterCustGb);
            this.Controls.Add(this.customersGb);
            this.Controls.Add(this.mainMenu);
            this.Name = "MainForm";
            this.Text = "Customer-Order Management [COM]";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.customersGb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customersDgv)).EndInit();
            this.selecterCustGb.ResumeLayout(false);
            this.selecterCustGb.PerformLayout();
            this.selectedOperationsGb.ResumeLayout(false);
            this.selectedCustOrderGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator quiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem2;
        private System.Windows.Forms.GroupBox customersGb;
        private System.Windows.Forms.GroupBox selecterCustGb;
        private System.Windows.Forms.GroupBox selectedOperationsGb;
        private System.Windows.Forms.Button selOpsDeleteBtn;
        private System.Windows.Forms.Button selOpsUpdateBtn;
        private System.Windows.Forms.GroupBox selectedCustOrderGroup;
        private System.Windows.Forms.Button SelectedCustomerOrders;
        private System.Windows.Forms.Label selectedAddressLbl;
        private System.Windows.Forms.Label selectedPhoneLbl;
        private System.Windows.Forms.Label selectedNameLbl;
        private System.Windows.Forms.Label selectedIdLbl;
        private System.Windows.Forms.DataGridView customersDgv;
        private System.Windows.Forms.TextBox selectedCustAddressTxt;
        private System.Windows.Forms.TextBox selectedCustPhoneTxt;
        private System.Windows.Forms.TextBox selectedCustNameTxt;
        private System.Windows.Forms.TextBox selectedCustIdTxt;
        private System.Windows.Forms.Button selOpsCreateBtn;
        private System.Windows.Forms.Label responceLbl;
    }
}

