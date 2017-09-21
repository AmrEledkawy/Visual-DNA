using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tool_for_DNA_Computing
{
    public partial class AppendHead : Form
    {
        public AppendHead()
        {
            InitializeComponent();
        }
        string tube, pattern;
        private void btnUpload_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"E:\1st Master\Tool\Tool";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = theDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the stream here.                            
                            tube = File.ReadAllText(theDialog.FileName);
                            txtTube.Text = tube;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void btnAppH_Click(object sender, EventArgs e)
        {
            pattern = txtPattern.Text;
            txtAppH.Text = OperationsOfDNAComputing.appendHead(tube, pattern);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(f.SelectedPath + "\\appendHead.txt", txtAppH.Text);
                MessageBox.Show("Saved to " + f.SelectedPath + "\\appendHead.txt", "Saved File", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
