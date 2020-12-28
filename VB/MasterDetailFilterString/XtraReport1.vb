Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Namespace MasterDetailFilterString
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub DetailReport_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles DetailReport.BeforePrint
			Dim orderId As Integer = Convert.ToInt32(Me.GetCurrentColumnValue("OrderID"))
			DirectCast(sender, DetailReportBand).FilterString = String.Format("[OrderID] = {0}", orderId)
		End Sub

	End Class
End Namespace
