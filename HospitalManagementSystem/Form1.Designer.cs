
namespace HospitalManagementSystem
{
    partial class Form1
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
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.newInvoiceTile = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.newClientTile = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.salesTile = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.reportTile = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.unpaidTile = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.ytdTile = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.SettingsTile = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.back = new DevComponents.DotNetBar.ButtonX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelItem1
            // 
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "labelItem1";
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
            this.itemPanel1.Location = new System.Drawing.Point(1, 65);
            this.itemPanel1.Name = "itemPanel1";
            this.itemPanel1.ReserveLeftSpace = false;
            this.itemPanel1.Size = new System.Drawing.Size(563, 295);
            this.itemPanel1.TabIndex = 11;
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
            this.newInvoiceTile,
            this.newClientTile,
            this.salesTile,
            this.reportTile,
            this.unpaidTile,
            this.ytdTile,
            this.SettingsTile});
            // 
            // 
            // 
            this.itemContainer1.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // newInvoiceTile
            // 
            this.newInvoiceTile.Image = global::HospitalManagementSystem.Properties.Resources.department;
            this.newInvoiceTile.Name = "newInvoiceTile";
            this.newInvoiceTile.SymbolColor = System.Drawing.Color.Empty;
            this.newInvoiceTile.Text = " <b><font size=\"+4\">مدیریت</font></b>\r\n<br/>\r\n <b><font size=\"+4\">ساختمان‌ها</fon" +
    "t></b>";
            this.newInvoiceTile.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            // 
            // 
            // 
            this.newInvoiceTile.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.newInvoiceTile.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(103)))), ((int)(((byte)(155)))));
            this.newInvoiceTile.TileStyle.BackColorGradientAngle = 45;
            this.newInvoiceTile.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.newInvoiceTile.TileStyle.PaddingBottom = 4;
            this.newInvoiceTile.TileStyle.PaddingLeft = 4;
            this.newInvoiceTile.TileStyle.PaddingRight = 4;
            this.newInvoiceTile.TileStyle.PaddingTop = 4;
            this.newInvoiceTile.TileStyle.TextColor = System.Drawing.Color.White;
            this.newInvoiceTile.TitleText = "Departments";
            this.newInvoiceTile.TitleTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newInvoiceTile.Click += new System.EventHandler(this.newInvoiceTile_Click);
            // 
            // newClientTile
            // 
            this.newClientTile.Image = global::HospitalManagementSystem.Properties.Resources.doctor;
            this.newClientTile.Name = "newClientTile";
            this.newClientTile.SymbolColor = System.Drawing.Color.Empty;
            this.newClientTile.Text = " <b><font size=\"+4\">مدیریت</font></b>\r\n<br/>\r\n <b><font size=\"+4\">پزشک‌ها</font><" +
    "/b>";
            this.newClientTile.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Green;
            // 
            // 
            // 
            this.newClientTile.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(151)))), ((int)(((byte)(42)))));
            this.newClientTile.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(177)))), ((int)(((byte)(51)))));
            this.newClientTile.TileStyle.BackColorGradientAngle = 45;
            this.newClientTile.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.newClientTile.TileStyle.PaddingBottom = 4;
            this.newClientTile.TileStyle.PaddingLeft = 4;
            this.newClientTile.TileStyle.PaddingRight = 4;
            this.newClientTile.TileStyle.PaddingTop = 4;
            this.newClientTile.TileStyle.TextColor = System.Drawing.Color.White;
            this.newClientTile.TitleText = "Doctors";
            this.newClientTile.TitleTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newClientTile.Click += new System.EventHandler(this.newClientTile_Click);
            // 
            // salesTile
            // 
            this.salesTile.Image = global::HospitalManagementSystem.Properties.Resources.patient;
            this.salesTile.Name = "salesTile";
            this.salesTile.SymbolColor = System.Drawing.Color.Empty;
            this.salesTile.Text = " <b><font size=\"+4\">مدیریت</font></b>\r\n<br/>\r\n <b><font size=\"+4\">بیماران</font><" +
    "/b>";
            this.salesTile.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Coffee;
            // 
            // 
            // 
            this.salesTile.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.salesTile.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(67)))), ((int)(((byte)(37)))));
            this.salesTile.TileStyle.BackColorGradientAngle = 45;
            this.salesTile.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.salesTile.TileStyle.PaddingBottom = 4;
            this.salesTile.TileStyle.PaddingLeft = 4;
            this.salesTile.TileStyle.PaddingRight = 4;
            this.salesTile.TileStyle.PaddingTop = 4;
            this.salesTile.TileStyle.TextColor = System.Drawing.Color.White;
            this.salesTile.TitleText = "Patients";
            this.salesTile.TitleTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesTile.Click += new System.EventHandler(this.salesTile_Click);
            // 
            // reportTile
            // 
            this.reportTile.Image = global::HospitalManagementSystem.Properties.Resources.room;
            this.reportTile.Name = "reportTile";
            this.reportTile.SymbolColor = System.Drawing.Color.Empty;
            this.reportTile.Text = " <b><font size=\"+4\">مدیریت</font></b>\r\n<br/>\r\n <b><font size=\"+4\">اتاق‌ها</font><" +
    "/b>";
            this.reportTile.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange;
            // 
            // 
            // 
            this.reportTile.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.reportTile.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(136)))), ((int)(((byte)(0)))));
            this.reportTile.TileStyle.BackColorGradientAngle = 45;
            this.reportTile.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reportTile.TileStyle.PaddingBottom = 4;
            this.reportTile.TileStyle.PaddingLeft = 4;
            this.reportTile.TileStyle.PaddingRight = 4;
            this.reportTile.TileStyle.PaddingTop = 4;
            this.reportTile.TileStyle.TextColor = System.Drawing.Color.White;
            this.reportTile.TitleText = "Rooms";
            this.reportTile.TitleTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportTile.Click += new System.EventHandler(this.reportTile_Click);
            // 
            // unpaidTile
            // 
            this.unpaidTile.Image = global::HospitalManagementSystem.Properties.Resources.receptionist;
            this.unpaidTile.Name = "unpaidTile";
            this.unpaidTile.SymbolColor = System.Drawing.Color.Empty;
            this.unpaidTile.Text = " <b><font size=\"+4\">مدیریت</font></b>\r\n<br/>\r\n <b><font size=\"+4\">پذیرش‌ها</font>" +
    "</b>";
            this.unpaidTile.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.RedOrange;
            // 
            // 
            // 
            this.unpaidTile.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.unpaidTile.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(57)))), ((int)(((byte)(0)))));
            this.unpaidTile.TileStyle.BackColorGradientAngle = 45;
            this.unpaidTile.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.unpaidTile.TileStyle.PaddingBottom = 4;
            this.unpaidTile.TileStyle.PaddingLeft = 4;
            this.unpaidTile.TileStyle.PaddingRight = 4;
            this.unpaidTile.TileStyle.PaddingTop = 4;
            this.unpaidTile.TileStyle.TextColor = System.Drawing.Color.White;
            this.unpaidTile.TitleText = "Receptionists";
            this.unpaidTile.TitleTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unpaidTile.Click += new System.EventHandler(this.unpaidTile_Click);
            // 
            // ytdTile
            // 
            this.ytdTile.Image = global::HospitalManagementSystem.Properties.Resources.bill;
            this.ytdTile.Name = "ytdTile";
            this.ytdTile.SymbolColor = System.Drawing.Color.Empty;
            this.ytdTile.Text = " <b><font size=\"+4\">مدیریت</font></b>\r\n<br/>\r\n <b><font size=\"+4\">قبض‌ها</font></" +
    "b>";
            this.ytdTile.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Magenta;
            // 
            // 
            // 
            this.ytdTile.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(85)))), ((int)(((byte)(148)))));
            this.ytdTile.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(98)))), ((int)(((byte)(185)))));
            this.ytdTile.TileStyle.BackColorGradientAngle = 45;
            this.ytdTile.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ytdTile.TileStyle.PaddingBottom = 4;
            this.ytdTile.TileStyle.PaddingLeft = 4;
            this.ytdTile.TileStyle.PaddingRight = 4;
            this.ytdTile.TileStyle.PaddingTop = 4;
            this.ytdTile.TileStyle.TextColor = System.Drawing.Color.White;
            this.ytdTile.TitleText = "Bills";
            this.ytdTile.TitleTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ytdTile.Click += new System.EventHandler(this.ytdTile_Click);
            // 
            // SettingsTile
            // 
            this.SettingsTile.Image = global::HospitalManagementSystem.Properties.Resources.Support;
            this.SettingsTile.Name = "SettingsTile";
            this.SettingsTile.SymbolColor = System.Drawing.Color.Empty;
            this.SettingsTile.Text = " <b><font size=\"+4\">تنظیمات</font></b>\r\n<br/>\r\n <b><font size=\"+4\">نرم‌افزار</fon" +
    "t></b>\r\n";
            this.SettingsTile.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blue;
            // 
            // 
            // 
            this.SettingsTile.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(102)))), ((int)(((byte)(168)))));
            this.SettingsTile.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.SettingsTile.TileStyle.BackColorGradientAngle = 45;
            this.SettingsTile.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SettingsTile.TileStyle.PaddingBottom = 4;
            this.SettingsTile.TileStyle.PaddingLeft = 4;
            this.SettingsTile.TileStyle.PaddingRight = 4;
            this.SettingsTile.TileStyle.PaddingTop = 4;
            this.SettingsTile.TileStyle.TextColor = System.Drawing.Color.White;
            this.SettingsTile.TitleText = "Settings";
            this.SettingsTile.TitleTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsTile.Click += new System.EventHandler(this.SettingsTile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(477, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "مدیر";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(250, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "نام مدیر";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "نام بیمارستان";
            // 
            // back
            // 
            this.back.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.back.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.back.HoverImage = global::HospitalManagementSystem.Properties.Resources.backhover;
            this.back.Image = global::HospitalManagementSystem.Properties.Resources.back;
            this.back.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.back.Location = new System.Drawing.Point(12, 358);
            this.back.Name = "back";
            this.back.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.back.Size = new System.Drawing.Size(50, 50);
            this.back.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.back.TabIndex = 12;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::HospitalManagementSystem.Properties.Resources.User3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ForeColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(518, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 33);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 415);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.itemPanel1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت بیمارستان";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.ItemPanel itemPanel1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.Metro.MetroTileItem newInvoiceTile;
        private DevComponents.DotNetBar.Metro.MetroTileItem newClientTile;
        private DevComponents.DotNetBar.Metro.MetroTileItem salesTile;
        private DevComponents.DotNetBar.Metro.MetroTileItem reportTile;
        private DevComponents.DotNetBar.Metro.MetroTileItem unpaidTile;
        private DevComponents.DotNetBar.Metro.MetroTileItem ytdTile;
        private DevComponents.DotNetBar.Metro.MetroTileItem SettingsTile;
        private DevComponents.DotNetBar.ButtonX back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

