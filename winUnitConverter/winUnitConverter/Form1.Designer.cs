
namespace winUnitConverter
{
    partial class Form1
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
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtUnit2 = new System.Windows.Forms.TextBox();
            this.txtUnit1 = new System.Windows.Forms.TextBox();
            this.cmbUnit1 = new System.Windows.Forms.ComboBox();
            this.cmbUnit2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.Location = new System.Drawing.Point(38, 20);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(281, 43);
            this.lblMainTitle.TabIndex = 0;
            this.lblMainTitle.Text = "Unit Converter";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.ForeColor = System.Drawing.Color.Black;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Length",
            "Mass",
            "Temperature"});
            this.cmbType.Location = new System.Drawing.Point(43, 65);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(273, 33);
            this.cmbType.TabIndex = 1;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // txtUnit2
            // 
            this.txtUnit2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnit2.Location = new System.Drawing.Point(187, 104);
            this.txtUnit2.Name = "txtUnit2";
            this.txtUnit2.Size = new System.Drawing.Size(129, 32);
            this.txtUnit2.TabIndex = 2;
            this.txtUnit2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnit2_KeyPress);
            this.txtUnit2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUnit2_KeyUp);
            // 
            // txtUnit1
            // 
            this.txtUnit1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnit1.Location = new System.Drawing.Point(43, 104);
            this.txtUnit1.Name = "txtUnit1";
            this.txtUnit1.Size = new System.Drawing.Size(129, 32);
            this.txtUnit1.TabIndex = 3;
            this.txtUnit1.Text = "1";
            this.txtUnit1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnit1_KeyPress);
            this.txtUnit1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUnit1_KeyUp);
            // 
            // cmbUnit1
            // 
            this.cmbUnit1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnit1.FormattingEnabled = true;
            this.cmbUnit1.Items.AddRange(new object[] {
            "Kilometer",
            "Meter",
            "Centimeter",
            "Milimeter",
            "Mile",
            "Yard",
            "Foot",
            "Inch"});
            this.cmbUnit1.Location = new System.Drawing.Point(43, 136);
            this.cmbUnit1.Name = "cmbUnit1";
            this.cmbUnit1.Size = new System.Drawing.Size(129, 33);
            this.cmbUnit1.TabIndex = 4;
            this.cmbUnit1.DropDownClosed += new System.EventHandler(this.cmbUnit1_DropDownClosed);
            // 
            // cmbUnit2
            // 
            this.cmbUnit2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnit2.FormattingEnabled = true;
            this.cmbUnit2.Items.AddRange(new object[] {
            "Kilometer",
            "Meter",
            "Centimeter",
            "Milimeter",
            "Mile",
            "Yard",
            "Foot",
            "Inch"});
            this.cmbUnit2.Location = new System.Drawing.Point(187, 136);
            this.cmbUnit2.Name = "cmbUnit2";
            this.cmbUnit2.Size = new System.Drawing.Size(129, 33);
            this.cmbUnit2.TabIndex = 5;
            this.cmbUnit2.DropDownClosed += new System.EventHandler(this.cmbUnit2_DropDownClosed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 194);
            this.Controls.Add(this.cmbUnit2);
            this.Controls.Add(this.cmbUnit1);
            this.Controls.Add(this.txtUnit1);
            this.Controls.Add(this.txtUnit2);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblMainTitle);
            this.Name = "Form1";
            this.Text = "Unit Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox txtUnit2;
        private System.Windows.Forms.TextBox txtUnit1;
        private System.Windows.Forms.ComboBox cmbUnit1;
        private System.Windows.Forms.ComboBox cmbUnit2;
    }
}

