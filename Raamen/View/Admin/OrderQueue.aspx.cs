using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Raamen.View.Admin
{
    public partial class OrderQueue : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void orderQueueGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "HandleOrder")
            {
                int index = Convert.ToInt32(e.CommandArgument.ToString());
                GridViewRow gvr = orderQueueGridView.Rows[index];

                // Retrieve the order details
                int customerId = Convert.ToInt32(gvr.Cells[0].Text);
                int ramenId = Convert.ToInt32(gvr.Cells[1].Text);
                int quantity = Convert.ToInt32(gvr.Cells[2].Text);

                // Handle the order (move to the handled transactions section)
                OrderHandler.HandleOrder(customerId, ramenId, quantity);

                // Refresh the order queue GridView
                BindOrderQueueGridView();
            }
        }

        private void BindOrderQueueGridView()
        {
            // Retrieve the order queue data and bind it to the GridView
            List<Order> orderQueue = OrderHandler.GetOrderQueue();
            orderQueueGridView.DataSource = orderQueue;
            orderQueueGridView.DataBind();
        }
    }
}