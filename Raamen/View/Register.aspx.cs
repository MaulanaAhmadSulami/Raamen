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
            //string status = Controller.UserController.RegisterUser(username, email, gender, password, conf_password);
            //lblError.Text = status;

            //if(status == "User registered successfully.")
            //{
            //    Response.Redirect("Homepage.aspx");
            //}

        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Homepage.aspx");
        }
    }
}