Namespace Vega_X
	' Token: 0x02000005 RID: 5
	Public Partial Class Loader
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600002F RID: 47 RVA: 0x00002271 File Offset: 0x00000471
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000030 RID: 48 RVA: 0x0000479C File Offset: 0x0000299C
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.Vega_X.Loader))
			Me.progressBar1 = New Global.System.Windows.Forms.ProgressBar()
			Me.label2 = New Global.System.Windows.Forms.Label()
			Me.timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.label1 = New Global.System.Windows.Forms.Label()
			Me.panel2 = New Global.System.Windows.Forms.Panel()
			Me.label3 = New Global.System.Windows.Forms.Label()
			Me.button5 = New Global.System.Windows.Forms.Button()
			MyBase.SuspendLayout()
			Me.progressBar1.Location = New Global.System.Drawing.Point(26, 56)
			Me.progressBar1.Maximum = 1000
			Me.progressBar1.Name = "progressBar1"
			Me.progressBar1.Size = New Global.System.Drawing.Size(344, 23)
			Me.progressBar1.TabIndex = 4
			AddHandler Me.progressBar1.Click, AddressOf Me.progressBar1_Click
			Me.label2.AutoSize = True
			Me.label2.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.label2.ForeColor = Global.System.Drawing.Color.White
			Me.label2.Location = New Global.System.Drawing.Point(105, 94)
			Me.label2.Name = "label2"
			Me.label2.Size = New Global.System.Drawing.Size(133, 21)
			Me.label2.TabIndex = 5
			Me.label2.Text = "Loading APIs . . . "
			AddHandler Me.label2.Click, AddressOf Me.label2_Click
			AddHandler Me.timer1.Tick, AddressOf Me.timer1_Tick
			Me.label1.AutoSize = True
			Me.label1.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 15.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.label1.ForeColor = Global.System.Drawing.Color.White
			Me.label1.Location = New Global.System.Drawing.Point(114, 12)
			Me.label1.Name = "label1"
			Me.label1.Size = New Global.System.Drawing.Size(165, 30)
			Me.label1.TabIndex = 3
			Me.label1.Text = "Vega X - Loader"
			AddHandler Me.label1.Click, AddressOf Me.label1_Click
			Me.panel2.BackColor = Global.System.Drawing.Color.Transparent
			Me.panel2.BackgroundImage = CType(componentResourceManager.GetObject("panel2.BackgroundImage"), Global.System.Drawing.Image)
			Me.panel2.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Zoom
			Me.panel2.Location = New Global.System.Drawing.Point(3, 2)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New Global.System.Drawing.Size(48, 40)
			Me.panel2.TabIndex = 12
			Me.label3.AutoSize = True
			Me.label3.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.label3.ForeColor = Global.System.Drawing.Color.White
			Me.label3.Location = New Global.System.Drawing.Point(128, 93)
			Me.label3.Name = "label3"
			Me.label3.Size = New Global.System.Drawing.Size(97, 21)
			Me.label3.TabIndex = 13
			Me.label3.Text = "Opening . . ."
			Me.label3.Visible = False
			Me.button5.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.button5.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.button5.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button5.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.button5.Location = New Global.System.Drawing.Point(299, 95)
			Me.button5.Name = "button5"
			Me.button5.Size = New Global.System.Drawing.Size(86, 30)
			Me.button5.TabIndex = 14
			Me.button5.Text = "Skip Loading"
			Me.button5.UseVisualStyleBackColor = False
			AddHandler Me.button5.Click, AddressOf Me.button5_Click
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.FromArgb(60, 60, 60)
			MyBase.ClientSize = New Global.System.Drawing.Size(399, 138)
			MyBase.Controls.Add(Me.button5)
			MyBase.Controls.Add(Me.panel2)
			MyBase.Controls.Add(Me.label1)
			MyBase.Controls.Add(Me.label2)
			MyBase.Controls.Add(Me.progressBar1)
			MyBase.Controls.Add(Me.label3)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "Loader"
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Loader"
			AddHandler MyBase.Load, AddressOf Me.Loader_Load
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x0400002A RID: 42
		Private components As Global.System.ComponentModel.IContainer = Nothing

		' Token: 0x0400002B RID: 43
		Private progressBar1 As Global.System.Windows.Forms.ProgressBar

		' Token: 0x0400002C RID: 44
		Private label2 As Global.System.Windows.Forms.Label

		' Token: 0x0400002D RID: 45
		Private timer1 As Global.System.Windows.Forms.Timer

		' Token: 0x0400002E RID: 46
		Private label1 As Global.System.Windows.Forms.Label

		' Token: 0x0400002F RID: 47
		Private panel2 As Global.System.Windows.Forms.Panel

		' Token: 0x04000030 RID: 48
		Private label3 As Global.System.Windows.Forms.Label

		' Token: 0x04000031 RID: 49
		Private button5 As Global.System.Windows.Forms.Button
	End Class
End Namespace
