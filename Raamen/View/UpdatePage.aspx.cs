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
    public partial class UpdatePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int CustomerId = getUserIdFromSession();

                if(CustomerId != 0)
                {
                    User user = UserRepository.getUserById(CustomerId);
                    if (user != null)
                    {
                        txtUsername.Text = user.Username;
                        txtEmail.Text = user.Email;
                        string gender = user.Gender;
                        if (!string.IsNullOrEmpty(gender))
                        {
                            if (gender.Equals("Male", StringComparison.OrdinalIgnoreCase))
                            {
                                rbMale.Checked = true;
                            }
                            else if (gender.Equals("Female", StringComparison.OrdinalIgnoreCase))
                            {
                                rbFemale.Checked = true;
                            }
                        }
                        txtPassword.Text = user.Password;
                    }
                }
            }
        }

        protected void logoutBtn_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("user_cookie");
            cookie.Expires = DateTime.Now.AddHours(-1);
            Response.Cookies.Add(cookie);


            Response.Redirect("Homepage.aspx");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int CustomerId = getUserIdFromSession();

            if(CustomerId != 0)
            {
                string username = txtUsername.Text;
                string email = txtEmail.Text;
                string gender = string.Empty;
                if (rbMale.Checked)
                {
                    gender = rbMale.Text;
                }
                else if (rbFemale.Checked)
                {
                    gender = rbFemale.Text;
                }
                string password = txtPassword.Text;

                string result = UserController.UpdateUserProfile(CustomerId, username, email, gender, password);
                lblMessage.Text = result;
            }
        }

        private int getUserIdFromSession()
        {
            if (Session["user"] != null)
            {
                User user = (User)Session["user"];
                return user.CustomerId;
            }
            return 0;
        }
    }
}