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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            scooby.BackColor = Color.Transparent;
            scooby.Parent = pictureBox1;
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

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                scooby.ImageLocation = @"c:track";
                scooby.Left = scooby.Left + 25;
                if (scooby.Left > Form1.ActiveForm.Width)
                    scooby.Left = 0 - scooby.Width;
            }
            if (e.KeyCode == Keys.Left)
            {
                scooby.ImageLocation = @"c:track";
                scooby.Left = scooby.Left - 25;
                if (scooby.Left + scooby.Width < 0)
                    scooby.Left = Form1.ActiveForm.Width;

            }
        }
        //drop ducha
        private void timer1_Tick(object sender, EventArgs e)
        {
            snacks.Top = snacks.Top +10;



            if (snacks.Top > Form.ActiveForm.Height)
            {
                snacks.Top = -1;
                Random rnd = new Random();
                snacks.Left = rnd.Next(1, Form1.ActiveForm.Width);
            }

            duch.Top = duch.Top + 20;

            if (duch.Top > Form1.ActiveForm.Height)
            {
                duch.Top = -1;
                Random rnd = new Random();
                duch.Left = rnd.Next(1, Form1.ActiveForm.Width);
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
            if ((snacks.Left + snacks.Width > scooby.Left)
                  && (snacks.Left < scooby.Left + scooby.Width)
                  && (snacks.Top > scooby.Top - snacks.Height)
                  && (snacks.Top < scooby.Top + scooby.Height))
            {
                int punkty = Int32.Parse(labelpunkty.Text);
                punkty = punkty + 1;
                labelpunkty.Text = punkty.ToString();
            }
            if (labelpunkty.Text == "10")
            {
                int życia = Int32.Parse(labelzycie.Text);
                życia = życia + 1;
                labelzycie.Text = życia.ToString();
            }

            if ((duch.Left + duch.Width > scooby.Left)
             && (duch.Left < scooby.Left + scooby.Width)
             && (duch.Top > scooby.Top - duch.Height)
             && (duch.Top < scooby.Top + scooby.Height))
            {
                int życia = Int32.Parse(labelzycie.Text);
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
            //zycie
            if (labelzycie.Text == "0")
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
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

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void scooby_Click(object sender, EventArgs e)
        {

        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            int punkty = Int32.Parse(labelpunkty.Text);
            if (punkty % 10 == 0)
            {
                int życia = Int32.Parse(labelzycie.Text);
                życia = życia + 1;
                labelzycie.Text = życia.ToString();
            }
            timer5.Enabled = true;
            timer3.Enabled = true;
        }
    }
}
