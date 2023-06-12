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

                CrystalReportViewer.ReportSource = report;

            List<Header> headerList = ReportHandler.GetAllTransactions();
            List<Raman> ramenList = ReportHandler.GetAllRamen();

            DataSet1 data = getDataSet(headerList, ramenList);
                report.SetDataSource(data);

        }

        private DataSet1

           getDataSet(List<Header> Header_list, List<Raman> Ramen_list)
        {
            DataSet1 data = new DataSet1();

            var HeaderTable = data.Header;
            var DetailTable = data.Detail;
            var DetailTablex2 = data.Ramen;

            foreach(Header rm in Header_list)
            {
                var hrow = HeaderTable.NewRow();
                hrow["HeaderId"] = rm.HeaderId;
                hrow["CustomerId"] = rm.CustomerId;
                hrow["StaffId"] = rm.StaffId;
                hrow["Date"] = rm.Date;
                
                HeaderTable.Rows.Add(hrow);

                foreach(Detail cd in rm.Details)
                {
                    var drow = DetailTable.NewRow();
                    drow["HeaderId"] = cd.HeaderId;
                    drow["RamenId"] = cd.RamenId;
                    drow["Quantity"] = cd.Quantity;

                    DetailTable.Rows.Add(drow);
                }

            }

            foreach(Raman ramen in Ramen_list)
            {
                var rrow = DetailTablex2.NewRow();
                rrow["RamenId"] = ramen.RamenId;
                rrow["Name"] = ramen.Name;
                rrow["Price"] = ramen.Price;
            }

            return data;

        }

    }
}   