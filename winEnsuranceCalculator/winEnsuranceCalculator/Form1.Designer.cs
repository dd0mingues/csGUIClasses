
namespace winEnsuranceCalculator
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
            this.dateBirthday = new System.Windows.Forms.DateTimePicker();
            this.btnCompute = new System.Windows.Forms.Button();
            this.chkClaim = new System.Windows.Forms.CheckBox();
            this.radThird = new System.Windows.Forms.RadioButton();
            this.radAll = new System.Windows.Forms.RadioButton();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.grpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateBirthday
            // 
            this.dateBirthday.Location = new System.Drawing.Point(12, 56);
            this.dateBirthday.Name = "dateBirthday";
            this.dateBirthday.Size = new System.Drawing.Size(231, 20);
            this.dateBirthday.TabIndex = 0;
            this.dateBirthday.ValueChanged += new System.EventHandler(this.dateBirthday_ValueChanged);
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(177, 108);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(66, 47);
            this.btnCompute.TabIndex = 1;
            this.btnCompute.Text = "Get Appraisal";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // chkClaim
            // 
            this.chkClaim.AutoSize = true;
            this.chkClaim.Location = new System.Drawing.Point(12, 170);
            this.chkClaim.Name = "chkClaim";
            this.chkClaim.Size = new System.Drawing.Size(133, 17);
            this.chkClaim.TabIndex = 2;
            this.chkClaim.Text = "Claim in the las 5 years";
            this.chkClaim.UseVisualStyleBackColor = true;
            // 
            // radThird
            // 
            this.radThird.AutoSize = true;
            this.radThird.Checked = true;
            this.radThird.Location = new System.Drawing.Point(0, 19);
            this.radThird.Name = "radThird";
            this.radThird.Size = new System.Drawing.Size(76, 17);
            this.radThird.TabIndex = 3;
            this.radThird.TabStop = true;
            this.radThird.Text = "Third Party";
            this.radThird.UseVisualStyleBackColor = true;
            // 
            // radAll
            // 
            this.radAll.AutoSize = true;
            this.radAll.Location = new System.Drawing.Point(0, 42);
            this.radAll.Name = "radAll";
            this.radAll.Size = new System.Drawing.Size(107, 17);
            this.radAll.TabIndex = 4;
            this.radAll.TabStop = true;
            this.radAll.Text = "All-encompassing";
            this.radAll.UseVisualStyleBackColor = true;
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.radThird);
            this.grpBox.Controls.Add(this.radAll);
            this.grpBox.Location = new System.Drawing.Point(12, 96);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(112, 68);
            this.grpBox.TabIndex = 5;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Type of ensurance";
            // 
            // lblValue
            // 
            this.lblValue.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.Location = new System.Drawing.Point(0, 210);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(260, 45);
            this.lblValue.TabIndex = 6;
            this.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.Location = new System.Drawing.Point(-4, 9);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(272, 37);
            this.lblMainTitle.TabIndex = 7;
            this.lblMainTitle.Text = "Ensurance Calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 274);
            this.Controls.Add(this.lblMainTitle);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.chkClaim);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.dateBirthday);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateBirthday;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.CheckBox chkClaim;
        private System.Windows.Forms.RadioButton radThird;
        private System.Windows.Forms.RadioButton radAll;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblMainTitle;
    }
}

