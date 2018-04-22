using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Security;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string JQueryVer = "1.7.1";
        ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
        {
            Path = "~/Scripts/jquery-" + JQueryVer + ".min.js",
            DebugPath = "~/Scripts/jquery-" + JQueryVer + ".js",
            CdnPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-" + JQueryVer + ".min.js",
            CdnDebugPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-" + JQueryVer + ".js",
            CdnSupportsSecureConnection = true,
            LoadSuccessExpression = "window.jQuery"
        });


    }
    

    protected void userRegister1(object sender, EventArgs e)
    {
        string constr = ConfigurationManager.ConnectionStrings["Khulna_website"].ConnectionString;
        using (SqlConnection connection = new SqlConnection(constr))
        {
            string insertQuery = "insert into dbo.users(user_f_name,user_l_name,user_password,user_email,user_age, user_gender) values (@First_Name, @Last_Name, @Regi_Password, @Regi_Email, @Age, @Gender);";

            SqlCommand com = new SqlCommand(insertQuery, connection);

            connection.Open();

            com.Parameters.AddWithValue("@First_Name", First_Name.Text);
            com.Parameters.AddWithValue("@Last_Name", Last_Name.Text);
            com.Parameters.AddWithValue("@Regi_Password", Regi_Password.Text);
            com.Parameters.AddWithValue("@Regi_Email", Regi_Email.Text);
            com.Parameters.AddWithValue("@Age", Age.Text);
            com.Parameters.AddWithValue("@Gender", Gender.SelectedValue);

            com.ExecuteNonQuery();
        }
    }
}