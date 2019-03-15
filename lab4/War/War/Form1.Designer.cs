namespace War
{
    partial class War
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(War));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.currentScores = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.playerWin = new System.Windows.Forms.RichTextBox();
            this.computerWin = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonContainer = new System.Windows.Forms.GroupBox();
            this.exit = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.draw = new System.Windows.Forms.Button();
            this.computerBox = new System.Windows.Forms.PictureBox();
            this.playerBox = new System.Windows.Forms.PictureBox();
            this.currentScores.SuspendLayout();
            this.buttonContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.computerBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(67, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Computer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(616, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player:";
            // 
            // currentScores
            // 
            this.currentScores.Controls.Add(this.richTextBox1);
            this.currentScores.Controls.Add(this.playerWin);
            this.currentScores.Controls.Add(this.computerWin);
            this.currentScores.Controls.Add(this.label4);
            this.currentScores.Controls.Add(this.label3);
            this.currentScores.Location = new System.Drawing.Point(275, 79);
            this.currentScores.Name = "currentScores";
            this.currentScores.Size = new System.Drawing.Size(290, 255);
            this.currentScores.TabIndex = 2;
            this.currentScores.TabStop = false;
            this.currentScores.Text = "Current Scores:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.richTextBox1.Location = new System.Drawing.Point(7, 201);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(277, 48);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // playerWin
            // 
            this.playerWin.BackColor = System.Drawing.SystemColors.Window;
            this.playerWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerWin.Location = new System.Drawing.Point(155, 110);
            this.playerWin.Name = "playerWin";
            this.playerWin.ReadOnly = true;
            this.playerWin.Size = new System.Drawing.Size(84, 44);
            this.playerWin.TabIndex = 3;
            this.playerWin.Text = "";
            // 
            // computerWin
            // 
            this.computerWin.BackColor = System.Drawing.SystemColors.Window;
            this.computerWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerWin.Location = new System.Drawing.Point(155, 34);
            this.computerWin.Name = "computerWin";
            this.computerWin.ReadOnly = true;
            this.computerWin.Size = new System.Drawing.Size(84, 44);
            this.computerWin.TabIndex = 2;
            this.computerWin.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Player # Wins:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Computer # Wins:";
            // 
            // buttonContainer
            // 
            this.buttonContainer.BackColor = System.Drawing.Color.Crimson;
            this.buttonContainer.Controls.Add(this.exit);
            this.buttonContainer.Controls.Add(this.start);
            this.buttonContainer.Controls.Add(this.draw);
            this.buttonContainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContainer.Location = new System.Drawing.Point(12, 343);
            this.buttonContainer.Name = "buttonContainer";
            this.buttonContainer.Size = new System.Drawing.Size(810, 95);
            this.buttonContainer.TabIndex = 3;
            this.buttonContainer.TabStop = false;
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(693, 19);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(83, 54);
            this.exit.TabIndex = 2;
            this.exit.Text = "Close";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click_1);
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(582, 19);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(83, 54);
            this.start.TabIndex = 1;
            this.start.Text = "New Game";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // draw
            // 
            this.draw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.draw.ForeColor = System.Drawing.Color.Black;
            this.draw.Location = new System.Drawing.Point(75, 19);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(83, 54);
            this.draw.TabIndex = 0;
            this.draw.Text = "Draw";
            this.draw.UseVisualStyleBackColor = true;
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // computerBox
            // 
            this.computerBox.Image = ((System.Drawing.Image)(resources.GetObject("computerBox.Image")));
            this.computerBox.Location = new System.Drawing.Point(74, 79);
            this.computerBox.Name = "computerBox";
            this.computerBox.Size = new System.Drawing.Size(169, 255);
            this.computerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.computerBox.TabIndex = 4;
            this.computerBox.TabStop = false;
            // 
            // playerBox
            // 
            this.playerBox.Image = ((System.Drawing.Image)(resources.GetObject("playerBox.Image")));
            this.playerBox.Location = new System.Drawing.Point(594, 84);
            this.playerBox.Name = "playerBox";
            this.playerBox.Size = new System.Drawing.Size(169, 249);
            this.playerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerBox.TabIndex = 5;
            this.playerBox.TabStop = false;
            // 
            // War
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 450);
            this.Controls.Add(this.playerBox);
            this.Controls.Add(this.computerBox);
            this.Controls.Add(this.buttonContainer);
            this.Controls.Add(this.currentScores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "War";
            this.Text = "War";
            this.Load += new System.EventHandler(this.War_Load);
            this.currentScores.ResumeLayout(false);
            this.currentScores.PerformLayout();
            this.buttonContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.computerBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox currentScores;
        private System.Windows.Forms.RichTextBox playerWin;
        private System.Windows.Forms.RichTextBox computerWin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox buttonContainer;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.PictureBox computerBox;
        private System.Windows.Forms.PictureBox playerBox;
    }
}

