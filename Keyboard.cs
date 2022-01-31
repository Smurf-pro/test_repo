using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proizvidstvennaya_practika
{
    public partial class Keyboard : Form
    {
        SqlDataAdapter da,dad;
        string loginn = Auth.user_log;
        DataTable ddd;
        DataSet ds;
        SqlConnection con = new SqlConnection($"Data Source=LAPTOP-T0MQN7JE\\ILYA;Initial Catalog=Inventarizacia_ob_VUZa;Integrated Security=True");
        public Keyboard()
        {
            InitializeComponent();
        }
        private void add_Click(object sender, EventArgs e)
        {
            if (ser.Text != "" && ser.Text != " " && nazv.Text != "" && nazv.Text != " ")
            {
                if (interfacee.SelectedIndex != -1)
                {
                    if (type_keybord.SelectedIndex != -1)
                    {
                        con.Open();
                        var zp = false;
                        var Type_oborudovaniya = "Клавиатура";
                        string Mesto_Hraneniya = "Склад";
                        string Serial_number_klaviatura = ser.Text;
                        string Nazvanie = nazv.Text;
                        string Interface_podlkuchenia = interfacee.SelectedItem.ToString();
                        string Type_klaviatur = type_keybord.SelectedItem.ToString();

                        SqlCommand cmd = new SqlCommand("Sklad_insert", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@Ser_num", SqlDbType.Char).Value = Serial_number_klaviatura;
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

                            SqlCommand cmd1 = new SqlCommand("Klaviatura_insert", con);
                            cmd1.CommandType = CommandType.StoredProcedure;
                            cmd1.Parameters.Add("@Serial_number_klaviatura", SqlDbType.Char).Value = Serial_number_klaviatura;
                            cmd1.Parameters.Add("@Type_oborudovaniya", SqlDbType.Char).Value = Type_oborudovaniya;
                            cmd1.Parameters.Add("@Nazvanie", SqlDbType.Char).Value = Nazvanie;
                            cmd1.Parameters.Add("@Interface_podlkuchenia", SqlDbType.Char).Value = Interface_podlkuchenia;
                            cmd1.Parameters.Add("@Type_klaviatur", SqlDbType.Char).Value = Type_klaviatur;
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
                        MessageBox.Show("Тип клавиатуры не заполнен");
                    }
                }
                else
                {
                    MessageBox.Show("Интерфейс подключения не заполнен");
                }
            }
            else
            {
                MessageBox.Show("Поля не заполнены");
            }
        }
        void GetList()
        {
            con.Open();
            da = new SqlDataAdapter($"Select * From [dbo].[Klaviatura]", con);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Keyboard_Load(object sender, EventArgs e)
        {
            GetList();
        }

        private void nazad_Click(object sender, EventArgs e)
        {
            Add_tehnica frm = new Add_tehnica();
            this.Hide();
            if (frm.ShowDialog() != DialogResult.OK)
                Close();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}