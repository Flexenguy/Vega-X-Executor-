Namespace Vega_X
	' Token: 0x02000002 RID: 2
	Public Partial Class AdjustableScripts
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000015 RID: 21 RVA: 0x0000213B File Offset: 0x0000033B
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000016 RID: 22 RVA: 0x00002B68 File Offset: 0x00000D68
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.Vega_X.AdjustableScripts))
			Me.panel1 = New Global.System.Windows.Forms.Panel()
			Me.button9 = New Global.System.Windows.Forms.Button()
			Me.button2 = New Global.System.Windows.Forms.Button()
			Me.panel2 = New Global.System.Windows.Forms.Panel()
			Me.label1 = New Global.System.Windows.Forms.Label()
			Me.label2 = New Global.System.Windows.Forms.Label()
			Me.label3 = New Global.System.Windows.Forms.Label()
			Me.label4 = New Global.System.Windows.Forms.Label()
			Me.textBox1 = New Global.System.Windows.Forms.TextBox()
			Me.textBox2 = New Global.System.Windows.Forms.TextBox()
			Me.textBox4 = New Global.System.Windows.Forms.TextBox()
			Me.label6 = New Global.System.Windows.Forms.Label()
			Me.button1 = New Global.System.Windows.Forms.Button()
			Me.button3 = New Global.System.Windows.Forms.Button()
			Me.button4 = New Global.System.Windows.Forms.Button()
			Me.button5 = New Global.System.Windows.Forms.Button()
			Me.panel1.SuspendLayout()
			MyBase.SuspendLayout()
			Me.panel1.BackColor = Global.System.Drawing.Color.FromArgb(60, 60, 60)
			Me.panel1.Controls.Add(Me.button9)
			Me.panel1.Controls.Add(Me.button2)
			Me.panel1.Controls.Add(Me.panel2)
			Me.panel1.Controls.Add(Me.label1)
			Me.panel1.Location = New Global.System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New Global.System.Drawing.Size(393, 44)
			Me.panel1.TabIndex = 0
			AddHandler Me.panel1.Paint, AddressOf Me.panel1_Paint
			AddHandler Me.panel1.MouseDown, AddressOf Me.panel1_MouseDown
			AddHandler Me.panel1.MouseMove, AddressOf Me.panel1_MouseMove
			Me.button9.BackColor = Global.System.Drawing.Color.FromArgb(60, 60, 60)
			Me.button9.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(60, 60, 60)
			Me.button9.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button9.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.button9.ForeColor = Global.System.Drawing.SystemColors.ControlLightLight
			Me.button9.Location = New Global.System.Drawing.Point(360, 5)
			Me.button9.Name = "button9"
			Me.button9.Size = New Global.System.Drawing.Size(30, 27)
			Me.button9.TabIndex = 18
			Me.button9.Text = "X"
			Me.button9.UseVisualStyleBackColor = False
			AddHandler Me.button9.Click, AddressOf Me.button9_Click
			Me.button2.BackColor = Global.System.Drawing.Color.FromArgb(60, 60, 60)
			Me.button2.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(60, 60, 60)
			Me.button2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.button2.ForeColor = Global.System.Drawing.SystemColors.ControlLightLight
			Me.button2.Location = New Global.System.Drawing.Point(327, 5)
			Me.button2.Name = "button2"
			Me.button2.Size = New Global.System.Drawing.Size(30, 27)
			Me.button2.TabIndex = 17
			Me.button2.Text = "—"
			Me.button2.UseVisualStyleBackColor = False
			AddHandler Me.button2.Click, AddressOf Me.button2_Click
			Me.panel2.BackColor = Global.System.Drawing.Color.Transparent
			Me.panel2.BackgroundImage = CType(componentResourceManager.GetObject("panel2.BackgroundImage"), Global.System.Drawing.Image)
			Me.panel2.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Zoom
			Me.panel2.Location = New Global.System.Drawing.Point(3, 3)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New Global.System.Drawing.Size(47, 37)
			Me.panel2.TabIndex = 12
			Me.label1.AutoSize = True
			Me.label1.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.label1.ForeColor = Global.System.Drawing.SystemColors.Window
			Me.label1.Location = New Global.System.Drawing.Point(127, 10)
			Me.label1.Name = "label1"
			Me.label1.Size = New Global.System.Drawing.Size(124, 21)
			Me.label1.TabIndex = 4
			Me.label1.Text = "Vega X - Scripts"
			AddHandler Me.label1.MouseDown, AddressOf Me.label1_MouseDown
			AddHandler Me.label1.MouseMove, AddressOf Me.label1_MouseMove
			Me.label2.AutoSize = True
			Me.label2.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 14.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.label2.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.label2.Location = New Global.System.Drawing.Point(90, 53)
			Me.label2.Name = "label2"
			Me.label2.Size = New Global.System.Drawing.Size(218, 25)
			Me.label2.TabIndex = 207
			Me.label2.Text = "Character Modifications"
			AddHandler Me.label2.Click, AddressOf Me.label2_Click
			Me.label3.AutoSize = True
			Me.label3.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.label3.ForeColor = Global.System.Drawing.SystemColors.Window
			Me.label3.Location = New Global.System.Drawing.Point(12, 86)
			Me.label3.Name = "label3"
			Me.label3.Size = New Global.System.Drawing.Size(93, 21)
			Me.label3.TabIndex = 208
			Me.label3.Text = "Walkspeed:"
			Me.label4.AutoSize = True
			Me.label4.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.label4.ForeColor = Global.System.Drawing.SystemColors.Window
			Me.label4.Location = New Global.System.Drawing.Point(262, 87)
			Me.label4.Name = "label4"
			Me.label4.Size = New Global.System.Drawing.Size(103, 21)
			Me.label4.TabIndex = 209
			Me.label4.Text = "Jump Power:"
			Me.textBox1.Location = New Global.System.Drawing.Point(15, 111)
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New Global.System.Drawing.Size(100, 20)
			Me.textBox1.TabIndex = 210
			AddHandler Me.textBox1.TextChanged, AddressOf Me.textBox1_TextChanged
			AddHandler Me.textBox1.KeyPress, AddressOf Me.textBox1_KeyPress
			Me.textBox2.Location = New Global.System.Drawing.Point(265, 111)
			Me.textBox2.Name = "textBox2"
			Me.textBox2.Size = New Global.System.Drawing.Size(100, 20)
			Me.textBox2.TabIndex = 211
			AddHandler Me.textBox2.TextChanged, AddressOf Me.textBox2_TextChanged
			AddHandler Me.textBox2.KeyPress, AddressOf Me.textBox2_KeyPress
			Me.textBox4.Location = New Global.System.Drawing.Point(139, 111)
			Me.textBox4.Name = "textBox4"
			Me.textBox4.Size = New Global.System.Drawing.Size(100, 20)
			Me.textBox4.TabIndex = 230
			AddHandler Me.textBox4.TextChanged, AddressOf Me.textBox4_TextChanged
			AddHandler Me.textBox4.KeyPress, AddressOf Me.textBox4_KeyPress
			Me.label6.AutoSize = True
			Me.label6.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.label6.ForeColor = Global.System.Drawing.SystemColors.Window
			Me.label6.Location = New Global.System.Drawing.Point(136, 86)
			Me.label6.Name = "label6"
			Me.label6.Size = New Global.System.Drawing.Size(65, 21)
			Me.label6.TabIndex = 228
			Me.label6.Text = "Gravity:"
			Me.button1.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.button1.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button1.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.button1.Location = New Global.System.Drawing.Point(15, 136)
			Me.button1.Name = "button1"
			Me.button1.Size = New Global.System.Drawing.Size(100, 23)
			Me.button1.TabIndex = 232
			Me.button1.Text = "RESET"
			Me.button1.UseVisualStyleBackColor = False
			AddHandler Me.button1.Click, AddressOf Me.button1_Click
			Me.button3.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.button3.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.button3.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button3.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.button3.Location = New Global.System.Drawing.Point(139, 136)
			Me.button3.Name = "button3"
			Me.button3.Size = New Global.System.Drawing.Size(100, 23)
			Me.button3.TabIndex = 233
			Me.button3.Text = "RESET"
			Me.button3.UseVisualStyleBackColor = False
			AddHandler Me.button3.Click, AddressOf Me.button3_Click
			Me.button4.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.button4.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.button4.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button4.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.button4.Location = New Global.System.Drawing.Point(265, 136)
			Me.button4.Name = "button4"
			Me.button4.Size = New Global.System.Drawing.Size(100, 23)
			Me.button4.TabIndex = 234
			Me.button4.Text = "RESET"
			Me.button4.UseVisualStyleBackColor = False
			AddHandler Me.button4.Click, AddressOf Me.button4_Click
			Me.button5.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.button5.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.button5.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button5.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.button5.Location = New Global.System.Drawing.Point(12, 167)
			Me.button5.Name = "button5"
			Me.button5.Size = New Global.System.Drawing.Size(370, 40)
			Me.button5.TabIndex = 235
			Me.button5.Text = "RESET ALL SETTINGS TO DEFAULT"
			Me.button5.UseVisualStyleBackColor = False
			AddHandler Me.button5.Click, AddressOf Me.button5_Click
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.FromArgb(50, 50, 50)
			MyBase.ClientSize = New Global.System.Drawing.Size(394, 218)
			MyBase.Controls.Add(Me.button5)
			MyBase.Controls.Add(Me.button4)
			MyBase.Controls.Add(Me.button3)
			MyBase.Controls.Add(Me.button1)
			MyBase.Controls.Add(Me.textBox4)
			MyBase.Controls.Add(Me.label6)
			MyBase.Controls.Add(Me.textBox2)
			MyBase.Controls.Add(Me.textBox1)
			MyBase.Controls.Add(Me.label4)
			MyBase.Controls.Add(Me.label3)
			MyBase.Controls.Add(Me.label2)
			MyBase.Controls.Add(Me.panel1)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "AdjustableScripts"
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "AdjustableScripts"
			AddHandler MyBase.Load, AddressOf Me.AdjustableScripts_Load
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x04000003 RID: 3
		Private components As Global.System.ComponentModel.IContainer = Nothing

		' Token: 0x04000004 RID: 4
		Private panel1 As Global.System.Windows.Forms.Panel

		' Token: 0x04000005 RID: 5
		Private label1 As Global.System.Windows.Forms.Label

		' Token: 0x04000006 RID: 6
		Private panel2 As Global.System.Windows.Forms.Panel

		' Token: 0x04000007 RID: 7
		Private button9 As Global.System.Windows.Forms.Button

		' Token: 0x04000008 RID: 8
		Private button2 As Global.System.Windows.Forms.Button

		' Token: 0x04000009 RID: 9
		Private label2 As Global.System.Windows.Forms.Label

		' Token: 0x0400000A RID: 10
		Private label3 As Global.System.Windows.Forms.Label

		' Token: 0x0400000B RID: 11
		Private label4 As Global.System.Windows.Forms.Label

		' Token: 0x0400000C RID: 12
		Private textBox1 As Global.System.Windows.Forms.TextBox

		' Token: 0x0400000D RID: 13
		Private textBox2 As Global.System.Windows.Forms.TextBox

		' Token: 0x0400000E RID: 14
		Private textBox4 As Global.System.Windows.Forms.TextBox

		' Token: 0x0400000F RID: 15
		Private label6 As Global.System.Windows.Forms.Label

		' Token: 0x04000010 RID: 16
		Private button1 As Global.System.Windows.Forms.Button

		' Token: 0x04000011 RID: 17
		Private button3 As Global.System.Windows.Forms.Button

		' Token: 0x04000012 RID: 18
		Private button4 As Global.System.Windows.Forms.Button

		' Token: 0x04000013 RID: 19
		Private button5 As Global.System.Windows.Forms.Button
	End Class
End Namespace
