using System;
using System.Drawing;
using System.IO;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace AdrBubbleBooterCreatorNS
{
	// Token: 0x02000011 RID: 17
	[StandardModule]
	internal sealed class Utils
	{
		// Token: 0x060000AB RID: 171 RVA: 0x0012AF6C File Offset: 0x0012916C
		public static byte[] ImageToBytes(Image Img)
		{
			byte[] result = null;
			if (Img != null)
			{
				MemoryStream memoryStream = new MemoryStream();
				Img.Save(memoryStream, Img.RawFormat);
				result = memoryStream.GetBuffer();
			}
			return result;
		}

		// Token: 0x02000012 RID: 18
		public class BytesHexConverter
		{
			// Token: 0x060000AD RID: 173 RVA: 0x0012AFA4 File Offset: 0x001291A4
			public static byte[] HexStringToBytes(string strInput)
			{
				int num = strInput.Length / 2;
				checked
				{
					byte[] array = new byte[num - 1 + 1];
					int num2 = 0;
					int num3 = num - 1;
					for (int i = num2; i <= num3; i++)
					{
						array[i] = Convert.ToByte(strInput.Substring(i * 2, 2), 16);
					}
					return array;
				}
			}

			// Token: 0x060000AE RID: 174 RVA: 0x0012AFEC File Offset: 0x001291EC
			public static string BytesToHexString(byte[] bytes_Input)
			{
				StringBuilder stringBuilder = new StringBuilder(checked(bytes_Input.Length * 2));
				foreach (byte b in bytes_Input)
				{
					stringBuilder.Append(b.ToString("X02"));
				}
				return stringBuilder.ToString();
			}
		}
	}
}
