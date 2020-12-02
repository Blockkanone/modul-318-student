using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Device.Location;

namespace SBBTopSecretFormsApp
{

    public partial class Form3 : Form
    {

        ITransport _transport = new Transport();
        public Form3(StationBoardRoot depatureStationPanel, string station, Connections connectionResult1, Connections connectionResult2, Connections connectionResult3, Connections connectionResult4)
        {

            InitializeComponent();


            var depatureDateTime1 = DateTime.Parse(depatureStationPanel.Entries[0].Stop.Departure.ToString());

            var depatureDateTime2 = DateTime.Parse(depatureStationPanel.Entries[1].Stop.Departure.ToString());

            var depatureDateTime3 = DateTime.Parse(depatureStationPanel.Entries[2].Stop.Departure.ToString());

            var depatureDateTime4 = DateTime.Parse(depatureStationPanel.Entries[3].Stop.Departure.ToString());


            depatureStation.Text = Convert.ToString(station);


            arrivalStationtbx1.Text = Convert.ToString(depatureStationPanel.Entries[0].To);

            depatureDatetbx1.Text = depatureDateTime1.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
            depatureTimetbx1.Text = depatureDateTime1.ToString("HH:mm", CultureInfo.InvariantCulture);

            depatureStationNrtbx1.Text = Convert.ToString(connectionResult1.ConnectionList[0].From.Platform);
            if (depatureStationPanel.Entries[0].Category == "B")
            {
                depatureLinetbx1.Text = Convert.ToString(depatureStationPanel.Entries[0].Number);
            }
            else
            {
                depatureLinetbx1.Text = Convert.ToString(depatureStationPanel.Entries[0].Name);
            }



            arrivalStationtbx2.Text = Convert.ToString(depatureStationPanel.Entries[1].To);

            depatureDatetbx2.Text = depatureDateTime2.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
            depatureTimetbx2.Text = depatureDateTime2.ToString("HH:mm", CultureInfo.InvariantCulture);

            depatureStationNrtbx2.Text = Convert.ToString(connectionResult2.ConnectionList[0].From.Platform);

            if (depatureStationPanel.Entries[1].Category == "B")
            {
                depatureLinetbx2.Text = Convert.ToString(depatureStationPanel.Entries[1].Number);
            }
            else
            {
                depatureLinetbx2.Text = Convert.ToString(depatureStationPanel.Entries[1].Name);
            }



            arrivalStationtbx3.Text = Convert.ToString(depatureStationPanel.Entries[2].To);

            depatureDatetbx3.Text = depatureDateTime3.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
            depatureTimetbx3.Text = depatureDateTime3.ToString("HH:mm", CultureInfo.InvariantCulture);

            depatureStationNrtbx3.Text = Convert.ToString(connectionResult3.ConnectionList[0].From.Platform);

            if (depatureStationPanel.Entries[2].Category == "B")
            {
                depatureLinetbx3.Text = Convert.ToString(depatureStationPanel.Entries[2].Number);
            }
            else
            {
                depatureLinetbx3.Text = Convert.ToString(depatureStationPanel.Entries[2].Name);
            }



            arrivalStationtbx4.Text = Convert.ToString(depatureStationPanel.Entries[3].To);

            depatureDatetbx4.Text = depatureDateTime4.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
            depatureTimetbx4.Text = depatureDateTime4.ToString("HH:mm", CultureInfo.InvariantCulture);

            depatureStationNrtbx4.Text = Convert.ToString(connectionResult4.ConnectionList[0].From.Platform);

            if (depatureStationPanel.Entries[3].Category == "B")
            {
                depatureLinetbx4.Text = Convert.ToString(depatureStationPanel.Entries[3].Number);
            }
            else
            {
                depatureLinetbx4.Text = Convert.ToString(depatureStationPanel.Entries[3].Name);
            }
            var condition = depatureStationPanel.Entries[0].Category;
            if (condition == "B")
            {
                depatureTypetbx1.Text = "Bus";
            }
            else
            {
                depatureTypetbx1.Text = "Zug";
            }
            if (condition == "B")
            {

                depatureTypetbx2.Text = "Bus";
            }
            else
            {
                depatureTypetbx2.Text = "Zug";
            }
            if (condition == "B")
            {

                depatureTypetbx3.Text = "Bus";
            }
            else
            {
                depatureTypetbx3.Text = "Zug";
            }
            if (condition == "B")
            {

                depatureTypetbx4.Text = "Bus";
            }
            else
            {
                depatureTypetbx4.Text = "Zug";
            }
            var LatInicial = depatureStationPanel.Station.Coordinate.XCoordinate;
            var LngInicial = depatureStationPanel.Station.Coordinate.YCoordinate;
            depatureStationPanelGmap.DragButton = MouseButtons.Left;
            depatureStationPanelGmap.CanDragMap = true;
            depatureStationPanelGmap.MapProvider = GMapProviders.GoogleMap;
            depatureStationPanelGmap.Position = new PointLatLng(LatInicial, LngInicial);
            depatureStationPanelGmap.MinZoom = 0;
            depatureStationPanelGmap.MaxZoom = 24;
            depatureStationPanelGmap.Zoom = 10;
            depatureStationPanelGmap.AutoScroll = true;

            GMapOverlay markersOverlay = new GMapOverlay("markers");
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(LatInicial, LngInicial),
              GMarkerGoogleType.green);
            markersOverlay.Markers.Clear();
            markersOverlay.Markers.Add(marker);
            depatureStationPanelGmap.Overlays.Add(markersOverlay);
            
            
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();

