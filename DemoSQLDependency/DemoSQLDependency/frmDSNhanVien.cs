using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSQLDependency
{
    public partial class frmDSNhanVien : Form
    {
        private int changeCount = 0;
        private const string tableName = "NHANVIEN";
        private const string statusMessage = "Đã có {0} thay đổi.";

        private SqlConnection connection = null;
        private SqlCommand command = null;
        private DataSet dataToWatch = null;

        private string sqlQuery = "SELECT MANV,HO,TEN,DIACHI,NGAYSINH,LUONG,MACN,TrangThaiXoa FROM dbo.NhanVien";

        public frmDSNhanVien()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }

        public static string GetConnectionString()
        {
            return Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                                Program.database + ";User ID=" +
                                Program.mlogin + ";password=" + Program.password;
        }

        private bool CanRequestNotifications()
        {
            try
            {
                SqlClientPermission perm = new SqlClientPermission(PermissionState.Unrestricted);
                perm.Demand();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: "+ex);
                return false;
            }
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            if (CanRequestNotifications() == true)
            {
                BatDau();
            }
            else
            {
                MessageBox.Show("Bạn chưa kích hoạt dịch vụ Broker");
            }
                
        }

        private void BatDau()
        {
            changeCount = 0;
            SqlDependency.Stop(GetConnectionString());
            try
            {
                SqlDependency.Start(GetConnectionString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex);
                return;
            }
            if (connection == null)
            {
                connection = new SqlConnection(GetConnectionString());
                connection.Open();
            }
            if (command == null)
                command = new SqlCommand(sqlQuery, connection);

            if (dataToWatch == null)
                dataToWatch = new DataSet();
            GetData();
        }

        private void GetData()
        {
            dataToWatch.Clear();
            command.Notification = null;

            SqlDependency dependency = new SqlDependency(command);
            dependency.OnChange += dependency_OnChange;

            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                adapter.Fill(dataToWatch, tableName);

                this.dataGridView1.DataSource = dataToWatch;
                this.dataGridView1.DataMember = tableName;
            }
        }

        private void dependency_OnChange(object sender, SqlNotificationEventArgs e)
        {
            ISynchronizeInvoke i = (ISynchronizeInvoke)this;
            if (i.InvokeRequired)
            {
                OnChangeEventHandler tempDelegate = new OnChangeEventHandler(dependency_OnChange);

                object[] args = new[] { sender, e };

                i.BeginInvoke(tempDelegate, args);

                return;
            }

            SqlDependency dependency = (SqlDependency)sender;

            dependency.OnChange -= dependency_OnChange;

            changeCount += 1;
            this.label1.Text = string.Format(statusMessage, changeCount);

 
            var withBlock = this.listboxTinhTrang.Items;
                withBlock.Clear();
                withBlock.Add("Info:   " + e.Info.ToString());
                withBlock.Add("Source: " + e.Source.ToString());
                withBlock.Add("Type:   " + e.Type.ToString());

            GetData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmNhanVien frmNV = new frmNhanVien();
            frmNV.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát khỏi form?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void frmDSNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            SqlDependency.Stop(GetConnectionString());
            if (connection != null)
                connection.Close();
        }
    }
}
