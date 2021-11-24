
namespace win7540_008
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
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.lblExangeRate = new System.Windows.Forms.Label();
            this.txtExchange = new System.Windows.Forms.TextBox();
            this.lblEuros = new System.Windows.Forms.Label();
            this.grpMaterials = new System.Windows.Forms.GroupBox();
            this.radGravel = new System.Windows.Forms.RadioButton();
            this.radTarmac = new System.Windows.Forms.RadioButton();
            this.radConcrete = new System.Windows.Forms.RadioButton();
            this.radBrick = new System.Windows.Forms.RadioButton();
            this.lblPrices = new System.Windows.Forms.Label();
            this.txtConcrete = new System.Windows.Forms.TextBox();
            this.txtGravel = new System.Windows.Forms.TextBox();
            this.txtTarmac = new System.Windows.Forms.TextBox();
            this.txtBrick = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.grpFoundations = new System.Windows.Forms.GroupBox();
            this.radExtra = new System.Windows.Forms.RadioButton();
            this.radStandart = new System.Windows.Forms.RadioButton();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblGBPTitle = new System.Windows.Forms.Label();
            this.lblGBPPrice = new System.Windows.Forms.Label();
            this.lblEurTitle = new System.Windows.Forms.Label();
            this.lblEurPrice = new System.Windows.Forms.Label();
            this.lblFinalDisplay = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpMaterials.SuspendLayout();
            this.grpFoundations.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.Location = new System.Drawing.Point(117, 33);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(285, 37);
            this.lblMainTitle.TabIndex = 0;
            this.lblMainTitle.Text = "Euro Drives or Patios";
            // 
            // lblExangeRate
            // 
            this.lblExangeRate.AutoSize = true;
            this.lblExangeRate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExangeRate.Location = new System.Drawing.Point(145, 77);
            this.lblExangeRate.Name = "lblExangeRate";
            this.lblExangeRate.Size = new System.Drawing.Size(153, 18);
            this.lblExangeRate.TabIndex = 1;
            this.lblExangeRate.Text = "Exchange Rate: 1£ =";
            // 
            // txtExchange
            // 
            this.txtExchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExchange.Location = new System.Drawing.Point(304, 73);
            this.txtExchange.Name = "txtExchange";
            this.txtExchange.Size = new System.Drawing.Size(43, 26);
            this.txtExchange.TabIndex = 2;
            this.txtExchange.Text = "1.45";
            this.txtExchange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtExchange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExchange_KeyPress);
            // 
            // lblEuros
            // 
            this.lblEuros.AutoSize = true;
            this.lblEuros.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuros.Location = new System.Drawing.Point(353, 77);
            this.lblEuros.Name = "lblEuros";
            this.lblEuros.Size = new System.Drawing.Size(17, 18);
            this.lblEuros.TabIndex = 3;
            this.lblEuros.Text = "€";
            // 
            // grpMaterials
            // 
            this.grpMaterials.Controls.Add(this.radGravel);
            this.grpMaterials.Controls.Add(this.radTarmac);
            this.grpMaterials.Controls.Add(this.radConcrete);
            this.grpMaterials.Controls.Add(this.radBrick);
            this.grpMaterials.Location = new System.Drawing.Point(40, 132);
            this.grpMaterials.Name = "grpMaterials";
            this.grpMaterials.Size = new System.Drawing.Size(126, 112);
            this.grpMaterials.TabIndex = 4;
            this.grpMaterials.TabStop = false;
            this.grpMaterials.Text = "Materials";
            // 
            // radGravel
            // 
            this.radGravel.AutoSize = true;
            this.radGravel.Location = new System.Drawing.Point(7, 92);
            this.radGravel.Name = "radGravel";
            this.radGravel.Size = new System.Drawing.Size(56, 17);
            this.radGravel.TabIndex = 3;
            this.radGravel.Text = "Gravel";
            this.radGravel.UseVisualStyleBackColor = true;
            // 
            // radTarmac
            // 
            this.radTarmac.AutoSize = true;
            this.radTarmac.Location = new System.Drawing.Point(7, 68);
            this.radTarmac.Name = "radTarmac";
            this.radTarmac.Size = new System.Drawing.Size(61, 17);
            this.radTarmac.TabIndex = 2;
            this.radTarmac.Text = "Tarmac";
            this.radTarmac.UseVisualStyleBackColor = true;
            // 
            // radConcrete
            // 
            this.radConcrete.AutoSize = true;
            this.radConcrete.Location = new System.Drawing.Point(7, 44);
            this.radConcrete.Name = "radConcrete";
            this.radConcrete.Size = new System.Drawing.Size(68, 17);
            this.radConcrete.TabIndex = 1;
            this.radConcrete.Text = "Concrete";
            this.radConcrete.UseVisualStyleBackColor = true;
            // 
            // radBrick
            // 
            this.radBrick.AutoSize = true;
            this.radBrick.Checked = true;
            this.radBrick.Location = new System.Drawing.Point(7, 22);
            this.radBrick.Name = "radBrick";
            this.radBrick.Size = new System.Drawing.Size(49, 17);
            this.radBrick.TabIndex = 0;
            this.radBrick.TabStop = true;
            this.radBrick.Text = "Brick";
            this.radBrick.UseVisualStyleBackColor = true;
            // 
            // lblPrices
            // 
            this.lblPrices.AutoSize = true;
            this.lblPrices.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrices.Location = new System.Drawing.Point(172, 122);
            this.lblPrices.Name = "lblPrices";
            this.lblPrices.Size = new System.Drawing.Size(126, 18);
            this.lblPrices.TabIndex = 5;
            this.lblPrices.Text = "Prices / sq meter";
            // 
            // txtConcrete
            // 
            this.txtConcrete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConcrete.Location = new System.Drawing.Point(200, 175);
            this.txtConcrete.Name = "txtConcrete";
            this.txtConcrete.Size = new System.Drawing.Size(66, 22);
            this.txtConcrete.TabIndex = 6;
            this.txtConcrete.Text = "25.50";
            this.txtConcrete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtConcrete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConcrete_KeyPress);
            // 
            // txtGravel
            // 
            this.txtGravel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGravel.Location = new System.Drawing.Point(200, 223);
            this.txtGravel.Name = "txtGravel";
            this.txtGravel.Size = new System.Drawing.Size(66, 22);
            this.txtGravel.TabIndex = 7;
            this.txtGravel.Text = "29.75";
            this.txtGravel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGravel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGravel_KeyPress);
            // 
            // txtTarmac
            // 
            this.txtTarmac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarmac.Location = new System.Drawing.Point(200, 199);
            this.txtTarmac.Name = "txtTarmac";
            this.txtTarmac.Size = new System.Drawing.Size(66, 22);
            this.txtTarmac.TabIndex = 8;
            this.txtTarmac.Text = "20.00";
            this.txtTarmac.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTarmac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTarmac_KeyPress);
            // 
            // txtBrick
            // 
            this.txtBrick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrick.Location = new System.Drawing.Point(200, 151);
            this.txtBrick.Name = "txtBrick";
            this.txtBrick.Size = new System.Drawing.Size(66, 22);
            this.txtBrick.TabIndex = 9;
            this.txtBrick.Text = "35.75";
            this.txtBrick.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBrick.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBrick_KeyPress);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(233, 398);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(53, 34);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // grpFoundations
            // 
            this.grpFoundations.Controls.Add(this.radExtra);
            this.grpFoundations.Controls.Add(this.radStandart);
            this.grpFoundations.Location = new System.Drawing.Point(356, 156);
            this.grpFoundations.Name = "grpFoundations";
            this.grpFoundations.Size = new System.Drawing.Size(126, 65);
            this.grpFoundations.TabIndex = 5;
            this.grpFoundations.TabStop = false;
            this.grpFoundations.Text = "Foundation";
            // 
            // radExtra
            // 
            this.radExtra.AutoSize = true;
            this.radExtra.Location = new System.Drawing.Point(7, 44);
            this.radExtra.Name = "radExtra";
            this.radExtra.Size = new System.Drawing.Size(78, 17);
            this.radExtra.TabIndex = 1;
            this.radExtra.TabStop = true;
            this.radExtra.Text = "Extra Deep";
            this.radExtra.UseVisualStyleBackColor = true;
            // 
            // radStandart
            // 
            this.radStandart.AutoSize = true;
            this.radStandart.Checked = true;
            this.radStandart.Location = new System.Drawing.Point(7, 22);
            this.radStandart.Name = "radStandart";
            this.radStandart.Size = new System.Drawing.Size(65, 17);
            this.radStandart.TabIndex = 0;
            this.radStandart.TabStop = true;
            this.radStandart.Text = "Standart";
            this.radStandart.UseVisualStyleBackColor = true;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(197, 251);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(55, 18);
            this.lblLength.TabIndex = 11;
            this.lblLength.Text = "Lenght";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(197, 280);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(48, 18);
            this.lblWidth.TabIndex = 12;
            this.lblWidth.Text = "Width";
            // 
            // txtLength
            // 
            this.txtLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLength.Location = new System.Drawing.Point(258, 251);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(66, 22);
            this.txtLength.TabIndex = 13;
            this.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLength_KeyPress);
            // 
            // txtWidth
            // 
            this.txtWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWidth.Location = new System.Drawing.Point(258, 280);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(66, 22);
            this.txtWidth.TabIndex = 14;
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWidth_KeyPress);
            // 
            // lblGBPTitle
            // 
            this.lblGBPTitle.AutoSize = true;
            this.lblGBPTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGBPTitle.Location = new System.Drawing.Point(121, 314);
            this.lblGBPTitle.Name = "lblGBPTitle";
            this.lblGBPTitle.Size = new System.Drawing.Size(42, 18);
            this.lblGBPTitle.TabIndex = 15;
            this.lblGBPTitle.Text = "GBP";
            // 
            // lblGBPPrice
            // 
            this.lblGBPPrice.BackColor = System.Drawing.Color.White;
            this.lblGBPPrice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGBPPrice.Location = new System.Drawing.Point(169, 314);
            this.lblGBPPrice.Name = "lblGBPPrice";
            this.lblGBPPrice.Size = new System.Drawing.Size(188, 18);
            this.lblGBPPrice.TabIndex = 16;
            this.lblGBPPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEurTitle
            // 
            this.lblEurTitle.AutoSize = true;
            this.lblEurTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEurTitle.Location = new System.Drawing.Point(121, 341);
            this.lblEurTitle.Name = "lblEurTitle";
            this.lblEurTitle.Size = new System.Drawing.Size(41, 18);
            this.lblEurTitle.TabIndex = 17;
            this.lblEurTitle.Text = "EUR";
            // 
            // lblEurPrice
            // 
            this.lblEurPrice.BackColor = System.Drawing.Color.White;
            this.lblEurPrice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEurPrice.Location = new System.Drawing.Point(169, 341);
            this.lblEurPrice.Name = "lblEurPrice";
            this.lblEurPrice.Size = new System.Drawing.Size(188, 18);
            this.lblEurPrice.TabIndex = 18;
            this.lblEurPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFinalDisplay
            // 
            this.lblFinalDisplay.BackColor = System.Drawing.Color.White;
            this.lblFinalDisplay.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalDisplay.Location = new System.Drawing.Point(124, 368);
            this.lblFinalDisplay.Name = "lblFinalDisplay";
            this.lblFinalDisplay.Size = new System.Drawing.Size(278, 18);
            this.lblFinalDisplay.TabIndex = 19;
            this.lblFinalDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(127, 398);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 34);
            this.btnCalculate.TabIndex = 20;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(292, 398);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(107, 34);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(517, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 446);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblFinalDisplay);
            this.Controls.Add(this.lblEurPrice);
            this.Controls.Add(this.lblEurTitle);
            this.Controls.Add(this.lblGBPPrice);
            this.Controls.Add(this.lblGBPTitle);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.grpFoundations);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtBrick);
            this.Controls.Add(this.txtTarmac);
            this.Controls.Add(this.txtGravel);
            this.Controls.Add(this.txtConcrete);
            this.Controls.Add(this.lblPrices);
            this.Controls.Add(this.grpMaterials);
            this.Controls.Add(this.lblEuros);
            this.Controls.Add(this.txtExchange);
            this.Controls.Add(this.lblExangeRate);
            this.Controls.Add(this.lblMainTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.grpMaterials.ResumeLayout(false);
            this.grpMaterials.PerformLayout();
            this.grpFoundations.ResumeLayout(false);
            this.grpFoundations.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Label lblExangeRate;
        private System.Windows.Forms.TextBox txtExchange;
        private System.Windows.Forms.Label lblEuros;
        private System.Windows.Forms.GroupBox grpMaterials;
        private System.Windows.Forms.RadioButton radGravel;
        private System.Windows.Forms.RadioButton radTarmac;
        private System.Windows.Forms.RadioButton radConcrete;
        private System.Windows.Forms.RadioButton radBrick;
        private System.Windows.Forms.Label lblPrices;
        private System.Windows.Forms.TextBox txtConcrete;
        private System.Windows.Forms.TextBox txtGravel;
        private System.Windows.Forms.TextBox txtTarmac;
        private System.Windows.Forms.TextBox txtBrick;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox grpFoundations;
        private System.Windows.Forms.RadioButton radExtra;
        private System.Windows.Forms.RadioButton radStandart;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblGBPTitle;
        private System.Windows.Forms.Label lblGBPPrice;
        private System.Windows.Forms.Label lblEurTitle;
        private System.Windows.Forms.Label lblEurPrice;
        private System.Windows.Forms.Label lblFinalDisplay;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

