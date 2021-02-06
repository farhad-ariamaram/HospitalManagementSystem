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
    public partial class Manager_DocMngmnt : OfficeForm
    {
        DoctorBL BL;
        DepartmentBL DepBL;
        public Manager_DocMngmnt()
        {
            InitializeComponent();
            BL = new DoctorBL();
            DepBL = new DepartmentBL();
        }

        private void Manager_DocMngmnt_Load(object sender, EventArgs e)
        {
            this.Enabled = false;
            backgroundWorker1.RunWorkerAsync();
        }

        private void refresh()
        {
            var q = from a in BL.Read()
                    join b in DepBL.Read() on a.DepartmentId equals b.Id
                    select new { a.Id, a.Name, a.Special, a.PhoneNo, Dep = b.Name };
            dataGridView1.DataSource = q.ToList();

            comboBoxEx1.DataSource = DepBL.Read().Select(a => new { a.Id, a.Name }).ToList();
            comboBoxEx1.DisplayMember = "Name";
            comboBoxEx1.ValueMember = "Id";

            comboBoxEx2.DataSource = DepBL.Read().Select(a => new { a.Id, a.Name }).ToList();
            comboBoxEx2.DisplayMember = "Name";
            comboBoxEx2.ValueMember = "Id";
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (comboBoxEx1.SelectedValue != null)
            {
                Doctor obj = new Doctor();
                obj.DepartmentId = (int)comboBoxEx1.SelectedValue;
                obj.Name = textBoxX1.Text;
                obj.Special = textBoxX4.Text;
                obj.PhoneNo = textBoxX3.Text;
                try
                {
                    BL.Create(obj);
                    refresh();
                    textBoxX1.Text = "";
                    textBoxX3.Text = "";
                    textBoxX4.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "خطا");
                }
            }
            else
            {
                MessageBox.Show("ساختمان نمی‌تواند خالی باشد", "خطا");
            }
        }

        private void superTabItem2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                labelX6.Text = getValue(1).ToString();
                textBoxX6.Text = getValue(1).ToString();
                textBoxX2.Text = getValue(2).ToString();
                textBoxX5.Text = getValue(3).ToString();
                comboBoxEx2.SelectedIndex = comboBoxEx2.FindString(getValue(4).ToString());
            }
            if (getValue(0) == null)
            {
                labelX6.Text = "";
            }
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            if (getValue(0) == null)
            {

            }
            else
            {
                Doctor obj = new Doctor();
                obj.Id = (int)getValue(0);
                obj.Name = textBoxX6.Text;
                obj.Special = textBoxX2.Text;
                obj.PhoneNo = textBoxX5.Text;
                obj.DepartmentId = (int)comboBoxEx2.SelectedValue;
                try
                {
                    BL.Update(obj);
                    refresh();
                    labelX6.Text = getValue(1).ToString();
                    labelX4.Text = getValue(1).ToString();
                    textBoxX6.Text = getValue(1).ToString();
                    textBoxX2.Text = getValue(2).ToString();
                    textBoxX5.Text = getValue(3).ToString();
                    comboBoxEx2.SelectedIndex = comboBoxEx2.FindString(getValue(4).ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "خطا");
                }
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
                textBoxX6.Text = getValue(1).ToString();
                textBoxX2.Text = getValue(2).ToString();
                textBoxX5.Text = getValue(3).ToString();
                comboBoxEx2.SelectedIndex = comboBoxEx2.FindString(getValue(4).ToString());
            }
            else
            {
                labelX4.Text = "";
                textBoxX6.Text = "";
                textBoxX2.Text = "";
                textBoxX5.Text = "";
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
                    Doctor obj = new Doctor();
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
