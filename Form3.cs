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
    public partial class Form3 : Form
    {
       
        Dictionary<string, string> Preg = new Dictionary<string, string>();
        int i, acabar;
        string k, j;
        bool acabat = false;
        
        public Form3(Dictionary<string,string> vocab, int limit)
        {
            InitializeComponent();
            Preg = vocab;
            acabar = limit;
            Random rand = new Random();
            Preg = Preg.OrderBy(x => rand.Next()).ToDictionary(item => item.Key, item => item.Value);
            i = 0;
            k = Preg.ElementAt(i).Key;
            j = Preg.ElementAt(i).Value;
            label3.Text = k;
            button3.Visible = false;
        }
        int compte = 0;

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2.PerformClick();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 q = new Form3(Preg, acabar);
            q.ShowDialog();
        }

        int encerts = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            compte++;
            if (button2.Text == "Finish Exam") this.Close();
            else if (textBox2.Text == j & compte != acabar)
            {
                label5.Text = "Correct";
                ++i;
                ++encerts;
                label3.Text = Preg.ElementAt(i).Key;
                j = Preg.ElementAt(i).Value;
            }
            else if(textBox2.Text == j & compte == acabar)
            {
                button3.Visible = true;
                label5.Text = "Correct";
                ++encerts;
                label3.Text = "You have " + encerts.ToString() + "/" + acabar.ToString();
                button2.Text = "Finish Exam";
            }
            else if (textBox2.Text != j & compte == acabar)
            {
                button3.Visible = true;
                label5.Text = "Error";
                label3.Text = "You have "+encerts.ToString()+"/"+acabar.ToString();
                button2.Text = "Finish Exam";
                

            }
            else
            {
                label5.Text = "Error";
                ++i;
                label3.Text = Preg.ElementAt(i).Key;
                j = Preg.ElementAt(i).Value;
            }
            textBox2.Text = string.Empty;
        }


    }
}
