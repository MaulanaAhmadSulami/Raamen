using Raamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Raamen.View
{
    public partial class Adminhome : System.Web.UI.Page
    {
        private Model.Database1Entities db = new Model.Database1Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            // biar gabisa lewat url
            if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                User user;
                //make new session when expired
                if(Session["user"] == null)
                {
                    var id = Request.Cookies["user_cookie"].Value;
                    user = (from x in db.Users where x.CustomerId.ToString() == id select x).FirstOrDefault();
                    Session["user"] = user;
                }
                else
                {
                    user = (User) Session["user"];
                }

                name.Text = user.Username;
            }
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