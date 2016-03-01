namespace WindowsCustomerUI
{
    partial class CustomerScreen
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
            this.lbCustomerType = new System.Windows.Forms.Label();
            this.cbCustomerType = new System.Windows.Forms.ComboBox();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.lbBillAmount = new System.Windows.Forms.Label();
            this.tbBillAmount = new System.Windows.Forms.TextBox();
            this.lbBillDate = new System.Windows.Forms.Label();
            this.dtBillDate = new System.Windows.Forms.DateTimePicker();
            this.lbAddress = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lvCustomers = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lbCustomerType
            // 
            this.lbCustomerType.AutoSize = true;
            this.lbCustomerType.Location = new System.Drawing.Point(12, 9);
            this.lbCustomerType.Name = "lbCustomerType";
            this.lbCustomerType.Size = new System.Drawing.Size(76, 13);
            this.lbCustomerType.TabIndex = 0;
            this.lbCustomerType.Text = "Custoner Type";
            // 
            // cbCustomerType
            // 
            this.cbCustomerType.FormattingEnabled = true;
            this.cbCustomerType.Items.AddRange(new object[] {
            "Lead",
            "Customer"});
            this.cbCustomerType.Location = new System.Drawing.Point(127, 6);
            this.cbCustomerType.Name = "cbCustomerType";
            this.cbCustomerType.Size = new System.Drawing.Size(121, 21);
            this.cbCustomerType.TabIndex = 1;
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.Location = new System.Drawing.Point(12, 38);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(80, 13);
            this.lbCustomerName.TabIndex = 2;
            this.lbCustomerName.Text = "Custoner Name";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(127, 35);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(121, 20);
            this.tbCustomerName.TabIndex = 3;
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Location = new System.Drawing.Point(12, 66);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lbPhoneNumber.TabIndex = 4;
            this.lbPhoneNumber.Text = "Phone Number";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(127, 63);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(121, 20);
            this.tbPhoneNumber.TabIndex = 5;
            // 
            // lbBillAmount
            // 
            this.lbBillAmount.AutoSize = true;
            this.lbBillAmount.Location = new System.Drawing.Point(279, 9);
            this.lbBillAmount.Name = "lbBillAmount";
            this.lbBillAmount.Size = new System.Drawing.Size(59, 13);
            this.lbBillAmount.TabIndex = 6;
            this.lbBillAmount.Text = "Bill Amount";
            // 
            // tbBillAmount
            // 
            this.tbBillAmount.Location = new System.Drawing.Point(351, 6);
            this.tbBillAmount.Name = "tbBillAmount";
            this.tbBillAmount.Size = new System.Drawing.Size(121, 20);
            this.tbBillAmount.TabIndex = 7;
            // 
            // lbBillDate
            // 
            this.lbBillDate.AutoSize = true;
            this.lbBillDate.Location = new System.Drawing.Point(279, 38);
            this.lbBillDate.Name = "lbBillDate";
            this.lbBillDate.Size = new System.Drawing.Size(59, 13);
            this.lbBillDate.TabIndex = 8;
            this.lbBillDate.Text = "Bill Amount";
            // 
            // dtBillDate
            // 
            this.dtBillDate.Location = new System.Drawing.Point(351, 38);
            this.dtBillDate.Name = "dtBillDate";
            this.dtBillDate.Size = new System.Drawing.Size(121, 20);
            this.dtBillDate.TabIndex = 9;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(279, 66);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(45, 13);
            this.lbAddress.TabIndex = 10;
            this.lbAddress.Text = "Address";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(351, 63);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(121, 52);
            this.tbAddress.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 92);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(96, 92);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(177, 92);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(258, 92);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lvCustomers
            // 
            this.lvCustomers.Location = new System.Drawing.Point(15, 121);
            this.lvCustomers.Name = "lvCustomers";
            this.lvCustomers.Size = new System.Drawing.Size(457, 128);
            this.lvCustomers.TabIndex = 16;
            this.lvCustomers.UseCompatibleStateImageBehavior = false;
            // 
            // CustomerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.lvCustomers);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.dtBillDate);
            this.Controls.Add(this.lbBillDate);
            this.Controls.Add(this.tbBillAmount);
            this.Controls.Add(this.lbBillAmount);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.lbPhoneNumber);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.lbCustomerName);
            this.Controls.Add(this.cbCustomerType);
            this.Controls.Add(this.lbCustomerType);
            this.Name = "CustomerScreen";
            this.Text = "Customer Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCustomerType;
        private System.Windows.Forms.ComboBox cbCustomerType;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Label lbBillAmount;
        private System.Windows.Forms.TextBox tbBillAmount;
        private System.Windows.Forms.Label lbBillDate;
        private System.Windows.Forms.DateTimePicker dtBillDate;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListView lvCustomers;
    }
}