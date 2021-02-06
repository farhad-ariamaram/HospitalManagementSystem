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
    public partial class Receptionist_PayBill : OfficeForm
    {
        int recId = Form2.RecId;
        BillBL BL;
        PatientBL patBL;
        ReceptionistBL recBL;
        BillsHistoryBL biHiBL;
        public Receptionist_PayBill()
        {
            InitializeComponent();
            BL = new BillBL();
            patBL = new PatientBL();
            recBL = new ReceptionistBL();
            biHiBL = new BillsHistoryBL();
        }

        private void Receptionist_PayBill_Load(object sender, EventArgs e)
        {
            this.Enabled = false;
            backgroundWorker1.RunWorkerAsync();
        }

        private void refresh()
        {
            var q = from a in BL.Read()
                    join b in patBL.Read() on a.PatientId equals b.Id
                    join c in recBL.Read() on a.ReceptionistId equals c.Id
                    where (a.ReceptionistId == recId)
                    select new { a.Id, a.BillNo, a.Amount, PName = b.Name, RName = c.Name };
            dataGridView1.DataSource = q.ToList();
            if (dataGridView1.SelectedCells.Count > 0)
            {
                labelX4.Text = getValue(1).ToString();
            }
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            this.Hide();
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
                labelX4.Text = getValue(1).ToString();
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
                    BillsHistory billHistoryObj = new BillsHistory();
                    billHistoryObj.Amount = getValue(2).ToString();
                    billHistoryObj.BillNo = getValue(1).ToString();
                    billHistoryObj.Date = DateTime.Now;
                    billHistoryObj.PatientName = getValue(3).ToString();
                    billHistoryObj.ReceptionistName = getValue(4).ToString();
                    biHiBL.Create(billHistoryObj);

                    BillFactor billFactor = new BillFactor();
                    billFactor.BillNo = billHistoryObj.BillNo;
                    billFactor.Amount = billHistoryObj.Amount;
                    billFactor.Date = billHistoryObj.Date;
                    billFactor.PatientName = billHistoryObj.PatientName;
                    billFactor.ReceptionistName = billHistoryObj.ReceptionistName;
                    Receptionist_PrintFactor frm = new Receptionist_PrintFactor(billFactor);
                    frm.ShowDialog();

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
