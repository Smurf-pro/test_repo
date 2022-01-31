using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proizvidstvennaya_practika
{
    public partial class Mouse : Form
    {
        string loginn = Auth.user_log;
        SqlDataAdapter da, dad;
        DataTable ddd;
        DataSet ds;
        SqlConnection con = new SqlConnection($"Data Source=LAPTOP-T0MQN7JE\\ILYA;Initial Catalog=Inventarizacia_ob_VUZa;Integrated Security=True");
        public Mouse()
        {
            InitializeComponent();
        }

        private void nazad_Click(object sender, EventArgs e)
        {
            Add_tehnica frm = new Add_tehnica();
            this.Hide();
            if (frm.ShowDialog() != DialogResult.OK)
                Close();
        }
        void GetList()
        {
            con.Open();
            da = new SqlDataAdapter($"Select * From [dbo].[Mouse]", con);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Mouse_Load(object sender, EventArgs e)
        {
            GetList();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (ser.Text != "" && ser.Text != " " && nazv.Text != "" && nazv.Text != " " && max_ras_datchika.Text != "" && max_ras_datchika.Text != " ")
            {
                if (type_connect.SelectedIndex != -1)
                {
                    if (interface_mouse.SelectedIndex != -1)
                    {
                        var zp = false;
                        con.Open();
                        var Type_oborudovaniya = "Мышка";
                        string Serial_number_mouse = ser.Text;
                        string Nazvanie = nazv.Text;
                        string Type_soedineniya = type_connect.Text;
                        string Interface_mouse = interface_mouse.SelectedItem.ToString();
                        string Max_razreshenie_datchika = max_ras_datchika.Text;
                        string Mesto_Hraneniya = "Склад";

                        SqlCommand cmd = new SqlCommand("Sklad_insert", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@Ser_num", SqlDbType.Char).Value = Serial_number_mouse;
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

                            SqlCommand cmd1 = new SqlCommand("Mouse_insert", con);
                            cmd1.CommandType = CommandType.StoredProcedure;
                            cmd1.Parameters.Add("@Serial_number_mouse", SqlDbType.Char).Value = Serial_number_mouse;
                            cmd1.Parameters.Add("@Type_oborudovaniya", SqlDbType.Char).Value = Type_oborudovaniya;
                            cmd1.Parameters.Add("@Nazvanie", SqlDbType.Char).Value = Nazvanie;
                            cmd1.Parameters.Add("@Type_soedineniya", SqlDbType.Char).Value = Type_soedineniya;
                            cmd1.Parameters.Add("@Interface_mouse", SqlDbType.Char).Value = Interface_mouse;
                            cmd1.Parameters.Add("@Max_razreshenie_datchika", SqlDbType.Int).Value = Max_razreshenie_datchika;
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
                        MessageBox.Show("Интерфейс мышки не выбран");
                    }
                }
                else
                {
                    MessageBox.Show("Тип соединения не выбран");
                }
            }
            else
            {
                MessageBox.Show("Поля не заполнены");
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Mouse_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}