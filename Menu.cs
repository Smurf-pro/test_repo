using System;
using System.Windows.Forms;

namespace Proizvidstvennaya_practika
{
    public partial class Menu : Form
    {
        public static string server;
        public Menu()
        {
            InitializeComponent();
        }

        private void to_sklad_Click(object sender, EventArgs e)
        {
                Sklad frm = new Sklad();
                this.Hide();
                if (frm.ShowDialog() != DialogResult.OK)
                    Close();
        }
  
        private void to_aud_Click(object sender, EventArgs e)
        {
            Auditorii frm = new Auditorii();
            this.Hide();
            if (frm.ShowDialog() != DialogResult.OK)
                Close();
        }

        private void see_obor_audit_Click(object sender, EventArgs e)
        {
            Prosmotr_auditor frm = new Prosmotr_auditor();
            this.Hide();
            if (frm.ShowDialog() != DialogResult.OK)
                Close();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}