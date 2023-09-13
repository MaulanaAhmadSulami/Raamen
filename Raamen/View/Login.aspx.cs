using Raamen.Controller;
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
    public partial class Login : System.Web.UI.Page
    {
        private Model.Database1Entities db = new Model.Database1Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            HttpCookie cookie = Request.Cookies["user_cookie"];

            if(cookie != null)
            {
                string ifCookie = cookie.Value;
                int getId = ifCookie.IndexOf('-') + 1;
                int getUserId = int.Parse(ifCookie.Substring(getId));

                User user = UserRepository.getUserById(getUserId);

                if(user.RoleId == 1)
                {
                    Response.Redirect("Admin/Home.aspx");
                }else if(user.RoleId == 3)
                {
                    Response.Redirect("Staff/Home.aspx");
                }else if(user.RoleId == 4)
                {
                    Response.Redirect("Customer/Home.aspx");
                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //string username = txtUsername.Text;
            //string password = txtPassword.Text;
            bool isRemember = RememberMe.Checked;
            //var user = (from x in db.Users where x.Username.Equals(username) && x.Password.Equals(password) select x).FirstOrDefault();
            User user = UserController.UserLogin(txtUsername.Text, txtPassword.Text);

            if(user != null)
            {
                //cookie session
                Session["user"] = user;

                if (isRemember)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");
                    cookie.Value = user.CustomerId.ToString();

                    //expire after 1hr (irl time)
                    cookie.Expires = DateTime.Now.AddHours(1);
                    Response.Cookies.Add(cookie);
                }
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
            else
            {
                lblError.Text = "User not found";
                lblError.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Welcome.aspx");
        }
    }
}