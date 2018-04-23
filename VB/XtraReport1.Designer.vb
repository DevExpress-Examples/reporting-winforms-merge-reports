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
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel
            Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
            Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo
            Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
            Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
            Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand
            Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'Detail
            '
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel1})
            Me.Detail.HeightF = 28.0!
            Me.Detail.KeepTogether = True
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'xrLabel1
            '
            Me.xrLabel1.BackColor = System.Drawing.Color.Silver
            Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 12.0!)
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(275.0!, 0.0!)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(100.0!, 25.0!)
            Me.xrLabel1.Text = "Report 1"
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            '
            'PageHeader
            '
            Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPageInfo2})
            Me.PageHeader.HeightF = 33.0!
            Me.PageHeader.Name = "PageHeader"
            Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'xrPageInfo2
            '
            Me.xrPageInfo2.BackColor = System.Drawing.Color.Silver
            Me.xrPageInfo2.Font = New System.Drawing.Font("Times New Roman", 12.0!)
            Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(275.0!, 0.0!)
            Me.xrPageInfo2.Name = "xrPageInfo2"
            Me.xrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(100.0!, 25.0!)
            Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            '
            'PageFooter
            '
            Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPageInfo1})
            Me.PageFooter.HeightF = 33.0!
            Me.PageFooter.Name = "PageFooter"
            Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'xrPageInfo1
            '
            Me.xrPageInfo1.BackColor = System.Drawing.Color.Silver
            Me.xrPageInfo1.Font = New System.Drawing.Font("Times New Roman", 12.0!)
            Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(275.0!, 0.0!)
            Me.xrPageInfo1.Name = "xrPageInfo1"
            Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(100.0!, 25.0!)
            Me.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            '
            'TopMarginBand1
            '
            Me.TopMarginBand1.Name = "TopMarginBand1"
            '
            'BottomMarginBand1
            '
            Me.BottomMarginBand1.Name = "BottomMarginBand1"
            '
            'XtraReport1
            '
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.TopMarginBand1, Me.BottomMarginBand1})
            Me.DetailPrintCount = 160
            Me.Version = "10.2"
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
		Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
        Private xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
        Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
        Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
	End Class
End Namespace
