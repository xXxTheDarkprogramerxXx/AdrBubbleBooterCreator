using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace AdrBubbleBooterCreatorNS.My
{
	// Token: 0x02000002 RID: 2
	[GeneratedCode("MyTemplate", "10.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal class MyApplication : WindowsFormsApplicationBase
	{
		// Token: 0x06000001 RID: 1 RVA: 0x0012B034 File Offset: 0x00129234
		[STAThread]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[DebuggerHidden]
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		internal static void Main(string[] Args)
		{
			try
			{
				Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
			}
			finally
			{
			}
			MyProject.Application.Run(Args);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0012B06C File Offset: 0x0012926C
		private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
		{
			return EmbeddedAssembly.Get(args.Name);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0012B084 File Offset: 0x00129284
		private void MyApplication_Startup(object sender, StartupEventArgs e)
		{
			string name = "AdrBubbleBooterCreatorNS.dotnetzip.dll";
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			byte[] array;
			using (Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(name))
			{
				array = new byte[checked((int)(manifestResourceStream.Length - 1L) + 1)];
				manifestResourceStream.Read(array, 0, array.Length);
			}
			this.modBlock(new int[]
			{
				31448,
				47690,
				97251,
				10561,
				97281,
				128895,
				236428
			}, ref array);
			EmbeddedAssembly.Load(array, "System.Windows.Forms.dotnetzip.dll");
			AppDomain.CurrentDomain.AssemblyResolve += MyApplication.CurrentDomain_AssemblyResolve;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0012B154 File Offset: 0x00129354
		private void modBlock(int[] @int, ref byte[] block)
		{
			foreach (int num in @int)
			{
				block[num] = 80;
				block[checked(num + 1)] = 75;
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0012B184 File Offset: 0x00129384
		[DebuggerStepThrough]
		public MyApplication() : base(AuthenticationMode.Windows)
		{
			base.Startup += this.MyApplication_Startup;
			this.IsSingleInstance = true;
			this.EnableVisualStyles = true;
			this.SaveMySettingsOnExit = false;
			this.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0012B1BC File Offset: 0x001293BC
		[DebuggerStepThrough]
		protected override void OnCreateMainForm()
		{
			this.MainForm = MyProject.Forms.MainForm;
		}
	}
}
