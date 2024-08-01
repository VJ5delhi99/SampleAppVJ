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
    }
}