namespace LightStickRental
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "ATEEZ 二代手燈"}, 1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136))));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "BOYNEXTDOOR 手燈"}, 3, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136))));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "NEXZ 手燈"}, 5, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136))));
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Stray Kids 二代手燈"}, 6, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136))));
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "SEVENTEEN 三代手燈"}, 8, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136))));
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "TWS 手燈"}, 10, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136))));
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("TWICE 三代手燈", 9);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpRentalInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtRenterName = new System.Windows.Forms.TextBox();
            this.btnComfirm = new System.Windows.Forms.Button();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpChoose = new System.Windows.Forms.GroupBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageLists1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuChangeRent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.grpRentalInfo.SuspendLayout();
            this.grpChoose.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRentalInfo
            // 
            this.grpRentalInfo.Controls.Add(this.label1);
            this.grpRentalInfo.Controls.Add(this.txtDays);
            this.grpRentalInfo.Controls.Add(this.txtDate);
            this.grpRentalInfo.Controls.Add(this.txtRenterName);
            this.grpRentalInfo.Controls.Add(this.btnComfirm);
            this.grpRentalInfo.Controls.Add(this.lblDays);
            this.grpRentalInfo.Controls.Add(this.lblDate);
            this.grpRentalInfo.Controls.Add(this.lblName);
            this.grpRentalInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpRentalInfo.Font = new System.Drawing.Font("標楷體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpRentalInfo.Location = new System.Drawing.Point(384, 0);
            this.grpRentalInfo.Name = "grpRentalInfo";
            this.grpRentalInfo.Size = new System.Drawing.Size(451, 436);
            this.grpRentalInfo.TabIndex = 0;
            this.grpRentalInfo.TabStop = false;
            this.grpRentalInfo.Text = "2.填寫租借資料";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(17, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "(西元年/月/日)";
            // 
            // txtDays
            // 
            this.txtDays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDays.Location = new System.Drawing.Point(150, 242);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(254, 22);
            this.txtDays.TabIndex = 6;
            // 
            // txtDate
            // 
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDate.Location = new System.Drawing.Point(180, 156);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(224, 22);
            this.txtDate.TabIndex = 5;
            // 
            // txtRenterName
            // 
            this.txtRenterName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRenterName.Location = new System.Drawing.Point(158, 64);
            this.txtRenterName.Name = "txtRenterName";
            this.txtRenterName.Size = new System.Drawing.Size(246, 22);
            this.txtRenterName.TabIndex = 4;
            // 
            // btnComfirm
            // 
            this.btnComfirm.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnComfirm.Font = new System.Drawing.Font("標楷體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnComfirm.Location = new System.Drawing.Point(240, 321);
            this.btnComfirm.Name = "btnComfirm";
            this.btnComfirm.Size = new System.Drawing.Size(164, 39);
            this.btnComfirm.TabIndex = 3;
            this.btnComfirm.Text = "確認租借";
            this.btnComfirm.UseVisualStyleBackColor = false;
            this.btnComfirm.Click += new System.EventHandler(this.btnComfirm_Click);
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("標楷體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDays.Location = new System.Drawing.Point(17, 244);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(94, 18);
            this.lblDays.TabIndex = 2;
            this.lblDays.Text = "租借天數:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("標楷體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDate.Location = new System.Drawing.Point(17, 158);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(132, 18);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "預計租借日期:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("標楷體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblName.Location = new System.Drawing.Point(17, 66);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(113, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "租借者姓名:";
            // 
            // grpChoose
            // 
            this.grpChoose.Controls.Add(this.btnNext);
            this.grpChoose.Controls.Add(this.listView1);
            this.grpChoose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpChoose.Font = new System.Drawing.Font("標楷體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpChoose.Location = new System.Drawing.Point(0, 30);
            this.grpChoose.Name = "grpChoose";
            this.grpChoose.Size = new System.Drawing.Size(384, 406);
            this.grpChoose.TabIndex = 1;
            this.grpChoose.TabStop = false;
            this.grpChoose.Text = "1.選擇手燈";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Thistle;
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNext.Font = new System.Drawing.Font("標楷體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNext.Location = new System.Drawing.Point(3, 364);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(378, 39);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "我就要租這支手燈!!";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Info;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7});
            this.listView1.LargeImageList = this.imageLists1;
            this.listView1.Location = new System.Drawing.Point(3, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(378, 378);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // imageLists1
            // 
            this.imageLists1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageLists1.ImageStream")));
            this.imageLists1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageLists1.Images.SetKeyName(0, "ATZ1.jpg");
            this.imageLists1.Images.SetKeyName(1, "ATZ2.jpg");
            this.imageLists1.Images.SetKeyName(2, "BND1.jpg");
            this.imageLists1.Images.SetKeyName(3, "BND2.jpg");
            this.imageLists1.Images.SetKeyName(4, "NEXZ1.jpg");
            this.imageLists1.Images.SetKeyName(5, "NEXZ2.jpg");
            this.imageLists1.Images.SetKeyName(6, "SKZ.jpg");
            this.imageLists1.Images.SetKeyName(7, "SVT1.jpg");
            this.imageLists1.Images.SetKeyName(8, "SVT2.jpg");
            this.imageLists1.Images.SetKeyName(9, "TWICE.jpg");
            this.imageLists1.Images.SetKeyName(10, "TWS1.jpg");
            this.imageLists1.Images.SetKeyName(11, "TWS2.jpg");
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(286, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "系統功能(&S)";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuChangeRent,
            this.toolStripMenuItem2,
            this.tsmLogout});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(128, 24);
            this.toolStripMenuItem1.Text = "系統功能(&S)";
            // 
            // menuChangeRent
            // 
            this.menuChangeRent.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuChangeRent.Name = "menuChangeRent";
            this.menuChangeRent.Size = new System.Drawing.Size(224, 26);
            this.menuChangeRent.Text = "變更實時租金";
            this.menuChangeRent.Click += new System.EventHandler(this.menuChangeRent_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem2.Text = "查看歷史紀錄";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // tsmLogout
            // 
            this.tsmLogout.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tsmLogout.Name = "tsmLogout";
            this.tsmLogout.Size = new System.Drawing.Size(224, 26);
            this.tsmLogout.Text = "登出系統";
            this.tsmLogout.Click += new System.EventHandler(this.tsmLogout_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(835, 436);
            this.Controls.Add(this.grpChoose);
            this.Controls.Add(this.grpRentalInfo);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "韓團手燈租借";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpRentalInfo.ResumeLayout(false);
            this.grpRentalInfo.PerformLayout();
            this.grpChoose.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRentalInfo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtRenterName;
        private System.Windows.Forms.Button btnComfirm;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.GroupBox grpChoose;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageLists1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuChangeRent;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmLogout;
    }
}