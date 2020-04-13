using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSQLDependency
{
    static class Program
    {
        public static String connstr;
        public static String servername = "DESKTOP-MDI30DF";
        public static String mlogin = "sa";
        public static String password = "123";
        public static String database = "QLVT_DATHANG";
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDSNhanVien());
        }
    }
}
