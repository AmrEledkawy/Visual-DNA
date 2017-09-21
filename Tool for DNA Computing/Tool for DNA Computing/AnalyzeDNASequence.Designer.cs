namespace Tool_for_DNA_Computing
{
    partial class AnalyzeDNASequence
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
            this.txtSequence = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNuPercent = new System.Windows.Forms.Label();
            this.lblGC = new System.Windows.Forms.Label();
            this.lblMT = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.lblMW = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSequence
            // 
            this.txtSequence.Location = new System.Drawing.Point(12, 41);
            this.txtSequence.Multiline = true;
            this.txtSequence.Name = "txtSequence";
            this.txtSequence.Size = new System.Drawing.Size(582, 114);
            this.txtSequence.TabIndex = 3;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(12, 12);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(160, 23);
            this.btnUpload.TabIndex = 4;
            this.btnUpload.Text = "Upload DNA Sequence File";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nucleotide Percentage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "GC_AT Content";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Melting Temprature";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "G_C_A_T Content";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Molecular Weight";
            // 
            // lblNuPercent
            // 
            this.lblNuPercent.AutoSize = true;
            this.lblNuPercent.Location = new System.Drawing.Point(260, 235);
            this.lblNuPercent.Name = "lblNuPercent";
            this.lblNuPercent.Size = new System.Drawing.Size(0, 13);
            this.lblNuPercent.TabIndex = 10;
            // 
            // lblGC
            // 
            this.lblGC.AutoSize = true;
            this.lblGC.Location = new System.Drawing.Point(260, 297);
            this.lblGC.Name = "lblGC";
            this.lblGC.Size = new System.Drawing.Size(0, 13);
            this.lblGC.TabIndex = 11;
            // 
            // lblMT
            // 
            this.lblMT.AutoSize = true;
            this.lblMT.Location = new System.Drawing.Point(260, 342);
            this.lblMT.Name = "lblMT";
            this.lblMT.Size = new System.Drawing.Size(0, 13);
            this.lblMT.TabIndex = 12;
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Location = new System.Drawing.Point(260, 389);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(0, 13);
            this.lblG.TabIndex = 13;
            // 
            // lblMW
            // 
            this.lblMW.AutoSize = true;
            this.lblMW.Location = new System.Drawing.Point(260, 450);
            this.lblMW.Name = "lblMW";
            this.lblMW.Size = new System.Drawing.Size(0, 13);
            this.lblMW.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Analyze DNA Sequence";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnalyzeDNASequence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 490);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMW);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.lblMT);
            this.Controls.Add(this.lblGC);
            this.Controls.Add(this.lblNuPercent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSequence);
            this.Controls.Add(this.btnUpload);
            this.MaximizeBox = false;
            this.Name = "AnalyzeDNASequence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analyze DNA Sequence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSequence;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNuPercent;
        private System.Windows.Forms.Label lblGC;
        private System.Windows.Forms.Label lblMT;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblMW;
        private System.Windows.Forms.Button button1;
    }
}