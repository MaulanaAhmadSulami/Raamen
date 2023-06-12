using Raamen.Dataset;
using Raamen.Handler;
using Raamen.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
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

        private DataSet1 getDataSet(List<Header> Header_list)
        {
            DataSet1 data = new DataSet1();

            var HeaderTable = data.Header;
            var DetailTable = data.Detail;
            var FooterTable = data.Footer;

            int grandtotal = 0;

            foreach (Header rm in Header_list)
            {
                int subtotal = 0;
                var hrow = HeaderTable.NewRow();
                hrow["HeaderId"] = rm.HeaderId;
                hrow["CustomerId"] = rm.User.Username;
                hrow["StaffId"] = rm.StaffId;
                hrow["Date"] = rm.Date;
                HeaderTable.Rows.Add(hrow);

                foreach (Detail cd in rm.Details)
                {
                    var drow = DetailTable.NewRow();
                    drow["HeaderId"] = cd.HeaderId;
                    drow["RamenName"] = cd.Raman.Name;
                    drow["MeatName"] = cd.Raman.Meat.Name;
                    drow["Broth"] = cd.Raman.Broth;
                    drow["Quantity"] = cd.Quantity;
                    drow["Price"] = cd.Raman.Price;
                    drow["Total"] = cd.Quantity * int.Parse(cd.Raman.Price);
                    subtotal = subtotal + (cd.Quantity * int.Parse(cd.Raman.Price));
                    drow["Subtotal"] = subtotal;

                    DetailTable.Rows.Add(drow);
                }
                grandtotal += subtotal;
            }

            var frow = FooterTable.NewRow();
            frow["GrandTotal"] = grandtotal;
            FooterTable.Rows.Add(frow);

            return data;

        }

    }
}   