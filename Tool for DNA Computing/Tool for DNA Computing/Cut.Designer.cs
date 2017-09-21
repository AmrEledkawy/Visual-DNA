namespace Tool_for_DNA_Computing
{
    partial class Cut
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
            this.btnCut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.txtTube = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtCut = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCut
            // 
            this.btnCut.Location = new System.Drawing.Point(12, 224);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(160, 23);
            this.btnCut.TabIndex = 41;
            this.btnCut.Text = "Cut";
            this.btnCut.UseVisualStyleBackColor = true;
            this.btnCut.Click += new System.EventHandler(this.btnReserved_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Enter the Pattern";
            // 
            // txtPattern
            // 
            this.txtPattern.Location = new System.Drawing.Point(176, 184);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(136, 20);
            this.txtPattern.TabIndex = 39;
            // 
            // txtTube
            // 
            this.txtTube.Location = new System.Drawing.Point(12, 39);
            this.txtTube.Multiline = true;
            this.txtTube.Name = "txtTube";
            this.txtTube.Size = new System.Drawing.Size(582, 114);
            this.txtTube.TabIndex = 37;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(12, 10);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(160, 23);
            this.btnUpload.TabIndex = 38;
            this.btnUpload.Text = "Upload Test Tube  File";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtCut
            // 
            this.txtCut.Location = new System.Drawing.Point(12, 267);
            this.txtCut.Multiline = true;
            this.txtCut.Name = "txtCut";
            this.txtCut.Size = new System.Drawing.Size(582, 114);
            this.txtCut.TabIndex = 43;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 387);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 23);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "Save as Text File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Cut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 443);
            this.Controls.Add(this.txtCut);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPattern);
            this.Controls.Add(this.txtTube);
            this.Controls.Add(this.btnUpload);
            this.MaximizeBox = false;
            this.Name = "Cut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.TextBox txtTube;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txtCut;
        private System.Windows.Forms.Button btnSave;
    }
}