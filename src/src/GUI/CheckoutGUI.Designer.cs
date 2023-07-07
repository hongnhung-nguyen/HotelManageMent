
namespace src.GUI
{
    partial class CheckoutGUI
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
            this.dateRa = new System.Windows.Forms.DateTimePicker();
            this.dateVao = new System.Windows.Forms.DateTimePicker();
            this.textBoxLoaiPhong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxGiaPhong = new System.Windows.Forms.TextBox();
            this.button_XemPhong = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMaKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_DSDichVu = new System.Windows.Forms.DataGridView();
            this.textBoxMaPhong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTienPhong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDaThanhToan = new System.Windows.Forms.TextBox();
            this.textBoxTienDV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button_timphong = new System.Windows.Forms.Button();
            this.buttonTinhTien = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxTongTien = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSDichVu)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.dateRa);
            this.groupBox1.Controls.Add(this.dateVao);
            this.groupBox1.Controls.Add(this.textBoxLoaiPhong);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxGiaPhong);
            this.groupBox1.Controls.Add(this.button_XemPhong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxMaKH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 274);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng";
            // 
            // dateRa
            // 
            this.dateRa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateRa.Location = new System.Drawing.Point(178, 173);
            this.dateRa.Name = "dateRa";
            this.dateRa.Size = new System.Drawing.Size(242, 26);
            this.dateRa.TabIndex = 54;
            this.dateRa.Value = new System.DateTime(2023, 7, 3, 0, 0, 0, 0);
            // 
            // dateVao
            // 
            this.dateVao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateVao.Location = new System.Drawing.Point(178, 126);
            this.dateVao.Name = "dateVao";
            this.dateVao.Size = new System.Drawing.Size(242, 26);
            this.dateVao.TabIndex = 53;
            this.dateVao.Value = new System.DateTime(2023, 7, 2, 18, 6, 22, 0);
            // 
            // textBoxLoaiPhong
            // 
            this.textBoxLoaiPhong.Location = new System.Drawing.Point(178, 88);
            this.textBoxLoaiPhong.Name = "textBoxLoaiPhong";
            this.textBoxLoaiPhong.Size = new System.Drawing.Size(242, 26);
            this.textBoxLoaiPhong.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Thời gian đi";
            // 
            // textBoxGiaPhong
            // 
            this.textBoxGiaPhong.Location = new System.Drawing.Point(178, 222);
            this.textBoxGiaPhong.Name = "textBoxGiaPhong";
            this.textBoxGiaPhong.Size = new System.Drawing.Size(242, 26);
            this.textBoxGiaPhong.TabIndex = 17;
            // 
            // button_XemPhong
            // 
            this.button_XemPhong.Location = new System.Drawing.Point(-11, 344);
            this.button_XemPhong.Name = "button_XemPhong";
            this.button_XemPhong.Size = new System.Drawing.Size(258, 37);
            this.button_XemPhong.TabIndex = 8;
            this.button_XemPhong.Text = "Xem Phòng";
            this.button_XemPhong.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mã Khách Hàng";
            // 
            // textBoxMaKH
            // 
            this.textBoxMaKH.Location = new System.Drawing.Point(178, 44);
            this.textBoxMaKH.Name = "textBoxMaKH";
            this.textBoxMaKH.Size = new System.Drawing.Size(242, 26);
            this.textBoxMaKH.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thời gian đến";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giá phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại Phòng";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.dataGridView_DSDichVu);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(635, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(542, 274);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Sử Dụng Dịch Vụ";
            // 
            // dataGridView_DSDichVu
            // 
            this.dataGridView_DSDichVu.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView_DSDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DSDichVu.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView_DSDichVu.Location = new System.Drawing.Point(59, 47);
            this.dataGridView_DSDichVu.Name = "dataGridView_DSDichVu";
            this.dataGridView_DSDichVu.RowHeadersWidth = 62;
            this.dataGridView_DSDichVu.RowTemplate.Height = 28;
            this.dataGridView_DSDichVu.Size = new System.Drawing.Size(430, 209);
            this.dataGridView_DSDichVu.TabIndex = 0;
            // 
            // textBoxMaPhong
            // 
            this.textBoxMaPhong.Location = new System.Drawing.Point(537, 31);
            this.textBoxMaPhong.Name = "textBoxMaPhong";
            this.textBoxMaPhong.Size = new System.Drawing.Size(271, 26);
            this.textBoxMaPhong.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(377, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nhập Mã Phòng";
            // 
            // textBoxTienPhong
            // 
            this.textBoxTienPhong.Location = new System.Drawing.Point(216, 23);
            this.textBoxTienPhong.Name = "textBoxTienPhong";
            this.textBoxTienPhong.Size = new System.Drawing.Size(242, 26);
            this.textBoxTienPhong.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Tiền dịch vụ";
            // 
            // textBoxDaThanhToan
            // 
            this.textBoxDaThanhToan.Location = new System.Drawing.Point(216, 144);
            this.textBoxDaThanhToan.Name = "textBoxDaThanhToan";
            this.textBoxDaThanhToan.Size = new System.Drawing.Size(242, 26);
            this.textBoxDaThanhToan.TabIndex = 23;
            // 
            // textBoxTienDV
            // 
            this.textBoxTienDV.Location = new System.Drawing.Point(216, 84);
            this.textBoxTienDV.Name = "textBoxTienDV";
            this.textBoxTienDV.Size = new System.Drawing.Size(242, 26);
            this.textBoxTienDV.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Tiền phòng";
            // 
            // label10
            // 
            this.label10.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(54, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Đã thanh toán";
            // 
            // button_timphong
            // 
            this.button_timphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_timphong.Location = new System.Drawing.Point(857, 24);
            this.button_timphong.Name = "button_timphong";
            this.button_timphong.Size = new System.Drawing.Size(119, 40);
            this.button_timphong.TabIndex = 59;
            this.button_timphong.Text = "Tìm";
            this.button_timphong.UseVisualStyleBackColor = true;
            this.button_timphong.Click += new System.EventHandler(this.button_timphong_Click);
            // 
            // buttonTinhTien
            // 
            this.buttonTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTinhTien.Location = new System.Drawing.Point(509, 381);
            this.buttonTinhTien.Name = "buttonTinhTien";
            this.buttonTinhTien.Size = new System.Drawing.Size(145, 58);
            this.buttonTinhTien.TabIndex = 60;
            this.buttonTinhTien.Text = "Tính Tiền";
            this.buttonTinhTien.UseVisualStyleBackColor = true;
            this.buttonTinhTien.Click += new System.EventHandler(this.buttonTinhTien_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox3.Controls.Add(this.textBoxTongTien);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBoxTienPhong);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBoxDaThanhToan);
            this.groupBox3.Controls.Add(this.textBoxTienDV);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(298, 454);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(539, 260);
            this.groupBox3.TabIndex = 61;
            this.groupBox3.TabStop = false;
            // 
            // textBoxTongTien
            // 
            this.textBoxTongTien.Location = new System.Drawing.Point(216, 207);
            this.textBoxTongTien.Name = "textBoxTongTien";
            this.textBoxTongTien.Size = new System.Drawing.Size(242, 26);
            this.textBoxTongTien.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(27, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(504, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "................................................................................." +
    "..................";
            // 
            // label11
            // 
            this.label11.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(53, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Tổng tiền";
            // 
            // label14
            // 
            this.label14.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(751, 501);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 20);
            this.label14.TabIndex = 62;
            // 
            // CheckoutGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 750);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonTinhTien);
            this.Controls.Add(this.button_timphong);
            this.Controls.Add(this.textBoxMaPhong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CheckoutGUI";
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.CheckoutGUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSDichVu)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_XemPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_DSDichVu;
        private System.Windows.Forms.TextBox textBoxMaKH;
        private System.Windows.Forms.TextBox textBoxMaPhong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxGiaPhong;
        private System.Windows.Forms.TextBox textBoxLoaiPhong;
        private System.Windows.Forms.TextBox textBoxTienPhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDaThanhToan;
        private System.Windows.Forms.TextBox textBoxTienDV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_timphong;
        private System.Windows.Forms.Button buttonTinhTien;
        private System.Windows.Forms.DateTimePicker dateRa;
        private System.Windows.Forms.DateTimePicker dateVao;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxTongTien;
        private System.Windows.Forms.Label label14;
    }
}