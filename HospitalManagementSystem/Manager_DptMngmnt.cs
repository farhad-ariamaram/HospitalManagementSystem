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
    public partial class Manager_DptMngmnt : OfficeForm
    {
        DepartmentBL BL;
        public Manager_DptMngmnt()
        {
            InitializeComponent();
            BL = new DepartmentBL();
        }

        private void Manager_DptMngmnt_Load(object sender, EventArgs e)
        {
            this.Enabled = false;
            backgroundWorker1.RunWorkerAsync();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Department obj = new Department();
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

        public void refresh()
        {
            var q = from a in BL.Read()
                    select new { a.Id, a.Name };
            dataGridView1.DataSource = q.ToList();
        }

        private void superTabItem2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                labelX6.Text = getValue(1).ToString();
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
                labelX5.Text = getValue(1).ToString();
            }
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            if (getValue(0) == null)
            {

            }
            else
            {
                Department obj = new Department();
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

        private void superTabItem3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                labelX5.Text = getValue(1).ToString();
            }
            if (getValue(0) == null)
            {
                labelX5.Text = "";
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
                    Department obj = new Department();
                    obj.Id = (int)getValue(0);
                    BL.Delete(obj);
                    refresh();
                    if (dataGridView1.SelectedCells.Count > 0)
                    {
                        labelX5.Text = getValue(1).ToString();
                    }
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
