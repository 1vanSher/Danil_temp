using Npgsql;
using static Danil_temp.DataBank;

namespace Danil_temp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string login = "";
                DataBank.SQLtoDB($"SELECT * FROM users WHERE login = '{textBox1.Text}'");
                if (DataBank.dt.Rows.Contains(0) == true)
                {
                    throw new Exception("Логин занят");
                }
                else
                {
                    DataBank.SQLtoDBwithChanges($"INSERT INTO users (login, password) VALUES ('{textBox1.Text}', {textBox2.Text});");
                    this.Hide();
                    Form1 form1 = new Form1();
                    form1.ShowDialog();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
