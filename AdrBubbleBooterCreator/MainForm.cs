using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using AdrBubbleBooterCreatorNS.My.Resources;
using Ionic.Zip;
using Microsoft.VisualBasic.CompilerServices;

namespace AdrBubbleBooterCreatorNS
{
	// Token: 0x0200000B RID: 11
	[DesignerGenerated]
	public partial class MainForm : Form
	{
		// Token: 0x06000032 RID: 50 RVA: 0x0012B534 File Offset: 0x00129734
		public MainForm()
		{
			base.Load += this.MainForm_Load;
			base.FormClosing += this.MainForm_FormClosing;
			this.pngquant = string.Concat(new string[]
			{
				Path.GetTempPath(),
				Conversions.ToString(Path.DirectorySeparatorChar),
				Path.GetRandomFileName(),
				Conversions.ToString(Path.DirectorySeparatorChar),
				"pngquant.exe"
			});
			this.pngquant_exported = false;
			this.InitializeComponent();
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000035 RID: 53 RVA: 0x0012C9A8 File Offset: 0x0012ABA8
		// (set) Token: 0x06000036 RID: 54 RVA: 0x0012C9BC File Offset: 0x0012ABBC
		internal virtual Button ButtonAbout
		{
			get
			{
				return this._ButtonAbout;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonAbout_Click);
				if (this._ButtonAbout != null)
				{
					this._ButtonAbout.Click -= value2;
				}
				this._ButtonAbout = value;
				if (this._ButtonAbout != null)
				{
					this._ButtonAbout.Click += value2;
				}
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000037 RID: 55 RVA: 0x0012CA08 File Offset: 0x0012AC08
		// (set) Token: 0x06000038 RID: 56 RVA: 0x0012CA1C File Offset: 0x0012AC1C
		internal virtual Button ButtonHomepage
		{
			get
			{
				return this._ButtonHomepage;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonHomepage_Click);
				if (this._ButtonHomepage != null)
				{
					this._ButtonHomepage.Click -= value2;
				}
				this._ButtonHomepage = value;
				if (this._ButtonHomepage != null)
				{
					this._ButtonHomepage.Click += value2;
				}
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000039 RID: 57 RVA: 0x0012CA68 File Offset: 0x0012AC68
		// (set) Token: 0x0600003A RID: 58 RVA: 0x0012CA7C File Offset: 0x0012AC7C
		internal virtual Button ButtonDonate
		{
			get
			{
				return this._ButtonDonate;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonDonate_Click);
				if (this._ButtonDonate != null)
				{
					this._ButtonDonate.Click -= value2;
				}
				this._ButtonDonate = value;
				if (this._ButtonDonate != null)
				{
					this._ButtonDonate.Click += value2;
				}
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600003B RID: 59 RVA: 0x0012CAC8 File Offset: 0x0012ACC8
		// (set) Token: 0x0600003C RID: 60 RVA: 0x0012CADC File Offset: 0x0012ACDC
		internal virtual Button ButtonClear
		{
			get
			{
				return this._ButtonClear;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonClear_Click);
				if (this._ButtonClear != null)
				{
					this._ButtonClear.Click -= value2;
				}
				this._ButtonClear = value;
				if (this._ButtonClear != null)
				{
					this._ButtonClear.Click += value2;
				}
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600003D RID: 61 RVA: 0x0012CB28 File Offset: 0x0012AD28
		// (set) Token: 0x0600003E RID: 62 RVA: 0x0012CB3C File Offset: 0x0012AD3C
		internal virtual Button ButtonCreate
		{
			get
			{
				return this._ButtonCreate;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonCreate_Click);
				if (this._ButtonCreate != null)
				{
					this._ButtonCreate.Click -= value2;
				}
				this._ButtonCreate = value;
				if (this._ButtonCreate != null)
				{
					this._ButtonCreate.Click += value2;
				}
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600003F RID: 63 RVA: 0x0012CB88 File Offset: 0x0012AD88
		// (set) Token: 0x06000040 RID: 64 RVA: 0x0012CB9C File Offset: 0x0012AD9C
		internal virtual Label LabelTitle
		{
			get
			{
				return this._LabelTitle;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelTitle = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000041 RID: 65 RVA: 0x0012CBA8 File Offset: 0x0012ADA8
		// (set) Token: 0x06000042 RID: 66 RVA: 0x0012CBBC File Offset: 0x0012ADBC
		internal virtual TextBox TextBoxTitle
		{
			get
			{
				return this._TextBoxTitle;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBoxTitle = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000043 RID: 67 RVA: 0x0012CBC8 File Offset: 0x0012ADC8
		// (set) Token: 0x06000044 RID: 68 RVA: 0x0012CBDC File Offset: 0x0012ADDC
		internal virtual TextBox TextBoxTitleId
		{
			get
			{
				return this._TextBoxTitleId;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBoxTitleId = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000045 RID: 69 RVA: 0x0012CBE8 File Offset: 0x0012ADE8
		// (set) Token: 0x06000046 RID: 70 RVA: 0x0012CBFC File Offset: 0x0012ADFC
		internal virtual Label LabelTitleId
		{
			get
			{
				return this._LabelTitleId;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelTitleId = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000047 RID: 71 RVA: 0x0012CC08 File Offset: 0x0012AE08
		// (set) Token: 0x06000048 RID: 72 RVA: 0x0012CC1C File Offset: 0x0012AE1C
		internal virtual TextBox TextBoxMs0
		{
			get
			{
				return this._TextBoxMs0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBoxMs0 = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000049 RID: 73 RVA: 0x0012CC28 File Offset: 0x0012AE28
		// (set) Token: 0x0600004A RID: 74 RVA: 0x0012CC3C File Offset: 0x0012AE3C
		internal virtual Label LabelMs0
		{
			get
			{
				return this._LabelMs0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelMs0 = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600004B RID: 75 RVA: 0x0012CC48 File Offset: 0x0012AE48
		// (set) Token: 0x0600004C RID: 76 RVA: 0x0012CC5C File Offset: 0x0012AE5C
		internal virtual TextBox TextBoxIcon0
		{
			get
			{
				return this._TextBoxIcon0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TextBoxIcon0_Click);
				DragEventHandler value3 = new DragEventHandler(this.TextBoxIcon0_DragDrop);
				DragEventHandler value4 = new DragEventHandler(this.TextBoxIcon0_DragEnter);
				if (this._TextBoxIcon0 != null)
				{
					this._TextBoxIcon0.Click -= value2;
					this._TextBoxIcon0.DragDrop -= value3;
					this._TextBoxIcon0.DragEnter -= value4;
				}
				this._TextBoxIcon0 = value;
				if (this._TextBoxIcon0 != null)
				{
					this._TextBoxIcon0.Click += value2;
					this._TextBoxIcon0.DragDrop += value3;
					this._TextBoxIcon0.DragEnter += value4;
				}
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600004D RID: 77 RVA: 0x0012CCF4 File Offset: 0x0012AEF4
		// (set) Token: 0x0600004E RID: 78 RVA: 0x0012CD08 File Offset: 0x0012AF08
		internal virtual Label LabelIcon0
		{
			get
			{
				return this._LabelIcon0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelIcon0 = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600004F RID: 79 RVA: 0x0012CD14 File Offset: 0x0012AF14
		// (set) Token: 0x06000050 RID: 80 RVA: 0x0012CD28 File Offset: 0x0012AF28
		internal virtual TextBox TextBoxBg0
		{
			get
			{
				return this._TextBoxBg0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TextBoxBg0_Click);
				DragEventHandler value3 = new DragEventHandler(this.TextBoxBg0_DragDrop);
				DragEventHandler value4 = new DragEventHandler(this.TextBoxBg0_DragEnter);
				if (this._TextBoxBg0 != null)
				{
					this._TextBoxBg0.Click -= value2;
					this._TextBoxBg0.DragDrop -= value3;
					this._TextBoxBg0.DragEnter -= value4;
				}
				this._TextBoxBg0 = value;
				if (this._TextBoxBg0 != null)
				{
					this._TextBoxBg0.Click += value2;
					this._TextBoxBg0.DragDrop += value3;
					this._TextBoxBg0.DragEnter += value4;
				}
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000051 RID: 81 RVA: 0x0012CDC0 File Offset: 0x0012AFC0
		// (set) Token: 0x06000052 RID: 82 RVA: 0x0012CDD4 File Offset: 0x0012AFD4
		internal virtual Label LabelBg0
		{
			get
			{
				return this._LabelBg0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelBg0 = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000053 RID: 83 RVA: 0x0012CDE0 File Offset: 0x0012AFE0
		// (set) Token: 0x06000054 RID: 84 RVA: 0x0012CDF4 File Offset: 0x0012AFF4
		internal virtual TextBox TextBoxStartup
		{
			get
			{
				return this._TextBoxStartup;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TextBoxStartup_Click);
				DragEventHandler value3 = new DragEventHandler(this.TextBoxStartup_DragDrop);
				DragEventHandler value4 = new DragEventHandler(this.TextBoxStartup_DragEnter);
				if (this._TextBoxStartup != null)
				{
					this._TextBoxStartup.Click -= value2;
					this._TextBoxStartup.DragDrop -= value3;
					this._TextBoxStartup.DragEnter -= value4;
				}
				this._TextBoxStartup = value;
				if (this._TextBoxStartup != null)
				{
					this._TextBoxStartup.Click += value2;
					this._TextBoxStartup.DragDrop += value3;
					this._TextBoxStartup.DragEnter += value4;
				}
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000055 RID: 85 RVA: 0x0012CE8C File Offset: 0x0012B08C
		// (set) Token: 0x06000056 RID: 86 RVA: 0x0012CEA0 File Offset: 0x0012B0A0
		internal virtual Label LabelStartup
		{
			get
			{
				return this._LabelStartup;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelStartup = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000057 RID: 87 RVA: 0x0012CEAC File Offset: 0x0012B0AC
		// (set) Token: 0x06000058 RID: 88 RVA: 0x0012CEC0 File Offset: 0x0012B0C0
		internal virtual TextBox TextBoxPic0
		{
			get
			{
				return this._TextBoxPic0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TextBoxPic0_Click);
				DragEventHandler value3 = new DragEventHandler(this.TextBoxPic0_DragDrop);
				DragEventHandler value4 = new DragEventHandler(this.TextBoxPic0_DragEnter);
				if (this._TextBoxPic0 != null)
				{
					this._TextBoxPic0.Click -= value2;
					this._TextBoxPic0.DragDrop -= value3;
					this._TextBoxPic0.DragEnter -= value4;
				}
				this._TextBoxPic0 = value;
				if (this._TextBoxPic0 != null)
				{
					this._TextBoxPic0.Click += value2;
					this._TextBoxPic0.DragDrop += value3;
					this._TextBoxPic0.DragEnter += value4;
				}
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000059 RID: 89 RVA: 0x0012CF58 File Offset: 0x0012B158
		// (set) Token: 0x0600005A RID: 90 RVA: 0x0012CF6C File Offset: 0x0012B16C
		internal virtual Label LabelPic0
		{
			get
			{
				return this._LabelPic0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelPic0 = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600005B RID: 91 RVA: 0x0012CF78 File Offset: 0x0012B178
		// (set) Token: 0x0600005C RID: 92 RVA: 0x0012CF8C File Offset: 0x0012B18C
		internal virtual Label LabelDriver
		{
			get
			{
				return this._LabelDriver;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelDriver = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600005D RID: 93 RVA: 0x0012CF98 File Offset: 0x0012B198
		// (set) Token: 0x0600005E RID: 94 RVA: 0x0012CFAC File Offset: 0x0012B1AC
		internal virtual ComboBox ComboBoxDriver
		{
			get
			{
				return this._ComboBoxDriver;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ComboBoxDriver_SelectedIndexChanged);
				if (this._ComboBoxDriver != null)
				{
					this._ComboBoxDriver.SelectedIndexChanged -= value2;
				}
				this._ComboBoxDriver = value;
				if (this._ComboBoxDriver != null)
				{
					this._ComboBoxDriver.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600005F RID: 95 RVA: 0x0012CFF8 File Offset: 0x0012B1F8
		// (set) Token: 0x06000060 RID: 96 RVA: 0x0012D00C File Offset: 0x0012B20C
		internal virtual ComboBox ComboBoxExecute
		{
			get
			{
				return this._ComboBoxExecute;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ComboBoxExecute_SelectedIndexChanged);
				if (this._ComboBoxExecute != null)
				{
					this._ComboBoxExecute.SelectedIndexChanged -= value2;
				}
				this._ComboBoxExecute = value;
				if (this._ComboBoxExecute != null)
				{
					this._ComboBoxExecute.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000061 RID: 97 RVA: 0x0012D058 File Offset: 0x0012B258
		// (set) Token: 0x06000062 RID: 98 RVA: 0x0012D06C File Offset: 0x0012B26C
		internal virtual Label LabelExecute
		{
			get
			{
				return this._LabelExecute;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelExecute = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000063 RID: 99 RVA: 0x0012D078 File Offset: 0x0012B278
		// (set) Token: 0x06000064 RID: 100 RVA: 0x0012D08C File Offset: 0x0012B28C
		internal virtual ComboBox ComboBoxPlugins
		{
			get
			{
				return this._ComboBoxPlugins;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ComboBoxPlugins_SelectedIndexChanged);
				if (this._ComboBoxPlugins != null)
				{
					this._ComboBoxPlugins.SelectedIndexChanged -= value2;
				}
				this._ComboBoxPlugins = value;
				if (this._ComboBoxPlugins != null)
				{
					this._ComboBoxPlugins.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000065 RID: 101 RVA: 0x0012D0D8 File Offset: 0x0012B2D8
		// (set) Token: 0x06000066 RID: 102 RVA: 0x0012D0EC File Offset: 0x0012B2EC
		internal virtual Label LabelPlugins
		{
			get
			{
				return this._LabelPlugins;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelPlugins = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000067 RID: 103 RVA: 0x0012D0F8 File Offset: 0x0012B2F8
		// (set) Token: 0x06000068 RID: 104 RVA: 0x0012D10C File Offset: 0x0012B30C
		internal virtual LinkLabel LinkLabelOpenBg0
		{
			get
			{
				return this._LinkLabelOpenBg0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler value2 = new LinkLabelLinkClickedEventHandler(this.LinkLabelOpenBg0_LinkClicked);
				if (this._LinkLabelOpenBg0 != null)
				{
					this._LinkLabelOpenBg0.LinkClicked -= value2;
				}
				this._LinkLabelOpenBg0 = value;
				if (this._LinkLabelOpenBg0 != null)
				{
					this._LinkLabelOpenBg0.LinkClicked += value2;
				}
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000069 RID: 105 RVA: 0x0012D158 File Offset: 0x0012B358
		// (set) Token: 0x0600006A RID: 106 RVA: 0x0012D16C File Offset: 0x0012B36C
		internal virtual LinkLabel LinkLabelOpenIcon0
		{
			get
			{
				return this._LinkLabelOpenIcon0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler value2 = new LinkLabelLinkClickedEventHandler(this.LinkLabelOpenIcon0_LinkClicked);
				if (this._LinkLabelOpenIcon0 != null)
				{
					this._LinkLabelOpenIcon0.LinkClicked -= value2;
				}
				this._LinkLabelOpenIcon0 = value;
				if (this._LinkLabelOpenIcon0 != null)
				{
					this._LinkLabelOpenIcon0.LinkClicked += value2;
				}
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600006B RID: 107 RVA: 0x0012D1B8 File Offset: 0x0012B3B8
		// (set) Token: 0x0600006C RID: 108 RVA: 0x0012D1CC File Offset: 0x0012B3CC
		internal virtual LinkLabel LinkLabelStartup
		{
			get
			{
				return this._LinkLabelStartup;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler value2 = new LinkLabelLinkClickedEventHandler(this.LinkLabelStartup_LinkClicked);
				if (this._LinkLabelStartup != null)
				{
					this._LinkLabelStartup.LinkClicked -= value2;
				}
				this._LinkLabelStartup = value;
				if (this._LinkLabelStartup != null)
				{
					this._LinkLabelStartup.LinkClicked += value2;
				}
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600006D RID: 109 RVA: 0x0012D218 File Offset: 0x0012B418
		// (set) Token: 0x0600006E RID: 110 RVA: 0x0012D22C File Offset: 0x0012B42C
		internal virtual LinkLabel LinkLabelOpenPic0
		{
			get
			{
				return this._LinkLabelOpenPic0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler value2 = new LinkLabelLinkClickedEventHandler(this.LinkLabelOpenPic0_LinkClicked);
				if (this._LinkLabelOpenPic0 != null)
				{
					this._LinkLabelOpenPic0.LinkClicked -= value2;
				}
				this._LinkLabelOpenPic0 = value;
				if (this._LinkLabelOpenPic0 != null)
				{
					this._LinkLabelOpenPic0.LinkClicked += value2;
				}
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600006F RID: 111 RVA: 0x0012D278 File Offset: 0x0012B478
		// (set) Token: 0x06000070 RID: 112 RVA: 0x0012D28C File Offset: 0x0012B48C
		internal virtual PictureBox PictureBoxImage
		{
			get
			{
				return this._PictureBoxImage;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBoxImage = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000071 RID: 113 RVA: 0x0012D298 File Offset: 0x0012B498
		// (set) Token: 0x06000072 RID: 114 RVA: 0x0012D2AC File Offset: 0x0012B4AC
		internal virtual ComboBox ComboBoxIcon0Style
		{
			get
			{
				return this._ComboBoxIcon0Style;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ComboBoxIcon0Style_SelectedIndexChanged);
				if (this._ComboBoxIcon0Style != null)
				{
					this._ComboBoxIcon0Style.SelectedIndexChanged -= value2;
				}
				this._ComboBoxIcon0Style = value;
				if (this._ComboBoxIcon0Style != null)
				{
					this._ComboBoxIcon0Style.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000073 RID: 115 RVA: 0x0012D2F8 File Offset: 0x0012B4F8
		// (set) Token: 0x06000074 RID: 116 RVA: 0x0012D30C File Offset: 0x0012B50C
		internal virtual Label LabelIcon0Style
		{
			get
			{
				return this._LabelIcon0Style;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelIcon0Style = value;
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0012D318 File Offset: 0x0012B518
		private void MainForm_Load(object sender, EventArgs e)
		{
			this.ComboBoxDriver.Text = "DEFAULT";
			this.ComboBoxExecute.Text = "DEFAULT";
			this.ComboBoxPlugins.Text = "DEFAULT";
			this.ComboBoxIcon0Style.Text = "PSP";
			try
			{
				Directory.CreateDirectory(Path.GetDirectoryName(this.pngquant));
				File.WriteAllBytes(this.pngquant, Resources.pngquant);
				this.pngquant_exported = true;
			}
			catch (Exception ex)
			{
				this.pngquant_exported = false;
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0012D3B4 File Offset: 0x0012B5B4
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				Directory.Delete(Path.GetDirectoryName(this.pngquant), true);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0012D3F0 File Offset: 0x0012B5F0
		private void TextBoxIcon0_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Copy;
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0012D40C File Offset: 0x0012B60C
		private void TextBoxIcon0_DragDrop(object sender, DragEventArgs e)
		{
			try
			{
				foreach (object value in ((IEnumerable)e.Data.GetData(DataFormats.FileDrop)))
				{
					string text = Conversions.ToString(value);
					if (File.Exists(text) && Conversions.ToBoolean(this.IsImage(text)))
					{
						this.TextBoxIcon0.Text = text;
						break;
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0012D494 File Offset: 0x0012B694
		private void TextBoxBg0_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Copy;
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0012D4B0 File Offset: 0x0012B6B0
		private void TextBoxBg0_DragDrop(object sender, DragEventArgs e)
		{
			try
			{
				foreach (object value in ((IEnumerable)e.Data.GetData(DataFormats.FileDrop)))
				{
					string text = Conversions.ToString(value);
					if (File.Exists(text) && Conversions.ToBoolean(this.IsImage(text)))
					{
						this.TextBoxBg0.Text = text;
						break;
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0012D538 File Offset: 0x0012B738
		private void TextBoxStartup_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Copy;
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0012D554 File Offset: 0x0012B754
		private void TextBoxStartup_DragDrop(object sender, DragEventArgs e)
		{
			try
			{
				foreach (object value in ((IEnumerable)e.Data.GetData(DataFormats.FileDrop)))
				{
					string text = Conversions.ToString(value);
					if (File.Exists(text) && Conversions.ToBoolean(this.IsImage(text)))
					{
						this.TextBoxStartup.Text = text;
						break;
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0012D5DC File Offset: 0x0012B7DC
		private void TextBoxPic0_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Copy;
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0012D5F8 File Offset: 0x0012B7F8
		private void TextBoxPic0_DragDrop(object sender, DragEventArgs e)
		{
			try
			{
				foreach (object value in ((IEnumerable)e.Data.GetData(DataFormats.FileDrop)))
				{
					string text = Conversions.ToString(value);
					if (File.Exists(text) && Conversions.ToBoolean(this.IsImage(text)))
					{
						this.TextBoxPic0.Text = text;
						break;
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0012D680 File Offset: 0x0012B880
		private void LinkLabelOpenIcon0_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.OpenFileDialogImages(this.TextBoxIcon0);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0012D690 File Offset: 0x0012B890
		private void LinkLabelOpenBg0_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.OpenFileDialogImages(this.TextBoxBg0);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0012D6A0 File Offset: 0x0012B8A0
		private void LinkLabelStartup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.OpenFileDialogImages(this.TextBoxStartup);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0012D6B0 File Offset: 0x0012B8B0
		private void LinkLabelOpenPic0_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.OpenFileDialogImages(this.TextBoxPic0);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0012D6C0 File Offset: 0x0012B8C0
		private void TextBoxIcon0_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.TextBoxIcon0.Text.ToUpper(), "%DEFAULT%", false) == 0)
			{
				this.PictureBoxImage.Image = Resources.icon0;
			}
			else
			{
				this.SetImagePictureBox(this.TextBoxIcon0.Text);
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0012D710 File Offset: 0x0012B910
		private void TextBoxBg0_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.TextBoxBg0.Text.ToUpper(), "%DEFAULT%", false) == 0)
			{
				this.PictureBoxImage.Image = Resources.bg0;
			}
			else
			{
				this.SetImagePictureBox(this.TextBoxBg0.Text);
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0012D760 File Offset: 0x0012B960
		private void TextBoxStartup_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.TextBoxStartup.Text.ToUpper(), "%DEFAULT%", false) == 0)
			{
				this.PictureBoxImage.Image = Resources.startup;
			}
			else
			{
				this.SetImagePictureBox(this.TextBoxStartup.Text);
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0012D7B0 File Offset: 0x0012B9B0
		private void TextBoxPic0_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.TextBoxPic0.Text.ToUpper(), "%DEFAULT%", false) == 0)
			{
				this.PictureBoxImage.Image = Resources.pic0;
			}
			else
			{
				this.SetImagePictureBox(this.TextBoxPic0.Text);
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0012D800 File Offset: 0x0012BA00
		private void ComboBoxDriver_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0012D804 File Offset: 0x0012BA04
		private void ComboBoxExecute_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0012D808 File Offset: 0x0012BA08
		private void ComboBoxPlugins_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0012D80C File Offset: 0x0012BA0C
		private void ComboBoxIcon0Style_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0012D810 File Offset: 0x0012BA10
		private void OpenFileDialogImages(TextBox tbox)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			OpenFileDialog openFileDialog2 = openFileDialog;
			openFileDialog2.Multiselect = false;
			openFileDialog2.CheckFileExists = true;
			openFileDialog2.Filter = "Image files (*.PNG;*.BMP;*.JPG)|*.PNG;*.BMP;*.JPG|All files (*.*)|*.*";
			if (openFileDialog2.ShowDialog() == DialogResult.OK)
			{
				tbox.Text = openFileDialog2.FileName;
				this.SetImagePictureBox(openFileDialog2.FileName);
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0012D864 File Offset: 0x0012BA64
		private void SetImagePictureBox(string imgfile)
		{
			if (File.Exists(imgfile))
			{
				this.PictureBoxImage.Image = Image.FromFile(imgfile);
			}
			else
			{
				this.PictureBoxImage.Image = null;
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0012D890 File Offset: 0x0012BA90
		private void ButtonCreate_Click(object sender, EventArgs e)
		{
			try
			{
				string text = this.TextBoxTitle.Text;
				string text2 = this.TextBoxTitleId.Text;
				string text3 = this.TextBoxMs0.Text;
				string text4 = this.TextBoxIcon0.Text;
				string text5 = this.TextBoxBg0.Text;
				string text6 = this.TextBoxPic0.Text;
				string text7 = this.TextBoxStartup.Text;
				string text8 = this.ComboBoxDriver.Text;
				string text9 = this.ComboBoxExecute.Text;
				string text10 = this.ComboBoxPlugins.Text;
				string text11 = this.ComboBoxIcon0Style.Text;
				if (text.Length < 1)
				{
					MessageBox.Show("Title is not valid!", "Confirmation!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else if (!text2.ToUpper().StartsWith("PSPEMU"))
				{
					MessageBox.Show("TitleId must start with PSPEMU!", "Confirmation!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else if (text2.Length < 9)
				{
					MessageBox.Show("TitleId is not valid!", "Confirmation!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else if (text3.Length <= 5 | !text3.ToLower().StartsWith("ms0:/"))
				{
					MessageBox.Show("ms0: file path is not valid!", "Confirmation!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					this.Enabled = false;
					StringBuilder stringBuilder = new StringBuilder();
					stringBuilder.AppendLine("#=================================================");
					stringBuilder.Append("PATH").Append("=").Append(text3).AppendLine();
					stringBuilder.AppendLine("#=================================================");
					stringBuilder.Append("DRIVER").Append("=").Append(text8).AppendLine();
					stringBuilder.AppendLine("#=================================================");
					stringBuilder.Append("EXECUTE").Append("=").Append(text9).AppendLine();
					stringBuilder.AppendLine("#=================================================");
					stringBuilder.Append("PLUGINS").Append("=").Append(text10).AppendLine();
					stringBuilder.AppendLine("#=================================================");
					stringBuilder.AppendLine("# PATH    : ISO\\CSO\\PBP file");
					stringBuilder.AppendLine("# DRIVER  : INFERNO, MARCH33, NP9660");
					stringBuilder.AppendLine("# EXECUTE : EBOOT.BIN, EBOOT.OLD, BOOT.BIN");
					stringBuilder.AppendLine("# PLUGINS : DEFAULT, ENABLE, DISABLE");
					stringBuilder.AppendLine("#=================================================");
					stringBuilder.AppendLine("# IF YOU DO NOT WANT TO USE ONE OF THE CONFIGS");
					stringBuilder.AppendLine("# DELETE IT BY REMOVING THE WHOLE SINGLE LINE");
					stringBuilder.AppendLine("#=================================================");
					byte[] bytes = Encoding.UTF8.GetBytes(stringBuilder.ToString());
					byte[] bytes2 = Encoding.UTF8.GetBytes(text);
					byte[] bytes3 = Encoding.UTF8.GetBytes(text);
					byte[] bytes4 = BitConverter.GetBytes(Convert.ToUInt32(bytes2.Length));
					byte[] bytes5 = Encoding.ASCII.GetBytes(text2);
					Array.Resize<byte>(ref bytes3, 52);
					Array.Resize<byte>(ref bytes2, 128);
					MemoryStream memoryStream = new MemoryStream(Resources.param);
					memoryStream.Seek(712L, SeekOrigin.Begin);
					memoryStream.Write(bytes3, 0, bytes3.Length);
					memoryStream.Write(bytes2, 0, bytes2.Length);
					memoryStream.Seek(264L, SeekOrigin.Begin);
					memoryStream.Write(bytes4, 0, bytes4.Length);
					memoryStream.Seek(280L, SeekOrigin.Begin);
					memoryStream.Write(bytes4, 0, bytes4.Length);
					memoryStream.Seek(892L, SeekOrigin.Begin);
					memoryStream.Write(bytes5, 0, bytes5.Length);
					SaveFileDialog saveFileDialog = new SaveFileDialog();
					SaveFileDialog saveFileDialog2 = saveFileDialog;
					saveFileDialog2.CheckPathExists = true;
					saveFileDialog2.OverwritePrompt = true;
					saveFileDialog2.FileName = text2.ToUpper() + ".VPK";
					saveFileDialog2.Filter = "VPK files (*.VPK)|*.VPK";
					if (saveFileDialog2.ShowDialog() == DialogResult.OK)
					{
						string fileName = saveFileDialog2.FileName;
						if (File.Exists(fileName))
						{
							File.Delete(fileName);
						}
						using (ZipFile zipFile = new ZipFile(fileName))
						{
							zipFile.CompressionLevel = 9;
							zipFile.Comment = "Created By AdrBubbleBooterCreator (c) LMAN 2017";
							zipFile.AddDirectoryByName("data");
							zipFile.AddDirectoryByName("sce_sys/livearea/contents");
							zipFile.UpdateEntry("eboot.bin", Resources.eboot);
							zipFile.UpdateEntry("data/boot.inf", bytes);
							zipFile.UpdateEntry("sce_sys/param.sfo", memoryStream.ToArray());
							string directoryName = Path.GetDirectoryName(this.pngquant);
							if (File.Exists(text4))
							{
								byte[] array = File.ReadAllBytes(text4);
								Image img = MainForm.ImageConverter.byteArrayToImage(ref array, ImageFormat.Png);
								Size size = new Size(128, 128);
								array = this.ResizeImage(img, size, false);
								if (Operators.CompareString(text11, "PSP", false) == 0)
								{
									array = this.ResizeIconImage(MainForm.ImageConverter.byteArrayToImage(ref array, ImageFormat.Png), MainForm.ICONStyle.PSPGame);
								}
								else if (Operators.CompareString(text11, "MINI\\PSONE", false) == 0)
								{
									array = this.ResizeIconImage(MainForm.ImageConverter.byteArrayToImage(ref array, ImageFormat.Png), MainForm.ICONStyle.MiniPSOne);
								}
								string path = "ICON0.PNG";
								string text12 = Path.Combine(directoryName, path);
								File.WriteAllBytes(text12, array);
								if (!this.RunProcess(this.pngquant, "-v -f %PNG% -o %PNG%".Replace("%PNG%", "\"" + text12 + "\""), directoryName).ToLower().Contains("error"))
								{
									array = File.ReadAllBytes(text12);
									zipFile.AddEntry("sce_sys/icon0.png", array);
								}
							}
							else if (text4.ToUpper().StartsWith("DEFAULT") | text4.ToUpper().StartsWith("%DEFAULT%"))
							{
								zipFile.UpdateEntry("sce_sys/icon0.png", Utils.ImageToBytes(Resources.icon0));
							}
							if (File.Exists(text6))
							{
								byte[] array = File.ReadAllBytes(text6);
								Image img2 = MainForm.ImageConverter.byteArrayToImage(ref array, ImageFormat.Png);
								Size size = new Size(960, 544);
								array = this.ResizeImage(img2, size, false);
								string path = "PIC0.PNG";
								string text12 = Path.Combine(directoryName, path);
								File.WriteAllBytes(text12, array);
								if (!this.RunProcess(this.pngquant, "-v -f %PNG% -o %PNG%".Replace("%PNG%", "\"" + text12 + "\""), directoryName).ToLower().Contains("error"))
								{
									array = File.ReadAllBytes(text12);
									zipFile.AddEntry("sce_sys/pic0.png", array);
								}
							}
							else if (text6.ToUpper().StartsWith("DEFAULT") | text6.ToUpper().StartsWith("%DEFAULT%"))
							{
								zipFile.UpdateEntry("sce_sys/pic0.png", Utils.ImageToBytes(Resources.pic0));
							}
							if (File.Exists(text5))
							{
								byte[] array = File.ReadAllBytes(text5);
								Image img3 = MainForm.ImageConverter.byteArrayToImage(ref array, ImageFormat.Png);
								Size size = new Size(840, 500);
								array = this.ResizeImage(img3, size, false);
								string path = "BG0.PNG";
								string text12 = Path.Combine(directoryName, path);
								File.WriteAllBytes(text12, array);
								if (!this.RunProcess(this.pngquant, "-v -f %PNG% -o %PNG%".Replace("%PNG%", "\"" + text12 + "\""), directoryName).ToLower().Contains("error"))
								{
									array = File.ReadAllBytes(text12);
									zipFile.AddEntry("sce_sys/livearea/contents/bg0.png", array);
								}
							}
							else if (text5.ToUpper().ToUpper().StartsWith("DEFAULT") | text5.ToUpper().StartsWith("%DEFAULT%"))
							{
								zipFile.UpdateEntry("sce_sys/livearea/contents/bg0.png", Utils.ImageToBytes(Resources.bg0));
							}
							if (File.Exists(text7))
							{
								byte[] array = File.ReadAllBytes(text7);
								Image img4 = MainForm.ImageConverter.byteArrayToImage(ref array, ImageFormat.Png);
								Size size = new Size(144, 80);
								array = this.ResizeImage(img4, size, false);
								string path = "STARTUP.PNG";
								string text12 = Path.Combine(directoryName, path);
								File.WriteAllBytes(text12, array);
								if (!this.RunProcess(this.pngquant, "-v -f %PNG% -o %PNG%".Replace("%PNG%", "\"" + text12 + "\""), directoryName).ToLower().Contains("error"))
								{
									array = File.ReadAllBytes(text12);
									zipFile.AddEntry("sce_sys/livearea/contents/startup.png", array);
								}
							}
							else if (text7.ToUpper().StartsWith("DEFAULT") | text7.ToUpper().StartsWith("%DEFAULT%"))
							{
								zipFile.UpdateEntry("sce_sys/livearea/contents/startup.png", Utils.ImageToBytes(Resources.startup));
							}
							zipFile.UpdateEntry("sce_sys/livearea/contents/template.xml", Resources.template);
							zipFile.Save();
							MessageBox.Show("VPK Successfully Created.\r\n\r\n\"" + saveFileDialog2.FileName + "\"", "Confirmation!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Confirmation!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			this.Enabled = true;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0012E180 File Offset: 0x0012C380
		private void ButtonAbout_Click(object sender, EventArgs e)
		{
			MessageBox.Show("AdrBubbleBooterCreator © 2017 by LMAN\r\n\r\nUses pngquant © 2009-2016 by Kornel Lesiński", "About", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0012E198 File Offset: 0x0012C398
		private void ButtonHomepage_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start("https://sites.google.com/site/theleecherman");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Opening homepage link failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0012E1E4 File Offset: 0x0012C3E4
		private void ButtonDonate_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start("https://sites.google.com/site/theleecherman/donate");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Opening donation link failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0012E230 File Offset: 0x0012C430
		private void ButtonClear_Click(object sender, EventArgs e)
		{
			this.TextBoxTitle.Text = "AdrBubbleBooter";
			this.TextBoxTitleId.Text = "PSPEMU001";
			this.TextBoxMs0.Text = "ms0:/";
			this.TextBoxIcon0.Text = "%DEFAULT%";
			this.TextBoxBg0.Text = "%DEFAULT%";
			this.TextBoxPic0.Text = "%DEFAULT%";
			this.TextBoxStartup.Text = "%DEFAULT%";
			this.ComboBoxDriver.Text = "DEFAULT";
			this.ComboBoxExecute.Text = "DEFAULT";
			this.ComboBoxPlugins.Text = "DEFAULT";
			this.ComboBoxIcon0Style.Text = "PSP";
			this.PictureBoxImage.Image = null;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0012E2FC File Offset: 0x0012C4FC
		private string IsImage(string filename)
		{
			string[] array = new string[]
			{
				".png",
				".bmp",
				".jpg"
			};
			foreach (string text in array)
			{
				if (filename.ToLower().EndsWith(text.ToLower()))
				{
					return Conversions.ToString(true);
				}
			}
			return Conversions.ToString(false);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0012E368 File Offset: 0x0012C568
		private string RunProcess(string app, string args, string workingdir)
		{
			StringBuilder stringBuilder = new StringBuilder();
			try
			{
				if (Operators.CompareString(Conversions.ToString(Path.DirectorySeparatorChar), "/", false) == 0)
				{
					string text = "wine";
					string text2 = app + " " + args.Replace("\"", "'");
					string text3 = workingdir.Replace("\"", "'");
					app = text;
					args = text2;
					workingdir = text3;
				}
				Process process = new Process();
				process.StartInfo = new ProcessStartInfo(app, args)
				{
					UseShellExecute = false,
					RedirectStandardOutput = true
				};
				process.StartInfo.WorkingDirectory = workingdir;
				process.StartInfo.CreateNoWindow = true;
				process.Start();
				stringBuilder.AppendLine(process.StandardOutput.ReadToEnd());
				process.WaitForExit();
				process.Close();
			}
			catch (Exception ex)
			{
				return null;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0012E460 File Offset: 0x0012C660
		public byte[] ResizeIconImage(Image Img, MainForm.ICONStyle iconStyle)
		{
			Bitmap bitmap = new Bitmap(Img.Width, Img.Height);
			try
			{
				using (Graphics graphics = Graphics.FromImage(bitmap))
				{
					graphics.DrawImage(Resources.pspbase, 0, 0, 128, 128);
					Rectangle destRect;
					if (iconStyle == MainForm.ICONStyle.MiniPSOne)
					{
						destRect = new Rectangle(24, 24, 80, 80);
					}
					else if (iconStyle == MainForm.ICONStyle.PSPGame)
					{
						destRect = new Rectangle(9, 34, 110, 61);
					}
					else
					{
						destRect = new Rectangle(9, 34, 110, 61);
					}
					graphics.DrawImage(Img, destRect, 0, 0, bitmap.Width, bitmap.Height, GraphicsUnit.Pixel);
				}
			}
			catch (Exception ex)
			{
			}
			MemoryStream memoryStream = new MemoryStream();
			bitmap.Save(memoryStream, ImageFormat.Png);
			return memoryStream.ToArray();
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0012E53C File Offset: 0x0012C73C
		private byte[] ResizeImage(Image img, Size size, bool preserveAspectRatio = true)
		{
			checked
			{
				int width2;
				int height2;
				if (preserveAspectRatio)
				{
					int width = img.Width;
					int height = img.Height;
					float num = (float)size.Width / (float)width;
					float num2 = (float)size.Height / (float)height;
					float num3 = (num2 < num) ? num2 : num;
					width2 = (int)Math.Round((double)(unchecked((float)width * num3)));
					height2 = (int)Math.Round((double)(unchecked((float)height * num3)));
				}
				else
				{
					width2 = size.Width;
					height2 = size.Height;
				}
				Image image = new Bitmap(width2, height2);
				image = this.MakeGrayscale((Bitmap)image);
				using (Graphics graphics = Graphics.FromImage(image))
				{
					graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
					graphics.CompositingQuality = CompositingQuality.HighQuality;
					graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
					graphics.SmoothingMode = SmoothingMode.AntiAlias;
					graphics.CompositingMode = CompositingMode.SourceOver;
					graphics.DrawImage(img, 0, 0, width2, height2);
				}
				MemoryStream memoryStream = new MemoryStream();
				image.Save(memoryStream, ImageFormat.Png);
				return memoryStream.ToArray();
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0012E640 File Offset: 0x0012C840
		public Bitmap MakeGrayscale(Bitmap original)
		{
			Bitmap bitmap = new Bitmap(original.Width, original.Height);
			Graphics graphics = Graphics.FromImage(bitmap);
			ColorMatrix colorMatrix = new ColorMatrix(new float[][]
			{
				new float[]
				{
					0.3f,
					0.3f,
					0.3f,
					0f,
					0f
				},
				new float[]
				{
					0.59f,
					0.59f,
					0.59f,
					0f,
					0f
				},
				new float[]
				{
					0.11f,
					0.11f,
					0.11f,
					0f,
					0f
				},
				new float[]
				{
					0f,
					0f,
					0f,
					1f,
					0f
				},
				new float[]
				{
					0f,
					0f,
					0f,
					0f,
					1f
				}
			});
			ImageAttributes imageAttributes = new ImageAttributes();
			imageAttributes.SetColorMatrix(colorMatrix);
			Graphics graphics2 = graphics;
			Rectangle destRect = new Rectangle(0, 0, original.Width, original.Height);
			graphics2.DrawImage(original, destRect, 0, 0, original.Width, original.Height, GraphicsUnit.Pixel, imageAttributes);
			graphics.Dispose();
			return bitmap;
		}

		// Token: 0x0400001A RID: 26
		[AccessedThroughProperty("ButtonAbout")]
		private Button _ButtonAbout;

		// Token: 0x0400001B RID: 27
		[AccessedThroughProperty("ButtonHomepage")]
		private Button _ButtonHomepage;

		// Token: 0x0400001C RID: 28
		[AccessedThroughProperty("ButtonDonate")]
		private Button _ButtonDonate;

		// Token: 0x0400001D RID: 29
		[AccessedThroughProperty("ButtonClear")]
		private Button _ButtonClear;

		// Token: 0x0400001E RID: 30
		[AccessedThroughProperty("ButtonCreate")]
		private Button _ButtonCreate;

		// Token: 0x0400001F RID: 31
		[AccessedThroughProperty("LabelTitle")]
		private Label _LabelTitle;

		// Token: 0x04000020 RID: 32
		[AccessedThroughProperty("TextBoxTitle")]
		private TextBox _TextBoxTitle;

		// Token: 0x04000021 RID: 33
		[AccessedThroughProperty("TextBoxTitleId")]
		private TextBox _TextBoxTitleId;

		// Token: 0x04000022 RID: 34
		[AccessedThroughProperty("LabelTitleId")]
		private Label _LabelTitleId;

		// Token: 0x04000023 RID: 35
		[AccessedThroughProperty("TextBoxMs0")]
		private TextBox _TextBoxMs0;

		// Token: 0x04000024 RID: 36
		[AccessedThroughProperty("LabelMs0")]
		private Label _LabelMs0;

		// Token: 0x04000025 RID: 37
		[AccessedThroughProperty("TextBoxIcon0")]
		private TextBox _TextBoxIcon0;

		// Token: 0x04000026 RID: 38
		[AccessedThroughProperty("LabelIcon0")]
		private Label _LabelIcon0;

		// Token: 0x04000027 RID: 39
		[AccessedThroughProperty("TextBoxBg0")]
		private TextBox _TextBoxBg0;

		// Token: 0x04000028 RID: 40
		[AccessedThroughProperty("LabelBg0")]
		private Label _LabelBg0;

		// Token: 0x04000029 RID: 41
		[AccessedThroughProperty("TextBoxStartup")]
		private TextBox _TextBoxStartup;

		// Token: 0x0400002A RID: 42
		[AccessedThroughProperty("LabelStartup")]
		private Label _LabelStartup;

		// Token: 0x0400002B RID: 43
		[AccessedThroughProperty("TextBoxPic0")]
		private TextBox _TextBoxPic0;

		// Token: 0x0400002C RID: 44
		[AccessedThroughProperty("LabelPic0")]
		private Label _LabelPic0;

		// Token: 0x0400002D RID: 45
		[AccessedThroughProperty("LabelDriver")]
		private Label _LabelDriver;

		// Token: 0x0400002E RID: 46
		[AccessedThroughProperty("ComboBoxDriver")]
		private ComboBox _ComboBoxDriver;

		// Token: 0x0400002F RID: 47
		[AccessedThroughProperty("ComboBoxExecute")]
		private ComboBox _ComboBoxExecute;

		// Token: 0x04000030 RID: 48
		[AccessedThroughProperty("LabelExecute")]
		private Label _LabelExecute;

		// Token: 0x04000031 RID: 49
		[AccessedThroughProperty("ComboBoxPlugins")]
		private ComboBox _ComboBoxPlugins;

		// Token: 0x04000032 RID: 50
		[AccessedThroughProperty("LabelPlugins")]
		private Label _LabelPlugins;

		// Token: 0x04000033 RID: 51
		[AccessedThroughProperty("LinkLabelOpenBg0")]
		private LinkLabel _LinkLabelOpenBg0;

		// Token: 0x04000034 RID: 52
		[AccessedThroughProperty("LinkLabelOpenIcon0")]
		private LinkLabel _LinkLabelOpenIcon0;

		// Token: 0x04000035 RID: 53
		[AccessedThroughProperty("LinkLabelStartup")]
		private LinkLabel _LinkLabelStartup;

		// Token: 0x04000036 RID: 54
		[AccessedThroughProperty("LinkLabelOpenPic0")]
		private LinkLabel _LinkLabelOpenPic0;

		// Token: 0x04000037 RID: 55
		[AccessedThroughProperty("PictureBoxImage")]
		private PictureBox _PictureBoxImage;

		// Token: 0x04000038 RID: 56
		[AccessedThroughProperty("ComboBoxIcon0Style")]
		private ComboBox _ComboBoxIcon0Style;

		// Token: 0x04000039 RID: 57
		[AccessedThroughProperty("LabelIcon0Style")]
		private Label _LabelIcon0Style;

		// Token: 0x0400003A RID: 58
		private string pngquant;

		// Token: 0x0400003B RID: 59
		private bool pngquant_exported;

		// Token: 0x0200000C RID: 12
		public enum ICONStyle
		{
			// Token: 0x0400003D RID: 61
			PSPGame,
			// Token: 0x0400003E RID: 62
			MiniPSOne
		}

		// Token: 0x0200000D RID: 13
		private class ImageConverter
		{
			// Token: 0x06000098 RID: 152 RVA: 0x0012E7EC File Offset: 0x0012C9EC
			public static byte[] imageToByteArray(ref Image imageIn, ImageFormat fmt)
			{
				MemoryStream memoryStream = new MemoryStream();
				imageIn.Save(memoryStream, fmt);
				return memoryStream.ToArray();
			}

			// Token: 0x06000099 RID: 153 RVA: 0x0012E810 File Offset: 0x0012CA10
			public static Image byteArrayToImage(ref byte[] byteArrayIn, ImageFormat fmt)
			{
				MemoryStream stream = new MemoryStream(byteArrayIn);
				Image image = Image.FromStream(stream);
				fmt = image.RawFormat;
				return image;
			}
		}
	}
}
