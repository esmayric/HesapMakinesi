namespace Calculator
{
    public partial class Form1 : Form
    {
        private char _islem;
        private bool _ekranTemizleme;
        double _ilkSayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleme == true)
            {
                labelEkran.Text = "";
                _ekranTemizleme = false;
            }
            if (labelEkran.Text == "0") labelEkran.Text = "";
            labelEkran.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleme == true)
            {
                labelEkran.Text = "";
                _ekranTemizleme = false;
            }
            if (labelEkran.Text == "0") labelEkran.Text = "";
            labelEkran.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleme == true)
            {
                labelEkran.Text = "";
                _ekranTemizleme = false;
            }
            if (labelEkran.Text == "0") labelEkran.Text = "";
            labelEkran.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleme == true)
            {
                labelEkran.Text = "";
                _ekranTemizleme = false;
            }
            if (labelEkran.Text == "0") labelEkran.Text = "";
            labelEkran.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleme == true)
            {
                labelEkran.Text = "";
                _ekranTemizleme = false;
            }
            if (labelEkran.Text == "0") labelEkran.Text = "";
            labelEkran.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleme == true)
            {
                labelEkran.Text = "";
                _ekranTemizleme = false;
            }
            if (labelEkran.Text == "0") labelEkran.Text = "";
            labelEkran.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleme == true)
            {
                labelEkran.Text = "";
                _ekranTemizleme = false;
            }
            if (labelEkran.Text == "0") labelEkran.Text = "";
            labelEkran.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleme == true)
            {
                labelEkran.Text = "";
                _ekranTemizleme = false;
            }
            if (labelEkran.Text == "0") labelEkran.Text = "";
            labelEkran.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleme == true)
            {
                labelEkran.Text = "";
                _ekranTemizleme = false;
            }
            if (labelEkran.Text == "0") labelEkran.Text = "";
            labelEkran.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleme == true)
            {
                labelEkran.Text = "";
                _ekranTemizleme = false;
            }
            if (labelEkran.Text == "0") labelEkran.Text = "";
            labelEkran.Text += "0";
        }
        private void buttonVirgul_Click(object sender, EventArgs e)
        {
            if (labelEkran.Text.IndexOf(",") < 1)
            {
                labelEkran.Text = labelEkran.Text + ",";
            }
        }
        private void buttonEsittir_Click(object sender, EventArgs e)
        {
            double ikinciSayi = Convert.ToInt32(labelEkran.Text);
            double sonuc;

            switch (_islem)
            {
                case '+':
                    sonuc = _ilkSayi + ikinciSayi;
                    break;

                case '-':
                    sonuc = _ilkSayi - ikinciSayi;
                    break;

                case '*':
                    sonuc = _ilkSayi * ikinciSayi;
                    break;

                case '/':
                    sonuc = _ilkSayi / ikinciSayi;
                    break;

                default:
                    sonuc = 0;
                    break;
            }
            labelEkran.Text = Convert.ToString(sonuc);
        }

        private void buttonArti_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizleme = true;
            _ilkSayi = Convert.ToDouble(labelEkran.Text);
        }
        private void buttonEksi_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizleme = true;
            _ilkSayi = Convert.ToDouble(labelEkran.Text);
        }

        private void buttonCarpi_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTemizleme = true;
            _ilkSayi = Convert.ToDouble(labelEkran.Text);
        }

        private void buttonBolme_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizleme = true;
            _ilkSayi = Convert.ToDouble(labelEkran.Text);
        }
        private void buttonC_Click(object sender, EventArgs e)
        {
            labelEkran.Text = "0";
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            labelEkran.Text = labelEkran.Text.Substring(0, labelEkran.Text.Length - 1);
        }

        private void buttonNegatif_Click(object sender, EventArgs e)
        {
            if (labelEkran.Text != "0")
            {
                if (labelEkran.Text.StartsWith("-"))
                {
                    labelEkran.Text = labelEkran.Text.Replace("-", "");
                }
                else if (labelEkran.Text.StartsWith(""))
                {
                    labelEkran.Text = "-" + labelEkran.Text;
                }
            }
        }
    }
}