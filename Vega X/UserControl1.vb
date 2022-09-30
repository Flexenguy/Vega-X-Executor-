Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports FastColoredTextBoxNS

Namespace Vega_X
	' Token: 0x0200000E RID: 14
	Public Class UserControl1
		Inherits UserControl

		' Token: 0x06000213 RID: 531 RVA: 0x00002668 File Offset: 0x00000868
		Public Sub New()
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000214 RID: 532 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub fastColoredTextBox1_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000215 RID: 533 RVA: 0x0000267D File Offset: 0x0000087D
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000216 RID: 534 RVA: 0x00023C58 File Offset: 0x00021E58
		Private Sub InitializeComponent()
			Me.components = New Container()
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(UserControl1))
			Me.fastColoredTextBox1 = New FastColoredTextBox()
			Me.contextMenuStrip1 = New ContextMenuStrip(Me.components)
			CType(Me.fastColoredTextBox1, ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.fastColoredTextBox1.AutoCompleteBracketsList = New Char() { "("c, ")"c, "{"c, "}"c, "["c, "]"c, """"c, """"c, "'"c, "'"c }
			Me.fastColoredTextBox1.AutoIndentCharsPatterns = vbCrLf & "^\s*[\w\.]+(\s\w+)?\s*(?<range>=)\s*(?<range>.+)" & vbCrLf
			Me.fastColoredTextBox1.AutoScrollMinSize = New Size(507, 126)
			Me.fastColoredTextBox1.BackBrush = Nothing
			Me.fastColoredTextBox1.BackColor = Color.FromArgb(50, 50, 50)
			Me.fastColoredTextBox1.BracketsHighlightStrategy = BracketsHighlightStrategy.Strategy2
			Me.fastColoredTextBox1.CharHeight = 14
			Me.fastColoredTextBox1.CharWidth = 8
			Me.fastColoredTextBox1.CommentPrefix = "--"
			Me.fastColoredTextBox1.Cursor = Cursors.IBeam
			Me.fastColoredTextBox1.DisabledColor = Color.FromArgb(100, 180, 180, 180)
			Me.fastColoredTextBox1.Dock = DockStyle.Fill
			Me.fastColoredTextBox1.Font = New Font("Courier New", 9.5F)
			Me.fastColoredTextBox1.ForeColor = Color.White
			Me.fastColoredTextBox1.IndentBackColor = Color.FromArgb(45, 45, 45)
			Me.fastColoredTextBox1.IsReplaceMode = False
			Me.fastColoredTextBox1.Language = Language.Lua
			Me.fastColoredTextBox1.LeftBracket = "("c
			Me.fastColoredTextBox1.LeftBracket2 = "{"c
			Me.fastColoredTextBox1.Location = New Point(0, 0)
			Me.fastColoredTextBox1.Name = "fastColoredTextBox1"
			Me.fastColoredTextBox1.Paddings = New Padding(0)
			Me.fastColoredTextBox1.RightBracket = ")"c
			Me.fastColoredTextBox1.RightBracket2 = "}"c
			Me.fastColoredTextBox1.SelectionColor = Color.FromArgb(60, 0, 0, 255)
			Me.fastColoredTextBox1.ServiceColors = CType(componentResourceManager.GetObject("fastColoredTextBox1.ServiceColors"), ServiceColors)
			Me.fastColoredTextBox1.Size = New Size(669, 251)
			Me.fastColoredTextBox1.TabIndex = 24
			Me.fastColoredTextBox1.Text = componentResourceManager.GetString("fastColoredTextBox1.Text")
			Me.fastColoredTextBox1.Zoom = 100
			AddHandler Me.fastColoredTextBox1.Load, AddressOf Me.fastColoredTextBox1_Load
			Me.contextMenuStrip1.Name = "contextMenuStrip1"
			Me.contextMenuStrip1.Size = New Size(61, 4)
			MyBase.AutoScaleDimensions = New SizeF(6F, 13F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.Controls.Add(Me.fastColoredTextBox1)
			MyBase.Name = "UserControl1"
			MyBase.Size = New Size(669, 251)
			CType(Me.fastColoredTextBox1, ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x0400023B RID: 571
		Private components As IContainer = Nothing

		' Token: 0x0400023C RID: 572
		Private fastColoredTextBox1 As FastColoredTextBox

		' Token: 0x0400023D RID: 573
		Private contextMenuStrip1 As ContextMenuStrip
	End Class
End Namespace
