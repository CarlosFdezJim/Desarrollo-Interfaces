using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;


namespace MiniProyecto
{
    public partial class Form1 : Form
    {
        //Creamos un marcador
        GMarkerGoogle marker;
        //Creamos capa de marcado
        GMapOverlay markerOverlay;
        DataTable dt;
         
        double LatInicial = 37.184660801046874;
        double LngInicial = -3.592937626433216;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gMapControl.DragButton = MouseButtons.Left;
            gMapControl.CanDragMap = true;
            gMapControl.MapProvider = GMapProviders.GoogleMap;
            gMapControl.Position = new PointLatLng(LatInicial, LngInicial);
            gMapControl.MinZoom = 0;
            gMapControl.MaxZoom = 19;
            gMapControl.Zoom = 35;
            gMapControl.AutoScroll = true;

            //Marcador
            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(LatInicial, LngInicial), GMarkerGoogleType.blue);
            //Agregamos el primer marcador
            markerOverlay.Markers.Add(marker);

            //Agregamos un toolTip de texto a los marcadores
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Ubicación: \n Latitud: {0} \n Longitud: {1}", LatInicial, LngInicial);

            //Agregamos al mapa el marcador
            gMapControl.Overlays.Add(markerOverlay);

        }


        private void bttnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
