namespace Tool_for_DNA_Computing
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
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.btnComplement = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnSeperate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.Location = new System.Drawing.Point(12, 27);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(159, 23);
            this.btnAnalysis.TabIndex = 0;
            this.btnAnalysis.Text = "Analyze DNA Sequence";
            this.btnAnalysis.UseVisualStyleBackColor = true;
            this.btnAnalysis.Click += new System.EventHandler(this.btnAnalysis_Click);
            // 
            // btnComplement
            // 
            this.btnComplement.Location = new System.Drawing.Point(12, 83);
            this.btnComplement.Name = "btnComplement";
            this.btnComplement.Size = new System.Drawing.Size(159, 23);
            this.btnComplement.TabIndex = 1;
            this.btnComplement.Text = "Complement DNA Sequence";
            this.btnComplement.UseVisualStyleBackColor = true;
            this.btnComplement.Click += new System.EventHandler(this.btnComplement_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(12, 143);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(159, 23);
            this.btnReverse.TabIndex = 2;
            this.btnReverse.Text = "Reverse DNA Sequence";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnSeperate
            // 
            this.btnSeperate.Location = new System.Drawing.Point(343, 27);
            this.btnSeperate.Name = "btnSeperate";
            this.btnSeperate.Size = new System.Drawing.Size(324, 23);
            this.btnSeperate.TabIndex = 5;
            this.btnSeperate.Text = "Sperate Sequences with Specific Pattern in a Test Tube";
            this.btnSeperate.UseVisualStyleBackColor = true;
            this.btnSeperate.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(343, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(324, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Select Sequences of Specific Length in a Test Tube";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(12, 200);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(159, 23);
            this.btnMerge.TabIndex = 3;
            this.btnMerge.Text = "Merge two Test Tubes";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(12, 258);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(159, 23);
            this.btnSort.TabIndex = 6;
            this.btnSort.Text = "Sort Test Tube Sequences";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(324, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cut Test Tube Sequences at Specific Pattern";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(343, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(324, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Append Pattern at the Head of every Sequence in the Test Tube";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(343, 258);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(324, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Append Pattern at the Tail of every Sequence in the test Tube";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(343, 313);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(324, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Substitute Pattern in Test Tube Sequences with another";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 364);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnSeperate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnComplement);
            this.Controls.Add(this.btnAnalysis);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DNA Computing Tool";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnalysis;
        private System.Windows.Forms.Button btnComplement;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnSeperate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

