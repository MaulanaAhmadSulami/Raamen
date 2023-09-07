using Raamen.Handler;
using Raamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Raamen.View.Customer
{
    public partial class OrderRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ramenGV.DataSource = RamenHandler.getAllRamen();
            ramenGV.DataBind();

            User user = (User)Session["user"];
            int userId = user.CustomerId;
            
            cartGV.DataSource = CartHandler.getUserCartDetail(userId);
            cartGV.DataBind();
            if(cartGV.Rows.Count == 0)
            {
                clearCart.Visible = false;
                checkout.Visible = false;
                LabelTotal.Text = "Your cart is empty.";
            }
            else
            {
                int sumTotal = 0;
                foreach (GridViewRow row in cartGV.Rows)
                {
                    sumTotal += ((int.Parse(row.Cells[1].Text)) * int.Parse(row.Cells[2].Text));
                }
                total.Text = sumTotal.ToString(); 
            }
        }

        protected void ramenGV_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            User user = (User)Session["user"];
            int userId = user.CustomerId;

            if (e.CommandName == "insertCart")
            {
                int index = Convert.ToInt32(e.CommandArgument.ToString());
                GridViewRow gvr = ramenGV.Rows[index];
                string id = gvr.Cells[0].Text;
                status.Text = CartHandler.insert(int.Parse(id), userId);
                Response.Redirect("OrderRamen.aspx");
            }
        }
        protected void cartGV_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            User user = (User)Session["user"];
            int userId = user.CustomerId;

            if (e.CommandName == "removeRamen")
            {
                int index = Convert.ToInt32(e.CommandArgument.ToString());
                GridViewRow gvr = cartGV.Rows[index];
                string id = gvr.Cells[0].Text;
                status.Text = CartHandler.delete(int.Parse(id), userId);
                Response.Redirect("OrderRamen.aspx");
            }
        }

        protected void clearCart_Click(object sender, EventArgs e)
        {
            User user = (User)Session["user"];
            int userId = user.CustomerId;

            status.Text = CartHandler.clearCart(userId);
            Response.Redirect("OrderRamen.aspx");
        }

        protected void checkout_Click(object sender, EventArgs e)
        {
            User user = (User)Session["user"];
            int userId = user.CustomerId;

            status.Text = CartHandler.checkout(userId);
            cartGV.DataSource = CartHandler.getUserCartDetail(userId);
            cartGV.DataBind();
        }
    }
}