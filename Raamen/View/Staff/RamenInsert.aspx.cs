using Raamen.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Raamen.View.Staff
{
    public partial class RamenInsert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void insertButton_Click(object sender, EventArgs e)
        {
            string name = Name.Text;
            int meat = int.Parse(Meat.SelectedValue);
            string broth = Broth.Text;
            string price = Price.Text;
            status.Text = RamenController.insertRamen(name, meat, broth, price);
            if (status.Text.Equals("Success"))
            {
                Response.Redirect("RamenManage.aspx");
            }
        }
        protected void backButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("RamenManage.aspx");
        }
    }
}