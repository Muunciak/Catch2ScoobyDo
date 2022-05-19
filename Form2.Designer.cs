namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.scooby = new System.Windows.Forms.PictureBox();
            this.duch = new System.Windows.Forms.PictureBox();
            this.snacks = new System.Windows.Forms.PictureBox();
            this.napispunkty = new System.Windows.Forms.PictureBox();
            this.labelpunkty = new System.Windows.Forms.Label();
            this.napiszycie = new System.Windows.Forms.PictureBox();
            this.labelzycie = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.labelkolizja = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.labelpunkty2 = new System.Windows.Forms.Label();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scooby)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snacks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.napispunkty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.napiszycie)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(991, 488);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // scooby
            // 
            this.scooby.Image = ((System.Drawing.Image)(resources.GetObject("scooby.Image")));
            this.scooby.Location = new System.Drawing.Point(457, 340);
            this.scooby.Name = "scooby";
            this.scooby.Size = new System.Drawing.Size(115, 160);
            this.scooby.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scooby.TabIndex = 1;
            this.scooby.TabStop = false;
            this.scooby.Click += new System.EventHandler(this.scooby_Click);
            // 
            // duch
            // 
            this.duch.Image = ((System.Drawing.Image)(resources.GetObject("duch.Image")));
            this.duch.Location = new System.Drawing.Point(154, 202);
            this.duch.Name = "duch";
            this.duch.Size = new System.Drawing.Size(227, 134);
            this.duch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.duch.TabIndex = 2;
            this.duch.TabStop = false;
            // 
            // snacks
            // 
            this.snacks.Image = ((System.Drawing.Image)(resources.GetObject("snacks.Image")));
            this.snacks.Location = new System.Drawing.Point(671, 202);
            this.snacks.Name = "snacks";
            this.snacks.Size = new System.Drawing.Size(59, 82);
            this.snacks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.snacks.TabIndex = 3;
            this.snacks.TabStop = false;
            // 
            // napispunkty
            // 
            this.napispunkty.Image = ((System.Drawing.Image)(resources.GetObject("napispunkty.Image")));
            this.napispunkty.Location = new System.Drawing.Point(12, 12);
            this.napispunkty.Name = "napispunkty";
            this.napispunkty.Size = new System.Drawing.Size(159, 68);
            this.napispunkty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.napispunkty.TabIndex = 4;
            this.napispunkty.TabStop = false;
            // 
            // labelpunkty
            // 
            this.labelpunkty.AutoSize = true;
            this.labelpunkty.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelpunkty.ForeColor = System.Drawing.Color.Maroon;
            this.labelpunkty.Location = new System.Drawing.Point(173, 12);
            this.labelpunkty.Name = "labelpunkty";
            this.labelpunkty.Size = new System.Drawing.Size(77, 90);
            this.labelpunkty.TabIndex = 5;
            this.labelpunkty.Text = "0";
            // 
            // napiszycie
            // 
            this.napiszycie.Image = ((System.Drawing.Image)(resources.GetObject("napiszycie.Image")));
            this.napiszycie.Location = new System.Drawing.Point(12, 86);
            this.napiszycie.Name = "napiszycie";
            this.napiszycie.Size = new System.Drawing.Size(159, 83);
            this.napiszycie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.napiszycie.TabIndex = 6;
            this.napiszycie.TabStop = false;
            // 
            // labelzycie
            // 
            this.labelzycie.AutoSize = true;
            this.labelzycie.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelzycie.ForeColor = System.Drawing.Color.Maroon;
            this.labelzycie.Location = new System.Drawing.Point(173, 86);
            this.labelzycie.Name = "labelzycie";
            this.labelzycie.Size = new System.Drawing.Size(77, 90);
            this.labelzycie.TabIndex = 7;
            this.labelzycie.Text = "3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // labelkolizja
            // 
            this.labelkolizja.AutoSize = true;
            this.labelkolizja.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelkolizja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelkolizja.Location = new System.Drawing.Point(434, 24);
            this.labelkolizja.Name = "labelkolizja";
            this.labelkolizja.Size = new System.Drawing.Size(0, 135);
            this.labelkolizja.TabIndex = 8;
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // labelpunkty2
            // 
            this.labelpunkty2.AutoSize = true;
            this.labelpunkty2.Location = new System.Drawing.Point(454, 12);
            this.labelpunkty2.Name = "labelpunkty2";
            this.labelpunkty2.Size = new System.Drawing.Size(35, 13);
            this.labelpunkty2.TabIndex = 9;
            this.labelpunkty2.Text = "label1";
            this.labelpunkty2.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Interval = 1000;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 512);
            this.Controls.Add(this.labelpunkty2);
            this.Controls.Add(this.labelkolizja);
            this.Controls.Add(this.labelzycie);
            this.Controls.Add(this.napiszycie);
            this.Controls.Add(this.labelpunkty);
            this.Controls.Add(this.napispunkty);
            this.Controls.Add(this.snacks);
            this.Controls.Add(this.duch);
            this.Controls.Add(this.scooby);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scooby)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snacks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.napispunkty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.napiszycie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox scooby;
        private System.Windows.Forms.PictureBox duch;
        private System.Windows.Forms.PictureBox snacks;
        private System.Windows.Forms.PictureBox napispunkty;
        private System.Windows.Forms.Label labelpunkty;
        private System.Windows.Forms.PictureBox napiszycie;
        private System.Windows.Forms.Label labelzycie;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label labelkolizja;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label labelpunkty2;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
    }
}