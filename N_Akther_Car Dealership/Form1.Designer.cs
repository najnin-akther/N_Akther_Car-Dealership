namespace N_Akther_Car_Dealership
{
    partial class frmCarDealership
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
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.grpPackages = new System.Windows.Forms.GroupBox();
            this.rdoNonePackage = new System.Windows.Forms.RadioButton();
            this.rdoExtraPackage = new System.Windows.Forms.RadioButton();
            this.rdoLuxuryPackage = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.grpPackages.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(345, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(235, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Car Price Calculation";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(330, 154);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(82, 13);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(462, 154);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(137, 20);
            this.txtCustomerName.TabIndex = 2;
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Location = new System.Drawing.Point(351, 213);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(58, 13);
            this.lblBasePrice.TabIndex = 2;
            this.lblBasePrice.Text = "Base Price";
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Location = new System.Drawing.Point(462, 206);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(137, 20);
            this.txtBasePrice.TabIndex = 4;
            // 
            // grpPackages
            // 
            this.grpPackages.Controls.Add(this.rdoLuxuryPackage);
            this.grpPackages.Controls.Add(this.rdoExtraPackage);
            this.grpPackages.Controls.Add(this.rdoNonePackage);
            this.grpPackages.Location = new System.Drawing.Point(193, 80);
            this.grpPackages.Name = "grpPackages";
            this.grpPackages.Size = new System.Drawing.Size(504, 59);
            this.grpPackages.TabIndex = 5;
            this.grpPackages.TabStop = false;
            this.grpPackages.Text = "Add-On Packages";
            // 
            // rdoNonePackage
            // 
            this.rdoNonePackage.AutoSize = true;
            this.rdoNonePackage.Location = new System.Drawing.Point(110, 35);
            this.rdoNonePackage.Name = "rdoNonePackage";
            this.rdoNonePackage.Size = new System.Drawing.Size(51, 17);
            this.rdoNonePackage.TabIndex = 3;
            this.rdoNonePackage.Text = "None";
            this.rdoNonePackage.UseVisualStyleBackColor = true;
            this.rdoNonePackage.CheckedChanged += new System.EventHandler(this.rdoNonePackage_CheckedChanged);
                                                                                           
            // 
            // rdoExtraPackage
            // 
            this.rdoExtraPackage.AutoSize = true;
            this.rdoExtraPackage.Location = new System.Drawing.Point(265, 35);
            this.rdoExtraPackage.Name = "rdoExtraPackage";
            this.rdoExtraPackage.Size = new System.Drawing.Size(57, 17);
            this.rdoExtraPackage.TabIndex = 4;
            this.rdoExtraPackage.Text = " Extras";
            this.rdoExtraPackage.UseVisualStyleBackColor = true;
            this.rdoExtraPackage.CheckedChanged += new System.EventHandler(this.rdoExtraPackage_CheckedChanged);
            // 
            // rdoLuxuryPackage
            // 
            this.rdoLuxuryPackage.AutoSize = true;
            this.rdoLuxuryPackage.Checked = true;
            this.rdoLuxuryPackage.Location = new System.Drawing.Point(424, 35);
            this.rdoLuxuryPackage.Name = "rdoLuxuryPackage";
            this.rdoLuxuryPackage.Size = new System.Drawing.Size(56, 17);
            this.rdoLuxuryPackage.TabIndex = 5;
            this.rdoLuxuryPackage.TabStop = true;
            this.rdoLuxuryPackage.Text = "Luxury";
            this.rdoLuxuryPackage.UseVisualStyleBackColor = true;
            this.rdoLuxuryPackage.CheckedChanged += new System.EventHandler(this.rdoLuxuryPackage_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(121, 388);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(77, 35);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(321, 388);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 35);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(576, 388);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(73, 32);
            this.btnQuit.TabIndex = 8;
            this.btnQuit.Text = "Q&uit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(210, 239);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(421, 108);
            this.lstOutput.TabIndex = 9;
            this.lstOutput.TabStop = false;
            // 
            // frmCarDealership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpPackages);
            this.Controls.Add(this.txtBasePrice);
            this.Controls.Add(this.lblBasePrice);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmCarDealership";
            this.Text = "Naj\'s Car Dealership";
            this.Load += new System.EventHandler(this.frmCarDealership_Load);
            this.grpPackages.ResumeLayout(false);
            this.grpPackages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.GroupBox grpPackages;
        private System.Windows.Forms.RadioButton rdoLuxuryPackage;
        private System.Windows.Forms.RadioButton rdoExtraPackage;
        private System.Windows.Forms.RadioButton rdoNonePackage;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.ListBox lstOutput;
    }
}

