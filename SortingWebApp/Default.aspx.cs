using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SortingService.Service2Client service1 = new SortingService.Service2Client(); //instantiating service1
            Label1.Text = service1.sort(TextBox2.Text); //invoking sort operation on the list of numbers in input textbox
        }
    }
}