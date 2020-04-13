using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSQLDependency
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
            btnGhi.Enabled = false;
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNhanVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.DS.NhanVien);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bdsNhanVien.AddNew();
            btnThem.Enabled = false;
            dgv_NV.Enabled = false;
            btnGhi.Enabled = true;
            btnXoa.Enabled = false;
            btnThoat.Enabled = true;
            txtMaNV.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult yn;
            yn = MessageBox.Show("Bạn có thật sự muốn xóa nhân viên này ?\n Nếu xóa, thì username của nhân viên cũng sẽ mất theo.", "Notification", MessageBoxButtons.YesNo);
            if (yn == DialogResult.Yes)
            {
                try
                {
                    bdsNhanVien.RemoveCurrent();
                    nhanVienTableAdapter.Update(DS.NhanVien);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên.\n" + ex.Message, "Notification", MessageBoxButtons.OK);
                    return;
                }
            }

            if (bdsNhanVien.Count == 0)
            {
                btnXoa.Enabled = false;
                btnGhi.Enabled = true;
            }
            else
            {
                btnXoa.Enabled = true;
            }
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            try
            {
                bdsNhanVien.EndEdit();
                bdsNhanVien.ResetCurrentItem();

                nhanVienTableAdapter.Update(DS.NhanVien);
            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Ghi. Bạn kiểm tra lại thông tin nhân viên trứơc khi ghi" + ex.Message, "Notification", MessageBoxButtons.OK);
            }

            dgv_NV.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnGhi.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát khỏi form?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        
    }
}
