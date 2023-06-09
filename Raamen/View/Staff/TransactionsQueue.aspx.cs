using Raamen.Handler;
using Raamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Raamen.View.Staff
{
    public partial class TransactionsQueue : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            unhandledGV.DataSource = HeaderHandler.getTransactionUnhandled();
            unhandledGV.DataBind();
            handledGV.DataSource = HeaderHandler.getTransactionHandled();
            handledGV.DataBind();
        }

        protected void unhandledGV_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            User user = (User)Session["user"];
            int userId = user.CustomerId;

            if (e.CommandName == "trxHandle")
            {
                int index = Convert.ToInt32(e.CommandArgument.ToString());
                GridViewRow gvr = unhandledGV.Rows[index];
                string id = gvr.Cells[0].Text;
                status.Text = HeaderHandler.handleTransaction(int.Parse(id), userId);
            }
        }

        protected void handled_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "trxDetail")
            {
                int index = Convert.ToInt32(e.CommandArgument.ToString());
                GridViewRow gvr = handledGV.Rows[index];
                string id = gvr.Cells[0].Text;
                Response.Redirect("HistoryDetail.aspx?id=" + id);
            }
        }
    }
}