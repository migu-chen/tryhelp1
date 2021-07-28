using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web728
{
    #region  myRegion
    public partial class Try1 : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("Page_PreInit<br/>");
                    }
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("Page_Init<br/>");
        }
        protected void Page_PreLoad(object sender, EventArgs e)
        {
            Response.Write("Page_PreLoad<br/>");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Page_Load<br/>");
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("Page_PreRendert<br/>");
        }
        protected void Page_Render(object sender, EventArgs e)
        {
            Response.Write("Page_Render<br/>");
        }
  #endregion
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Button1_Click<br/>");
        }
        protected  void DropDownList1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Write("DropDownList1_OnSelectedIndexChanged<br/>");
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Write("RadioButtonList1_SelectedIndexChanged<br/>");
        }
          

        protected void Button1_Init1(object sender, EventArgs e)
        {
            Response.Write("Button1_Init1<br/>");
        }

        protected void DropDownList1_Init1(object sender, EventArgs e)
        {
           Response.Write("DropDownList1_Init1<br/>");
        }

        protected void RadioButtonList1_Init(object sender, EventArgs e)
        {
           Response.Write("RadioButtonList1_Init<br/>");
         }
    }
  
}