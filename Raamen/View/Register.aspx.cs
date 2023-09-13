using Raamen.Handler;
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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.EnableViewState = true;
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

            string username = txtUsername.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string gender = ddlGender.Text;
            string conf_password = txtConfirmPassword.Text;
            bool isStaff = Request.QueryString["role"] == "staff";

            string status;
            if (isStaff)
            {
                status = Controller.UserController.RegisterUser(username, email, gender, password, conf_password, true);
            }
            else
            {
                status = Controller.UserController.RegisterUser(username, email, gender, password, conf_password, false);
            }
            lblError.Text = status;

            if(status == "User registered successfully.")
            {
                Response.Redirect("Login.aspx");
            }

        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Welcome.aspx");
        }
    }
}