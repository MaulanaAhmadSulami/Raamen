using Raamen.Handler;
using Raamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Raamen.View.Admin
{
    public partial class History : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            trxGV.DataSource = HeaderHandler.getTransactionAll();
            trxGV.DataBind();
        }

        protected void trxGV_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "trxDetail")
            {
                int index = Convert.ToInt32(e.CommandArgument.ToString());
                GridViewRow gvr = trxGV.Rows[index];
                string id = gvr.Cells[0].Text;
                Response.Redirect("HistoryDetail.aspx?id=" + id);
            }
        }
    }
}