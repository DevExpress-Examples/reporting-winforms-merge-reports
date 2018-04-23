using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace ReportMerging {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            CombineTwoReports();
        }

        private void button2_Click(object sender, EventArgs e) {
            MergeTwoReports();
        }

        private void button3_Click(object sender, EventArgs e) {
            CreateBooklet();
        }

        private void CombineTwoReports() {
            // Create the 1st report and generate its document.
            XtraReport1 report1 = new XtraReport1();
            report1.CreateDocument();

            // Create the 2nd report and generate its document.
            XtraReport2 report2 = new XtraReport2();
            report2.CreateDocument();

            // Add all pages of the 2nd report to the end of the 1st report.
            report1.Pages.AddRange(report2.Pages);

            // Reset all page numbers in the resulting document.
            report1.PrintingSystem.ContinuousPageNumbering = true;

            // Show the Print Preview form.
            report1.ShowPreviewDialog();
        }

        private void MergeTwoReports() {
            // Create the 1st report and generate its document.
            XtraReport1 report1 = new XtraReport1();
            report1.CreateDocument();

            // Create the 2nd report and generate its document.
            XtraReport2 report2 = new XtraReport2();
            report2.CreateDocument();

            // Merge pages of two reports, page-by-page.
            int minPageCount = Math.Min(report1.Pages.Count, report2.Pages.Count);
            for (int i = 0; i < minPageCount; i++) {
                report1.Pages.Insert(i * 2 + 1, report2.Pages[i]);
            }
            if (report2.Pages.Count != minPageCount) {
                for (int i = minPageCount; i < report2.Pages.Count; i++) {
                    report1.Pages.Add(report2.Pages[i]);
                }
            }

            // Reset all page numbers in the resulting document.
            report1.PrintingSystem.ContinuousPageNumbering = true;

            // Show the Print Preview form.
            report1.ShowPreviewDialog();
        }

        private void CreateBooklet() {
            // Create the 1st report and generate its document.
            XtraReport1 report1 = new XtraReport1();
            report1.CreateDocument();

            // Preserve original page numbers on all pages.
            report1.PrintingSystem.ContinuousPageNumbering = false;

            // Create a booklet.
            int centerPageIndex = Convert.ToInt32((report1.Pages.Count - 1) / 2);
            for (int i = 0; i < centerPageIndex; i++) {
                report1.Pages.Insert(i * 2 + 1, report1.Pages[report1.Pages.Count - 1]);
            }

            // Show the Print Preview form.
            report1.ShowPreviewDialog();
        }
    }
}

