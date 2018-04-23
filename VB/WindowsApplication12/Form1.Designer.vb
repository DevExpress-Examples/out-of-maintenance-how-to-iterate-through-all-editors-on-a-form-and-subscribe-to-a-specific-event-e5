Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication12
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.TextEdit7 = New DevExpress.XtraEditors.TextEdit()
			Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.TextEdit6 = New DevExpress.XtraEditors.TextEdit()
			Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
			Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit()
			Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
			Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
			Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
			Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
			CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.GroupControl1.SuspendLayout()
			CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.GroupControl2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' TextEdit7
			' 
			Me.TextEdit7.Location = New System.Drawing.Point(16, 37)
			Me.TextEdit7.Name = "TextEdit7"
			Me.TextEdit7.Size = New System.Drawing.Size(100, 20)
			Me.TextEdit7.TabIndex = 6
			' 
			' GroupControl1
			' 
			Me.GroupControl1.Controls.Add(Me.TextEdit7)
			Me.GroupControl1.Controls.Add(Me.TextEdit6)
			Me.GroupControl1.Location = New System.Drawing.Point(464, 121)
			Me.GroupControl1.Name = "GroupControl1"
			Me.GroupControl1.Size = New System.Drawing.Size(200, 100)
			Me.GroupControl1.TabIndex = 11
			Me.GroupControl1.Text = "GroupControl1"
			' 
			' TextEdit6
			' 
			Me.TextEdit6.Location = New System.Drawing.Point(16, 63)
			Me.TextEdit6.Name = "TextEdit6"
			Me.TextEdit6.Size = New System.Drawing.Size(100, 20)
			Me.TextEdit6.TabIndex = 5
			' 
			' TextEdit1
			' 
			Me.TextEdit1.Location = New System.Drawing.Point(80, 158)
			Me.TextEdit1.Name = "TextEdit1"
			Me.TextEdit1.Size = New System.Drawing.Size(100, 20)
			Me.TextEdit1.TabIndex = 9
			' 
			' TextEdit5
			' 
			Me.TextEdit5.Location = New System.Drawing.Point(5, 23)
			Me.TextEdit5.Name = "TextEdit5"
			Me.TextEdit5.Size = New System.Drawing.Size(100, 20)
			Me.TextEdit5.TabIndex = 4
			' 
			' TextEdit2
			' 
			Me.TextEdit2.Location = New System.Drawing.Point(80, 184)
			Me.TextEdit2.Name = "TextEdit2"
			Me.TextEdit2.Size = New System.Drawing.Size(100, 20)
			Me.TextEdit2.TabIndex = 10
			' 
			' TextEdit4
			' 
			Me.TextEdit4.Location = New System.Drawing.Point(5, 49)
			Me.TextEdit4.Name = "TextEdit4"
			Me.TextEdit4.Size = New System.Drawing.Size(100, 20)
			Me.TextEdit4.TabIndex = 3
			' 
			' TextEdit3
			' 
			Me.TextEdit3.Location = New System.Drawing.Point(5, 75)
			Me.TextEdit3.Name = "TextEdit3"
			Me.TextEdit3.Size = New System.Drawing.Size(100, 20)
			Me.TextEdit3.TabIndex = 2
			' 
			' GroupControl2
			' 
			Me.GroupControl2.Controls.Add(Me.TextEdit5)
			Me.GroupControl2.Controls.Add(Me.TextEdit4)
			Me.GroupControl2.Controls.Add(Me.TextEdit3)
			Me.GroupControl2.Location = New System.Drawing.Point(443, 299)
			Me.GroupControl2.Name = "GroupControl2"
			Me.GroupControl2.Size = New System.Drawing.Size(200, 100)
			Me.GroupControl2.TabIndex = 12
			Me.GroupControl2.Text = "GroupControl2"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(745, 520)
			Me.Controls.Add(Me.GroupControl1)
			Me.Controls.Add(Me.TextEdit1)
			Me.Controls.Add(Me.TextEdit2)
			Me.Controls.Add(Me.GroupControl2)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.GroupControl1.ResumeLayout(False)
			CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.GroupControl2.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Friend TextEdit7 As DevExpress.XtraEditors.TextEdit
		Friend GroupControl1 As DevExpress.XtraEditors.GroupControl
		Friend TextEdit6 As DevExpress.XtraEditors.TextEdit
		Friend TextEdit1 As DevExpress.XtraEditors.TextEdit
		Friend TextEdit5 As DevExpress.XtraEditors.TextEdit
		Friend TextEdit2 As DevExpress.XtraEditors.TextEdit
		Friend TextEdit4 As DevExpress.XtraEditors.TextEdit
		Friend TextEdit3 As DevExpress.XtraEditors.TextEdit
		Friend GroupControl2 As DevExpress.XtraEditors.GroupControl
	End Class
End Namespace

