using TextBox = System.Windows.Forms.TextBox;

namespace Sayi_tahmin_RANDOM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rd = new();
        string msg;
        int succes1 = 0, succes2 = 0, succes3 = 0, succes4 = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void ColorChooser(Label lbl, TextBox txb, out int succes)
        {

            lbl.Text = rd.Next(1, 5).ToString();
            lbl.BackColor = lbl.Text == txb.Text ? Color.LightGreen : Color.Red;
            int.TryParse(txb.Text, out int txbResult);
            succes = int.Parse(lbl.Text) ==  txbResult ? 1 : 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ColorChooser(label1, textBox1, out succes1);
            ColorChooser(label2, textBox2, out succes2);
            ColorChooser(label3, textBox3, out succes3);
            ColorChooser(label4, textBox4, out succes4);

            int succesCount = succes1 + succes2 + succes3 + succes4;

            if (succesCount >= 3)
            {
                msg = $"{succesCount} numbers guessed SUCCESSFULLY.";
                MessageBox.Show(msg);
            }

        }
    }
}