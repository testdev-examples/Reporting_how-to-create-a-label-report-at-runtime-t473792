﻿Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Linq
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace dxWinFormsSample
	Friend Module Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread>
		Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			DevExpress.Skins.SkinManager.EnableFormSkins()
			Application.Run(New Form1())
		End Sub
	End Module
End Namespace
