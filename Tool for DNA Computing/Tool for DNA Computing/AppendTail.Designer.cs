namespace Tool_for_DNA_Computing
{
    partial class AppendTail
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
            this.txtAppT = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAppT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.txtTube = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAppT
            // 
            this.txtAppT.Location = new System.Drawing.Point(12, 264);
            this.txtAppT.Multiline = true;
            this.txtAppT.Name = "txtAppT";
            this.txtAppT.Size = new System.Drawing.Size(582, 114);
            this.txtAppT.TabIndex = 57;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 384);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 23);
            this.btnSave.TabIndex = 56;
            this.btnSave.Text = "Save as Text File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAppT
            // 
            this.btnAppT.Location = new System.Drawing.Point(12, 221);
            this.btnAppT.Name = "btnAppT";
            this.btnAppT.Size = new System.Drawing.Size(160, 23);
            this.btnAppT.TabIndex = 55;
            this.btnAppT.Text = "Append Tail";
            this.btnAppT.UseVisualStyleBackColor = true;
            this.btnAppT.Click += new System.EventHandler(this.btnAppT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Enter the Pattern";
            // 
            // txtPattern
            // 
            this.txtPattern.Location = new System.Drawing.Point(176, 181);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(136, 20);
            this.txtPattern.TabIndex = 53;
            // 
            // txtTube
            // 
            this.txtTube.Location = new System.Drawing.Point(12, 36);
            this.txtTube.Multiline = true;
            this.txtTube.Name = "txtTube";
            this.txtTube.Size = new System.Drawing.Size(582, 114);
            this.txtTube.TabIndex = 51;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(12, 7);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(160, 23);
            this.btnUpload.TabIndex = 52;
            this.btnUpload.Text = "Upload Test Tube  File";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // AppendTail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 414);
            this.Controls.Add(this.txtAppT);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAppT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPattern);
            this.Controls.Add(this.txtTube);
            this.Controls.Add(this.btnUpload);
            this.MaximizeBox = false;
            this.Name = "AppendTail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Append Tail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAppT;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAppT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.TextBox txtTube;
        private System.Windows.Forms.Button btnUpload;
    }
}