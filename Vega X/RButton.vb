Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Namespace Vega_X
	' Token: 0x02000008 RID: 8
	Public Class RButton
		Inherits Button

		' Token: 0x06000063 RID: 99 RVA: 0x00006E38 File Offset: 0x00005038
		Public Sub New()
			MyBase.FlatStyle = FlatStyle.Flat
			MyBase.FlatAppearance.BorderSize = 0
			MyBase.Size = New Size(150, 40)
			Me.BackColor = Color.LightGray
			Me.ForeColor = Color.White
		End Sub

		' Token: 0x06000064 RID: 100 RVA: 0x00006EA0 File Offset: 0x000050A0
		Private Function GetFigurePath(rect As Rectangle, radius As Single) As GraphicsPath
			Dim graphicsPath As GraphicsPath = New GraphicsPath()
			Dim num As Single = radius * 2F
			graphicsPath.StartFigure()
			graphicsPath.AddArc(CSng(rect.X), CSng(rect.Y), num, num, 180F, 90F)
			graphicsPath.AddArc(CSng(rect.Right) - num, CSng(rect.Y), num, num, 270F, 90F)
			graphicsPath.AddArc(CSng(rect.Right) - num, CSng(rect.Bottom) - num, num, num, 0F, 90F)
			graphicsPath.AddArc(CSng(rect.X), CSng(rect.Bottom) - num, num, num, 90F, 90F)
			graphicsPath.CloseFigure()
			Return graphicsPath
		End Function

		' Token: 0x06000065 RID: 101 RVA: 0x00006F5C File Offset: 0x0000515C
		Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
			MyBase.OnPaint(pevent)
			Dim clientRectangle As Rectangle = MyBase.ClientRectangle
			Dim rect As Rectangle = Rectangle.Inflate(clientRectangle, -Me.borderSize, -Me.borderSize)
			Dim num As Integer = 2
			If Me.borderSize > 0 Then
				num = Me.borderSize
			End If
			If Me.borderRadius > 2 Then
				Using figurePath As GraphicsPath = Me.GetFigurePath(clientRectangle, CSng(Me.borderRadius))
					Using figurePath2 As GraphicsPath = Me.GetFigurePath(rect, CSng((Me.borderRadius - Me.borderSize)))
						Using pen As Pen = New Pen(MyBase.Parent.BackColor, CSng(num))
							Using pen2 As Pen = New Pen(Me.borderColor, CSng(Me.borderSize))
								pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias
								MyBase.Region = New Region(figurePath)
								pevent.Graphics.DrawPath(pen, figurePath)
								If Me.borderSize >= 1 Then
									pevent.Graphics.DrawPath(pen2, figurePath2)
								End If
							End Using
						End Using
					End Using
					Return
				End Using
			End If
			pevent.Graphics.SmoothingMode = SmoothingMode.None
			MyBase.Region = New Region(clientRectangle)
			If Me.borderSize >= 1 Then
				Using pen3 As Pen = New Pen(Me.borderColor, CSng(Me.borderSize))
					pen3.Alignment = PenAlignment.Inset
					pevent.Graphics.DrawRectangle(pen3, 0, 0, MyBase.Width - 1, MyBase.Height - 1)
				End Using
			End If
		End Sub

		' Token: 0x06000066 RID: 102 RVA: 0x000023C9 File Offset: 0x000005C9
		Protected Overrides Sub OnHandleCreated(e As EventArgs)
			MyBase.OnHandleCreated(e)
			AddHandler MyBase.Parent.BackColorChanged, AddressOf Me.Container_BackColorChanged
		End Sub

		' Token: 0x06000067 RID: 103 RVA: 0x000023E9 File Offset: 0x000005E9
		Private Sub Container_BackColorChanged(sender As Object, e As EventArgs)
			If MyBase.DesignMode Then
				MyBase.Invalidate()
			End If
		End Sub

		' Token: 0x0400005E RID: 94
		Private borderSize As Integer = 0

		' Token: 0x0400005F RID: 95
		Private borderRadius As Integer = 20

		' Token: 0x04000060 RID: 96
		Private borderColor As Color = Color.DarkGray
	End Class
End Namespace
