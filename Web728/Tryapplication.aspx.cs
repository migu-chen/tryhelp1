using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web728
{
    public partial class Tryapplication : System.Web.UI.Page
    {
        public string PageFrom = "test";
        public int PageClickCount = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Lit1Msg.Text = Convert.ToInt32(this.Application["Count"]).ToString();
        }//

        protected void Button1_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            //this.PageClickCount += 1;
            if(this .Application["Count"] == null)
            {
                this.Application["Count"] = 1;
                cnt = 1;
            } 
            else
            {
                cnt = (int)this.Application["Count"];
                cnt += 1;
                this.Application["Count"] = cnt;
            }
            //string val = this.Lit1Msg.Text;
            //int cnt = int.Parse(val);
            this.Application["Count"] = (cnt + 1);
            this.Lit1Msg.Text = (cnt).ToString();
        }
    }
}