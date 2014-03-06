using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
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
using GMap7.RouteSim;

namespace GMap7
{
    public partial class Form1 : Form
    {
        private PointLatLng gPoint;
        private GMapOverlay markers;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myMap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            myMap.Position = new GMap.NET.PointLatLng(46.25, 20.15);
            markers = new GMapOverlay("markers");
            myMap.Overlays.Add(markers);
        }

        private void myMap_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                gPoint = myMap.FromLocalToLatLng(e.X, e.Y);
                contextMenuStrip1.Show(this, new Point(e.X, e.Y));
            }
        }

        private void add30_Click(object sender, EventArgs e)
        {
            GMarkerGoogle marker = new GMarkerGoogle(gPoint, GMarkerGoogleType.green);
            markers.Markers.Add(marker);
        }

        private void add50_Click(object sender, EventArgs e)
        {
            
        }

        private void add90_Click(object sender, EventArgs e)
        {

        }

        private void add130_Click(object sender, EventArgs e)
        {

        }

        private void destinationMenuItem_Click(object sender, EventArgs e)
        {
            GMarkerGoogle marker = new GMarkerGoogle(gPoint, GMarkerGoogleType.red);
            markers.Markers.Add(marker);
            PointLatLng start = new PointLatLng(markers.Markers[0].Position.Lat, markers.Markers[0].Position.Lng);
            PointLatLng end = new PointLatLng(markers.Markers[1].Position.Lat, markers.Markers[1].Position.Lng);
            MapRoute route = GMap.NET.MapProviders.GoogleMapProvider.Instance.GetRoute(
                start,
                end,
                false,
                false,
                14
            );
            GMapRoute r = new GMapRoute(route.Points, "My route");

            GMapOverlay routesOverlay = new GMapOverlay("routes");
            routesOverlay.Routes.Add(r);
            myMap.Overlays.Add(routesOverlay);

            // Térkép frissítése a route felrakása után, különben csak egy zoomolás után látszik a route.
            myMap.UpdateRouteLocalPosition(r);
            myMap.Invalidate();
        }

        
    }
}
