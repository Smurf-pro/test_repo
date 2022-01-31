using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proizvidstvennaya_practika
{
    public partial class Scaner : Form
    {
        string loginn = Auth.user_log;
        SqlDataAdapter da, dad;
        DataTable dt, ddd;
        SqlCommand cmd;
        DataSet ds;
        SqlConnection con = new SqlConnection($"Data Source=LAPTOP-T0MQN7JE\\ILYA;Initial Catalog=Inventarizacia_ob_VUZa;Integrated Security=True");
        public Scaner()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (ser.Text != "" && ser.Text != " " && nazv.Text != "" && nazv.Text != " ")
            {
                if (type_scan.SelectedIndex != -1)
                {
                    if (dvustoron_pech.SelectedIndex != -1)
                    {
                        if (max_format_origin.SelectedIndex != -1)
                        {
                            var zp = false;
                            con.Open();
                            var Type_oborudovaniya = "Сканер";
                            string Mesto_Hraneniya = "Склад";
                            string Serial_number_scaner = ser.Text;
                            string Nazvanie = nazv.Text;
                            string Type_skanera = type_scan.SelectedItem.ToString();
                            string Dvustoron_scan = dvustoron_pech.SelectedItem.ToString();
                            string Max_format_originala = max_format_origin.SelectedItem.ToString();

                            SqlCommand cmd = new SqlCommand("Sklad_insert", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@Ser_num", SqlDbType.Char).Value = Serial_number_scaner;
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

                                SqlCommand cmd1 = new SqlCommand("Scaner_insert", con);
                                cmd1.CommandType = CommandType.StoredProcedure;
                                cmd1.Parameters.Add("@Serial_number_scaner", SqlDbType.Char).Value = Serial_number_scaner;
                                cmd1.Parameters.Add("@Type_oborudovaniya", SqlDbType.Char).Value = Type_oborudovaniya;
                                cmd1.Parameters.Add("@Nazvanie", SqlDbType.Char).Value = Nazvanie;
                                cmd1.Parameters.Add("@Type_skanera", SqlDbType.Char).Value = Type_skanera;
                                cmd1.Parameters.Add("@Dvustoron_scan", SqlDbType.Char).Value = Dvustoron_scan;
                                cmd1.Parameters.Add("@Max_format_originala", SqlDbType.Char).Value = Max_format_originala;
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
                            MessageBox.Show("Максимальный формат оригинала не выбран");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Наличие двусторонней печати не выбрано");
                    }
                }
                else
                {
                    MessageBox.Show("Тип сканера не выбран");
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
            da = new SqlDataAdapter($"Select * From [dbo].[Scaner]", con);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Scaner_Load(object sender, EventArgs e)
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