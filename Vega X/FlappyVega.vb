Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Threading
Imports System.Windows.Forms

Namespace Vega_X
	' Token: 0x02000003 RID: 3
	Public Partial Class FlappyVega
		Inherits Form

		' Token: 0x06000017 RID: 23 RVA: 0x0000215D File Offset: 0x0000035D
		Public Sub New()
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000018 RID: 24 RVA: 0x000038BC File Offset: 0x00001ABC
		Private Sub GameTimerEvent(sender As Object, e As EventArgs)
			Me.bird.Top += Me.gravity
			Me.pipedown.Left -= Me.pipespeed
			Me.pipeup.Left -= Me.pipespeed
			Me.Score.Text = Me.score.ToString()
			If Me.pipedown.Left < -600 Then
				Me.pipedown.Left = 800
				Me.score += 1
			End If
			If Me.pipeup.Left < -650 Then
				Me.pipeup.Left = 800
				Me.score += 1
			End If
			If Me.bird.Bounds.IntersectsWith(Me.pipedown.Bounds) OrElse Me.bird.Bounds.IntersectsWith(Me.pipeup.Bounds) OrElse Me.bird.Bounds.IntersectsWith(Me.ground.Bounds) OrElse Me.bird.Bounds.IntersectsWith(Me.panel1.Bounds) Then
				Me.endgame()
			End If
		End Sub

		' Token: 0x06000019 RID: 25 RVA: 0x00003A14 File Offset: 0x00001C14
		Private Sub gamekeydown(sender As Object, e As KeyEventArgs)
			If e.KeyCode = Keys.F Then
				MyBase.Close()
			End If
			If e.KeyCode = Keys.A Then
				Me.gametimer.Interval = 20
				Dim label As Label = Me.Score
				label.Text += " "
				Thread.Sleep(50)
				Dim label2 As Label = Me.Score
				label2.Text += "Current Mode = EASY"
			End If
			If e.KeyCode = Keys.Z Then
				Me.gametimer.Interval = 3
				Dim label3 As Label = Me.Score
				label3.Text += " "
				Thread.Sleep(50)
				Dim label4 As Label = Me.Score
				label4.Text += "Current Mode = EXPERT"
			End If
			If e.KeyCode = Keys.Q Then
				Me.gametimer.Interval = 10
				Dim label5 As Label = Me.Score
				label5.Text += " "
				Thread.Sleep(50)
				Dim label6 As Label = Me.Score
				label6.Text += "Current Mode = HARD"
			End If
			If e.KeyCode = Keys.E Then
				Me.gametimer.Enabled = True
				Me.label2.Visible = False
				Me.label3.Visible = False
				Me.label4.Visible = False
				Me.label5.Visible = False
				Me.label6.Visible = False
			End If
			If e.KeyCode = Keys.Space Then
				Me.gravity = -7
			End If
		End Sub

		' Token: 0x0600001A RID: 26 RVA: 0x00002187 File Offset: 0x00000387
		Private Sub endgame()
			Me.gametimer.[Stop]()
			Dim label As Label = Me.Score
			label.Text += "Game Over"
			MyBase.Close()
		End Sub

		' Token: 0x0600001B RID: 27 RVA: 0x000021B5 File Offset: 0x000003B5
		Private Sub gamekeyup(sender As Object, e As KeyEventArgs)
			If e.KeyCode = Keys.Space Then
				Me.gravity = 7
			End If
		End Sub

		' Token: 0x0600001C RID: 28 RVA: 0x00002097 File Offset: 0x00000297
		Private Sub FlappyVega_Load(sender As Object, e As EventArgs)
			MyBase.TopMost = True
		End Sub

		' Token: 0x0600001D RID: 29 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub label2_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600001E RID: 30 RVA: 0x000021CA File Offset: 0x000003CA
		Private Sub panel1_MouseDown(sender As Object, e As MouseEventArgs)
			Me.lastPoint = New Point(e.X, e.Y)
		End Sub

		' Token: 0x0600001F RID: 31 RVA: 0x00003B9C File Offset: 0x00001D9C
		Private Sub panel1_MouseMove(sender As Object, e As MouseEventArgs)
			If e.Button = MouseButtons.Left Then
				MyBase.Left += e.X - Me.lastPoint.X
				MyBase.Top += e.Y - Me.lastPoint.Y
			End If
		End Sub

		' Token: 0x06000020 RID: 32 RVA: 0x00002086 File Offset: 0x00000286
		Private Sub button1_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06000021 RID: 33 RVA: 0x0000208E File Offset: 0x0000028E
		Private Sub button2_Click(sender As Object, e As EventArgs)
			MyBase.WindowState = FormWindowState.Minimized
		End Sub

		' Token: 0x06000022 RID: 34 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub label5_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x04000014 RID: 20
		Private pipespeed As Integer = 5

		' Token: 0x04000015 RID: 21
		Private gravity As Integer = 7

		' Token: 0x04000016 RID: 22
		Private score As Integer = 0

		' Token: 0x04000017 RID: 23
		Private lastPoint As Point
	End Class
End Namespace
