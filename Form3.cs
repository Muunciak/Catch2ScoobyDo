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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            kurczak.BackColor = Color.Transparent;
            kurczak.Parent = pictureBox1;
            kudlaty.BackColor = Color.Transparent;
            kudlaty.Parent = pictureBox1;
            duch.BackColor = Color.Transparent;
            duch.Parent = pictureBox1;
            labelpunkty.BackColor = Color.Transparent;
            labelpunkty.Parent = pictureBox1;
            napispunkty.BackColor = Color.Transparent;
            napispunkty.Parent = pictureBox1;
            labelzycie.BackColor = Color.Transparent;
            labelzycie.Parent = pictureBox1;
            napiszycie.BackColor = Color.Transparent;
            napiszycie.Parent = pictureBox1;
            labelkolizja.BackColor = Color.Transparent;
            labelkolizja.Parent = pictureBox1;
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                kudlaty.ImageLocation = @"c:track";
                kudlaty.Left = kudlaty.Left + 25;
                if (kudlaty.Left > Form1.ActiveForm.Width)
                    kudlaty.Left = 0 - kudlaty.Width;
            }
            if (e.KeyCode == Keys.Left)
            {
                kudlaty.ImageLocation = @"c:track";
                kudlaty.Left = kudlaty.Left - 25;
                if (kudlaty.Left + kudlaty.Width < 0)
                    kudlaty.Left = Form1.ActiveForm.Width;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            duch.Top = duch.Top + 20;

            if (duch.Top > Form1.ActiveForm.Height)
            {
                duch.Top = -1;
                Random rnd = new Random();
                duch.Left = rnd.Next(1, Form1.ActiveForm.Width);
            }
            kurczak.Top = kurczak.Top + 20;

            if (kurczak.Top > Form1.ActiveForm.Height)
            {
                kurczak.Top = -1;
                Random rnd = new Random();
                kurczak.Left = rnd.Next(1, Form1.ActiveForm.Width);
            }
            //Interwał timera
            int punkty2 = Int32.Parse(labelpunkty.Text);
            labelpunkty2.Text = timer1.Interval.ToString();
            if (punkty2 % 25 == 0)
                timer2.Enabled = true;

        }
        //punkty i kolizja
        private void timer2_Tick(object sender, EventArgs e)
        {
            if ((kurczak.Left + kurczak.Width > kudlaty.Left)
                  && (kurczak.Left < kudlaty.Left + kudlaty.Width)
                  && (kurczak.Top > kudlaty.Top - kurczak.Height)
                  && (kurczak.Top < kudlaty.Top + kudlaty.Height))
            {
                int punkty = Int32.Parse(labelpunkty.Text);
                punkty = punkty + 1;
                labelpunkty.Text = punkty.ToString();
            }
            int życia = Int32.Parse(labelzycie.Text);

            if ((duch.Left + duch.Width > kudlaty.Left)
             && (duch.Left < kudlaty.Left + kudlaty.Width)
             && (duch.Top > kudlaty.Top - duch.Height)
             && (duch.Top < kudlaty.Top + kudlaty.Height))
            {
                labelkolizja.Text = "Kolizja";
                życia = życia - 1;
                labelzycie.Text = życia.ToString();
            }
            else
            {
                labelkolizja.Text = " ";
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if ((snacks.Left + snacks.Width > kudlaty.Left)
                && (snacks.Left < kudlaty.Left + kudlaty.Width)
                && (snacks.Top > kudlaty.Top - snacks.Height)
                && (snacks.Top < kudlaty.Top + kudlaty.Height))
            {
                int życia = Int32.Parse(labelzycie.Text);
                życia = życia + 1;
                labelzycie.Text = życia.ToString();
            }
            snacks.Top = snacks.Top + 15;



            if (snacks.Top > Form.ActiveForm.Height)
            {
                snacks.Top = -1;
                Random rnd = new Random();
                snacks.Left = rnd.Next(1, Form1.ActiveForm.Width);
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            //Blokada interwała
            timer1.Interval--;
            if (timer1.Interval == 1)
            {
                timer1.Interval = 2;
            }
            timer4.Enabled = false;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            //zycie
            if (labelzycie.Text == "0")
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                timer4.Enabled = false;
                timer5.Enabled = false;

                DialogResult Dialog = MessageBox.Show("Twój wynik: " + labelpunkty.Text + " Czy chcesz zagrać jeszcze raz?", "Przegrałeś!",
                   MessageBoxButtons.YesNo);
                if (Dialog == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
