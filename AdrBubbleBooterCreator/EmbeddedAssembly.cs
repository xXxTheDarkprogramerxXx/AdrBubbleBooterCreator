using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using Microsoft.VisualBasic.CompilerServices;

namespace AdrBubbleBooterCreatorNS
{
	// Token: 0x0200000A RID: 10
	public class EmbeddedAssembly
	{
		// Token: 0x0600002F RID: 47 RVA: 0x0012AA00 File Offset: 0x00128C00
		public static void Load(string embeddedResource, string fileName)
		{
			if (EmbeddedAssembly.dic == null)
			{
				EmbeddedAssembly.dic = new Dictionary<string, Assembly>();
			}
			byte[] array = null;
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			checked
			{
				Assembly assembly;
				using (Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(embeddedResource))
				{
					if (manifestResourceStream == null)
					{
						throw new Exception(embeddedResource + " is not found in Embedded Resources.");
					}
					array = new byte[(int)manifestResourceStream.Length - 1 + 1];
					manifestResourceStream.Read(array, 0, (int)manifestResourceStream.Length);
					try
					{
						assembly = Assembly.Load(array);
						EmbeddedAssembly.dic.Add(assembly.FullName, assembly);
						return;
					}
					catch (Exception ex)
					{
					}
				}
				bool flag = false;
				string path = "";
				using (SHA1CryptoServiceProvider sha1CryptoServiceProvider = new SHA1CryptoServiceProvider())
				{
					string left = BitConverter.ToString(sha1CryptoServiceProvider.ComputeHash(array)).Replace("-", string.Empty);
					path = Path.GetTempPath() + fileName;
					if (File.Exists(path))
					{
						byte[] buffer = File.ReadAllBytes(path);
						string right = BitConverter.ToString(sha1CryptoServiceProvider.ComputeHash(buffer)).Replace("-", string.Empty);
						if (Operators.CompareString(left, right, false) == 0)
						{
							flag = true;
						}
						else
						{
							flag = false;
						}
					}
					else
					{
						flag = false;
					}
				}
				if (!flag)
				{
					File.WriteAllBytes(path, array);
				}
				assembly = Assembly.LoadFile(path);
				EmbeddedAssembly.dic.Add(assembly.FullName, assembly);
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0012AB7C File Offset: 0x00128D7C
		public static Assembly Get(string assemblyFullName)
		{
			if (EmbeddedAssembly.dic == null || EmbeddedAssembly.dic.Count == 0)
			{
				return null;
			}
			if (EmbeddedAssembly.dic.ContainsKey(assemblyFullName))
			{
				return EmbeddedAssembly.dic[assemblyFullName];
			}
			return null;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0012ABBC File Offset: 0x00128DBC
		public static void Load(byte[] embeddedResourceBytes, string fileName)
		{
			if (EmbeddedAssembly.dic == null)
			{
				EmbeddedAssembly.dic = new Dictionary<string, Assembly>();
			}
			Assembly assembly = Assembly.Load(embeddedResourceBytes);
			bool flag = false;
			string path = "";
			using (SHA1CryptoServiceProvider sha1CryptoServiceProvider = new SHA1CryptoServiceProvider())
			{
				string left = BitConverter.ToString(sha1CryptoServiceProvider.ComputeHash(embeddedResourceBytes)).Replace("-", string.Empty);
				path = Path.GetTempPath() + fileName;
				if (File.Exists(path))
				{
					byte[] buffer = File.ReadAllBytes(path);
					string right = BitConverter.ToString(sha1CryptoServiceProvider.ComputeHash(buffer)).Replace("-", string.Empty);
					if (Operators.CompareString(left, right, false) == 0)
					{
						flag = true;
					}
					else
					{
						flag = false;
					}
				}
				else
				{
					flag = false;
				}
			}
			if (!flag)
			{
				File.WriteAllBytes(path, embeddedResourceBytes);
			}
			assembly = Assembly.LoadFile(path);
			EmbeddedAssembly.dic.Add(assembly.FullName, assembly);
		}

		// Token: 0x04000018 RID: 24
		private static Dictionary<string, Assembly> dic = null;
	}
}
