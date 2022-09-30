Namespace Vega_X
	' Token: 0x02000003 RID: 3
	Public Partial Class FlappyVega
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000023 RID: 35 RVA: 0x000021E3 File Offset: 0x000003E3
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000024 RID: 36 RVA: 0x00003BF8 File Offset: 0x00001DF8
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.Vega_X.FlappyVega))
			Me.panel1 = New Global.System.Windows.Forms.Panel()
			Me.panel2 = New Global.System.Windows.Forms.Panel()
			Me.label1 = New Global.System.Windows.Forms.Label()
			Me.ground = New Global.System.Windows.Forms.PictureBox()
			Me.pipedown = New Global.System.Windows.Forms.PictureBox()
			Me.bird = New Global.System.Windows.Forms.PictureBox()
			Me.pipeup = New Global.System.Windows.Forms.PictureBox()
			Me.Score = New Global.System.Windows.Forms.Label()
			Me.gametimer = New Global.System.Windows.Forms.Timer(Me.components)
			Me.label2 = New Global.System.Windows.Forms.Label()
			Me.label3 = New Global.System.Windows.Forms.Label()
			Me.label4 = New Global.System.Windows.Forms.Label()
			Me.label5 = New Global.System.Windows.Forms.Label()
			Me.label6 = New Global.System.Windows.Forms.Label()
			Me.label7 = New Global.System.Windows.Forms.Label()
			Me.panel1.SuspendLayout()
			CType(Me.ground, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pipedown, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bird, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pipeup, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.panel1.BackColor = Global.System.Drawing.Color.FromArgb(60, 60, 60)
			Me.panel1.Controls.Add(Me.panel2)
			Me.panel1.Controls.Add(Me.label1)
			Me.panel1.Location = New Global.System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New Global.System.Drawing.Size(800, 40)
			Me.panel1.TabIndex = 1
			AddHandler Me.panel1.MouseDown, AddressOf Me.panel1_MouseDown
			AddHandler Me.panel1.MouseMove, AddressOf Me.panel1_MouseMove
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
			Me.label1.Location = New Global.System.Drawing.Point(324, 9)
			Me.label1.Name = "label1"
			Me.label1.Size = New Global.System.Drawing.Size(162, 21)
			Me.label1.TabIndex = 3
			Me.label1.Text = "Vega X - Flappy Vega"
			Me.ground.Image = CType(componentResourceManager.GetObject("ground.Image"), Global.System.Drawing.Image)
			Me.ground.Location = New Global.System.Drawing.Point(-1, 404)
			Me.ground.Name = "ground"
			Me.ground.Size = New Global.System.Drawing.Size(800, 144)
			Me.ground.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.CenterImage
			Me.ground.TabIndex = 2
			Me.ground.TabStop = False
			Me.pipedown.Image = CType(componentResourceManager.GetObject("pipedown.Image"), Global.System.Drawing.Image)
			Me.pipedown.Location = New Global.System.Drawing.Point(564, 281)
			Me.pipedown.Name = "pipedown"
			Me.pipedown.Size = New Global.System.Drawing.Size(99, 123)
			Me.pipedown.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.Zoom
			Me.pipedown.TabIndex = 3
			Me.pipedown.TabStop = False
			Me.bird.Image = CType(componentResourceManager.GetObject("bird.Image"), Global.System.Drawing.Image)
			Me.bird.Location = New Global.System.Drawing.Point(96, 178)
			Me.bird.Name = "bird"
			Me.bird.Size = New Global.System.Drawing.Size(49, 50)
			Me.bird.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.Zoom
			Me.bird.TabIndex = 4
			Me.bird.TabStop = False
			Me.pipeup.Image = CType(componentResourceManager.GetObject("pipeup.Image"), Global.System.Drawing.Image)
			Me.pipeup.Location = New Global.System.Drawing.Point(630, 40)
			Me.pipeup.Name = "pipeup"
			Me.pipeup.Size = New Global.System.Drawing.Size(91, 118)
			Me.pipeup.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.Zoom
			Me.pipeup.TabIndex = 5
			Me.pipeup.TabStop = False
			Me.Score.AutoSize = True
			Me.Score.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Score.ForeColor = Global.System.Drawing.SystemColors.Window
			Me.Score.Location = New Global.System.Drawing.Point(12, 418)
			Me.Score.Name = "Score"
			Me.Score.Size = New Global.System.Drawing.Size(0, 21)
			Me.Score.TabIndex = 15
			Me.gametimer.Interval = 20
			AddHandler Me.gametimer.Tick, AddressOf Me.GameTimerEvent
			Me.label2.AutoSize = True
			Me.label2.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 18F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.label2.ForeColor = Global.System.Drawing.SystemColors.Window
			Me.label2.Location = New Global.System.Drawing.Point(12, 55)
			Me.label2.Name = "label2"
			Me.label2.Size = New Global.System.Drawing.Size(208, 32)
			Me.label2.TabIndex = 11
			Me.label2.Text = "Press 'E' To START"
			AddHandler Me.label2.Click, AddressOf Me.label2_Click
			Me.label3.AutoSize = True
			Me.label3.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.label3.ForeColor = Global.System.Drawing.SystemColors.Window
			Me.label3.Location = New Global.System.Drawing.Point(11, 348)
			Me.label3.Name = "label3"
			Me.label3.Size = New Global.System.Drawing.Size(196, 21)
			Me.label3.TabIndex = 16
			Me.label3.Text = "Press 'Q' For HARD Mode"
			Me.label4.AutoSize = True
			Me.label4.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.label4.ForeColor = Global.System.Drawing.SystemColors.Window
			Me.label4.Location = New Global.System.Drawing.Point(11, 372)
			Me.label4.Name = "label4"
			Me.label4.Size = New Global.System.Drawing.Size(217, 21)
			Me.label4.TabIndex = 17
			Me.label4.Text = "Press 'Z' For EXTREME Mode"
			Me.label5.AutoSize = True
			Me.label5.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.label5.ForeColor = Global.System.Drawing.SystemColors.Window
			Me.label5.Location = New Global.System.Drawing.Point(11, 324)
			Me.label5.Name = "label5"
			Me.label5.Size = New Global.System.Drawing.Size(188, 21)
			Me.label5.TabIndex = 18
			Me.label5.Text = "Press 'A' For EASY Mode"
			AddHandler Me.label5.Click, AddressOf Me.label5_Click
			Me.label6.AutoSize = True
			Me.label6.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.label6.ForeColor = Global.System.Drawing.Color.Red
			Me.label6.Location = New Global.System.Drawing.Point(110, 226)
			Me.label6.Name = "label6"
			Me.label6.Size = New Global.System.Drawing.Size(203, 21)
			Me.label6.TabIndex = 19
			Me.label6.Text = "Tip: Press 'Space' To Jump!"
			Me.label7.AutoSize = True
			Me.label7.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 18F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.label7.ForeColor = Global.System.Drawing.SystemColors.Window
			Me.label7.Location = New Global.System.Drawing.Point(241, 363)
			Me.label7.Name = "label7"
			Me.label7.Size = New Global.System.Drawing.Size(317, 32)
			Me.label7.TabIndex = 20
			Me.label7.Text = "Press 'F' To Close The Game"
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.FromArgb(50, 50, 50)
			MyBase.ClientSize = New Global.System.Drawing.Size(800, 450)
			MyBase.Controls.Add(Me.label7)
			MyBase.Controls.Add(Me.label6)
			MyBase.Controls.Add(Me.label5)
			MyBase.Controls.Add(Me.label4)
			MyBase.Controls.Add(Me.label3)
			MyBase.Controls.Add(Me.label2)
			MyBase.Controls.Add(Me.Score)
			MyBase.Controls.Add(Me.pipeup)
			MyBase.Controls.Add(Me.bird)
			MyBase.Controls.Add(Me.pipedown)
			MyBase.Controls.Add(Me.ground)
			MyBase.Controls.Add(Me.panel1)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Name = "FlappyVega"
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Flappy Vega Minigame"
			AddHandler MyBase.Load, AddressOf Me.FlappyVega_Load
			AddHandler MyBase.KeyDown, AddressOf Me.gamekeydown
			AddHandler MyBase.KeyUp, AddressOf Me.gamekeyup
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			CType(Me.ground, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pipedown, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bird, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pipeup, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x04000018 RID: 24
		Private components As Global.System.ComponentModel.IContainer = Nothing

		' Token: 0x04000019 RID: 25
		Private panel1 As Global.System.Windows.Forms.Panel

		' Token: 0x0400001A RID: 26
		Private panel2 As Global.System.Windows.Forms.Panel

		' Token: 0x0400001B RID: 27
		Private label1 As Global.System.Windows.Forms.Label

		' Token: 0x0400001C RID: 28
		Private ground As Global.System.Windows.Forms.PictureBox

		' Token: 0x0400001D RID: 29
		Private pipedown As Global.System.Windows.Forms.PictureBox

		' Token: 0x0400001E RID: 30
		Private bird As Global.System.Windows.Forms.PictureBox

		' Token: 0x0400001F RID: 31
		Private pipeup As Global.System.Windows.Forms.PictureBox

		' Token: 0x04000020 RID: 32
		Private Score As Global.System.Windows.Forms.Label

		' Token: 0x04000021 RID: 33
		Private gametimer As Global.System.Windows.Forms.Timer

		' Token: 0x04000022 RID: 34
		Private label2 As Global.System.Windows.Forms.Label

		' Token: 0x04000023 RID: 35
		Private label3 As Global.System.Windows.Forms.Label

		' Token: 0x04000024 RID: 36
		Private label4 As Global.System.Windows.Forms.Label

		' Token: 0x04000025 RID: 37
		Private label5 As Global.System.Windows.Forms.Label

		' Token: 0x04000026 RID: 38
		Private label6 As Global.System.Windows.Forms.Label

		' Token: 0x04000027 RID: 39
		Private label7 As Global.System.Windows.Forms.Label
	End Class
End Namespace
