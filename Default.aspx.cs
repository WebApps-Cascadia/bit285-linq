using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Linq;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        StudentsDatabaseDataContext studentDBC = new StudentsDatabaseDataContext();
        var allstudents = from MyStudent in studentDBC.Students where MyStudent.StudentID > 1 select MyStudent;

        GridView1.DataSource = allstudents;
        GridView1.DataBind();
    }
}