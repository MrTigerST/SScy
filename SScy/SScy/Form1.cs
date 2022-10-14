using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SScy.Traslating; // Using Translation system

namespace SScy
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Convert.ToString(id_txbx.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "ENGLISH")
            {
                button1.Text = "CONNECTION REQUEST";
            }
            else
            {
                button1.Text = "RICHIEDI LA CONNESSIONE";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(codice.Text);
            if (comboBox1.Text == "ENGLISH")
            {
                MessageBox.Show("Code copied");
            }
            else
            {
                MessageBox.Show("Codice Copiato");
            }
        }
    }
}

       