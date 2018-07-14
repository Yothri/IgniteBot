using System;
using System.Windows.Forms;

namespace Engine
{
    public class Program
    {
        [STAThread]
        public static int Initialize(String pwzArgument)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
            return 0;
        }
    }
}