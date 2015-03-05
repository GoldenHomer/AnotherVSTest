using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Deefault : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlDataSource1.SelectParameters["Name"].DefaultValue = TextBox1.Text;
        SqlDataSource1.SelectParameters["Salary"].DefaultValue = TextBox2.Text;
    }
}