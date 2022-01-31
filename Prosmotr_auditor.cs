using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proizvidstvennaya_practika
{
    public partial class Prosmotr_auditor : Form
    {
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;
        SqlCommand cmd;
        SqlConnection con = new SqlConnection($"Data Source=LAPTOP-T0MQN7JE\\ILYA;Initial Catalog=Inventarizacia_ob_VUZa;Integrated Security=True");
        public Prosmotr_auditor()
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

        private void Prosmotr_auditor_Load(object sender, EventArgs e)
        {
            LoadAuditorii();
        }
        void LoadAuditorii()
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter($"SELECT * from [dbo].[Auditoriya]", con);
                DataSet dataSet = new DataSet();
                da.Fill(dataSet);

                comboBox2.DataSource = dataSet.Tables[0];
                comboBox2.DisplayMember = "Nazvanie";
                comboBox2.ValueMember = "Nazvanie";
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
            string Mesto = comboBox2.Text;
            con.Open();
            da = new SqlDataAdapter($"Select * From [dbo].[Sklad] WHERE Mesto_Hraneniya = '{Mesto}'", con);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void prosmotr_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
                GetList();
            }
            else
            {
                MessageBox.Show("Выберите значения в combobox");
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

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}