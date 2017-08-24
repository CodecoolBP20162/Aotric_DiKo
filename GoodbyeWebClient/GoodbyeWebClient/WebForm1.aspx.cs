using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GoodbyeWebClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        

        protected void Button1_Click1(object sender, EventArgs e)
        {
            ServiceReference1.GoodbyeServiceClient client = new ServiceReference1.GoodbyeServiceClient("BasicHttpBinding_IGoodbyeService");
            Label1.Text = client.GetMessage(TextBox1.Text);

        }
    }
}