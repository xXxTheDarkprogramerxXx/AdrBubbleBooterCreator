using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace AdrBubbleBooterCreatorNS
{
	// Token: 0x02000008 RID: 8
	public class BitmapCopyToBpp
	{
		// Token: 0x06000022 RID: 34 RVA: 0x0012A778 File Offset: 0x00128978
		public static Bitmap CopyToBpp(Bitmap b, int bpp)
		{
			if (bpp != 1 && bpp != 8)
			{
				throw new ArgumentException("1 or 8", "bpp");
			}
			int width = b.Width;
			int height = b.Height;
			IntPtr hbitmap = b.GetHbitmap();
			BitmapCopyToBpp.BITMAPINFO bitmapinfo = default(BitmapCopyToBpp.BITMAPINFO);
			bitmapinfo.biSize = 40u;
			bitmapinfo.biWidth = width;
			bitmapinfo.biHeight = height;
			bitmapinfo.biPlanes = 1;
			checked
			{
				bitmapinfo.biBitCount = (short)bpp;
				bitmapinfo.biCompression = BitmapCopyToBpp.BI_RGB;
				bitmapinfo.biSizeImage = (uint)Math.Round((double)(unchecked((long)(checked(width + 7)) & (long)((ulong)-8)) * unchecked((long)height)) / 8.0);
				bitmapinfo.biXPelsPerMeter = 1000000;
				bitmapinfo.biYPelsPerMeter = 1000000;
				uint num = 1u << bpp;
				bitmapinfo.biClrUsed = num;
				bitmapinfo.biClrImportant = num;
				bitmapinfo.cols = new uint[256];
				if (bpp == 1)
				{
					bitmapinfo.cols[0] = BitmapCopyToBpp.MAKERGB(0, 0, 0);
					bitmapinfo.cols[1] = BitmapCopyToBpp.MAKERGB(255, 255, 255);
				}
				else
				{
					int num2 = 0;
					int num3 = (int)(unchecked((ulong)num) - 1UL);
					for (int i = num2; i <= num3; i++)
					{
						bitmapinfo.cols[i] = BitmapCopyToBpp.MAKERGB(i, i, i);
					}
				}
				IntPtr intPtr2;
				IntPtr intPtr = BitmapCopyToBpp.CreateDIBSection(IntPtr.Zero, ref bitmapinfo, BitmapCopyToBpp.DIB_RGB_COLORS, ref intPtr2, IntPtr.Zero, 0u);
				IntPtr dc = BitmapCopyToBpp.GetDC(IntPtr.Zero);
				IntPtr intPtr3 = BitmapCopyToBpp.CreateCompatibleDC(dc);
				BitmapCopyToBpp.SelectObject(intPtr3, hbitmap);
				IntPtr intPtr4 = BitmapCopyToBpp.CreateCompatibleDC(dc);
				BitmapCopyToBpp.SelectObject(intPtr4, intPtr);
				BitmapCopyToBpp.BitBlt(intPtr4, 0, 0, width, height, intPtr3, 0, 0, BitmapCopyToBpp.SRCCOPY);
				Bitmap result = Image.FromHbitmap(intPtr);
				BitmapCopyToBpp.DeleteDC(intPtr3);
				BitmapCopyToBpp.DeleteDC(intPtr4);
				BitmapCopyToBpp.ReleaseDC(IntPtr.Zero, dc);
				BitmapCopyToBpp.DeleteObject(hbitmap);
				BitmapCopyToBpp.DeleteObject(intPtr);
				return result;
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0012A95C File Offset: 0x00128B5C
		private static void SplashImage(Bitmap b, int x, int y)
		{
			IntPtr hbitmap = b.GetHbitmap();
			IntPtr dc = BitmapCopyToBpp.GetDC(IntPtr.Zero);
			IntPtr intPtr = BitmapCopyToBpp.CreateCompatibleDC(dc);
			BitmapCopyToBpp.SelectObject(intPtr, hbitmap);
			BitmapCopyToBpp.BitBlt(dc, x, y, b.Width, b.Height, intPtr, 0, 0, BitmapCopyToBpp.SRCCOPY);
			BitmapCopyToBpp.DeleteDC(intPtr);
			BitmapCopyToBpp.ReleaseDC(IntPtr.Zero, dc);
			BitmapCopyToBpp.DeleteObject(hbitmap);
		}

		// Token: 0x06000024 RID: 36
		[DllImport("gdi32.dll")]
		public static extern bool DeleteObject(IntPtr hObject);

		// Token: 0x06000025 RID: 37
		[DllImport("user32.dll")]
		public static extern IntPtr GetDC(IntPtr hwnd);

		// Token: 0x06000026 RID: 38
		[DllImport("gdi32.dll")]
		public static extern IntPtr CreateCompatibleDC(IntPtr hdc);

		// Token: 0x06000027 RID: 39
		[DllImport("user32.dll")]
		public static extern int ReleaseDC(IntPtr hwnd, IntPtr hdc);

		// Token: 0x06000028 RID: 40
		[DllImport("gdi32.dll")]
		public static extern int DeleteDC(IntPtr hdc);

		// Token: 0x06000029 RID: 41
		[DllImport("gdi32.dll")]
		public static extern IntPtr SelectObject(IntPtr hdc, IntPtr hgdiobj);

		// Token: 0x0600002A RID: 42
		[DllImport("gdi32.dll")]
		public static extern int BitBlt(IntPtr hdcDst, int xDst, int yDst, int w, int h, IntPtr hdcSrc, int xSrc, int ySrc, int rop);

		// Token: 0x0600002B RID: 43
		[DllImport("gdi32.dll")]
		private static extern IntPtr CreateDIBSection(IntPtr hdc, ref BitmapCopyToBpp.BITMAPINFO bmi, uint Usage, ref IntPtr bits, IntPtr hSection, uint dwOffset);

		// Token: 0x0600002C RID: 44 RVA: 0x0012A9C4 File Offset: 0x00128BC4
		private static uint MAKERGB(int r, int g, int b)
		{
			return checked((uint)(b & 255) | (uint)((uint)(r & 255) << 8) | (uint)((uint)(g & 255) << 16));
		}

		// Token: 0x04000009 RID: 9
		private static int SRCCOPY = 13369376;

		// Token: 0x0400000A RID: 10
		private static uint BI_RGB = 0u;

		// Token: 0x0400000B RID: 11
		private static uint DIB_RGB_COLORS = 0u;

		// Token: 0x02000009 RID: 9
		public struct BITMAPINFO
		{
			// Token: 0x0400000C RID: 12
			public uint biSize;

			// Token: 0x0400000D RID: 13
			public int biWidth;

			// Token: 0x0400000E RID: 14
			public int biHeight;

			// Token: 0x0400000F RID: 15
			public short biPlanes;

			// Token: 0x04000010 RID: 16
			public short biBitCount;

			// Token: 0x04000011 RID: 17
			public uint biCompression;

			// Token: 0x04000012 RID: 18
			public uint biSizeImage;

			// Token: 0x04000013 RID: 19
			public int biXPelsPerMeter;

			// Token: 0x04000014 RID: 20
			public int biYPelsPerMeter;

			// Token: 0x04000015 RID: 21
			public uint biClrUsed;

			// Token: 0x04000016 RID: 22
			public uint biClrImportant;

			// Token: 0x04000017 RID: 23
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
			public uint[] cols;
		}
	}
}
