Namespace Vega_X
	' Token: 0x0200000D RID: 13
	Public Partial Class SimpleUI
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000211 RID: 529 RVA: 0x00002646 File Offset: 0x00000846
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000212 RID: 530 RVA: 0x00023064 File Offset: 0x00021264
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.Vega_X.SimpleUI))
			Me.panel1 = New Global.System.Windows.Forms.Panel()
			Me.button1 = New Global.System.Windows.Forms.Button()
			Me.button10 = New Global.System.Windows.Forms.Button()
			Me.panel2 = New Global.System.Windows.Forms.Panel()
			Me.label1 = New Global.System.Windows.Forms.Label()
			Me.fastColoredTextBox1 = New Global.FastColoredTextBoxNS.FastColoredTextBox()
			Me.button3 = New Global.System.Windows.Forms.Button()
			Me.button2 = New Global.System.Windows.Forms.Button()
			Me.button4 = New Global.System.Windows.Forms.Button()
			Me.button5 = New Global.System.Windows.Forms.Button()
			Me.button6 = New Global.System.Windows.Forms.Button()
			Me.panel1.SuspendLayout()
			CType(Me.fastColoredTextBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.panel1.BackColor = Global.System.Drawing.Color.FromArgb(60, 60, 60)
			Me.panel1.Controls.Add(Me.button1)
			Me.panel1.Controls.Add(Me.button10)
			Me.panel1.Controls.Add(Me.panel2)
			Me.panel1.Controls.Add(Me.label1)
			Me.panel1.Location = New Global.System.Drawing.Point(0, -1)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New Global.System.Drawing.Size(543, 41)
			Me.panel1.TabIndex = 0
			AddHandler Me.panel1.MouseDown, AddressOf Me.panel1_MouseDown
			AddHandler Me.panel1.MouseMove, AddressOf Me.panel1_MouseMove
			Me.button1.BackColor = Global.System.Drawing.Color.FromArgb(60, 60, 60)
			Me.button1.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(60, 60, 60)
			Me.button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.button1.ForeColor = Global.System.Drawing.SystemColors.ControlLightLight
			Me.button1.Location = New Global.System.Drawing.Point(509, 5)
			Me.button1.Name = "button1"
			Me.button1.Size = New Global.System.Drawing.Size(30, 27)
			Me.button1.TabIndex = 15
			Me.button1.Text = "X"
			Me.button1.UseVisualStyleBackColor = False
			AddHandler Me.button1.Click, AddressOf Me.button1_Click
			Me.button10.BackColor = Global.System.Drawing.Color.FromArgb(60, 60, 60)
			Me.button10.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(60, 60, 60)
			Me.button10.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button10.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.button10.ForeColor = Global.System.Drawing.SystemColors.ControlLightLight
			Me.button10.Location = New Global.System.Drawing.Point(475, 5)
			Me.button10.Name = "button10"
			Me.button10.Size = New Global.System.Drawing.Size(28, 27)
			Me.button10.TabIndex = 14
			Me.button10.Text = "—"
			Me.button10.UseVisualStyleBackColor = False
			AddHandler Me.button10.Click, AddressOf Me.button10_Click
			Me.panel2.BackColor = Global.System.Drawing.Color.Transparent
			Me.panel2.BackgroundImage = CType(componentResourceManager.GetObject("panel2.BackgroundImage"), Global.System.Drawing.Image)
			Me.panel2.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Zoom
			Me.panel2.Location = New Global.System.Drawing.Point(0, 1)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New Global.System.Drawing.Size(44, 40)
			Me.panel2.TabIndex = 11
			Me.label1.AutoSize = True
			Me.label1.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.label1.ForeColor = Global.System.Drawing.SystemColors.Window
			Me.label1.Location = New Global.System.Drawing.Point(203, 9)
			Me.label1.Name = "label1"
			Me.label1.Size = New Global.System.Drawing.Size(144, 21)
			Me.label1.TabIndex = 4
			Me.label1.Text = "Vega X - Simple UI"
			AddHandler Me.label1.MouseDown, AddressOf Me.label1_MouseDown
			AddHandler Me.label1.MouseMove, AddressOf Me.label1_MouseMove
			AddHandler Me.label1.MouseUp, AddressOf Me.label1_MouseUp
			Me.fastColoredTextBox1.AutoCompleteBracketsList = New Char() { "("c, ")"c, "{"c, "}"c, "["c, "]"c, """"c, """"c, "'"c, "'"c }
			Me.fastColoredTextBox1.AutoIndentCharsPatterns = vbCrLf & "^\s*[\w\.]+(\s\w+)?\s*(?<range>=)\s*(?<range>.+)" & vbCrLf
			Me.fastColoredTextBox1.AutoScrollMinSize = New Global.System.Drawing.Size(195, 70)
			Me.fastColoredTextBox1.BackBrush = Nothing
			Me.fastColoredTextBox1.BackColor = Global.System.Drawing.Color.FromArgb(50, 50, 50)
			Me.fastColoredTextBox1.BracketsHighlightStrategy = Global.FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2
			Me.fastColoredTextBox1.CharHeight = 14
			Me.fastColoredTextBox1.CharWidth = 8
			Me.fastColoredTextBox1.CommentPrefix = "--"
			Me.fastColoredTextBox1.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.fastColoredTextBox1.DisabledColor = Global.System.Drawing.Color.FromArgb(100, 180, 180, 180)
			Me.fastColoredTextBox1.Font = New Global.System.Drawing.Font("Courier New", 9.75F)
			Me.fastColoredTextBox1.ForeColor = Global.System.Drawing.Color.White
			Me.fastColoredTextBox1.IndentBackColor = Global.System.Drawing.Color.FromArgb(40, 40, 40)
			Me.fastColoredTextBox1.IsReplaceMode = False
			Me.fastColoredTextBox1.Language = Global.FastColoredTextBoxNS.Language.Lua
			Me.fastColoredTextBox1.LeftBracket = "("c
			Me.fastColoredTextBox1.LeftBracket2 = "{"c
			Me.fastColoredTextBox1.Location = New Global.System.Drawing.Point(6, 46)
			Me.fastColoredTextBox1.Name = "fastColoredTextBox1"
			Me.fastColoredTextBox1.Paddings = New Global.System.Windows.Forms.Padding(0)
			Me.fastColoredTextBox1.RightBracket = ")"c
			Me.fastColoredTextBox1.RightBracket2 = "}"c
			Me.fastColoredTextBox1.SelectionColor = Global.System.Drawing.Color.FromArgb(60, 0, 0, 255)
			Me.fastColoredTextBox1.ServiceColors = CType(componentResourceManager.GetObject("fastColoredTextBox1.ServiceColors"), Global.FastColoredTextBoxNS.ServiceColors)
			Me.fastColoredTextBox1.Size = New Global.System.Drawing.Size(525, 154)
			Me.fastColoredTextBox1.TabIndex = 25
			Me.fastColoredTextBox1.Text = "-- Vega X - Simple UI" & vbCrLf & vbCrLf & "-- Full-LUA Execution" & vbCrLf & vbCrLf & "-- Made By 1_F0"
			Me.fastColoredTextBox1.Zoom = 100
			AddHandler Me.fastColoredTextBox1.Load, AddressOf Me.fastColoredTextBox1_Load
			Me.button3.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.button3.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.button3.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button3.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.button3.Location = New Global.System.Drawing.Point(12, 206)
			Me.button3.Name = "button3"
			Me.button3.Size = New Global.System.Drawing.Size(89, 30)
			Me.button3.TabIndex = 26
			Me.button3.Text = "Execute"
			Me.button3.UseVisualStyleBackColor = False
			AddHandler Me.button3.Click, AddressOf Me.button3_Click
			Me.button2.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.button2.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.button2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button2.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.button2.Location = New Global.System.Drawing.Point(202, 206)
			Me.button2.Name = "button2"
			Me.button2.Size = New Global.System.Drawing.Size(89, 30)
			Me.button2.TabIndex = 27
			Me.button2.Text = "Open File"
			Me.button2.UseVisualStyleBackColor = False
			AddHandler Me.button2.Click, AddressOf Me.button2_Click
			Me.button4.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.button4.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.button4.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button4.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.button4.Location = New Global.System.Drawing.Point(107, 206)
			Me.button4.Name = "button4"
			Me.button4.Size = New Global.System.Drawing.Size(89, 30)
			Me.button4.TabIndex = 28
			Me.button4.Text = "Clear"
			Me.button4.UseVisualStyleBackColor = False
			AddHandler Me.button4.Click, AddressOf Me.button4_Click
			Me.button5.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.button5.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.button5.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button5.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.button5.Location = New Global.System.Drawing.Point(442, 206)
			Me.button5.Name = "button5"
			Me.button5.Size = New Global.System.Drawing.Size(89, 30)
			Me.button5.TabIndex = 29
			Me.button5.Text = "Attach"
			Me.button5.UseVisualStyleBackColor = False
			AddHandler Me.button5.Click, AddressOf Me.button5_Click
			Me.button6.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.button6.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.button6.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button6.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.button6.Location = New Global.System.Drawing.Point(297, 206)
			Me.button6.Name = "button6"
			Me.button6.Size = New Global.System.Drawing.Size(89, 30)
			Me.button6.TabIndex = 30
			Me.button6.Text = "Script Hub"
			Me.button6.UseVisualStyleBackColor = False
			AddHandler Me.button6.Click, AddressOf Me.button6_Click
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			MyBase.ClientSize = New Global.System.Drawing.Size(543, 245)
			MyBase.Controls.Add(Me.button6)
			MyBase.Controls.Add(Me.button5)
			MyBase.Controls.Add(Me.button4)
			MyBase.Controls.Add(Me.button2)
			MyBase.Controls.Add(Me.button3)
			MyBase.Controls.Add(Me.fastColoredTextBox1)
			MyBase.Controls.Add(Me.panel1)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "SimpleUI"
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "SimpleUI"
			AddHandler MyBase.Load, AddressOf Me.SimpleUI_Load
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			CType(Me.fastColoredTextBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x0400022F RID: 559
		Private components As Global.System.ComponentModel.IContainer = Nothing

		' Token: 0x04000230 RID: 560
		Private panel1 As Global.System.Windows.Forms.Panel

		' Token: 0x04000231 RID: 561
		Private label1 As Global.System.Windows.Forms.Label

		' Token: 0x04000232 RID: 562
		Private panel2 As Global.System.Windows.Forms.Panel

		' Token: 0x04000233 RID: 563
		Private button10 As Global.System.Windows.Forms.Button

		' Token: 0x04000234 RID: 564
		Private button1 As Global.System.Windows.Forms.Button

		' Token: 0x04000235 RID: 565
		Private fastColoredTextBox1 As Global.FastColoredTextBoxNS.FastColoredTextBox

		' Token: 0x04000236 RID: 566
		Private button3 As Global.System.Windows.Forms.Button

		' Token: 0x04000237 RID: 567
		Private button2 As Global.System.Windows.Forms.Button

		' Token: 0x04000238 RID: 568
		Private button4 As Global.System.Windows.Forms.Button

		' Token: 0x04000239 RID: 569
		Private button5 As Global.System.Windows.Forms.Button

		' Token: 0x0400023A RID: 570
		Private button6 As Global.System.Windows.Forms.Button
	End Class
End Namespace
