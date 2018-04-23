Imports Microsoft.VisualBasic
Imports System
Namespace ReportMerging
	Public Partial Class XtraReport1
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

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
			Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
			Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
			Me.Detail.Height = 28
			Me.Detail.KeepTogether = True
			Me.Detail.Name = "Detail"
			Me.Detail.RepeatCountOnEmptyDataSource = 160
			' 
			' xrLabel1
			' 
			Me.xrLabel1.BackColor = System.Drawing.Color.Silver
			Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 12F)
			Me.xrLabel1.Location = New System.Drawing.Point(275, 0)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.ParentStyleUsing.UseBackColor = False
			Me.xrLabel1.ParentStyleUsing.UseFont = False
			Me.xrLabel1.Size = New System.Drawing.Size(100, 25)
			Me.xrLabel1.Text = "Report 1"
			Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
			' 
			' PageHeader
			' 
			Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageInfo2})
			Me.PageHeader.Height = 33
			Me.PageHeader.Name = "PageHeader"
			' 
			' xrPageInfo2
			' 
			Me.xrPageInfo2.BackColor = System.Drawing.Color.Silver
			Me.xrPageInfo2.Font = New System.Drawing.Font("Times New Roman", 12F)
			Me.xrPageInfo2.Location = New System.Drawing.Point(275, 0)
			Me.xrPageInfo2.Name = "xrPageInfo2"
			Me.xrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrPageInfo2.ParentStyleUsing.UseBackColor = False
			Me.xrPageInfo2.ParentStyleUsing.UseFont = False
			Me.xrPageInfo2.Size = New System.Drawing.Size(100, 25)
			Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
			' 
			' PageFooter
			' 
			Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageInfo1})
			Me.PageFooter.Height = 33
			Me.PageFooter.Name = "PageFooter"
			' 
			' xrPageInfo1
			' 
			Me.xrPageInfo1.BackColor = System.Drawing.Color.Silver
			Me.xrPageInfo1.Font = New System.Drawing.Font("Times New Roman", 12F)
			Me.xrPageInfo1.Location = New System.Drawing.Point(275, 0)
			Me.xrPageInfo1.Name = "xrPageInfo1"
			Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrPageInfo1.ParentStyleUsing.UseBackColor = False
			Me.xrPageInfo1.ParentStyleUsing.UseFont = False
			Me.xrPageInfo1.Size = New System.Drawing.Size(100, 25)
			Me.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageHeader, Me.PageFooter})
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
		Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
		Private xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
	End Class
End Namespace
