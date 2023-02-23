using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TwotierArchitecture
{
    public partial class AllData : System.Web.UI.Page
    {
        ConnectionClass con = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            string query = "select name,age,photo from Register";
            DataSet ds = con.Fun_ExeAdapter(query);
            DataList1.DataSource = ds;
            DataList1.DataBind();
        }
    }
}