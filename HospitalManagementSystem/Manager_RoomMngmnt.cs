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
    public partial class Manager_RoomMngmnt : OfficeForm
    {
        RoomBL BL;
        public Manager_RoomMngmnt()
        {
            InitializeComponent();
            BL = new RoomBL();
        }

        private void Manager_RoomMngmnt_Load(object sender, EventArgs e)
        {
            this.Enabled = false;
            backgroundWorker1.RunWorkerAsync();
        }

        private void refresh()
        {
            var q = from a in BL.Read()
                    select new { a.Id, a.Location };
            dataGridView1.DataSource = q.ToList();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Room obj = new Room();
            obj.Location = textBoxX1.Text;
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

        private void buttonX5_Click(object sender, EventArgs e)
        {
            if (getValue(0) == null)
            {

            }
            else
            {
                Room obj = new Room();
                obj.Id = (int)getValue(0);
                obj.Location = textBoxX2.Text;
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

        private void superTabItem2_Click(object sender, EventArgs e)
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
                    Room obj = new Room();
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
