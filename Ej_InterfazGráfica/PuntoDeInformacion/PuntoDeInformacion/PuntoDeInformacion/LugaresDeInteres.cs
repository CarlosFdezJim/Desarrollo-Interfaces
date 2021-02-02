using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace PuntoDeInformacion
{
    public partial class LugaresDeInteres : UserControl
    {
        //Creamos un marcador
        GMarkerGoogle marker;
        //Creamos capa de marcado
        GMapOverlay markerOverlay;

        double LatInicial = 37.184660801046874;
        double LngInicial = -3.592937626433216;
        public LugaresDeInteres()
        {
            InitializeComponent();
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(LatInicial, LngInicial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 19;
            gMapControl1.Zoom = 35;
            gMapControl1.AutoScroll = true;
        }

        private void bttnCafeterias_Click(object sender, EventArgs e)
        {
            showCoffeShop();
        }

        public void showCoffeShop()
        {

            double Lat4esquinas = 37.183994756384266;
            double Lng4esquinas = -3.5934579926012633;

            //Marcador
            GMapOverlay markerOverlay = new GMapOverlay("Cuatro Esquinas");
            GMarkerGoogle marker4esquinas = new GMarkerGoogle(new PointLatLng(Lat4esquinas, Lng4esquinas), GMarkerGoogleType.blue);

            //Agregamos el primer marcador
            markerOverlay.Markers.Add(marker4esquinas); 

            //Agregamos un toolTip de texto a los marcadores
            marker4esquinas.ToolTipMode = MarkerTooltipMode.Always;
            marker4esquinas.ToolTipText = string.Format("Cuatro Esquinas");

            //Agregamos al mapa el marcador
            gMapControl1.Overlays.Add(markerOverlay);

        }
    }
}
