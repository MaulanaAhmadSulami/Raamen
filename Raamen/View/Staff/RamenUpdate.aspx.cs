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
            if (!IsPostBack)
            {
                string id = Request.QueryString["id"];
                Raman ramen = RamenController.getRamenbyId(int.Parse(id));
                if (ramen != null)
                {
                    NameTxt.Text = ramen.Name;
                    MeatDrop.SelectedValue = ramen.MeatId.ToString();
                    BrothTxt.Text = ramen.Broth;
                    PriceTxt.Text = ramen.Price;
                    ID.Value = ramen.RamenId.ToString();
                }
            }
        }

        protected void backButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("RamenManage.aspx");
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(ID.Value);
            string name = NameTxt.Text;
            int meat = int.Parse(MeatDrop.SelectedValue);
            string broth = BrothTxt.Text;
            string price = PriceTxt.Text;
            statusTxt.Text = RamenController.updateRamen(id, name, meat, broth, price);
            if (statusTxt.Text.Equals("Success"))
            {
                Response.Redirect("RamenManage.aspx");
            }
        }
    }
}