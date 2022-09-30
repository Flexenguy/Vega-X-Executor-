Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Threading
Imports System.Windows.Forms

Namespace Vega_X
	' Token: 0x02000005 RID: 5
	Public Partial Class Loader
		Inherits Form

		' Token: 0x06000028 RID: 40 RVA: 0x00002224 File Offset: 0x00000424
		Public Sub New()
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000029 RID: 41 RVA: 0x00002240 File Offset: 0x00000440
		Private Sub Loader_Load(sender As Object, e As EventArgs)
			MyBase.TopMost = True
			Me.timer1.Enabled = True
			Me.timer1.Interval = 100
		End Sub

		' Token: 0x0600002A RID: 42 RVA: 0x00004700 File Offset: 0x00002900
		Private Sub timer1_Tick(sender As Object, e As EventArgs)
			Me.progress += 50
			If Me.progress >= 1000 Then
				Me.timer1.Enabled = False
				Me.timer1.[Stop]()
				MyBase.Hide()
				Thread.Sleep(500)
				Dim vegaX As VegaX = New VegaX()
				vegaX.Show()
			End If
			If Me.progress >= 650 Then
				Me.label3.Visible = True
				Me.label2.Visible = False
			End If
			Me.progressBar1.Value = Me.progress
		End Sub

		' Token: 0x0600002B RID: 43 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub progressBar1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600002C RID: 44 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub label2_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600002D RID: 45 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub label1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600002E RID: 46 RVA: 0x00002262 File Offset: 0x00000462
		Private Sub button5_Click(sender As Object, e As EventArgs)
			Me.timer1.Interval = 10
		End Sub

		' Token: 0x04000029 RID: 41
		Private progress As Integer = 0
	End Class
End Namespace
