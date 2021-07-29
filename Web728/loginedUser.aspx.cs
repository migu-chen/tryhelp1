using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web728
{
    public partial class loginedUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Session["LoginUser"] != null)
            {
                this.ItUser.Text = "已登入，目前登錄者:" + Session["LoginedUser"];
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            bool isAccountRight = string.Compare("admin", this.textAccount.Text) == 0;
            bool isPasswordRight = string.Compare("4rfv%TGB", this.textPassword.Text) == 0;
            if(isAccountRight && isPasswordRight)
            {
                this.it
            }
        }

        protected void btnlogin_Click1(object sender, EventArgs e)
        {

        }
    }
}