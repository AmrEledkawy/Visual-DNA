namespace Tool_for_DNA_Computing
{
    partial class Substitute
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
            this.txtSub = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPattern1 = new System.Windows.Forms.TextBox();
            this.txtTube = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPattern2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSub
            // 
            this.txtSub.Location = new System.Drawing.Point(10, 322);
            this.txtSub.Multiline = true;
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(582, 114);
            this.txtSub.TabIndex = 64;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(10, 442);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 23);
            this.btnSave.TabIndex = 63;
            this.btnSave.Text = "Save as Text File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(10, 279);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(160, 23);
            this.btnSub.TabIndex = 62;
            this.btnSub.Text = "Substitute";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Enter the Pattern";
            // 
            // txtPattern1
            // 
            this.txtPattern1.Location = new System.Drawing.Point(174, 181);
            this.txtPattern1.Name = "txtPattern1";
            this.txtPattern1.Size = new System.Drawing.Size(136, 20);
            this.txtPattern1.TabIndex = 60;
            // 
            // txtTube
            // 
            this.txtTube.Location = new System.Drawing.Point(10, 36);
            this.txtTube.Multiline = true;
            this.txtTube.Name = "txtTube";
            this.txtTube.Size = new System.Drawing.Size(582, 114);
            this.txtTube.TabIndex = 58;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(10, 7);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(160, 23);
            this.btnUpload.TabIndex = 59;
            this.btnUpload.Text = "Upload Test Tube  File";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "Enter the new Pattern";
            // 
            // txtPattern2
            // 
            this.txtPattern2.Location = new System.Drawing.Point(174, 229);
            this.txtPattern2.Name = "txtPattern2";
            this.txtPattern2.Size = new System.Drawing.Size(136, 20);
            this.txtPattern2.TabIndex = 65;
            // 
            // Substitute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 475);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPattern2);
            this.Controls.Add(this.txtSub);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPattern1);
            this.Controls.Add(this.txtTube);
            this.Controls.Add(this.btnUpload);
            this.MaximizeBox = false;
            this.Name = "Substitute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Substitute";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSub;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPattern1;
        private System.Windows.Forms.TextBox txtTube;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPattern2;
    }
}