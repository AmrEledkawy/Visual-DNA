namespace Tool_for_DNA_Computing
{
    partial class AppendHead
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
            this.txtAppH = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAppH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.txtTube = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAppH
            // 
            this.txtAppH.Location = new System.Drawing.Point(10, 265);
            this.txtAppH.Multiline = true;
            this.txtAppH.Name = "txtAppH";
            this.txtAppH.Size = new System.Drawing.Size(582, 114);
            this.txtAppH.TabIndex = 50;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(10, 385);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 23);
            this.btnSave.TabIndex = 49;
            this.btnSave.Text = "Save as Text File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAppH
            // 
            this.btnAppH.Location = new System.Drawing.Point(10, 222);
            this.btnAppH.Name = "btnAppH";
            this.btnAppH.Size = new System.Drawing.Size(160, 23);
            this.btnAppH.TabIndex = 48;
            this.btnAppH.Text = "Append Head";
            this.btnAppH.UseVisualStyleBackColor = true;
            this.btnAppH.Click += new System.EventHandler(this.btnAppH_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Enter the Pattern";
            // 
            // txtPattern
            // 
            this.txtPattern.Location = new System.Drawing.Point(174, 182);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(136, 20);
            this.txtPattern.TabIndex = 46;
            // 
            // txtTube
            // 
            this.txtTube.Location = new System.Drawing.Point(10, 37);
            this.txtTube.Multiline = true;
            this.txtTube.Name = "txtTube";
            this.txtTube.Size = new System.Drawing.Size(582, 114);
            this.txtTube.TabIndex = 44;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(10, 8);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(160, 23);
            this.btnUpload.TabIndex = 45;
            this.btnUpload.Text = "Upload Test Tube  File";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // AppendHead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 417);
            this.Controls.Add(this.txtAppH);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAppH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPattern);
            this.Controls.Add(this.txtTube);
            this.Controls.Add(this.btnUpload);
            this.MaximizeBox = false;
            this.Name = "AppendHead";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Append Head";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAppH;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAppH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.TextBox txtTube;
        private System.Windows.Forms.Button btnUpload;
    }
}