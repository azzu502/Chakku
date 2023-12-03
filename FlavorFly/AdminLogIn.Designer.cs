namespace FlavorFly
{
    partial class AdminLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogIn));
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            UnameTF = new TextBox();
            UpassTF = new TextBox();
            LogInBtn = new Button();
            ForgotPassBtn = new Button();
            label2 = new Label();
            ReturnBtn = new Button();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.wall;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(204, 213);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.wall;
            pictureBox1.Location = new Point(0, 210);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 256);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.wall;
            pictureBox2.Location = new Point(595, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(204, 213);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.wall;
            pictureBox4.Location = new Point(595, 210);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(204, 256);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.adminn;
            pictureBox5.Location = new Point(324, 24);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(154, 131);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 18;
            pictureBox5.TabStop = false;
            // 
            // UnameTF
            // 
            UnameTF.BackColor = Color.Wheat;
            UnameTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UnameTF.Location = new Point(295, 209);
            UnameTF.Multiline = true;
            UnameTF.Name = "UnameTF";
            UnameTF.PlaceholderText = "Username";
            UnameTF.Size = new Size(206, 30);
            UnameTF.TabIndex = 19;
            // 
            // UpassTF
            // 
            UpassTF.BackColor = Color.Wheat;
            UpassTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpassTF.Location = new Point(295, 245);
            UpassTF.Multiline = true;
            UpassTF.Name = "UpassTF";
            UpassTF.PlaceholderText = "Password";
            UpassTF.Size = new Size(206, 30);
            UpassTF.TabIndex = 20;
            // 
            // LogInBtn
            // 
            LogInBtn.BackColor = Color.FromArgb(128, 128, 255);
            LogInBtn.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogInBtn.Location = new Point(295, 297);
            LogInBtn.Name = "LogInBtn";
            LogInBtn.Size = new Size(206, 31);
            LogInBtn.TabIndex = 21;
            LogInBtn.Text = "Log In";
            LogInBtn.UseVisualStyleBackColor = false;
            // 
            // ForgotPassBtn
            // 
            ForgotPassBtn.BackColor = Color.FromArgb(128, 128, 255);
            ForgotPassBtn.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForgotPassBtn.Location = new Point(330, 334);
            ForgotPassBtn.Name = "ForgotPassBtn";
            ForgotPassBtn.Size = new Size(134, 31);
            ForgotPassBtn.TabIndex = 25;
            ForgotPassBtn.Text = "Forgot Password";
            ForgotPassBtn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(330, 158);
            label2.Name = "label2";
            label2.Size = new Size(130, 26);
            label2.TabIndex = 24;
            label2.Text = "Admin LogIn";
            // 
            // ReturnBtn
            // 
            ReturnBtn.BackColor = Color.IndianRed;
            ReturnBtn.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReturnBtn.Location = new Point(706, 409);
            ReturnBtn.Name = "ReturnBtn";
            ReturnBtn.Size = new Size(82, 29);
            ReturnBtn.TabIndex = 26;
            ReturnBtn.Text = "Return";
            ReturnBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.FFfrontpage;
            pictureBox6.Location = new Point(12, 12);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(125, 86);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 27;
            pictureBox6.TabStop = false;
            // 
            // AdminLogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 467);
            Controls.Add(pictureBox6);
            Controls.Add(ReturnBtn);
            Controls.Add(ForgotPassBtn);
            Controls.Add(label2);
            Controls.Add(LogInBtn);
            Controls.Add(UpassTF);
            Controls.Add(UnameTF);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminLogIn";
            Text = "AdminLogIn";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private TextBox UnameTF;
        private TextBox UpassTF;
        private Button LogInBtn;
        private Button ForgotPassBtn;
        private Label label2;
        private Button ReturnBtn;
        private PictureBox pictureBox6;
    }
}