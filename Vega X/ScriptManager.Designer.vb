Namespace Vega_X
	' Token: 0x0200000C RID: 12
	Public Partial Class ScriptManager
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000200 RID: 512 RVA: 0x000025AE File Offset: 0x000007AE
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000201 RID: 513 RVA: 0x00021D80 File Offset: 0x0001FF80
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.Vega_X.ScriptManager))
			Me.panel1 = New Global.System.Windows.Forms.Panel()
			Me.button107 = New Global.System.Windows.Forms.Button()
			Me.button2 = New Global.System.Windows.Forms.Button()
			Me.label2 = New Global.System.Windows.Forms.Label()
			Me.label1 = New Global.System.Windows.Forms.Label()
			Me.panel2 = New Global.System.Windows.Forms.Panel()
			Me.dataGridView1 = New Global.System.Windows.Forms.DataGridView()
			Me.richTextBox2 = New Global.System.Windows.Forms.RichTextBox()
			Me.button8 = New Global.System.Windows.Forms.Button()
			Me.button1 = New Global.System.Windows.Forms.Button()
			Me.button3 = New Global.System.Windows.Forms.Button()
			Me.button4 = New Global.System.Windows.Forms.Button()
			Me.label3 = New Global.System.Windows.Forms.Label()
			Me.label4 = New Global.System.Windows.Forms.Label()
			Me.richTextBox1 = New Global.System.Windows.Forms.RichTextBox()
			Me.button5 = New Global.System.Windows.Forms.Button()
			Me.button6 = New Global.System.Windows.Forms.Button()
			Me.label5 = New Global.System.Windows.Forms.Label()
			Me.label6 = New Global.System.Windows.Forms.Label()
			Me.button7 = New Global.System.Windows.Forms.Button()
			Me.button9 = New Global.System.Windows.Forms.Button()
			Me.panel1.SuspendLayout()
			CType(Me.dataGridView1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.panel1.BackColor = Global.System.Drawing.Color.FromArgb(60, 60, 60)
			Me.panel1.Controls.Add(Me.button107)
			Me.panel1.Controls.Add(Me.button2)
			Me.panel1.Controls.Add(Me.label2)
			Me.panel1.Controls.Add(Me.label1)
			Me.panel1.Controls.Add(Me.panel2)
			Me.panel1.Location = New Global.System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New Global.System.Drawing.Size(779, 44)
			Me.panel1.TabIndex = 1
			AddHandler Me.panel1.MouseDown, AddressOf Me.panel1_MouseDown
			AddHandler Me.panel1.MouseMove, AddressOf Me.panel1_MouseMove
			Me.button107.BackColor = Global.System.Drawing.Color.FromArgb(60, 60, 60)
			Me.button107.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(60, 60, 60)
			Me.button107.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button107.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.button107.ForeColor = Global.System.Drawing.SystemColors.ControlLightLight
			Me.button107.Location = New Global.System.Drawing.Point(744, 8)
			Me.button107.Name = "button107"
			Me.button107.Size = New Global.System.Drawing.Size(30, 27)
			Me.button107.TabIndex = 23
			Me.button107.Text = "X"
			Me.button107.UseVisualStyleBackColor = False
			AddHandler Me.button107.Click, AddressOf Me.button107_Click
			Me.button2.BackColor = Global.System.Drawing.Color.FromArgb(60, 60, 60)
			Me.button2.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(60, 60, 60)
			Me.button2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.button2.ForeColor = Global.System.Drawing.SystemColors.ControlLightLight
			Me.button2.Location = New Global.System.Drawing.Point(711, 8)
			Me.button2.Name = "button2"
			Me.button2.Size = New Global.System.Drawing.Size(30, 27)
			Me.button2.TabIndex = 22
			Me.button2.Text = "—"
			Me.button2.UseVisualStyleBackColor = False
			AddHandler Me.button2.Click, AddressOf Me.button2_Click
			Me.label2.AutoSize = True
			Me.label2.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 14.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.label2.ForeColor = Global.System.Drawing.Color.Ivory
			Me.label2.Location = New Global.System.Drawing.Point(56, 8)
			Me.label2.Name = "label2"
			Me.label2.Size = New Global.System.Drawing.Size(0, 25)
			Me.label2.TabIndex = 21
			Me.label2.Visible = False
			Me.label1.AutoSize = True
			Me.label1.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.label1.ForeColor = Global.System.Drawing.SystemColors.Window
			Me.label1.Location = New Global.System.Drawing.Point(309, 11)
			Me.label1.Name = "label1"
			Me.label1.Size = New Global.System.Drawing.Size(186, 21)
			Me.label1.TabIndex = 2
			Me.label1.Text = "Vega X - Script Manager"
			Me.panel2.BackColor = Global.System.Drawing.Color.Transparent
			Me.panel2.BackgroundImage = CType(componentResourceManager.GetObject("panel2.BackgroundImage"), Global.System.Drawing.Image)
			Me.panel2.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Zoom
			Me.panel2.Location = New Global.System.Drawing.Point(2, 2)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New Global.System.Drawing.Size(48, 39)
			Me.panel2.TabIndex = 1
			Me.dataGridView1.AllowUserToAddRows = False
			Me.dataGridView1.AllowUserToDeleteRows = False
			Me.dataGridView1.AllowUserToResizeColumns = False
			Me.dataGridView1.AllowUserToResizeRows = False
			Me.dataGridView1.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dataGridView1.Location = New Global.System.Drawing.Point(511, 108)
			Me.dataGridView1.Name = "dataGridView1"
			Me.dataGridView1.[ReadOnly] = True
			Me.dataGridView1.RowHeadersVisible = False
			Me.dataGridView1.Size = New Global.System.Drawing.Size(246, 240)
			Me.dataGridView1.TabIndex = 5
			AddHandler Me.dataGridView1.CellContentClick, AddressOf Me.dataGridView1_CellContentClick
			Me.richTextBox2.BackColor = Global.System.Drawing.Color.FromArgb(30, 30, 30)
			Me.richTextBox2.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.richTextBox2.Font = New Global.System.Drawing.Font("Courier New", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.richTextBox2.ForeColor = Global.System.Drawing.Color.ForestGreen
			Me.richTextBox2.Location = New Global.System.Drawing.Point(135, 144)
			Me.richTextBox2.Name = "richTextBox2"
			Me.richTextBox2.Size = New Global.System.Drawing.Size(350, 204)
			Me.richTextBox2.TabIndex = 137
			Me.richTextBox2.Text = "-- Paste Your Script Here"
			AddHandler Me.richTextBox2.TextChanged, AddressOf Me.richTextBox2_TextChanged
			Me.button8.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.button8.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.button8.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button8.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.button8.Location = New Global.System.Drawing.Point(135, 354)
			Me.button8.Name = "button8"
			Me.button8.Size = New Global.System.Drawing.Size(83, 30)
			Me.button8.TabIndex = 138
			Me.button8.Text = "Save"
			Me.button8.UseVisualStyleBackColor = False
			AddHandler Me.button8.Click, AddressOf Me.button8_Click
			Me.button1.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.button1.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button1.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.button1.Location = New Global.System.Drawing.Point(402, 354)
			Me.button1.Name = "button1"
			Me.button1.Size = New Global.System.Drawing.Size(83, 30)
			Me.button1.TabIndex = 139
			Me.button1.Text = "Clear"
			Me.button1.UseVisualStyleBackColor = False
			AddHandler Me.button1.Click, AddressOf Me.button1_Click
			Me.button3.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.button3.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.button3.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button3.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.button3.Location = New Global.System.Drawing.Point(313, 354)
			Me.button3.Name = "button3"
			Me.button3.Size = New Global.System.Drawing.Size(83, 30)
			Me.button3.TabIndex = 140
			Me.button3.Text = "File"
			Me.button3.UseVisualStyleBackColor = False
			AddHandler Me.button3.Click, AddressOf Me.button3_Click
			Me.button4.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.button4.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.button4.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button4.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.button4.Location = New Global.System.Drawing.Point(224, 354)
			Me.button4.Name = "button4"
			Me.button4.Size = New Global.System.Drawing.Size(83, 30)
			Me.button4.TabIndex = 141
			Me.button4.Text = "Execute"
			Me.button4.UseVisualStyleBackColor = False
			AddHandler Me.button4.Click, AddressOf Me.button4_Click
			Me.label3.AutoSize = True
			Me.label3.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 18F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.label3.ForeColor = Global.System.Drawing.SystemColors.Window
			Me.label3.Location = New Global.System.Drawing.Point(50, 104)
			Me.label3.Name = "label3"
			Me.label3.Size = New Global.System.Drawing.Size(68, 32)
			Me.label3.TabIndex = 24
			Me.label3.Text = "Title:"
			Me.label4.AutoSize = True
			Me.label4.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 18F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.label4.ForeColor = Global.System.Drawing.SystemColors.Window
			Me.label4.Location = New Global.System.Drawing.Point(35, 144)
			Me.label4.Name = "label4"
			Me.label4.Size = New Global.System.Drawing.Size(83, 32)
			Me.label4.TabIndex = 142
			Me.label4.Text = "Script:"
			Me.richTextBox1.BackColor = Global.System.Drawing.Color.FromArgb(30, 30, 30)
			Me.richTextBox1.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.richTextBox1.Font = New Global.System.Drawing.Font("Courier New", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.richTextBox1.ForeColor = Global.System.Drawing.Color.ForestGreen
			Me.richTextBox1.Location = New Global.System.Drawing.Point(135, 108)
			Me.richTextBox1.Name = "richTextBox1"
			Me.richTextBox1.ScrollBars = Global.System.Windows.Forms.RichTextBoxScrollBars.None
			Me.richTextBox1.Size = New Global.System.Drawing.Size(350, 28)
			Me.richTextBox1.TabIndex = 143
			Me.richTextBox1.Text = "-- Script Name Here"
			Me.button5.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.button5.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.button5.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button5.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.button5.Location = New Global.System.Drawing.Point(644, 354)
			Me.button5.Name = "button5"
			Me.button5.Size = New Global.System.Drawing.Size(113, 30)
			Me.button5.TabIndex = 144
			Me.button5.Text = "Delete Script"
			Me.button5.UseVisualStyleBackColor = False
			AddHandler Me.button5.Click, AddressOf Me.button5_Click
			Me.button6.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.button6.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.button6.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button6.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.button6.Location = New Global.System.Drawing.Point(511, 354)
			Me.button6.Name = "button6"
			Me.button6.Size = New Global.System.Drawing.Size(127, 30)
			Me.button6.TabIndex = 145
			Me.button6.Text = "Open Script"
			Me.button6.UseVisualStyleBackColor = False
			AddHandler Me.button6.Click, AddressOf Me.button6_Click
			Me.label5.AutoSize = True
			Me.label5.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 18F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.label5.ForeColor = Global.System.Drawing.SystemColors.Window
			Me.label5.Location = New Global.System.Drawing.Point(212, 65)
			Me.label5.Name = "label5"
			Me.label5.Size = New Global.System.Drawing.Size(182, 32)
			Me.label5.TabIndex = 146
			Me.label5.Text = "Script Manager"
			Me.label6.AutoSize = True
			Me.label6.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 18F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.label6.ForeColor = Global.System.Drawing.SystemColors.Window
			Me.label6.Location = New Global.System.Drawing.Point(574, 66)
			Me.label6.Name = "label6"
			Me.label6.Size = New Global.System.Drawing.Size(121, 32)
			Me.label6.TabIndex = 147
			Me.label6.Text = "Script List"
			AddHandler Me.label6.Click, AddressOf Me.label6_Click
			Me.button7.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.button7.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.button7.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button7.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.button7.Location = New Global.System.Drawing.Point(22, 318)
			Me.button7.Name = "button7"
			Me.button7.Size = New Global.System.Drawing.Size(96, 66)
			Me.button7.TabIndex = 148
			Me.button7.Text = "How To Use The Script Manager"
			Me.button7.UseVisualStyleBackColor = False
			AddHandler Me.button7.Click, AddressOf Me.button7_Click
			Me.button9.BackColor = Global.System.Drawing.Color.FromArgb(65, 65, 65)
			Me.button9.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(45, 45, 45)
			Me.button9.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button9.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.button9.Location = New Global.System.Drawing.Point(22, 267)
			Me.button9.Name = "button9"
			Me.button9.Size = New Global.System.Drawing.Size(96, 45)
			Me.button9.TabIndex = 149
			Me.button9.Text = "Attach"
			Me.button9.UseVisualStyleBackColor = False
			AddHandler Me.button9.Click, AddressOf Me.button9_Click
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.FromArgb(50, 50, 50)
			MyBase.ClientSize = New Global.System.Drawing.Size(780, 404)
			MyBase.Controls.Add(Me.button9)
			MyBase.Controls.Add(Me.button7)
			MyBase.Controls.Add(Me.label6)
			MyBase.Controls.Add(Me.label5)
			MyBase.Controls.Add(Me.button6)
			MyBase.Controls.Add(Me.button5)
			MyBase.Controls.Add(Me.richTextBox1)
			MyBase.Controls.Add(Me.label4)
			MyBase.Controls.Add(Me.label3)
			MyBase.Controls.Add(Me.button4)
			MyBase.Controls.Add(Me.button3)
			MyBase.Controls.Add(Me.button1)
			MyBase.Controls.Add(Me.button8)
			MyBase.Controls.Add(Me.richTextBox2)
			MyBase.Controls.Add(Me.dataGridView1)
			MyBase.Controls.Add(Me.panel1)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Name = "ScriptManager"
			Me.Text = "ScriptManager"
			AddHandler MyBase.Load, AddressOf Me.ScriptManager_Load
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			CType(Me.dataGridView1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x04000216 RID: 534
		Private components As Global.System.ComponentModel.IContainer = Nothing

		' Token: 0x04000217 RID: 535
		Private panel1 As Global.System.Windows.Forms.Panel

		' Token: 0x04000218 RID: 536
		Private label2 As Global.System.Windows.Forms.Label

		' Token: 0x04000219 RID: 537
		Private label1 As Global.System.Windows.Forms.Label

		' Token: 0x0400021A RID: 538
		Private panel2 As Global.System.Windows.Forms.Panel

		' Token: 0x0400021B RID: 539
		Private button107 As Global.System.Windows.Forms.Button

		' Token: 0x0400021C RID: 540
		Private button2 As Global.System.Windows.Forms.Button

		' Token: 0x0400021D RID: 541
		Private dataGridView1 As Global.System.Windows.Forms.DataGridView

		' Token: 0x0400021E RID: 542
		Private richTextBox2 As Global.System.Windows.Forms.RichTextBox

		' Token: 0x0400021F RID: 543
		Private button8 As Global.System.Windows.Forms.Button

		' Token: 0x04000220 RID: 544
		Private button1 As Global.System.Windows.Forms.Button

		' Token: 0x04000221 RID: 545
		Private button3 As Global.System.Windows.Forms.Button

		' Token: 0x04000222 RID: 546
		Private button4 As Global.System.Windows.Forms.Button

		' Token: 0x04000223 RID: 547
		Private label3 As Global.System.Windows.Forms.Label

		' Token: 0x04000224 RID: 548
		Private label4 As Global.System.Windows.Forms.Label

		' Token: 0x04000225 RID: 549
		Private richTextBox1 As Global.System.Windows.Forms.RichTextBox

		' Token: 0x04000226 RID: 550
		Private button5 As Global.System.Windows.Forms.Button

		' Token: 0x04000227 RID: 551
		Private button6 As Global.System.Windows.Forms.Button

		' Token: 0x04000228 RID: 552
		Private label5 As Global.System.Windows.Forms.Label

		' Token: 0x04000229 RID: 553
		Private label6 As Global.System.Windows.Forms.Label

		' Token: 0x0400022A RID: 554
		Private button7 As Global.System.Windows.Forms.Button

		' Token: 0x0400022B RID: 555
		Private button9 As Global.System.Windows.Forms.Button
	End Class
End Namespace
