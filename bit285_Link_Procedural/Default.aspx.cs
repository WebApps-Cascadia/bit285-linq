using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LinqToStudentsDataContext linqStud = new LinqToStudentsDataContext();
        var allstudents = from stud in linqStud.Students
                          where stud.StudentID != null

                          select stud;
        GridView1.DataSource = allstudents;

        GridView1.DataBind();
    }
}