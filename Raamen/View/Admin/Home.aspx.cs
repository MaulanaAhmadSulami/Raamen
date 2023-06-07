using Raamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Raamen.View.Admin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private Model.Database1Entities db = new Model.Database1Entities();
        protected void Page_Load(object sender, EventArgs e)
        {

            // load data for gridview
            cust_GV.DataSource = Repository.UserRepository.GetCustomers();
            cust_GV.DataBind();
            staff_GV.DataSource = Repository.UserRepository.GetStaffs();
            staff_GV.DataBind();
        }
    }
}