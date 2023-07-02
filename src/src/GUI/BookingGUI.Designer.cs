
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_SoDT = new System.Windows.Forms.TextBox();
            this.textBox_DiaChi = new System.Windows.Forms.TextBox();
            this.textBox_Gmail = new System.Windows.Forms.TextBox();
            this.textBox_TenKH = new System.Windows.Forms.TextBox();
            this.textBox_CNND = new System.Windows.Forms.TextBox();
            this.textBox_giaPhong = new System.Windows.Forms.TextBox();
            this.textBox_maPhong = new System.Windows.Forms.TextBox();
            this.dateTimePicker_NgayVao = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_NgayRa = new System.Windows.Forms.DateTimePicker();
            this.button_NhanPhong = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(396, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐẶT PHÒNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Ra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày Vào";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "CMND/passport";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 490);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Địa Chỉ : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tên Khách Hàng : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 437);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Gmail :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 552);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "SĐT : ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Mã Phòng";
            // 
            // textBox_SoDT
            // 
            this.textBox_SoDT.Location = new System.Drawing.Point(180, 549);
            this.textBox_SoDT.Name = "textBox_SoDT";
            this.textBox_SoDT.Size = new System.Drawing.Size(319, 26);
            this.textBox_SoDT.TabIndex = 12;
            // 
            // textBox_DiaChi
            // 
            this.textBox_DiaChi.Location = new System.Drawing.Point(180, 484);
            this.textBox_DiaChi.Name = "textBox_DiaChi";
            this.textBox_DiaChi.Size = new System.Drawing.Size(319, 26);
            this.textBox_DiaChi.TabIndex = 14;
            // 
            // textBox_Gmail
            // 
            this.textBox_Gmail.Location = new System.Drawing.Point(180, 434);
            this.textBox_Gmail.Name = "textBox_Gmail";
            this.textBox_Gmail.Size = new System.Drawing.Size(319, 26);
            this.textBox_Gmail.TabIndex = 15;
            // 
            // textBox_TenKH
            // 
            this.textBox_TenKH.Location = new System.Drawing.Point(180, 372);
            this.textBox_TenKH.Name = "textBox_TenKH";
            this.textBox_TenKH.Size = new System.Drawing.Size(319, 26);
            this.textBox_TenKH.TabIndex = 16;
            // 
            // textBox_CNND
            // 
            this.textBox_CNND.Location = new System.Drawing.Point(180, 310);
            this.textBox_CNND.Name = "textBox_CNND";
            this.textBox_CNND.Size = new System.Drawing.Size(319, 26);
            this.textBox_CNND.TabIndex = 17;
            // 
            // textBox_giaPhong
            // 
            this.textBox_giaPhong.Location = new System.Drawing.Point(180, 136);
            this.textBox_giaPhong.Name = "textBox_giaPhong";
            this.textBox_giaPhong.Size = new System.Drawing.Size(319, 26);
            this.textBox_giaPhong.TabIndex = 18;
            // 
            // textBox_maPhong
            // 
            this.textBox_maPhong.Location = new System.Drawing.Point(180, 88);
            this.textBox_maPhong.Name = "textBox_maPhong";
            this.textBox_maPhong.Size = new System.Drawing.Size(319, 26);
            this.textBox_maPhong.TabIndex = 19;
            // 
            // dateTimePicker_NgayVao
            // 
            this.dateTimePicker_NgayVao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_NgayVao.Location = new System.Drawing.Point(180, 187);
            this.dateTimePicker_NgayVao.Name = "dateTimePicker_NgayVao";
            this.dateTimePicker_NgayVao.Size = new System.Drawing.Size(319, 26);
            this.dateTimePicker_NgayVao.TabIndex = 20;
            this.dateTimePicker_NgayVao.Value = new System.DateTime(2023, 7, 2, 18, 6, 22, 0);
            // 
            // dateTimePicker_NgayRa
            // 
            this.dateTimePicker_NgayRa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_NgayRa.Location = new System.Drawing.Point(180, 248);
            this.dateTimePicker_NgayRa.Name = "dateTimePicker_NgayRa";
            this.dateTimePicker_NgayRa.Size = new System.Drawing.Size(319, 26);
            this.dateTimePicker_NgayRa.TabIndex = 21;
            this.dateTimePicker_NgayRa.Value = new System.DateTime(2023, 7, 2, 18, 6, 33, 0);
            // 
            // button_NhanPhong
            // 
            this.button_NhanPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_NhanPhong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_NhanPhong.Location = new System.Drawing.Point(622, 525);
            this.button_NhanPhong.Name = "button_NhanPhong";
            this.button_NhanPhong.Size = new System.Drawing.Size(249, 47);
            this.button_NhanPhong.TabIndex = 23;
            this.button_NhanPhong.Text = "Nhận Phòng";
            this.button_NhanPhong.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::src.Properties.Resources._219983;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(552, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 361);
            this.panel1.TabIndex = 22;
            // 
            // BookingGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 610);
            this.Controls.Add(this.button_NhanPhong);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker_NgayRa);
            this.Controls.Add(this.dateTimePicker_NgayVao);
            this.Controls.Add(this.textBox_maPhong);
            this.Controls.Add(this.textBox_giaPhong);
            this.Controls.Add(this.textBox_CNND);
            this.Controls.Add(this.textBox_TenKH);
            this.Controls.Add(this.textBox_Gmail);
            this.Controls.Add(this.textBox_DiaChi);
            this.Controls.Add(this.textBox_SoDT);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BookingGUI";
            this.Text = "BookingGUI";
            this.Load += new System.EventHandler(this.BookingGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_SoDT;
        private System.Windows.Forms.TextBox textBox_DiaChi;
        private System.Windows.Forms.TextBox textBox_Gmail;
        private System.Windows.Forms.TextBox textBox_TenKH;
        private System.Windows.Forms.TextBox textBox_CNND;
        private System.Windows.Forms.TextBox textBox_giaPhong;
        private System.Windows.Forms.TextBox textBox_maPhong;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayVao;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayRa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_NhanPhong;
    }
}