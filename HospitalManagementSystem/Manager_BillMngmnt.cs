using DevComponents.DotNetBar;
using HMSBussinesLogic;
using HMSDataLayer;
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
    public partial class Manager_BillMngmnt : OfficeForm
    {
        BillBL BL;
        PatientBL patBL;
        ReceptionistBL recBL;

        public Manager_BillMngmnt()
        {
            InitializeComponent();
            BL = new BillBL();
            patBL = new PatientBL();
            recBL = new ReceptionistBL();
        }

        private void Manager_BillMngmnt_Load(object sender, EventArgs e)
        {
            this.Enabled = false;
            backgroundWorker1.RunWorkerAsync();
        }

        private void refresh()
        {
            textBoxX3.Text = RandomString(7);
            var q = from a in BL.Read()
                    join b in patBL.Read() on a.PatientId equals b.Id
                    join c in recBL.Read() on a.ReceptionistId equals c.Id
                    select new { a.Id, a.BillNo, a.Amount, PName = b.Name, RName = c.Name };
            dataGridView1.DataSource = q.ToList();

            //Patients Combos
            comboBoxEx1.DataSource = patBL.Read().Select(a => new { a.Id, a.Name }).ToList();
            comboBoxEx1.DisplayMember = "Name";
            comboBoxEx1.ValueMember = "Id";
            comboBoxEx4.DataSource = patBL.Read().Select(a => new { a.Id, a.Name }).ToList();
            comboBoxEx4.DisplayMember = "Name";
            comboBoxEx4.ValueMember = "Id";

            //Receptionist Combos
            comboBoxEx2.DataSource = recBL.Read().Select(a => new { a.Id, a.Name }).ToList();
            comboBoxEx2.DisplayMember = "Name";
            comboBoxEx2.ValueMember = "Id";
            comboBoxEx3.DataSource = recBL.Read().Select(a => new { a.Id, a.Name }).ToList();
            comboBoxEx3.DisplayMember = "Name";
            comboBoxEx3.ValueMember = "Id";
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (comboBoxEx1.SelectedValue != null && comboBoxEx2.SelectedValue != null)
            {
                Bill obj = new Bill();
                obj.BillNo = textBoxX3.Text;
                obj.Amount = textBoxX1.Text;
                obj.PatientId = (int)comboBoxEx1.SelectedValue;
                obj.ReceptionistId = (int)comboBoxEx2.SelectedValue;

                try
                {
                    BL.Create(obj);
                    refresh();
                    textBoxX1.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "خطا");
                }
            }
            else
            {
                MessageBox.Show("همه فیلد ها را تکمیل کنید", "خطا");
            }

        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void superTabItem2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                labelX6.Text = getValue(1).ToString();
                textBoxX2.Text = getValue(1).ToString();
                textBoxX4.Text = getValue(2).ToString();
                comboBoxEx4.SelectedIndex = comboBoxEx4.FindString(getValue(3).ToString());
                comboBoxEx3.SelectedIndex = comboBoxEx3.FindString(getValue(4).ToString());
            }
            if (getValue(0) == null)
            {
                labelX6.Text = "";
            }
        }

        private object getValue(int rowNo)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                return dataGridView1.CurrentRow.Cells[rowNo].Value;
            }
            return null;
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                labelX6.Text = getValue(1).ToString();
                labelX4.Text = getValue(1).ToString();
                textBoxX2.Text = getValue(1).ToString();
                textBoxX4.Text = getValue(2).ToString();
                comboBoxEx4.SelectedIndex = comboBoxEx4.FindString(getValue(3).ToString());
                comboBoxEx3.SelectedIndex = comboBoxEx3.FindString(getValue(4).ToString());
            }
        }

        private void superTabItem3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                labelX4.Text = getValue(1).ToString();
            }
            if (getValue(0) == null)
            {
                labelX4.Text = "";
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (getValue(0) == null)
            {

            }
            else
            {
                try
                {
                    Bill obj = new Bill();
                    obj.Id = (int)getValue(0);
                    BL.Delete(obj);
                    refresh();
                    if (dataGridView1.SelectedCells.Count > 0)
                    {
                        labelX4.Text = getValue(1).ToString();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "خطا");
                }

            }
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            if (getValue(0) == null)
            {

            }
            else
            {
                Bill obj = new Bill();
                obj.Id = (int)getValue(0);
                obj.BillNo = textBoxX2.Text;
                obj.Amount = textBoxX4.Text;
                obj.PatientId = (int)comboBoxEx4.SelectedValue;
                obj.ReceptionistId = (int)comboBoxEx3.SelectedValue;
                try
                {
                    BL.Update(obj);
                    refresh();
                    textBoxX2.Text = "";
                    textBoxX4.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "خطا");
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate () {
                refresh();
            }));
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Enabled = true;
        }
    }
}
