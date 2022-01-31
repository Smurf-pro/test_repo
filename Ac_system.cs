using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proizvidstvennaya_practika
{
    public partial class Ac_system : Form
    {
        SqlDataAdapter da, dad;
        DataTable ddd;
        DataSet ds;
        SqlConnection con = new SqlConnection($"Data Source=LAPTOP-T0MQN7JE\\ILYA;Initial Catalog=Inventarizacia_ob_VUZa;Integrated Security=True");
        string loginn = Auth.user_log;

        public Ac_system()
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
            da = new SqlDataAdapter($"Select * From [dbo].[Akusticheskaya_system]", con);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Ac_system_Load(object sender, EventArgs e)
        {
            GetList();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (ser.Text != "" && ser.Text != " " && nazv.Text != "" && nazv.Text != " ")
            {
                if (sound.SelectedIndex != -1)
                {               
                    con.Open();
                    try
                    {
                        var zp = false;   
                            string Ser_num = ser.Text;
                            var Type_oborudovaniya = "Акустическая система";
                            string Nazvanie_ob = nazv.Text;
                            string Mesto_Hraneniya = "Склад";
                            string Login = loginn;
                            string Max_power = maxMosh.Text;
                            string Zvukovaya_shema = sound.SelectedItem.ToString();
                            SqlCommand cmd = new SqlCommand("Sklad_insert", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@Ser_num", SqlDbType.Char).Value = Ser_num;
                            cmd.Parameters.Add("@Type_oborudovaniya_", SqlDbType.Char).Value = Type_oborudovaniya;
                            cmd.Parameters.Add("@Nazvanie_ob", SqlDbType.Char).Value = Nazvanie_ob;
                            cmd.Parameters.Add("@Mesto_Hraneniya", SqlDbType.Char).Value = Mesto_Hraneniya;
                            cmd.Parameters.Add("@Login", SqlDbType.Char).Value = Login;
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

                        string Serial_number_ak_syst = ser.Text;
                        int inventr_number2 = Convert.ToInt32(inventr_number);

                        SqlCommand cmd1 = new SqlCommand("Akusticheskaya_system_insert", con);
                        cmd1.CommandType = CommandType.StoredProcedure;
                        cmd1.Parameters.Add("@Serial_number_ak_syst", SqlDbType.Char).Value = Serial_number_ak_syst;
                        cmd1.Parameters.Add("@Type_oborudovaniya", SqlDbType.Char).Value = Type_oborudovaniya;
                        cmd1.Parameters.Add("@Nazvanie", SqlDbType.Char).Value = Nazvanie_ob;
                        cmd1.Parameters.Add("@Max_power", SqlDbType.Int).Value = Max_power;
                        cmd1.Parameters.Add("@Zvukovaya_shema", SqlDbType.Char).Value = Zvukovaya_shema;
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
                    catch
                    {
                        MessageBox.Show("Такая техника уже есть на складе");
                    }
                }
                else
                {
                    MessageBox.Show("Звуковая схема не заполнена");
                }
            }
            else
            {
                MessageBox.Show("Поля не заполнены");
            }
        }

        private void maxMosh_KeyPress(object sender, KeyPressEventArgs e)
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
//////////
/////////
/////////
////////