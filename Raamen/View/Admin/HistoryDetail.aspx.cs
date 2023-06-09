using Raamen.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Raamen.View.Admin
{
    public partial class HistoryDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            trxID.Text = id;
            detailGV.DataSource = DetailHandler.getTransactionDetail(int.Parse(id));
            detailGV.DataBind();
        }
        protected void backButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("History.aspx");
        }
    }
}