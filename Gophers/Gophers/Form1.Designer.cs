namespace Gophers
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            imageList1 = new ImageList(components);
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            label1 = new Label();
            button10 = new Button();
            label2 = new Label();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            comboBox1 = new ComboBox();
            button11 = new Button();
            label4 = new Label();
            button12 = new Button();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ImageList = imageList1;
            button1.Location = new Point(78, 32);
            button1.Name = "button1";
            button1.Size = new Size(100, 100);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "OX.png");
            imageList1.Images.SetKeyName(1, "Gophers.png");
            // 
            // button2
            // 
            button2.ImageList = imageList1;
            button2.Location = new Point(214, 32);
            button2.Name = "button2";
            button2.Size = new Size(100, 100);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.ImageList = imageList1;
            button3.Location = new Point(350, 32);
            button3.Name = "button3";
            button3.Size = new Size(100, 100);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.ImageList = imageList1;
            button4.Location = new Point(78, 170);
            button4.Name = "button4";
            button4.Size = new Size(100, 100);
            button4.TabIndex = 6;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.ImageList = imageList1;
            button5.Location = new Point(214, 170);
            button5.Name = "button5";
            button5.Size = new Size(100, 100);
            button5.TabIndex = 5;
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.ImageList = imageList1;
            button6.Location = new Point(350, 170);
            button6.Name = "button6";
            button6.Size = new Size(100, 100);
            button6.TabIndex = 4;
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.ImageList = imageList1;
            button7.Location = new Point(78, 301);
            button7.Name = "button7";
            button7.Size = new Size(100, 100);
            button7.TabIndex = 9;
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.ImageList = imageList1;
            button8.Location = new Point(214, 301);
            button8.Name = "button8";
            button8.Size = new Size(100, 100);
            button8.TabIndex = 8;
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.ImageList = imageList1;
            button9.Location = new Point(350, 301);
            button9.Name = "button9";
            button9.Size = new Size(100, 100);
            button9.TabIndex = 7;
            button9.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(78, 453);
            label1.Name = "label1";
            label1.Size = new Size(67, 30);
            label1.TabIndex = 10;
            label1.Text = "剩餘:";
            // 
            // button10
            // 
            button10.Location = new Point(456, 170);
            button10.Name = "button10";
            button10.Size = new Size(131, 43);
            button10.TabIndex = 11;
            button10.Text = "開始遊戲";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(459, 301);
            label2.Name = "label2";
            label2.Size = new Size(73, 30);
            label2.TabIndex = 12;
            label2.Text = "擊中 :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(459, 364);
            label3.Name = "label3";
            label3.Size = new Size(73, 30);
            label3.TabIndex = 13;
            label3.Text = "失誤 :";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "初階", "中階", "高階" });
            comboBox1.Location = new Point(558, 78);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(137, 23);
            comboBox1.TabIndex = 15;
            // 
            // button11
            // 
            button11.Location = new Point(620, 570);
            button11.Name = "button11";
            button11.Size = new Size(75, 23);
            button11.TabIndex = 14;
            button11.Text = "button11";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(456, 75);
            label4.Name = "label4";
            label4.Size = new Size(96, 26);
            label4.TabIndex = 16;
            label4.Text = "選擇難度";
            // 
            // button12
            // 
            button12.Location = new Point(456, 240);
            button12.Name = "button12";
            button12.Size = new Size(131, 43);
            button12.TabIndex = 17;
            button12.Text = "重新開始";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(100, 570);
            label5.Name = "label5";
            label5.Size = new Size(109, 41);
            label5.TabIndex = 18;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(457, 138);
            label6.Name = "label6";
            label6.Size = new Size(96, 26);
            label6.TabIndex = 19;
            label6.Text = "自訂秒數";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(547, 141);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 21;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(642, 138);
            label7.Name = "label7";
            label7.Size = new Size(138, 26);
            label7.TabIndex = 22;
            label7.Text = "毫秒出現一隻";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 618);
            Controls.Add(label7);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button12);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(button11);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button10);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label1;
        private Button button10;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private ImageList imageList1;
        private ComboBox comboBox1;
        private Button button11;
        private Label label4;
        private Button button12;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private Label label7;
    }
}