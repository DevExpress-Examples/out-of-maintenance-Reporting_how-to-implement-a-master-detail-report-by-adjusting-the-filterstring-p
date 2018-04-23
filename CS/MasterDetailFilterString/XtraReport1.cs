using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace MasterDetailFilterString {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void DetailReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            int orderId = Convert.ToInt32(this.GetCurrentColumnValue("OrderID"));
            ((DetailReportBand)sender).FilterString = string.Format("[OrderID] = {0}", orderId);
        }

    }
}