            watcher.TryStart(false, TimeSpan.FromMilliseconds(1000));

            GeoCoordinate coord = watcher.Position.Location;

            if (coord.IsUnknown != true)
            {
                GMarkerGoogle OwnMarker = new GMarkerGoogle(new PointLatLng(coord.Latitude, coord.Longitude),
              GMarkerGoogleType.red);
                markersOverlay.Markers.Add(OwnMarker);
                depatureStationPanelGmap.Overlays.Add(markersOverlay);
            }
            
        }

        private void reload_Click(object sender, EventArgs e)
        {
            var StationId = _transport.GetStations(query: depatureStation.Text);
            var Station = StationId.StationList[0].Name;
            var depatureStationPanel = _transport.GetStationBoard(station: depatureStation.Text, id: StationId.StationList[0].Id);

            if (depatureStation.Text != "")
            {
                var depatureTextResult = _transport.GetStations(query: depatureStation.Text);
                string depatureText = depatureTextResult.StationList[0].Name;

                DateTime dateSearchConnection = DateTime.Now;
                string YearSearch = dateSearchConnection.Year.ToString();
                string MonthSearch = dateSearchConnection.Month.ToString();
                string DaySearch = dateSearchConnection.Day.ToString();
                string HourSearch = dateSearchConnection.Hour.ToString();
                string MinuteSearch = dateSearchConnection.Minute.ToString();

                if (MonthSearch == "1" || MonthSearch == "2" || MonthSearch == "3" || MonthSearch == "4" || MonthSearch == "5" || MonthSearch == "6" || MonthSearch == "7" || MonthSearch == "8" || MonthSearch == "9")
                {
                    MonthSearch = "0" + MonthSearch;
                }

                if (DaySearch == "1" || DaySearch == "2" || DaySearch == "3" || DaySearch == "4" || DaySearch == "5" || DaySearch == "6" || DaySearch == "7" || DaySearch == "8" || DaySearch == "9")
                {
                    DaySearch = "0" + DaySearch;
                }

                string DateSearchConnections = YearSearch + "-" + MonthSearch + "-" + DaySearch;
                string TimeSearchConnections = HourSearch + ":" + MinuteSearch;

                var connectionResult1 = _transport.GetConnections(fromStation: depatureStation.Text, toStattion: depatureStationPanel.Entries[0].To, date: DateSearchConnections, time: TimeSearchConnections);
                var connectionResult2 = _transport.GetConnections(fromStation: depatureStation.Text, toStattion: depatureStationPanel.Entries[1].To, date: DateSearchConnections, time: TimeSearchConnections);
                var connectionResult3 = _transport.GetConnections(fromStation: depatureStation.Text, toStattion: depatureStationPanel.Entries[2].To, date: DateSearchConnections, time: TimeSearchConnections);
                var connectionResult4 = _transport.GetConnections(fromStation: depatureStation.Text, toStattion: depatureStationPanel.Entries[3].To, date: DateSearchConnections, time: TimeSearchConnections);



                var depatureDateTime1 = DateTime.Parse(depatureStationPanel.Entries[0].Stop.Departure.ToString());

                var depatureDateTime2 = DateTime.Parse(depatureStationPanel.Entries[1].Stop.Departure.ToString());

                var depatureDateTime3 = DateTime.Parse(depatureStationPanel.Entries[2].Stop.Departure.ToString());

                var depatureDateTime4 = DateTime.Parse(depatureStationPanel.Entries[3].Stop.Departure.ToString());




                arrivalStationtbx1.Text = Convert.ToString(depatureStationPanel.Entries[0].To);

                depatureDatetbx1.Text = depatureDateTime1.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
                depatureTimetbx1.Text = depatureDateTime1.ToString("HH:mm", CultureInfo.InvariantCulture);

                depatureStationNrtbx1.Text = Convert.ToString(connectionResult1.ConnectionList[0].From.Platform);
                if (depatureStationPanel.Entries[0].Category == "B")
                {
                    depatureLinetbx1.Text = Convert.ToString(depatureStationPanel.Entries[0].Number);
                }
                else
                {
                    depatureLinetbx1.Text = Convert.ToString(depatureStationPanel.Entries[0].Name);
                }



                arrivalStationtbx2.Text = Convert.ToString(depatureStationPanel.Entries[1].To);

                depatureDatetbx2.Text = depatureDateTime2.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
                depatureTimetbx2.Text = depatureDateTime2.ToString("HH:mm", CultureInfo.InvariantCulture);

                depatureStationNrtbx2.Text = Convert.ToString(connectionResult2.ConnectionList[0].From.Platform);

                if (depatureStationPanel.Entries[1].Category == "B")
                {
                    depatureLinetbx2.Text = Convert.ToString(depatureStationPanel.Entries[1].Number);
                }
                else
                {
                    depatureLinetbx2.Text = Convert.ToString(depatureStationPanel.Entries[1].Name);
                }



                arrivalStationtbx3.Text = Convert.ToString(depatureStationPanel.Entries[2].To);

                depatureDatetbx3.Text = depatureDateTime3.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
                depatureTimetbx3.Text = depatureDateTime3.ToString("HH:mm", CultureInfo.InvariantCulture);

                depatureStationNrtbx3.Text = Convert.ToString(connectionResult3.ConnectionList[0].From.Platform);

                if (depatureStationPanel.Entries[2].Category == "B")
                {
                    depatureLinetbx3.Text = Convert.ToString(depatureStationPanel.Entries[2].Number);
                }
                else
                {
                    depatureLinetbx3.Text = Convert.ToString(depatureStationPanel.Entries[2].Name);
                }



                arrivalStationtbx4.Text = Convert.ToString(depatureStationPanel.Entries[3].To);

                depatureDatetbx4.Text = depatureDateTime4.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
                depatureTimetbx4.Text = depatureDateTime4.ToString("HH:mm", CultureInfo.InvariantCulture);

                depatureStationNrtbx4.Text = Convert.ToString(connectionResult4.ConnectionList[0].From.Platform);

                if (depatureStationPanel.Entries[3].Category == "B")
                {
                    depatureLinetbx4.Text = Convert.ToString(depatureStationPanel.Entries[3].Number);
                }
                else
                {
                    depatureLinetbx4.Text = Convert.ToString(depatureStationPanel.Entries[3].Name);
                }


                var condition = depatureStationPanel.Entries[0].Category;
                if (condition == "B")
                {
                    depatureTypetbx1.Text = "Bus";
                }
                else
                {
                    depatureTypetbx1.Text = "Zug";
                }
                if (condition == "B")
                {

                    depatureTypetbx2.Text = "Bus";
                }
                else
                {
                    depatureTypetbx2.Text = "Zug";
                }
                if (condition == "B")
                {

                    depatureTypetbx3.Text = "Bus";
                }
                else
                {
                    depatureTypetbx3.Text = "Zug";
                }
                if (condition == "B")
                {

                    depatureTypetbx4.Text = "Bus";
                }
                else
                {
                    depatureTypetbx4.Text = "Zug";
                }
                var LatInicial = depatureStationPanel.Station.Coordinate.XCoordinate;
                var LngInicial = depatureStationPanel.Station.Coordinate.YCoordinate;
                depatureStationPanelGmap.DragButton = MouseButtons.Left;
                depatureStationPanelGmap.CanDragMap = true;
                depatureStationPanelGmap.MapProvider = GMapProviders.GoogleMap;
                depatureStationPanelGmap.Position = new PointLatLng(LatInicial, LngInicial);
                depatureStationPanelGmap.MinZoom = 0;
                depatureStationPanelGmap.MaxZoom = 24;
                depatureStationPanelGmap.Zoom = 10;
                depatureStationPanelGmap.AutoScroll = true;

                GMapOverlay markersOverlay = new GMapOverlay("markers");
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(LatInicial, LngInicial),
                  GMarkerGoogleType.green);
                markersOverlay.Markers.Clear();
                markersOverlay.Markers.Add(marker);
                depatureStationPanelGmap.Overlays.Add(markersOverlay);


                GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();

                watcher.TryStart(false, TimeSpan.FromMilliseconds(10000));

                GeoCoordinate coord = watcher.Position.Location;

                if (coord.IsUnknown != true)
                {
                    GMarkerGoogle OwnMarker = new GMarkerGoogle(new PointLatLng(coord.Latitude, coord.Longitude),
                  GMarkerGoogleType.red);
                    markersOverlay.Markers.Add(OwnMarker);
                    depatureStationPanelGmap.Overlays.Add(markersOverlay);
                }
            }
        }
    }
}
