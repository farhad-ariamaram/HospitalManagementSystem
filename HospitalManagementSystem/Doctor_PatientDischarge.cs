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
    public partial class Doctor_PatientDischarge : OfficeForm
    {
        int DocId = Form3.DocId;
        PatientBL BL;
        DoctorBL DocBL;
        RoomBL RooBL;
        ReceptionistBL RecBL;
        PatientHistoryBL PaHiBL;
        public Doctor_PatientDischarge()
        {
            InitializeComponent();
            BL = new PatientBL();
            DocBL = new DoctorBL();
            RooBL = new RoomBL();
            RecBL = new ReceptionistBL();
            PaHiBL = new PatientHistoryBL();
        }
        private void refresh()
        {
            var q = from a in BL.Read()
                    join b in DocBL.Read() on a.DoctorId equals b.Id
                    join c in RooBL.Read() on a.RoomId equals c.Id
                    join d in RecBL.Read() on a.ReceptionistId equals d.Id
                    where (a.DoctorId == DocId)
                    select new { a.Id, Pname = a.Name, a.PhoneNo, a.Address, a.Age, a.Gender, DocName = b.Name, c.Location, RecName = d.Name };
            dataGridView1.DataSource = q.ToList();
        }

        private void Doctor_PatientDischarge_Load(object sender, EventArgs e)
        {
            this.Enabled = false;
            backgroundWorker1.RunWorkerAsync();
            if (dataGridView1.SelectedCells.Count > 0)
            {
                labelX4.Text = getValue(1).ToString();
            }
            else
            {
                labelX4.Text = "";
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
                labelX4.Text = "";
            }
            else
            {
                try
                {
                    Patient obj = new Patient();
                    obj.Id = (int)getValue(0);
                    BL.Delete(obj);
                    PatientsHistory patientHistoryObj = new PatientsHistory();
                    patientHistoryObj.Name = getValue(1).ToString();
                    patientHistoryObj.PhoneNo = getValue(2).ToString();
                    patientHistoryObj.Address = getValue(3).ToString();
                    patientHistoryObj.Age = Convert.ToInt32(getValue(4).ToString());
                    if (getValue(5).ToString().Equals("True"))
                    {
                        patientHistoryObj.Gender = true;
                    }
                    else
                    {
                        patientHistoryObj.Gender = false;
                    }
                    patientHistoryObj.DoctorName = getValue(6).ToString();
                    patientHistoryObj.RoomNo = getValue(7).ToString();
                    patientHistoryObj.ReceptionistName = getValue(8).ToString();
                    patientHistoryObj.Date = DateTime.Now;
                    PaHiBL.Create(patientHistoryObj);
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
