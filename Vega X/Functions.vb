Imports System
Imports System.IO
Imports System.Windows.Forms

Namespace Vega_X
	' Token: 0x02000004 RID: 4
	Friend Class Functions
		' Token: 0x06000025 RID: 37 RVA: 0x000046BC File Offset: 0x000028BC
		Public Shared Sub PopulateListBox(lsb As ListBox, Folder As String, FileType As String)
			Dim directoryInfo As DirectoryInfo = New DirectoryInfo(Folder)
			Dim files As FileInfo() = directoryInfo.GetFiles(FileType)
			For Each fileInfo As FileInfo In files
				lsb.Items.Add(fileInfo.Name)
			Next
		End Sub

		' Token: 0x04000028 RID: 40
		Public Shared OpenFile As OpenFileDialog = New OpenFileDialog() With { .Filter = "Lua Files (*.lua)|*.lua|Text Files (*txt)|*.txt" }
	End Class
End Namespace
