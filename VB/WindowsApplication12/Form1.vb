Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace WindowsApplication12
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			ProcessAllEditors(Me)
		End Sub

		Private Sub ProcessAllEditors(ByVal container As Control)
			If TypeOf container Is BaseEdit Then
				'subscribe to the current control's events
				AddHandler container.GotFocus, AddressOf c_GotFocus
			Else
				'process all child controls recursively
				For Each c As Control In container.Controls
					ProcessAllEditors(c)
				Next c
			End If
		End Sub

		Private Sub c_GotFocus(ByVal sender As Object, ByVal e As EventArgs)
			If TypeOf sender Is TextEdit Then
                CType(sender, TextEdit).SelectAll()
			End If
		End Sub
	End Class
End Namespace