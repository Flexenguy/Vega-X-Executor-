Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports WeAreDevs_API

Namespace Vega_X
	' Token: 0x02000002 RID: 2
	Public Partial Class AdjustableScripts
		Inherits Form

		' Token: 0x06000001 RID: 1 RVA: 0x00002064 File Offset: 0x00000264
		Public Sub New()
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000002 RID: 2 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub panel1_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		' Token: 0x06000003 RID: 3 RVA: 0x00002086 File Offset: 0x00000286
		Private Sub button9_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06000004 RID: 4 RVA: 0x0000208E File Offset: 0x0000028E
		Private Sub button2_Click(sender As Object, e As EventArgs)
			MyBase.WindowState = FormWindowState.Minimized
		End Sub

		' Token: 0x06000005 RID: 5 RVA: 0x00002A1C File Offset: 0x00000C1C
		Private Sub textBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
			Dim text As String = Me.textBox1.Text
			If e.KeyChar = Convert.ToChar(Keys.[Return]) Then
				Me.api.SendLuaScript("game.Players.LocalPlayer.Character.Humanoid.WalkSpeed = " + text)
				Me.textBox1.Clear()
			End If
		End Sub

		' Token: 0x06000006 RID: 6 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub textBox1_TextChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000007 RID: 7 RVA: 0x00002097 File Offset: 0x00000297
		Private Sub AdjustableScripts_Load(sender As Object, e As EventArgs)
			MyBase.TopMost = True
		End Sub

		' Token: 0x06000008 RID: 8 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub label2_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000009 RID: 9 RVA: 0x00002A6C File Offset: 0x00000C6C
		Private Sub textBox2_KeyPress(sender As Object, e As KeyPressEventArgs)
			Dim text As String = Me.textBox2.Text
			If e.KeyChar = Convert.ToChar(Keys.[Return]) Then
				Me.api.SendLuaScript("game.Players.LocalPlayer.Character.Humanoid.JumpPower = " + text)
				Me.textBox2.Clear()
			End If
		End Sub

		' Token: 0x0600000A RID: 10 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub textBox2_TextChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600000B RID: 11 RVA: 0x00002ABC File Offset: 0x00000CBC
		Private Sub textBox4_KeyPress(sender As Object, e As KeyPressEventArgs)
			Dim text As String = Me.textBox4.Text
			If e.KeyChar = Convert.ToChar(Keys.[Return]) Then
				Me.api.SendLuaScript("game.Workspace.Gravity = " + text)
				Me.textBox4.Clear()
			End If
		End Sub

		' Token: 0x0600000C RID: 12 RVA: 0x000020A0 File Offset: 0x000002A0
		Private Sub button1_Click(sender As Object, e As EventArgs)
			Me.api.SendLuaScript("game.Players.LocalPlayer.Character.Humanoid.WalkSpeed = 16")
			Console.Beep()
		End Sub

		' Token: 0x0600000D RID: 13 RVA: 0x000020B7 File Offset: 0x000002B7
		Private Sub button3_Click(sender As Object, e As EventArgs)
			Me.api.SendLuaScript("game.Workspace.Gravity = 196.2")
			Console.Beep()
		End Sub

		' Token: 0x0600000E RID: 14 RVA: 0x000020CE File Offset: 0x000002CE
		Private Sub button4_Click(sender As Object, e As EventArgs)
			Me.api.SendLuaScript("game.Players.LocalPlayer.Character.Humanoid.JumpPower = 50")
			Console.Beep()
		End Sub

		' Token: 0x0600000F RID: 15 RVA: 0x000020E5 File Offset: 0x000002E5
		Private Sub button5_Click(sender As Object, e As EventArgs)
			Me.api.SendLuaScript("game.Players.LocalPlayer.Character.Humanoid.JumpPower = 50")
			Me.api.SendLuaScript("game.Workspace.Gravity = 196.2")
			Me.api.SendLuaScript("game.Players.LocalPlayer.Character.Humanoid.WalkSpeed = 16")
			MessageBox.Show("All Character Modifications Have Been Reset.")
		End Sub

		' Token: 0x06000010 RID: 16 RVA: 0x00002B0C File Offset: 0x00000D0C
		Private Sub panel1_MouseMove(sender As Object, e As MouseEventArgs)
			If e.Button = MouseButtons.Left Then
				MyBase.Left += e.X - Me.lastPoint.X
				MyBase.Top += e.Y - Me.lastPoint.Y
			End If
		End Sub

		' Token: 0x06000011 RID: 17 RVA: 0x00002122 File Offset: 0x00000322
		Private Sub panel1_MouseDown(sender As Object, e As MouseEventArgs)
			Me.lastPoint = New Point(e.X, e.Y)
		End Sub

		' Token: 0x06000012 RID: 18 RVA: 0x00002122 File Offset: 0x00000322
		Private Sub label1_MouseDown(sender As Object, e As MouseEventArgs)
			Me.lastPoint = New Point(e.X, e.Y)
		End Sub

		' Token: 0x06000013 RID: 19 RVA: 0x00002B0C File Offset: 0x00000D0C
		Private Sub label1_MouseMove(sender As Object, e As MouseEventArgs)
			If e.Button = MouseButtons.Left Then
				MyBase.Left += e.X - Me.lastPoint.X
				MyBase.Top += e.Y - Me.lastPoint.Y
			End If
		End Sub

		' Token: 0x06000014 RID: 20 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub textBox4_TextChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x04000001 RID: 1
		Private api As ExploitAPI = New ExploitAPI()

		' Token: 0x04000002 RID: 2
		Private lastPoint As Point
	End Class
End Namespace
