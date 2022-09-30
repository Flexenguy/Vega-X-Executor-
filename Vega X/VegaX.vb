Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Windows.Forms
Imports EasyExploits
Imports FastColoredTextBoxNS
Imports WeAreDevs_API

Namespace Vega_X
	' Token: 0x0200000F RID: 15
	Public Partial Class VegaX
		Inherits Form

		' Token: 0x06000217 RID: 535 RVA: 0x0000269F File Offset: 0x0000089F
		Public Sub New()
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000218 RID: 536 RVA: 0x00023F5C File Offset: 0x0002215C
		Private Sub panel1_MouseMove(sender As Object, e As MouseEventArgs)
			If e.Button = MouseButtons.Left Then
				MyBase.Left += e.X - Me.lastPoint.X
				MyBase.Top += e.Y - Me.lastPoint.Y
			End If
		End Sub

		' Token: 0x06000219 RID: 537 RVA: 0x000026CA File Offset: 0x000008CA
		Private Sub panel1_MouseDown(sender As Object, e As MouseEventArgs)
			Me.lastPoint = New Point(e.X, e.Y)
		End Sub

		' Token: 0x0600021A RID: 538 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub panel2_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		' Token: 0x0600021B RID: 539 RVA: 0x00023FB8 File Offset: 0x000221B8
		Private Sub button1_Click(sender As Object, e As EventArgs)
			Dim dialogResult As DialogResult = MessageBox.Show("Do You Really Want To Close Vega X?", "Vega X | Execution", MessageBoxButtons.YesNo)
			If dialogResult = DialogResult.Yes Then
				Application.[Exit]()
			ElseIf dialogResult <> DialogResult.No Then
			End If
		End Sub

		' Token: 0x0600021C RID: 540 RVA: 0x000026E3 File Offset: 0x000008E3
		Private Sub panel2_Click(sender As Object, e As EventArgs)
			MessageBox.Show("Made By 1_F0", "Credits", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
		End Sub

		' Token: 0x0600021D RID: 541 RVA: 0x000026CA File Offset: 0x000008CA
		Private Sub label1_MouseDown(sender As Object, e As MouseEventArgs)
			Me.lastPoint = New Point(e.X, e.Y)
		End Sub

		' Token: 0x0600021E RID: 542 RVA: 0x00023F5C File Offset: 0x0002215C
		Private Sub label1_MouseMove(sender As Object, e As MouseEventArgs)
			If e.Button = MouseButtons.Left Then
				MyBase.Left += e.X - Me.lastPoint.X
				MyBase.Top += e.Y - Me.lastPoint.Y
			End If
		End Sub

		' Token: 0x0600021F RID: 543 RVA: 0x0000208E File Offset: 0x0000028E
		Private Sub button2_Click(sender As Object, e As EventArgs)
			MyBase.WindowState = FormWindowState.Minimized
		End Sub

		' Token: 0x06000220 RID: 544 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub label1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000221 RID: 545 RVA: 0x00023FEC File Offset: 0x000221EC
		Private Sub button6_Click(sender As Object, e As EventArgs)
			Dim fastColoredTextBox As FastColoredTextBox = TryCast(Me.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", True).FirstOrDefault(), FastColoredTextBox)
			Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
			If saveFileDialog.ShowDialog() = DialogResult.OK Then
				Using stream As Stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew)
					Using streamWriter As StreamWriter = New StreamWriter(stream)
						streamWriter.Write(fastColoredTextBox.Text)
					End Using
				End Using
			End If
		End Sub

		' Token: 0x06000222 RID: 546 RVA: 0x00024084 File Offset: 0x00022284
		Private Sub button8_Click(sender As Object, e As EventArgs)
			Dim fastColoredTextBox As FastColoredTextBox = TryCast(Me.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", True).FirstOrDefault(), FastColoredTextBox)
			fastColoredTextBox.Text = ""
		End Sub

		' Token: 0x06000223 RID: 547 RVA: 0x000240C4 File Offset: 0x000222C4
		Private Sub button7_Click(sender As Object, e As EventArgs)
			Dim fastColoredTextBox As FastColoredTextBox = TryCast(Me.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", True).FirstOrDefault(), FastColoredTextBox)
			Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
			If openFileDialog.ShowDialog() = DialogResult.OK Then
				openFileDialog.Title = "Open"
				fastColoredTextBox.Text = File.ReadAllText(openFileDialog.FileName)
			End If
		End Sub

		' Token: 0x06000224 RID: 548 RVA: 0x00024124 File Offset: 0x00022324
		Private Sub button5_Click(sender As Object, e As EventArgs)
			Dim options As Options = New Options()
			options.Show()
		End Sub

		' Token: 0x06000225 RID: 549 RVA: 0x00024140 File Offset: 0x00022340
		Private Sub VegaX_Load(sender As Object, e As EventArgs)
			Me.timer1.Start()
			Dim text As String = "Scriptbox " + (Me.TabControl1.TabCount + 1).ToString()
			Dim userControl As UserControl1 = New UserControl1()
			userControl.Dock = DockStyle.Fill
			Dim tabPage As TabPage = New TabPage(text)
			tabPage.Controls.Add(userControl)
			Me.TabControl1.TabPages.Add(tabPage)
			MyBase.TopMost = True
			Me.listBox1.Items.Clear()
			Functions.PopulateListBox(Me.listBox1, "./Scripts", "*.txt")
			Functions.PopulateListBox(Me.listBox1, "./Scripts", "*.lua")
			Me.pictureBox1.AllowDrop = True
			Me.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
			Me.EasyExploitRadioButton.Checked = True
		End Sub

		' Token: 0x06000226 RID: 550 RVA: 0x00024210 File Offset: 0x00022410
		Private Sub button9_Click(sender As Object, e As EventArgs)
			Dim scriptManager As ScriptManager = New ScriptManager()
			scriptManager.Show()
		End Sub

		' Token: 0x06000227 RID: 551 RVA: 0x0002422C File Offset: 0x0002242C
		Private Sub listBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
			Dim fastColoredTextBox As FastColoredTextBox = TryCast(Me.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", True).FirstOrDefault(), FastColoredTextBox)
			fastColoredTextBox.Text = File.ReadAllText(String.Format("./Scripts/{0}", Me.listBox1.SelectedItem))
		End Sub

		' Token: 0x06000228 RID: 552 RVA: 0x00024280 File Offset: 0x00022480
		Private Sub button3_Click(sender As Object, e As EventArgs)
			If Me.WrdRadioButton.Checked Then
				Dim fastColoredTextBox As FastColoredTextBox = TryCast(Me.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", True).FirstOrDefault(), FastColoredTextBox)
				Me.api.SendLuaScript(fastColoredTextBox.Text)
			ElseIf Me.EasyExploitRadioButton.Checked Then
				Dim fastColoredTextBox2 As FastColoredTextBox = TryCast(Me.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", True).FirstOrDefault(), FastColoredTextBox)
				Me.[module].ExecuteScript(fastColoredTextBox2.Text)
			End If
		End Sub

		' Token: 0x06000229 RID: 553 RVA: 0x000026F8 File Offset: 0x000008F8
		Private Sub button11_Click(sender As Object, e As EventArgs)
			Me.api.LaunchExploit()
		End Sub

		' Token: 0x0600022A RID: 554 RVA: 0x00023048 File Offset: 0x00021248
		Private Sub button4_Click(sender As Object, e As EventArgs)
			Dim scriptHub As ScriptHub = New ScriptHub()
			scriptHub.Show()
		End Sub

		' Token: 0x0600022B RID: 555 RVA: 0x00024318 File Offset: 0x00022518
		Private Sub button12_Click(sender As Object, e As EventArgs)
			Dim text As String = "Scriptbox" + (Me.TabControl1.TabCount + 1).ToString()
			Dim userControl As UserControl1 = New UserControl1()
			userControl.Dock = DockStyle.Fill
			Dim tabPage As TabPage = New TabPage(text)
			tabPage.Controls.Add(userControl)
			Me.TabControl1.TabPages.Add(tabPage)
		End Sub

		' Token: 0x0600022C RID: 556 RVA: 0x00002706 File Offset: 0x00000906
		Private Sub RTab_Click(sender As Object, e As EventArgs)
			Me.TabControl1.TabPages.Remove(Me.TabControl1.SelectedTab)
		End Sub

		' Token: 0x0600022D RID: 557 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600022E RID: 558 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub loadToolStripMenuItem_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600022F RID: 559 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub TabControl1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000230 RID: 560 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub panel1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000231 RID: 561 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub listBox1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000232 RID: 562 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub VegaX_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000233 RID: 563 RVA: 0x00024378 File Offset: 0x00022578
		Private Sub executeToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.listBox1.SelectedIndex <> -1 Then
				Me.api.SendLuaScript(File.ReadAllText("scripts\" + Me.listBox1.SelectedItem.ToString()))
				Me.api.SendLuaCScript(File.ReadAllText("scripts\" + Me.listBox1.SelectedItem.ToString()))
			End If
		End Sub

		' Token: 0x06000234 RID: 564 RVA: 0x000243EC File Offset: 0x000225EC
		Private Sub loadToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
			Dim fastColoredTextBox As FastColoredTextBox = TryCast(Me.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", True).FirstOrDefault(), FastColoredTextBox)
			If Me.listBox1.SelectedIndex <> -1 Then
				fastColoredTextBox.Text = File.ReadAllText("scripts\" + Me.listBox1.SelectedItem.ToString())
			Else
				MessageBox.Show("Please select a script from the list before trying to loading it in tab.", "Name")
			End If
		End Sub

		' Token: 0x06000235 RID: 565 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub timer1_Tick(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000236 RID: 566 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub VegaX_FormClosing(sender As Object, e As FormClosingEventArgs)
		End Sub

		' Token: 0x06000237 RID: 567 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub checkBox1_CheckedChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000238 RID: 568 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub lightThemeToolStripMenuItem_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000239 RID: 569 RVA: 0x00002723 File Offset: 0x00000923
		Private Sub redThemeToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Form.ActiveForm.BackColor = Color.DarkRed
		End Sub

		' Token: 0x0600023A RID: 570 RVA: 0x00002734 File Offset: 0x00000934
		Private Sub orangeThemeToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Form.ActiveForm.BackColor = Color.Orange
		End Sub

		' Token: 0x0600023B RID: 571 RVA: 0x00002745 File Offset: 0x00000945
		Private Sub yellowThemeToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Form.ActiveForm.BackColor = Color.Yellow
		End Sub

		' Token: 0x0600023C RID: 572 RVA: 0x00002756 File Offset: 0x00000956
		Private Sub greenThemeToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Form.ActiveForm.BackColor = Color.Green
		End Sub

		' Token: 0x0600023D RID: 573 RVA: 0x00002767 File Offset: 0x00000967
		Private Sub blueThemeToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Form.ActiveForm.BackColor = Color.Blue
		End Sub

		' Token: 0x0600023E RID: 574 RVA: 0x00002778 File Offset: 0x00000978
		Private Sub purpleThemeToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Form.ActiveForm.BackColor = Color.Purple
		End Sub

		' Token: 0x0600023F RID: 575 RVA: 0x00002789 File Offset: 0x00000989
		Private Sub blackThemeToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Form.ActiveForm.BackColor = Color.Black
		End Sub

		' Token: 0x06000240 RID: 576 RVA: 0x0000279A File Offset: 0x0000099A
		Private Sub pinkThemeToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Form.ActiveForm.BackColor = Color.Pink
		End Sub

		' Token: 0x06000241 RID: 577 RVA: 0x000027AB File Offset: 0x000009AB
		Private Sub whiteThemeToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Form.ActiveForm.BackColor = Color.White
		End Sub

		' Token: 0x06000242 RID: 578 RVA: 0x000027BC File Offset: 0x000009BC
		Private Sub dEFAULTTHEMEToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Form.ActiveForm.BackColor = Me.button12.BackColor
			Me.panel1.BackColor = Me.button13.BackColor
		End Sub

		' Token: 0x06000243 RID: 579 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub toolStripSeparator6_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000244 RID: 580 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub cUSTOMTHEMEToolStripMenuItem_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000245 RID: 581 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub pictureBox1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000246 RID: 582 RVA: 0x000027E9 File Offset: 0x000009E9
		Private Sub pictureBox1_DragEnter(sender As Object, e As DragEventArgs)
			e.Effect = DragDropEffects.Copy
		End Sub

		' Token: 0x06000247 RID: 583 RVA: 0x0002446C File Offset: 0x0002266C
		Private Sub pictureBox1_DragDrop(sender As Object, e As DragEventArgs)
			Dim data As Object = e.Data.GetData(DataFormats.FileDrop)
			If data IsNot Nothing Then
				Dim array As String() = TryCast(data, String())
				If array.Length <> 0 Then
					Me.pictureBox1.Image = Image.FromFile(array(0))
				End If
			End If
		End Sub

		' Token: 0x06000248 RID: 584 RVA: 0x000244B4 File Offset: 0x000226B4
		Private Sub rEMOVECUSTOMTHEMEToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim dialogResult As DialogResult = MessageBox.Show("Do You Really Want To Remove Your Custom Theme?", "Vega X | Themes", MessageBoxButtons.YesNo)
			If dialogResult = DialogResult.Yes Then
				Me.pictureBox1.Image = Nothing
			ElseIf dialogResult <> DialogResult.No Then
			End If
		End Sub

		' Token: 0x06000249 RID: 585 RVA: 0x000027F2 File Offset: 0x000009F2
		Private Sub lightBlueThemeToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Form.ActiveForm.BackColor = Color.LightBlue
		End Sub

		' Token: 0x0600024A RID: 586 RVA: 0x000244EC File Offset: 0x000226EC
		Private Sub checkBox1_CheckedChanged_1(sender As Object, e As EventArgs)
			If Me.checkBox1.CheckState = CheckState.Checked Then
				Form.ActiveForm.Opacity = CDbl(Me.trackBar1.Value) / 10.0
			End If
			If Me.checkBox1.CheckState = CheckState.Unchecked Then
				Form.ActiveForm.Opacity = CDbl(Me.trackBar2.Value) / 10.0
			End If
		End Sub

		' Token: 0x0600024B RID: 587 RVA: 0x00002803 File Offset: 0x00000A03
		Private Sub timer1_Tick_1(sender As Object, e As EventArgs)
			If MyBase.Opacity < 1.0 Then
				MyBase.Opacity += 0.15
			Else
				Me.timer1.[Stop]()
			End If
		End Sub

		' Token: 0x0600024C RID: 588 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub toolStripSeparator15_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600024D RID: 589 RVA: 0x0000283B File Offset: 0x00000A3B
		Private Sub lightBlueToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
			Me.panel1.BackColor = Color.CornflowerBlue
		End Sub

		' Token: 0x0600024E RID: 590 RVA: 0x0000284D File Offset: 0x00000A4D
		Private Sub deepRedToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.panel1.BackColor = Color.OrangeRed
		End Sub

		' Token: 0x0600024F RID: 591 RVA: 0x0000285F File Offset: 0x00000A5F
		Private Sub lightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.panel1.BackColor = Color.DarkSeaGreen
		End Sub

		' Token: 0x06000250 RID: 592 RVA: 0x00002871 File Offset: 0x00000A71
		Private Sub dEFAULTCOLORToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
			Me.panel1.BackColor = Me.button13.BackColor
		End Sub

		' Token: 0x06000251 RID: 593 RVA: 0x00002889 File Offset: 0x00000A89
		Private Sub dimRedToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.panel1.BackColor = Color.IndianRed
		End Sub

		' Token: 0x06000252 RID: 594 RVA: 0x0000289B File Offset: 0x00000A9B
		Private Sub brightPurpleToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.panel1.BackColor = Color.MediumPurple
		End Sub

		' Token: 0x06000253 RID: 595 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub panel1_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		' Token: 0x06000254 RID: 596 RVA: 0x000028AD File Offset: 0x00000AAD
		Private Sub grayThemeToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Form.ActiveForm.BackColor = Color.Gray
		End Sub

		' Token: 0x06000255 RID: 597 RVA: 0x000028BE File Offset: 0x00000ABE
		Private Sub redToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Form.ActiveForm.BackColor = Color.Red
		End Sub

		' Token: 0x06000256 RID: 598 RVA: 0x00002734 File Offset: 0x00000934
		Private Sub orangeToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Form.ActiveForm.BackColor = Color.Orange
		End Sub

		' Token: 0x06000257 RID: 599 RVA: 0x00002745 File Offset: 0x00000945
		Private Sub yellowToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Form.ActiveForm.BackColor = Color.Yellow
		End Sub

		' Token: 0x06000258 RID: 600 RVA: 0x00002756 File Offset: 0x00000956
		Private Sub greenToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Form.ActiveForm.BackColor = Color.Green
		End Sub

		' Token: 0x06000259 RID: 601 RVA: 0x00002767 File Offset: 0x00000967
		Private Sub blueToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Form.ActiveForm.BackColor = Color.Blue
		End Sub

		' Token: 0x0600025A RID: 602 RVA: 0x00002778 File Offset: 0x00000978
		Private Sub purpleToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Form.ActiveForm.BackColor = Color.Purple
		End Sub

		' Token: 0x0600025B RID: 603 RVA: 0x000028CF File Offset: 0x00000ACF
		Private Sub darkGreenToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Form.ActiveForm.BackColor = Color.DarkGreen
		End Sub

		' Token: 0x0600025C RID: 604 RVA: 0x000027F2 File Offset: 0x000009F2
		Private Sub lightBlueToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Form.ActiveForm.BackColor = Color.LightBlue
		End Sub

		' Token: 0x0600025D RID: 605 RVA: 0x00002789 File Offset: 0x00000989
		Private Sub blackToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Form.ActiveForm.BackColor = Color.Black
		End Sub

		' Token: 0x0600025E RID: 606 RVA: 0x0000279A File Offset: 0x0000099A
		Private Sub pinkToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Form.ActiveForm.BackColor = Color.Pink
		End Sub

		' Token: 0x0600025F RID: 607 RVA: 0x000028E0 File Offset: 0x00000AE0
		Private Sub tanToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Form.ActiveForm.BackColor = Color.Tan
		End Sub

		' Token: 0x06000260 RID: 608 RVA: 0x000027AB File Offset: 0x000009AB
		Private Sub whiteToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Form.ActiveForm.BackColor = Color.White
		End Sub

		' Token: 0x06000261 RID: 609 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub dragAnyImageIntoTheBlankSpaceToAddACustomThemeToolStripMenuItem_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000262 RID: 610 RVA: 0x000028F1 File Offset: 0x00000AF1
		Private Sub cUSTOMTHEMEToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
			MessageBox.Show("Drag And Drop Any Image/GIF File Next To The 'Transparent' Checkbox To Use A Custom Theme.")
		End Sub

		' Token: 0x06000263 RID: 611 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub tRANSPARENTTEXTBOXToolStripMenuItem_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000264 RID: 612 RVA: 0x000028FE File Offset: 0x00000AFE
		Private Sub onToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.TabControl1.SendToBack()
		End Sub

		' Token: 0x06000265 RID: 613 RVA: 0x0000290B File Offset: 0x00000B0B
		Private Sub offToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.TabControl1.BringToFront()
		End Sub

		' Token: 0x06000266 RID: 614 RVA: 0x0002455C File Offset: 0x0002275C
		Private Sub button14_Click(sender As Object, e As EventArgs)
			Dim fastColoredTextBox As FastColoredTextBox = TryCast(Me.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", True).FirstOrDefault(), FastColoredTextBox)
			Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
			If openFileDialog.ShowDialog() = DialogResult.OK Then
				openFileDialog.Title = "Open"
				fastColoredTextBox.Text = File.ReadAllText(openFileDialog.FileName)
				Me.api.SendLuaScript(fastColoredTextBox.Text)
				Me.api.SendLuaCScript(fastColoredTextBox.Text)
			End If
		End Sub

		' Token: 0x06000267 RID: 615 RVA: 0x00023048 File Offset: 0x00021248
		Private Sub button15_Click(sender As Object, e As EventArgs)
			Dim scriptHub As ScriptHub = New ScriptHub()
			scriptHub.Show()
		End Sub

		' Token: 0x06000268 RID: 616 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub checkBox2_CheckedChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000269 RID: 617 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub WrdRadioButton_CheckedChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600026A RID: 618 RVA: 0x00002918 File Offset: 0x00000B18
		Private Sub toolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Me.panel1.BackColor = Color.Black
		End Sub

		' Token: 0x0600026B RID: 619 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub EasyExploitRadioButton_CheckedChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600026C RID: 620 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub panel3_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		' Token: 0x0600026D RID: 621 RVA: 0x00024084 File Offset: 0x00022284
		Private Sub button4_Click_1(sender As Object, e As EventArgs)
			Dim fastColoredTextBox As FastColoredTextBox = TryCast(Me.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", True).FirstOrDefault(), FastColoredTextBox)
			fastColoredTextBox.Text = ""
		End Sub

		' Token: 0x0600026E RID: 622 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub panel4_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		' Token: 0x0600026F RID: 623 RVA: 0x00024084 File Offset: 0x00022284
		Private Sub panel4_Click(sender As Object, e As EventArgs)
			Dim fastColoredTextBox As FastColoredTextBox = TryCast(Me.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", True).FirstOrDefault(), FastColoredTextBox)
			fastColoredTextBox.Text = ""
		End Sub

		' Token: 0x06000270 RID: 624 RVA: 0x00024280 File Offset: 0x00022480
		Private Sub panel3_Click(sender As Object, e As EventArgs)
			If Me.WrdRadioButton.Checked Then
				Dim fastColoredTextBox As FastColoredTextBox = TryCast(Me.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", True).FirstOrDefault(), FastColoredTextBox)
				Me.api.SendLuaScript(fastColoredTextBox.Text)
			ElseIf Me.EasyExploitRadioButton.Checked Then
				Dim fastColoredTextBox2 As FastColoredTextBox = TryCast(Me.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", True).FirstOrDefault(), FastColoredTextBox)
				Me.[module].ExecuteScript(fastColoredTextBox2.Text)
			End If
		End Sub

		' Token: 0x06000271 RID: 625 RVA: 0x000240C4 File Offset: 0x000222C4
		Private Sub button8_Click_1(sender As Object, e As EventArgs)
			Dim fastColoredTextBox As FastColoredTextBox = TryCast(Me.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", True).FirstOrDefault(), FastColoredTextBox)
			Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
			If openFileDialog.ShowDialog() = DialogResult.OK Then
				openFileDialog.Title = "Open"
				fastColoredTextBox.Text = File.ReadAllText(openFileDialog.FileName)
			End If
		End Sub

		' Token: 0x06000272 RID: 626 RVA: 0x000240C4 File Offset: 0x000222C4
		Private Sub panel5_Click(sender As Object, e As EventArgs)
			Dim fastColoredTextBox As FastColoredTextBox = TryCast(Me.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", True).FirstOrDefault(), FastColoredTextBox)
			Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
			If openFileDialog.ShowDialog() = DialogResult.OK Then
				openFileDialog.Title = "Open"
				fastColoredTextBox.Text = File.ReadAllText(openFileDialog.FileName)
			End If
		End Sub

		' Token: 0x06000273 RID: 627 RVA: 0x00023FEC File Offset: 0x000221EC
		Private Sub button6_Click_1(sender As Object, e As EventArgs)
			Dim fastColoredTextBox As FastColoredTextBox = TryCast(Me.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", True).FirstOrDefault(), FastColoredTextBox)
			Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
			If saveFileDialog.ShowDialog() = DialogResult.OK Then
				Using stream As Stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew)
					Using streamWriter As StreamWriter = New StreamWriter(stream)
						streamWriter.Write(fastColoredTextBox.Text)
					End Using
				End Using
			End If
		End Sub

		' Token: 0x06000274 RID: 628 RVA: 0x00023FEC File Offset: 0x000221EC
		Private Sub panel6_Click(sender As Object, e As EventArgs)
			Dim fastColoredTextBox As FastColoredTextBox = TryCast(Me.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", True).FirstOrDefault(), FastColoredTextBox)
			Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
			If saveFileDialog.ShowDialog() = DialogResult.OK Then
				Using stream As Stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew)
					Using streamWriter As StreamWriter = New StreamWriter(stream)
						streamWriter.Write(fastColoredTextBox.Text)
					End Using
				End Using
			End If
		End Sub

		' Token: 0x06000275 RID: 629 RVA: 0x0002455C File Offset: 0x0002275C
		Private Sub button7_Click_1(sender As Object, e As EventArgs)
			Dim fastColoredTextBox As FastColoredTextBox = TryCast(Me.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", True).FirstOrDefault(), FastColoredTextBox)
			Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
			If openFileDialog.ShowDialog() = DialogResult.OK Then
				openFileDialog.Title = "Open"
				fastColoredTextBox.Text = File.ReadAllText(openFileDialog.FileName)
				Me.api.SendLuaScript(fastColoredTextBox.Text)
				Me.api.SendLuaCScript(fastColoredTextBox.Text)
			End If
		End Sub

		' Token: 0x06000276 RID: 630 RVA: 0x0002455C File Offset: 0x0002275C
		Private Sub panel7_Click(sender As Object, e As EventArgs)
			Dim fastColoredTextBox As FastColoredTextBox = TryCast(Me.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", True).FirstOrDefault(), FastColoredTextBox)
			Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
			If openFileDialog.ShowDialog() = DialogResult.OK Then
				openFileDialog.Title = "Open"
				fastColoredTextBox.Text = File.ReadAllText(openFileDialog.FileName)
				Me.api.SendLuaScript(fastColoredTextBox.Text)
				Me.api.SendLuaCScript(fastColoredTextBox.Text)
			End If
		End Sub

		' Token: 0x06000277 RID: 631 RVA: 0x00024124 File Offset: 0x00022324
		Private Sub button14_Click_1(sender As Object, e As EventArgs)
			Dim options As Options = New Options()
			options.Show()
		End Sub

		' Token: 0x06000278 RID: 632 RVA: 0x00024124 File Offset: 0x00022324
		Private Sub panel8_Click(sender As Object, e As EventArgs)
			Dim options As Options = New Options()
			options.Show()
		End Sub

		' Token: 0x06000279 RID: 633 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub panel9_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		' Token: 0x0600027A RID: 634 RVA: 0x0000292A File Offset: 0x00000B2A
		Private Sub panel9_Click(sender As Object, e As EventArgs)
			Me.contextMenuStrip1.Show(Me.button16, 0, Me.button16.Height)
		End Sub

		' Token: 0x0600027B RID: 635 RVA: 0x0000292A File Offset: 0x00000B2A
		Private Sub button16_Click(sender As Object, e As EventArgs)
			Me.contextMenuStrip1.Show(Me.button16, 0, Me.button16.Height)
		End Sub

		' Token: 0x0600027C RID: 636 RVA: 0x00002949 File Offset: 0x00000B49
		Private Sub button5_Click_1(sender As Object, e As EventArgs)
			If Me.WrdRadioButton.Checked Then
				Me.api.LaunchExploit()
			ElseIf Me.EasyExploitRadioButton.Checked Then
				Me.[module].LaunchExploit()
			End If
		End Sub

		' Token: 0x0600027D RID: 637 RVA: 0x00002949 File Offset: 0x00000B49
		Private Sub panel10_Click(sender As Object, e As EventArgs)
			If Me.WrdRadioButton.Checked Then
				Me.api.LaunchExploit()
			ElseIf Me.EasyExploitRadioButton.Checked Then
				Me.[module].LaunchExploit()
			End If
		End Sub

		' Token: 0x0600027E RID: 638 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub button10_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600027F RID: 639 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub panel12_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		' Token: 0x06000280 RID: 640 RVA: 0x0000505C File Offset: 0x0000325C
		Private Sub button10_Click_1(sender As Object, e As EventArgs)
			Dim simpleUI As SimpleUI = New SimpleUI()
			simpleUI.Show()
		End Sub

		' Token: 0x06000281 RID: 641 RVA: 0x0000505C File Offset: 0x0000325C
		Private Sub panel12_Click(sender As Object, e As EventArgs)
			Dim simpleUI As SimpleUI = New SimpleUI()
			simpleUI.Show()
		End Sub

		' Token: 0x06000282 RID: 642 RVA: 0x00024210 File Offset: 0x00022410
		Private Sub panel13_Click(sender As Object, e As EventArgs)
			Dim scriptManager As ScriptManager = New ScriptManager()
			scriptManager.Show()
		End Sub

		' Token: 0x06000283 RID: 643 RVA: 0x00023048 File Offset: 0x00021248
		Private Sub panel14_Click(sender As Object, e As EventArgs)
			Dim scriptHub As ScriptHub = New ScriptHub()
			scriptHub.Show()
		End Sub

		' Token: 0x06000284 RID: 644 RVA: 0x0000297E File Offset: 0x00000B7E
		Private Sub button11_Click_1(sender As Object, e As EventArgs)
			Me.listBox1.Items.Clear()
			Functions.PopulateListBox(Me.listBox1, "./Scripts", "*.txt")
			Functions.PopulateListBox(Me.listBox1, "./Scripts", "*.lua")
		End Sub

		' Token: 0x06000285 RID: 645 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub panel9_Leave(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000286 RID: 646 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub contextMenuStrip1_MouseLeave(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000287 RID: 647 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub panel10_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		' Token: 0x06000288 RID: 648 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub panel7_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		' Token: 0x06000289 RID: 649 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub panel14_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		' Token: 0x0600028A RID: 650 RVA: 0x00002949 File Offset: 0x00000B49
		Private Sub rButton1_Click(sender As Object, e As EventArgs)
			If Me.WrdRadioButton.Checked Then
				Me.api.LaunchExploit()
			ElseIf Me.EasyExploitRadioButton.Checked Then
				Me.[module].LaunchExploit()
			End If
		End Sub

		' Token: 0x0600028B RID: 651 RVA: 0x00024280 File Offset: 0x00022480
		Private Sub rButton2_Click(sender As Object, e As EventArgs)
			If Me.WrdRadioButton.Checked Then
				Dim fastColoredTextBox As FastColoredTextBox = TryCast(Me.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", True).FirstOrDefault(), FastColoredTextBox)
				Me.api.SendLuaScript(fastColoredTextBox.Text)
			ElseIf Me.EasyExploitRadioButton.Checked Then
				Dim fastColoredTextBox2 As FastColoredTextBox = TryCast(Me.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", True).FirstOrDefault(), FastColoredTextBox)
				Me.[module].ExecuteScript(fastColoredTextBox2.Text)
			End If
		End Sub

		' Token: 0x0600028C RID: 652 RVA: 0x00024084 File Offset: 0x00022284
		Private Sub rButton3_Click(sender As Object, e As EventArgs)
			Dim fastColoredTextBox As FastColoredTextBox = TryCast(Me.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", True).FirstOrDefault(), FastColoredTextBox)
			fastColoredTextBox.Text = ""
		End Sub

		' Token: 0x0600028D RID: 653 RVA: 0x0002455C File Offset: 0x0002275C
		Private Sub rButton4_Click(sender As Object, e As EventArgs)
			Dim fastColoredTextBox As FastColoredTextBox = TryCast(Me.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", True).FirstOrDefault(), FastColoredTextBox)
			Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
			If openFileDialog.ShowDialog() = DialogResult.OK Then
				openFileDialog.Title = "Open"
				fastColoredTextBox.Text = File.ReadAllText(openFileDialog.FileName)
				Me.api.SendLuaScript(fastColoredTextBox.Text)
				Me.api.SendLuaCScript(fastColoredTextBox.Text)
			End If
		End Sub

		' Token: 0x0600028E RID: 654 RVA: 0x00023FEC File Offset: 0x000221EC
		Private Sub rButton5_Click(sender As Object, e As EventArgs)
			Dim fastColoredTextBox As FastColoredTextBox = TryCast(Me.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", True).FirstOrDefault(), FastColoredTextBox)
			Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
			If saveFileDialog.ShowDialog() = DialogResult.OK Then
				Using stream As Stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew)
					Using streamWriter As StreamWriter = New StreamWriter(stream)
						streamWriter.Write(fastColoredTextBox.Text)
					End Using
				End Using
			End If
		End Sub

		' Token: 0x0600028F RID: 655 RVA: 0x000240C4 File Offset: 0x000222C4
		Private Sub rButton6_Click(sender As Object, e As EventArgs)
			Dim fastColoredTextBox As FastColoredTextBox = TryCast(Me.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", True).FirstOrDefault(), FastColoredTextBox)
			Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
			If openFileDialog.ShowDialog() = DialogResult.OK Then
				openFileDialog.Title = "Open"
				fastColoredTextBox.Text = File.ReadAllText(openFileDialog.FileName)
			End If
		End Sub

		' Token: 0x06000290 RID: 656 RVA: 0x00024124 File Offset: 0x00022324
		Private Sub rButton7_Click(sender As Object, e As EventArgs)
			Dim options As Options = New Options()
			options.Show()
		End Sub

		' Token: 0x06000291 RID: 657 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub rButton8_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000292 RID: 658 RVA: 0x0000292A File Offset: 0x00000B2A
		Private Sub rButton8_Click_1(sender As Object, e As EventArgs)
			Me.contextMenuStrip1.Show(Me.button16, 0, Me.button16.Height)
		End Sub

		' Token: 0x06000293 RID: 659 RVA: 0x00024210 File Offset: 0x00022410
		Private Sub rButton9_Click(sender As Object, e As EventArgs)
			Dim scriptManager As ScriptManager = New ScriptManager()
			scriptManager.Show()
		End Sub

		' Token: 0x06000294 RID: 660 RVA: 0x0000505C File Offset: 0x0000325C
		Private Sub rButton10_Click(sender As Object, e As EventArgs)
			Dim simpleUI As SimpleUI = New SimpleUI()
			simpleUI.Show()
		End Sub

		' Token: 0x06000295 RID: 661 RVA: 0x00024318 File Offset: 0x00022518
		Private Sub rButton11_Click(sender As Object, e As EventArgs)
			Dim text As String = "Scriptbox" + (Me.TabControl1.TabCount + 1).ToString()
			Dim userControl As UserControl1 = New UserControl1()
			userControl.Dock = DockStyle.Fill
			Dim tabPage As TabPage = New TabPage(text)
			tabPage.Controls.Add(userControl)
			Me.TabControl1.TabPages.Add(tabPage)
		End Sub

		' Token: 0x06000296 RID: 662 RVA: 0x0000297E File Offset: 0x00000B7E
		Private Sub rButton11_Click_1(sender As Object, e As EventArgs)
			Me.listBox1.Items.Clear()
			Functions.PopulateListBox(Me.listBox1, "./Scripts", "*.txt")
			Functions.PopulateListBox(Me.listBox1, "./Scripts", "*.lua")
		End Sub

		' Token: 0x06000297 RID: 663 RVA: 0x00023048 File Offset: 0x00021248
		Private Sub rButton8_Click_2(sender As Object, e As EventArgs)
			Dim scriptHub As ScriptHub = New ScriptHub()
			scriptHub.Show()
		End Sub

		' Token: 0x0400023E RID: 574
		Private api As ExploitAPI = New ExploitAPI()

		' Token: 0x0400023F RID: 575
		Private [module] As [Module] = New [Module]()

		' Token: 0x04000240 RID: 576
		Private lastPoint As Point
	End Class
End Namespace
