Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices

Namespace Vega_X.Properties
	' Token: 0x02000011 RID: 17
	<CompilerGenerated()>
	<GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")>
	<DebuggerNonUserCode()>
	Friend Class Resources
		' Token: 0x0600029B RID: 667 RVA: 0x00002205 File Offset: 0x00000405
		Friend Sub New()
		End Sub

		' Token: 0x17000001 RID: 1
		' (get) Token: 0x0600029C RID: 668 RVA: 0x000277E8 File Offset: 0x000259E8
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend Shared ReadOnly Property ResourceManager As ResourceManager
			Get
				If Resources.resourceMan Is Nothing Then
					Dim resourceManager As ResourceManager = New ResourceManager("Vega_X.Properties.Resources", GetType(Resources).Assembly)
					Resources.resourceMan = resourceManager
				End If
				Return Resources.resourceMan
			End Get
		End Property

		' Token: 0x17000002 RID: 2
		' (get) Token: 0x0600029D RID: 669 RVA: 0x00027828 File Offset: 0x00025A28
		' (set) Token: 0x0600029E RID: 670 RVA: 0x000029F3 File Offset: 0x00000BF3
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend Shared Property Culture As CultureInfo
			Get
				Return Resources.resourceCulture
			End Get
			Set(value As CultureInfo)
				Resources.resourceCulture = value
			End Set
		End Property

		' Token: 0x04000295 RID: 661
		Private Shared resourceMan As ResourceManager

		' Token: 0x04000296 RID: 662
		Private Shared resourceCulture As CultureInfo
	End Class
End Namespace
