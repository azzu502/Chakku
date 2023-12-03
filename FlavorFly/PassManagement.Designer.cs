namespace FlavorFly
{
    partial class PassManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassManagement));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ResetPassBtn = new Button();
            ResetPassTF = new TextBox();
            ResetPassLbl = new Label();
            EnterUserNameBtn = new Button();
            label1 = new Label();
            ForgotPassTF = new TextBox();
            label2 = new Label();
            ReturnBtn = new Button();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.wall;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(799, 449);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(ResetPassBtn);
            panel1.Controls.Add(ResetPassTF);
            panel1.Controls.Add(ResetPassLbl);
            panel1.Controls.Add(EnterUserNameBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ForgotPassTF);
            panel1.Location = new Point(174, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(466, 304);
            panel1.TabIndex = 1;
            // 
            // ResetPassBtn
            // 
            ResetPassBtn.BackColor = Color.FromArgb(128, 128, 255);
            ResetPassBtn.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResetPassBtn.Location = new Point(302, 232);
            ResetPassBtn.Name = "ResetPassBtn";
            ResetPassBtn.Size = new Size(93, 31);
            ResetPassBtn.TabIndex = 17;
            ResetPassBtn.Text = "Enter";
            ResetPassBtn.UseVisualStyleBackColor = false;
            // 
            // ResetPassTF
            // 
            ResetPassTF.BackColor = Color.Wheat;
            ResetPassTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResetPassTF.Location = new Point(80, 232);
            ResetPassTF.Multiline = true;
            ResetPassTF.Name = "ResetPassTF";
            ResetPassTF.PlaceholderText = "New Password";
            ResetPassTF.Size = new Size(206, 30);
            ResetPassTF.TabIndex = 16;
            // 
            // ResetPassLbl
            // 
            ResetPassLbl.AutoSize = true;
            ResetPassLbl.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResetPassLbl.Location = new Point(80, 200);
            ResetPassLbl.Name = "ResetPassLbl";
            ResetPassLbl.Size = new Size(199, 20);
            ResetPassLbl.TabIndex = 15;
            ResetPassLbl.Text = "Enter your New Password";
            // 
            // EnterUserNameBtn
            // 
            EnterUserNameBtn.BackColor = Color.FromArgb(128, 128, 255);
            EnterUserNameBtn.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EnterUserNameBtn.Location = new Point(302, 126);
            EnterUserNameBtn.Name = "EnterUserNameBtn";
            EnterUserNameBtn.Size = new Size(93, 31);
            EnterUserNameBtn.TabIndex = 14;
            EnterUserNameBtn.Text = "Enter";
            EnterUserNameBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(80, 91);
            label1.Name = "label1";
            label1.Size = new Size(165, 20);
            label1.TabIndex = 13;
            label1.Text = "Enter your Username";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ForgotPassTF
            // 
            ForgotPassTF.BackColor = Color.Wheat;
            ForgotPassTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForgotPassTF.Location = new Point(80, 127);
            ForgotPassTF.Multiline = true;
            ForgotPassTF.Name = "ForgotPassTF";
            ForgotPassTF.PlaceholderText = "Username";
            ForgotPassTF.Size = new Size(206, 30);
            ForgotPassTF.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(114, 28);
            label2.Name = "label2";
            label2.Size = new Size(233, 32);
            label2.TabIndex = 18;
            label2.Text = "Password Recovery";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ReturnBtn
            // 
            ReturnBtn.BackColor = Color.IndianRed;
            ReturnBtn.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReturnBtn.Location = new Point(691, 396);
            ReturnBtn.Name = "ReturnBtn";
            ReturnBtn.Size = new Size(82, 29);
            ReturnBtn.TabIndex = 19;
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
            // PassManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox6);
            Controls.Add(ReturnBtn);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PassManagement";
            Text = "PassManagement";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button ResetPassBtn;
        private TextBox ResetPassTF;
        private Label ResetPassLbl;
        private Button EnterUserNameBtn;
        private Label label1;
        private TextBox ForgotPassTF;
        private Label label2;
        private Button ReturnBtn;
        private PictureBox pictureBox6;
    }
}