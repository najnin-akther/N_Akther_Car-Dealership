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
        /// Required method for Designer support
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.grpPackages = new System.Windows.Forms.GroupBox();
            this.rdoLuxuryPackage = new System.Windows.Forms.RadioButton();
            this.rdoExtraPackage = new System.Windows.Forms.RadioButton();
            this.rdoNonePackage = new System.Windows.Forms.RadioButton();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.grpPackages.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(150, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(264, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Car Price Calculation";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(40, 80);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(103, 15);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Location = new System.Drawing.Point(40, 120);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(67, 15);
            this.lblBasePrice.TabIndex = 2;
            this.lblBasePrice.Text = "Base Price:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(170, 77);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(180, 23);
            this.txtCustomerName.TabIndex = 0;
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Location = new System.Drawing.Point(170, 117);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(180, 23);
            this.txtBasePrice.TabIndex = 1;
            // 
            // grpPackages
            // 
            this.grpPackages.Controls.Add(this.rdoLuxuryPackage);
            this.grpPackages.Controls.Add(this.rdoExtraPackage);
            this.grpPackages.Controls.Add(this.rdoNonePackage);
            this.grpPackages.Location = new System.Drawing.Point(40, 170);
            this.grpPackages.Name = "grpPackages";
            this.grpPackages.Size = new System.Drawing.Size(200, 120);
            this.grpPackages.TabIndex = 2;
            this.grpPackages.TabStop = false;
            this.grpPackages.Text = "Add-on Packages";
            // 
            // rdoLuxuryPackage
            // 
            this.rdoLuxuryPackage.AutoSize = true;
            this.rdoLuxuryPackage.Location = new System.Drawing.Point(20, 85);
            this.rdoLuxuryPackage.Name = "rdoLuxuryPackage";
            this.rdoLuxuryPackage.Size = new System.Drawing.Size(66, 19);
            this.rdoLuxuryPackage.TabIndex = 2;
            this.rdoLuxuryPackage.Text = "Luxury";
            this.rdoLuxuryPackage.UseVisualStyleBackColor = true;
            this.rdoLuxuryPackage.CheckedChanged +=
                new System.EventHandler(this.rdoLuxuryPackage_CheckedChanged);
            // 
            // rdoExtraPackage
            // 
            this.rdoExtraPackage.AutoSize = true;
            this.rdoExtraPackage.Location = new System.Drawing.Point(20, 55);
            this.rdoExtraPackage.Name = "rdoExtraPackage";
            this.rdoExtraPackage.Size = new System.Drawing.Size(57, 19);
            this.rdoExtraPackage.TabIndex = 1;
            this.rdoExtraPackage.Text = "Extra";
            this.rdoExtraPackage.UseVisualStyleBackColor = true;
            this.rdoExtraPackage.CheckedChanged +=
                new System.EventHandler(this.rdoExtraPackage_CheckedChanged);
            // 
            // rdoNonePackage
            // 
            this.rdoNonePackage.AutoSize = true;
            this.rdoNonePackage.Checked = true;
            this.rdoNonePackage.Location = new System.Drawing.Point(20, 25);
            this.rdoNonePackage.Name = "rdoNonePackage";
            this.rdoNonePackage.Size = new System.Drawing.Size(57, 19);
            this.rdoNonePackage.TabIndex = 0;
            this.rdoNonePackage.TabStop = true;
            this.rdoNonePackage.Text = "None";
            this.rdoNonePackage.UseVisualStyleBackColor = true;
            this.rdoNonePackage.CheckedChanged +=
                new System.EventHandler(this.rdoNonePackage_CheckedChanged);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 15;
            this.lstOutput.Location = new System.Drawing.Point(280, 170);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(260, 154);
            this.lstOutput.TabIndex = 6;
            this.lstOutput.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(40, 320);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 35);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click +=
                new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(170, 320);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click +=
                new System.EventHandler(this.btnClear_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(300, 320);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(100, 35);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click +=
                new System.EventHandler(this.btnQuit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(584, 391);

            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.grpPackages);
            this.Controls.Add(this.txtBasePrice);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblBasePrice);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblTitle);

            this.Name = "Form1";

            this.Text = "Akther Car Dealership";

            this.Load +=
                new System.EventHandler(this.Form1_Load);

            this.grpPackages.ResumeLayout(false);
            this.grpPackages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.GroupBox grpPackages;
        private System.Windows.Forms.RadioButton rdoLuxuryPackage;
        private System.Windows.Forms.RadioButton rdoExtraPackage;
        private System.Windows.Forms.RadioButton rdoNonePackage;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnQuit;
    }
}