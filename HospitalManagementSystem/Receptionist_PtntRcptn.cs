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
    public partial class Receptionist_PtntRcptn : OfficeForm
    {
        int recId = Form2.RecId;
        PatientBL BL;
        DoctorBL DocBL;
        RoomBL RooBL;
        ReceptionistBL RecBL;
        public Receptionist_PtntRcptn()
        {
            InitializeComponent();
            BL = new PatientBL();
            DocBL = new DoctorBL();
            RooBL = new RoomBL();
            RecBL = new ReceptionistBL();
        }

        private void Receptionist_PtntRcptn_Load(object sender, EventArgs e)
        {
            this.Enabled = false;
            backgroundWorker1.RunWorkerAsync();
        }

        private void refresh()
        {
            var q = from a in BL.Read()
                    join b in DocBL.Read() on a.DoctorId equals b.Id
                    join c in RooBL.Read() on a.RoomId equals c.Id
                    join d in RecBL.Read() on a.ReceptionistId equals d.Id
                    where (a.ReceptionistId == recId)
                    select new { a.Id, Pname = a.Name, a.PhoneNo, a.Address, a.Age, a.Gender, DocName = b.Name, c.Location, RecName = d.Name };
            dataGridView1.DataSource = q.ToList();

            //doctors combos
            comboBoxEx5.DataSource = DocBL.Read().Select(a => new { a.Id, a.Name }).ToList();
            comboBoxEx5.DisplayMember = "Name";
            comboBoxEx5.ValueMember = "Id";
            comboBoxEx1.DataSource = DocBL.Read().Select(a => new { a.Id, a.Name }).ToList();
            comboBoxEx1.DisplayMember = "Name";
            comboBoxEx1.ValueMember = "Id";

            //rooms combos
            comboBoxEx2.DataSource = RooBL.Read().Select(a => new { a.Id, a.Location }).ToList();
            comboBoxEx2.DisplayMember = "Location";
            comboBoxEx2.ValueMember = "Id";
            comboBoxEx4.DataSource = RooBL.Read().Select(a => new { a.Id, a.Location }).ToList();
            comboBoxEx4.DisplayMember = "Location";
            comboBoxEx4.ValueMember = "Id";

            //receptionist combos
            comboBoxEx3.DataSource = RecBL.Read().Select(a => new { a.Id, a.Name }).Where(a => a.Id == recId).ToList();
            comboBoxEx3.DisplayMember = "Name";
            comboBoxEx3.ValueMember = "Id";
            comboBoxEx6.DataSource = RecBL.Read().Select(a => new { a.Id, a.Name }).Where(a => a.Id == recId).ToList();
            comboBoxEx6.DisplayMember = "Name";
            comboBoxEx6.ValueMember = "Id";

        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (comboBoxEx1.SelectedValue != null && comboBoxEx2.SelectedValue != null)
            {
                Patient obj = new Patient();
                obj.Name = textBoxX1.Text;
                obj.PhoneNo = textBoxX4.Text;
                obj.Address = textBoxX3.Text;
                obj.Age = (int)numericUpDown1.Value;
                obj.Gender = radioButton1.Checked ? true : false;
                obj.DoctorId = (int)comboBoxEx5.SelectedValue;
                obj.ReceptionistId = (int)comboBoxEx3.SelectedValue;
                obj.RoomId = (int)comboBoxEx4.SelectedValue;

                try
                {
                    BL.Create(obj);
                    refresh();
                    textBoxX1.Text = "";
                    textBoxX3.Text = "";
                    textBoxX4.Text = "";
                    numericUpDown1.Value = 0;
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

        private void superTabItem2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                labelX6.Text = getValue(1).ToString();
                textBoxX6.Text = getValue(1).ToString();
                textBoxX2.Text = getValue(2).ToString();
                textBoxX5.Text = getValue(3).ToString();
                numericUpDown2.Value = Convert.ToInt32(getValue(4).ToString());
                if (getValue(5).ToString().Equals("True"))
                {
                    radioButton4.Checked = true;
                }
                else
                {
                    radioButton3.Checked = true;
                }

                comboBoxEx1.SelectedIndex = comboBoxEx1.FindString(getValue(6).ToString());
                comboBoxEx2.SelectedIndex = comboBoxEx2.FindString(getValue(7).ToString());
                comboBoxEx6.SelectedIndex = comboBoxEx6.FindString(getValue(8).ToString());
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
                textBoxX6.Text = getValue(1).ToString();
                textBoxX2.Text = getValue(2).ToString();
                textBoxX5.Text = getValue(3).ToString();
                numericUpDown2.Value = Convert.ToInt32(getValue(4).ToString());
                if (getValue(5).ToString().Equals("True"))
                {
                    radioButton4.Checked = true;
                }
                else
                {
                    radioButton3.Checked = true;
                }

                comboBoxEx1.SelectedIndex = comboBoxEx1.FindString(getValue(6).ToString());
                comboBoxEx2.SelectedIndex = comboBoxEx2.FindString(getValue(7).ToString());
                comboBoxEx6.SelectedIndex = comboBoxEx6.FindString(getValue(8).ToString());
            }
        }

        private void superTabItem1_Click(object sender, EventArgs e)
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
                    Patient obj = new Patient();
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

        private void buttonX3_Click(object sender, EventArgs e)
        {
            if (getValue(0) == null)
            {

            }
            else
            {
                Patient obj = new Patient();
                obj.Id = (int)getValue(0);
                obj.Name = textBoxX6.Text;
                obj.PhoneNo = textBoxX2.Text;
                obj.Address = textBoxX5.Text;
                obj.Age = (int)numericUpDown2.Value;
                obj.Gender = radioButton4.Checked ? true : false;
                obj.DoctorId = (int)comboBoxEx1.SelectedValue;
                obj.ReceptionistId = (int)comboBoxEx6.SelectedValue;
                obj.RoomId = (int)comboBoxEx2.SelectedValue;
                try
                {
                    BL.Update(obj);
                    refresh();
                    textBoxX6.Text = "";
                    textBoxX2.Text = "";
                    textBoxX5.Text = "";
                    numericUpDown2.Value = 0;
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
