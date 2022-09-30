Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Net
Imports System.Windows.Forms
Imports WeAreDevs_API

Namespace Vega_X
	' Token: 0x0200000B RID: 11
	Public Partial Class ScriptHub3
		Inherits Form

		' Token: 0x06000171 RID: 369 RVA: 0x000024C5 File Offset: 0x000006C5
		Public Sub New()
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000172 RID: 370 RVA: 0x0000208E File Offset: 0x0000028E
		Private Sub button2_Click(sender As Object, e As EventArgs)
			MyBase.WindowState = FormWindowState.Minimized
		End Sub

		' Token: 0x06000173 RID: 371 RVA: 0x00002097 File Offset: 0x00000297
		Private Sub ScriptHub3_Load(sender As Object, e As EventArgs)
			MyBase.TopMost = True
		End Sub

		' Token: 0x06000174 RID: 372 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub label1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000175 RID: 373 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub button15_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000176 RID: 374 RVA: 0x00002086 File Offset: 0x00000286
		Private Sub button9_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06000177 RID: 375 RVA: 0x000024E5 File Offset: 0x000006E5
		Private Sub panel1_MouseDown(sender As Object, e As MouseEventArgs)
			Me.lastPoint = New Point(e.X, e.Y)
		End Sub

		' Token: 0x06000178 RID: 376 RVA: 0x00019660 File Offset: 0x00017860
		Private Sub panel1_MouseMove(sender As Object, e As MouseEventArgs)
			If e.Button = MouseButtons.Left Then
				MyBase.Left += e.X - Me.lastPoint.X
				MyBase.Top += e.Y - Me.lastPoint.Y
			End If
		End Sub

		' Token: 0x06000179 RID: 377 RVA: 0x00019660 File Offset: 0x00017860
		Private Sub label1_MouseMove(sender As Object, e As MouseEventArgs)
			If e.Button = MouseButtons.Left Then
				MyBase.Left += e.X - Me.lastPoint.X
				MyBase.Top += e.Y - Me.lastPoint.Y
			End If
		End Sub

		' Token: 0x0600017A RID: 378 RVA: 0x000024E5 File Offset: 0x000006E5
		Private Sub label1_MouseDown(sender As Object, e As MouseEventArgs)
			Me.lastPoint = New Point(e.X, e.Y)
		End Sub

		' Token: 0x0600017B RID: 379 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub panel1_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		' Token: 0x0600017C RID: 380 RVA: 0x000081D4 File Offset: 0x000063D4
		Private Sub button7_Click(sender As Object, e As EventArgs)
			MyBase.Hide()
			Dim scriptHub As ScriptHub2 = New ScriptHub2()
			scriptHub.Show()
		End Sub

		' Token: 0x0600017D RID: 381 RVA: 0x00011478 File Offset: 0x0000F678
		Private Sub button6_Click(sender As Object, e As EventArgs)
			MyBase.Hide()
			Dim scriptHub As ScriptHub = New ScriptHub()
			scriptHub.Show()
		End Sub

		' Token: 0x0600017E RID: 382 RVA: 0x000196BC File Offset: 0x000178BC
		Private Sub button93_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/7Dvxr2WN")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x0600017F RID: 383 RVA: 0x000196E8 File Offset: 0x000178E8
		Private Sub button92_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/50Fx94Mf")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x06000180 RID: 384 RVA: 0x00019714 File Offset: 0x00017914
		Private Sub button13_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/HxiEuLU0")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x06000181 RID: 385 RVA: 0x00019740 File Offset: 0x00017940
		Private Sub button91_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/Ki9MdWhp")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x06000182 RID: 386 RVA: 0x0001976C File Offset: 0x0001796C
		Private Sub button5_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/jv68vmUE")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x06000183 RID: 387 RVA: 0x00019798 File Offset: 0x00017998
		Private Sub button4_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/WzykCZ3f")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x06000184 RID: 388 RVA: 0x000197C4 File Offset: 0x000179C4
		Private Sub button21_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/BJR0qrVt")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x06000185 RID: 389 RVA: 0x000197F0 File Offset: 0x000179F0
		Private Sub button20_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/nXjKtdvk")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x06000186 RID: 390 RVA: 0x0001981C File Offset: 0x00017A1C
		Private Sub button19_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://raw.githubusercontent.com/BunnySalf/Hentai/main/MHEEHUB")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x06000187 RID: 391 RVA: 0x00019848 File Offset: 0x00017A48
		Private Sub button18_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/BGu7tyrg")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x06000188 RID: 392 RVA: 0x00019874 File Offset: 0x00017A74
		Private Sub button12_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x06000189 RID: 393 RVA: 0x000198A0 File Offset: 0x00017AA0
		Private Sub button8_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/y2mXFhC0")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x0600018A RID: 394 RVA: 0x000198CC File Offset: 0x00017ACC
		Private Sub button11_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/g9g9H95T")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x0600018B RID: 395 RVA: 0x000198F8 File Offset: 0x00017AF8
		Private Sub button3_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/xd4p5qQN")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x0600018C RID: 396 RVA: 0x00019924 File Offset: 0x00017B24
		Private Sub button14_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/KmjuMx3m")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x0600018D RID: 397 RVA: 0x00019950 File Offset: 0x00017B50
		Private Sub button1_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/e4KvBszD")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x0600018E RID: 398 RVA: 0x0001997C File Offset: 0x00017B7C
		Private Sub button10_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://paste.ee/r/I20HH/0")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x0600018F RID: 399 RVA: 0x000199A8 File Offset: 0x00017BA8
		Private Sub button28_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/YpEXtdJy")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x06000190 RID: 400 RVA: 0x000199D4 File Offset: 0x00017BD4
		Private Sub button29_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/KpaR8t5M")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x06000191 RID: 401 RVA: 0x00019A00 File Offset: 0x00017C00
		Private Sub button25_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/U29siiLB")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x06000192 RID: 402 RVA: 0x00019A2C File Offset: 0x00017C2C
		Private Sub button24_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/mpZiCUsi")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x06000193 RID: 403 RVA: 0x00019A58 File Offset: 0x00017C58
		Private Sub button23_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/jDCpKDyV")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x06000194 RID: 404 RVA: 0x00019A84 File Offset: 0x00017C84
		Private Sub button27_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/Mq4FTHB1")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x06000195 RID: 405 RVA: 0x00019AB0 File Offset: 0x00017CB0
		Private Sub button22_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/LH2hH9Ru")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x06000196 RID: 406 RVA: 0x00019ADC File Offset: 0x00017CDC
		Private Sub button16_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/ArgFS8v5")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x06000197 RID: 407 RVA: 0x00019B08 File Offset: 0x00017D08
		Private Sub button15_Click_1(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/ygwcfXck")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x06000198 RID: 408 RVA: 0x00019B34 File Offset: 0x00017D34
		Private Sub button26_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/t6Wg9jkL")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x06000199 RID: 409 RVA: 0x00019B60 File Offset: 0x00017D60
		Private Sub button31_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://paste.ee/r/qbfoU/0")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x0600019A RID: 410 RVA: 0x00019B8C File Offset: 0x00017D8C
		Private Sub button32_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/3zUavF4g")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x0600019B RID: 411 RVA: 0x00019BB8 File Offset: 0x00017DB8
		Private Sub button33_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/6YQ8YmB4")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x0600019C RID: 412 RVA: 0x00019BE4 File Offset: 0x00017DE4
		Private Sub button30_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/JTR8eQQE")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x0600019D RID: 413 RVA: 0x00019C10 File Offset: 0x00017E10
		Private Sub button44_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/F2kjkhip")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x0600019E RID: 414 RVA: 0x00019C3C File Offset: 0x00017E3C
		Private Sub button45_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/7xVaeDvQ")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x0600019F RID: 415 RVA: 0x00019C68 File Offset: 0x00017E68
		Private Sub button46_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/8gyLj9mx")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001A0 RID: 416 RVA: 0x00019C94 File Offset: 0x00017E94
		Private Sub button43_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/VECiYAqd")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001A1 RID: 417 RVA: 0x00019CC0 File Offset: 0x00017EC0
		Private Sub button41_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/uzjXFG6u")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001A2 RID: 418 RVA: 0x00019CEC File Offset: 0x00017EEC
		Private Sub button40_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/GsnRLKgE")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001A3 RID: 419 RVA: 0x00019D18 File Offset: 0x00017F18
		Private Sub button39_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/efukZQnW")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001A4 RID: 420 RVA: 0x00019D44 File Offset: 0x00017F44
		Private Sub button38_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/SatDWeF6")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001A5 RID: 421 RVA: 0x00019D70 File Offset: 0x00017F70
		Private Sub button37_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/4dJtXW7T")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001A6 RID: 422 RVA: 0x00019D9C File Offset: 0x00017F9C
		Private Sub button36_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/YNkWWyAu")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001A7 RID: 423 RVA: 0x00019DC8 File Offset: 0x00017FC8
		Private Sub button35_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/y2yFfXw3")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001A8 RID: 424 RVA: 0x00019DF4 File Offset: 0x00017FF4
		Private Sub button34_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/yxv9CbfX")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001A9 RID: 425 RVA: 0x00019E20 File Offset: 0x00018020
		Private Sub button42_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/LVRZBuES")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001AA RID: 426 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub panel3_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		' Token: 0x060001AB RID: 427 RVA: 0x00019E4C File Offset: 0x0001804C
		Private Sub button49_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/W9WFjykQ")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001AC RID: 428 RVA: 0x00019E78 File Offset: 0x00018078
		Private Sub button51_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/QzaGGr3B")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001AD RID: 429 RVA: 0x00019EA4 File Offset: 0x000180A4
		Private Sub button48_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/S7g4vVH6")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001AE RID: 430 RVA: 0x00019ED0 File Offset: 0x000180D0
		Private Sub button47_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/cD8eWK4K")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001AF RID: 431 RVA: 0x00004F04 File Offset: 0x00003104
		Private Sub button50_Click(sender As Object, e As EventArgs)
			Dim processes As Process() = Process.GetProcesses()
			For Each process As Process In processes
				If process.ProcessName = "RobloxPlayerBeta" Then
					process.Kill()
				End If
			Next
		End Sub

		' Token: 0x060001B0 RID: 432 RVA: 0x00019EFC File Offset: 0x000180FC
		Private Sub button54_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/5CKaXQGP")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001B1 RID: 433 RVA: 0x00019EFC File Offset: 0x000180FC
		Private Sub button55_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/5CKaXQGP")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001B2 RID: 434 RVA: 0x00019EFC File Offset: 0x000180FC
		Private Sub button56_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/5CKaXQGP")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001B3 RID: 435 RVA: 0x00019EFC File Offset: 0x000180FC
		Private Sub button53_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/5CKaXQGP")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001B4 RID: 436 RVA: 0x00019EFC File Offset: 0x000180FC
		Private Sub button52_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/5CKaXQGP")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001B5 RID: 437 RVA: 0x00019F28 File Offset: 0x00018128
		Private Sub button67_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/hPxNj094")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001B6 RID: 438 RVA: 0x00019F54 File Offset: 0x00018154
		Private Sub button66_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001B7 RID: 439 RVA: 0x00019F80 File Offset: 0x00018180
		Private Sub button65_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/Tg7VZkDm")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001B8 RID: 440 RVA: 0x00019F54 File Offset: 0x00018154
		Private Sub button62_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001B9 RID: 441 RVA: 0x00019F54 File Offset: 0x00018154
		Private Sub button61_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001BA RID: 442 RVA: 0x00019F54 File Offset: 0x00018154
		Private Sub button60_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001BB RID: 443 RVA: 0x00019F54 File Offset: 0x00018154
		Private Sub button59_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001BC RID: 444 RVA: 0x00019F54 File Offset: 0x00018154
		Private Sub button58_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001BD RID: 445 RVA: 0x00019F54 File Offset: 0x00018154
		Private Sub button57_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001BE RID: 446 RVA: 0x00019EFC File Offset: 0x000180FC
		Private Sub button63_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/5CKaXQGP")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001BF RID: 447 RVA: 0x00019EFC File Offset: 0x000180FC
		Private Sub button64_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/5CKaXQGP")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001C0 RID: 448 RVA: 0x00019FAC File Offset: 0x000181AC
		Private Sub button71_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/ZAjeQsqV")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001C1 RID: 449 RVA: 0x00019F54 File Offset: 0x00018154
		Private Sub button73_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001C2 RID: 450 RVA: 0x00019F54 File Offset: 0x00018154
		Private Sub button70_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001C3 RID: 451 RVA: 0x00019F54 File Offset: 0x00018154
		Private Sub button69_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001C4 RID: 452 RVA: 0x00019F54 File Offset: 0x00018154
		Private Sub button68_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001C5 RID: 453 RVA: 0x00019FD8 File Offset: 0x000181D8
		Private Sub button72_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/gAZFz1jN")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001C6 RID: 454 RVA: 0x00019FD8 File Offset: 0x000181D8
		Private Sub button77_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/gAZFz1jN")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001C7 RID: 455 RVA: 0x00019FD8 File Offset: 0x000181D8
		Private Sub button79_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/gAZFz1jN")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001C8 RID: 456 RVA: 0x00019FD8 File Offset: 0x000181D8
		Private Sub button76_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/gAZFz1jN")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001C9 RID: 457 RVA: 0x00019FD8 File Offset: 0x000181D8
		Private Sub button75_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/gAZFz1jN")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001CA RID: 458 RVA: 0x00019FD8 File Offset: 0x000181D8
		Private Sub button74_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/gAZFz1jN")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001CB RID: 459 RVA: 0x00019FD8 File Offset: 0x000181D8
		Private Sub button83_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/gAZFz1jN")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001CC RID: 460 RVA: 0x00019FD8 File Offset: 0x000181D8
		Private Sub button85_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/gAZFz1jN")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001CD RID: 461 RVA: 0x00019FD8 File Offset: 0x000181D8
		Private Sub button82_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/gAZFz1jN")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001CE RID: 462 RVA: 0x0001A004 File Offset: 0x00018204
		Private Sub button81_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/itwzEm75")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001CF RID: 463 RVA: 0x00019FD8 File Offset: 0x000181D8
		Private Sub button80_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/gAZFz1jN")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001D0 RID: 464 RVA: 0x0001A030 File Offset: 0x00018230
		Private Sub button78_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/GCPUsDzh")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001D1 RID: 465 RVA: 0x0001A05C File Offset: 0x0001825C
		Private Sub button84_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/vY3eMhzX")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001D2 RID: 466 RVA: 0x0001A088 File Offset: 0x00018288
		Private Sub button89_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/mHHWDbbz")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001D3 RID: 467 RVA: 0x0001A0B4 File Offset: 0x000182B4
		Private Sub button90_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/VjVT44dh")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001D4 RID: 468 RVA: 0x0001A0E0 File Offset: 0x000182E0
		Private Sub button94_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/tz1249Fr")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001D5 RID: 469 RVA: 0x0001A0E0 File Offset: 0x000182E0
		Private Sub button88_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/tz1249Fr")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001D6 RID: 470 RVA: 0x0001A0E0 File Offset: 0x000182E0
		Private Sub button87_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/tz1249Fr")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001D7 RID: 471 RVA: 0x0001A0E0 File Offset: 0x000182E0
		Private Sub button86_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/tz1249Fr")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001D8 RID: 472 RVA: 0x0001A10C File Offset: 0x0001830C
		Private Sub button98_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/ycrDXnRU")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001D9 RID: 473 RVA: 0x0001A138 File Offset: 0x00018338
		Private Sub button100_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/WgnTh2Js")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001DA RID: 474 RVA: 0x0001A164 File Offset: 0x00018364
		Private Sub button99_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/LRJjFxZE")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001DB RID: 475 RVA: 0x0001A190 File Offset: 0x00018390
		Private Sub button97_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/n4HbYaBg")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001DC RID: 476 RVA: 0x0001A1BC File Offset: 0x000183BC
		Private Sub button96_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/0QWEisXk")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001DD RID: 477 RVA: 0x00019AB0 File Offset: 0x00017CB0
		Private Sub button95_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/LH2hH9Ru")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001DE RID: 478 RVA: 0x0001A1E8 File Offset: 0x000183E8
		Private Sub button114_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/RCYV2fTq")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001DF RID: 479 RVA: 0x0001A214 File Offset: 0x00018414
		Private Sub button115_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/BSAWq4B7")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001E0 RID: 480 RVA: 0x0001A240 File Offset: 0x00018440
		Private Sub button116_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/RECwMzDZ")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001E1 RID: 481 RVA: 0x0001A26C File Offset: 0x0001846C
		Private Sub button113_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/sQa24JwK")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001E2 RID: 482 RVA: 0x0001A298 File Offset: 0x00018498
		Private Sub button112_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/NuJkRZU8")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001E3 RID: 483 RVA: 0x0001A2C4 File Offset: 0x000184C4
		Private Sub button111_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/L75chtXt")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001E4 RID: 484 RVA: 0x0001A2F0 File Offset: 0x000184F0
		Private Sub button110_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://raw.githubusercontent.com/Historia00012/HISTORIAHUB/main/BSS%20FREE")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001E5 RID: 485 RVA: 0x0001A31C File Offset: 0x0001851C
		Private Sub button109_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/hhXLbMSj")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001E6 RID: 486 RVA: 0x0001A348 File Offset: 0x00018548
		Private Sub button108_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/M1ycsJvj")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001E7 RID: 487 RVA: 0x0001A374 File Offset: 0x00018574
		Private Sub button107_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/Jbwm8cHr")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001E8 RID: 488 RVA: 0x0001A3A0 File Offset: 0x000185A0
		Private Sub button106_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/2B87nBmn")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001E9 RID: 489 RVA: 0x0001A3CC File Offset: 0x000185CC
		Private Sub button105_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/k5TJREte")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001EA RID: 490 RVA: 0x0001A3F8 File Offset: 0x000185F8
		Private Sub button104_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/i7eC3vXy")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001EB RID: 491 RVA: 0x0001A424 File Offset: 0x00018624
		Private Sub button103_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/5cPi1vG2")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x060001EC RID: 492 RVA: 0x0001A450 File Offset: 0x00018650
		Private Sub button102_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim script As String = webClient.DownloadString("https://pastebin.com/raw/5uJMZRGn")
			Me.api.SendLuaScript(script)
		End Sub

		' Token: 0x0400018B RID: 395
		Private api As ExploitAPI = New ExploitAPI()

		' Token: 0x0400018C RID: 396
		Private lastPoint As Point
	End Class
End Namespace
