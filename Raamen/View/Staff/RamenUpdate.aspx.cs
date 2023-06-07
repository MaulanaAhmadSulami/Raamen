using Raamen.Controller;
using Raamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Raamen.View.Staff
{
    public partial class RamenUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            Raman ramen = RamenController.getRamenbyId(int.Parse(id));
            if (ramen != null)
            {
                Name.Text = ramen.Name;
                Meat.SelectedValue = ramen.MeatId.ToString();
                Broth.Text = ramen.Broth;
                Price.Text = ramen.Price;
                ID.Value = ramen.RamenId.ToString();
            }
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(ID.Value);
            string name = Name.Text;
            int meat = int.Parse(Meat.SelectedValue);
            string broth = Broth.Text;
            string price = Price.Text;
            status.Text = RamenController.updateRamen(id, name, meat, broth, price);
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