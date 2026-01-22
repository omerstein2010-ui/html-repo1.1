using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace idkwhatWeb2._2.aspx_pages
{
    public partial class HomePageNLogin : System.Web.UI.Page
    {
        protected string msg;
        protected string ncn;
        protected string var1;
        //protected List<string> l2;
        protected void Page_Load(object sender, EventArgs e)
        {
            //msg = Request.Form["idkwhatxtarCs1"];
            //ncn = Request.Form["idkwhatxtarCs3"];
            //var l1 = new List<string>();
            //msg = Request.Form["idkwhatxtarCs1"];
            //ncn = Request.Form["idkwhatxtarCs3"];
            //l1.Add(msg);
            //l1.Add(ncn);
            //Session["msg"] = l1;
            ////var1 = Session["var1"] as string;
            //if (var1 != null)
            //{
            //    //msg = null;
            //    //ncn = null;
            //}

            //var x = Request.Form["idkwhatxtar6"];
            //if (x == "y")
            //{
            //    //ScriptManager.RegisterStartupScript("")
            //}
            var l1 = new List<string>();
            msg = Request.Form["idkwhatxtarCs4"];
            ncn = Request.Form["idkwhatxtarCs3"];
            l1.Add(msg);
            l1.Add(ncn);
            Console.WriteLine($"{l1[0]}");
            Session["msg"] = l1;

        }
    }
}