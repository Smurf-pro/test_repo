using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proizvidstvennaya_practika
{
    public partial class Auditorii : Form
    {
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;
        SqlCommand cmd;
        SqlConnection con = new SqlConnection($"Data Source=LAPTOP-T0MQN7JE\\ILYA;Initial Catalog=Inventarizacia_ob_VUZa;Integrated Security=True");
        public Auditorii()
        {
            InitializeComponent();
        }

        private void nazad_Click(object sender, EventArgs e)
        {
            Menu frm = new Menu();
            this.Hide();
            if (frm.ShowDialog() != DialogResult.OK)
                Close();
        }

        private void Auditorii_Load(object sender, EventArgs e)
        {
            GetList();
        }
        void GetList()
        {
            con.Open();
            da = new SqlDataAdapter("Select * From [dbo].[Auditoriya]", con);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (nom_aud.Text != "" && floor.Text != "")
            {
                    string str = nom_aud.Text;
                    if (str.Length == 4)
                    {
                        if (str.EndsWith("а") || str.EndsWith("б") || str.EndsWith("в"))
                        {
                            con.Open();
                            try
                            {
                                string Nazvanie = nom_aud.Text;
                                string Floor = floor.Text;

                                SqlCommand cmd = new SqlCommand("Auditoriya_insert", con);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add("@Nazvanie", SqlDbType.VarChar).Value = Nazvanie;
                                cmd.Parameters.Add("@Floor", SqlDbType.Int).Value = Floor;
                                cmd.ExecuteNonQuery();
                                con.Close();
                                GetList();
                            }
                            catch
                            {
                                MessageBox.Show("Такая аудитория уже существует");
                            }
                        }
                        else
                        {
                           MessageBox.Show("Такой аудитории не может существовать");
                        }
                    }  
                    else
                    {
                           if (str.Length == 3)
                           {
                                 if (int.TryParse(str, out int number))
                                 {
                                        con.Open();
                                        try
                                        {
                                            string Nazvanie = nom_aud.Text;
                                            string Floor = floor.Text;

                                            SqlCommand cmd = new SqlCommand("Auditoriya_insert", con);
                                            cmd.CommandType = CommandType.StoredProcedure;
                                            cmd.Parameters.Add("@Nazvanie", SqlDbType.VarChar).Value = Nazvanie;
                                            cmd.Parameters.Add("@Floor", SqlDbType.Int).Value = Floor;
                                            cmd.ExecuteNonQuery();
                                            con.Close();
                                            GetList();
                                        }
                                        catch
                                        {
                                            MessageBox.Show("Такая аудитория уже существует");
                                        }
                                 }
                                 else
                                 {
                                 }
                           }
                    } 
            }
            else
            {
                MessageBox.Show("Заполните поля!");
            }
        }
            private void floor_KeyPress(object sender, KeyPressEventArgs e)
            {
            if ((e.KeyChar >= '1' && e.KeyChar <= '3') || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                    string message = "Только цифры! Максимальный этаж 3";
                    string caption = "Ошибочка!";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    e.Handled = true;
            }
            }   

        private void eksport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            Microsoft.Office.Interop.Excel._Worksheet workSheet = ExcelApp.ActiveSheet;

            workSheet.Cells[1, "A"] = "Номер аудитории";
            workSheet.Cells[1, "B"] = "Этаж";

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }

        private void nom_aud_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar >= 'а' && e.KeyChar <= 'в') || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                string message = "Введите номер аудитории(цифрами) и букву(а-в), если она есть";
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