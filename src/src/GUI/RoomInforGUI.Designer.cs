
namespace src.GUI
{
    partial class RoomInforGUI
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tenKH = new System.Windows.Forms.TextBox();
            this.txCMNN = new System.Windows.Forms.TextBox();
            this.tb_giaPhong = new System.Windows.Forms.TextBox();
            this.tx_maphong = new System.Windows.Forms.TextBox();
            this.dateVao = new System.Windows.Forms.DateTimePicker();
            this.dateRa = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.textSdt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxDichvu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_themDV = new System.Windows.Forms.Button();
            this.button_XoaDV = new System.Windows.Forms.Button();
            this.dataGridView_DichVu = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textSdt);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.dateRa);
            this.groupBox1.Controls.Add(this.dateVao);
            this.groupBox1.Controls.Add(this.tx_maphong);
            this.groupBox1.Controls.Add(this.tb_giaPhong);
            this.groupBox1.Controls.Add(this.txCMNN);
            this.groupBox1.Controls.Add(this.tenKH);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(824, 397);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Đặt Phòng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Giá Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Ngày Ra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "Ngày Vào";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "CMND/passport";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(236, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 20);
            this.label8.TabIndex = 45;
            this.label8.Text = "Tên Khách Hàng : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(236, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 20);
            this.label11.TabIndex = 46;
            this.label11.Text = "Mã Phòng";
            // 
            // tenKH
            // 
            this.tenKH.Location = new System.Drawing.Point(398, 244);
            this.tenKH.Name = "tenKH";
            this.tenKH.Size = new System.Drawing.Size(397, 26);
            this.tenKH.TabIndex = 47;
            // 
            // txCMNN
            // 
            this.txCMNN.Location = new System.Drawing.Point(398, 296);
            this.txCMNN.Name = "txCMNN";
            this.txCMNN.Size = new System.Drawing.Size(397, 26);
            this.txCMNN.TabIndex = 48;
            // 
            // tb_giaPhong
            // 
            this.tb_giaPhong.Location = new System.Drawing.Point(398, 83);
            this.tb_giaPhong.Name = "tb_giaPhong";
            this.tb_giaPhong.Size = new System.Drawing.Size(397, 26);
            this.tb_giaPhong.TabIndex = 49;
            // 
            // tx_maphong
            // 
            this.tx_maphong.Location = new System.Drawing.Point(398, 35);
            this.tx_maphong.Name = "tx_maphong";
            this.tx_maphong.Size = new System.Drawing.Size(397, 26);
            this.tx_maphong.TabIndex = 50;
            // 
            // dateVao
            // 
            this.dateVao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateVao.Location = new System.Drawing.Point(398, 135);
            this.dateVao.Name = "dateVao";
            this.dateVao.Size = new System.Drawing.Size(397, 26);
            this.dateVao.TabIndex = 51;
            this.dateVao.Value = new System.DateTime(2023, 7, 2, 18, 6, 22, 0);
            // 
            // dateRa
            // 
            this.dateRa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateRa.Location = new System.Drawing.Point(398, 196);
            this.dateRa.Name = "dateRa";
            this.dateRa.Size = new System.Drawing.Size(397, 26);
            this.dateRa.TabIndex = 52;
            this.dateRa.Value = new System.DateTime(2023, 7, 2, 18, 6, 33, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(253, 346);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 20);
            this.label10.TabIndex = 54;
            this.label10.Text = "SĐT : ";
            // 
            // textSdt
            // 
            this.textSdt.Location = new System.Drawing.Point(398, 343);
            this.textSdt.Name = "textSdt";
            this.textSdt.Size = new System.Drawing.Size(397, 26);
            this.textSdt.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 26);
            this.label1.TabIndex = 41;
            this.label1.Text = "Thông Tin Phòng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_DichVu);
            this.groupBox2.Controls.Add(this.button_XoaDV);
            this.groupBox2.Controls.Add(this.button_themDV);
            this.groupBox2.Controls.Add(this.textBoxDichvu);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(12, 441);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(824, 316);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Dịch Vụ";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::src.Properties.Resources.receptionist;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(25, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(159, 177);
            this.panel2.TabIndex = 54;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::src.Properties.Resources._219983;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(25, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 177);
            this.panel1.TabIndex = 53;
            // 
            // textBoxDichvu
            // 
            this.textBoxDichvu.Location = new System.Drawing.Point(338, 34);
            this.textBoxDichvu.Name = "textBoxDichvu";
            this.textBoxDichvu.Size = new System.Drawing.Size(168, 26);
            this.textBoxDichvu.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 56;
            this.label4.Text = "Dịch Vụ";
            // 
            // button_themDV
            // 
            this.button_themDV.Location = new System.Drawing.Point(532, 27);
            this.button_themDV.Name = "button_themDV";
            this.button_themDV.Size = new System.Drawing.Size(119, 40);
            this.button_themDV.TabIndex = 58;
            this.button_themDV.Text = "Thêm";
            this.button_themDV.UseVisualStyleBackColor = true;
            // 
            // button_XoaDV
            // 
            this.button_XoaDV.Location = new System.Drawing.Point(688, 27);
            this.button_XoaDV.Name = "button_XoaDV";
            this.button_XoaDV.Size = new System.Drawing.Size(107, 40);
            this.button_XoaDV.TabIndex = 59;
            this.button_XoaDV.Text = "Xóa";
            this.button_XoaDV.UseVisualStyleBackColor = true;
            // 
            // dataGridView_DichVu
            // 
            this.dataGridView_DichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DichVu.Location = new System.Drawing.Point(237, 93);
            this.dataGridView_DichVu.Name = "dataGridView_DichVu";
            this.dataGridView_DichVu.RowHeadersWidth = 62;
            this.dataGridView_DichVu.RowTemplate.Height = 28;
            this.dataGridView_DichVu.Size = new System.Drawing.Size(557, 191);
            this.dataGridView_DichVu.TabIndex = 60;
            // 
            // RoomInforGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 747);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "RoomInforGUI";
            this.Text = "RoomInforGUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DichVu)).EndInit();
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
        private System.Windows.Forms.TextBox txCMNN;
        private System.Windows.Forms.TextBox tenKH;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_DichVu;
        private System.Windows.Forms.Button button_XoaDV;
        private System.Windows.Forms.Button button_themDV;
        private System.Windows.Forms.TextBox textBoxDichvu;
        private System.Windows.Forms.Label label4;
    }
}