namespace _3.PresentationLayers.Views
{
    partial class FrmChucVu
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
            this.dtg_Show = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Timkiem = new System.Windows.Forms.TextBox();
            this.gB_tt = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_ma = new System.Windows.Forms.TextBox();
            this.tb_trangthai = new System.Windows.Forms.TextBox();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Show)).BeginInit();
            this.gB_tt.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_Timkiem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtg_Show);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1077, 259);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Chức Vụ";
            // 
            // dtg_Show
            // 
            this.dtg_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Show.Location = new System.Drawing.Point(20, 65);
            this.dtg_Show.Name = "dtg_Show";
            this.dtg_Show.RowHeadersWidth = 51;
            this.dtg_Show.RowTemplate.Height = 29;
            this.dtg_Show.Size = new System.Drawing.Size(1040, 176);
            this.dtg_Show.TabIndex = 0;
            this.dtg_Show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Show_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(723, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm Kiếm: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_Timkiem
            // 
            this.tb_Timkiem.Location = new System.Drawing.Point(808, 32);
            this.tb_Timkiem.Name = "tb_Timkiem";
            this.tb_Timkiem.Size = new System.Drawing.Size(252, 27);
            this.tb_Timkiem.TabIndex = 2;
            // 
            // gB_tt
            // 
            this.gB_tt.Controls.Add(this.label4);
            this.gB_tt.Controls.Add(this.label3);
            this.gB_tt.Controls.Add(this.label2);
            this.gB_tt.Controls.Add(this.tb_ten);
            this.gB_tt.Controls.Add(this.tb_trangthai);
            this.gB_tt.Controls.Add(this.tb_ma);
            this.gB_tt.Location = new System.Drawing.Point(12, 288);
            this.gB_tt.Name = "gB_tt";
            this.gB_tt.Size = new System.Drawing.Size(692, 282);
            this.gB_tt.TabIndex = 1;
            this.gB_tt.TabStop = false;
            this.gB_tt.Text = "Thông Tin Chức Vụ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Reset);
            this.groupBox3.Controls.Add(this.btn_Xoa);
            this.groupBox3.Controls.Add(this.btn_Sua);
            this.groupBox3.Controls.Add(this.btn_Them);
            this.groupBox3.Location = new System.Drawing.Point(740, 288);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(349, 282);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // tb_ma
            // 
            this.tb_ma.Location = new System.Drawing.Point(156, 35);
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Size = new System.Drawing.Size(125, 27);
            this.tb_ma.TabIndex = 0;
            // 
            // tb_trangthai
            // 
            this.tb_trangthai.Location = new System.Drawing.Point(314, 142);
            this.tb_trangthai.Name = "tb_trangthai";
            this.tb_trangthai.Size = new System.Drawing.Size(125, 27);
            this.tb_trangthai.TabIndex = 2;
            // 
            // tb_ten
            // 
            this.tb_ten.Location = new System.Drawing.Point(453, 35);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(125, 27);
            this.tb_ten.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Trạng Thái :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên :";
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(6, 44);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(337, 29);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(6, 106);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(337, 29);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Sửa ";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(3, 172);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(337, 29);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(6, 234);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(337, 29);
            this.btn_Reset.TabIndex = 3;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // FrmChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 582);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gB_tt);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmChucVu";
            this.Text = "FrmChucVu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Show)).EndInit();
            this.gB_tt.ResumeLayout(false);
            this.gB_tt.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_Timkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtg_Show;
        private System.Windows.Forms.GroupBox gB_tt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ten;
        private System.Windows.Forms.TextBox tb_trangthai;
        private System.Windows.Forms.TextBox tb_ma;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
    }
}