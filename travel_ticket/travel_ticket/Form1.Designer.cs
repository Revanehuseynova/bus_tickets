namespace travel_ticket
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
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            maskedTextBox2 = new MaskedTextBox();
            label7 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            button1 = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            button2 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label8 = new Label();
            maskedTextBox4 = new MaskedTextBox();
            label9 = new Label();
            label10 = new Label();
            label12 = new Label();
            listBox1 = new ListBox();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(973, 142);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.BEU_logo;
            pictureBox2.Location = new Point(11, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(211, 108);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Vivaldi", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(312, 87);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 2;
            label2.Text = "Enjoy the journey! 🚌";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RosyBrown;
            label1.Font = new Font("Stencil", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(299, 54);
            label1.Name = "label1";
            label1.Size = new Size(184, 33);
            label1.TabIndex = 1;
            label1.Text = "BMU Travel";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(622, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(maskedTextBox2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Sitka Banner", 13.7999992F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 151);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(376, 292);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Travel Information";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 246);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 36);
            textBox1.TabIndex = 9;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(91, 198);
            maskedTextBox2.Mask = "00:00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(171, 36);
            maskedTextBox2.TabIndex = 8;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 198);
            label7.Name = "label7";
            label7.Size = new Size(66, 33);
            label7.TabIndex = 7;
            label7.Text = "Time:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(91, 150);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(171, 36);
            maskedTextBox1.TabIndex = 6;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // button1
            // 
            button1.BackColor = Color.RosyBrown;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(284, 40);
            button1.Name = "button1";
            button1.Size = new Size(76, 93);
            button1.TabIndex = 2;
            button1.Text = ">\r\n<";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Bakı", "Sumqayıt", "Yevlax", "Mingeçevir", "Naxçıvan", "Lenkeran", "Şeki", "Quba", "Xankendi", "Xaçmaz", "Fizuli" });
            comboBox2.Location = new Point(91, 92);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(171, 41);
            comboBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bakı", "Sumqayıt", "Yevlax", "Mingeçevir", "Naxçıvan", "Lenkeran", "Şeki", "Quba", "Xankendi", "Xaçmaz", "Fizuli" });
            comboBox1.Location = new Point(91, 40);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(171, 41);
            comboBox1.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 92);
            label6.Name = "label6";
            label6.Size = new Size(43, 33);
            label6.TabIndex = 3;
            label6.Text = "To:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 153);
            label5.Name = "label5";
            label5.Size = new Size(61, 33);
            label5.TabIndex = 2;
            label5.Text = "Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 246);
            label4.Name = "label4";
            label4.Size = new Size(63, 33);
            label4.TabIndex = 1;
            label4.Text = "Seat: ";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 43);
            label3.Name = "label3";
            label3.Size = new Size(68, 33);
            label3.TabIndex = 0;
            label3.Text = "From:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(maskedTextBox4);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label12);
            groupBox2.Font = new Font("Sitka Banner", 13.7999992F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(402, 151);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(345, 292);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Person Information";
            // 
            // button2
            // 
            button2.BackColor = Color.RosyBrown;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(135, 236);
            button2.Name = "button2";
            button2.Size = new Size(169, 44);
            button2.TabIndex = 13;
            button2.Text = "Buy Ticket";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(130, 131);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(171, 36);
            textBox4.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(130, 85);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(171, 36);
            textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(130, 40);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(171, 36);
            textBox2.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 179);
            label8.Name = "label8";
            label8.Size = new Size(73, 33);
            label8.TabIndex = 7;
            label8.Text = "Phone:";
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(130, 179);
            maskedTextBox4.Mask = "(994) 000-0000";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(171, 36);
            maskedTextBox4.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 85);
            label9.Name = "label9";
            label9.Size = new Size(52, 33);
            label9.TabIndex = 3;
            label9.Text = "FIN:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 132);
            label10.Name = "label10";
            label10.Size = new Size(71, 33);
            label10.TabIndex = 2;
            label10.Text = "Email:";
            label10.Click += label10_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(17, 43);
            label12.Name = "label12";
            label12.Size = new Size(107, 33);
            label12.TabIndex = 0;
            label12.Text = "Full Name:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 463);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(735, 104);
            listBox1.TabIndex = 3;
            // 
            // button3
            // 
            button3.BackColor = Color.RosyBrown;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(10, 573);
            button3.Name = "button3";
            button3.Size = new Size(235, 44);
            button3.TabIndex = 14;
            button3.Text = "Delete Ticket";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.RosyBrown;
            button4.ForeColor = Color.Black;
            button4.Location = new Point(512, 573);
            button4.Name = "button4";
            button4.Size = new Size(235, 44);
            button4.TabIndex = 15;
            button4.Text = "Exit Program";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(771, 649);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(listBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private MaskedTextBox maskedTextBox1;
        private Button button1;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox2;
        private Label label7;
        private GroupBox groupBox2;
        private Label label8;
        private MaskedTextBox maskedTextBox4;
        private Label label9;
        private Label label10;
        private Label label12;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button2;
        private ListBox listBox1;
        private Button button3;
        private Button button4;
    }
}
