
namespace src.GUI
{
    partial class BookingGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingGUI));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimeNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox_GioTinh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_DichVu = new System.Windows.Forms.Button();
            this.button_NhanPhong = new System.Windows.Forms.Button();
            this.button_CheckTT_KH = new System.Windows.Forms.Button();
            this.txCMNN = new System.Windows.Forms.TextBox();
            this.txt_tenKH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Gmail = new System.Windows.Forms.TextBox();
            this.textBox_DiaChi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textSdt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateRa = new System.Windows.Forms.DateTimePicker();
            this.dateVao = new System.Windows.Forms.DateTimePicker();
            this.tx_maphong = new System.Windows.Forms.TextBox();
            this.tb_giaPhong = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.dateTimeNgaySinh);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.comboBox_GioTinh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_DichVu);
            this.groupBox1.Controls.Add(this.button_NhanPhong);
            this.groupBox1.Controls.Add(this.button_CheckTT_KH);
            this.groupBox1.Controls.Add(this.txCMNN);
            this.groupBox1.Controls.Add(this.txt_tenKH);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_Gmail);
            this.groupBox1.Controls.Add(this.textBox_DiaChi);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textSdt);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.dateRa);
            this.groupBox1.Controls.Add(this.dateVao);
            this.groupBox1.Controls.Add(this.tx_maphong);
            this.groupBox1.Controls.Add(this.tb_giaPhong);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(937, 602);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Đặt Phòng";
            //this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dateTimeNgaySinh
            // 
            this.dateTimeNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNgaySinh.Location = new System.Drawing.Point(398, 272);
            this.dateTimeNgaySinh.Name = "dateTimeNgaySinh";
            this.dateTimeNgaySinh.Size = new System.Drawing.Size(486, 26);
            this.dateTimeNgaySinh.TabIndex = 70;
            this.dateTimeNgaySinh.Value = new System.DateTime(2001, 1, 31, 0, 0, 0, 0);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(250, 272);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 20);
            this.label13.TabIndex = 68;
            this.label13.Text = " Ngày Sinh :";
            // 
            // comboBox_GioTinh
            // 
            this.comboBox_GioTinh.FormattingEnabled = true;
            this.comboBox_GioTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBox_GioTinh.Location = new System.Drawing.Point(715, 146);
            this.comboBox_GioTinh.Name = "comboBox_GioTinh";
            this.comboBox_GioTinh.Size = new System.Drawing.Size(169, 28);
            this.comboBox_GioTinh.TabIndex = 67;
            this.comboBox_GioTinh.Text = "Nam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(626, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 66;
            this.label1.Text = "Giới Tính : ";
            // 
            // button_DichVu
            // 
            this.button_DichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DichVu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_DichVu.Location = new System.Drawing.Point(379, 532);
            this.button_DichVu.Name = "button_DichVu";
            this.button_DichVu.Size = new System.Drawing.Size(227, 47);
            this.button_DichVu.TabIndex = 65;
            this.button_DichVu.Text = "Thêm Dịch Vụ";
            this.button_DichVu.UseVisualStyleBackColor = true;
            this.button_DichVu.Click += new System.EventHandler(this.button_DichVu_Click);
            // 
            // button_NhanPhong
            // 
            this.button_NhanPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_NhanPhong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_NhanPhong.Location = new System.Drawing.Point(673, 532);
            this.button_NhanPhong.Name = "button_NhanPhong";
            this.button_NhanPhong.Size = new System.Drawing.Size(211, 47);
            this.button_NhanPhong.TabIndex = 64;
            this.button_NhanPhong.Text = "Nhận Phòng";
            this.button_NhanPhong.UseVisualStyleBackColor = true;
            this.button_NhanPhong.Click += new System.EventHandler(this.button_NhanPhong_Click);
            // 
            // button_CheckTT_KH
            // 
            this.button_CheckTT_KH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CheckTT_KH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_CheckTT_KH.Location = new System.Drawing.Point(25, 532);
            this.button_CheckTT_KH.Name = "button_CheckTT_KH";
            this.button_CheckTT_KH.Size = new System.Drawing.Size(281, 47);
            this.button_CheckTT_KH.TabIndex = 57;
            this.button_CheckTT_KH.Text = "Check Thông Tin Khách Hàng";
            this.button_CheckTT_KH.UseVisualStyleBackColor = true;
            this.button_CheckTT_KH.Click += new System.EventHandler(this.button_CheckTT_KH_Click);
            // 
            // txCMNN
            // 
            this.txCMNN.Location = new System.Drawing.Point(398, 149);
            this.txCMNN.Name = "txCMNN";
            this.txCMNN.Size = new System.Drawing.Size(208, 26);
            this.txCMNN.TabIndex = 63;
            //this.txCMNN.TextChanged += new System.EventHandler(this.txCMNN_TextChanged);
            // 
            // txt_tenKH
            // 
            this.txt_tenKH.Location = new System.Drawing.Point(398, 206);
            this.txt_tenKH.Name = "txt_tenKH";
            this.txt_tenKH.Size = new System.Drawing.Size(486, 26);
            this.txt_tenKH.TabIndex = 62;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(250, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 20);
            this.label8.TabIndex = 61;
            this.label8.Text = "Tên Khách Hàng : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 60;
            this.label6.Text = "CMND/passport";
            // 
            // textBox_Gmail
            // 
            this.textBox_Gmail.Location = new System.Drawing.Point(398, 328);
            this.textBox_Gmail.Name = "textBox_Gmail";
            this.textBox_Gmail.Size = new System.Drawing.Size(486, 26);
            this.textBox_Gmail.TabIndex = 59;
            // 
            // textBox_DiaChi
            // 
            this.textBox_DiaChi.Location = new System.Drawing.Point(398, 380);
            this.textBox_DiaChi.Name = "textBox_DiaChi";
            this.textBox_DiaChi.Size = new System.Drawing.Size(486, 26);
            this.textBox_DiaChi.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(250, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 57;
            this.label9.Text = "Gmail :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 56;
            this.label7.Text = "Địa Chỉ : ";
            // 
            // textSdt
            // 
            this.textSdt.Location = new System.Drawing.Point(398, 446);
            this.textSdt.Name = "textSdt";
            this.textSdt.Size = new System.Drawing.Size(486, 26);
            this.textSdt.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(250, 449);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 20);
            this.label10.TabIndex = 54;
            this.label10.Text = "Số Điện Thoại";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::src.Properties.Resources._219983;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(25, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 177);
            this.panel1.TabIndex = 53;
            // 
            // dateRa
            // 
            this.dateRa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateRa.Location = new System.Drawing.Point(716, 93);
            this.dateRa.Name = "dateRa";
            this.dateRa.Size = new System.Drawing.Size(168, 26);
            this.dateRa.TabIndex = 52;
            this.dateRa.Value = new System.DateTime(2023, 7, 2, 18, 6, 33, 0);
            // 
            // dateVao
            // 
            this.dateVao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateVao.Location = new System.Drawing.Point(398, 93);
            this.dateVao.Name = "dateVao";
            this.dateVao.Size = new System.Drawing.Size(208, 26);
            this.dateVao.TabIndex = 51;
            this.dateVao.Value = new System.DateTime(2023, 7, 2, 18, 6, 22, 0);
            // 
            // tx_maphong
            // 
            this.tx_maphong.Location = new System.Drawing.Point(398, 35);
            this.tx_maphong.Name = "tx_maphong";
            this.tx_maphong.Size = new System.Drawing.Size(208, 26);
            this.tx_maphong.TabIndex = 50;
            //this.tx_maphong.TextChanged += new System.EventHandler(this.tx_maphong_TextChanged);
            // 
            // tb_giaPhong
            // 
            this.tb_giaPhong.Location = new System.Drawing.Point(716, 32);
            this.tb_giaPhong.Name = "tb_giaPhong";
            this.tb_giaPhong.Size = new System.Drawing.Size(168, 26);
            this.tb_giaPhong.TabIndex = 49;
            //this.tb_giaPhong.TextChanged += new System.EventHandler(this.tb_giaPhong_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(253, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 20);
            this.label11.TabIndex = 46;
            this.label11.Text = "Mã Phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "Ngày Vào";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(626, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Ngày Ra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(626, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Giá Phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.ForestGreen;
            this.label4.Location = new System.Drawing.Point(149, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(638, 80);
            this.label4.TabIndex = 42;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkGreen;
            this.label12.Location = new System.Drawing.Point(21, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 22);
            this.label12.TabIndex = 43;
            this.label12.Text = "Hướng Dẫn :";
            // 
            // BookingGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 714);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(975, 878);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "BookingGUI";
            this.Text = "RoomInforGUI";
            this.Load += new System.EventHandler(this.BookingGUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textSdt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateRa;
        private System.Windows.Forms.DateTimePicker dateVao;
        private System.Windows.Forms.TextBox tx_maphong;
        private System.Windows.Forms.TextBox tb_giaPhong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_CheckTT_KH;
        private System.Windows.Forms.TextBox textBox_Gmail;
        private System.Windows.Forms.TextBox textBox_DiaChi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txCMNN;
        private System.Windows.Forms.TextBox txt_tenKH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_NhanPhong;
        private System.Windows.Forms.Button button_DichVu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox_GioTinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeNgaySinh;
        private System.Windows.Forms.Label label13;
    }
}