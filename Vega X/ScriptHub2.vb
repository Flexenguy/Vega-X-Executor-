Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Net
Imports System.Windows.Forms
Imports EasyExploits
Imports WeAreDevs_API

Namespace Vega_X
	' Token: 0x0200000A RID: 10
	Public Partial Class ScriptHub2
		Inherits Form

		' Token: 0x060000FB RID: 251 RVA: 0x0000245F File Offset: 0x0000065F
		Public Sub New()
			Me.InitializeComponent()
		End Sub

		' Token: 0x060000FC RID: 252 RVA: 0x00002086 File Offset: 0x00000286
		Private Sub button1_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x060000FD RID: 253 RVA: 0x0000208E File Offset: 0x0000028E
		Private Sub button2_Click(sender As Object, e As EventArgs)
			MyBase.WindowState = FormWindowState.Minimized
		End Sub

		' Token: 0x060000FE RID: 254 RVA: 0x00011478 File Offset: 0x0000F678
		Private Sub button3_Click(sender As Object, e As EventArgs)
			MyBase.Hide()
			Dim scriptHub As ScriptHub = New ScriptHub()
			scriptHub.Show()
		End Sub

		' Token: 0x060000FF RID: 255 RVA: 0x00002097 File Offset: 0x00000297
		Private Sub ScriptHub2_Load(sender As Object, e As EventArgs)
			MyBase.TopMost = True
		End Sub

		' Token: 0x06000100 RID: 256 RVA: 0x0000248A File Offset: 0x0000068A
		Private Sub label1_MouseDown(sender As Object, e As MouseEventArgs)
			Me.lastPoint = New Point(e.X, e.Y)
		End Sub

		' Token: 0x06000101 RID: 257 RVA: 0x0000248A File Offset: 0x0000068A
		Private Sub panel1_MouseDown(sender As Object, e As MouseEventArgs)
			Me.lastPoint = New Point(e.X, e.Y)
		End Sub

		' Token: 0x06000102 RID: 258 RVA: 0x00011498 File Offset: 0x0000F698
		Private Sub label1_MouseMove(sender As Object, e As MouseEventArgs)
			If e.Button = MouseButtons.Left Then
				MyBase.Left += e.X - Me.lastPoint.X
				MyBase.Top += e.Y - Me.lastPoint.Y
			End If
		End Sub

		' Token: 0x06000103 RID: 259 RVA: 0x00011498 File Offset: 0x0000F698
		Private Sub panel1_MouseMove(sender As Object, e As MouseEventArgs)
			If e.Button = MouseButtons.Left Then
				MyBase.Left += e.X - Me.lastPoint.X
				MyBase.Top += e.Y - Me.lastPoint.Y
			End If
		End Sub

		' Token: 0x06000104 RID: 260 RVA: 0x000114F4 File Offset: 0x0000F6F4
		Private Sub button93_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/MtRWaGAt")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000105 RID: 261 RVA: 0x00011520 File Offset: 0x0000F720
		Private Sub button92_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/kAZ6wZRk")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000106 RID: 262 RVA: 0x0001154C File Offset: 0x0000F74C
		Private Sub button91_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/brZVArpB")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000107 RID: 263 RVA: 0x0001154C File Offset: 0x0000F74C
		Private Sub button90_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/brZVArpB")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000108 RID: 264 RVA: 0x00011578 File Offset: 0x0000F778
		Private Sub button89_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/F6sdeFzi")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000109 RID: 265 RVA: 0x000115A4 File Offset: 0x0000F7A4
		Private Sub button21_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/DFQt4x4y")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600010A RID: 266 RVA: 0x000115D0 File Offset: 0x0000F7D0
		Private Sub button88_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/8qjwJzWp")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600010B RID: 267 RVA: 0x000115D0 File Offset: 0x0000F7D0
		Private Sub button5_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/8qjwJzWp")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600010C RID: 268 RVA: 0x000115FC File Offset: 0x0000F7FC
		Private Sub button6_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/7BK0zSnP")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600010D RID: 269 RVA: 0x00011628 File Offset: 0x0000F828
		Private Sub button20_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/pDEp2TEL")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600010E RID: 270 RVA: 0x00011654 File Offset: 0x0000F854
		Private Sub button19_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/U1G4bpxT")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600010F RID: 271 RVA: 0x00011680 File Offset: 0x0000F880
		Private Sub button18_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/HyEm5Mnn")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000110 RID: 272 RVA: 0x000116AC File Offset: 0x0000F8AC
		Private Sub button17_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/gvexZC6A")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000111 RID: 273 RVA: 0x000116D8 File Offset: 0x0000F8D8
		Private Sub button16_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/n03ZWbX5")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000112 RID: 274 RVA: 0x00011704 File Offset: 0x0000F904
		Private Sub button15_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/GP3q41DC")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000113 RID: 275 RVA: 0x00011730 File Offset: 0x0000F930
		Private Sub button14_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/Stk8iRpX")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000114 RID: 276 RVA: 0x0001175C File Offset: 0x0000F95C
		Private Sub button13_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/ZMYqBJCG")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000115 RID: 277 RVA: 0x00011788 File Offset: 0x0000F988
		Private Sub button12_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/i4tXbjBY")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000116 RID: 278 RVA: 0x000117B4 File Offset: 0x0000F9B4
		Private Sub button11_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/fZr4TT6T")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000117 RID: 279 RVA: 0x000117E0 File Offset: 0x0000F9E0
		Private Sub button10_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/vWi4ZKYE")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000118 RID: 280 RVA: 0x0001180C File Offset: 0x0000FA0C
		Private Sub button9_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/WEwW1hrY")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000119 RID: 281 RVA: 0x00011838 File Offset: 0x0000FA38
		Private Sub button8_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/9PiGSf6R")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600011A RID: 282 RVA: 0x00011864 File Offset: 0x0000FA64
		Private Sub button7_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/npkadTm8")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600011B RID: 283 RVA: 0x00011890 File Offset: 0x0000FA90
		Private Sub button4_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/JG1ALHEt")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600011C RID: 284 RVA: 0x000118BC File Offset: 0x0000FABC
		Private Sub button29_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/PqQhVM3k")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600011D RID: 285 RVA: 0x000118E8 File Offset: 0x0000FAE8
		Private Sub button27_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/ayX664qv")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600011E RID: 286 RVA: 0x00011914 File Offset: 0x0000FB14
		Private Sub button28_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/Nqbb0554")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600011F RID: 287 RVA: 0x00011940 File Offset: 0x0000FB40
		Private Sub button26_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/gNHTqHhZ")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000120 RID: 288 RVA: 0x0001196C File Offset: 0x0000FB6C
		Private Sub button25_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/qPALUQ2w")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000121 RID: 289 RVA: 0x00011998 File Offset: 0x0000FB98
		Private Sub button24_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/GVpBbqWv")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000122 RID: 290 RVA: 0x000119C4 File Offset: 0x0000FBC4
		Private Sub button23_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/kz1Et0kG")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000123 RID: 291 RVA: 0x000119F0 File Offset: 0x0000FBF0
		Private Sub button22_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/NVgGkU6g")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000124 RID: 292 RVA: 0x00011A1C File Offset: 0x0000FC1C
		Private Sub button30_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/sLSCRGsC")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000125 RID: 293 RVA: 0x00011A48 File Offset: 0x0000FC48
		Private Sub button34_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/XQm9RC08")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000126 RID: 294 RVA: 0x00011A74 File Offset: 0x0000FC74
		Private Sub button33_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/SXBwqVdQ")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000127 RID: 295 RVA: 0x00011AA0 File Offset: 0x0000FCA0
		Private Sub button31_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/AFhCw3P8")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000128 RID: 296 RVA: 0x00011ACC File Offset: 0x0000FCCC
		Private Sub button36_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/uiW0hpJV")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000129 RID: 297 RVA: 0x00011AF8 File Offset: 0x0000FCF8
		Private Sub button32_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/ksLM4ERj")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600012A RID: 298 RVA: 0x00011B24 File Offset: 0x0000FD24
		Private Sub button37_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/WPzz3GxQ")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600012B RID: 299 RVA: 0x00011B50 File Offset: 0x0000FD50
		Private Sub button35_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/tdYyGdrg")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600012C RID: 300 RVA: 0x00011B7C File Offset: 0x0000FD7C
		Private Sub button47_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/Y8JdGB17")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600012D RID: 301 RVA: 0x00011BA8 File Offset: 0x0000FDA8
		Private Sub button46_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/9qBVcPHq")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600012E RID: 302 RVA: 0x00011BD4 File Offset: 0x0000FDD4
		Private Sub button45_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/C4h2PAjW")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600012F RID: 303 RVA: 0x00011C00 File Offset: 0x0000FE00
		Private Sub button44_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/AQAGVVDx")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000130 RID: 304 RVA: 0x00011C2C File Offset: 0x0000FE2C
		Private Sub button43_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/CdDw1CUw")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000131 RID: 305 RVA: 0x00011C58 File Offset: 0x0000FE58
		Private Sub button42_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/WrjYDpjZ")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000132 RID: 306 RVA: 0x00011C84 File Offset: 0x0000FE84
		Private Sub button41_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/QWTKEEku")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000133 RID: 307 RVA: 0x00011CB0 File Offset: 0x0000FEB0
		Private Sub button40_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/anCLbYyx")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000134 RID: 308 RVA: 0x00011CDC File Offset: 0x0000FEDC
		Private Sub button39_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/0SRVMJ3g")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000135 RID: 309 RVA: 0x00011D08 File Offset: 0x0000FF08
		Private Sub button38_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/dU2RRizn")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000136 RID: 310 RVA: 0x00011D34 File Offset: 0x0000FF34
		Private Sub button50_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/uLta4zKD")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000137 RID: 311 RVA: 0x00011D60 File Offset: 0x0000FF60
		Private Sub button52_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/tPBrwqxe")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000138 RID: 312 RVA: 0x00011D8C File Offset: 0x0000FF8C
		Private Sub button51_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/gD2y9QpQ")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000139 RID: 313 RVA: 0x00011DB8 File Offset: 0x0000FFB8
		Private Sub button48_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/0sLTRnTL")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600013A RID: 314 RVA: 0x00011DE4 File Offset: 0x0000FFE4
		Private Sub button49_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/GESqdXMh")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600013B RID: 315 RVA: 0x00011E10 File Offset: 0x00010010
		Private Sub button54_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/mmSYPxWr")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600013C RID: 316 RVA: 0x00011E3C File Offset: 0x0001003C
		Private Sub button56_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/KL7PdncT")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600013D RID: 317 RVA: 0x00011E68 File Offset: 0x00010068
		Private Sub button55_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/L5Qzsryu")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600013E RID: 318 RVA: 0x00011E94 File Offset: 0x00010094
		Private Sub button57_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/YhgCX53P")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600013F RID: 319 RVA: 0x00011EC0 File Offset: 0x000100C0
		Private Sub button53_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/N8rQAX02")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000140 RID: 320 RVA: 0x00011EEC File Offset: 0x000100EC
		Private Sub button59_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/38t0NCJN")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000141 RID: 321 RVA: 0x00011F18 File Offset: 0x00010118
		Private Sub button61_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/rzSky5V2")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000142 RID: 322 RVA: 0x00011F44 File Offset: 0x00010144
		Private Sub button60_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/AmLiehYY")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000143 RID: 323 RVA: 0x00011F70 File Offset: 0x00010170
		Private Sub button62_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://paste.ee/r/e6dHL/0")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000144 RID: 324 RVA: 0x00011F9C File Offset: 0x0001019C
		Private Sub button58_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/ahBKsjJ2")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000145 RID: 325 RVA: 0x00011FC8 File Offset: 0x000101C8
		Private Sub button75_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/83JJ7ASG")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000146 RID: 326 RVA: 0x00011FF4 File Offset: 0x000101F4
		Private Sub button74_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/20hs02bX")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000147 RID: 327 RVA: 0x00012020 File Offset: 0x00010220
		Private Sub button73_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/giKPsJPd")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000148 RID: 328 RVA: 0x0001204C File Offset: 0x0001024C
		Private Sub button72_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/YTgufSPE")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000149 RID: 329 RVA: 0x00012078 File Offset: 0x00010278
		Private Sub button71_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/a5Syx1q2")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600014A RID: 330 RVA: 0x000120A4 File Offset: 0x000102A4
		Private Sub button70_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/Bcr0U8yH")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600014B RID: 331 RVA: 0x000120D0 File Offset: 0x000102D0
		Private Sub button69_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/SPfAgY7h")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600014C RID: 332 RVA: 0x000120FC File Offset: 0x000102FC
		Private Sub button68_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/1PhkfZiF")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600014D RID: 333 RVA: 0x00012128 File Offset: 0x00010328
		Private Sub button67_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/kmqeWYRq")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600014E RID: 334 RVA: 0x00012154 File Offset: 0x00010354
		Private Sub button66_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/HEdyUsUM")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600014F RID: 335 RVA: 0x00012180 File Offset: 0x00010380
		Private Sub button65_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/Xijw6r4Z")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000150 RID: 336 RVA: 0x000121AC File Offset: 0x000103AC
		Private Sub button64_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/L2yCYCUE")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000151 RID: 337 RVA: 0x000121D8 File Offset: 0x000103D8
		Private Sub button63_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/W95B2fD9")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000152 RID: 338 RVA: 0x00012204 File Offset: 0x00010404
		Private Sub button78_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/zhfD8AiR")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000153 RID: 339 RVA: 0x00012230 File Offset: 0x00010430
		Private Sub button79_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/DKDJZ2RQ")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000154 RID: 340 RVA: 0x0001225C File Offset: 0x0001045C
		Private Sub button81_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/XWcqDVNG")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000155 RID: 341 RVA: 0x00012288 File Offset: 0x00010488
		Private Sub button80_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/kFL5QhXE")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000156 RID: 342 RVA: 0x000122B4 File Offset: 0x000104B4
		Private Sub button77_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/a3HpVbJE")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000157 RID: 343 RVA: 0x000122E0 File Offset: 0x000104E0
		Private Sub button76_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/azi9xfYQ")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000158 RID: 344 RVA: 0x0001230C File Offset: 0x0001050C
		Private Sub button85_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/PXJnmTeg")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000159 RID: 345 RVA: 0x00012338 File Offset: 0x00010538
		Private Sub button86_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/WbUsjpG8")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600015A RID: 346 RVA: 0x00012364 File Offset: 0x00010564
		Private Sub button87_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/B7ZecPEr")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600015B RID: 347 RVA: 0x00012390 File Offset: 0x00010590
		Private Sub button83_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/ZHmzeFwN")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600015C RID: 348 RVA: 0x000123BC File Offset: 0x000105BC
		Private Sub button84_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/ZJ95tBHE")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600015D RID: 349 RVA: 0x000123E8 File Offset: 0x000105E8
		Private Sub button82_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/NVf0Rja2")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600015E RID: 350 RVA: 0x00002086 File Offset: 0x00000286
		Private Sub button1_Click_1(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x0600015F RID: 351 RVA: 0x000081F4 File Offset: 0x000063F4
		Private Sub button94_Click(sender As Object, e As EventArgs)
			MyBase.Hide()
			Dim scriptHub As ScriptHub3 = New ScriptHub3()
			scriptHub.Show()
		End Sub

		' Token: 0x06000160 RID: 352 RVA: 0x00012414 File Offset: 0x00010614
		Private Sub button109_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/LvWwQiDk")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000161 RID: 353 RVA: 0x00012440 File Offset: 0x00010640
		Private Sub button108_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/mvNegXuS")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000162 RID: 354 RVA: 0x0001246C File Offset: 0x0001066C
		Private Sub button107_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/ZxeknPzV")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000163 RID: 355 RVA: 0x00012498 File Offset: 0x00010698
		Private Sub button106_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/w99VdFL6")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000164 RID: 356 RVA: 0x000124C4 File Offset: 0x000106C4
		Private Sub button105_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/QAW7c3pK")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000165 RID: 357 RVA: 0x000124F0 File Offset: 0x000106F0
		Private Sub button104_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/Pek7fnEA")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000166 RID: 358 RVA: 0x0001251C File Offset: 0x0001071C
		Private Sub button103_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/WEkw8Jmg")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000167 RID: 359 RVA: 0x00012548 File Offset: 0x00010748
		Private Sub button101_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/VZfMP9mk")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000168 RID: 360 RVA: 0x00012574 File Offset: 0x00010774
		Private Sub button100_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/ZSCyKavt")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000169 RID: 361 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub label9_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600016A RID: 362 RVA: 0x000125A0 File Offset: 0x000107A0
		Private Sub button99_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/iYmwv9bN")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600016B RID: 363 RVA: 0x000125CC File Offset: 0x000107CC
		Private Sub button98_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/fn4YYRZn")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600016C RID: 364 RVA: 0x000125F8 File Offset: 0x000107F8
		Private Sub button97_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/0QQiQmdi")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600016D RID: 365 RVA: 0x00012624 File Offset: 0x00010824
		Private Sub button96_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/bAev2Ri8")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600016E RID: 366 RVA: 0x00012650 File Offset: 0x00010850
		Private Sub button95_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/R3fHyyyy")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0400010A RID: 266
		Private api As ExploitAPI = New ExploitAPI()

		' Token: 0x0400010B RID: 267
		Private [module] As [Module] = New [Module]()

		' Token: 0x0400010C RID: 268
		Private lastPoint As Point
	End Class
End Namespace
