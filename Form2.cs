using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace preguntes_anglès
{
    public partial class Form2 : Form
    {
        public Form2(string limit)
        {
            InitializeComponent();
            label4.Text = limit;
        }
        Dictionary<string,string> vocab = new Dictionary<string, string>();
        int compte = 0;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label3.Text = textBox2.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            vocab.Add(label3.Text, label2.Text);
            compte++;
            textBox2.Focus();
            textBox1.Text = textBox2.Text = string.Empty;
            if(compte == Convert.ToInt32(label4.Text))
            {
                this.Visible = false;
                Form3 h = new Form3(vocab, Convert.ToInt32(label4.Text));
                h.ShowDialog();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox1.Focus();
            }
        }
    }
}
