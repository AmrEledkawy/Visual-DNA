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
    public partial class AnalyzeDNASequence : Form
    {
        public AnalyzeDNASequence()
        {
            InitializeComponent();
        }
        string sequence;
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
                            sequence = File.ReadAllText(theDialog.FileName);
                            txtSequence.Text = sequence;
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
           float[] NPer= OperationsOfDNAComputing.Nu_Percentage(sequence);
           lblNuPercent.Text = "A " + NPer[0]+" %" + "\nC " + NPer[1] +" %"+
               "\nG " + NPer[2] + " %" + "\nC " + NPer[3]+" %";

           int GC; int AT;
           OperationsOfDNAComputing.GC_AT_Content(sequence,out GC,out AT);
           lblGC.Text = "GC " + GC + " nucleotides" + "\nAT " + AT + " nucleotides";

           lblMT.Text = OperationsOfDNAComputing.DNA_Melting_Temp(sequence).ToString();

           int G; int C; int A; int T;
           OperationsOfDNAComputing.G_C_A_T_Content(sequence, out A, out C, out G, out T);
           lblG.Text = "A " + A + " nucleotides" + "\nC " + C + " nucleotides" + "\nG " + G + " nucleotides" +
               "\nT " + T + " nucleotides";

           lblMW.Text = OperationsOfDNAComputing.DNA_MW(sequence).ToString();
        }
    }
}
