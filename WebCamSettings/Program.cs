using System;
using System.Runtime.InteropServices;

namespace WebCamSettings
{
	class Program
	{
		[DllImport("user32", EntryPoint = "SendMessage")]
		public static extern int SendMessage(int hWnd, uint Msg, int wParam, int lParam);

		[DllImport("avicap32.dll", EntryPoint = "capCreateCaptureWindowA")]
		public static extern int capCreateCaptureWindowA(string lpszWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, int hwndParent, int nID);

		static int mCapHwnd;

		private static void Main()
		{
			mCapHwnd = capCreateCaptureWindowA("WebCap", 0, 0, 0, 0, 0, 0, 0);
			SendMessage(mCapHwnd, 1034, 0, 0);
			SendMessage(mCapHwnd, 1066, 0, 0);
		}
	}
}
