using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace DynamicSQLDemo
{
    public partial class SearchPageWithoutDynamicSQL : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {}

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string connectionStr = ConfigurationManager
                .ConnectionStrings["connectionStr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionStr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd Connection = con;
                cmd CommandText = "spSearchEmployees";
                cmd CommandType = CommandType.StoredProcedure;

                if (inputFirstname.Value.Trim() != "")
                {

                }
            }
        }
    }
}
