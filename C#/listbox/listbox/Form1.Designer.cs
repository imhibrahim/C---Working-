namespace listbox
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
            fruitlist = new ListBox();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // fruitlist
            // 
            fruitlist.BackColor = SystemColors.InactiveCaption;
            fruitlist.Font = new Font("MS UI Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fruitlist.FormattingEnabled = true;
            fruitlist.Items.AddRange(new object[] { "mango", "Banana", "Orange" });
            fruitlist.Location = new Point(7, 14);
            fruitlist.Name = "fruitlist";
            fruitlist.Size = new Size(156, 384);
            fruitlist.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(459, 90);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(251, 46);
            label1.Name = "label1";
            label1.Size = new Size(96, 30);
            label1.TabIndex = 2;
            label1.Text = "Enter Fruit Name\r\n\r\n";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(364, 40);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(255, 31);
            textBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(364, 132);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Count all\r\n";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(459, 132);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "Sorting";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(544, 132);
            button4.Name = "button4";
            button4.Size = new Size(94, 23);
            button4.TabIndex = 6;
            button4.Text = "Remove Item";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(459, 184);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 7;
            button5.Text = "Clear All";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(fruitlist);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox fruitlist;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
