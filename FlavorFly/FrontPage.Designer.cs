namespace FlavorFly
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panel1 = new Panel();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            button3 = new Button();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.FFfrontpage;
            pictureBox1.Location = new Point(12, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(508, 383);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.BorderSize = 10;
            button1.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(768, 484);
            button1.Name = "button1";
            button1.Size = new Size(131, 38);
            button1.TabIndex = 2;
            button1.Text = "EXIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(554, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(345, 168);
            panel1.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 128, 255);
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatAppearance.BorderSize = 10;
            button2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(95, 127);
            button2.Name = "button2";
            button2.Size = new Size(152, 38);
            button2.TabIndex = 3;
            button2.Text = "USER";
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.User;
            pictureBox2.Location = new Point(95, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(152, 125);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(554, 278);
            panel2.Name = "panel2";
            panel2.Size = new Size(345, 169);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 128, 255);
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.FlatAppearance.BorderSize = 10;
            button3.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(95, 131);
            button3.Name = "button3";
            button3.Size = new Size(152, 38);
            button3.TabIndex = 4;
            button3.Text = "ADMIN";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.adminn;
            pictureBox3.Location = new Point(95, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(152, 126);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 428);
            label1.Name = "label1";
            label1.Size = new Size(490, 32);
            label1.TabIndex = 6;
            label1.Text = "HELLO, WELCOME TO OUR OFFICIAL APP.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Emoji", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(95, 9);
            label2.Name = "label2";
            label2.Size = new Size(153, 38);
            label2.TabIndex = 7;
            label2.Text = "LOGIN AS";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(128, 128, 255);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(554, 42);
            panel3.Name = "panel3";
            panel3.Size = new Size(345, 56);
            panel3.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            BackgroundImage = Properties.Resources.wall;
            ClientSize = new Size(921, 543);
            Controls.Add(panel3);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "FrontPage";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Panel panel3;
    }
}
