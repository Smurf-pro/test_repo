using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Proizvidstvennaya_practika
{
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection($"Data Source=LAPTOP-T0MQN7JE\\ILYA;Initial Catalog=Inventarizacia_ob_VUZa;Integrated Security=True");
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Auth frm = new Auth();
            this.Hide();
            if (frm.ShowDialog() != DialogResult.OK)
                Close();
        }

        private void Reg_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (log.Text != "" && pas.Text != "")
            {
                con.Open();

                string Login = log.Text;
                string Password = pas.Text;
                string Role = "кладовщик";

                byte[] hashBytes = Encoding.Unicode.GetBytes(Password);
                using (System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider())
                {
                    hashBytes = md5.ComputeHash(hashBytes);
                    StringBuilder stringBuilder = new StringBuilder();
                    foreach (byte b in hashBytes)
                        stringBuilder.Append(b.ToString("X2"));
                    Password = stringBuilder.ToString();
                }

                SqlCommand cmd = new SqlCommand("Users_insert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Login", SqlDbType.Char).Value = Login;
                cmd.Parameters.Add("@Password", SqlDbType.Char).Value = Password;
                cmd.Parameters.Add("@Role", SqlDbType.Char).Value = Role;
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Успешно добавлено");
                    Auth frm = new Auth();
                    this.Hide();
                    if (frm.ShowDialog() != DialogResult.OK)
                        Close();
                }
                catch
                {
                    MessageBox.Show("Проверьте введенные данные.");
                }
                con.Close();
            }
        }
    }
}