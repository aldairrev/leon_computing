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
    public partial class Cursos : System.Web.UI.Page
    {
        CourseBL courseBL = new CourseBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            List<CourseBE> courses = courseBL.getAll();
            cursosData.DataSource = courses ?? new List<CourseBE>();
            cursosData.DataBind();
        }
    }
}