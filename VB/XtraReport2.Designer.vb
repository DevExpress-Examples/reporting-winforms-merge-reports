Namespace ReportMerging
	Partial Public Class XtraReport2
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
			Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.xrPageInfo3 = New DevExpress.XtraReports.UI.XRPageInfo()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
			Me.Detail.HeightF = 29F
			Me.Detail.KeepTogether = True
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabel1
			' 
			Me.xrLabel1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(128)))), (CInt((CByte(128)))))
			Me.xrLabel1.Font = New DevExpress.Drawing.DXFont("Times New Roman", 12F)
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(250F, 0F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(100F, 25F)
			Me.xrLabel1.Text = "Report 2"
			Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
			' 
			' PageHeader
			' 
			Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageInfo2})
			Me.PageHeader.HeightF = 212.2917F
			Me.PageHeader.Name = "PageHeader"
			Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrPageInfo2
			' 
			Me.xrPageInfo2.BackColor = System.Drawing.Color.White
			Me.xrPageInfo2.Font = New DevExpress.Drawing.DXFont("Times New Roman", 72F)
			Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(250F, 0F)
			Me.xrPageInfo2.Name = "xrPageInfo2"
			Me.xrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.Number
			Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(159.375F, 182.5F)
			Me.xrPageInfo2.StylePriority.UseBackColor = False
			Me.xrPageInfo2.StylePriority.UseFont = False
			Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
			' 
			' PageFooter
			' 
			Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageInfo1})
			Me.PageFooter.HeightF = 33F
			Me.PageFooter.Name = "PageFooter"
			Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrPageInfo1
			' 
			Me.xrPageInfo1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(128)))), (CInt((CByte(128)))))
			Me.xrPageInfo1.Font = New DevExpress.Drawing.DXFont("Times New Roman", 12F)
			Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(250F, 0F)
			Me.xrPageInfo1.Name = "xrPageInfo1"
			Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(100F, 25F)
			Me.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
			' 
			' topMarginBand1
			' 
			Me.topMarginBand1.Name = "topMarginBand1"
			' 
			' bottomMarginBand1
			' 
			Me.bottomMarginBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageInfo3})
			Me.bottomMarginBand1.Name = "bottomMarginBand1"
			' 
			' xrPageInfo3
			' 
			Me.xrPageInfo3.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(128)))), (CInt((CByte(128)))))
			Me.xrPageInfo3.Font = New DevExpress.Drawing.DXFont("Times New Roman", 12F)
			Me.xrPageInfo3.LocationFloat = New DevExpress.Utils.PointFloat(236.4583F, 65.00002F)
			Me.xrPageInfo3.Name = "xrPageInfo3"
			Me.xrPageInfo3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrPageInfo3.SizeF = New System.Drawing.SizeF(100F, 25F)
			Me.xrPageInfo3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
			' 
			' XtraReport2
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageHeader, Me.PageFooter, Me.topMarginBand1, Me.bottomMarginBand1})
			Me.PageHeight = 583
			Me.PageWidth = 827
			Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A5Rotated
			Me.ReportPrintOptions.DetailCount = 100
			Me.ReportPrintOptions.DetailCountOnEmptyDataSource = 100
			Me.Version = "22.2"
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
		Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
		Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
		Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
		Private bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
		Private xrPageInfo3 As DevExpress.XtraReports.UI.XRPageInfo
	End Class
End Namespace
