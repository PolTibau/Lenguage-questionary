namespace preguntes_anglès
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(506, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 38);
            this.button2.TabIndex = 0;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(285, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(199, 31);
            this.textBox2.TabIndex = 1;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(624, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Write in this textbox the traduction of each word that appears, then click \"OK\"";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "...";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.Location = new System.Drawing.Point(513, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 37);
            this.button3.TabIndex = 5;
            this.button3.Text = "Repeat Exam";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(681, 347);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Name = "Form3";
            this.Text = "Exam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private Button button2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button3;
    }
}