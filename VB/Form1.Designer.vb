Imports Microsoft.VisualBasic
Imports System
Namespace ReportMerging
	Public Partial Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
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
			Me.button1 = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			Me.button3 = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(119, 33)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(78, 31)
			Me.button1.TabIndex = 0
			Me.button1.Text = "1 + 2"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' button2
			' 
			Me.button2.Location = New System.Drawing.Point(122, 97)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(75, 38)
			Me.button2.TabIndex = 1
			Me.button2.Text = "1, 2"
			Me.button2.UseVisualStyleBackColor = True
'			Me.button2.Click += New System.EventHandler(Me.button2_Click);
			' 
			' button3
			' 
			Me.button3.Location = New System.Drawing.Point(122, 167)
			Me.button3.Name = "button3"
			Me.button3.Size = New System.Drawing.Size(75, 37)
			Me.button3.TabIndex = 2
			Me.button3.Text = "1, -1"
			Me.button3.UseVisualStyleBackColor = True
'			Me.button3.Click += New System.EventHandler(Me.button3_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(351, 258)
			Me.Controls.Add(Me.button3)
			Me.Controls.Add(Me.button2)
			Me.Controls.Add(Me.button1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents button1 As System.Windows.Forms.Button
		Private WithEvents button2 As System.Windows.Forms.Button
		Private WithEvents button3 As System.Windows.Forms.Button
	End Class
End Namespace

