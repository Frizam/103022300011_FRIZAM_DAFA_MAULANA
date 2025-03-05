namespace _103022300011_FRIZAM_DAFA_MAULANA
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        String value;
        int hasil;
        int hasil_terakhir=0; // tempat menampung hasil terakhir saat sudah melakukan operasi pertama kali
        int angka1, angka2;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            value = "7";
            label1.Text = value;
            // button angka 7 yang akan mengeluarkan output kedalam "7" label
        }

        private void button1_Click(object sender, EventArgs e)
        {
            value = "1";
            label1.Text = value;
            // button angka 1 yang akan mengeluarkan output kedalam "1" label
        }

        private void button2_Click(object sender, EventArgs e)
        {
            value = "2";
            label1.Text = value;
            // button angka 2 yang akan mengeluarkan output kedalam "2" label
        }

        private void button3_Click(object sender, EventArgs e)
        {
            value = "3";
            label1.Text = value;
            // button angka 3 yang akan mengeluarkan output kedalam "3" label
        }

        private void button9_Click(object sender, EventArgs e)
        {
            value = "9";
            label1.Text = value;
            // button angka 9 yang akan mengeluarkan output kedalam "9" label
        }

        private void button4_Click(object sender, EventArgs e)
        {
            value = "4";
            label1.Text = value;
            // button angka 4 yang akan mengeluarkan output kedalam "4" label
        }

        private void button5_Click(object sender, EventArgs e)
        {
            value = "5";
            label1.Text = value;
            // button angka 5 yang akan mengeluarkan output kedalam "5" label
        }

        private void button6_Click(object sender, EventArgs e)
        {
            value = "6";
            label1.Text = value;
            // button angka 6 yang akan mengeluarkan output kedalam "6" label
        }

        private void button8_Click(object sender, EventArgs e)
        {
            value = "8";
            label1.Text = value;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            angka1 = int.Parse(value);
            label1.Text="";
            // merefresh output di label dan mengkonvert value menjadi integer dan ditampung dalam variabel angka1
        }

        private void button11_Click(object sender, EventArgs e)
        {
            value = "0";
            label1.Text = value;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            angka2 = int.Parse(value);


            if (hasil_terakhir == 0)
            {
                hasil = angka1 + angka2;
                label1.Text = "" + hasil;
                hasil_terakhir = hasil;

            } else if (hasil_terakhir != 0) 
            {
                hasil_terakhir += angka2;
                label1.Text = "" + hasil_terakhir;
            }
            // mengkonvert value yang akan ditampung di variabel angka2 dan melakukan operasi penjumlahan dan menampilkan hasilnya di label
            // jika pertama kali melakukan operasi maka akan di tampung hasilnya kedalam hasil terakhir
            //hasil terakhir digunakan jika masih ingin melakukan penjumlahan lagi
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
