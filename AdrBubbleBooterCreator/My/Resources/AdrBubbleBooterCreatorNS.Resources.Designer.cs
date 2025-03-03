using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AdrBubbleBooterCreatorNS.My.Resources
{
	// Token: 0x0200000E RID: 14
	[HideModuleName]
	[StandardModule]
	[CompilerGenerated]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	internal sealed class Resources
	{
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600009A RID: 154 RVA: 0x0012ACA0 File Offset: 0x00128EA0
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(Resources.resourceMan, null))
				{
					ResourceManager resourceManager = new ResourceManager("AdrBubbleBooterCreatorNS.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600009B RID: 155 RVA: 0x0012ACE0 File Offset: 0x00128EE0
		// (set) Token: 0x0600009C RID: 156 RVA: 0x0012ACF4 File Offset: 0x00128EF4
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600009D RID: 157 RVA: 0x0012ACFC File Offset: 0x00128EFC
		internal static Bitmap bg0
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("bg0", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600009E RID: 158 RVA: 0x0012AD2C File Offset: 0x00128F2C
		internal static byte[] eboot
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("eboot", Resources.resourceCulture));
				return (byte[])objectValue;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600009F RID: 159 RVA: 0x0012AD5C File Offset: 0x00128F5C
		internal static Bitmap icon0
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("icon0", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x0012AD8C File Offset: 0x00128F8C
		internal static byte[] param
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("param", Resources.resourceCulture));
				return (byte[])objectValue;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x0012ADBC File Offset: 0x00128FBC
		internal static Bitmap pic0
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("pic0", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x0012ADEC File Offset: 0x00128FEC
		internal static byte[] pngquant
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("pngquant", Resources.resourceCulture));
				return (byte[])objectValue;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x0012AE1C File Offset: 0x0012901C
		internal static Bitmap pspbase
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("pspbase", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x0012AE4C File Offset: 0x0012904C
		internal static Bitmap startup
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("startup", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x0012AE7C File Offset: 0x0012907C
		internal static string template
		{
			get
			{
				return Resources.ResourceManager.GetString("template", Resources.resourceCulture);
			}
		}

		// Token: 0x0400003F RID: 63
		private static ResourceManager resourceMan;

		// Token: 0x04000040 RID: 64
		private static CultureInfo resourceCulture;
	}
}
