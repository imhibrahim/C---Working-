namespace Auth
{
    partial class loginform
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
            label1 = new Label();
            signin = new GroupBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            signin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(218, 22);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 0;
            label1.Text = "Login form";
            // 
            // signin
            // 
            signin.Controls.Add(linkLabel1);
            signin.Controls.Add(button1);
            signin.Controls.Add(checkBox1);
            signin.Controls.Add(textBox2);
            signin.Controls.Add(textBox1);
            signin.Controls.Add(label3);
            signin.Controls.Add(label2);
            signin.Location = new Point(262, 77);
            signin.Name = "signin";
            signin.Size = new Size(304, 282);
            signin.TabIndex = 1;
            signin.TabStop = false;
            signin.Text = "Signin";
            // 
            // button1
            // 
            button1.Location = new Point(124, 159);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(91, 115);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(90, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(179, 23);
            textBox2.TabIndex = 3;
            textBox2.UseSystemPasswordChar = true;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(90, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 23);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 84);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 1;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 38);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 0;
            label2.Text = "Username";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.images_removebg_preview__1_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 242);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = SystemColors.ActiveCaptionText;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(124, 198);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(170, 28);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Go To SignUp Form";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // loginform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 354);
            Controls.Add(pictureBox1);
            Controls.Add(signin);
            Controls.Add(label1);
            Name = "loginform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "loginform";
            signin.ResumeLayout(false);
            signin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox signin;
        private Button button1;
        private CheckBox checkBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
    }
}
