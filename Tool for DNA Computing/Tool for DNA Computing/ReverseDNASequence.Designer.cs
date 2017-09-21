namespace Tool_for_DNA_Computing
{
    partial class ReverseDNASequence
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtSequence = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtReverse = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Reverse DNA Sequence";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSequence
            // 
            this.txtSequence.Location = new System.Drawing.Point(12, 40);
            this.txtSequence.Multiline = true;
            this.txtSequence.Name = "txtSequence";
            this.txtSequence.Size = new System.Drawing.Size(582, 114);
            this.txtSequence.TabIndex = 16;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(12, 11);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(160, 23);
            this.btnUpload.TabIndex = 17;
            this.btnUpload.Text = "Upload DNA Sequence File";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtReverse
            // 
            this.txtReverse.Location = new System.Drawing.Point(12, 207);
            this.txtReverse.Multiline = true;
            this.txtReverse.Name = "txtReverse";
            this.txtReverse.Size = new System.Drawing.Size(582, 114);
            this.txtReverse.TabIndex = 19;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 345);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save as Text File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ReverseDNASequence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 400);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtReverse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSequence);
            this.Controls.Add(this.btnUpload);
            this.MinimizeBox = false;
            this.Name = "ReverseDNASequence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reverse DNA Sequence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSequence;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txtReverse;
        private System.Windows.Forms.Button btnSave;
    }
}