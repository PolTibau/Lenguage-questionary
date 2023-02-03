using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace preguntes_anglès
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> Preg = new Dictionary<string, string>();
            string[] lines1 = File.ReadAllLines(textBox1.Text).ToArray();
            string[] lines2 = File.ReadAllLines(textBox2.Text).ToArray();
            int limit = lines1.Length;
            int i = 0;
            while (i < limit)
            {
                Preg.Add(lines1[i], lines2[i]);
                ++i;
            }
            this.Visible = false;
            Form3 q = new Form3(Preg, limit);
            q.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
