using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Raamen.Dataset;
using Raamen.Handler;
using Raamen.Model;

namespace Raamen.View.Admin
{
    public partial class ReportView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CrystalReport1 report = new CrystalReport1();
            CrystalReportViewer1.ReportSource = report;
            DataSet1 data = getData(ReportHandler.GetRamen());
            report.SetDataSource(data);
        }

        private DataSet1 getData(List<Raman> ramen)
        {
            DataSet1 data = new DataSet1();
            var headertable = data.Ramen;
            var detailtable = data.CartDetail;

            foreach (Raman r in ramen)
            {
                var hrow = headertable.NewRow();
                hrow["RamenId"] = r.RamenId;
                hrow["MeatId"] = r.MeatId;
                hrow["Name"] = r.Name;
                hrow["Broth"] = r.Broth;
                hrow["Price"] = r.Price;

                headertable.Rows.Add(hrow);

                foreach(CartDetail c in r.CartDetails)
                {
                    var drow = detailtable.NewRow();
                    drow["CartDetailId"] = c.CartDetailId;
                    drow["CartId"] = c.CartId;
                    drow["RamenId"] = c.RamenId;
                    drow["Quantity"] = c.Quantity;

                    detailtable.Rows.Add(drow);
                }
            }
            return data;
        }
    }
}