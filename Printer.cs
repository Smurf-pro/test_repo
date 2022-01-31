using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proizvidstvennaya_practika
{
    public partial class Printer : Form
    {
        string loginn = Auth.user_log;
        SqlDataAdapter da,dad;
        DataTable dt,ddd;
        SqlCommand cmd;
        DataSet ds;
        SqlConnection con = new SqlConnection($"Data Source=LAPTOP-T0MQN7JE\\ILYA;Initial Catalog=Inventarizacia_ob_VUZa;Integrated Security=True");
        public Printer()
        {
            InitializeComponent();
        }
        void GetList()
        {
            con.Open();
            da = new SqlDataAdapter($"Select * From [dbo].[Printer]", con);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Printer_Load(object sender, EventArgs e)
        {
            GetList();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (ser.Text != "" && ser.Text != " " && nazv.Text !="" && nazv.Text != " " && maxSpeed.Text != "" && maxSpeed.Text != " ")
            {
               if (type.SelectedIndex != -1)
               {
                    if (cvet.SelectedIndex != -1)
                    {
                        if (maxformat.SelectedIndex != -1)
                        {
                            var zp = false;
                            con.Open();
                            string Mesto_Hraneniya = "Склад";
                            var Type_oborudovaniya = "Принтер";
                            string Serial_number_printer = ser.Text;
                            string Nazvanie = nazv.Text;
                            string Type_printera = type.Text;
                            string Cvetnost_pechati = cvet.SelectedItem.ToString();
                            string Max_speed_pechati = maxSpeed.Text;
                            string Max_format_pechati = maxformat.SelectedItem.ToString();

                            SqlCommand cmd = new SqlCommand("Sklad_insert", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@Ser_num", SqlDbType.Char).Value = Serial_number_printer;
                            cmd.Parameters.Add("@Type_oborudovaniya_", SqlDbType.Char).Value = Type_oborudovaniya;
                            cmd.Parameters.Add("@Nazvanie_ob", SqlDbType.Char).Value = Nazvanie;
                            cmd.Parameters.Add("@Mesto_Hraneniya", SqlDbType.Char).Value = Mesto_Hraneniya;
                            cmd.Parameters.Add("@Login", SqlDbType.Char).Value = loginn;
                            try
                            {
                                cmd.ExecuteNonQuery();
                                zp = true;
                                MessageBox.Show("Успешно добавлено");
                            }
                            catch
                            {
                                MessageBox.Show("Проверьте введенные данные.");
                                zp = false;
                            }
                            con.Close();
                            if (zp == true)
                            {
                                con.Open();
                                dad = new SqlDataAdapter("Select Invent_num FROM [dbo].[Sklad] WHERE Ser_num = '" + ser.Text + "'", con);
                                ddd = new DataTable();
                                DataSet datasett2 = new DataSet();
                                dad.Fill(datasett2);
                                ddd = datasett2.Tables[0];

                                DataRow dataRow = ddd.Rows[0];
                                string inventr_number = dataRow[0].ToString();
                                con.Close();
                                con.Open();
                                int inventr_number2 = Convert.ToInt32(inventr_number);

                                SqlCommand cmd1 = new SqlCommand("Printer_insert", con);
                                cmd1.CommandType = CommandType.StoredProcedure;
                                cmd1.Parameters.Add("@Serial_number_printer", SqlDbType.Char).Value = Serial_number_printer;
                                cmd1.Parameters.Add("@Type_oborudovaniya", SqlDbType.Char).Value = Type_oborudovaniya;
                                cmd1.Parameters.Add("@Nazvanie", SqlDbType.Char).Value = Nazvanie;
                                cmd1.Parameters.Add("@Type_printera", SqlDbType.Char).Value = Type_printera;
                                cmd1.Parameters.Add("@Cvetnost_pechati", SqlDbType.Char).Value = Cvetnost_pechati;
                                cmd1.Parameters.Add("@Max_speed_pechati", SqlDbType.Int).Value = Max_speed_pechati;
                                cmd1.Parameters.Add("@Max_format_pechati", SqlDbType.Char).Value = Max_format_pechati;
                                cmd1.Parameters.Add("@Invent_num", SqlDbType.Int).Value = inventr_number2;

                                try
                                {
                                    cmd1.ExecuteNonQuery();
                                }
                                catch
                                {
                                    MessageBox.Show("Проверьте введенные данные.");
                                }
                                con.Close();
                                GetList();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Максимальный формат печати не заполнен");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Цветность печати не заполнена");
                    }
               }
               else
               {
                    MessageBox.Show("Тип принтера не заполнен");
               }
            }
            else
            {
                MessageBox.Show("Поля не заполнены");
            }
        }

        private void nazad_Click(object sender, EventArgs e)
        {
            Add_tehnica frm = new Add_tehnica();
            this.Hide();
            if (frm.ShowDialog() != DialogResult.OK)
                Close();
        }

        private void maxSpeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                string message = "Только цифры";
                string caption = "Ошибочка!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                e.Handled = true;
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}