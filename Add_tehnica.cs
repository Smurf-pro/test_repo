using System;
using System.Windows.Forms;

namespace Proizvidstvennaya_practika
{
    public partial class Add_tehnica : Form
    {
        public Add_tehnica()
        {
            InitializeComponent();
        }

        private void nazad_Click(object sender, EventArgs e)
        {
            Sklad frm = new Sklad();
            this.Hide();
            if (frm.ShowDialog() != DialogResult.OK)
                Close();
        }

        private void add_print_Click(object sender, EventArgs e)
        {
            Printer frm = new Printer();
            this.Hide();
            if (frm.ShowDialog() != DialogResult.OK)
                Close();
        }

        private void add_proector_Click(object sender, EventArgs e)
        {
            Proector frm = new Proector();
            this.Hide();
            if (frm.ShowDialog() != DialogResult.OK)
                Close();
        }

        private void ak_system_Click(object sender, EventArgs e)
        {
            Ac_system frm = new Ac_system();
            this.Hide();
            if (frm.ShowDialog() != DialogResult.OK)
                Close();
        }

        private void to_monitor_Click(object sender, EventArgs e)
        {
            Monitor frm = new Monitor();
            this.Hide();
            if (frm.ShowDialog() != DialogResult.OK)
                Close();
        }

        private void to_scan_Click(object sender, EventArgs e)
        {
            Scaner frm = new Scaner();
            this.Hide();
            if (frm.ShowDialog() != DialogResult.OK)
                Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Computer frm = new Computer();
            this.Hide();
            if (frm.ShowDialog() != DialogResult.OK)
                Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Keyboard frm = new Keyboard();
            this.Hide();
            if (frm.ShowDialog() != DialogResult.OK)
                Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Mouse frm = new Mouse();
            this.Hide();
            if (frm.ShowDialog() != DialogResult.OK)
                Close();
        }

        private void Add_tehnica_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}