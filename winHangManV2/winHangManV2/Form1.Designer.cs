
namespace winHangManV2
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitleGameLvl = new System.Windows.Forms.Label();
            this.lblGameLvl = new System.Windows.Forms.Label();
            this.btnA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(130, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(203, 49);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Hang Man";
            // 
            // lblTitleGameLvl
            // 
            this.lblTitleGameLvl.AutoSize = true;
            this.lblTitleGameLvl.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleGameLvl.Location = new System.Drawing.Point(12, 89);
            this.lblTitleGameLvl.Name = "lblTitleGameLvl";
            this.lblTitleGameLvl.Size = new System.Drawing.Size(93, 23);
            this.lblTitleGameLvl.TabIndex = 1;
            this.lblTitleGameLvl.Text = "Game level";
            // 
            // lblGameLvl
            // 
            this.lblGameLvl.AutoSize = true;
            this.lblGameLvl.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameLvl.Location = new System.Drawing.Point(12, 112);
            this.lblGameLvl.Name = "lblGameLvl";
            this.lblGameLvl.Size = new System.Drawing.Size(52, 23);
            this.lblGameLvl.TabIndex = 2;
            this.lblGameLvl.Text = "Basic";
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnA.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.ForeColor = System.Drawing.Color.Black;
            this.btnA.Location = new System.Drawing.Point(32, 431);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(40, 40);
            this.btnA.TabIndex = 3;
            this.btnA.Text = "A";
            this.btnA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnA.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(488, 653);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.lblGameLvl);
            this.Controls.Add(this.lblTitleGameLvl);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTitleGameLvl;
        private System.Windows.Forms.Label lblGameLvl;
        private System.Windows.Forms.Button btnA;
    }
}

