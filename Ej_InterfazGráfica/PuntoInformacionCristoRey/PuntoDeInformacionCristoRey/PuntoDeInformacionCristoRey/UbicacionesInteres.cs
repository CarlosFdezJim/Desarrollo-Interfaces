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

namespace PuntoDeInformacionCristoRey
{
    public partial class UbicacionesInteres : UserControl
    {
        //Creamos un marcador
        GMarkerGoogle marker;
        //Creamos capa de marcado
        GMapOverlay markerOverlay;

        //Cristo Rey
        double LatInicial = 37.184660801046874;
        double LngInicial = -3.592937626433216;

        //Cafeterías
        double Lat4esquinas = 37.183994756384266;
        double Lng4esquinas = -3.5934579926012633;

        double LatTorcuato = 37.18397297583474;
        double LngTorcuato = -3.593664198773338;

        //Librerías
        double LatLibreriaAlbayzin = 37.18410119051905;
        double LngLibreriaAlbayzin = -3.5937171723999772;

        //Aparcamientos
        double LatAparcamientos = 37.18840447375304;
        double LngAparcamientos = -3.5943378355047697;

        double LatParking = 37.18411652520051;
        double LngParking = -3.595891491879612;

        //Sitios de interés
        double LatElPepe = 37.18387454636741;
        double LngElPepe = -3.596019776884006;

        public UbicacionesInteres()
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
            ShowLocationCristoRey();
        }

        private void bttnCafeterias_Click(object sender, EventArgs e)
        {
            ShowLocations(Lat4esquinas, Lng4esquinas, "Cuatro Esquinas");
            ShowLocations(LatTorcuato, LngTorcuato, "Torcuato");
        }

        private void bttnLibrerias_Click(object sender, EventArgs e)
        {
            ShowLocations(LatLibreriaAlbayzin, LngLibreriaAlbayzin, "Librería Albayzin");
        }

        private void bttnAparcamientos_Click(object sender, EventArgs e)
        {
            ShowLocations(LatAparcamientos, LngAparcamientos, "Placeta Polideportivo Aynadamar");
            ShowLocations(LatParking, LngParking, "Parking San Cristóbal Albaicín");
        }

        private void bttnLugaresDeInteres_Click(object sender, EventArgs e)
        {
            ShowLocations(LatElPepe, LngElPepe, "El Pepe");
        }

        public void ShowLocations(double lat, double lng, string nombre)
        {
            //Marcador
            markerOverlay = new GMapOverlay();
            marker = new GMarkerGoogle(new PointLatLng(lat, lng), GMarkerGoogleType.blue);

            //Agregamos el marcador
            markerOverlay.Markers.Add(marker);

            //Agregamos un toolTip de texto a los marcadores
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker.ToolTipText = string.Format(nombre);

            //Agregamos al mapa el marcador
            gMapControl1.Overlays.Add(markerOverlay);
        }

        public void ShowLocationCristoRey()
        {
            //Marcador
            markerOverlay = new GMapOverlay();
            marker = new GMarkerGoogle(new PointLatLng(LatInicial, LngInicial), GMarkerGoogleType.red);

            //Agregamos el marcador
            markerOverlay.Markers.Add(marker);

            //Agregamos un toolTip de texto a los marcadores
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("CES CRISTO REY");

            //Agregamos al mapa el marcador
            gMapControl1.Overlays.Add(markerOverlay);
        }
    }
}
