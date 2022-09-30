Namespace Vega_X
	' Token: 0x02000006 RID: 6
	Public Partial Class MiniGame
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000036 RID: 54 RVA: 0x0000229B File Offset: 0x0000049B
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000037 RID: 55 RVA: 0x00004E0C File Offset: 0x0000300C
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.Vega_X.MiniGame))
			Me.timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			MyBase.SuspendLayout()
			Me.timer1.Enabled = True
			Me.timer1.Interval = 10
			AddHandler Me.timer1.Tick, AddressOf Me.timer1_Tick
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.FromArgb(60, 60, 60)
			MyBase.ClientSize = New Global.System.Drawing.Size(800, 450)
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "MiniGame"
			Me.Text = "MiniGame (Re-Size Window To Move)"
			AddHandler MyBase.Load, AddressOf Me.MiniGame_Load
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x04000037 RID: 55
		Private components As Global.System.ComponentModel.IContainer = Nothing

		' Token: 0x04000038 RID: 56
		Private timer1 As Global.System.Windows.Forms.Timer
	End Class
End Namespace
