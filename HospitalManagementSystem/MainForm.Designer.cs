
namespace HospitalManagementSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.mangerTile = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.doctorTile = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.receptionistTile = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.supportTile = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.aboutTile = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // itemPanel1
            // 
            this.itemPanel1.AutoScroll = true;
            this.itemPanel1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.itemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanel1.ContainerControlProcessDialogKey = true;
            this.itemPanel1.DragDropSupport = true;
            this.itemPanel1.ForeColor = System.Drawing.Color.Black;
            this.itemPanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
            this.itemPanel1.Location = new System.Drawing.Point(-5, 65);
            this.itemPanel1.Name = "itemPanel1";
            this.itemPanel1.ReserveLeftSpace = false;
            this.itemPanel1.Size = new System.Drawing.Size(563, 295);
            this.itemPanel1.TabIndex = 20;
            this.itemPanel1.Text = "itemPanel1";
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.ItemSpacing = 6;
            this.itemContainer1.MinimumSize = new System.Drawing.Size(560, 290);
            this.itemContainer1.MultiLine = true;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.ResizeItemsToFit = false;
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.mangerTile,
            this.doctorTile,
            this.receptionistTile,
            this.supportTile,
            this.aboutTile});
            // 
            // 
            // 
            this.itemContainer1.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // mangerTile
            // 
            this.mangerTile.Image = global::HospitalManagementSystem.Properties.Resources.Manager3;
            this.mangerTile.Name = "mangerTile";
            this.mangerTile.SymbolColor = System.Drawing.Color.Empty;
            this.mangerTile.Text = " <b><font size=\"+4\">مدیر</font></b>\r\n<br/>\r\n <b><font size=\"+4\">بیمارستان</font><" +
    "/b>";
            this.mangerTile.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            // 
            // 
            // 
            this.mangerTile.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.mangerTile.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(103)))), ((int)(((byte)(155)))));
            this.mangerTile.TileStyle.BackColorGradientAngle = 45;
            this.mangerTile.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mangerTile.TileStyle.PaddingBottom = 4;
            this.mangerTile.TileStyle.PaddingLeft = 4;
            this.mangerTile.TileStyle.PaddingRight = 4;
            this.mangerTile.TileStyle.PaddingTop = 4;
            this.mangerTile.TileStyle.TextColor = System.Drawing.Color.White;
            this.mangerTile.TitleText = "Hospital Manager";
            this.mangerTile.TitleTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mangerTile.Click += new System.EventHandler(this.mangerTile_Click);
            // 
            // doctorTile
            // 
            this.doctorTile.Image = global::HospitalManagementSystem.Properties.Resources.doctor;
            this.doctorTile.Name = "doctorTile";
            this.doctorTile.SymbolColor = System.Drawing.Color.Empty;
            this.doctorTile.Text = " <b><font size=\"+4\">پزشک</font></b>";
            this.doctorTile.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Green;
            // 
            // 
            // 
            this.doctorTile.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(151)))), ((int)(((byte)(42)))));
            this.doctorTile.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(177)))), ((int)(((byte)(51)))));
            this.doctorTile.TileStyle.BackColorGradientAngle = 45;
            this.doctorTile.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.doctorTile.TileStyle.PaddingBottom = 4;
            this.doctorTile.TileStyle.PaddingLeft = 4;
            this.doctorTile.TileStyle.PaddingRight = 4;
            this.doctorTile.TileStyle.PaddingTop = 4;
            this.doctorTile.TileStyle.TextColor = System.Drawing.Color.White;
            this.doctorTile.TitleText = "Doctor";
            this.doctorTile.TitleTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorTile.Click += new System.EventHandler(this.doctorTile_Click);
            // 
            // receptionistTile
            // 
            this.receptionistTile.Image = global::HospitalManagementSystem.Properties.Resources.receptionist;
            this.receptionistTile.Name = "receptionistTile";
            this.receptionistTile.SymbolColor = System.Drawing.Color.Empty;
            this.receptionistTile.Text = " <b><font size=\"+4\">مسئول</font></b>\r\n<br/>\r\n <b><font size=\"+4\">پذیرش</font></b>" +
    "";
            this.receptionistTile.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Coffee;
            // 
            // 
            // 
            this.receptionistTile.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.receptionistTile.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(136)))), ((int)(((byte)(0)))));
            this.receptionistTile.TileStyle.BackColorGradientAngle = 45;
            this.receptionistTile.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.receptionistTile.TileStyle.PaddingBottom = 4;
            this.receptionistTile.TileStyle.PaddingLeft = 4;
            this.receptionistTile.TileStyle.PaddingRight = 4;
            this.receptionistTile.TileStyle.PaddingTop = 4;
            this.receptionistTile.TileStyle.TextColor = System.Drawing.Color.White;
            this.receptionistTile.TitleText = "Receptionist";
            this.receptionistTile.TitleTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receptionistTile.Click += new System.EventHandler(this.receptionistTile_Click);
            // 
            // supportTile
            // 
            this.supportTile.Image = global::HospitalManagementSystem.Properties.Resources.Support2;
            this.supportTile.Name = "supportTile";
            this.supportTile.SymbolColor = System.Drawing.Color.Empty;
            this.supportTile.Text = " <b><font size=\"+4\">ارتباط با</font></b>\r\n<br/>\r\n <b><font size=\"+4\">پشتیبانی</fo" +
    "nt></b>";
            this.supportTile.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.RedViolet;
            // 
            // 
            // 
            this.supportTile.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.supportTile.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
            this.supportTile.TileStyle.BackColorGradientAngle = 45;
            this.supportTile.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.supportTile.TileStyle.PaddingBottom = 4;
            this.supportTile.TileStyle.PaddingLeft = 4;
            this.supportTile.TileStyle.PaddingRight = 4;
            this.supportTile.TileStyle.PaddingTop = 4;
            this.supportTile.TileStyle.TextColor = System.Drawing.Color.White;
            this.supportTile.TitleText = "Support";
            this.supportTile.TitleTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supportTile.Click += new System.EventHandler(this.supportTile_Click);
            // 
            // aboutTile
            // 
            this.aboutTile.Image = global::HospitalManagementSystem.Properties.Resources.aboutme1;
            this.aboutTile.Name = "aboutTile";
            this.aboutTile.SymbolColor = System.Drawing.Color.Empty;
            this.aboutTile.Text = " <b><font size=\"+4\">درباره</font></b>\r\n<br/>\r\n <b><font size=\"+4\">سازنده</font></" +
    "b>";
            this.aboutTile.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Teal;
            // 
            // 
            // 
            this.aboutTile.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(55)))), ((int)(((byte)(76)))));
            this.aboutTile.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.aboutTile.TileStyle.BackColorGradientAngle = 45;
            this.aboutTile.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.aboutTile.TileStyle.PaddingBottom = 4;
            this.aboutTile.TileStyle.PaddingLeft = 4;
            this.aboutTile.TileStyle.PaddingRight = 4;
            this.aboutTile.TileStyle.PaddingTop = 4;
            this.aboutTile.TileStyle.TextColor = System.Drawing.Color.White;
            this.aboutTile.TitleText = "About Me";
            this.aboutTile.TitleTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutTile.Click += new System.EventHandler(this.aboutTile_Click);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(12, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(546, 40);
            this.labelX1.TabIndex = 17;
            this.labelX1.Text = "نام بیمارستان";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 258);
            this.Controls.Add(this.itemPanel1);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سیستم مدیریت بیمارستان - نسخه 1.0.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ItemPanel itemPanel1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.Metro.MetroTileItem mangerTile;
        private DevComponents.DotNetBar.Metro.MetroTileItem doctorTile;
        private DevComponents.DotNetBar.Metro.MetroTileItem receptionistTile;
        private DevComponents.DotNetBar.Metro.MetroTileItem supportTile;
        private DevComponents.DotNetBar.Metro.MetroTileItem aboutTile;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}