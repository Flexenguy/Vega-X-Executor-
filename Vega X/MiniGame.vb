Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace Vega_X
	' Token: 0x02000006 RID: 6
	Public Partial Class MiniGame
		Inherits Form

		' Token: 0x06000031 RID: 49 RVA: 0x00004CD0 File Offset: 0x00002ED0
		Public Sub New()
			Me.InitializeComponent()
			AddHandler MyBase.Paint, AddressOf Me.paintBall
			Me.DoubleBuffered = True
		End Sub

		' Token: 0x06000032 RID: 50 RVA: 0x00004D2C File Offset: 0x00002F2C
		Private Sub paintBall(sender As Object, e As PaintEventArgs)
			Me.graphics = e.Graphics
			Dim brush As SolidBrush = New SolidBrush(Color.Blue)
			Me.graphics.FillEllipse(brush, Me.x, Me.y, 10, 10)
		End Sub

		' Token: 0x06000033 RID: 51 RVA: 0x00004D6C File Offset: 0x00002F6C
		Private Sub MoveBall()
			Dim num As Integer = Me.x + Me.dx
			Dim num2 As Integer = Me.y + Me.dy
			If num < -5 OrElse num > MyBase.ClientSize.Width Then
				Me.dx = -Me.dx
			End If
			If num2 < 0 OrElse num2 > MyBase.ClientSize.Height Then
				Me.dy = -Me.dy
			End If
			Me.x += Me.dx
			Me.y += Me.dy
			MyBase.Invalidate()
		End Sub

		' Token: 0x06000034 RID: 52 RVA: 0x00002097 File Offset: 0x00000297
		Private Sub MiniGame_Load(sender As Object, e As EventArgs)
			MyBase.TopMost = True
		End Sub

		' Token: 0x06000035 RID: 53 RVA: 0x00002293 File Offset: 0x00000493
		Private Sub timer1_Tick(sender As Object, e As EventArgs)
			Me.MoveBall()
		End Sub

		' Token: 0x04000032 RID: 50
		Private graphics As Graphics

		' Token: 0x04000033 RID: 51
		Private x As Integer = 150

		' Token: 0x04000034 RID: 52
		Private y As Integer = 100

		' Token: 0x04000035 RID: 53
		Private dx As Integer = 3

		' Token: 0x04000036 RID: 54
		Private dy As Integer = 2
	End Class
End Namespace
