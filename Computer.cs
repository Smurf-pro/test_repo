using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proizvidstvennaya_practika
{
    public partial class Computer : Form
    {
        string loginn = Auth.user_log;
        SqlDataAdapter da,dad;
        DataTable ddd;
        DataSet ds;
        SqlConnection con = new SqlConnection($"Data Source=LAPTOP-T0MQN7JE\\ILYA;Initial Catalog=Inventarizacia_ob_VUZa;Integrated Security=True");
        public Computer()
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

        private void add_Click(object sender, EventArgs e)
        {
            if (ser.Text != "" && ser.Text != " " && nazv.Text != "" && nazv.Text != " " && cpu.Text != "" && cpu.Text != " " && videokarta.Text != "" && videokarta.Text != " ")
            {
                if (operativka.SelectedIndex != -1)
                {
                    if (hard_disk.SelectedIndex != -1)
                    {
                        if (ssd.SelectedIndex != -1)
                        {
                            if (Oc.SelectedIndex != -1)
                            {
                                con.Open();
                                var zp = false;
                                var Type_oborudovaniya = "Компьютер";
                                string Mesto_Hraneniya = "Склад";
                                string Serial_number_pc = ser.Text;
                                string Nazvanie = nazv.Text;
                                string Processor = cpu.Text;
                                string Operativnaya_pamyt = operativka.SelectedItem.ToString();
                                string Hard_drive = hard_disk.SelectedItem.ToString();
                                string SolidStateDrive = ssd.SelectedItem.ToString();
                                string Videokarta = videokarta.Text;
                                string OC = Oc.SelectedItem.ToString();

                                SqlCommand cmd = new SqlCommand("Sklad_insert", con);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add("@Ser_num", SqlDbType.Char).Value = Serial_number_pc;
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

                                    SqlCommand cmd1 = new SqlCommand("Computers_insert", con);
                                    cmd1.CommandType = CommandType.StoredProcedure;
                                    cmd1.Parameters.Add("@Serial_number_pc", SqlDbType.Char).Value = Serial_number_pc;
                                    cmd1.Parameters.Add("@Type_oborudovaniya", SqlDbType.Char).Value = Type_oborudovaniya;
                                    cmd1.Parameters.Add("@Nazvanie", SqlDbType.Char).Value = Nazvanie;
                                    cmd1.Parameters.Add("@Processor", SqlDbType.Char).Value = Processor;
                                    cmd1.Parameters.Add("@Operativnaya_pamyt", SqlDbType.Char).Value = Operativnaya_pamyt;
                                    cmd1.Parameters.Add("@Hard_drive", SqlDbType.Char).Value = Hard_drive;
                                    cmd1.Parameters.Add("@SolidStateDrive", SqlDbType.Char).Value = SolidStateDrive;
                                    cmd1.Parameters.Add("@Videokarta", SqlDbType.Char).Value = Videokarta;
                                    cmd1.Parameters.Add("@OC", SqlDbType.Char).Value = OC;
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
                                MessageBox.Show("Операционная система не выбрана");
                            }
                        }
                        else
                        {
                            MessageBox.Show("SSD не выбран");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Жесткий диск не выбран");
                    }
                }
                else
                {
                    MessageBox.Show("Размер оперативной памяти не выбран");
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

        void GetList()
        {
            con.Open();
            da = new SqlDataAdapter($"Select * From [dbo].[Computers]", con);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Computer_Load(object sender, EventArgs e)
        {
            GetList();
        }
    }
}