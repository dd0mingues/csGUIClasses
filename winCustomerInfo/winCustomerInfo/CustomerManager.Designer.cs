
namespace winCustomerInfo
{
    partial class CustomerManager
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
            this.lblFirstNameTitle = new System.Windows.Forms.Label();
            this.lblLastNameTitle = new System.Windows.Forms.Label();
            this.lblPhoneNumberTitle = new System.Windows.Forms.Label();
            this.lblCountyTitle = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnFunction = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgridCustomers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgridCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstNameTitle
            // 
            this.lblFirstNameTitle.AutoSize = true;
            this.lblFirstNameTitle.Location = new System.Drawing.Point(60, 55);
            this.lblFirstNameTitle.Name = "lblFirstNameTitle";
            this.lblFirstNameTitle.Size = new System.Drawing.Size(57, 13);
            this.lblFirstNameTitle.TabIndex = 0;
            this.lblFirstNameTitle.Text = "First Name";
            // 
            // lblLastNameTitle
            // 
            this.lblLastNameTitle.AutoSize = true;
            this.lblLastNameTitle.Location = new System.Drawing.Point(227, 55);
            this.lblLastNameTitle.Name = "lblLastNameTitle";
            this.lblLastNameTitle.Size = new System.Drawing.Size(58, 13);
            this.lblLastNameTitle.TabIndex = 1;
            this.lblLastNameTitle.Text = "Last Name";
            // 
            // lblPhoneNumberTitle
            // 
            this.lblPhoneNumberTitle.AutoSize = true;
            this.lblPhoneNumberTitle.Location = new System.Drawing.Point(227, 94);
            this.lblPhoneNumberTitle.Name = "lblPhoneNumberTitle";
            this.lblPhoneNumberTitle.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneNumberTitle.TabIndex = 3;
            this.lblPhoneNumberTitle.Text = "Phone Number";
            // 
            // lblCountyTitle
            // 
            this.lblCountyTitle.AutoSize = true;
            this.lblCountyTitle.Location = new System.Drawing.Point(60, 94);
            this.lblCountyTitle.Name = "lblCountyTitle";
            this.lblCountyTitle.Size = new System.Drawing.Size(40, 13);
            this.lblCountyTitle.TabIndex = 2;
            this.lblCountyTitle.Text = "County";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(63, 71);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(120, 20);
            this.txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(230, 71);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(120, 20);
            this.txtLastName.TabIndex = 5;
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(63, 110);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(120, 20);
            this.txtCounty.TabIndex = 6;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(230, 110);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(120, 20);
            this.txtPhoneNumber.TabIndex = 7;
            // 
            // btnFunction
            // 
            this.btnFunction.Location = new System.Drawing.Point(407, 109);
            this.btnFunction.Name = "btnFunction";
            this.btnFunction.Size = new System.Drawing.Size(99, 20);
            this.btnFunction.TabIndex = 9;
            this.btnFunction.Text = "Add";
            this.btnFunction.UseVisualStyleBackColor = true;
            this.btnFunction.Click += new System.EventHandler(this.btnFunction_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(407, 291);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 20);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgridCustomers
            // 
            this.dgridCustomers.AllowUserToAddRows = false;
            this.dgridCustomers.AllowUserToDeleteRows = false;
            this.dgridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.a,
            this.Column2,
            this.Column3});
            this.dgridCustomers.Location = new System.Drawing.Point(63, 149);
            this.dgridCustomers.Name = "dgridCustomers";
            this.dgridCustomers.ReadOnly = true;
            this.dgridCustomers.Size = new System.Drawing.Size(443, 107);
            this.dgridCustomers.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "First Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // a
            // 
            this.a.Frozen = true;
            this.a.HeaderText = "Last Name";
            this.a.Name = "a";
            this.a.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "County";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Phone Number";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // CustomerManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 369);
            this.Controls.Add(this.dgridCustomers);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFunction);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtCounty);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblPhoneNumberTitle);
            this.Controls.Add(this.lblCountyTitle);
            this.Controls.Add(this.lblLastNameTitle);
            this.Controls.Add(this.lblFirstNameTitle);
            this.Name = "CustomerManager";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerManager_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgridCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstNameTitle;
        private System.Windows.Forms.Label lblLastNameTitle;
        private System.Windows.Forms.Label lblPhoneNumberTitle;
        private System.Windows.Forms.Label lblCountyTitle;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgridCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        public System.Windows.Forms.Button btnFunction;
    }
}

