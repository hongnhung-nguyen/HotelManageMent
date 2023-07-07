
namespace src.GUI
{
    partial class MainBookingGUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_XemPhong = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_TTPhong = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_GiaMax = new System.Windows.Forms.ComboBox();
            this.comboBox_GiaMin = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_LoaiPhong = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDatPhong = new System.Windows.Forms.Button();
            this.textBox_TinhTrang_TTP = new System.Windows.Forms.TextBox();
            this.button_XemChiTiet = new System.Windows.Forms.Button();
            this.textBoxMaPhong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.button_XemPhong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox_TTPhong);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox_GiaMax);
            this.groupBox1.Controls.Add(this.comboBox_GiaMin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_LoaiPhong);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 223);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc Thông Tin ****";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button_XemPhong
            // 
            this.button_XemPhong.Location = new System.Drawing.Point(247, 153);
            this.button_XemPhong.Name = "button_XemPhong";
            this.button_XemPhong.Size = new System.Drawing.Size(258, 37);
            this.button_XemPhong.TabIndex = 8;
            this.button_XemPhong.Text = "Xem Phòng";
            this.button_XemPhong.UseVisualStyleBackColor = true;
            this.button_XemPhong.Click += new System.EventHandler(this.button_XemPhong_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tình Trạng";
            // 
            // comboBox_TTPhong
            // 
            this.comboBox_TTPhong.FormattingEnabled = true;
            this.comboBox_TTPhong.Location = new System.Drawing.Point(127, 30);
            this.comboBox_TTPhong.Name = "comboBox_TTPhong";
            this.comboBox_TTPhong.Size = new System.Drawing.Size(222, 28);
            this.comboBox_TTPhong.TabIndex = 9;
            this.comboBox_TTPhong.Text = "All";
            this.comboBox_TTPhong.SelectedIndexChanged += new System.EventHandler(this.comboBox_TTPhong_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đến";
            // 
            // comboBox_GiaMax
            // 
            this.comboBox_GiaMax.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.comboBox_GiaMax.FormattingEnabled = true;
            this.comboBox_GiaMax.Items.AddRange(new object[] {
            "100000",
            "300000",
            "400000",
            "600000",
            "800000",
            "1000000",
            "15000000",
            "20000000",
            "25000000",
            "50000000"});
            this.comboBox_GiaMax.Location = new System.Drawing.Point(481, 91);
            this.comboBox_GiaMax.Name = "comboBox_GiaMax";
            this.comboBox_GiaMax.Size = new System.Drawing.Size(196, 28);
            this.comboBox_GiaMax.TabIndex = 5;
            // 
            // comboBox_GiaMin
            // 
            this.comboBox_GiaMin.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.comboBox_GiaMin.FormattingEnabled = true;
            this.comboBox_GiaMin.Items.AddRange(new object[] {
            "100000",
            "300000",
            "400000",
            "500000",
            "700000",
            "1000000",
            "2000000"});
            this.comboBox_GiaMin.Location = new System.Drawing.Point(127, 93);
            this.comboBox_GiaMin.Name = "comboBox_GiaMin";
            this.comboBox_GiaMin.Size = new System.Drawing.Size(222, 28);
            this.comboBox_GiaMin.TabIndex = 3;
            this.comboBox_GiaMin.Text = "0";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mức giá";
            // 
            // comboBox_LoaiPhong
            // 
            this.comboBox_LoaiPhong.FormattingEnabled = true;
            this.comboBox_LoaiPhong.Items.AddRange(new object[] {
            "Standard",
            "Superior",
            "Deluxe",
            "Suit"});
            this.comboBox_LoaiPhong.Location = new System.Drawing.Point(481, 30);
            this.comboBox_LoaiPhong.Name = "comboBox_LoaiPhong";
            this.comboBox_LoaiPhong.Size = new System.Drawing.Size(196, 28);
            this.comboBox_LoaiPhong.TabIndex = 1;
            this.comboBox_LoaiPhong.Text = "All";
            this.comboBox_LoaiPhong.SelectedIndexChanged += new System.EventHandler(this.comboBox_LoaiPhong_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại Phòng";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.buttonDatPhong);
            this.groupBox2.Controls.Add(this.textBox_TinhTrang_TTP);
            this.groupBox2.Controls.Add(this.button_XemChiTiet);
            this.groupBox2.Controls.Add(this.textBoxMaPhong);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(708, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 223);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Phòng";
            // 
            // buttonDatPhong
            // 
            this.buttonDatPhong.Location = new System.Drawing.Point(276, 153);
            this.buttonDatPhong.Name = "buttonDatPhong";
            this.buttonDatPhong.Size = new System.Drawing.Size(175, 37);
            this.buttonDatPhong.TabIndex = 17;
            this.buttonDatPhong.Text = "Đặt Phòng";
            this.buttonDatPhong.UseVisualStyleBackColor = true;
            this.buttonDatPhong.Click += new System.EventHandler(this.buttonDatPhong_Click);
            // 
            // textBox_TinhTrang_TTP
            // 
            this.textBox_TinhTrang_TTP.Location = new System.Drawing.Point(151, 90);
            this.textBox_TinhTrang_TTP.Name = "textBox_TinhTrang_TTP";
            this.textBox_TinhTrang_TTP.Size = new System.Drawing.Size(300, 26);
            this.textBox_TinhTrang_TTP.TabIndex = 16;
            // 
            // button_XemChiTiet
            // 
            this.button_XemChiTiet.Location = new System.Drawing.Point(37, 153);
            this.button_XemChiTiet.Name = "button_XemChiTiet";
            this.button_XemChiTiet.Size = new System.Drawing.Size(175, 37);
            this.button_XemChiTiet.TabIndex = 11;
            this.button_XemChiTiet.Text = "Thông Tin Đặt Phòng";
            this.button_XemChiTiet.UseVisualStyleBackColor = true;
            this.button_XemChiTiet.Click += new System.EventHandler(this.button_XemChiTiet_Click);
            // 
            // textBoxMaPhong
            // 
            this.textBoxMaPhong.Location = new System.Drawing.Point(151, 33);
            this.textBoxMaPhong.Name = "textBoxMaPhong";
            this.textBoxMaPhong.Size = new System.Drawing.Size(300, 26);
            this.textBoxMaPhong.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tình Trạng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mã Phòng";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 240);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(1192, 498);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // MainBookingGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 750);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(100, 100);
            this.MaximumSize = new System.Drawing.Size(1239, 806);
            this.MinimumSize = new System.Drawing.Size(1239, 806);
            this.Name = "MainBookingGUI";
            this.Text = "BookingGUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainBookingGUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_TTPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_GiaMax;
        private System.Windows.Forms.ComboBox comboBox_GiaMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_LoaiPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_XemPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_TinhTrang_TTP;
        private System.Windows.Forms.Button button_XemChiTiet;
        private System.Windows.Forms.TextBox textBoxMaPhong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonDatPhong;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}