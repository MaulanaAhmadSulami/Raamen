using Raamen.Dataset;
using Raamen.Handler;
using Raamen.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Raamen.View.Admin
{
    public partial class ReportView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            CrystalReport1 report = new CrystalReport1();

            DataSet1 data = getDataSet(ReportHandler.GetAllTransactions());
            report.SetDataSource(data);

            CrystalReportViewer.ReportSource = report;

        }

        private DataSet1

         getDataSet(List<Header> Header_list)
        {
            DataSet1 data = new DataSet1();

            var HeaderTable = data.Header;
            var DetailTable = data.Detail;

            foreach (Header rm in Header_list)
            {
                var hrow = HeaderTable.NewRow();
                hrow["HeaderId"] = rm.HeaderId;
                hrow["CustomerId"] = rm.CustomerId;
                hrow["StaffId"] = rm.StaffId;
                hrow["Date"] = rm.Date;

                HeaderTable.Rows.Add(hrow);

                foreach (Detail cd in rm.Details)
                {
                    var drow = DetailTable.NewRow();
                    drow["HeaderId"] = cd.HeaderId;
                    drow["RamenId"] = cd.RamenId;
                    drow["Quantity"] = cd.Quantity;

                    DetailTable.Rows.Add(drow);
                }

            }

            return data;

        }

    }
}   