namespace form1
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
            label1 = new Label();
            num1 = new TextBox();
            submit = new Button();
            ans = new Label();
            num2 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(98, 74);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 0;
            label1.Text = "Number 1";
            label1.Click += label1_Click;
            // 
            // num1
            // 
            num1.BorderStyle = BorderStyle.FixedSingle;
            num1.Location = new Point(223, 71);
            num1.Multiline = true;
            num1.Name = "num1";
            num1.Size = new Size(226, 28);
            num1.TabIndex = 1;
            // 
            // submit
            // 
            submit.Font = new Font("Script MT Bold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submit.ForeColor = SystemColors.ActiveCaptionText;
            submit.Location = new Point(98, 207);
            submit.Name = "submit";
            submit.Size = new Size(96, 34);
            submit.TabIndex = 2;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = true;
            submit.Click += button1_Click;
            // 
            // ans
            // 
            ans.AutoSize = true;
            ans.Font = new Font("Kristen ITC", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ans.Location = new Point(275, 270);
            ans.Name = "ans";
            ans.Size = new Size(86, 33);
            ans.TabIndex = 3;
            ans.Text = "label2";
            ans.TextAlign = ContentAlignment.MiddleCenter;
            ans.Visible = false;
            // 
            // num2
            // 
            num2.BorderStyle = BorderStyle.FixedSingle;
            num2.Location = new Point(223, 124);
            num2.Multiline = true;
            num2.Name = "num2";
            num2.Size = new Size(226, 28);
            num2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MV Boli", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(98, 127);
            label3.Name = "label3";
            label3.Size = new Size(111, 25);
            label3.TabIndex = 6;
            label3.Text = "Number 2";
            // 
            // button1
            // 
            button1.Font = new Font("Script MT Bold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(211, 207);
            button1.Name = "button1";
            button1.Size = new Size(96, 34);
            button1.TabIndex = 7;
            button1.Text = "Subtraction";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Font = new Font("Script MT Bold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(323, 207);
            button2.Name = "button2";
            button2.Size = new Size(96, 34);
            button2.TabIndex = 8;
            button2.Text = "Multiply";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Script MT Bold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(425, 207);
            button3.Name = "button3";
            button3.Size = new Size(96, 34);
            button3.TabIndex = 9;
            button3.Text = "Divid";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(619, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(num2);
            Controls.Add(ans);
            Controls.Add(submit);
            Controls.Add(num1);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My New Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox num1;
        private Button submit;
        private Label ans;
        private TextBox num2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
