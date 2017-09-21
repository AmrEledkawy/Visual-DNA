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
    public partial class Merge : Form
    {
        public Merge()
        {
            InitializeComponent();
        }
        string tube1, tube2;
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
                            tube1 = File.ReadAllText(theDialog.FileName);
                            txtTube1.Text = tube1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void btnUpload2_Click(object sender, EventArgs e)
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
                            tube2 = File.ReadAllText(theDialog.FileName);
                            txtTube2.Text = tube2;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMerge.Text = OperationsOfDNAComputing.merge(tube1, tube2);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(f.SelectedPath + "\\merge.txt", txtMerge.Text);
                MessageBox.Show("Saved to " + f.SelectedPath + "\\merge.txt", "Saved File", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
