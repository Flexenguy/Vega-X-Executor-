Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports EasyExploits
Imports WeAreDevs_API

Namespace Vega_X
	' Token: 0x0200000C RID: 12
	Public Partial Class ScriptManager
		Inherits Form

		' Token: 0x060001EF RID: 495 RVA: 0x00002520 File Offset: 0x00000720
		Public Sub New()
			Me.InitializeComponent()
		End Sub

		' Token: 0x060001F0 RID: 496 RVA: 0x00021B20 File Offset: 0x0001FD20
		Private Sub ScriptManager_Load(sender As Object, e As EventArgs)
			MyBase.TopMost = True
			Me.table = New DataTable()
			Me.table.Columns.Add("Title", GetType(String))
			Me.table.Columns.Add("Scripts", GetType(String))
			Me.dataGridView1.DataSource = Me.table
			Me.dataGridView1.Columns("Scripts").Visible = False
		End Sub

		' Token: 0x060001F1 RID: 497 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub label6_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060001F2 RID: 498 RVA: 0x00021BAC File Offset: 0x0001FDAC
		Private Sub button8_Click(sender As Object, e As EventArgs)
			Me.table.Rows.Add(New Object() { Me.richTextBox1.Text, Me.richTextBox2.Text })
			Me.richTextBox1.Clear()
			Me.richTextBox2.Clear()
		End Sub

		' Token: 0x060001F3 RID: 499 RVA: 0x0000254B File Offset: 0x0000074B
		Private Sub button7_Click(sender As Object, e As EventArgs)
			MessageBox.Show("To use the script manager, first add a *SCRIPT TITLE* and a *SCRIPT*. Then press *SAVE*. Your script will save to the *SCRIPT LIST*. To retrieve a script, select it from the *SCRIPT LIST* and press the *OPEN SCRIPT* button. Then you can execute it with the *EXECUTE SCRIPT* button. Enjoy! ")
		End Sub

		' Token: 0x060001F4 RID: 500 RVA: 0x00002558 File Offset: 0x00000758
		Private Sub button4_Click(sender As Object, e As EventArgs)
			Me.[module].ExecuteScript(Me.richTextBox2.Text)
		End Sub

		' Token: 0x060001F5 RID: 501 RVA: 0x00021C04 File Offset: 0x0001FE04
		Private Sub button3_Click(sender As Object, e As EventArgs)
			Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
			If saveFileDialog.ShowDialog() = DialogResult.OK Then
				Using stream As Stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew)
					Using streamWriter As StreamWriter = New StreamWriter(stream)
						streamWriter.Write(Me.richTextBox2.Text)
					End Using
				End Using
			End If
		End Sub

		' Token: 0x060001F6 RID: 502 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub richTextBox2_TextChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060001F7 RID: 503 RVA: 0x00002570 File Offset: 0x00000770
		Private Sub button1_Click(sender As Object, e As EventArgs)
			Me.richTextBox1.Clear()
			Me.richTextBox2.Clear()
		End Sub

		' Token: 0x060001F8 RID: 504 RVA: 0x00021C7C File Offset: 0x0001FE7C
		Private Sub button6_Click(sender As Object, e As EventArgs)
			Dim rowIndex As Integer = Me.dataGridView1.CurrentCell.RowIndex
			If rowIndex > -1 Then
				Me.richTextBox1.Text = Me.table.Rows(rowIndex).ItemArray(0).ToString()
				Me.richTextBox2.Text = Me.table.Rows(rowIndex).ItemArray(1).ToString()
			End If
		End Sub

		' Token: 0x060001F9 RID: 505 RVA: 0x00021CF0 File Offset: 0x0001FEF0
		Private Sub button5_Click(sender As Object, e As EventArgs)
			Dim rowIndex As Integer = Me.dataGridView1.CurrentCell.RowIndex
			Me.table.Rows(rowIndex).Delete()
		End Sub

		' Token: 0x060001FA RID: 506 RVA: 0x00002086 File Offset: 0x00000286
		Private Sub button107_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x060001FB RID: 507 RVA: 0x0000208E File Offset: 0x0000028E
		Private Sub button2_Click(sender As Object, e As EventArgs)
			MyBase.WindowState = FormWindowState.Minimized
		End Sub

		' Token: 0x060001FC RID: 508 RVA: 0x00021D24 File Offset: 0x0001FF24
		Private Sub panel1_MouseMove(sender As Object, e As MouseEventArgs)
			If e.Button = MouseButtons.Left Then
				MyBase.Left += e.X - Me.lastPoint.X
				MyBase.Top += e.Y - Me.lastPoint.Y
			End If
		End Sub

		' Token: 0x060001FD RID: 509 RVA: 0x00002588 File Offset: 0x00000788
		Private Sub panel1_MouseDown(sender As Object, e As MouseEventArgs)
			Me.lastPoint = New Point(e.X, e.Y)
		End Sub

		' Token: 0x060001FE RID: 510 RVA: 0x000025A1 File Offset: 0x000007A1
		Private Sub button9_Click(sender As Object, e As EventArgs)
			Me.[module].LaunchExploit()
		End Sub

		' Token: 0x060001FF RID: 511 RVA: 0x00002084 File Offset: 0x00000284
		Private Sub dataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
		End Sub

		' Token: 0x04000212 RID: 530
		Private [module] As [Module] = New [Module]()

		' Token: 0x04000213 RID: 531
		Private api As ExploitAPI = New ExploitAPI()

		' Token: 0x04000214 RID: 532
		Private table As DataTable

		' Token: 0x04000215 RID: 533
		Private lastPoint As Point
	End Class
End Namespace
