namespace C_Dersleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int soruNo = 0, dogru = 0, yanlis = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruNo += 1;
            label4.Text = soruNo.ToString();

            if (soruNo == 1)
            {
                richTextBox1.Text = "Cumhuriyet ka� y�l�nda ilan edilmi�tir? ";
                button1.Text = "1920";
                button2.Text = "1921";
                button3.Text = "1922";
                button4.Text = "1923";

                label8.Text = "1923";
            }
            else if (soruNo == 2)
            {
                richTextBox1.Text = "Hangi il Ege b�lgemizde bulunmaz? ";
                button1.Text = "�zmir";
                button2.Text = "Bal�kesir";
                button3.Text = "Ayd�n";
                button4.Text = "Manisa";

                label8.Text = "Bal�kesir";
            }
            else if (soruNo == 3)
            {
                richTextBox1.Text = "Son Ku�lar hangi yazar�m�za aittir? ";
                button1.Text = "Sait Faik";
                button2.Text = "Cemal S�reyya";
                button3.Text = "Atilla �lhan";
                button4.Text = "Re�at Nuri";

                label8.Text = "Sait Faik";
                button5.Text = "Sonu�lar";
            }
            else if (soruNo == 4)
            {
                soruNo -= 1;
                label4.Text = soruNo.ToString();
                MessageBox.Show("Do�ru Say�s�: " + dogru + "\n" + "Yanl�� Say�s�: " + yanlis);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            label7.Text = button1.Text;

            if (label7.Text == label8.Text)
            {
                dogru += 1;
                label5.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlis += 1;
                label6.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            label7.Text = button2.Text;

            if (label7.Text == label8.Text)
            {
                dogru += 1;
                label5.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlis += 1;
                label6.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            label7.Text = button3.Text;

            if (label7.Text == label8.Text)
            {
                dogru += 1;
                label5.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlis += 1;
                label6.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            label7.Text = button4.Text;

            if (label7.Text == label8.Text)
            {
                dogru += 1;
                label5.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlis += 1;
                label6.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }
    }

}
