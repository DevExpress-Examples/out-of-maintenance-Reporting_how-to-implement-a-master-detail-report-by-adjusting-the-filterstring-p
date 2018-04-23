# How to implement a Master-Detail report by adjusting the FilterString property at runtime


<p>This example illustrates the capability to create a <strong>Master-Detail</strong> report type by adjusting the <strong>DetailReportBand.FilterString</strong> property to filter "Order_Details" DetailReport band at runtime.</p><p>The example shows the common "<i>Orders - Order_Details</i>" Northwind data.<br />
The DetailReport_BeforePrint event handler is used to obtain the current <i>OrderID</i> value and then update the FilterString property accordingly.</p>

<br/>


