using System.Drawing.Text;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using static preguntes_anglès.Program;

namespace preguntes_anglès
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string limit;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (textBox1.Text != "")
                {
                    limit = textBox1.Text;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("You should write a number");

            }
        }

        private void byhand_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 f = new Form2(limit);
            f.ShowDialog();
        }
        private void document_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 s = new Form4();
            s.ShowDialog();

        }
    }
}
