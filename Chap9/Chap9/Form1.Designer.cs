namespace Chap9
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
            this.label5 = new System.Windows.Forms.Label();
            this.assignment1 = new System.Windows.Forms.TextBox();
            this.assignment2 = new System.Windows.Forms.TextBox();
            this.assignment3 = new System.Windows.Forms.TextBox();
            this.numOfGrades = new System.Windows.Forms.TextBox();
            this.answer = new System.Windows.Forms.TextBox();
            this.average = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Grade Book";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Assignment 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Assignment 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Assignment  3";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 60);
            this.label5.TabIndex = 4;
            this.label5.Text = "Enter the number of grades";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // assignment1
            // 
            this.assignment1.Location = new System.Drawing.Point(295, 52);
            this.assignment1.Name = "assignment1";
            this.assignment1.Size = new System.Drawing.Size(100, 20);
            this.assignment1.TabIndex = 5;
            this.assignment1.TextChanged += new System.EventHandler(this.assignment1_TextChanged);
            // 
            // assignment2
            // 
            this.assignment2.Location = new System.Drawing.Point(295, 103);
            this.assignment2.Name = "assignment2";
            this.assignment2.Size = new System.Drawing.Size(100, 20);
            this.assignment2.TabIndex = 6;
            // 
            // assignment3
            // 
            this.assignment3.Location = new System.Drawing.Point(295, 154);
            this.assignment3.Name = "assignment3";
            this.assignment3.Size = new System.Drawing.Size(100, 20);
            this.assignment3.TabIndex = 7;
            // 
            // numOfGrades
            // 
            this.numOfGrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfGrades.Location = new System.Drawing.Point(194, 225);
            this.numOfGrades.Name = "numOfGrades";
            this.numOfGrades.Size = new System.Drawing.Size(67, 32);
            this.numOfGrades.TabIndex = 8;
            // 
            // answer
            // 
            this.answer.BackColor = System.Drawing.Color.PaleTurquoise;
            this.answer.Location = new System.Drawing.Point(278, 237);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(104, 20);
            this.answer.TabIndex = 9;
            // 
            // average
            // 
            this.average.Location = new System.Drawing.Point(295, 196);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(75, 23);
            this.average.TabIndex = 10;
            this.average.Text = "Average";
            this.average.UseVisualStyleBackColor = true;
            this.average.Visible = false;
            this.average.Click += new System.EventHandler(this.average_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(295, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(869, 468);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.average);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.numOfGrades);
            this.Controls.Add(this.assignment3);
            this.Controls.Add(this.assignment2);
            this.Controls.Add(this.assignment1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox assignment1;
        private System.Windows.Forms.TextBox assignment2;
        private System.Windows.Forms.TextBox assignment3;
        private System.Windows.Forms.TextBox numOfGrades;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Button average;
        private System.Windows.Forms.Button button2;
    }
}

