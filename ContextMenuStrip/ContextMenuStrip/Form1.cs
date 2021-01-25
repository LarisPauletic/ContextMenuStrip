using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContextMenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening_1(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void desnoNaLijevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBxLijevo.Text = txtBxDesno.Text;
        }

        private void lijevoNaDesnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBxDesno.Text = txtBxLijevo.Text;
        }

        private void contextMenuStrip1_Opening_2(object sender, CancelEventArgs e)
        {

        }

        
    }
}
