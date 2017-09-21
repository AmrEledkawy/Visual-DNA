using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tool_for_DNA_Computing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            Form f = new AnalyzeDNASequence(); f.Show();
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            Form f = new ReverseDNASequence(); f.Show();
        }

        private void btnComplement_Click(object sender, EventArgs e)
        {
            Form f = new ComplementDNASequence(); f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = new Merge(); f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new Seperate(); f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new Select(); f.Show();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Form f = new Sort(); f.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form f = new Cut(); f.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form f = new AppendHead(); f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f = new AppendTail(); f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form f = new Substitute(); f.Show();
        }
    }
}
