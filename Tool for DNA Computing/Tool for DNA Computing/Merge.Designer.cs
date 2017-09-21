namespace Tool_for_DNA_Computing
{
    partial class Merge
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTube2 = new System.Windows.Forms.TextBox();
            this.btnUpload2 = new System.Windows.Forms.Button();
            this.txtTube1 = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtMerge = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 520);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 23);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save as Text File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTube2
            // 
            this.txtTube2.Location = new System.Drawing.Point(12, 208);
            this.txtTube2.Multiline = true;
            this.txtTube2.Name = "txtTube2";
            this.txtTube2.Size = new System.Drawing.Size(582, 114);
            this.txtTube2.TabIndex = 29;
            // 
            // btnUpload2
            // 
            this.btnUpload2.Location = new System.Drawing.Point(12, 179);
            this.btnUpload2.Name = "btnUpload2";
            this.btnUpload2.Size = new System.Drawing.Size(160, 23);
            this.btnUpload2.TabIndex = 28;
            this.btnUpload2.Text = "Upload Test Tube 2 File";
            this.btnUpload2.UseVisualStyleBackColor = true;
            this.btnUpload2.Click += new System.EventHandler(this.btnUpload2_Click);
            // 
            // txtTube1
            // 
            this.txtTube1.Location = new System.Drawing.Point(12, 41);
            this.txtTube1.Multiline = true;
            this.txtTube1.Name = "txtTube1";
            this.txtTube1.Size = new System.Drawing.Size(582, 114);
            this.txtTube1.TabIndex = 26;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(12, 12);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(160, 23);
            this.btnUpload.TabIndex = 27;
            this.btnUpload.Text = "Upload Test Tube 1 File";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtMerge
            // 
            this.txtMerge.Location = new System.Drawing.Point(12, 383);
            this.txtMerge.Multiline = true;
            this.txtMerge.Name = "txtMerge";
            this.txtMerge.Size = new System.Drawing.Size(582, 114);
            this.txtMerge.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Merge Test Tubes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Merge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 557);
            this.Controls.Add(this.txtMerge);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTube2);
            this.Controls.Add(this.btnUpload2);
            this.Controls.Add(this.txtTube1);
            this.Controls.Add(this.btnUpload);
            this.MinimizeBox = false;
            this.Name = "Merge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Merge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtTube2;
        private System.Windows.Forms.Button btnUpload2;
        private System.Windows.Forms.TextBox txtTube1;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txtMerge;
        private System.Windows.Forms.Button button1;
    }
}