using DevComponents.DotNetBar.Metro;
using HMSBussinesLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class Form3 : MetroForm
    {
        public static int DocId = -1;
        DoctorBL BL;
        public Form3()
        {
            InitializeComponent();
            BL = new DoctorBL();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DocId = -1;
            this.Enabled = false;
            backgroundWorker1.RunWorkerAsync();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void PatientDischargeTile_Click(object sender, EventArgs e)
        {
            if (DocId != -1)
            {
                Doctor_PatientDischarge frm = new Doctor_PatientDischarge();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("ابتدا یک پزشک انتخاب کنید", "خطا");
            }
        }

        private void comboBoxEx1_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            DocId = (int)comboBoxEx1.SelectedValue;
            label2.Text = comboBoxEx1.Text;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate () {
                label3.Text = "بیمارستان " + Informations.read().HospitalName;
                comboBoxEx1.DataSource = BL.Read().Select(a => new { a.Id, a.Name }).ToList();
                comboBoxEx1.DisplayMember = "Name";
                comboBoxEx1.ValueMember = "Id";
                comboBoxEx1.SelectedValue = -1;
            }));
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Enabled = true;
        }

    }
}
