using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_ManagementKaraoke
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var mutex = new System.Threading.Mutex(false, Application.ProductName))
            {
                if (!mutex.WaitOne(0, false))
                {
                    MessageBox.Show("Ứng dụng đang chạy, không thể chạy thêm !!");
                    return;
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Nguoi_Dung());
            }
        }
    }
}
