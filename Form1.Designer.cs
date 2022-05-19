namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.scooby = new System.Windows.Forms.PictureBox();
            this.kudlaty = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.scooby)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kudlaty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // scooby
            // 
            this.scooby.Image = ((System.Drawing.Image)(resources.GetObject("scooby.Image")));
            this.scooby.Location = new System.Drawing.Point(92, 12);
            this.scooby.Name = "scooby";
            this.scooby.Size = new System.Drawing.Size(246, 406);
            this.scooby.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scooby.TabIndex = 0;
            this.scooby.TabStop = false;
            // 
            // kudlaty
            // 
            this.kudlaty.Image = ((System.Drawing.Image)(resources.GetObject("kudlaty.Image")));
            this.kudlaty.Location = new System.Drawing.Point(483, 12);
            this.kudlaty.Name = "kudlaty";
            this.kudlaty.Size = new System.Drawing.Size(214, 406);
            this.kudlaty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kudlaty.TabIndex = 1;
            this.kudlaty.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(92, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "SCOOBY DOO!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(483, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "Kudłaty!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(752, 457);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 481);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kudlaty);
            this.Controls.Add(this.scooby);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scooby)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kudlaty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox scooby;
        private System.Windows.Forms.PictureBox kudlaty;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

