using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TwotierArchitecture
{
    public partial class ProfileView : System.Web.UI.Page
    {
        ConnectionClass connectionClass = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            string query = "select name,age,address,photo from Register where Id=" + Session["uid"] + "";
            SqlDataReader dr = connectionClass.Fun_ExecuteReader(query);
            while(dr.Read())
            {
                lblName.Text = dr["name"].ToString();
                lblAge.Text = dr["age"].ToString();
                lblPhone.Text = dr["address"].ToString();
                Image1.ImageUrl = dr["photo"].ToString();
            }
        }
    }
}