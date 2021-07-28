using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web728
{
    public partial class TrySession : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Ltlmag.Text = Convert.ToInt32(this.Session["Count"]).ToString();
        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            //this.PageClickCount += 1;
            if (this.Session["Count"] == null)
            {
                this.Session ["Count"] = 1;
                cnt = 1;
            }
            else
            {
                cnt = (int)this.Session["Count"];
                cnt += 1;
                this.Application["Count"] = cnt;
            }
            //string val = this.Lit1Msg.Text;
            //int cnt = int.Parse(val);
            // this.Application["Count"] = (cnt + 1);
            this.Ltlmag.Text = (cnt).ToString();
        }
    }
}