Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Linq
Imports System.Net
Imports System.Windows.Forms
Imports EasyExploits
Imports WeAreDevs_API

Namespace Vega_X
	' Token: 0x02000007 RID: 7
	Public Partial Class Options
		Inherits Form

		' Token: 0x06000038 RID: 56 RVA: 0x000022BD File Offset: 0x000004BD
		Public Sub New()
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000039 RID: 57 RVA: 0x00004F04 File Offset: 0x00003104
		Private Sub button1_Click(sender As Object, e As EventArgs)
			Dim processes As Process() = Process.GetProcesses()
			For Each process As Process In processes
				If process.ProcessName = "RobloxPlayerBeta" Then
					process.Kill()
				End If
			Next
		End Sub

		' Token: 0x0600003A RID: 58 RVA: 0x00002097 File Offset: 0x00000297
		Private Sub button7_Click(sender As Object, e As EventArgs)
			MyBase.TopMost = True
		End Sub

		' Token: 0x0600003B RID: 59 RVA: 0x000022E8 File Offset: 0x000004E8
		Private Sub button3_Click(sender As Object, e As EventArgs)
			MyBase.TopMost = False
		End Sub

		' Token: 0x0600003C RID: 60 RVA: 0x00004F44 File Offset: 0x00003144
		Private Sub button4_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://the-shed.dev/scripts/sbp.lua")
			Me.[module].ExecuteScript(script)
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600003D RID: 61 RVA: 0x00004F7C File Offset: 0x0000317C
		Private Sub panel1_MouseMove(sender As Object, e As MouseEventArgs)
			If e.Button = MouseButtons.Left Then
				MyBase.Left += e.X - Me.lastPoint.X
				MyBase.Top += e.Y - Me.lastPoint.Y
			End If
		End Sub

		' Token: 0x0600003E RID: 62 RVA: 0x000022F1 File Offset: 0x000004F1
		Private Sub panel1_MouseDown(sender As Object, e As MouseEventArgs)
			Me.lastPoint = New Point(e.X, e.Y)
		End Sub

		' Token: 0x0600003F RID: 63 RVA: 0x000022F1 File Offset: 0x000004F1
		Private Sub label1_MouseDown(sender As Object, e As MouseEventArgs)
			Me.lastPoint = New Point(e.X, e.Y)
		End Sub

		' Token: 0x06000040 RID: 64 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub panel1_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		' Token: 0x06000041 RID: 65 RVA: 0x00004F7C File Offset: 0x0000317C
		Private Sub label1_MouseMove(sender As Object, e As MouseEventArgs)
			If e.Button = MouseButtons.Left Then
				MyBase.Left += e.X - Me.lastPoint.X
				MyBase.Top += e.Y - Me.lastPoint.Y
			End If
		End Sub

		' Token: 0x06000042 RID: 66 RVA: 0x00004FD8 File Offset: 0x000031D8
		Private Sub button2_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/sVxD31v1")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000043 RID: 67 RVA: 0x00002097 File Offset: 0x00000297
		Private Sub Options_Load(sender As Object, e As EventArgs)
			MyBase.TopMost = True
		End Sub

		' Token: 0x06000044 RID: 68 RVA: 0x00004FD8 File Offset: 0x000031D8
		Private Sub checkBox2_CheckedChanged(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/sVxD31v1")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000045 RID: 69 RVA: 0x00005004 File Offset: 0x00003204
		Private Sub checkBox1_CheckedChanged(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/pQF6rXMm")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000046 RID: 70 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub label1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000047 RID: 71 RVA: 0x00005030 File Offset: 0x00003230
		Private Sub button5_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/SiqScdtW")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000048 RID: 72 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub button8_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000049 RID: 73 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub button11_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600004A RID: 74 RVA: 0x0000230A File Offset: 0x0000050A
		Private Sub button8_Click_1(sender As Object, e As EventArgs)
			Process.Start("https://1f02.net/")
		End Sub

		' Token: 0x0600004B RID: 75 RVA: 0x00002317 File Offset: 0x00000517
		Private Sub button9_Click(sender As Object, e As EventArgs)
			Process.Start("https://glot.io/snippets/f1tt9okm5w")
		End Sub

		' Token: 0x0600004C RID: 76 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub button10_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600004D RID: 77 RVA: 0x0000208E File Offset: 0x0000028E
		Private Sub button10_Click_1(sender As Object, e As EventArgs)
			MyBase.WindowState = FormWindowState.Minimized
		End Sub

		' Token: 0x0600004E RID: 78 RVA: 0x0000505C File Offset: 0x0000325C
		Private Sub button11_Click_1(sender As Object, e As EventArgs)
			Dim simpleUI As SimpleUI = New SimpleUI()
			simpleUI.Show()
		End Sub

		' Token: 0x0600004F RID: 79 RVA: 0x00005078 File Offset: 0x00003278
		Private Sub button12_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/D4dWs2Vc")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000050 RID: 80 RVA: 0x000050A4 File Offset: 0x000032A4
		Private Sub checkBox3_CheckedChanged(sender As Object, e As EventArgs)
			Dim vegaX As VegaX = Application.OpenForms.OfType().FirstOrDefault()
			If vegaX IsNot Nothing Then
				vegaX.TopMost = Me.checkBox3.Checked
				MyBase.TopMost = False
			End If
		End Sub

		' Token: 0x06000051 RID: 81 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub button3_Click_1(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000052 RID: 82 RVA: 0x00002324 File Offset: 0x00000524
		Private Sub button7_Click_1(sender As Object, e As EventArgs)
			Process.Start("https://www.youtube.com/channel/UCPnCsR8_hY_z7tceY5-0KSA?sub_confirmation=1")
		End Sub

		' Token: 0x06000053 RID: 83 RVA: 0x000050E0 File Offset: 0x000032E0
		Private Sub button3_Click_2(sender As Object, e As EventArgs)
			Dim miniGame As MiniGame = New MiniGame()
			miniGame.Show()
		End Sub

		' Token: 0x06000054 RID: 84 RVA: 0x00002331 File Offset: 0x00000531
		Private Sub button13_Click(sender As Object, e As EventArgs)
			Process.Start("https://pastebin.com/raw/cFWfNhmW")
		End Sub

		' Token: 0x06000055 RID: 85 RVA: 0x00002086 File Offset: 0x00000286
		Private Sub button7_Click_2(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06000056 RID: 86 RVA: 0x0000233E File Offset: 0x0000053E
		Private Sub button14_Click(sender As Object, e As EventArgs)
			MessageBox.Show("Kill Roblox: Closes Roblox | Attach Method 2: A Faster Attaching Method | Boost FPS: Limits Graphics | Bypass AC: Bypasses *SOME* Anti-Cheats | TopMost: Puts Vega On Top Of Other Programs | Anti-AFK: Prevents Getting Kicked For Inactivity")
		End Sub

		' Token: 0x06000057 RID: 87 RVA: 0x0000234B File Offset: 0x0000054B
		Private Sub button16_Click(sender As Object, e As EventArgs)
			Process.Start("https://linktr.ee/1f0")
		End Sub

		' Token: 0x06000058 RID: 88 RVA: 0x00002358 File Offset: 0x00000558
		Private Sub button15_Click(sender As Object, e As EventArgs)
			MessageBox.Show("1_F0", "Vega X | Credits", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
		End Sub

		' Token: 0x06000059 RID: 89 RVA: 0x00002086 File Offset: 0x00000286
		Private Sub button7_Click_3(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x0600005A RID: 90 RVA: 0x0000234B File Offset: 0x0000054B
		Private Sub button17_Click(sender As Object, e As EventArgs)
			Process.Start("https://linktr.ee/1f0")
		End Sub

		' Token: 0x0600005B RID: 91 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub richTextBox1_TextChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600005C RID: 92 RVA: 0x000050FC File Offset: 0x000032FC
		Private Sub button6_Click(sender As Object, e As EventArgs)
			Dim flappyVega As FlappyVega = New FlappyVega()
			flappyVega.Show()
		End Sub

		' Token: 0x0600005D RID: 93 RVA: 0x00005118 File Offset: 0x00003318
		Private Sub button18_Click(sender As Object, e As EventArgs)
			Dim adjustableScripts As AdjustableScripts = New AdjustableScripts()
			adjustableScripts.Show()
		End Sub

		' Token: 0x0600005E RID: 94 RVA: 0x0000236D File Offset: 0x0000056D
		Private Sub button19_Click(sender As Object, e As EventArgs)
			MessageBox.Show("Everything Seems To Be Working Fine.", "Vega X | Status", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
		End Sub

		' Token: 0x0600005F RID: 95 RVA: 0x00002382 File Offset: 0x00000582
		Private Sub button20_Click(sender As Object, e As EventArgs)
			Me.[module].ExecuteScript(Me.richTextBox2.Text)
		End Sub

		' Token: 0x06000060 RID: 96 RVA: 0x0000239A File Offset: 0x0000059A
		Private Sub button21_Click(sender As Object, e As EventArgs)
			Me.richTextBox2.Clear()
		End Sub

		' Token: 0x04000039 RID: 57
		Private api As ExploitAPI = New ExploitAPI()

		' Token: 0x0400003A RID: 58
		Private [module] As [Module] = New [Module]()

		' Token: 0x0400003B RID: 59
		Private lastPoint As Point
	End Class
End Namespace
