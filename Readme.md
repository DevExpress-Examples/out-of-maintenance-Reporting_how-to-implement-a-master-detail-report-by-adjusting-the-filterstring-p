<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128601229/18.2.10%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E543)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/MasterDetailFilterString/Form1.cs) (VB: [Form1.vb](./VB/MasterDetailFilterString/Form1.vb))
* [Program.cs](./CS/MasterDetailFilterString/Program.cs) (VB: [Program.vb](./VB/MasterDetailFilterString/Program.vb))
* [XtraReport1.cs](./CS/MasterDetailFilterString/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/MasterDetailFilterString/XtraReport1.vb))
<!-- default file list end -->
# How to implement a master-detail report by setting the FilterString property at runtime


<p>This example illustrates how to create a master-detail report by filtering a detail report at runtime. Handle the BeforePrint event of a detail report band to obtain the current master row key value. After that, specify <a href="https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XtraReportBase.FilterString">DetailReportBand.FilterString</a> based on this value.</p>
<p>Please note that in a master-detail report scenario, the recommended way is to create a corresponding master-detail relationship at a data source level. See the "Manage Relations..." section in the following article:</br>
<a href="https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.Sql.SqlDataSource">SqlDataSource Class</a>. </br>
Here is a step-by-step tutorial on how to create a master-detail report: <a href="https://docs.devexpress.com/XtraReports/4785/create-popular-reports/create-a-master-detail-report-with-detail-report-bands">Create a Master-Detail Report with Detail Report Bands</a> .

<br/>


