
namespace WindowsFormsApp1
{
    partial class frmArrows
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
            this.picLeft = new System.Windows.Forms.PictureBox();
            this.picRight = new System.Windows.Forms.PictureBox();
            this.picDown = new System.Windows.Forms.PictureBox();
            this.picUp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUp)).BeginInit();
            this.SuspendLayout();
            // 
            // picLeft
            // 
            this.picLeft.Image = global::WindowsFormsApp1.Properties.Resources.left;
            this.picLeft.Location = new System.Drawing.Point(12, 177);
            this.picLeft.Name = "picLeft";
            this.picLeft.Size = new System.Drawing.Size(185, 102);
            this.picLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLeft.TabIndex = 3;
            this.picLeft.TabStop = false;
            // 
            // picRight
            // 
            this.picRight.Image = global::WindowsFormsApp1.Properties.Resources.right;
            this.picRight.Location = new System.Drawing.Point(414, 177);
            this.picRight.Name = "picRight";
            this.picRight.Size = new System.Drawing.Size(185, 102);
            this.picRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRight.TabIndex = 2;
            this.picRight.TabStop = false;
            // 
            // picDown
            // 
            this.picDown.Image = global::WindowsFormsApp1.Properties.Resources.down;
            this.picDown.Location = new System.Drawing.Point(241, 300);
            this.picDown.Name = "picDown";
            this.picDown.Size = new System.Drawing.Size(125, 154);
            this.picDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDown.TabIndex = 1;
            this.picDown.TabStop = false;
            // 
            // picUp
            // 
            this.picUp.Image = global::WindowsFormsApp1.Properties.Resources.up;
            this.picUp.Location = new System.Drawing.Point(241, 12);
            this.picUp.Name = "picUp";
            this.picUp.Size = new System.Drawing.Size(125, 154);
            this.picUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUp.TabIndex = 0;
            this.picUp.TabStop = false;
            // 
            // frmArrows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(611, 466);
            this.Controls.Add(this.picLeft);
            this.Controls.Add(this.picRight);
            this.Controls.Add(this.picDown);
            this.Controls.Add(this.picUp);
            this.Name = "frmArrows";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmArrows_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picUp;
        private System.Windows.Forms.PictureBox picDown;
        private System.Windows.Forms.PictureBox picRight;
        private System.Windows.Forms.PictureBox picLeft;
    }
}

