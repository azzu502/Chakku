namespace FlavorFly
{
    partial class UserLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogIn));
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox5 = new PictureBox();
            ForgotPassBtn = new Button();
            label2 = new Label();
            GoToUserCreationBtn = new Button();
            label1 = new Label();
            LogInBtn = new Button();
            UpassTF = new TextBox();
            UnameTF = new TextBox();
            ReturnBtn = new Button();
            pictureBox6 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.wall;
            pictureBox3.Location = new Point(1, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(204, 213);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.wall;
            pictureBox2.Location = new Point(595, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(204, 213);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.User;
            pictureBox5.Location = new Point(315, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(154, 131);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // ForgotPassBtn
            // 
            ForgotPassBtn.BackColor = Color.FromArgb(128, 128, 255);
            ForgotPassBtn.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForgotPassBtn.Location = new Point(337, 322);
            ForgotPassBtn.Name = "ForgotPassBtn";
            ForgotPassBtn.Size = new Size(134, 31);
            ForgotPassBtn.TabIndex = 17;
            ForgotPassBtn.Text = "Forgot Password";
            ForgotPassBtn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(337, 146);
            label2.Name = "label2";
            label2.Size = new Size(112, 26);
            label2.TabIndex = 16;
            label2.Text = "User LogIn";
            label2.Click += label2_Click;
            // 
            // GoToUserCreationBtn
            // 
            GoToUserCreationBtn.BackColor = Color.FromArgb(128, 128, 255);
            GoToUserCreationBtn.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GoToUserCreationBtn.Location = new Point(478, 384);
            GoToUserCreationBtn.Name = "GoToUserCreationBtn";
            GoToUserCreationBtn.Size = new Size(94, 31);
            GoToUserCreationBtn.TabIndex = 15;
            GoToUserCreationBtn.Text = "Sign Up";
            GoToUserCreationBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(211, 390);
            label1.Name = "label1";
            label1.Size = new Size(267, 17);
            label1.TabIndex = 14;
            label1.Text = "Become one of our members to get a treat !";
            // 
            // LogInBtn
            // 
            LogInBtn.BackColor = Color.FromArgb(128, 128, 255);
            LogInBtn.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogInBtn.Location = new Point(296, 285);
            LogInBtn.Name = "LogInBtn";
            LogInBtn.Size = new Size(206, 31);
            LogInBtn.TabIndex = 13;
            LogInBtn.Text = "Log In";
            LogInBtn.UseVisualStyleBackColor = false;
            LogInBtn.Click += LogInBtn_Click;
            // 
            // UpassTF
            // 
            UpassTF.BackColor = Color.Wheat;
            UpassTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpassTF.Location = new Point(296, 233);
            UpassTF.Multiline = true;
            UpassTF.Name = "UpassTF";
            UpassTF.PlaceholderText = "Password";
            UpassTF.Size = new Size(206, 30);
            UpassTF.TabIndex = 12;
            UpassTF.TextChanged += UpassTF_TextChanged;
            // 
            // UnameTF
            // 
            UnameTF.BackColor = Color.Wheat;
            UnameTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UnameTF.Location = new Point(296, 197);
            UnameTF.Multiline = true;
            UnameTF.Name = "UnameTF";
            UnameTF.PlaceholderText = "Username";
            UnameTF.Size = new Size(206, 30);
            UnameTF.TabIndex = 11;
            UnameTF.TextChanged += UnameTF_TextChanged;
            // 
            // ReturnBtn
            // 
            ReturnBtn.BackColor = Color.IndianRed;
            ReturnBtn.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReturnBtn.Location = new Point(706, 409);
            ReturnBtn.Name = "ReturnBtn";
            ReturnBtn.Size = new Size(82, 29);
            ReturnBtn.TabIndex = 18;
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
            pictureBox6.TabIndex = 28;
            pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.wall;
            pictureBox1.Location = new Point(1, 210);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 240);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.wall;
            pictureBox4.Location = new Point(595, 210);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(204, 240);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // UserLogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox6);
            Controls.Add(ReturnBtn);
            Controls.Add(ForgotPassBtn);
            Controls.Add(label2);
            Controls.Add(GoToUserCreationBtn);
            Controls.Add(label1);
            Controls.Add(LogInBtn);
            Controls.Add(UpassTF);
            Controls.Add(UnameTF);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserLogIn";
            Text = "UserLogIn";
            Load += UserLogIn_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private Button ForgotPassBtn;
        private Label label2;
        private Button GoToUserCreationBtn;
        private Label label1;
        private Button LogInBtn;
        private TextBox UpassTF;
        private TextBox UnameTF;
        private Button ReturnBtn;
        private PictureBox pictureBox6;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
    }
}