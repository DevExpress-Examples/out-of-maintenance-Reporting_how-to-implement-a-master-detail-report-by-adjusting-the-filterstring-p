<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128601229/12.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E543)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/MasterDetailFilterString/Form1.cs) (VB: [Form1.vb](./VB/MasterDetailFilterString/Form1.vb))
* [Program.cs](./CS/MasterDetailFilterString/Program.cs) (VB: [Program.vb](./VB/MasterDetailFilterString/Program.vb))
* [XtraReport1.cs](./CS/MasterDetailFilterString/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/MasterDetailFilterString/XtraReport1.vb))
<!-- default file list end -->
# How to implement a Master-Detail report by adjusting the FilterString property at runtime


<p>This example illustrates the capability to create a <strong>Master-Detail</strong> report type by adjusting the <strong>DetailReportBand.FilterString</strong> property to filter "Order_Details" DetailReport band at runtime.</p><p>The example shows the common "<i>Orders - Order_Details</i>" Northwind data.<br />
The DetailReport_BeforePrint event handler is used to obtain the current <i>OrderID</i> value and then update the FilterString property accordingly.</p>

<br/>


