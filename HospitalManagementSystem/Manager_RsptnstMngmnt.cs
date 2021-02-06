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
    public partial class Manager_RsptnstMngmnt : OfficeForm
    {
        ReceptionistBL BL;
        public Manager_RsptnstMngmnt()
        {
            InitializeComponent();
            BL = new ReceptionistBL();
        }

        private void Manager_RsptnstMngmnt_Load(object sender, EventArgs e)
        {
            this.Enabled = false;
            backgroundWorker1.RunWorkerAsync();
        }

        private void refresh()
        {
            var q = from a in BL.Read()
                    select new { a.Id, a.Name };
            dataGridView1.DataSource = q.ToList();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonX1_Click_1(object sender, EventArgs e)
        {
            Receptionist obj = new Receptionist();
            obj.Name = textBoxX1.Text;
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

        private void buttonX5_Click_1(object sender, EventArgs e)
        {
            if (getValue(0) == null)
            {

            }
            else
            {
                Receptionist obj = new Receptionist();
                obj.Id = (int)getValue(0);
                obj.Name = textBoxX2.Text;
                try
                {
                    BL.Update(obj);
                    refresh();
                    textBoxX2.Text = "";
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

        private void superTabItem6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                labelX6.Text = getValue(1).ToString();
                textBoxX2.Text = getValue(1).ToString();
            }
            if (getValue(0) == null)
            {
                labelX6.Text = "";
            }
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                labelX6.Text = getValue(1).ToString();
                labelX4.Text = getValue(1).ToString();
                textBoxX2.Text = getValue(1).ToString();
            }
        }

        private void buttonX2_Click_1(object sender, EventArgs e)
        {
            if (getValue(0) == null)
            {

            }
            else
            {
                try
                {
                    Receptionist obj = new Receptionist();
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

        private void superTabItem5_Click(object sender, EventArgs e)
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
