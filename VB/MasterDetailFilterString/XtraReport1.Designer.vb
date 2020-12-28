Namespace MasterDetailFilterString
	Partial Public Class XtraReport1
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
			Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
			Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
			Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
			Me.dataSet11 = New MasterDetailFilterString.DataSet1()
			Me.ordersTableAdapter = New MasterDetailFilterString.DataSet1TableAdapters.OrdersTableAdapter()
			Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
			Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
			Me.order_DetailsTableAdapter = New MasterDetailFilterString.DataSet1TableAdapters.Order_DetailsTableAdapter()
			Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
			Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel7, Me.xrLabel6, Me.xrLabel5})
			Me.Detail.Height = 25
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabel7
			' 
			Me.xrLabel7.BackColor = System.Drawing.Color.PaleGoldenrod
			Me.xrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.ShipCity", "")})
			Me.xrLabel7.Location = New System.Drawing.Point(450, 0)
			Me.xrLabel7.Name = "xrLabel7"
			Me.xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel7.Size = New System.Drawing.Size(200, 25)
			Me.xrLabel7.StylePriority.UseBackColor = False
			Me.xrLabel7.Text = "xrLabel7"
			' 
			' xrLabel6
			' 
			Me.xrLabel6.BackColor = System.Drawing.Color.PaleGoldenrod
			Me.xrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.OrderDate", "")})
			Me.xrLabel6.Location = New System.Drawing.Point(242, 0)
			Me.xrLabel6.Name = "xrLabel6"
			Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel6.Size = New System.Drawing.Size(208, 25)
			Me.xrLabel6.StylePriority.UseBackColor = False
			Me.xrLabel6.Text = "xrLabel6"
			' 
			' xrLabel5
			' 
			Me.xrLabel5.BackColor = System.Drawing.Color.PaleGoldenrod
			Me.xrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.OrderID", "")})
			Me.xrLabel5.Location = New System.Drawing.Point(125, 0)
			Me.xrLabel5.Name = "xrLabel5"
			Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel5.Size = New System.Drawing.Size(117, 25)
			Me.xrLabel5.StylePriority.UseBackColor = False
			Me.xrLabel5.Text = "xrLabel5"
			' 
			' PageHeader
			' 
			Me.PageHeader.Height = 30
			Me.PageHeader.Name = "PageHeader"
			Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' PageFooter
			' 
			Me.PageFooter.Height = 30
			Me.PageFooter.Name = "PageFooter"
			Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' dataSet11
			' 
			Me.dataSet11.DataSetName = "DataSet1"
			Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' ordersTableAdapter
			' 
			Me.ordersTableAdapter.ClearBeforeFill = True
			' 
			' DetailReport
			' 
			Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail1})
			Me.DetailReport.DataAdapter = Me.order_DetailsTableAdapter
			Me.DetailReport.DataMember = "Order Details"
			Me.DetailReport.DataSource = Me.dataSet11
			Me.DetailReport.Name = "DetailReport"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.DetailReport.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.DetailReport_BeforePrint);
			' 
			' Detail1
			' 
			Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel11, Me.xrLabel4, Me.xrLabel2, Me.xrLabel10, Me.xrLabel9, Me.xrLabel8})
			Me.Detail1.Height = 33
			Me.Detail1.Name = "Detail1"
			' 
			' xrLabel11
			' 
			Me.xrLabel11.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.xrLabel11.Location = New System.Drawing.Point(508, 0)
			Me.xrLabel11.Name = "xrLabel11"
			Me.xrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel11.Size = New System.Drawing.Size(42, 25)
			Me.xrLabel11.StylePriority.UseFont = False
			Me.xrLabel11.Text = "Price:"
			' 
			' xrLabel4
			' 
			Me.xrLabel4.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.xrLabel4.Location = New System.Drawing.Point(358, 0)
			Me.xrLabel4.Name = "xrLabel4"
			Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel4.Size = New System.Drawing.Size(42, 25)
			Me.xrLabel4.StylePriority.UseFont = False
			Me.xrLabel4.Text = "Qty:"
			' 
			' xrLabel2
			' 
			Me.xrLabel2.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.xrLabel2.Location = New System.Drawing.Point(167, 0)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel2.Size = New System.Drawing.Size(75, 25)
			Me.xrLabel2.StylePriority.UseFont = False
			Me.xrLabel2.Text = "Product ID"
			' 
			' xrLabel10
			' 
			Me.xrLabel10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Order Details.UnitPrice", "{0:c}")})
			Me.xrLabel10.Location = New System.Drawing.Point(550, 0)
			Me.xrLabel10.Name = "xrLabel10"
			Me.xrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel10.Size = New System.Drawing.Size(100, 25)
			Me.xrLabel10.Text = "xrLabel10"
			' 
			' xrLabel9
			' 
			Me.xrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Order Details.Quantity", "")})
			Me.xrLabel9.Location = New System.Drawing.Point(400, 0)
			Me.xrLabel9.Name = "xrLabel9"
			Me.xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel9.Size = New System.Drawing.Size(100, 25)
			Me.xrLabel9.Text = "xrLabel9"
			' 
			' xrLabel8
			' 
			Me.xrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Order Details.ProductID", "")})
			Me.xrLabel8.Location = New System.Drawing.Point(242, 0)
			Me.xrLabel8.Name = "xrLabel8"
			Me.xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel8.Size = New System.Drawing.Size(100, 25)
			Me.xrLabel8.Text = "xrLabel8"
			' 
			' order_DetailsTableAdapter
			' 
			Me.order_DetailsTableAdapter.ClearBeforeFill = True
			' 
			' GroupHeader1
			' 
			Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel3, Me.xrLabel1})
			Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("CustomerID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
			Me.GroupHeader1.Height = 25
			Me.GroupHeader1.Name = "GroupHeader1"
			' 
			' xrLabel3
			' 
			Me.xrLabel3.BackColor = System.Drawing.Color.LightGreen
			Me.xrLabel3.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.xrLabel3.Location = New System.Drawing.Point(17, 0)
			Me.xrLabel3.Name = "xrLabel3"
			Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel3.Size = New System.Drawing.Size(108, 25)
			Me.xrLabel3.StylePriority.UseBackColor = False
			Me.xrLabel3.StylePriority.UseFont = False
			Me.xrLabel3.Text = "Customer:"
			' 
			' xrLabel1
			' 
			Me.xrLabel1.BackColor = System.Drawing.Color.LightGreen
			Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.CustomerID", "")})
			Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.xrLabel1.Location = New System.Drawing.Point(125, 0)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.Size = New System.Drawing.Size(125, 25)
			Me.xrLabel1.StylePriority.UseBackColor = False
			Me.xrLabel1.StylePriority.UseFont = False
			Me.xrLabel1.Text = "xrLabel1"
			' 
			' GroupFooter1
			' 
			Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLine1})
			Me.GroupFooter1.Height = 29
			Me.GroupFooter1.Name = "GroupFooter1"
			' 
			' xrLine1
			' 
			Me.xrLine1.Location = New System.Drawing.Point(8, 8)
			Me.xrLine1.Name = "xrLine1"
			Me.xrLine1.Size = New System.Drawing.Size(642, 8)
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageHeader, Me.PageFooter, Me.DetailReport, Me.GroupHeader1, Me.GroupFooter1})
			Me.DataAdapter = Me.ordersTableAdapter
			Me.DataMember = "Orders"
			Me.DataSource = Me.dataSet11
			Me.Version = "8.2"
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
		Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
		Private xrLabel7 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel6 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel5 As DevExpress.XtraReports.UI.XRLabel
		Private dataSet11 As DataSet1
		Private ordersTableAdapter As MasterDetailFilterString.DataSet1TableAdapters.OrdersTableAdapter
		Private WithEvents DetailReport As DevExpress.XtraReports.UI.DetailReportBand
		Private Detail1 As DevExpress.XtraReports.UI.DetailBand
		Private order_DetailsTableAdapter As MasterDetailFilterString.DataSet1TableAdapters.Order_DetailsTableAdapter
		Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
		Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
		Private xrLabel10 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel9 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel8 As DevExpress.XtraReports.UI.XRLabel
		Private xrLine1 As DevExpress.XtraReports.UI.XRLine
		Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel11 As DevExpress.XtraReports.UI.XRLabel
	End Class
End Namespace
