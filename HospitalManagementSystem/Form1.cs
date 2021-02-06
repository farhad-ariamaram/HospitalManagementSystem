using DevComponents.DotNetBar.Metro;
using HMSBussinesLogic;
using HMSDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void SettingsTile_Click(object sender, EventArgs e)
        {
            Manager_Settings mainForm = new Manager_Settings();
            mainForm.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            label2.Text = Informations.read().ManagerName;
            label3.Text = "بیمارستان " + Informations.read().HospitalName;
        }

        private void newInvoiceTile_Click(object sender, EventArgs e)
        {
            Manager_DptMngmnt frm = new Manager_DptMngmnt();
            frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newClientTile_Click(object sender, EventArgs e)
        {
            Manager_DocMngmnt frm = new Manager_DocMngmnt();
            frm.ShowDialog();
        }

        private void salesTile_Click(object sender, EventArgs e)
        {
            Manager_PtntMngmnt frm = new Manager_PtntMngmnt();
            frm.ShowDialog();
        }

        private void reportTile_Click(object sender, EventArgs e)
        {
            Manager_RoomMngmnt frm = new Manager_RoomMngmnt();
            frm.ShowDialog();
        }

        private void unpaidTile_Click(object sender, EventArgs e)
        {
            Manager_RsptnstMngmnt frm = new Manager_RsptnstMngmnt();
            frm.ShowDialog();
        }

        private void ytdTile_Click(object sender, EventArgs e)
        {
            Manager_BillMngmnt frm = new Manager_BillMngmnt();
            frm.ShowDialog();
        }
    }
}

