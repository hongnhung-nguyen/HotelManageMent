
namespace src.GUI
{
    partial class CustomerServicesGUI
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_DichVu = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox_DVName = new System.Windows.Forms.ComboBox();
            this.button_themDV = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_DV_KhachHang = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DichVu)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DV_KhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.dataGridView_DichVu);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(-1, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(937, 236);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Dịch Vụ";
            // 
            // dataGridView_DichVu
            // 
            this.dataGridView_DichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DichVu.Location = new System.Drawing.Point(254, 25);
            this.dataGridView_DichVu.Name = "dataGridView_DichVu";
            this.dataGridView_DichVu.RowHeadersWidth = 62;
            this.dataGridView_DichVu.RowTemplate.Height = 28;
            this.dataGridView_DichVu.Size = new System.Drawing.Size(630, 191);
            this.dataGridView_DichVu.TabIndex = 60;
            this.dataGridView_DichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DichVu_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::src.Properties.Resources.receptionist;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(25, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 177);
            this.panel2.TabIndex = 54;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.comboBox_DVName);
            this.groupBox1.Controls.Add(this.button_themDV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.dataGridView_DV_KhachHang);
            this.groupBox1.Location = new System.Drawing.Point(-1, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(937, 379);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dịch Vụ Khách Hàng Đã Chọn";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(417, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 40);
            this.button2.TabIndex = 66;
            this.button2.Text = "Xác Nhận";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox_DVName
            // 
            this.comboBox_DVName.FormattingEnabled = true;
            this.comboBox_DVName.Location = new System.Drawing.Point(344, 43);
            this.comboBox_DVName.Name = "comboBox_DVName";
            this.comboBox_DVName.Size = new System.Drawing.Size(224, 28);
            this.comboBox_DVName.TabIndex = 65;
            // 
            // button_themDV
            // 
            this.button_themDV.Location = new System.Drawing.Point(612, 36);
            this.button_themDV.Name = "button_themDV";
            this.button_themDV.Size = new System.Drawing.Size(116, 40);
            this.button_themDV.TabIndex = 64;
            this.button_themDV.Text = "Thêm";
            this.button_themDV.UseVisualStyleBackColor = true;
            this.button_themDV.Click += new System.EventHandler(this.button_themDV_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 63;
            this.label4.Text = "Dịch Vụ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(757, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 40);
            this.button1.TabIndex = 62;
            this.button1.Text = "Loại Bỏ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::src.Properties.Resources._219983;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(25, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 177);
            this.panel1.TabIndex = 61;
            // 
            // dataGridView_DV_KhachHang
            // 
            this.dataGridView_DV_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DV_KhachHang.Location = new System.Drawing.Point(254, 117);
            this.dataGridView_DV_KhachHang.Name = "dataGridView_DV_KhachHang";
            this.dataGridView_DV_KhachHang.RowHeadersWidth = 62;
            this.dataGridView_DV_KhachHang.RowTemplate.Height = 28;
            this.dataGridView_DV_KhachHang.Size = new System.Drawing.Size(630, 191);
            this.dataGridView_DV_KhachHang.TabIndex = 60;
            // 
            // CustomerServicesGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 650);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "CustomerServicesGUI";
            this.Text = "BookingGUI";
            this.Load += new System.EventHandler(this.CustomerServices_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DichVu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DV_KhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_DichVu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_DV_KhachHang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox_DVName;
        private System.Windows.Forms.Button button_themDV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}