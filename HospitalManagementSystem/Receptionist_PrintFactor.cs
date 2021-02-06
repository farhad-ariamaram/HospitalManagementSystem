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
    public partial class Receptionist_PrintFactor : Form
    {
        public Receptionist_PrintFactor(object obj)
        {
            InitializeComponent();
            BillFactorBindingSource.DataSource = obj;
        }

        private void Reseptionist_PrintFactor_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
