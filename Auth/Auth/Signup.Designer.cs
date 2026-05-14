namespace Auth
{
    partial class Signup
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            confirmpassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            login = new Button();
            reset = new Button();
            username = new TextBox();
            mail = new TextBox();
            label10 = new Label();
            password = new TextBox();
            label1 = new Label();
            gander = new ComboBox();
            linkLabel1 = new LinkLabel();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            errorProvider4 = new ErrorProvider(components);
            errorProvider5 = new ErrorProvider(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.46785F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.53215F));
            tableLayoutPanel1.Controls.Add(confirmpassword, 1, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(label6, 0, 4);
            tableLayoutPanel1.Controls.Add(login, 0, 5);
            tableLayoutPanel1.Controls.Add(reset, 1, 5);
            tableLayoutPanel1.Controls.Add(username, 1, 0);
            tableLayoutPanel1.Controls.Add(mail, 1, 1);
            tableLayoutPanel1.Controls.Add(label10, 1, 4);
            tableLayoutPanel1.Controls.Add(password, 1, 2);
            tableLayoutPanel1.Location = new Point(70, 69);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(370, 352);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // confirmpassword
            // 
            confirmpassword.Anchor = AnchorStyles.Left;
            confirmpassword.Location = new Point(149, 191);
            confirmpassword.Name = "confirmpassword";
            confirmpassword.Size = new Size(183, 23);
            confirmpassword.TabIndex = 10;
            confirmpassword.Leave += confirmpassword_Leave;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 18);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 2;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 76);
            label3.Name = "label3";
            label3.Size = new Size(40, 21);
            label3.TabIndex = 2;
            label3.Text = "Mail";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 134);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 2;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 192);
            label5.Name = "label5";
            label5.Size = new Size(137, 21);
            label5.TabIndex = 2;
            label5.Text = "Confirm Password";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 250);
            label6.Name = "label6";
            label6.Size = new Size(62, 21);
            label6.TabIndex = 2;
            label6.Text = "Gander";
            // 
            // login
            // 
            login.Anchor = AnchorStyles.None;
            login.Location = new Point(35, 309);
            login.Name = "login";
            login.Size = new Size(75, 23);
            login.TabIndex = 6;
            login.Text = "Register";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // reset
            // 
            reset.Anchor = AnchorStyles.None;
            reset.Location = new Point(220, 309);
            reset.Name = "reset";
            reset.Size = new Size(75, 23);
            reset.TabIndex = 7;
            reset.Text = "Reset\r\n";
            reset.UseVisualStyleBackColor = true;
            // 
            // username
            // 
            username.Anchor = AnchorStyles.Left;
            username.Location = new Point(149, 17);
            username.Name = "username";
            username.Size = new Size(183, 23);
            username.TabIndex = 8;
            username.Leave += username_Leave;
            // 
            // mail
            // 
            mail.Anchor = AnchorStyles.Left;
            mail.Location = new Point(149, 75);
            mail.Name = "mail";
            mail.Size = new Size(183, 23);
            mail.TabIndex = 9;
            mail.Leave += mail_Leave;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(149, 232);
            label10.Name = "label10";
            label10.Size = new Size(0, 30);
            label10.TabIndex = 4;
            label10.Click += label8_Click;
            // 
            // password
            // 
            password.Anchor = AnchorStyles.Left;
            password.Location = new Point(149, 133);
            password.Name = "password";
            password.Size = new Size(183, 23);
            password.TabIndex = 11;
            password.Leave += password_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 36);
            label1.Name = "label1";
            label1.Size = new Size(149, 30);
            label1.TabIndex = 1;
            label1.Text = "Register Form";
            // 
            // gander
            // 
            gander.Anchor = AnchorStyles.Bottom;
            gander.FormattingEnabled = true;
            gander.Items.AddRange(new object[] { "Male", "Female" });
            gander.Location = new Point(217, 319);
            gander.Name = "gander";
            gander.Size = new Size(185, 23);
            gander.TabIndex = 2;
            gander.Text = "Select Gander";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(225, 44);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(52, 20);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login \r\n";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            errorProvider5.ContainerControl = this;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 450);
            Controls.Add(linkLabel1);
            Controls.Add(gander);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Name = "Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signup";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label10;
        private Button login;
        private Button reset;
        private TextBox confirmpassword;
        private TextBox username;
        private TextBox mail;
        private TextBox password;
        private ComboBox gander;
        private LinkLabel linkLabel1;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider4;
        private ErrorProvider errorProvider5;
    }
}