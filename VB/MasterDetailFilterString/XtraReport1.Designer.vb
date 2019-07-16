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
			Me.components = New System.ComponentModel.Container()
			Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
			Dim column1 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table1 As New DevExpress.DataAccess.Sql.Table()
			Dim column2 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column3 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column4 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression4 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column5 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression5 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column6 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression6 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column7 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression7 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column8 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression8 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column9 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression9 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column10 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression10 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column11 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression11 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column12 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression12 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column13 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression13 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column14 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression14 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim selectQuery2 As New DevExpress.DataAccess.Sql.SelectQuery()
			Dim column15 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression15 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table2 As New DevExpress.DataAccess.Sql.Table()
			Dim column16 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression16 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column17 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression17 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column18 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression18 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column19 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression19 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
			Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
			Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
			Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
			Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
			Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
			Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
			Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel7, Me.xrLabel6, Me.xrLabel5})
			Me.Detail.HeightF = 25F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabel7
			' 
			Me.xrLabel7.BackColor = System.Drawing.Color.PaleGoldenrod
			Me.xrLabel7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ShipCity]")})
			Me.xrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(450F, 0F)
			Me.xrLabel7.Name = "xrLabel7"
			Me.xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel7.SizeF = New System.Drawing.SizeF(200F, 25F)
			Me.xrLabel7.StylePriority.UseBackColor = False
			Me.xrLabel7.Text = "xrLabel7"
			' 
			' xrLabel6
			' 
			Me.xrLabel6.BackColor = System.Drawing.Color.PaleGoldenrod
			Me.xrLabel6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OrderDate]")})
			Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(242F, 0F)
			Me.xrLabel6.Name = "xrLabel6"
			Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel6.SizeF = New System.Drawing.SizeF(208F, 25F)
			Me.xrLabel6.StylePriority.UseBackColor = False
			Me.xrLabel6.Text = "xrLabel6"
			' 
			' xrLabel5
			' 
			Me.xrLabel5.BackColor = System.Drawing.Color.PaleGoldenrod
			Me.xrLabel5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OrderID]")})
			Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(125F, 0F)
			Me.xrLabel5.Name = "xrLabel5"
			Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel5.SizeF = New System.Drawing.SizeF(117F, 25F)
			Me.xrLabel5.StylePriority.UseBackColor = False
			Me.xrLabel5.Text = "xrLabel5"
			' 
			' PageHeader
			' 
			Me.PageHeader.HeightF = 30F
			Me.PageHeader.Name = "PageHeader"
			Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' PageFooter
			' 
			Me.PageFooter.HeightF = 30F
			Me.PageFooter.Name = "PageFooter"
			Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' DetailReport
			' 
			Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail1})
			Me.DetailReport.DataMember = "Order Details"
			Me.DetailReport.DataSource = Me.sqlDataSource1
			Me.DetailReport.Level = 0
			Me.DetailReport.Name = "DetailReport"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.DetailReport.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.DetailReport_BeforePrint);
			' 
			' Detail1
			' 
			Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel11, Me.xrLabel4, Me.xrLabel2, Me.xrLabel10, Me.xrLabel9, Me.xrLabel8})
			Me.Detail1.HeightF = 33F
			Me.Detail1.Name = "Detail1"
			' 
			' xrLabel11
			' 
			Me.xrLabel11.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.xrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(508F, 0F)
			Me.xrLabel11.Name = "xrLabel11"
			Me.xrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel11.SizeF = New System.Drawing.SizeF(42F, 25F)
			Me.xrLabel11.StylePriority.UseFont = False
			Me.xrLabel11.Text = "Price:"
			' 
			' xrLabel4
			' 
			Me.xrLabel4.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(358F, 0F)
			Me.xrLabel4.Name = "xrLabel4"
			Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel4.SizeF = New System.Drawing.SizeF(42F, 25F)
			Me.xrLabel4.StylePriority.UseFont = False
			Me.xrLabel4.Text = "Qty:"
			' 
			' xrLabel2
			' 
			Me.xrLabel2.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(167F, 0F)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel2.SizeF = New System.Drawing.SizeF(75F, 25F)
			Me.xrLabel2.StylePriority.UseFont = False
			Me.xrLabel2.Text = "Product ID"
			' 
			' xrLabel10
			' 
			Me.xrLabel10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitPrice]")})
			Me.xrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(550F, 0F)
			Me.xrLabel10.Name = "xrLabel10"
			Me.xrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel10.SizeF = New System.Drawing.SizeF(100F, 25F)
			Me.xrLabel10.Text = "xrLabel10"
			Me.xrLabel10.TextFormatString = "{0:c}"
			' 
			' xrLabel9
			' 
			Me.xrLabel9.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Quantity]")})
			Me.xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(400F, 0F)
			Me.xrLabel9.Name = "xrLabel9"
			Me.xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel9.SizeF = New System.Drawing.SizeF(100F, 25F)
			Me.xrLabel9.Text = "xrLabel9"
			' 
			' xrLabel8
			' 
			Me.xrLabel8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductID]")})
			Me.xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(242F, 0F)
			Me.xrLabel8.Name = "xrLabel8"
			Me.xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel8.SizeF = New System.Drawing.SizeF(100F, 25F)
			Me.xrLabel8.Text = "xrLabel8"
			' 
			' GroupHeader1
			' 
			Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel3, Me.xrLabel1})
			Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("CustomerID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
			Me.GroupHeader1.HeightF = 25F
			Me.GroupHeader1.Name = "GroupHeader1"
			' 
			' xrLabel3
			' 
			Me.xrLabel3.BackColor = System.Drawing.Color.LightGreen
			Me.xrLabel3.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(17F, 0F)
			Me.xrLabel3.Name = "xrLabel3"
			Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel3.SizeF = New System.Drawing.SizeF(108F, 25F)
			Me.xrLabel3.StylePriority.UseBackColor = False
			Me.xrLabel3.StylePriority.UseFont = False
			Me.xrLabel3.Text = "Customer:"
			' 
			' xrLabel1
			' 
			Me.xrLabel1.BackColor = System.Drawing.Color.LightGreen
			Me.xrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CustomerID]")})
			Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(125F, 0F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(125F, 25F)
			Me.xrLabel1.StylePriority.UseBackColor = False
			Me.xrLabel1.StylePriority.UseFont = False
			Me.xrLabel1.Text = "xrLabel1"
			' 
			' GroupFooter1
			' 
			Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLine1})
			Me.GroupFooter1.HeightF = 29F
			Me.GroupFooter1.Name = "GroupFooter1"
			' 
			' xrLine1
			' 
			Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(8F, 8F)
			Me.xrLine1.Name = "xrLine1"
			Me.xrLine1.SizeF = New System.Drawing.SizeF(642F, 8F)
			' 
			' topMarginBand1
			' 
			Me.topMarginBand1.Name = "topMarginBand1"
			' 
			' bottomMarginBand1
			' 
			Me.bottomMarginBand1.Name = "bottomMarginBand1"
			' 
			' sqlDataSource1
			' 
			Me.sqlDataSource1.ConnectionName = "nwindConnectionString"
			Me.sqlDataSource1.Name = "sqlDataSource1"
			columnExpression1.ColumnName = "OrderID"
			table1.Name = "Orders"
			columnExpression1.Table = table1
			column1.Expression = columnExpression1
			columnExpression2.ColumnName = "CustomerID"
			columnExpression2.Table = table1
			column2.Expression = columnExpression2
			columnExpression3.ColumnName = "EmployeeID"
			columnExpression3.Table = table1
			column3.Expression = columnExpression3
			columnExpression4.ColumnName = "OrderDate"
			columnExpression4.Table = table1
			column4.Expression = columnExpression4
			columnExpression5.ColumnName = "RequiredDate"
			columnExpression5.Table = table1
			column5.Expression = columnExpression5
			columnExpression6.ColumnName = "ShippedDate"
			columnExpression6.Table = table1
			column6.Expression = columnExpression6
			columnExpression7.ColumnName = "ShipVia"
			columnExpression7.Table = table1
			column7.Expression = columnExpression7
			columnExpression8.ColumnName = "Freight"
			columnExpression8.Table = table1
			column8.Expression = columnExpression8
			columnExpression9.ColumnName = "ShipName"
			columnExpression9.Table = table1
			column9.Expression = columnExpression9
			columnExpression10.ColumnName = "ShipAddress"
			columnExpression10.Table = table1
			column10.Expression = columnExpression10
			columnExpression11.ColumnName = "ShipCity"
			columnExpression11.Table = table1
			column11.Expression = columnExpression11
			columnExpression12.ColumnName = "ShipRegion"
			columnExpression12.Table = table1
			column12.Expression = columnExpression12
			columnExpression13.ColumnName = "ShipPostalCode"
			columnExpression13.Table = table1
			column13.Expression = columnExpression13
			columnExpression14.ColumnName = "ShipCountry"
			columnExpression14.Table = table1
			column14.Expression = columnExpression14
			selectQuery1.Columns.Add(column1)
			selectQuery1.Columns.Add(column2)
			selectQuery1.Columns.Add(column3)
			selectQuery1.Columns.Add(column4)
			selectQuery1.Columns.Add(column5)
			selectQuery1.Columns.Add(column6)
			selectQuery1.Columns.Add(column7)
			selectQuery1.Columns.Add(column8)
			selectQuery1.Columns.Add(column9)
			selectQuery1.Columns.Add(column10)
			selectQuery1.Columns.Add(column11)
			selectQuery1.Columns.Add(column12)
			selectQuery1.Columns.Add(column13)
			selectQuery1.Columns.Add(column14)
			selectQuery1.Name = "Orders"
			selectQuery1.Tables.Add(table1)
			columnExpression15.ColumnName = "OrderID"
			table2.Name = "Order Details"
			columnExpression15.Table = table2
			column15.Expression = columnExpression15
			columnExpression16.ColumnName = "ProductID"
			columnExpression16.Table = table2
			column16.Expression = columnExpression16
			columnExpression17.ColumnName = "UnitPrice"
			columnExpression17.Table = table2
			column17.Expression = columnExpression17
			columnExpression18.ColumnName = "Quantity"
			columnExpression18.Table = table2
			column18.Expression = columnExpression18
			columnExpression19.ColumnName = "Discount"
			columnExpression19.Table = table2
			column19.Expression = columnExpression19
			selectQuery2.Columns.Add(column15)
			selectQuery2.Columns.Add(column16)
			selectQuery2.Columns.Add(column17)
			selectQuery2.Columns.Add(column18)
			selectQuery2.Columns.Add(column19)
			selectQuery2.Name = "Order Details"
			selectQuery2.Tables.Add(table2)
			Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1, selectQuery2})
			Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageHeader, Me.PageFooter, Me.DetailReport, Me.GroupHeader1, Me.GroupFooter1, Me.topMarginBand1, Me.bottomMarginBand1})
			Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
			Me.DataMember = "Orders"
			Me.DataSource = Me.sqlDataSource1
			Me.Version = "19.1"
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
		Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
		Private xrLabel7 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel6 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel5 As DevExpress.XtraReports.UI.XRLabel
		Private WithEvents DetailReport As DevExpress.XtraReports.UI.DetailReportBand
		Private Detail1 As DevExpress.XtraReports.UI.DetailBand
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
		Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
		Private bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
		Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
	End Class
End Namespace
