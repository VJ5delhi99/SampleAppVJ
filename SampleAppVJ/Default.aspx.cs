using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleAppVJ
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTestConnection_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            { 
                string type = txtDatabase.Text.Trim();
                string key = txtUserId.Text.Trim(); 

                 if (type.ToString().ToLower() == "connectionstring")
                {
                    lblStatus.Text = System.Configuration.ConfigurationManager.ConnectionStrings[key].ConnectionString;
                }
                else
                {
                    lblStatus.Text = System.Configuration.ConfigurationManager.AppSettings[key];

                } 
            }
        }

        protected void btnTestConnection1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            { 
                lblStatus.Text = ConfigurationHelper.GetSessionStateSqlConnectionString();
            }
        }

    }
}

public class ConfigurationHelper
{
    public static string GetSessionStateSqlConnectionString()
    {
        // Load the web.config file
        var configFile = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("~/web.config");

        // Get the sessionState section
        var sessionStateSection = (System.Web.Configuration.SessionStateSection)configFile.GetSection("system.web/sessionState");

        // Return the sqlConnectionString attribute value
        return sessionStateSection?.SqlConnectionString;
    }
}
