using Raamen.Model;
using Raamen.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Raamen.View
{
    public partial class Homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["user_cookie"];

            if (cookie != null)
            {
                string ifCookie = cookie.Value;
                int getId = ifCookie.IndexOf('-') + 1;
                int getUserId = int.Parse(ifCookie.Substring(getId));

                User user = UserRepository.getUserById(getUserId);

                if (user.RoleId == 1)
                {
                    Response.Redirect("Admin/Home.aspx");
                }
                else if (user.RoleId == 3)
                {
                    Response.Redirect("Staff/Home.aspx");
                }
                else if (user.RoleId == 4)
                {
                    Response.Redirect("Customer/Home.aspx");
                }
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }


        protected void btnRegisterStf_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx?role=staff");
        }
    }
}