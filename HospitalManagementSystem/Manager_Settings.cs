using DevComponents.DotNetBar;
using System;
using System.IO;
using System.Xml.Serialization;

namespace HospitalManagementSystem
{
    public partial class Manager_Settings : OfficeForm
    {
        Informations info;

        public Manager_Settings()
        {
            InitializeComponent();
            info = Informations.read();
        }

        private void Manager_Settings_Shown(object sender, EventArgs e)
        {
            textBoxX1.Text = info.ManagerName;
            textBoxX2.Text = info.HospitalName;
        }

        private void buttonX2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonX1_Click_1(object sender, EventArgs e)
        {
            Informations.write(textBoxX2.Text, textBoxX1.Text);
            this.Hide();
        }

        private void textBoxX1_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = errorProvider1.GetError(textBoxX1);
        }

        private void textBoxX2_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = errorProvider1.GetError(textBoxX2);
        }

        private void Manager_Settings_Load(object sender, EventArgs e)
        {

        }
    }
}
