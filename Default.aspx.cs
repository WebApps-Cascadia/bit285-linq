using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
		/***************************************************
	    LinkToStudentDataContext linqStudents = new LinkToStudentDataContext();
	    var allStudents =	from student in linqStudents.Students
							where student.StudentID > 0
							select student;

	    GridView1.DataSource = allStudents;
	    GridView1.DataBind();
		*****************************************************/
    }

	protected void Insert(object sender, EventArgs e)
	{
		ListDictionary ld = new ListDictionary();
		ld.Add("FirstName", FirstName.Text);
		ld.Add("LastName", LastName.Text);
		ld.Add("City", City.Text);
		ld.Add("Country", Country.Text);
		ld.Add("Zip", Zip.Text);
		ld.Add("Phone", Phone.Text);

		LinqDataSource1.Insert(ld);

		FirstName.Text = "";
		LastName.Text = "";
		City.Text = "";
		Country.Text = "";
		Zip.Text = "";
		Phone.Text = "";

		GridView1.DataBind();
	}
}