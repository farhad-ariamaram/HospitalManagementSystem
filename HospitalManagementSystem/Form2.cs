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
    public partial class Form2 : MetroForm
    {
        public static int RecId = -1;
        ReceptionistBL BL;
        public Form2()
        {
            InitializeComponent();
            BL = new ReceptionistBL();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void PatientRecTile_Click(object sender, EventArgs e)
        {
            if (RecId != -1)
            {
                Receptionist_PtntRcptn frm = new Receptionist_PtntRcptn();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("ابتدا یک پذیرش انتخاب کنید", "خطا");
            }

        }

        private void payBillTile_Click(object sender, EventArgs e)
        {
            if (RecId != -1)
            {
                Receptionist_PayBill frm = new Receptionist_PayBill();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("ابتدا یک پذیرش انتخاب کنید", "خطا");
            }
        }

        private void comboBoxEx1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RecId = (int)comboBoxEx1.SelectedValue;
            label2.Text = comboBoxEx1.Text;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            RecId = -1;
            this.Enabled = false;
            backgroundWorker1.RunWorkerAsync();
        }

        private void makeBillTile_Click(object sender, EventArgs e)
        {
            if (RecId != -1)
            {
                Receptionist_MakeBill frm = new Receptionist_MakeBill();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("ابتدا یک پذیرش انتخاب کنید", "خطا");
            }
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
