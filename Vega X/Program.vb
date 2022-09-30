Imports System
Imports System.Windows.Forms

Namespace Vega_X
	' Token: 0x02000010 RID: 16
	Friend Module Program
		' Token: 0x0600029A RID: 666 RVA: 0x000029DC File Offset: 0x00000BDC
		<STAThread()>
		Private Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New Loader())
		End Sub
	End Module
End Namespace
