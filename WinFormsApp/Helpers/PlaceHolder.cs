using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Helpers
{
    public  class PlaceHolder
    {
        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        public static void SetPlaceHolder(nint textboxHandle ,string message)
        {
            SendMessage(textboxHandle, EM_SETCUEBANNER, 0, message);
        }
    }
}
