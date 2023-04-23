using System;

namespace Gophers
{
    public partial class Form1 : Form
    {
        public double sec = 0;
        public int win_count = 0;
        public int loss_count = 0;
        public int r = -1;
        public Boolean s = false;//�ҥΦ۩w�q�Ҧ�
        public Boolean gop = false;//���a��->true ->�S��false
        Button[] buttons = new Button[9];
        public Form1()
        {
            InitializeComponent();
            sec = 0;
            buttons[0] = button1;
            buttons[1] = button2;
            buttons[2] = button3;
            buttons[3] = button4;
            buttons[4] = button5;
            buttons[5] = button6;
            buttons[6] = button7;
            buttons[7] = button8;
            buttons[8] = button9;
            buttons[0].ImageIndex = 0;
            for (int i = 1; i < 9; i++)
            {
                buttons[i].ImageIndex = 0;
                buttons[i].Click += button1_Click;
            }
            AllButtonsEbdf();
        }
        public void main()
        {
            AllButtonsEbdt();
            timer1.Enabled = true;
            //MessageBox.Show("s:" + s);
            if (s)
            {
                timer2.Interval = int.Parse(textBox1.Text); ;
                label5.Text = timer2.Interval + "";
            }
            else
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        timer2.Interval = 1000;
                        break;
                    case 1:
                        timer2.Interval = 500;
                        break;
                    case 2:
                        timer2.Interval = 250;
                        break;
                }
            }
            timer2.Enabled = true;
            sec = 30;

        }
        public void AllButtonsEbdt()
        {
            foreach (Button button in buttons)
            {
                button.Enabled = true;
            }
        }
        public void AllButtonsEbdf()
        {
            foreach (Button button in buttons)
            {
                button.Enabled = false;
            }
        }
        public void R()
        {
            Random random = new Random();
            r = random.Next(0, buttons.Length);
            buttons[r].ImageIndex = 1;
            gop = true;//�l��X�Ӧa��
        }
        public void reset()
        {
            sec = 30;
            win_count = 0;
            loss_count = 0;
            timer1.Enabled = false;
            timer2.Enabled = false;
            label2.Text = "���� : " + win_count;
            label3.Text = "���~ : " + loss_count;
            for (int i = 0; i < 9; i++)
            {
                buttons[i].ImageIndex = 0;
            }
            AllButtonsEbdf();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int buttonNumber = int.Parse(clickedButton.Name.Replace("button", "")) - 1;
            if (buttonNumber == r)//�I�諸��
            {
                buttons[buttonNumber].ImageIndex = 0;
                win_count++;
            }
            else
            {
                buttons[r].ImageIndex = 0;
                loss_count++;
            }
            gop = false;//�a���Q�~�]�F
            label2.Text = "���� : " + win_count;
            label3.Text = "���~ : " + loss_count;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            foreach (Button button in buttons)
            {
                button.ImageIndex = 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "�Ѿl�ɶ� : " + (sec -= 0.1).ToString("#.0") + " ��";

            if (sec <= 0)
            {
                label1.Text = "�Ѿl�ɶ� : " + "0��";
                timer1.Enabled = false;
                timer2.Enabled = false;
                AllButtonsEbdf();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (gop)//���a��
            {
                buttons[r].ImageIndex = 0;//�a�ݶ]��
                R();//�l��a��
            }
            else
            {
                R();//�l��a��
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("��@�U���צѥS");
                }
                else
                {
                    main();
                }
            }
            else
            {
                s = true;
                main();
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}