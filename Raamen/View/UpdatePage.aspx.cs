using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Raamen.View
{
    public partial class UpdatePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void logoutBtn_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("user_cookie");
            cookie.Expires = DateTime.Now.AddHours(-1);
            Response.Cookies.Add(cookie);


            Response.Redirect("Homepage.aspx");
        }
    }
}