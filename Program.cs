using System;
using System.Windows.Forms;

namespace Minecraft_Server_Status
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Screen1());
        }
    }
}
