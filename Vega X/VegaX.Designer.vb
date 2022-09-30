Namespace Vega_X
	' Token: 0x0200000F RID: 15
	Public Partial Class VegaX
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000298 RID: 664 RVA: 0x000029BA File Offset: 0x00000BBA
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000299 RID: 665 RVA: 0x000245E0 File Offset: 0x000227E0
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.Vega_X.VegaX))
			Me.panel1 = New Global.System.Windows.Forms.Panel()
			Me.EasyExploitRadioButton = New Global.System.Windows.Forms.RadioButton()
			Me.WrdRadioButton = New Global.System.Windows.Forms.RadioButton()
			Me.label2 = New Global.System.Windows.Forms.Label()
			Me.button11 = New Global.System.Windows.Forms.Button()
			Me.button2 = New Global.System.Windows.Forms.Button()
			Me.button1 = New Global.System.Windows.Forms.Button()
			Me.label1 = New Global.System.Windows.Forms.Label()
			Me.panel2 = New Global.System.Windows.Forms.Panel()
			Me.checkBox1 = New Global.System.Windows.Forms.CheckBox()
			Me.listBox1 = New Global.System.Windows.Forms.ListBox()
			Me.TabControl1 = New Global.System.Windows.Forms.TabControl()
			Me.RTab = New Global.System.Windows.Forms.Button()
			Me.button12 = New Global.System.Windows.Forms.Button()
			Me.lightThemeToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator3 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.grayThemeToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.redToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.orangeToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.yellowToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.greenToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.blueToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.purpleToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.darkGreenToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.lightBlueToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.blackToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.pinkToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.tanToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.whiteToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator4 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.dEFAULTTHEMEToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.contextMenuStrip1 = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.toolStripSeparator11 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.toolStripSeparator15 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.topBarPanelColorsToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator2 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.lightBlueToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.deepRedToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.lightGreenToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.dimRedToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.brightPurpleToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator17 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.toolStripSeparator1 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.toolStripSeparator14 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.cUSTOMTHEMEToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.rEMOVECUSTOMTHEMEToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator16 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.tRANSPARENTTEXTBOXToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator5 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.onToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.offToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator6 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.toolStripSeparator10 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.trackBar1 = New Global.System.Windows.Forms.TrackBar()
			Me.trackBar2 = New Global.System.Windows.Forms.TrackBar()
			Me.timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.button13 = New Global.System.Windows.Forms.Button()
			Me.panel3 = New Global.System.Windows.Forms.Panel()
			Me.panel4 = New Global.System.Windows.Forms.Panel()
			Me.panel5 = New Global.System.Windows.Forms.Panel()
			Me.panel6 = New Global.System.Windows.Forms.Panel()
			Me.panel7 = New Global.System.Windows.Forms.Panel()
			Me.panel8 = New Global.System.Windows.Forms.Panel()
			Me.panel9 = New Global.System.Windows.Forms.Panel()
			Me.pictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.panel10 = New Global.System.Windows.Forms.Panel()
			Me.panel11 = New Global.System.Windows.Forms.Panel()
			Me.panel12 = New Global.System.Windows.Forms.Panel()
			Me.panel13 = New Global.System.Windows.Forms.Panel()
			Me.panel14 = New Global.System.Windows.Forms.Panel()
			Me.rButton3 = New Global.Vega_X.RButton()
			Me.rButton2 = New Global.Vega_X.RButton()
			Me.rButton1 = New Global.Vega_X.RButton()
			Me.rButton4 = New Global.Vega_X.RButton()
			Me.rButton5 = New Global.Vega_X.RButton()
			Me.rButton6 = New Global.Vega_X.RButton()
			Me.rButton7 = New Global.Vega_X.RButton()
			Me.button16 = New Global.Vega_X.RButton()
			Me.rButton8 = New Global.Vega_X.RButton()
			Me.rButton9 = New Global.Vega_X.RButton()
			Me.rButton10 = New Global.Vega_X.RButton()
			Me.ATab = New Global.System.Windows.Forms.Button()
			Me.panel1.SuspendLayout()
			Me.contextMenuStrip1.SuspendLayout()
			CType(Me.trackBar1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trackBar2, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.panel1.BackColor = Global.System.Drawing.Color.FromArgb(60, 60, 60)
			Me.panel1.Controls.Add(Me.EasyExploitRadioButton)
			Me.panel1.Controls.Add(Me.WrdRadioButton)
			Me.panel1.Controls.Add(Me.label2)
			Me.panel1.Controls.Add(Me.button11)
			Me.panel1.Controls.Add(Me.button2)
			Me.panel1.Controls.Add(Me.button1)
			Me.panel1.Controls.Add(Me.label1)
			Me.panel1.Controls.Add(Me.panel2)
			Me.panel1.Location = New Global.System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New Global.System.Drawing.Size(815, 43)
			Me.panel1.TabIndex = 0
			AddHandler Me.panel1.Click, AddressOf Me.panel1_Click
			AddHandler Me.panel1.Paint, AddressOf Me.panel1_Paint
			AddHandler Me.panel1.MouseDown, AddressOf Me.panel1_MouseDown
			AddHandler Me.panel1.MouseMove, AddressOf Me.panel1_MouseMove
			Me.EasyExploitRadioButton.AutoSize = True
			Me.EasyExploitRadioButton.Location = New Global.System.Drawing.Point(138, 13)
			Me.EasyExploitRadioButton.Name = "EasyExploitRadioButton"
			Me.EasyExploitRadioButton.Size = New Global.System.Drawing.Size(59, 17)
			Me.EasyExploitRadioButton.TabIndex = 325
			Me.EasyExploitRadioButton.Text = "EX API"
			Me.EasyExploitRadioButton.UseVisualStyleBackColor = True
			AddHandler Me.EasyExploitRadioButton.CheckedChanged, AddressOf Me.EasyExploitRadioButton_CheckedChanged
			Me.WrdRadioButton.AutoSize = True
			Me.WrdRadioButton.Location = New Global.System.Drawing.Point(62, 13)
			Me.WrdRadioButton.Name = "WrdRadioButton"
			Me.WrdRadioButton.Size = New Global.System.Drawing.Size(72, 17)
			Me.WrdRadioButton.TabIndex = 324
			Me.WrdRadioButton.Text = "WRD API"
			Me.WrdRadioButton.UseVisualStyleBackColor = True
			AddHandler Me.WrdRadioButton.CheckedChanged, AddressOf Me.WrdRadioButton_CheckedChanged
			Me.label2.AutoSize = True
			Me.label2.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 14.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.label2.ForeColor = Global.System.Drawing.Color.Ivory
			Me.label2.Location = New Global.System.Drawing.Point(56, 8)
			Me.label2.Name = "label2"
			Me.label2.Size = New Global.System.Drawing.Size(0, 25)
			Me.label2.TabIndex = 21
			Me.label2.Visible = False
			Me.button11.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.button11.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.button11.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button11.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.button11.Location = New Global.System.Drawing.Point(636, 6)
			Me.button11.Name = "button11"
			Me.button11.Size = New Global.System.Drawing.Size(89, 30)
			Me.button11.TabIndex = 41
			Me.button11.Text = "Refresh Scripts"
			Me.button11.UseVisualStyleBackColor = False
			AddHandler Me.button11.Click, AddressOf Me.button11_Click_1
			Me.button2.BackColor = Global.System.Drawing.Color.FromArgb(60, 60, 60)
			Me.button2.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(60, 60, 60)
			Me.button2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.button2.ForeColor = Global.System.Drawing.SystemColors.ControlLightLight
			Me.button2.Location = New Global.System.Drawing.Point(732, 4)
			Me.button2.Name = "button2"
			Me.button2.Size = New Global.System.Drawing.Size(30, 36)
			Me.button2.TabIndex = 4
			Me.button2.Text = "—"
			Me.button2.UseVisualStyleBackColor = False
			AddHandler Me.button2.Click, AddressOf Me.button2_Click
			Me.button1.BackColor = Global.System.Drawing.Color.FromArgb(60, 60, 60)
			Me.button1.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(60, 60, 60)
			Me.button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.button1.ForeColor = Global.System.Drawing.SystemColors.ControlLightLight
			Me.button1.Location = New Global.System.Drawing.Point(768, 3)
			Me.button1.Name = "button1"
			Me.button1.Size = New Global.System.Drawing.Size(42, 37)
			Me.button1.TabIndex = 3
			Me.button1.Text = "X"
			Me.button1.UseVisualStyleBackColor = False
			AddHandler Me.button1.Click, AddressOf Me.button1_Click
			Me.label1.AutoSize = True
			Me.label1.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.label1.ForeColor = Global.System.Drawing.SystemColors.Window
			Me.label1.Location = New Global.System.Drawing.Point(331, 10)
			Me.label1.Name = "label1"
			Me.label1.Size = New Global.System.Drawing.Size(122, 21)
			Me.label1.TabIndex = 2
			Me.label1.Text = "Vega X - v2.1.8a"
			AddHandler Me.label1.Click, AddressOf Me.label1_Click
			AddHandler Me.label1.MouseDown, AddressOf Me.label1_MouseDown
			AddHandler Me.label1.MouseMove, AddressOf Me.label1_MouseMove
			Me.panel2.BackColor = Global.System.Drawing.Color.Transparent
			Me.panel2.BackgroundImage = CType(componentResourceManager.GetObject("panel2.BackgroundImage"), Global.System.Drawing.Image)
			Me.panel2.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Zoom
			Me.panel2.Location = New Global.System.Drawing.Point(2, 2)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New Global.System.Drawing.Size(48, 39)
			Me.panel2.TabIndex = 1
			AddHandler Me.panel2.Click, AddressOf Me.panel2_Click
			AddHandler Me.panel2.Paint, AddressOf Me.panel2_Paint
			Me.checkBox1.AutoSize = True
			Me.checkBox1.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.checkBox1.Location = New Global.System.Drawing.Point(705, 358)
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Size = New Global.System.Drawing.Size(83, 17)
			Me.checkBox1.TabIndex = 22
			Me.checkBox1.Text = "Transparent"
			Me.checkBox1.UseVisualStyleBackColor = True
			AddHandler Me.checkBox1.CheckedChanged, AddressOf Me.checkBox1_CheckedChanged_1
			Me.listBox1.BackColor = Global.System.Drawing.Color.FromArgb(57, 57, 57)
			Me.listBox1.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.listBox1.ForeColor = Global.System.Drawing.SystemColors.Window
			Me.listBox1.FormattingEnabled = True
			Me.listBox1.Location = New Global.System.Drawing.Point(686, 99)
			Me.listBox1.Name = "listBox1"
			Me.listBox1.Size = New Global.System.Drawing.Size(116, 247)
			Me.listBox1.TabIndex = 9
			AddHandler Me.listBox1.Click, AddressOf Me.listBox1_Click
			AddHandler Me.listBox1.SelectedIndexChanged, AddressOf Me.listBox1_SelectedIndexChanged
			Me.TabControl1.Location = New Global.System.Drawing.Point(73, 46)
			Me.TabControl1.Name = "TabControl1"
			Me.TabControl1.SelectedIndex = 0
			Me.TabControl1.Size = New Global.System.Drawing.Size(607, 268)
			Me.TabControl1.TabIndex = 24
			AddHandler Me.TabControl1.SelectedIndexChanged, AddressOf Me.TabControl1_SelectedIndexChanged
			AddHandler Me.TabControl1.Click, AddressOf Me.TabControl1_Click
			Me.RTab.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.RTab.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.RTab.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.RTab.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.RTab.Location = New Global.System.Drawing.Point(686, 72)
			Me.RTab.Name = "RTab"
			Me.RTab.Size = New Global.System.Drawing.Size(116, 22)
			Me.RTab.TabIndex = 26
			Me.RTab.Text = "Remove Tab"
			Me.RTab.UseVisualStyleBackColor = False
			AddHandler Me.RTab.Click, AddressOf Me.RTab_Click
			Me.button12.BackColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.button12.Location = New Global.System.Drawing.Point(792, 100)
			Me.button12.Name = "button12"
			Me.button12.Size = New Global.System.Drawing.Size(10, 10)
			Me.button12.TabIndex = 27
			Me.button12.Text = "button12"
			Me.button12.UseVisualStyleBackColor = False
			Me.lightThemeToolStripMenuItem.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.toolStripSeparator3, Me.grayThemeToolStripMenuItem, Me.redToolStripMenuItem, Me.orangeToolStripMenuItem, Me.yellowToolStripMenuItem, Me.greenToolStripMenuItem, Me.blueToolStripMenuItem, Me.purpleToolStripMenuItem, Me.darkGreenToolStripMenuItem, Me.lightBlueToolStripMenuItem1, Me.blackToolStripMenuItem, Me.pinkToolStripMenuItem, Me.tanToolStripMenuItem, Me.whiteToolStripMenuItem, Me.toolStripSeparator4 })
			Me.lightThemeToolStripMenuItem.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.lightThemeToolStripMenuItem.Name = "lightThemeToolStripMenuItem"
			Me.lightThemeToolStripMenuItem.Size = New Global.System.Drawing.Size(211, 22)
			Me.lightThemeToolStripMenuItem.Text = "Colors"
			AddHandler Me.lightThemeToolStripMenuItem.Click, AddressOf Me.lightThemeToolStripMenuItem_Click
			Me.toolStripSeparator3.Name = "toolStripSeparator3"
			Me.toolStripSeparator3.Size = New Global.System.Drawing.Size(129, 6)
			Me.grayThemeToolStripMenuItem.Name = "grayThemeToolStripMenuItem"
			Me.grayThemeToolStripMenuItem.Size = New Global.System.Drawing.Size(132, 22)
			Me.grayThemeToolStripMenuItem.Text = "Gray"
			AddHandler Me.grayThemeToolStripMenuItem.Click, AddressOf Me.grayThemeToolStripMenuItem_Click
			Me.redToolStripMenuItem.Name = "redToolStripMenuItem"
			Me.redToolStripMenuItem.Size = New Global.System.Drawing.Size(132, 22)
			Me.redToolStripMenuItem.Text = "Red"
			AddHandler Me.redToolStripMenuItem.Click, AddressOf Me.redToolStripMenuItem_Click
			Me.orangeToolStripMenuItem.Name = "orangeToolStripMenuItem"
			Me.orangeToolStripMenuItem.Size = New Global.System.Drawing.Size(132, 22)
			Me.orangeToolStripMenuItem.Text = "Orange"
			AddHandler Me.orangeToolStripMenuItem.Click, AddressOf Me.orangeToolStripMenuItem_Click
			Me.yellowToolStripMenuItem.Name = "yellowToolStripMenuItem"
			Me.yellowToolStripMenuItem.Size = New Global.System.Drawing.Size(132, 22)
			Me.yellowToolStripMenuItem.Text = "Yellow"
			AddHandler Me.yellowToolStripMenuItem.Click, AddressOf Me.yellowToolStripMenuItem_Click
			Me.greenToolStripMenuItem.Name = "greenToolStripMenuItem"
			Me.greenToolStripMenuItem.Size = New Global.System.Drawing.Size(132, 22)
			Me.greenToolStripMenuItem.Text = "Green"
			AddHandler Me.greenToolStripMenuItem.Click, AddressOf Me.greenToolStripMenuItem_Click
			Me.blueToolStripMenuItem.Name = "blueToolStripMenuItem"
			Me.blueToolStripMenuItem.Size = New Global.System.Drawing.Size(132, 22)
			Me.blueToolStripMenuItem.Text = "Blue"
			AddHandler Me.blueToolStripMenuItem.Click, AddressOf Me.blueToolStripMenuItem_Click
			Me.purpleToolStripMenuItem.Name = "purpleToolStripMenuItem"
			Me.purpleToolStripMenuItem.Size = New Global.System.Drawing.Size(132, 22)
			Me.purpleToolStripMenuItem.Text = "Purple"
			AddHandler Me.purpleToolStripMenuItem.Click, AddressOf Me.purpleToolStripMenuItem_Click
			Me.darkGreenToolStripMenuItem.Name = "darkGreenToolStripMenuItem"
			Me.darkGreenToolStripMenuItem.Size = New Global.System.Drawing.Size(132, 22)
			Me.darkGreenToolStripMenuItem.Text = "Dark Green"
			AddHandler Me.darkGreenToolStripMenuItem.Click, AddressOf Me.darkGreenToolStripMenuItem_Click
			Me.lightBlueToolStripMenuItem1.Name = "lightBlueToolStripMenuItem1"
			Me.lightBlueToolStripMenuItem1.Size = New Global.System.Drawing.Size(132, 22)
			Me.lightBlueToolStripMenuItem1.Text = "Light Blue"
			AddHandler Me.lightBlueToolStripMenuItem1.Click, AddressOf Me.lightBlueToolStripMenuItem1_Click
			Me.blackToolStripMenuItem.Name = "blackToolStripMenuItem"
			Me.blackToolStripMenuItem.Size = New Global.System.Drawing.Size(132, 22)
			Me.blackToolStripMenuItem.Text = "Black"
			AddHandler Me.blackToolStripMenuItem.Click, AddressOf Me.blackToolStripMenuItem_Click
			Me.pinkToolStripMenuItem.Name = "pinkToolStripMenuItem"
			Me.pinkToolStripMenuItem.Size = New Global.System.Drawing.Size(132, 22)
			Me.pinkToolStripMenuItem.Text = "Pink"
			AddHandler Me.pinkToolStripMenuItem.Click, AddressOf Me.pinkToolStripMenuItem_Click
			Me.tanToolStripMenuItem.Name = "tanToolStripMenuItem"
			Me.tanToolStripMenuItem.Size = New Global.System.Drawing.Size(132, 22)
			Me.tanToolStripMenuItem.Text = "Tan"
			AddHandler Me.tanToolStripMenuItem.Click, AddressOf Me.tanToolStripMenuItem_Click
			Me.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem"
			Me.whiteToolStripMenuItem.Size = New Global.System.Drawing.Size(132, 22)
			Me.whiteToolStripMenuItem.Text = "White"
			AddHandler Me.whiteToolStripMenuItem.Click, AddressOf Me.whiteToolStripMenuItem_Click
			Me.toolStripSeparator4.Name = "toolStripSeparator4"
			Me.toolStripSeparator4.Size = New Global.System.Drawing.Size(129, 6)
			Me.dEFAULTTHEMEToolStripMenuItem.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.dEFAULTTHEMEToolStripMenuItem.Name = "dEFAULTTHEMEToolStripMenuItem"
			Me.dEFAULTTHEMEToolStripMenuItem.Size = New Global.System.Drawing.Size(211, 22)
			Me.dEFAULTTHEMEToolStripMenuItem.Text = "DEFAULT THEME"
			AddHandler Me.dEFAULTTHEMEToolStripMenuItem.Click, AddressOf Me.dEFAULTTHEMEToolStripMenuItem_Click
			Me.contextMenuStrip1.BackColor = Global.System.Drawing.Color.FromArgb(70, 70, 70)
			Me.contextMenuStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.toolStripSeparator11, Me.lightThemeToolStripMenuItem, Me.toolStripSeparator15, Me.topBarPanelColorsToolStripMenuItem, Me.toolStripSeparator1, Me.dEFAULTTHEMEToolStripMenuItem, Me.toolStripSeparator14, Me.cUSTOMTHEMEToolStripMenuItem, Me.rEMOVECUSTOMTHEMEToolStripMenuItem, Me.toolStripSeparator16, Me.tRANSPARENTTEXTBOXToolStripMenuItem, Me.toolStripSeparator10 })
			Me.contextMenuStrip1.Name = "contextMenuStrip1"
			Me.contextMenuStrip1.Size = New Global.System.Drawing.Size(212, 172)
			AddHandler Me.contextMenuStrip1.MouseLeave, AddressOf Me.contextMenuStrip1_MouseLeave
			Me.toolStripSeparator11.Name = "toolStripSeparator11"
			Me.toolStripSeparator11.Size = New Global.System.Drawing.Size(208, 6)
			Me.toolStripSeparator15.Name = "toolStripSeparator15"
			Me.toolStripSeparator15.Size = New Global.System.Drawing.Size(208, 6)
			AddHandler Me.toolStripSeparator15.Click, AddressOf Me.toolStripSeparator15_Click
			Me.topBarPanelColorsToolStripMenuItem.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.toolStripSeparator2, Me.lightBlueToolStripMenuItem, Me.deepRedToolStripMenuItem, Me.lightGreenToolStripMenuItem, Me.dimRedToolStripMenuItem, Me.toolStripMenuItem1, Me.brightPurpleToolStripMenuItem, Me.toolStripSeparator17 })
			Me.topBarPanelColorsToolStripMenuItem.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.topBarPanelColorsToolStripMenuItem.Name = "topBarPanelColorsToolStripMenuItem"
			Me.topBarPanelColorsToolStripMenuItem.Size = New Global.System.Drawing.Size(211, 22)
			Me.topBarPanelColorsToolStripMenuItem.Text = "TopBar / Panel Colors"
			Me.toolStripSeparator2.Name = "toolStripSeparator2"
			Me.toolStripSeparator2.Size = New Global.System.Drawing.Size(145, 6)
			Me.lightBlueToolStripMenuItem.Name = "lightBlueToolStripMenuItem"
			Me.lightBlueToolStripMenuItem.Size = New Global.System.Drawing.Size(148, 22)
			Me.lightBlueToolStripMenuItem.Text = "Light Blue"
			AddHandler Me.lightBlueToolStripMenuItem.Click, AddressOf Me.lightBlueToolStripMenuItem_Click_1
			Me.deepRedToolStripMenuItem.Name = "deepRedToolStripMenuItem"
			Me.deepRedToolStripMenuItem.Size = New Global.System.Drawing.Size(148, 22)
			Me.deepRedToolStripMenuItem.Text = "Bright Orange"
			AddHandler Me.deepRedToolStripMenuItem.Click, AddressOf Me.deepRedToolStripMenuItem_Click
			Me.lightGreenToolStripMenuItem.Name = "lightGreenToolStripMenuItem"
			Me.lightGreenToolStripMenuItem.Size = New Global.System.Drawing.Size(148, 22)
			Me.lightGreenToolStripMenuItem.Text = "Light Green"
			AddHandler Me.lightGreenToolStripMenuItem.Click, AddressOf Me.lightGreenToolStripMenuItem_Click
			Me.dimRedToolStripMenuItem.Name = "dimRedToolStripMenuItem"
			Me.dimRedToolStripMenuItem.Size = New Global.System.Drawing.Size(148, 22)
			Me.dimRedToolStripMenuItem.Text = "Dim Red"
			AddHandler Me.dimRedToolStripMenuItem.Click, AddressOf Me.dimRedToolStripMenuItem_Click
			Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
			Me.toolStripMenuItem1.Size = New Global.System.Drawing.Size(148, 22)
			Me.toolStripMenuItem1.Text = "Black"
			AddHandler Me.toolStripMenuItem1.Click, AddressOf Me.toolStripMenuItem1_Click
			Me.brightPurpleToolStripMenuItem.Name = "brightPurpleToolStripMenuItem"
			Me.brightPurpleToolStripMenuItem.Size = New Global.System.Drawing.Size(148, 22)
			Me.brightPurpleToolStripMenuItem.Text = "Bright Purple"
			AddHandler Me.brightPurpleToolStripMenuItem.Click, AddressOf Me.brightPurpleToolStripMenuItem_Click
			Me.toolStripSeparator17.Name = "toolStripSeparator17"
			Me.toolStripSeparator17.Size = New Global.System.Drawing.Size(145, 6)
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			Me.toolStripSeparator1.Size = New Global.System.Drawing.Size(208, 6)
			Me.toolStripSeparator14.Name = "toolStripSeparator14"
			Me.toolStripSeparator14.Size = New Global.System.Drawing.Size(208, 6)
			Me.cUSTOMTHEMEToolStripMenuItem.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.cUSTOMTHEMEToolStripMenuItem.Name = "cUSTOMTHEMEToolStripMenuItem"
			Me.cUSTOMTHEMEToolStripMenuItem.Size = New Global.System.Drawing.Size(211, 22)
			Me.cUSTOMTHEMEToolStripMenuItem.Text = "CUSTOM THEME"
			AddHandler Me.cUSTOMTHEMEToolStripMenuItem.Click, AddressOf Me.cUSTOMTHEMEToolStripMenuItem_Click_1
			Me.rEMOVECUSTOMTHEMEToolStripMenuItem.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.rEMOVECUSTOMTHEMEToolStripMenuItem.Name = "rEMOVECUSTOMTHEMEToolStripMenuItem"
			Me.rEMOVECUSTOMTHEMEToolStripMenuItem.Size = New Global.System.Drawing.Size(211, 22)
			Me.rEMOVECUSTOMTHEMEToolStripMenuItem.Text = "REMOVE CUSTOM THEME"
			AddHandler Me.rEMOVECUSTOMTHEMEToolStripMenuItem.Click, AddressOf Me.rEMOVECUSTOMTHEMEToolStripMenuItem_Click
			Me.toolStripSeparator16.Name = "toolStripSeparator16"
			Me.toolStripSeparator16.Size = New Global.System.Drawing.Size(208, 6)
			Me.tRANSPARENTTEXTBOXToolStripMenuItem.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.toolStripSeparator5, Me.onToolStripMenuItem, Me.offToolStripMenuItem, Me.toolStripSeparator6 })
			Me.tRANSPARENTTEXTBOXToolStripMenuItem.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.tRANSPARENTTEXTBOXToolStripMenuItem.Name = "tRANSPARENTTEXTBOXToolStripMenuItem"
			Me.tRANSPARENTTEXTBOXToolStripMenuItem.Size = New Global.System.Drawing.Size(211, 22)
			Me.tRANSPARENTTEXTBOXToolStripMenuItem.Text = "REMOVE TEXT BOX"
			AddHandler Me.tRANSPARENTTEXTBOXToolStripMenuItem.Click, AddressOf Me.tRANSPARENTTEXTBOXToolStripMenuItem_Click
			Me.toolStripSeparator5.Name = "toolStripSeparator5"
			Me.toolStripSeparator5.Size = New Global.System.Drawing.Size(88, 6)
			Me.onToolStripMenuItem.Name = "onToolStripMenuItem"
			Me.onToolStripMenuItem.Size = New Global.System.Drawing.Size(91, 22)
			Me.onToolStripMenuItem.Text = "On"
			AddHandler Me.onToolStripMenuItem.Click, AddressOf Me.onToolStripMenuItem_Click
			Me.offToolStripMenuItem.Name = "offToolStripMenuItem"
			Me.offToolStripMenuItem.Size = New Global.System.Drawing.Size(91, 22)
			Me.offToolStripMenuItem.Text = "Off"
			AddHandler Me.offToolStripMenuItem.Click, AddressOf Me.offToolStripMenuItem_Click
			Me.toolStripSeparator6.Name = "toolStripSeparator6"
			Me.toolStripSeparator6.Size = New Global.System.Drawing.Size(88, 6)
			Me.toolStripSeparator10.Name = "toolStripSeparator10"
			Me.toolStripSeparator10.Size = New Global.System.Drawing.Size(208, 6)
			Me.trackBar1.Location = New Global.System.Drawing.Point(792, 276)
			Me.trackBar1.Name = "trackBar1"
			Me.trackBar1.Size = New Global.System.Drawing.Size(10, 45)
			Me.trackBar1.TabIndex = 1
			Me.trackBar1.Value = 7
			Me.trackBar2.Location = New Global.System.Drawing.Point(776, 276)
			Me.trackBar2.Name = "trackBar2"
			Me.trackBar2.Size = New Global.System.Drawing.Size(10, 45)
			Me.trackBar2.TabIndex = 30
			Me.trackBar2.Value = 10
			AddHandler Me.timer1.Tick, AddressOf Me.timer1_Tick_1
			Me.button13.BackColor = Global.System.Drawing.Color.FromArgb(60, 60, 60)
			Me.button13.Location = New Global.System.Drawing.Point(776, 191)
			Me.button13.Name = "button13"
			Me.button13.Size = New Global.System.Drawing.Size(10, 10)
			Me.button13.TabIndex = 31
			Me.button13.Text = "button13"
			Me.button13.UseVisualStyleBackColor = False
			Me.panel3.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.panel3.BackgroundImage = CType(componentResourceManager.GetObject("panel3.BackgroundImage"), Global.System.Drawing.Image)
			Me.panel3.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.panel3.Location = New Global.System.Drawing.Point(178, 328)
			Me.panel3.Name = "panel3"
			Me.panel3.Size = New Global.System.Drawing.Size(36, 34)
			Me.panel3.TabIndex = 2
			AddHandler Me.panel3.Click, AddressOf Me.panel3_Click
			AddHandler Me.panel3.Paint, AddressOf Me.panel3_Paint
			Me.panel4.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.panel4.BackgroundImage = CType(componentResourceManager.GetObject("panel4.BackgroundImage"), Global.System.Drawing.Image)
			Me.panel4.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.panel4.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.panel4.Location = New Global.System.Drawing.Point(111, 327)
			Me.panel4.Name = "panel4"
			Me.panel4.Size = New Global.System.Drawing.Size(36, 34)
			Me.panel4.TabIndex = 3
			AddHandler Me.panel4.Click, AddressOf Me.panel4_Click
			AddHandler Me.panel4.Paint, AddressOf Me.panel4_Paint
			Me.panel5.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.panel5.BackgroundImage = CType(componentResourceManager.GetObject("panel5.BackgroundImage"), Global.System.Drawing.Image)
			Me.panel5.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.panel5.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.panel5.Location = New Global.System.Drawing.Point(17, 190)
			Me.panel5.Name = "panel5"
			Me.panel5.Size = New Global.System.Drawing.Size(37, 36)
			Me.panel5.TabIndex = 4
			AddHandler Me.panel5.Click, AddressOf Me.panel5_Click
			Me.panel6.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.panel6.BackgroundImage = CType(componentResourceManager.GetObject("panel6.BackgroundImage"), Global.System.Drawing.Image)
			Me.panel6.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.panel6.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.panel6.Location = New Global.System.Drawing.Point(17, 258)
			Me.panel6.Name = "panel6"
			Me.panel6.Size = New Global.System.Drawing.Size(38, 38)
			Me.panel6.TabIndex = 5
			AddHandler Me.panel6.Click, AddressOf Me.panel6_Click
			Me.panel7.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.panel7.BackgroundImage = CType(componentResourceManager.GetObject("panel7.BackgroundImage"), Global.System.Drawing.Image)
			Me.panel7.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.panel7.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.panel7.Location = New Global.System.Drawing.Point(27, 323)
			Me.panel7.Name = "panel7"
			Me.panel7.Size = New Global.System.Drawing.Size(41, 42)
			Me.panel7.TabIndex = 6
			AddHandler Me.panel7.Click, AddressOf Me.panel7_Click
			AddHandler Me.panel7.Paint, AddressOf Me.panel7_Paint
			Me.panel8.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.panel8.BackgroundImage = CType(componentResourceManager.GetObject("panel8.BackgroundImage"), Global.System.Drawing.Image)
			Me.panel8.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.panel8.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.panel8.Location = New Global.System.Drawing.Point(16, 123)
			Me.panel8.Name = "panel8"
			Me.panel8.Size = New Global.System.Drawing.Size(39, 37)
			Me.panel8.TabIndex = 6
			AddHandler Me.panel8.Click, AddressOf Me.panel8_Click
			Me.panel9.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.panel9.BackgroundImage = CType(componentResourceManager.GetObject("panel9.BackgroundImage"), Global.System.Drawing.Image)
			Me.panel9.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.panel9.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.panel9.Location = New Global.System.Drawing.Point(16, 52)
			Me.panel9.Name = "panel9"
			Me.panel9.Size = New Global.System.Drawing.Size(40, 38)
			Me.panel9.TabIndex = 7
			AddHandler Me.panel9.Click, AddressOf Me.panel9_Click
			AddHandler Me.panel9.Paint, AddressOf Me.panel9_Paint
			AddHandler Me.panel9.Leave, AddressOf Me.panel9_Leave
			Me.pictureBox1.BackColor = Global.System.Drawing.Color.Transparent
			Me.pictureBox1.Location = New Global.System.Drawing.Point(-1, -1)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New Global.System.Drawing.Size(816, 389)
			Me.pictureBox1.TabIndex = 29
			Me.pictureBox1.TabStop = False
			AddHandler Me.pictureBox1.Click, AddressOf Me.pictureBox1_Click
			AddHandler Me.pictureBox1.DragDrop, AddressOf Me.pictureBox1_DragDrop
			AddHandler Me.pictureBox1.DragEnter, AddressOf Me.pictureBox1_DragEnter
			Me.panel10.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.panel10.BackgroundImage = CType(componentResourceManager.GetObject("panel10.BackgroundImage"), Global.System.Drawing.Image)
			Me.panel10.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Zoom
			Me.panel10.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.panel10.Location = New Global.System.Drawing.Point(243, 325)
			Me.panel10.Name = "panel10"
			Me.panel10.Size = New Global.System.Drawing.Size(41, 42)
			Me.panel10.TabIndex = 8
			AddHandler Me.panel10.Click, AddressOf Me.panel10_Click
			AddHandler Me.panel10.Paint, AddressOf Me.panel10_Paint
			Me.panel11.BackColor = Global.System.Drawing.Color.Transparent
			Me.panel11.BackgroundImage = CType(componentResourceManager.GetObject("panel11.BackgroundImage"), Global.System.Drawing.Image)
			Me.panel11.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Zoom
			Me.panel11.Location = New Global.System.Drawing.Point(275, 315)
			Me.panel11.Name = "panel11"
			Me.panel11.Size = New Global.System.Drawing.Size(65, 73)
			Me.panel11.TabIndex = 2
			Me.panel12.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.panel12.BackgroundImage = CType(componentResourceManager.GetObject("panel12.BackgroundImage"), Global.System.Drawing.Image)
			Me.panel12.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.panel12.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.panel12.Location = New Global.System.Drawing.Point(603, 325)
			Me.panel12.Name = "panel12"
			Me.panel12.Size = New Global.System.Drawing.Size(39, 37)
			Me.panel12.TabIndex = 9
			AddHandler Me.panel12.Click, AddressOf Me.panel12_Click
			AddHandler Me.panel12.Paint, AddressOf Me.panel12_Paint
			Me.panel13.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.panel13.BackgroundImage = CType(componentResourceManager.GetObject("panel13.BackgroundImage"), Global.System.Drawing.Image)
			Me.panel13.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.panel13.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.panel13.Location = New Global.System.Drawing.Point(480, 324)
			Me.panel13.Name = "panel13"
			Me.panel13.Size = New Global.System.Drawing.Size(41, 39)
			Me.panel13.TabIndex = 10
			AddHandler Me.panel13.Click, AddressOf Me.panel13_Click
			Me.panel14.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.panel14.BackgroundImage = CType(componentResourceManager.GetObject("panel14.BackgroundImage"), Global.System.Drawing.Image)
			Me.panel14.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.panel14.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.panel14.Location = New Global.System.Drawing.Point(354, 323)
			Me.panel14.Name = "panel14"
			Me.panel14.Size = New Global.System.Drawing.Size(47, 43)
			Me.panel14.TabIndex = 11
			AddHandler Me.panel14.Click, AddressOf Me.panel14_Click
			AddHandler Me.panel14.Paint, AddressOf Me.panel14_Paint
			Me.rButton3.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.rButton3.FlatAppearance.BorderSize = 0
			Me.rButton3.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.rButton3.ForeColor = Global.System.Drawing.Color.White
			Me.rButton3.Location = New Global.System.Drawing.Point(96, 320)
			Me.rButton3.Name = "rButton3"
			Me.rButton3.Size = New Global.System.Drawing.Size(62, 62)
			Me.rButton3.TabIndex = 42
			Me.rButton3.Text = "Clear"
			Me.rButton3.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.rButton3.UseVisualStyleBackColor = False
			AddHandler Me.rButton3.Click, AddressOf Me.rButton3_Click
			Me.rButton2.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.rButton2.FlatAppearance.BorderSize = 0
			Me.rButton2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.rButton2.ForeColor = Global.System.Drawing.Color.White
			Me.rButton2.Location = New Global.System.Drawing.Point(163, 320)
			Me.rButton2.Name = "rButton2"
			Me.rButton2.Size = New Global.System.Drawing.Size(64, 62)
			Me.rButton2.TabIndex = 41
			Me.rButton2.Text = "Execute"
			Me.rButton2.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.rButton2.UseVisualStyleBackColor = False
			AddHandler Me.rButton2.Click, AddressOf Me.rButton2_Click
			Me.rButton1.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.rButton1.FlatAppearance.BorderSize = 0
			Me.rButton1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.rButton1.ForeColor = Global.System.Drawing.Color.White
			Me.rButton1.Location = New Global.System.Drawing.Point(232, 320)
			Me.rButton1.Name = "rButton1"
			Me.rButton1.Size = New Global.System.Drawing.Size(64, 62)
			Me.rButton1.TabIndex = 0
			Me.rButton1.Text = "Attach"
			Me.rButton1.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.rButton1.UseVisualStyleBackColor = False
			AddHandler Me.rButton1.Click, AddressOf Me.rButton1_Click
			Me.rButton4.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.rButton4.FlatAppearance.BorderSize = 0
			Me.rButton4.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.rButton4.ForeColor = Global.System.Drawing.Color.White
			Me.rButton4.Location = New Global.System.Drawing.Point(5, 320)
			Me.rButton4.Name = "rButton4"
			Me.rButton4.Size = New Global.System.Drawing.Size(85, 62)
			Me.rButton4.TabIndex = 43
			Me.rButton4.Text = "Execute File"
			Me.rButton4.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.rButton4.UseVisualStyleBackColor = False
			AddHandler Me.rButton4.Click, AddressOf Me.rButton4_Click
			Me.rButton5.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.rButton5.FlatAppearance.BorderSize = 0
			Me.rButton5.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.rButton5.ForeColor = Global.System.Drawing.Color.White
			Me.rButton5.Location = New Global.System.Drawing.Point(5, 252)
			Me.rButton5.Name = "rButton5"
			Me.rButton5.Size = New Global.System.Drawing.Size(61, 62)
			Me.rButton5.TabIndex = 44
			Me.rButton5.Text = "Save File"
			Me.rButton5.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.rButton5.UseVisualStyleBackColor = False
			AddHandler Me.rButton5.Click, AddressOf Me.rButton5_Click
			Me.rButton6.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.rButton6.FlatAppearance.BorderSize = 0
			Me.rButton6.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.rButton6.ForeColor = Global.System.Drawing.Color.White
			Me.rButton6.Location = New Global.System.Drawing.Point(5, 184)
			Me.rButton6.Name = "rButton6"
			Me.rButton6.Size = New Global.System.Drawing.Size(61, 62)
			Me.rButton6.TabIndex = 45
			Me.rButton6.Text = "Open File"
			Me.rButton6.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.rButton6.UseVisualStyleBackColor = False
			AddHandler Me.rButton6.Click, AddressOf Me.rButton6_Click
			Me.rButton7.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.rButton7.FlatAppearance.BorderSize = 0
			Me.rButton7.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.rButton7.ForeColor = Global.System.Drawing.Color.White
			Me.rButton7.Location = New Global.System.Drawing.Point(5, 116)
			Me.rButton7.Name = "rButton7"
			Me.rButton7.Size = New Global.System.Drawing.Size(61, 62)
			Me.rButton7.TabIndex = 46
			Me.rButton7.Text = "Options"
			Me.rButton7.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.rButton7.UseVisualStyleBackColor = False
			AddHandler Me.rButton7.Click, AddressOf Me.rButton7_Click
			Me.button16.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.button16.FlatAppearance.BorderSize = 0
			Me.button16.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button16.ForeColor = Global.System.Drawing.Color.White
			Me.button16.Location = New Global.System.Drawing.Point(5, 47)
			Me.button16.Name = "button16"
			Me.button16.Size = New Global.System.Drawing.Size(61, 63)
			Me.button16.TabIndex = 47
			Me.button16.Text = "Themes"
			Me.button16.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.button16.UseVisualStyleBackColor = False
			AddHandler Me.button16.Click, AddressOf Me.rButton8_Click_1
			Me.rButton8.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.rButton8.FlatAppearance.BorderSize = 0
			Me.rButton8.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.rButton8.ForeColor = Global.System.Drawing.Color.White
			Me.rButton8.Location = New Global.System.Drawing.Point(319, 320)
			Me.rButton8.Name = "rButton8"
			Me.rButton8.Size = New Global.System.Drawing.Size(117, 62)
			Me.rButton8.TabIndex = 48
			Me.rButton8.Text = "Script Hub"
			Me.rButton8.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.rButton8.UseVisualStyleBackColor = False
			AddHandler Me.rButton8.Click, AddressOf Me.rButton8_Click_2
			Me.rButton9.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.rButton9.FlatAppearance.BorderSize = 0
			Me.rButton9.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.rButton9.ForeColor = Global.System.Drawing.Color.White
			Me.rButton9.Location = New Global.System.Drawing.Point(442, 320)
			Me.rButton9.Name = "rButton9"
			Me.rButton9.Size = New Global.System.Drawing.Size(116, 62)
			Me.rButton9.TabIndex = 49
			Me.rButton9.Text = "Script Manager"
			Me.rButton9.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.rButton9.UseVisualStyleBackColor = False
			AddHandler Me.rButton9.Click, AddressOf Me.rButton9_Click
			Me.rButton10.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.rButton10.FlatAppearance.BorderSize = 0
			Me.rButton10.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.rButton10.ForeColor = Global.System.Drawing.Color.White
			Me.rButton10.Location = New Global.System.Drawing.Point(564, 320)
			Me.rButton10.Name = "rButton10"
			Me.rButton10.Size = New Global.System.Drawing.Size(116, 62)
			Me.rButton10.TabIndex = 50
			Me.rButton10.Text = "Simple UI"
			Me.rButton10.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.rButton10.UseVisualStyleBackColor = False
			AddHandler Me.rButton10.Click, AddressOf Me.rButton10_Click
			Me.ATab.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.ATab.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.ATab.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.ATab.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.ATab.Location = New Global.System.Drawing.Point(686, 47)
			Me.ATab.Name = "ATab"
			Me.ATab.Size = New Global.System.Drawing.Size(116, 22)
			Me.ATab.TabIndex = 25
			Me.ATab.Text = "Add Tab"
			Me.ATab.UseVisualStyleBackColor = False
			AddHandler Me.ATab.Click, AddressOf Me.button12_Click
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			MyBase.ClientSize = New Global.System.Drawing.Size(816, 389)
			MyBase.Controls.Add(Me.panel12)
			MyBase.Controls.Add(Me.rButton10)
			MyBase.Controls.Add(Me.panel13)
			MyBase.Controls.Add(Me.rButton9)
			MyBase.Controls.Add(Me.panel14)
			MyBase.Controls.Add(Me.rButton8)
			MyBase.Controls.Add(Me.panel9)
			MyBase.Controls.Add(Me.button16)
			MyBase.Controls.Add(Me.panel8)
			MyBase.Controls.Add(Me.rButton7)
			MyBase.Controls.Add(Me.panel5)
			MyBase.Controls.Add(Me.rButton6)
			MyBase.Controls.Add(Me.panel6)
			MyBase.Controls.Add(Me.rButton5)
			MyBase.Controls.Add(Me.panel7)
			MyBase.Controls.Add(Me.rButton4)
			MyBase.Controls.Add(Me.panel4)
			MyBase.Controls.Add(Me.rButton3)
			MyBase.Controls.Add(Me.panel3)
			MyBase.Controls.Add(Me.rButton2)
			MyBase.Controls.Add(Me.panel10)
			MyBase.Controls.Add(Me.rButton1)
			MyBase.Controls.Add(Me.panel11)
			MyBase.Controls.Add(Me.RTab)
			MyBase.Controls.Add(Me.checkBox1)
			MyBase.Controls.Add(Me.ATab)
			MyBase.Controls.Add(Me.TabControl1)
			MyBase.Controls.Add(Me.listBox1)
			MyBase.Controls.Add(Me.panel1)
			MyBase.Controls.Add(Me.button12)
			MyBase.Controls.Add(Me.pictureBox1)
			MyBase.Controls.Add(Me.trackBar1)
			MyBase.Controls.Add(Me.trackBar2)
			MyBase.Controls.Add(Me.button13)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "VegaX"
			MyBase.Opacity = 0.0
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Vega X"
			AddHandler MyBase.FormClosing, AddressOf Me.VegaX_FormClosing
			AddHandler MyBase.Load, AddressOf Me.VegaX_Load
			AddHandler MyBase.Click, AddressOf Me.VegaX_Click
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			Me.contextMenuStrip1.ResumeLayout(False)
			CType(Me.trackBar1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trackBar2, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x04000241 RID: 577
		Private components As Global.System.ComponentModel.IContainer = Nothing

		' Token: 0x04000242 RID: 578
		Private panel1 As Global.System.Windows.Forms.Panel

		' Token: 0x04000243 RID: 579
		Private label1 As Global.System.Windows.Forms.Label

		' Token: 0x04000244 RID: 580
		Private panel2 As Global.System.Windows.Forms.Panel

		' Token: 0x04000245 RID: 581
		Private button1 As Global.System.Windows.Forms.Button

		' Token: 0x04000246 RID: 582
		Private button2 As Global.System.Windows.Forms.Button

		' Token: 0x04000247 RID: 583
		Private listBox1 As Global.System.Windows.Forms.ListBox

		' Token: 0x04000248 RID: 584
		Private TabControl1 As Global.System.Windows.Forms.TabControl

		' Token: 0x04000249 RID: 585
		Private RTab As Global.System.Windows.Forms.Button

		' Token: 0x0400024A RID: 586
		Private label2 As Global.System.Windows.Forms.Label

		' Token: 0x0400024B RID: 587
		Private button12 As Global.System.Windows.Forms.Button

		' Token: 0x0400024C RID: 588
		Private lightThemeToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		' Token: 0x0400024D RID: 589
		Private dEFAULTTHEMEToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		' Token: 0x0400024E RID: 590
		Private contextMenuStrip1 As Global.System.Windows.Forms.ContextMenuStrip

		' Token: 0x0400024F RID: 591
		Private toolStripSeparator11 As Global.System.Windows.Forms.ToolStripSeparator

		' Token: 0x04000250 RID: 592
		Private cUSTOMTHEMEToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		' Token: 0x04000251 RID: 593
		Private rEMOVECUSTOMTHEMEToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		' Token: 0x04000252 RID: 594
		Private checkBox1 As Global.System.Windows.Forms.CheckBox

		' Token: 0x04000253 RID: 595
		Private trackBar1 As Global.System.Windows.Forms.TrackBar

		' Token: 0x04000254 RID: 596
		Private trackBar2 As Global.System.Windows.Forms.TrackBar

		' Token: 0x04000255 RID: 597
		Private timer1 As Global.System.Windows.Forms.Timer

		' Token: 0x04000256 RID: 598
		Private toolStripSeparator14 As Global.System.Windows.Forms.ToolStripSeparator

		' Token: 0x04000257 RID: 599
		Private toolStripSeparator15 As Global.System.Windows.Forms.ToolStripSeparator

		' Token: 0x04000258 RID: 600
		Private toolStripSeparator16 As Global.System.Windows.Forms.ToolStripSeparator

		' Token: 0x04000259 RID: 601
		Private topBarPanelColorsToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		' Token: 0x0400025A RID: 602
		Private lightBlueToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		' Token: 0x0400025B RID: 603
		Private toolStripSeparator10 As Global.System.Windows.Forms.ToolStripSeparator

		' Token: 0x0400025C RID: 604
		Private deepRedToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		' Token: 0x0400025D RID: 605
		Private lightGreenToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		' Token: 0x0400025E RID: 606
		Private button13 As Global.System.Windows.Forms.Button

		' Token: 0x0400025F RID: 607
		Private toolStripSeparator17 As Global.System.Windows.Forms.ToolStripSeparator

		' Token: 0x04000260 RID: 608
		Private dimRedToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		' Token: 0x04000261 RID: 609
		Private brightPurpleToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		' Token: 0x04000262 RID: 610
		Private grayThemeToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		' Token: 0x04000263 RID: 611
		Private redToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		' Token: 0x04000264 RID: 612
		Private orangeToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		' Token: 0x04000265 RID: 613
		Private yellowToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		' Token: 0x04000266 RID: 614
		Private greenToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		' Token: 0x04000267 RID: 615
		Private blueToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		' Token: 0x04000268 RID: 616
		Private purpleToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		' Token: 0x04000269 RID: 617
		Private darkGreenToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		' Token: 0x0400026A RID: 618
		Private lightBlueToolStripMenuItem1 As Global.System.Windows.Forms.ToolStripMenuItem

		' Token: 0x0400026B RID: 619
		Private blackToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		' Token: 0x0400026C RID: 620
		Private pinkToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		' Token: 0x0400026D RID: 621
		Private tanToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		' Token: 0x0400026E RID: 622
		Private whiteToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		' Token: 0x0400026F RID: 623
		Private toolStripSeparator1 As Global.System.Windows.Forms.ToolStripSeparator

		' Token: 0x04000270 RID: 624
		Private tRANSPARENTTEXTBOXToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		' Token: 0x04000271 RID: 625
		Private toolStripSeparator2 As Global.System.Windows.Forms.ToolStripSeparator

		' Token: 0x04000272 RID: 626
		Private onToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		' Token: 0x04000273 RID: 627
		Private offToolStripMenuItem As Global.System.Windows.Forms.ToolStripMenuItem

		' Token: 0x04000274 RID: 628
		Private toolStripSeparator3 As Global.System.Windows.Forms.ToolStripSeparator

		' Token: 0x04000275 RID: 629
		Private toolStripSeparator4 As Global.System.Windows.Forms.ToolStripSeparator

		' Token: 0x04000276 RID: 630
		Private toolStripSeparator5 As Global.System.Windows.Forms.ToolStripSeparator

		' Token: 0x04000277 RID: 631
		Private toolStripSeparator6 As Global.System.Windows.Forms.ToolStripSeparator

		' Token: 0x04000278 RID: 632
		Private EasyExploitRadioButton As Global.System.Windows.Forms.RadioButton

		' Token: 0x04000279 RID: 633
		Private WrdRadioButton As Global.System.Windows.Forms.RadioButton

		' Token: 0x0400027A RID: 634
		Private toolStripMenuItem1 As Global.System.Windows.Forms.ToolStripMenuItem

		' Token: 0x0400027B RID: 635
		Private panel3 As Global.System.Windows.Forms.Panel

		' Token: 0x0400027C RID: 636
		Private panel4 As Global.System.Windows.Forms.Panel

		' Token: 0x0400027D RID: 637
		Private panel5 As Global.System.Windows.Forms.Panel

		' Token: 0x0400027E RID: 638
		Private panel6 As Global.System.Windows.Forms.Panel

		' Token: 0x0400027F RID: 639
		Private panel7 As Global.System.Windows.Forms.Panel

		' Token: 0x04000280 RID: 640
		Private panel8 As Global.System.Windows.Forms.Panel

		' Token: 0x04000281 RID: 641
		Private panel9 As Global.System.Windows.Forms.Panel

		' Token: 0x04000282 RID: 642
		Private pictureBox1 As Global.System.Windows.Forms.PictureBox

		' Token: 0x04000283 RID: 643
		Private panel10 As Global.System.Windows.Forms.Panel

		' Token: 0x04000284 RID: 644
		Private panel11 As Global.System.Windows.Forms.Panel

		' Token: 0x04000285 RID: 645
		Private panel12 As Global.System.Windows.Forms.Panel

		' Token: 0x04000286 RID: 646
		Private panel13 As Global.System.Windows.Forms.Panel

		' Token: 0x04000287 RID: 647
		Private button11 As Global.System.Windows.Forms.Button

		' Token: 0x04000288 RID: 648
		Private panel14 As Global.System.Windows.Forms.Panel

		' Token: 0x04000289 RID: 649
		Private rButton1 As Global.Vega_X.RButton

		' Token: 0x0400028A RID: 650
		Private rButton2 As Global.Vega_X.RButton

		' Token: 0x0400028B RID: 651
		Private rButton3 As Global.Vega_X.RButton

		' Token: 0x0400028C RID: 652
		Private rButton4 As Global.Vega_X.RButton

		' Token: 0x0400028D RID: 653
		Private rButton5 As Global.Vega_X.RButton

		' Token: 0x0400028E RID: 654
		Private rButton6 As Global.Vega_X.RButton

		' Token: 0x0400028F RID: 655
		Private rButton7 As Global.Vega_X.RButton

		' Token: 0x04000290 RID: 656
		Private button16 As Global.Vega_X.RButton

		' Token: 0x04000291 RID: 657
		Private rButton8 As Global.Vega_X.RButton

		' Token: 0x04000292 RID: 658
		Private rButton9 As Global.Vega_X.RButton

		' Token: 0x04000293 RID: 659
		Private rButton10 As Global.Vega_X.RButton

		' Token: 0x04000294 RID: 660
		Private ATab As Global.System.Windows.Forms.Button
	End Class
End Namespace
