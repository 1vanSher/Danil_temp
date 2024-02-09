using Npgsql;
using System.Data;
using System.Windows.Forms;
using static Danil_temp.DataBank;

namespace Danil_temp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataBank.SQLtoDB($"SELECT * FROM users WHERE login = '{textBox1.Text}'");
                string login = DataBank.dt.Rows[0][1].ToString();
                string password = DataBank.dt.Rows[0][2].ToString();
                if (login == textBox1.Text && password == textBox2.Text)
                {
                    this.Hide();
                    Form3 form3 = new Form3();
                    form3.ShowDialog();
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("Произошла ошибка");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
