Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Namespace ReportMerging
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			CombineTwoReports()
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			MergeTwoReports()
		End Sub

		Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
			CreateBooklet()
		End Sub

		Private Sub CombineTwoReports()
			' Create the 1st report and generate its document.
			Dim report1 As New XtraReport1()
			report1.CreateDocument()

			' Create the 2nd report and generate its document.
			Dim report2 As New XtraReport2()
			report2.CreateDocument()

			' Add all pages of the 2nd report to the end of the 1st report.
			report1.Pages.AddRange(report2.Pages)

			' Reset all page numbers in the resulting document.
			report1.PrintingSystem.ContinuousPageNumbering = True

			' Show the Print Preview form.
			report1.ShowPreviewDialog()
		End Sub

		Private Sub MergeTwoReports()
			' Create the 1st report and generate its document.
			Dim report1 As New XtraReport1()
			report1.CreateDocument()

			' Create the 2nd report and generate its document.
			Dim report2 As New XtraReport2()
			report2.CreateDocument()

			' Merge pages of two reports, page-by-page.
			Dim minPageCount As Integer = Math.Min(report1.Pages.Count, report2.Pages.Count)
			For i As Integer = 0 To minPageCount - 1
				report1.Pages.Insert(i * 2 + 1, report2.Pages(i))
			Next i
			If report2.Pages.Count <> minPageCount Then
				For i As Integer = minPageCount To report2.Pages.Count - 1
					report1.Pages.Add(report2.Pages(i))
				Next i
			End If

			' Reset all page numbers in the resulting document.
			report1.PrintingSystem.ContinuousPageNumbering = True

			' Show the Print Preview form.
			report1.ShowPreviewDialog()
		End Sub

		Private Sub CreateBooklet()
			' Create the 1st report and generate its document.
			Dim report1 As New XtraReport1()
			report1.CreateDocument()

			' Preserve original page numbers on all pages.
			report1.PrintingSystem.ContinuousPageNumbering = False

			' Create a booklet.
			Dim centerPageIndex As Integer = Convert.ToInt32((report1.Pages.Count - 1) / 2)
			For i As Integer = 0 To centerPageIndex - 1
				report1.Pages.Insert(i * 2 + 1, report1.Pages(report1.Pages.Count - 1))
			Next i

			' Show the Print Preview form.
			report1.ShowPreviewDialog()
		End Sub
	End Class
End Namespace

