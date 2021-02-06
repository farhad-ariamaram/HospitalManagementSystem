
namespace HospitalManagementSystem
{
    partial class Form3
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
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.PatientDischargeTile = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.back = new DevComponents.DotNetBar.ButtonX();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.itemPanel1.Location = new System.Drawing.Point(7, 65);
            this.itemPanel1.Name = "itemPanel1";
            this.itemPanel1.ReserveLeftSpace = false;
            this.itemPanel1.Size = new System.Drawing.Size(563, 106);
            this.itemPanel1.TabIndex = 15;
            this.itemPanel1.Text = "itemPanel1";
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.FixedSize = new System.Drawing.Size(0, 100);
            this.itemContainer1.ItemSpacing = 6;
            this.itemContainer1.MinimumSize = new System.Drawing.Size(560, 100);
            this.itemContainer1.MultiLine = true;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.ResizeItemsToFit = false;
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.PatientDischargeTile});
            // 
            // 
            // 
            this.itemContainer1.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // PatientDischargeTile
            // 
            this.PatientDischargeTile.Image = global::HospitalManagementSystem.Properties.Resources.cure;
            this.PatientDischargeTile.Name = "PatientDischargeTile";
            this.PatientDischargeTile.SymbolColor = System.Drawing.Color.Empty;
            this.PatientDischargeTile.Text = " <b><font size=\"+4\">ترخیص</font></b>\r\n<br/>\r\n <b><font size=\"+4\">بیمار</font></b>" +
    "";
            this.PatientDischargeTile.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Green;
            // 
            // 
            // 
            this.PatientDischargeTile.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(151)))), ((int)(((byte)(42)))));
            this.PatientDischargeTile.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(177)))), ((int)(((byte)(51)))));
            this.PatientDischargeTile.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.PatientDischargeTile.TitleText = "Patient Discharge";
            this.PatientDischargeTile.TitleTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.PatientDischargeTile.Click += new System.EventHandler(this.PatientDischargeTile_Click);
            // 
            // labelItem1
            // 
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "labelItem1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::HospitalManagementSystem.Properties.Resources.User3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ForeColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(526, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 33);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // back
            // 
            this.back.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.back.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.back.HoverImage = global::HospitalManagementSystem.Properties.Resources.backhover;
            this.back.Image = global::HospitalManagementSystem.Properties.Resources.back;
            this.back.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.back.Location = new System.Drawing.Point(18, 177);
            this.back.Name = "back";
            this.back.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.back.Size = new System.Drawing.Size(50, 50);
            this.back.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.back.TabIndex = 20;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(495, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "پزشک:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "نام بیمارستان";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(311, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "نام پزشک";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(483, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "پزشک";
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.DisplayMember = "Text";
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEx1.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEx1.FormattingEnabled = true;
            this.comboBoxEx1.ItemHeight = 15;
            this.comboBoxEx1.Location = new System.Drawing.Point(360, 193);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxEx1.Size = new System.Drawing.Size(129, 21);
            this.comboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx1.TabIndex = 23;
            this.comboBoxEx1.SelectionChangeCommitted += new System.EventHandler(this.comboBoxEx1_SelectionChangeCommitted_1);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 240);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxEx1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.itemPanel1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پزشک";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ItemPanel itemPanel1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.Metro.MetroTileItem PatientDischargeTile;
        private DevComponents.DotNetBar.ButtonX back;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}