namespace MortgageCalculator
{
    partial class MortgageCal
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
            this.calculate = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.downPayBox = new System.Windows.Forms.TextBox();
            this.interestBox = new System.Windows.Forms.TextBox();
            this.termBox = new System.Windows.Forms.TextBox();
            this.financeBox = new System.Windows.Forms.TextBox();
            this.paymentBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lable4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(34, 401);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 0;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(691, 401);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 1;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.button2_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(211, 74);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(328, 20);
            this.nameBox.TabIndex = 2;
            this.nameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameBox_KeyDown);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(120, 77);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(85, 13);
            this.name.TabIndex = 3;
            this.name.Text = "Applicant Name:";
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(211, 128);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(140, 20);
            this.priceBox.TabIndex = 4;
            this.priceBox.TextChanged += new System.EventHandler(this.priceBox_TextChanged);
            this.priceBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.priceBox_KeyDown);
            // 
            // downPayBox
            // 
            this.downPayBox.Location = new System.Drawing.Point(211, 180);
            this.downPayBox.Name = "downPayBox";
            this.downPayBox.Size = new System.Drawing.Size(140, 20);
            this.downPayBox.TabIndex = 5;
            this.downPayBox.TextChanged += new System.EventHandler(this.downPayBox_TextChanged);
            this.downPayBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.downPayBox_KeyDown);
            // 
            // interestBox
            // 
            this.interestBox.Location = new System.Drawing.Point(211, 230);
            this.interestBox.Name = "interestBox";
            this.interestBox.Size = new System.Drawing.Size(140, 20);
            this.interestBox.TabIndex = 6;
            this.interestBox.TextChanged += new System.EventHandler(this.interestBox_TextChanged);
            this.interestBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.interestBox_KeyDown);
            // 
            // termBox
            // 
            this.termBox.Location = new System.Drawing.Point(211, 278);
            this.termBox.Name = "termBox";
            this.termBox.Size = new System.Drawing.Size(140, 20);
            this.termBox.TabIndex = 7;
            this.termBox.TextChanged += new System.EventHandler(this.termBox_TextChanged);
            this.termBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.termBox_KeyDown);
            // 
            // financeBox
            // 
            this.financeBox.BackColor = System.Drawing.SystemColors.Info;
            this.financeBox.Location = new System.Drawing.Point(623, 127);
            this.financeBox.Name = "financeBox";
            this.financeBox.ReadOnly = true;
            this.financeBox.Size = new System.Drawing.Size(125, 20);
            this.financeBox.TabIndex = 8;
            // 
            // paymentBox
            // 
            this.paymentBox.BackColor = System.Drawing.SystemColors.Info;
            this.paymentBox.Location = new System.Drawing.Point(622, 179);
            this.paymentBox.Name = "paymentBox";
            this.paymentBox.ReadOnly = true;
            this.paymentBox.Size = new System.Drawing.Size(126, 20);
            this.paymentBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Home Purchase Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Down Payment Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Interest Rate (%):";
            // 
            // lable4
            // 
            this.lable4.AutoSize = true;
            this.lable4.Location = new System.Drawing.Point(101, 281);
            this.lable4.Name = "lable4";
            this.lable4.Size = new System.Drawing.Size(104, 13);
            this.lable4.TabIndex = 13;
            this.lable4.Text = "Loan Term (months):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(512, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Amount to Finanace:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(525, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Monthly Payment:";
            // 
            // MortgageCal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lable4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paymentBox);
            this.Controls.Add(this.financeBox);
            this.Controls.Add(this.termBox);
            this.Controls.Add(this.interestBox);
            this.Controls.Add(this.downPayBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.name);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.close);
            this.Controls.Add(this.calculate);
            this.Name = "MortgageCal";
            this.Text = "Mortgage Application and Calculation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox downPayBox;
        private System.Windows.Forms.TextBox interestBox;
        private System.Windows.Forms.TextBox termBox;
        private System.Windows.Forms.TextBox financeBox;
        private System.Windows.Forms.TextBox paymentBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lable4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

