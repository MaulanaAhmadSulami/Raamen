using Raamen.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Raamen.View.Admin
{
    public partial class RamenManage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ramenGV.DataSource = RamenHandler.getAllRamen();
            ramenGV.DataBind();
        }

        protected void insertRamen_Click(object sender, EventArgs e)
        {
            Response.Redirect("RamenInsert.aspx");
        }

        protected void ramenGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow gvr = ramenGV.Rows[e.NewEditIndex];
            string id = gvr.Cells[0].Text;
            Response.Redirect("RamenUpdate.aspx?id=" + id);
            e.Cancel = true;
        }

        protected void ramenGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow gvr = ramenGV.Rows[e.RowIndex];
            int id = int.Parse(gvr.Cells[0].Text);
            RamenHandler.deleteRamen(id);
            ramenGV.DataSource = RamenHandler.getAllRamen();
            ramenGV.DataBind();
        }
    }
}