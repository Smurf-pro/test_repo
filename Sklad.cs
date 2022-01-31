using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proizvidstvennaya_practika
{
    public partial class Sklad : Form
    {
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;
        SqlCommand cmd;
        SqlConnection con = new SqlConnection($"Data Source=LAPTOP-T0MQN7JE\\ILYA;Initial Catalog=Inventarizacia_ob_VUZa;Integrated Security=True");

        public Sklad()
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

        private void New_oborud_Click(object sender, EventArgs e)
        {
            Add_tehnica frm = new Add_tehnica();
            this.Hide();
            if (frm.ShowDialog() != DialogResult.OK)
                Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex != -1)
            {
                cmd = new SqlCommand();
                    con.Open();
                    cmd.Connection = con;

                var inv = comboBox4.Text;
                var inv_n = Convert.ToInt32(inv);
                cmd.CommandText = String.Format("delete from [dbo].[Sklad] where Invent_num='{0}'", inv_n);
                try
                {
                   cmd.ExecuteNonQuery();
                }
                catch
                {
                    
                }
                con.Close();
                GetList();
            }
            else
             {
                MessageBox.Show("Поле не может быть пустым");
             }
}

        private void Sklad_Load(object sender, EventArgs e)
        {
            GetList();
            LoadAuditorii();
            LoadInventarNomer();
            LoadInventarNomerForPerem();
        }
        void LoadAuditorii()
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter($"SELECT * from [dbo].[Auditoriya]", con);
                DataSet dataSet = new DataSet();
                da.Fill(dataSet);

                comboBox3.DataSource = dataSet.Tables[0];
                comboBox3.DisplayMember = "Nazvanie";
                comboBox3.ValueMember = "Nazvanie";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                con.Close();
            }
        }

        void LoadInventarNomer()
        {
            try
            {
                con.Open();
                string Mesto = "Склад";
                da = new SqlDataAdapter($"SELECT * from [dbo].[Sklad] WHERE Mesto_Hraneniya = '{Mesto}'", con);
                DataSet dataSet = new DataSet();
                da.Fill(dataSet);
                comboBox4.DataSource = dataSet.Tables[0];
                comboBox4.DisplayMember = "Invent_num";
                comboBox4.ValueMember = "Invent_num";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                con.Close();
            }
        }
        void LoadInventarNomerForPerem()
        {
            try
            {
                con.Open();
                string Mesto = "Склад";
                da = new SqlDataAdapter($"SELECT * from [dbo].[Sklad]", con);
                DataSet dataSet = new DataSet();
                da.Fill(dataSet);
                comboBox2.DataSource = dataSet.Tables[0];
                comboBox2.DisplayMember = "Invent_num";
                comboBox2.ValueMember = "Invent_num";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                con.Close();
            }
        }

        void GetList()
        {
            string Mesto = "Склад";
            con.Open();
            da = new SqlDataAdapter($"Select * From [dbo].[Sklad] WHERE Mesto_Hraneniya = '{Mesto}'", con);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void filtr_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                string oborud = comboBox1.SelectedItem.ToString();
                con.Open();
                da = new SqlDataAdapter($"Select * From [dbo].[Sklad] WHERE Type_oborudovaniya_ = '{oborud}'", con);
                ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
            else
            {
                MessageBox.Show("Выберите тип оборудования");
            }
        }

        private void refr_Click(object sender, EventArgs e)
        {
            GetList();
        }

        private void vse_oborudovanie_Click(object sender, EventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter($"Select * From [dbo].[Sklad] ", con);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                string message = "Только цифры и буквы латинского алфавита";
                string caption = "Ошибочка!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                e.Handled = true;
            }
        }

        private void peremestit_Click(object sender, EventArgs e)
        {
            if ((comboBox2.SelectedIndex != -1) && (comboBox3.SelectedIndex != -1))
            {
                var sel_in = comboBox2.Text;
                var mesto = comboBox3.Text;
                 var inv_n = Convert.ToInt32(sel_in);
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd = new SqlCommand($"UPDATE [dbo].[Sklad] SET Mesto_Hraneniya ='{mesto}' WHERE Invent_num = '{inv_n}'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                GetList();
            }
            else
            {
                MessageBox.Show("problema");
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

            workSheet.Cells[1, "A"] = "Инвентарный номер";
            workSheet.Cells[1, "B"] = "Серийный номер";
            workSheet.Cells[1, "C"] = "Тип оборудования";
            workSheet.Cells[1, "D"] = "Название";
            workSheet.Cells[1, "E"] = "Место хранения";

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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}