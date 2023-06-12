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

                DataSet1 data = getDataSet(ReportHandler.GetRamen());
                report.SetDataSource(data);

        }

        private DataSet1

           getDataSet(List<Raman> ramen_list)
        {
            DataSet1 data = new DataSet1();

            var HeaderTable = data.Ramen;
            var DetailTable = data.CartDetail;

            foreach(Raman rm in ramen_list)
            {
                var hrow = HeaderTable.NewRow();
                hrow["RamenId"] = rm.RamenId;
                hrow["MeatId"] = rm.MeatId;
                hrow["Name"] = rm.Name;
                hrow["Broth"] = rm.Broth;
                hrow["Price"] = rm.Price;

                HeaderTable.Rows.Add(hrow);

                foreach(CartDetail cd in rm.CartDetails)
                {
                    var drow = DetailTable.NewRow();
                    drow["CartDetailId"] = cd.CartDetailId;
                    drow["CartId"] = cd.CartId;
                    drow["RamenId"] = cd.RamenId;
                    drow["Quantity"] = cd.Quantity;

                    DetailTable.Rows.Add(drow);
                }
            }

            return data;

        }

    }
}