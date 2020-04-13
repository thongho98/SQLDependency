namespace DemoSQLDependency
{
    partial class frmNhanVien
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
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label lUONGLabel;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label trangThaiXoaLabel;
            this.DS = new DemoSQLDependency.QLVT_DATHANGDataSet();
            this.bdsNhanVien = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new DemoSQLDependency.QLVT_DATHANGDataSetTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new DemoSQLDependency.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.dgv_NV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.hOTextBox = new System.Windows.Forms.TextBox();
            this.tENTextBox = new System.Windows.Forms.TextBox();
            this.dIACHITextBox = new System.Windows.Forms.TextBox();
            this.nGAYSINHDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lUONGTextBox = new System.Windows.Forms.TextBox();
            this.mACNTextBox = new System.Windows.Forms.TextBox();
            this.trangThaiXoaTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            mANVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            lUONGLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            trangThaiXoaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(44, 51);
            mANVLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(51, 17);
            mANVLabel.TabIndex = 2;
            mANVLabel.Text = "MANV:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(64, 120);
            hOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(33, 17);
            hOLabel.TabIndex = 4;
            hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(56, 189);
            tENLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(40, 17);
            tENLabel.TabIndex = 6;
            tENLabel.Text = "TEN:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(44, 267);
            dIACHILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(56, 17);
            dIACHILabel.TabIndex = 8;
            dIACHILabel.Text = "DIACHI:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(392, 56);
            nGAYSINHLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(83, 17);
            nGAYSINHLabel.TabIndex = 10;
            nGAYSINHLabel.Text = "NGAYSINH:";
            // 
            // lUONGLabel
            // 
            lUONGLabel.AutoSize = true;
            lUONGLabel.Location = new System.Drawing.Point(416, 125);
            lUONGLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lUONGLabel.Name = "lUONGLabel";
            lUONGLabel.Size = new System.Drawing.Size(62, 17);
            lUONGLabel.TabIndex = 12;
            lUONGLabel.Text = "LUONG:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(426, 194);
            mACNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(51, 17);
            mACNLabel.TabIndex = 14;
            mACNLabel.Text = "MACN:";
            // 
            // trangThaiXoaLabel
            // 
            trangThaiXoaLabel.AutoSize = true;
            trangThaiXoaLabel.Location = new System.Drawing.Point(368, 264);
            trangThaiXoaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            trangThaiXoaLabel.Name = "trangThaiXoaLabel";
            trangThaiXoaLabel.Size = new System.Drawing.Size(111, 17);
            trangThaiXoaLabel.TabIndex = 16;
            trangThaiXoaLabel.Text = "Trang Thai Xoa:";
            // 
            // DS
            // 
            this.DS.DataSetName = "QLVT_DATHANGDataSet";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsNhanVien
            // 
            this.bdsNhanVien.DataMember = "NhanVien";
            this.bdsNhanVien.DataSource = this.DS;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.UpdateOrder = DemoSQLDependency.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(63, 62);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 28);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnGhi);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(1169, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(207, 662);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(63, 245);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 28);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(63, 182);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 28);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.Location = new System.Drawing.Point(63, 124);
            this.btnGhi.Margin = new System.Windows.Forms.Padding(4);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(100, 28);
            this.btnGhi.TabIndex = 1;
            this.btnGhi.Text = "GHI";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // dgv_NV
            // 
            this.dgv_NV.AutoGenerateColumns = false;
            this.dgv_NV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgv_NV.DataSource = this.bdsNhanVien;
            this.dgv_NV.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_NV.Location = new System.Drawing.Point(0, 0);
            this.dgv_NV.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_NV.Name = "dgv_NV";
            this.dgv_NV.Size = new System.Drawing.Size(1169, 328);
            this.dgv_NV.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MANV";
            this.dataGridViewTextBoxColumn1.HeaderText = "MANV";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HO";
            this.dataGridViewTextBoxColumn2.HeaderText = "HO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TEN";
            this.dataGridViewTextBoxColumn3.HeaderText = "TEN";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DIACHI";
            this.dataGridViewTextBoxColumn4.HeaderText = "DIACHI";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NGAYSINH";
            this.dataGridViewTextBoxColumn5.HeaderText = "NGAYSINH";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "LUONG";
            this.dataGridViewTextBoxColumn6.HeaderText = "LUONG";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MACN";
            this.dataGridViewTextBoxColumn7.HeaderText = "MACN";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TrangThaiXoa";
            this.dataGridViewTextBoxColumn8.HeaderText = "TrangThaiXoa";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "MANV", true));
            this.txtMaNV.Location = new System.Drawing.Point(107, 47);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(132, 22);
            this.txtMaNV.TabIndex = 3;
            // 
            // hOTextBox
            // 
            this.hOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "HO", true));
            this.hOTextBox.Location = new System.Drawing.Point(107, 116);
            this.hOTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.hOTextBox.Name = "hOTextBox";
            this.hOTextBox.Size = new System.Drawing.Size(132, 22);
            this.hOTextBox.TabIndex = 5;
            // 
            // tENTextBox
            // 
            this.tENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "TEN", true));
            this.tENTextBox.Location = new System.Drawing.Point(107, 185);
            this.tENTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.tENTextBox.Name = "tENTextBox";
            this.tENTextBox.Size = new System.Drawing.Size(132, 22);
            this.tENTextBox.TabIndex = 7;
            // 
            // dIACHITextBox
            // 
            this.dIACHITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "DIACHI", true));
            this.dIACHITextBox.Location = new System.Drawing.Point(114, 264);
            this.dIACHITextBox.Margin = new System.Windows.Forms.Padding(4);
            this.dIACHITextBox.Name = "dIACHITextBox";
            this.dIACHITextBox.Size = new System.Drawing.Size(132, 22);
            this.dIACHITextBox.TabIndex = 9;
            // 
            // nGAYSINHDateTimePicker
            // 
            this.nGAYSINHDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsNhanVien, "NGAYSINH", true));
            this.nGAYSINHDateTimePicker.Location = new System.Drawing.Point(488, 51);
            this.nGAYSINHDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.nGAYSINHDateTimePicker.Name = "nGAYSINHDateTimePicker";
            this.nGAYSINHDateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.nGAYSINHDateTimePicker.TabIndex = 11;
            // 
            // lUONGTextBox
            // 
            this.lUONGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "LUONG", true));
            this.lUONGTextBox.Location = new System.Drawing.Point(488, 121);
            this.lUONGTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lUONGTextBox.Name = "lUONGTextBox";
            this.lUONGTextBox.Size = new System.Drawing.Size(132, 22);
            this.lUONGTextBox.TabIndex = 13;
            // 
            // mACNTextBox
            // 
            this.mACNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "MACN", true));
            this.mACNTextBox.Location = new System.Drawing.Point(488, 190);
            this.mACNTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.mACNTextBox.Name = "mACNTextBox";
            this.mACNTextBox.Size = new System.Drawing.Size(132, 22);
            this.mACNTextBox.TabIndex = 15;
            // 
            // trangThaiXoaTextBox
            // 
            this.trangThaiXoaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "TrangThaiXoa", true));
            this.trangThaiXoaTextBox.Location = new System.Drawing.Point(488, 260);
            this.trangThaiXoaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.trangThaiXoaTextBox.Name = "trangThaiXoaTextBox";
            this.trangThaiXoaTextBox.Size = new System.Drawing.Size(132, 22);
            this.trangThaiXoaTextBox.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(hOLabel);
            this.groupBox2.Controls.Add(trangThaiXoaLabel);
            this.groupBox2.Controls.Add(this.txtMaNV);
            this.groupBox2.Controls.Add(this.trangThaiXoaTextBox);
            this.groupBox2.Controls.Add(mANVLabel);
            this.groupBox2.Controls.Add(mACNLabel);
            this.groupBox2.Controls.Add(this.hOTextBox);
            this.groupBox2.Controls.Add(this.mACNTextBox);
            this.groupBox2.Controls.Add(this.tENTextBox);
            this.groupBox2.Controls.Add(lUONGLabel);
            this.groupBox2.Controls.Add(tENLabel);
            this.groupBox2.Controls.Add(this.lUONGTextBox);
            this.groupBox2.Controls.Add(this.dIACHITextBox);
            this.groupBox2.Controls.Add(nGAYSINHLabel);
            this.groupBox2.Controls.Add(dIACHILabel);
            this.groupBox2.Controls.Add(this.nGAYSINHDateTimePicker);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1169, 334);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 662);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_NV);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private QLVT_DATHANGDataSet DS;
        private System.Windows.Forms.BindingSource bdsNhanVien;
        private QLVT_DATHANGDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.DataGridView dgv_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox hOTextBox;
        private System.Windows.Forms.TextBox tENTextBox;
        private System.Windows.Forms.TextBox dIACHITextBox;
        private System.Windows.Forms.DateTimePicker nGAYSINHDateTimePicker;
        private System.Windows.Forms.TextBox lUONGTextBox;
        private System.Windows.Forms.TextBox mACNTextBox;
        private System.Windows.Forms.TextBox trangThaiXoaTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}