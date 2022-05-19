using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Przycisk 1
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Regulamin : Zbieraj scooby chrupki i omijaj ducha! Życie otrzymujesz co 10 zdobytych punktów");
                               
            Form2 frm2 = new Form2();
            frm2.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
            frm2.Show();
            this.Hide();
        }


        //Przycisk 2
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Regulamin : Zbieraj pieczonego kurczaka i omijaj ducha! Dodatkowe życie dostajesz gdy zjesz scooby chrupki");
            Form3 frm3 = new Form3();
            frm3.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
            frm3.Show();
            this.Hide();
        }

        private void frm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            scooby.BackColor = Color.Transparent;
            scooby.Parent = pictureBox1;
            kudlaty.BackColor = Color.Transparent;
            kudlaty.Parent = pictureBox1;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Regulamin : Zbieraj pieczonego kurczaka i omijaj ducha! Uwaga jak zlapiesz scooby chrupki przywroci Ci zycie");
            Form3 frm3 = new Form3();
            frm3.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
            frm3.Show();
            this.Hide();
        }
    }
}
