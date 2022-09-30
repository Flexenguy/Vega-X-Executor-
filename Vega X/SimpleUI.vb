Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports EasyExploits
Imports FastColoredTextBoxNS
Imports WeAreDevs_API

Namespace Vega_X
	' Token: 0x0200000D RID: 13
	Public Partial Class SimpleUI
		Inherits Form

		' Token: 0x06000202 RID: 514 RVA: 0x000025D0 File Offset: 0x000007D0
		Public Sub New()
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000203 RID: 515 RVA: 0x00002086 File Offset: 0x00000286
		Private Sub button1_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06000204 RID: 516 RVA: 0x0000208E File Offset: 0x0000028E
		Private Sub button10_Click(sender As Object, e As EventArgs)
			MyBase.WindowState = FormWindowState.Minimized
		End Sub

		' Token: 0x06000205 RID: 517 RVA: 0x000025FB File Offset: 0x000007FB
		Private Sub button5_Click(sender As Object, e As EventArgs)
			Me.[module].LaunchExploit()
		End Sub

		' Token: 0x06000206 RID: 518 RVA: 0x00022FAC File Offset: 0x000211AC
		Private Sub button2_Click(sender As Object, e As EventArgs)
			Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
			If openFileDialog.ShowDialog() = DialogResult.OK Then
				openFileDialog.Title = "Open"
				Me.fastColoredTextBox1.Text = File.ReadAllText(openFileDialog.FileName)
			End If
		End Sub

		' Token: 0x06000207 RID: 519 RVA: 0x00002608 File Offset: 0x00000808
		Private Sub button3_Click(sender As Object, e As EventArgs)
			Me.[module].ExecuteScript(Me.fastColoredTextBox1.Text)
		End Sub

		' Token: 0x06000208 RID: 520 RVA: 0x00002620 File Offset: 0x00000820
		Private Sub button4_Click(sender As Object, e As EventArgs)
			Me.fastColoredTextBox1.Clear()
		End Sub

		' Token: 0x06000209 RID: 521 RVA: 0x0000262D File Offset: 0x0000082D
		Private Sub panel1_MouseDown(sender As Object, e As MouseEventArgs)
			Me.lastPoint = New Point(e.X, e.Y)
		End Sub

		' Token: 0x0600020A RID: 522 RVA: 0x00022FEC File Offset: 0x000211EC
		Private Sub panel1_MouseMove(sender As Object, e As MouseEventArgs)
			If e.Button = MouseButtons.Left Then
				MyBase.Left += e.X - Me.lastPoint.X
				MyBase.Top += e.Y - Me.lastPoint.Y
			End If
		End Sub

		' Token: 0x0600020B RID: 523 RVA: 0x00002097 File Offset: 0x00000297
		Private Sub SimpleUI_Load(sender As Object, e As EventArgs)
			MyBase.TopMost = True
		End Sub

		' Token: 0x0600020C RID: 524 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub label1_MouseUp(sender As Object, e As MouseEventArgs)
		End Sub

		' Token: 0x0600020D RID: 525 RVA: 0x00022FEC File Offset: 0x000211EC
		Private Sub label1_MouseMove(sender As Object, e As MouseEventArgs)
			If e.Button = MouseButtons.Left Then
				MyBase.Left += e.X - Me.lastPoint.X
				MyBase.Top += e.Y - Me.lastPoint.Y
			End If
		End Sub

		' Token: 0x0600020E RID: 526 RVA: 0x0000262D File Offset: 0x0000082D
		Private Sub label1_MouseDown(sender As Object, e As MouseEventArgs)
			Me.lastPoint = New Point(e.X, e.Y)
		End Sub

		' Token: 0x0600020F RID: 527 RVA: 0x00023048 File Offset: 0x00021248
		Private Sub button6_Click(sender As Object, e As EventArgs)
			Dim scriptHub As ScriptHub = New ScriptHub()
			scriptHub.Show()
		End Sub

		' Token: 0x06000210 RID: 528 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub fastColoredTextBox1_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0400022C RID: 556
		Private api As ExploitAPI = New ExploitAPI()

		' Token: 0x0400022D RID: 557
		Private [module] As [Module] = New [Module]()

		' Token: 0x0400022E RID: 558
		Private lastPoint As Point
	End Class
End Namespace
