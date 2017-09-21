namespace Tool_for_DNA_Computing
{
    partial class Select
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRemoved = new System.Windows.Forms.TextBox();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.txtReserved = new System.Windows.Forms.TextBox();
            this.btnReserved = new System.Windows.Forms.Button();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtTube = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Sequences with the Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Removed Sequences";
            // 
            // txtRemoved
            // 
            this.txtRemoved.Location = new System.Drawing.Point(19, 498);
            this.txtRemoved.Multiline = true;
            this.txtRemoved.Name = "txtRemoved";
            this.txtRemoved.Size = new System.Drawing.Size(582, 114);
            this.txtRemoved.TabIndex = 51;
            // 
            // btnSave2
            // 
            this.btnSave2.Location = new System.Drawing.Point(19, 618);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(160, 23);
            this.btnSave2.TabIndex = 50;
            this.btnSave2.Text = "Save as Text File";
            this.btnSave2.UseVisualStyleBackColor = true;
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // txtReserved
            // 
            this.txtReserved.Location = new System.Drawing.Point(19, 316);
            this.txtReserved.Multiline = true;
            this.txtReserved.Name = "txtReserved";
            this.txtReserved.Size = new System.Drawing.Size(582, 114);
            this.txtReserved.TabIndex = 49;
            // 
            // btnReserved
            // 
            this.btnReserved.Location = new System.Drawing.Point(19, 234);
            this.btnReserved.Name = "btnReserved";
            this.btnReserved.Size = new System.Drawing.Size(160, 23);
            this.btnReserved.TabIndex = 48;
            this.btnReserved.Text = "Select";
            this.btnReserved.UseVisualStyleBackColor = true;
            this.btnReserved.Click += new System.EventHandler(this.btnReserved_Click);
            // 
            // btnSave1
            // 
            this.btnSave1.Location = new System.Drawing.Point(19, 436);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(160, 23);
            this.btnSave1.TabIndex = 47;
            this.btnSave1.Text = "Save as Text File";
            this.btnSave1.UseVisualStyleBackColor = true;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Enter the length";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(183, 194);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(136, 20);
            this.txtLength.TabIndex = 45;
            // 
            // txtTube
            // 
            this.txtTube.Location = new System.Drawing.Point(19, 49);
            this.txtTube.Multiline = true;
            this.txtTube.Name = "txtTube";
            this.txtTube.Size = new System.Drawing.Size(582, 114);
            this.txtTube.TabIndex = 43;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(19, 20);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(160, 23);
            this.btnUpload.TabIndex = 44;
            this.btnUpload.Text = "Upload Test Tube  File";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 660);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRemoved);
            this.Controls.Add(this.btnSave2);
            this.Controls.Add(this.txtReserved);
            this.Controls.Add(this.btnReserved);
            this.Controls.Add(this.btnSave1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtTube);
            this.Controls.Add(this.btnUpload);
            this.MaximizeBox = false;
            this.Name = "Select";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRemoved;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.TextBox txtReserved;
        private System.Windows.Forms.Button btnReserved;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtTube;
        private System.Windows.Forms.Button btnUpload;
    }
}