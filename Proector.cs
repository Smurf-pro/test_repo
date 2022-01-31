using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proizvidstvennaya_practika
{
    public partial class Proector : Form
    {
        string loginn = Auth.user_log;
        SqlDataAdapter da,dad;
        DataTable dt,ddd;
        SqlCommand cmd;
        DataSet ds;
        SqlConnection con = new SqlConnection($"Data Source=LAPTOP-T0MQN7JE\\ILYA;Initial Catalog=Inventarizacia_ob_VUZa;Integrated Security=True");
        public Proector()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (serNom.Text != "" && serNom.Text != " " && nazv.Text != "" && nazv.Text != " " && pik_yarkost.Text != "" && pik_yarkost.Text != " " && rassh1.Text != "" && rassh2.Text != " ")
            {
                if (sootnoshenie_storon.SelectedIndex != -1)
                {
                    var zp = false;
                    con.Open();
                    var Type_oborudovaniya = "Проектор";
                    string Mesto_Hraneniya = "Склад";
                    string Serial_number_printer = serNom.Text;
                    string Nazvanie = nazv.Text;
                    string Razreshenie = rassh1.Text + "x" + rassh2.Text;
                    string Pikovaya_yarkost = pik_yarkost.Text;
                    string Sootnoshenie_storon_ekrana = sootnoshenie_storon.SelectedItem.ToString();

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
                        dad = new SqlDataAdapter("Select Invent_num FROM [dbo].[Sklad] WHERE Ser_num = '" + serNom.Text + "'", con);
                        ddd = new DataTable();
                        DataSet datasett2 = new DataSet();
                        dad.Fill(datasett2);
                        ddd = datasett2.Tables[0];

                        DataRow dataRow = ddd.Rows[0];
                        string inventr_number = dataRow[0].ToString();
                        con.Close();
                        con.Open();
                        int inventr_number2 = Convert.ToInt32(inventr_number);

                        SqlCommand cmd1 = new SqlCommand("Proector_insert", con);
                        cmd1.CommandType = CommandType.StoredProcedure;
                        cmd1.Parameters.Add("@Serial_number_proector", SqlDbType.Char).Value = Serial_number_printer;
                        cmd1.Parameters.Add("@Type_oborudovaniya", SqlDbType.Char).Value = Type_oborudovaniya;
                        cmd1.Parameters.Add("@Nazvanie", SqlDbType.Char).Value = Nazvanie;
                        cmd1.Parameters.Add("@Razreshenie", SqlDbType.Char).Value = Razreshenie;
                        cmd1.Parameters.Add("@Pikovaya_yarkost", SqlDbType.Int).Value = Pikovaya_yarkost;
                        cmd1.Parameters.Add("@Sootnoshenie_storon_ekrana", SqlDbType.Char).Value = Sootnoshenie_storon_ekrana;
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
                    MessageBox.Show("Соотношение сторон проектора не заполнено");
                }
            }
            else
            {
                MessageBox.Show("Поля не заполнены");
            }
        }

        private void pik_yarkost_KeyPress(object sender, KeyPressEventArgs e)
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
            da = new SqlDataAdapter($"Select * From [dbo].[Proector]", con);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Proector_Load(object sender, EventArgs e)
        {
            GetList();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}