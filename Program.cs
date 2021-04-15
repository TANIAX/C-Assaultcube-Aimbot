using System;
using System.Windows.Forms;

namespace Aimbot_cSharp
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CustomAimbot());
        }
    }
}