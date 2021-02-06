using DevComponents.DotNetBar.Metro;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace HospitalManagementSystem
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            if (!File.Exists("Info.xml"))
            {
                Informations.write("<نام بیمارستان>", "<نام مدیر>");
            }
        }

        private void mangerTile_Click(object sender, EventArgs e)
        {
            Form1 managerForm = new Form1();
            managerForm.Show();
            this.Hide();
        }

        private void doctorTile_Click(object sender, EventArgs e)
        {
            Form3 doctorForm = new Form3();
            doctorForm.Show();
            this.Hide();
        }

        private void receptionistTile_Click(object sender, EventArgs e)
        {
            Form2 recepForm = new Form2();
            recepForm.Show();
            this.Hide();
        }

        private void supportTile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/farhad-ariamaram/");
        }

        private void aboutTile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/farhad-ariamaram/");
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            labelX1.Text = "بیمارستان " + Informations.read().HospitalName;
        }
    }
}
