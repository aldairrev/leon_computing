using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LeonComputing_BL;
using LeonComputing_BE;
using System.Data;
using System.Web.UI.DataVisualization.Charting;
using System.Threading;

namespace LeonComputing_WEB.Consultas
{
    public partial class Eventos : System.Web.UI.Page
    {
        EventBL eventBL = new EventBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            dataChart.Titles.Add("Eventos Capacidades");
            dataChart.Palette = ChartColorPalette.Berry;

            List<EventBE> events = eventBL.getTenBestCapacity();

            for (int i = 0; i < events.Count; i++)
            {
                Series series = new Series($"[{i}] " + events[i].Name);
                series.Label = events[i].Name;
                series.Points.Add(events[i].Capacity);
                dataChart.Series.Add(series);
            }
            dataChart.DataBind();
        }
    }

}