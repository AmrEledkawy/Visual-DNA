namespace Tool_for_DNA_Computing
{
    partial class Sort
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
            this.txtTube = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.txtShort = new System.Windows.Forms.TextBox();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRemoved = new System.Windows.Forms.TextBox();
            this.btnSaved3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTube
            // 
            this.txtTube.Location = new System.Drawing.Point(12, 45);
            this.txtTube.Multiline = true;
            this.txtTube.Name = "txtTube";
            this.txtTube.Size = new System.Drawing.Size(582, 114);
            this.txtTube.TabIndex = 45;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(12, 16);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(160, 23);
            this.btnUpload.TabIndex = 46;
            this.btnUpload.Text = "Upload Test Tube  File";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(12, 179);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(160, 23);
            this.btnSort.TabIndex = 47;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Shortest Length Sequences";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Longest Length Sequences";
            // 
            // btnSave2
            // 
            this.btnSave2.Location = new System.Drawing.Point(12, 458);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(160, 23);
            this.btnSave2.TabIndex = 56;
            this.btnSave2.Text = "Save as Text File";
            this.btnSave2.UseVisualStyleBackColor = true;
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // txtShort
            // 
            this.txtShort.Location = new System.Drawing.Point(12, 249);
            this.txtShort.Multiline = true;
            this.txtShort.Name = "txtShort";
            this.txtShort.Size = new System.Drawing.Size(582, 50);
            this.txtShort.TabIndex = 55;
            // 
            // btnSave1
            // 
            this.btnSave1.Location = new System.Drawing.Point(12, 314);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(160, 23);
            this.btnSave1.TabIndex = 54;
            this.btnSave1.Text = "Save as Text File";
            this.btnSave1.UseVisualStyleBackColor = true;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // txtLong
            // 
            this.txtLong.Location = new System.Drawing.Point(12, 392);
            this.txtLong.Multiline = true;
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(582, 50);
            this.txtLong.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 499);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Removed Sequences";
            // 
            // txtRemoved
            // 
            this.txtRemoved.Location = new System.Drawing.Point(12, 524);
            this.txtRemoved.Multiline = true;
            this.txtRemoved.Name = "txtRemoved";
            this.txtRemoved.Size = new System.Drawing.Size(582, 114);
            this.txtRemoved.TabIndex = 62;
            // 
            // btnSaved3
            // 
            this.btnSaved3.Location = new System.Drawing.Point(12, 644);
            this.btnSaved3.Name = "btnSaved3";
            this.btnSaved3.Size = new System.Drawing.Size(160, 23);
            this.btnSaved3.TabIndex = 61;
            this.btnSaved3.Text = "Save as Text File";
            this.btnSaved3.UseVisualStyleBackColor = true;
            this.btnSaved3.Click += new System.EventHandler(this.btnSaved3_Click);
            // 
            // Sort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 675);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRemoved);
            this.Controls.Add(this.btnSaved3);
            this.Controls.Add(this.txtLong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave2);
            this.Controls.Add(this.txtShort);
            this.Controls.Add(this.btnSave1);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.txtTube);
            this.Controls.Add(this.btnUpload);
            this.MaximizeBox = false;
            this.Name = "Sort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTube;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.TextBox txtShort;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRemoved;
        private System.Windows.Forms.Button btnSaved3;
    }
}