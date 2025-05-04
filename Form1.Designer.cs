namespace C_Dersleri
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            button5 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            richTextBox1 = new RichTextBox();
            label7 = new Label();
            label8 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 72);
            label1.Name = "label1";
            label1.Size = new Size(83, 24);
            label1.TabIndex = 0;
            label1.Text = "Soru No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 96);
            label2.Name = "label2";
            label2.Size = new Size(71, 24);
            label2.TabIndex = 1;
            label2.Text = "Doğru: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 120);
            label3.Name = "label3";
            label3.Size = new Size(69, 24);
            label3.TabIndex = 2;
            label3.Text = "Yanlış: ";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(515, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(293, 283);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sonuç Ekranı";
            // 
            // button5
            // 
            button5.Location = new Point(49, 173);
            button5.Name = "button5";
            button5.Size = new Size(187, 54);
            button5.TabIndex = 8;
            button5.Text = "Devam Et";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(138, 120);
            label6.Name = "label6";
            label6.Size = new Size(20, 24);
            label6.TabIndex = 5;
            label6.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(138, 96);
            label5.Name = "label5";
            label5.Size = new Size(20, 24);
            label5.TabIndex = 5;
            label5.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(138, 72);
            label4.Name = "label4";
            label4.Size = new Size(20, 24);
            label4.TabIndex = 4;
            label4.Text = "0";
            // 
            // button1
            // 
            button1.Location = new Point(12, 300);
            button1.Name = "button1";
            button1.Size = new Size(241, 66);
            button1.TabIndex = 4;
            button1.Text = "A";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(259, 300);
            button2.Name = "button2";
            button2.Size = new Size(241, 65);
            button2.TabIndex = 5;
            button2.Text = "B";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 370);
            button3.Name = "button3";
            button3.Size = new Size(241, 66);
            button3.TabIndex = 6;
            button3.Text = "C";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(259, 370);
            button4.Name = "button4";
            button4.Size = new Size(241, 63);
            button4.TabIndex = 7;
            button4.Text = "D";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(522, 308);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(683, 308);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 124);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(2, -2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(498, 296);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(917, 126);
            label7.Name = "label7";
            label7.Size = new Size(60, 24);
            label7.TabIndex = 11;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(917, 173);
            label8.Name = "label8";
            label8.Size = new Size(61, 24);
            label8.TabIndex = 12;
            label8.Text = "label8";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(820, 448);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Soru Yarışması";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button button1;
        private Button button5;
        private Button button2;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private RichTextBox richTextBox1;
        private Label label7;
        private Label label8;
    }
}
