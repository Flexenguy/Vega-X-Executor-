Namespace Vega_X
	' Token: 0x02000007 RID: 7
	Public Partial Class Options
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000061 RID: 97 RVA: 0x000023A7 File Offset: 0x000005A7
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000062 RID: 98 RVA: 0x00005134 File Offset: 0x00003334
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.Vega_X.Options))
			Me.panel1 = New Global.System.Windows.Forms.Panel()
			Me.button7 = New Global.System.Windows.Forms.Button()
			Me.button10 = New Global.System.Windows.Forms.Button()
			Me.panel2 = New Global.System.Windows.Forms.Panel()
			Me.label1 = New Global.System.Windows.Forms.Label()
			Me.button1 = New Global.System.Windows.Forms.Button()
			Me.button2 = New Global.System.Windows.Forms.Button()
			Me.button4 = New Global.System.Windows.Forms.Button()
			Me.checkBox1 = New Global.System.Windows.Forms.CheckBox()
			Me.checkBox2 = New Global.System.Windows.Forms.CheckBox()
			Me.button5 = New Global.System.Windows.Forms.Button()
			Me.button8 = New Global.System.Windows.Forms.Button()
			Me.button9 = New Global.System.Windows.Forms.Button()
			Me.button11 = New Global.System.Windows.Forms.Button()
			Me.button12 = New Global.System.Windows.Forms.Button()
			Me.checkBox3 = New Global.System.Windows.Forms.CheckBox()
			Me.button3 = New Global.System.Windows.Forms.Button()
			Me.button13 = New Global.System.Windows.Forms.Button()
			Me.panel5 = New Global.System.Windows.Forms.Panel()
			Me.label2 = New Global.System.Windows.Forms.Label()
			Me.label3 = New Global.System.Windows.Forms.Label()
			Me.richTextBox1 = New Global.System.Windows.Forms.RichTextBox()
			Me.button15 = New Global.System.Windows.Forms.Button()
			Me.button16 = New Global.System.Windows.Forms.Button()
			Me.button17 = New Global.System.Windows.Forms.Button()
			Me.button6 = New Global.System.Windows.Forms.Button()
			Me.button18 = New Global.System.Windows.Forms.Button()
			Me.button19 = New Global.System.Windows.Forms.Button()
			Me.richTextBox2 = New Global.System.Windows.Forms.RichTextBox()
			Me.label4 = New Global.System.Windows.Forms.Label()
			Me.button20 = New Global.System.Windows.Forms.Button()
			Me.button21 = New Global.System.Windows.Forms.Button()
			Me.button14 = New Global.System.Windows.Forms.Button()
			Me.panel1.SuspendLayout()
			MyBase.SuspendLayout()
			Me.panel1.BackColor = Global.System.Drawing.Color.FromArgb(60, 60, 60)
			Me.panel1.Controls.Add(Me.button7)
			Me.panel1.Controls.Add(Me.button10)
			Me.panel1.Controls.Add(Me.panel2)
			Me.panel1.Controls.Add(Me.label1)
			Me.panel1.Location = New Global.System.Drawing.Point(-1, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New Global.System.Drawing.Size(744, 40)
			Me.panel1.TabIndex = 0
			AddHandler Me.panel1.Paint, AddressOf Me.panel1_Paint
			AddHandler Me.panel1.MouseDown, AddressOf Me.panel1_MouseDown
			AddHandler Me.panel1.MouseMove, AddressOf Me.panel1_MouseMove
			Me.button7.BackColor = Global.System.Drawing.Color.FromArgb(60, 60, 60)
			Me.button7.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(60, 60, 60)
			Me.button7.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button7.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.button7.ForeColor = Global.System.Drawing.SystemColors.ControlLightLight
			Me.button7.Location = New Global.System.Drawing.Point(709, 5)
			Me.button7.Name = "button7"
			Me.button7.Size = New Global.System.Drawing.Size(30, 27)
			Me.button7.TabIndex = 14
			Me.button7.Text = "X"
			Me.button7.UseVisualStyleBackColor = False
			AddHandler Me.button7.Click, AddressOf Me.button7_Click_3
			Me.button10.BackColor = Global.System.Drawing.Color.FromArgb(60, 60, 60)
			Me.button10.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(60, 60, 60)
			Me.button10.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button10.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.button10.ForeColor = Global.System.Drawing.SystemColors.ControlLightLight
			Me.button10.Location = New Global.System.Drawing.Point(676, 5)
			Me.button10.Name = "button10"
			Me.button10.Size = New Global.System.Drawing.Size(30, 27)
			Me.button10.TabIndex = 13
			Me.button10.Text = "—"
			Me.button10.UseVisualStyleBackColor = False
			AddHandler Me.button10.Click, AddressOf Me.button10_Click_1
			Me.panel2.BackColor = Global.System.Drawing.Color.Transparent
			Me.panel2.BackgroundImage = CType(componentResourceManager.GetObject("panel2.BackgroundImage"), Global.System.Drawing.Image)
			Me.panel2.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Zoom
			Me.panel2.Location = New Global.System.Drawing.Point(1, 0)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New Global.System.Drawing.Size(44, 40)
			Me.panel2.TabIndex = 10
			Me.label1.AutoSize = True
			Me.label1.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.label1.ForeColor = Global.System.Drawing.SystemColors.Window
			Me.label1.Location = New Global.System.Drawing.Point(305, 8)
			Me.label1.Name = "label1"
			Me.label1.Size = New Global.System.Drawing.Size(132, 21)
			Me.label1.TabIndex = 3
			Me.label1.Text = "Vega X - Options"
			AddHandler Me.label1.Click, AddressOf Me.label1_Click
			AddHandler Me.label1.MouseDown, AddressOf Me.label1_MouseDown
			AddHandler Me.label1.MouseMove, AddressOf Me.label1_MouseMove
			Me.button1.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.button1.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button1.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.button1.Location = New Global.System.Drawing.Point(12, 82)
			Me.button1.Name = "button1"
			Me.button1.Size = New Global.System.Drawing.Size(128, 30)
			Me.button1.TabIndex = 4
			Me.button1.Text = "Kill Roblox"
			Me.button1.UseVisualStyleBackColor = False
			AddHandler Me.button1.Click, AddressOf Me.button1_Click
			Me.button2.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.button2.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.button2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button2.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.button2.Location = New Global.System.Drawing.Point(146, 118)
			Me.button2.Name = "button2"
			Me.button2.Size = New Global.System.Drawing.Size(123, 30)
			Me.button2.TabIndex = 5
			Me.button2.Text = "Unlock / Boost FPS"
			Me.button2.UseVisualStyleBackColor = False
			AddHandler Me.button2.Click, AddressOf Me.button2_Click
			Me.button4.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.button4.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.button4.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button4.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.button4.Location = New Global.System.Drawing.Point(12, 280)
			Me.button4.Name = "button4"
			Me.button4.Size = New Global.System.Drawing.Size(258, 38)
			Me.button4.TabIndex = 13
			Me.button4.Text = "Chat Bypass Script"
			Me.button4.UseVisualStyleBackColor = False
			AddHandler Me.button4.Click, AddressOf Me.button4_Click
			Me.checkBox1.AutoSize = True
			Me.checkBox1.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.checkBox1.Location = New Global.System.Drawing.Point(18, 154)
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Size = New Global.System.Drawing.Size(67, 17)
			Me.checkBox1.TabIndex = 23
			Me.checkBox1.Text = "Anti-AFK"
			Me.checkBox1.UseVisualStyleBackColor = True
			AddHandler Me.checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged
			Me.checkBox2.AutoSize = True
			Me.checkBox2.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.checkBox2.Location = New Global.System.Drawing.Point(186, 155)
			Me.checkBox2.Name = "checkBox2"
			Me.checkBox2.Size = New Global.System.Drawing.Size(77, 17)
			Me.checkBox2.TabIndex = 24
			Me.checkBox2.Text = "Bypass AC"
			Me.checkBox2.UseVisualStyleBackColor = True
			AddHandler Me.checkBox2.CheckedChanged, AddressOf Me.checkBox2_CheckedChanged
			Me.button5.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.button5.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.button5.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button5.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.button5.Location = New Global.System.Drawing.Point(12, 118)
			Me.button5.Name = "button5"
			Me.button5.Size = New Global.System.Drawing.Size(128, 29)
			Me.button5.TabIndex = 26
			Me.button5.Text = "Force Reset Character"
			Me.button5.UseVisualStyleBackColor = False
			AddHandler Me.button5.Click, AddressOf Me.button5_Click
			Me.button8.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.button8.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.button8.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button8.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.button8.Location = New Global.System.Drawing.Point(12, 245)
			Me.button8.Name = "button8"
			Me.button8.Size = New Global.System.Drawing.Size(258, 30)
			Me.button8.TabIndex = 28
			Me.button8.Text = "Find New Scripts"
			Me.button8.UseVisualStyleBackColor = False
			AddHandler Me.button8.Click, AddressOf Me.button8_Click_1
			Me.button9.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.button9.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.button9.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button9.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.button9.Location = New Global.System.Drawing.Point(12, 207)
			Me.button9.Name = "button9"
			Me.button9.Size = New Global.System.Drawing.Size(128, 32)
			Me.button9.TabIndex = 29
			Me.button9.Text = "Obfuscate Script"
			Me.button9.UseVisualStyleBackColor = False
			AddHandler Me.button9.Click, AddressOf Me.button9_Click
			Me.button11.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.button11.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.button11.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button11.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.button11.Location = New Global.System.Drawing.Point(146, 207)
			Me.button11.Name = "button11"
			Me.button11.Size = New Global.System.Drawing.Size(124, 32)
			Me.button11.TabIndex = 30
			Me.button11.Text = "Simple UI"
			Me.button11.UseVisualStyleBackColor = False
			AddHandler Me.button11.Click, AddressOf Me.button11_Click_1
			Me.button12.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.button12.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.button12.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button12.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.button12.Location = New Global.System.Drawing.Point(12, 177)
			Me.button12.Name = "button12"
			Me.button12.Size = New Global.System.Drawing.Size(259, 24)
			Me.button12.TabIndex = 31
			Me.button12.Text = "Disable Respawn"
			Me.button12.UseVisualStyleBackColor = False
			AddHandler Me.button12.Click, AddressOf Me.button12_Click
			Me.checkBox3.AutoSize = True
			Me.checkBox3.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.checkBox3.Location = New Global.System.Drawing.Point(103, 154)
			Me.checkBox3.Name = "checkBox3"
			Me.checkBox3.Size = New Global.System.Drawing.Size(68, 17)
			Me.checkBox3.TabIndex = 32
			Me.checkBox3.Text = "TopMost"
			Me.checkBox3.UseVisualStyleBackColor = True
			AddHandler Me.checkBox3.CheckedChanged, AddressOf Me.checkBox3_CheckedChanged
			Me.button3.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.button3.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.button3.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button3.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.button3.Location = New Global.System.Drawing.Point(12, 324)
			Me.button3.Name = "button3"
			Me.button3.Size = New Global.System.Drawing.Size(128, 30)
			Me.button3.TabIndex = 33
			Me.button3.Text = "Easy Minigame"
			Me.button3.UseVisualStyleBackColor = False
			AddHandler Me.button3.Click, AddressOf Me.button3_Click_2
			Me.button13.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.button13.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.button13.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button13.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.button13.Location = New Global.System.Drawing.Point(146, 324)
			Me.button13.Name = "button13"
			Me.button13.Size = New Global.System.Drawing.Size(124, 30)
			Me.button13.TabIndex = 35
			Me.button13.Text = "Version Checker"
			Me.button13.UseVisualStyleBackColor = False
			AddHandler Me.button13.Click, AddressOf Me.button13_Click
			Me.panel5.BackColor = Global.System.Drawing.Color.Transparent
			Me.panel5.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.panel5.ForeColor = Global.System.Drawing.SystemColors.ControlLightLight
			Me.panel5.Location = New Global.System.Drawing.Point(277, 82)
			Me.panel5.Name = "panel5"
			Me.panel5.Size = New Global.System.Drawing.Size(15, 315)
			Me.panel5.TabIndex = 125
			Me.label2.AutoSize = True
			Me.label2.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.label2.ForeColor = Global.System.Drawing.SystemColors.Window
			Me.label2.Location = New Global.System.Drawing.Point(75, 52)
			Me.label2.Name = "label2"
			Me.label2.Size = New Global.System.Drawing.Size(134, 21)
			Me.label2.TabIndex = 14
			Me.label2.Text = "Vega X - Settings"
			Me.label3.AutoSize = True
			Me.label3.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.label3.ForeColor = Global.System.Drawing.SystemColors.Window
			Me.label3.Location = New Global.System.Drawing.Point(365, 52)
			Me.label3.Name = "label3"
			Me.label3.Size = New Global.System.Drawing.Size(117, 21)
			Me.label3.TabIndex = 126
			Me.label3.Text = "Vega X - Extras"
			Me.richTextBox1.BackColor = Global.System.Drawing.Color.FromArgb(30, 30, 30)
			Me.richTextBox1.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.richTextBox1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.richTextBox1.ForeColor = Global.System.Drawing.SystemColors.Window
			Me.richTextBox1.ImeMode = Global.System.Windows.Forms.ImeMode.[On]
			Me.richTextBox1.Location = New Global.System.Drawing.Point(298, 82)
			Me.richTextBox1.Name = "richTextBox1"
			Me.richTextBox1.[ReadOnly] = True
			Me.richTextBox1.ScrollBars = Global.System.Windows.Forms.RichTextBoxScrollBars.None
			Me.richTextBox1.Size = New Global.System.Drawing.Size(262, 146)
			Me.richTextBox1.TabIndex = 127
			Me.richTextBox1.Text = componentResourceManager.GetString("richTextBox1.Text")
			AddHandler Me.richTextBox1.TextChanged, AddressOf Me.richTextBox1_TextChanged
			Me.button15.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.button15.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.button15.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button15.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.button15.Location = New Global.System.Drawing.Point(298, 324)
			Me.button15.Name = "button15"
			Me.button15.Size = New Global.System.Drawing.Size(123, 30)
			Me.button15.TabIndex = 130
			Me.button15.Text = "Credits"
			Me.button15.UseVisualStyleBackColor = False
			AddHandler Me.button15.Click, AddressOf Me.button15_Click
			Me.button16.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.button16.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.button16.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button16.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.button16.Location = New Global.System.Drawing.Point(427, 324)
			Me.button16.Name = "button16"
			Me.button16.Size = New Global.System.Drawing.Size(133, 30)
			Me.button16.TabIndex = 131
			Me.button16.Text = "Newest Verison"
			Me.button16.UseVisualStyleBackColor = False
			AddHandler Me.button16.Click, AddressOf Me.button16_Click
			Me.button17.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.button17.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.button17.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button17.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.button17.Location = New Global.System.Drawing.Point(298, 360)
			Me.button17.Name = "button17"
			Me.button17.Size = New Global.System.Drawing.Size(262, 37)
			Me.button17.TabIndex = 132
			Me.button17.Text = "Join My Community Discord Server"
			Me.button17.UseVisualStyleBackColor = False
			AddHandler Me.button17.Click, AddressOf Me.button17_Click
			Me.button6.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.button6.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.button6.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button6.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.button6.Location = New Global.System.Drawing.Point(146, 82)
			Me.button6.Name = "button6"
			Me.button6.Size = New Global.System.Drawing.Size(123, 30)
			Me.button6.TabIndex = 133
			Me.button6.Text = "Flappy Bird"
			Me.button6.UseVisualStyleBackColor = False
			AddHandler Me.button6.Click, AddressOf Me.button6_Click
			Me.button18.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.button18.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.button18.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button18.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.button18.Location = New Global.System.Drawing.Point(298, 234)
			Me.button18.Name = "button18"
			Me.button18.Size = New Global.System.Drawing.Size(262, 41)
			Me.button18.TabIndex = 134
			Me.button18.Text = "Adjustable Scripts Menu"
			Me.button18.UseVisualStyleBackColor = False
			AddHandler Me.button18.Click, AddressOf Me.button18_Click
			Me.button19.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.button19.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.button19.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button19.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.button19.Location = New Global.System.Drawing.Point(298, 280)
			Me.button19.Name = "button19"
			Me.button19.Size = New Global.System.Drawing.Size(262, 38)
			Me.button19.TabIndex = 135
			Me.button19.Text = "Troubleshoot Tester"
			Me.button19.UseVisualStyleBackColor = False
			AddHandler Me.button19.Click, AddressOf Me.button19_Click
			Me.richTextBox2.BackColor = Global.System.Drawing.Color.FromArgb(30, 30, 30)
			Me.richTextBox2.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.richTextBox2.Font = New Global.System.Drawing.Font("Courier New", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.richTextBox2.ForeColor = Global.System.Drawing.Color.ForestGreen
			Me.richTextBox2.Location = New Global.System.Drawing.Point(566, 82)
			Me.richTextBox2.Name = "richTextBox2"
			Me.richTextBox2.Size = New Global.System.Drawing.Size(165, 221)
			Me.richTextBox2.TabIndex = 136
			Me.richTextBox2.Text = "-- Vega X - Alternative Execution Method" & vbLf & vbLf & "-- Full LUA Compatible" & vbLf & vbLf & "-- Made By 1_F0 (youtube.com/1f0yt)" & vbLf
			Me.label4.AutoSize = True
			Me.label4.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.label4.ForeColor = Global.System.Drawing.SystemColors.Window
			Me.label4.Location = New Global.System.Drawing.Point(574, 52)
			Me.label4.Name = "label4"
			Me.label4.Size = New Global.System.Drawing.Size(146, 21)
			Me.label4.TabIndex = 137
			Me.label4.Text = "Alternate Executor"
			Me.button20.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.button20.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.button20.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button20.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.button20.Location = New Global.System.Drawing.Point(566, 309)
			Me.button20.Name = "button20"
			Me.button20.Size = New Global.System.Drawing.Size(165, 45)
			Me.button20.TabIndex = 138
			Me.button20.Text = "Execute"
			Me.button20.UseVisualStyleBackColor = False
			AddHandler Me.button20.Click, AddressOf Me.button20_Click
			Me.button21.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.button21.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.button21.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button21.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.button21.Location = New Global.System.Drawing.Point(566, 360)
			Me.button21.Name = "button21"
			Me.button21.Size = New Global.System.Drawing.Size(165, 36)
			Me.button21.TabIndex = 139
			Me.button21.Text = "Clear"
			Me.button21.UseVisualStyleBackColor = False
			AddHandler Me.button21.Click, AddressOf Me.button21_Click
			Me.button14.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.button14.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.button14.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button14.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.button14.Location = New Global.System.Drawing.Point(12, 360)
			Me.button14.Name = "button14"
			Me.button14.Size = New Global.System.Drawing.Size(258, 37)
			Me.button14.TabIndex = 129
			Me.button14.Text = "Options Menu Button Explainations"
			Me.button14.UseVisualStyleBackColor = False
			AddHandler Me.button14.Click, AddressOf Me.button14_Click
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.FromArgb(50, 50, 50)
			MyBase.ClientSize = New Global.System.Drawing.Size(743, 408)
			MyBase.Controls.Add(Me.button21)
			MyBase.Controls.Add(Me.button20)
			MyBase.Controls.Add(Me.label4)
			MyBase.Controls.Add(Me.richTextBox2)
			MyBase.Controls.Add(Me.button19)
			MyBase.Controls.Add(Me.button18)
			MyBase.Controls.Add(Me.button6)
			MyBase.Controls.Add(Me.button17)
			MyBase.Controls.Add(Me.button16)
			MyBase.Controls.Add(Me.button15)
			MyBase.Controls.Add(Me.button14)
			MyBase.Controls.Add(Me.richTextBox1)
			MyBase.Controls.Add(Me.label3)
			MyBase.Controls.Add(Me.label2)
			MyBase.Controls.Add(Me.panel5)
			MyBase.Controls.Add(Me.button13)
			MyBase.Controls.Add(Me.button3)
			MyBase.Controls.Add(Me.checkBox3)
			MyBase.Controls.Add(Me.button12)
			MyBase.Controls.Add(Me.button11)
			MyBase.Controls.Add(Me.button9)
			MyBase.Controls.Add(Me.button8)
			MyBase.Controls.Add(Me.button5)
			MyBase.Controls.Add(Me.checkBox2)
			MyBase.Controls.Add(Me.checkBox1)
			MyBase.Controls.Add(Me.button4)
			MyBase.Controls.Add(Me.button2)
			MyBase.Controls.Add(Me.button1)
			MyBase.Controls.Add(Me.panel1)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "Options"
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			AddHandler MyBase.Load, AddressOf Me.Options_Load
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x0400003C RID: 60
		Private components As Global.System.ComponentModel.IContainer = Nothing

		' Token: 0x0400003D RID: 61
		Private panel1 As Global.System.Windows.Forms.Panel

		' Token: 0x0400003E RID: 62
		Private button1 As Global.System.Windows.Forms.Button

		' Token: 0x0400003F RID: 63
		Private button2 As Global.System.Windows.Forms.Button

		' Token: 0x04000040 RID: 64
		Private label1 As Global.System.Windows.Forms.Label

		' Token: 0x04000041 RID: 65
		Private panel2 As Global.System.Windows.Forms.Panel

		' Token: 0x04000042 RID: 66
		Private button4 As Global.System.Windows.Forms.Button

		' Token: 0x04000043 RID: 67
		Private checkBox1 As Global.System.Windows.Forms.CheckBox

		' Token: 0x04000044 RID: 68
		Private checkBox2 As Global.System.Windows.Forms.CheckBox

		' Token: 0x04000045 RID: 69
		Private button5 As Global.System.Windows.Forms.Button

		' Token: 0x04000046 RID: 70
		Private button8 As Global.System.Windows.Forms.Button

		' Token: 0x04000047 RID: 71
		Private button9 As Global.System.Windows.Forms.Button

		' Token: 0x04000048 RID: 72
		Private button10 As Global.System.Windows.Forms.Button

		' Token: 0x04000049 RID: 73
		Private button11 As Global.System.Windows.Forms.Button

		' Token: 0x0400004A RID: 74
		Private button12 As Global.System.Windows.Forms.Button

		' Token: 0x0400004B RID: 75
		Private checkBox3 As Global.System.Windows.Forms.CheckBox

		' Token: 0x0400004C RID: 76
		Private button3 As Global.System.Windows.Forms.Button

		' Token: 0x0400004D RID: 77
		Private button13 As Global.System.Windows.Forms.Button

		' Token: 0x0400004E RID: 78
		Private panel5 As Global.System.Windows.Forms.Panel

		' Token: 0x0400004F RID: 79
		Private label2 As Global.System.Windows.Forms.Label

		' Token: 0x04000050 RID: 80
		Private label3 As Global.System.Windows.Forms.Label

		' Token: 0x04000051 RID: 81
		Private richTextBox1 As Global.System.Windows.Forms.RichTextBox

		' Token: 0x04000052 RID: 82
		Private button15 As Global.System.Windows.Forms.Button

		' Token: 0x04000053 RID: 83
		Private button16 As Global.System.Windows.Forms.Button

		' Token: 0x04000054 RID: 84
		Private button7 As Global.System.Windows.Forms.Button

		' Token: 0x04000055 RID: 85
		Private button17 As Global.System.Windows.Forms.Button

		' Token: 0x04000056 RID: 86
		Private button6 As Global.System.Windows.Forms.Button

		' Token: 0x04000057 RID: 87
		Private button18 As Global.System.Windows.Forms.Button

		' Token: 0x04000058 RID: 88
		Private button19 As Global.System.Windows.Forms.Button

		' Token: 0x04000059 RID: 89
		Private richTextBox2 As Global.System.Windows.Forms.RichTextBox

		' Token: 0x0400005A RID: 90
		Private label4 As Global.System.Windows.Forms.Label

		' Token: 0x0400005B RID: 91
		Private button20 As Global.System.Windows.Forms.Button

		' Token: 0x0400005C RID: 92
		Private button21 As Global.System.Windows.Forms.Button

		' Token: 0x0400005D RID: 93
		Private button14 As Global.System.Windows.Forms.Button
	End Class
End Namespace
