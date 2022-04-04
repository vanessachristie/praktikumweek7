namespace praktikumweek7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnKon_Click(object sender, EventArgs e)
        {
            
            string hasil = tBoxPertama.Text;
            char[] charArr = hasil.ToCharArray();
            if (tBoxKedua.Text.Length==0 && tBoxKetiga.Text.Length==0 && tBoxPertama.Text.Length==0)
            {
                MessageBox.Show("belum ada yang akan di konversi! silahkan input lagi");
            }
            else if (tBoxPertama.Text.Length == 0)
            {
                MessageBox.Show("belum ada yang akan di konversi! silahkan input lagi");
            }
            else if (tBoxKetiga.Text.Length == 0)
            {
                MessageBox.Show("belum ada yang akan di konversi! silahkan input lagi");
            }
            else if (tBoxKedua.Text.Length == 0)
            {
                MessageBox.Show("belum ada yang akan di konversi! silahkan input lagi");
            }
            string simpan = tBoxKedua.Text;
            char character = char.Parse(simpan);

            string konversi = tBoxKetiga.Text;
            char character2 = char.Parse(konversi);

            int perbandingann = character2 - character;
            lOutput.Text = " ";
                foreach (char ch in charArr)
                { 
                    lOutput.Text += Convert.ToChar(ch + perbandingann);
                }
        }

       
    }
    }
