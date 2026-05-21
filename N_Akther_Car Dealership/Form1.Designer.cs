namespace N_Akther_Car_Dealership
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
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.grpPackages = new System.Windows.Forms.GroupBox();
            this.rdoLuxuryPackage = new System.Windows.Forms.RadioButton();
            this.rdoExtraPackage = new System.Windows.Forms.RadioButton();
            this.rdoNonePackage = new System.Windows.Forms.RadioButton();
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
            this.lblTitle.Location = new System.Drawing.Point(460, 44);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(290, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Car Price Calculation";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(440, 190);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(104, 16);
            this.lblCustomerName.TabIndex = 3;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(616, 190);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(181, 22);
            this.txtCustomerName.TabIndex = 4;
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Location = new System.Drawing.Point(468, 262);
            this.lblBasePrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(73, 16);
            this.lblBasePrice.TabIndex = 5;
            this.lblBasePrice.Text = "Base Price";
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Location = new System.Drawing.Point(616, 254);
            this.txtBasePrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(181, 22);
            this.txtBasePrice.TabIndex = 6;
            // 
            // grpPackages
            // 
            this.grpPackages.Controls.Add(this.rdoLuxuryPackage);
            this.grpPackages.Controls.Add(this.rdoExtraPackage);
            this.grpPackages.Controls.Add(this.rdoNonePackage);
            this.grpPackages.Location = new System.Drawing.Point(257, 98);
            this.grpPackages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPackages.Name = "grpPackages";
            this.grpPackages.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPackages.Size = new System.Drawing.Size(672, 73);
            this.grpPackages.TabIndex = 5;
            this.grpPackages.TabStop = false;
            this.grpPackages.Text = "Add-On Packages";
            // 
            // rdoLuxuryPackage
            // 
            this.rdoLuxuryPackage.AutoSize = true;
            this.rdoLuxuryPackage.Checked = true;
            this.rdoLuxuryPackage.Location = new System.Drawing.Point(565, 43);
            this.rdoLuxuryPackage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoLuxuryPackage.Name = "rdoLuxuryPackage";
            this.rdoLuxuryPackage.Size = new System.Drawing.Size(66, 20);
            this.rdoLuxuryPackage.TabIndex = 2;
            this.rdoLuxuryPackage.TabStop = true;
            this.rdoLuxuryPackage.Text = "Luxury";
            this.rdoLuxuryPackage.UseVisualStyleBackColor = true;
            this.rdoLuxuryPackage.CheckedChanged += new System.EventHandler(this.rdoLuxuryPackage_CheckedChanged);
            // 
            // rdoExtraPackage
            // 
            this.rdoExtraPackage.AutoSize = true;
            this.rdoExtraPackage.Location = new System.Drawing.Point(353, 43);
            this.rdoExtraPackage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoExtraPackage.Name = "rdoExtraPackage";
            this.rdoExtraPackage.Size = new System.Drawing.Size(68, 20);
            this.rdoExtraPackage.TabIndex = 1;
            this.rdoExtraPackage.Text = " Extras";
            this.rdoExtraPackage.UseVisualStyleBackColor = true;
            this.rdoExtraPackage.CheckedChanged += new System.EventHandler(this.rdoExtraPackage_CheckedChanged);
            // 
            // rdoNonePackage
            // 
            this.rdoNonePackage.AutoSize = true;
            this.rdoNonePackage.Location = new System.Drawing.Point(147, 43);
            this.rdoNonePackage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoNonePackage.Name = "rdoNonePackage";
            this.rdoNonePackage.Size = new System.Drawing.Size(61, 20);
            this.rdoNonePackage.TabIndex = 0;
            this.rdoNonePackage.Text = "None";
            this.rdoNonePackage.UseVisualStyleBackColor = true;
            this.rdoNonePackage.CheckedChanged += new System.EventHandler(this.rdoNonePackage_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(161, 478);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(103, 43);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(428, 478);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 43);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(768, 478);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(97, 39);
            this.btnQuit.TabIndex = 10;
            this.btnQuit.Text = "Q&uit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 16;
            this.lstOutput.Location = new System.Drawing.Point(280, 294);
            this.lstOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(560, 132);
            this.lstOutput.TabIndex = 7;
            this.lstOutput.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Naj\'s Car Dealership";
            this.Load += new System.EventHandler(this.Form1_Load);
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

