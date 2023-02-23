using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TwotierArchitecture
{
    public partial class Profile : System.Web.UI.Page
    {
        ConnectionClass con = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string query = "select count(Id) from Register where username='" + txtUsername.Text + "' and password='" + txtPassword.Text + "'";
            string cid = con.Fun_ExecuteScalar(query);
            if(cid == "1")
            {
                int id1 = 0;
                string qu = "select Id from Register where username='" + txtUsername.Text + "' and password='" + txtPassword.Text + "'";
                SqlDataReader dr=con.Fun_ExecuteReader(qu);
                while (dr.Read())
                {
                    id1=Convert.ToInt32(dr["Id"].ToString());

                }
                Session["uid"] = id1;
                Response.Redirect("ProfileView.aspx");

            }
        }
    }
}