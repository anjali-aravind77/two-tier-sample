using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TwotierArchitecture
{
    public partial class Page1 : System.Web.UI.Page
    {
        ConnectionClass objClass = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string path = "~/Photos/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(path));
            string strInsert = "Insert into Register values('" + txtName.Text + "'," + txtAge.Text + ",'" + txtAddress.Text + "','" + path + "','" + txtUsername.Text + "','" + txtPassword.Text + "')";
            int i = objClass.Fun_ExecuteNonQuery(strInsert);
            if (i != 0)
            {
                lblText.Text = "1 record inserted";
            }
        }

        protected void btnViewall_Click(object sender, EventArgs e)
        {
            Response.Redirect("AllData.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }
    }
}