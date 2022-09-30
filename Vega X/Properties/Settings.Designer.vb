Imports System
Imports System.CodeDom.Compiler
Imports System.Configuration
Imports System.Runtime.CompilerServices

Namespace Vega_X.Properties
	' Token: 0x02000012 RID: 18
	<CompilerGenerated()>
	<GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")>
	Friend NotInheritable Partial Class Settings
		Inherits ApplicationSettingsBase

		' Token: 0x17000003 RID: 3
		' (get) Token: 0x0600029F RID: 671 RVA: 0x0002783C File Offset: 0x00025A3C
		Public Shared ReadOnly Property [Default] As Settings
			Get
				Return Settings.defaultInstance
			End Get
		End Property

		' Token: 0x04000297 RID: 663
		Private Shared defaultInstance As Settings = CType(SettingsBase.Synchronized(New Settings()), Settings)
	End Class
End Namespace
