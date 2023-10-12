namespace FirstDisplay3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLoanAmount = new System.Windows.Forms.TextBox();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtTermsYears = new System.Windows.Forms.TextBox();
            this.txtMortgage = new System.Windows.Forms.Button();
            this.txtAuto = new System.Windows.Forms.Button();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loan Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Down Payment:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Interest Rate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Terms in Years";
            // 
            // txtLoanAmount
            // 
            this.txtLoanAmount.Location = new System.Drawing.Point(358, 28);
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.Size = new System.Drawing.Size(219, 26);
            this.txtLoanAmount.TabIndex = 4;
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Location = new System.Drawing.Point(358, 80);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(219, 26);
            this.txtDownPayment.TabIndex = 5;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(358, 132);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(219, 26);
            this.txtInterestRate.TabIndex = 6;
            // 
            // txtTermsYears
            // 
            this.txtTermsYears.Location = new System.Drawing.Point(358, 204);
            this.txtTermsYears.Name = "txtTermsYears";
            this.txtTermsYears.Size = new System.Drawing.Size(219, 26);
            this.txtTermsYears.TabIndex = 7;
            // 
            // txtMortgage
            // 
            this.txtMortgage.Location = new System.Drawing.Point(358, 253);
            this.txtMortgage.Name = "txtMortgage";
            this.txtMortgage.Size = new System.Drawing.Size(103, 37);
            this.txtMortgage.TabIndex = 8;
            this.txtMortgage.Text = "Mortgage";
            this.txtMortgage.UseVisualStyleBackColor = true;
            this.txtMortgage.Click += new System.EventHandler(this.txtMortgage_Click);
            // 
            // txtAuto
            // 
            this.txtAuto.Location = new System.Drawing.Point(493, 253);
            this.txtAuto.Name = "txtAuto";
            this.txtAuto.Size = new System.Drawing.Size(84, 37);
            this.txtAuto.TabIndex = 9;
            this.txtAuto.Text = "Auto";
            this.txtAuto.UseVisualStyleBackColor = true;
            this.txtAuto.Click += new System.EventHandler(this.txtAuto_Click);
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.AutoSize = true;
            this.lblMonthlyPayment.Location = new System.Drawing.Point(218, 336);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(134, 20);
            this.lblMonthlyPayment.TabIndex = 10;
            this.lblMonthlyPayment.Text = "Monthly Payment:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMonthlyPayment);
            this.Controls.Add(this.txtAuto);
            this.Controls.Add(this.txtMortgage);
            this.Controls.Add(this.txtTermsYears);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtDownPayment);
            this.Controls.Add(this.txtLoanAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLoanAmount;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtTermsYears;
        private System.Windows.Forms.Button txtMortgage;
        private System.Windows.Forms.Button txtAuto;
        private System.Windows.Forms.Label lblMonthlyPayment;
    }
}

