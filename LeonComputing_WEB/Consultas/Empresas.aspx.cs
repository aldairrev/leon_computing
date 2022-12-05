using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LeonComputing_BL;
using LeonComputing_BE;
using System.Data;

namespace LeonComputing_WEB.Consultas
{
    public partial class Empresas : System.Web.UI.Page
    {
        BusinessBL businessBL = new BusinessBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            List<BusinessBE> businesses = businessBL.getAll();
            System.Diagnostics.Debug.WriteLine(" businesses.Count " + businesses.Count);
            DataTable dt = new DataTable();
            dt.Columns.Add("name");
            dt.Columns.Add("url");
            dt.Columns.Add("code_id");

            foreach (BusinessBE business in businesses ?? new List<BusinessBE>())
            {
                dt.Rows.Add(business.Name);
                dt.Rows.Add(business.Url);
                dt.Rows.Add(business.Code_id);
            }
            empresasData.DataSource = businesses;
            empresasData.DataBind();
        }
    }
}