using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Proizvidstvennaya_practika
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }
        public static string user_log;
        SqlConnection con = new SqlConnection($"Data Source=LAPTOP-T0MQN7JE\\ILYA;Initial Catalog=Inventarizacia_ob_VUZa;Integrated Security=True");
        SqlDataAdapter da, daa,dad;
        DataTable dt, dtt,ddd;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
          //  {
                if (pass.Text != "")
                {
                    if (login.Text != "" && pass.Text != "")
                    {
                        da = new SqlDataAdapter("Select Password FROM [dbo].[Users] WHERE Login = '" + login.Text + "'", con);
                        dt = new DataTable();
                        DataSet dataset = new DataSet();
                        con.Open();
                        da.Fill(dataset);
                        dt = dataset.Tables[0];
                        //try
                        //{
                            string PasswordMD5 = pass.Text;
                            byte[] hashBytes = Encoding.Unicode.GetBytes(PasswordMD5);
                            using (System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider())
                            {
                                hashBytes = md5.ComputeHash(hashBytes);
                                StringBuilder stringBuilder = new StringBuilder();
                                foreach (byte b in hashBytes)
                                    stringBuilder.Append(b.ToString("X2"));
                                PasswordMD5 = stringBuilder.ToString();
                            }

                            if (PasswordMD5 == dt.Rows[0]["Password"].ToString())
                            {
                        con.Close();
                        // это нужно чтобы логин поймать
                        dad = new SqlDataAdapter("Select Login FROM [dbo].[Users] WHERE Login = '" + login.Text + "'", con);
                                ddd = new DataTable();
                                DataSet datasett2 = new DataSet();
                                con.Open();
                                dad.Fill(datasett2);
                                ddd = datasett2.Tables[0];

                                DataRow dataRow = ddd.Rows[0];
                                user_log = dataRow[0].ToString();
                        con.Close();

                        daa = new SqlDataAdapter("Select Role FROM [dbo].[Users] WHERE Login = '" + login.Text + "'", con);
                                dtt = new DataTable();
                                DataSet datasett = new DataSet();
                                con.Open();
                                daa.Fill(datasett);
                                dtt = datasett.Tables[0];
                                string role = "админ";
                                if (role == dtt.Rows[0]["Role"].ToString())
                                {
                                    Menu_admin frm = new Menu_admin();
                                    this.Hide();
                                    if (frm.ShowDialog() != DialogResult.OK)
                                        Close();
                                }
                                string role2 = "кладовщик";
                                if (role2 == dtt.Rows[0]["Role"].ToString())
                                {
                                    Menu frm = new Menu();
                                    this.Hide();
                                    if (frm.ShowDialog() != DialogResult.OK)
                                        Close();
                                }

                                string message = "Успешная авторизация";
                                string caption = "ок";
                                MessageBoxButtons buttons = MessageBoxButtons.OK;
                                DialogResult result;
                                result = MessageBox.Show(message, caption, buttons);
                    }
                            else
                            {
                                string message = "Такого пользователя нет";
                                string caption = "Ошибочка!";
                                MessageBoxButtons buttons = MessageBoxButtons.OK;
                                DialogResult result;
                                result = MessageBox.Show(message, caption, buttons);
                            }
                            con.Close();
                        //}
                        //catch
                        //{
                        //    string message = "Такого пользователя нет";
                        //    string caption = "Ошибочка!";
                        //    MessageBoxButtons buttons = MessageBoxButtons.OK;
                        //    DialogResult result;
                        //    result = MessageBox.Show(message, caption, buttons);
                        //}
                    }
                    else
                    {
                        MessageBox.Show("Введены неверные данные");
                    }
                }
                else
                {
                    MessageBox.Show("Введены неверные данные");
                }
            //}
            //catch (Exception exeption)
            //{
            //    MessageBox.Show(exeption.Message);
            //}
        }

        private void Auth_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reg frm = new Reg();
            this.Hide();
            if (frm.ShowDialog() != DialogResult.OK)
                Close();
        }
    }
}