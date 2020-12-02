using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBBTopSecretFormsApp
{

    public partial class Form2 : Form
    {
        ITransport _transport = new Transport();
        public Form2(Connections connectionResult, StationBoardRoot depatureStationPanel)
        {
            InitializeComponent();
            // Verschiedene Zeiten zum anzeigen werden erstellt
            var depatureDateTime1 = DateTime.Parse(connectionResult.ConnectionList[0].From.Departure);
            var arrivalDateTime1 = DateTime.Parse(connectionResult.ConnectionList[0].To.Arrival);

            var depatureDateTime2 = DateTime.Parse(connectionResult.ConnectionList[1].From.Departure);
            var arrivalDateTime2 = DateTime.Parse(connectionResult.ConnectionList[1].To.Arrival);

            var depatureDateTime3 = DateTime.Parse(connectionResult.ConnectionList[2].From.Departure);
            var arrivalDateTime3 = DateTime.Parse(connectionResult.ConnectionList[2].To.Arrival);

            var depatureDateTime4 = DateTime.Parse(connectionResult.ConnectionList[3].From.Departure);
            var arrivalDateTime4 = DateTime.Parse(connectionResult.ConnectionList[3].To.Arrival);

            // Alles wird bei der ersten Verbindung in die Textfelder eingefügt

            depatureStation1.Text = Convert.ToString(connectionResult.ConnectionList[0].From.Station.Name);
            arrivalStation1.Text = Convert.ToString(connectionResult.ConnectionList[0].To.Station.Name);

            depatureDatetbx1.Text = depatureDateTime1.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
            arrivalDatetbx1.Text = arrivalDateTime1.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
            depatureTimetbx1.Text = depatureDateTime1.ToString("HH:mm", CultureInfo.InvariantCulture);
            arrivalTimetbx1.Text = arrivalDateTime1.ToString("HH:mm", CultureInfo.InvariantCulture);

            depatureStationNrtbx1.Text = Convert.ToString(connectionResult.ConnectionList[0].From.Platform);
            arrivalStationNrtbx1.Text = Convert.ToString(connectionResult.ConnectionList[0].To.Platform);

            if (depatureStationPanel.Entries[0].Category == "B")
            {
                depatureLinetbx1.Text = Convert.ToString(depatureStationPanel.Entries[0].Number);
                arrivalLinetbx1.Text = Convert.ToString(depatureStationPanel.Entries[0].Number);
            }
            else
            {
                depatureLinetbx1.Text = Convert.ToString(depatureStationPanel.Entries[0].Name);
                arrivalLinetbx1.Text = Convert.ToString(depatureStationPanel.Entries[0].Name);
            }



            // Die Typen werden überprüft und eingefügt
            var condition = depatureStationPanel.Entries[0].Category;
            if (condition == "B")
            {

                depatureTypetbx1.Text = "Bus";
                arrivalTypetbx1.Text = "Bus";
            }
            else
            {
                depatureTypetbx1.Text = "Zug";
                arrivalTypetbx1.Text = "Zug";
            }
            if (condition == "B")
            {

                depatureTypetbx2.Text = "Bus";
                arrivalTypetbx2.Text = "Bus";
            }
            else
            {
                depatureTypetbx2.Text = "Zug";
                arrivalTypetbx2.Text = "Zug";
            }
            if (condition == "B")
            {

                depatureTypetbx3.Text = "Bus";
                arrivalTypetbx3.Text = "Bus";
            }
            else
            {
                depatureTypetbx3.Text = "Zug";
                arrivalTypetbx3.Text = "Zug";
            }
            if (condition == "B")
            {

                depatureTypetbx4.Text = "Bus";
                arrivalTypetbx4.Text = "Bus";
            }
            else
            {
                depatureTypetbx4.Text = "Zug";
                arrivalTypetbx4.Text = "Zug";
            }


            // Alles wird bei der zweiten Verbindung in die Textfelder eingefügt


            depatureStation2.Text = Convert.ToString(connectionResult.ConnectionList[1].From.Station.Name);
            arrivalStation2.Text = Convert.ToString(connectionResult.ConnectionList[1].To.Station.Name);

            depatureDatetbx2.Text = depatureDateTime2.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
            arrivalDatetbx2.Text = arrivalDateTime2.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
            depatureTimetbx2.Text = depatureDateTime2.ToString("HH:mm", CultureInfo.InvariantCulture);
            arrivalTimetbx2.Text = arrivalDateTime2.ToString("HH:mm", CultureInfo.InvariantCulture);

            depatureStationNrtbx2.Text = Convert.ToString(connectionResult.ConnectionList[1].From.Platform);
            arrivalStationNrtbx2.Text = Convert.ToString(connectionResult.ConnectionList[1].To.Platform);

            if (depatureStationPanel.Entries[0].Category == "B")
            {
                depatureLinetbx2.Text = Convert.ToString(depatureStationPanel.Entries[0].Number);
                arrivalLinetbx2.Text = Convert.ToString(depatureStationPanel.Entries[0].Number);
            }
            else
            {
                depatureLinetbx2.Text = Convert.ToString(depatureStationPanel.Entries[0].Name);
                arrivalLinetbx2.Text = Convert.ToString(depatureStationPanel.Entries[0].Name);
            }

            // Alles wird bei der dritten Verbindung in die Textfelder eingefügt

            depatureStation3.Text = Convert.ToString(connectionResult.ConnectionList[2].From.Station.Name);
            arrivalStation3.Text = Convert.ToString(connectionResult.ConnectionList[2].To.Station.Name);

            depatureDatetbx3.Text = depatureDateTime3.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
            arrivalDatetbx3.Text = arrivalDateTime3.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
            depatureTimetbx3.Text = depatureDateTime3.ToString("HH:mm", CultureInfo.InvariantCulture);
            arrivalTimetbx3.Text = arrivalDateTime3.ToString("HH:mm", CultureInfo.InvariantCulture);

            depatureStationNrtbx3.Text = Convert.ToString(connectionResult.ConnectionList[2].From.Platform);
            arrivalStationNrtbx3.Text = Convert.ToString(connectionResult.ConnectionList[2].To.Platform);

            if (depatureStationPanel.Entries[0].Category == "B")
            {
                depatureLinetbx3.Text = Convert.ToString(depatureStationPanel.Entries[0].Number);
                arrivalLinetbx3.Text = Convert.ToString(depatureStationPanel.Entries[0].Number);
            }
            else
            {
                depatureLinetbx3.Text = Convert.ToString(depatureStationPanel.Entries[0].Name);
                arrivalLinetbx3.Text = Convert.ToString(depatureStationPanel.Entries[0].Name);
            }

            // Alles wird bei der vierten Verbindung in die Textfelder eingefügt

            depatureStation4.Text = Convert.ToString(connectionResult.ConnectionList[3].From.Station.Name);
            arrivalStation4.Text = Convert.ToString(connectionResult.ConnectionList[3].To.Station.Name);

            depatureDatetbx4.Text = depatureDateTime4.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
            arrivalDatetbx4.Text = arrivalDateTime4.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
            depatureTimetbx4.Text = depatureDateTime4.ToString("HH:mm", CultureInfo.InvariantCulture);
            arrivalTimetbx4.Text = arrivalDateTime4.ToString("HH:mm", CultureInfo.InvariantCulture);

            depatureStationNrtbx4.Text = Convert.ToString(connectionResult.ConnectionList[3].From.Platform);
            arrivalStationNrtbx4.Text = Convert.ToString(connectionResult.ConnectionList[3].To.Platform);

            if (depatureStationPanel.Entries[0].Category == "B")
            {
                depatureLinetbx4.Text = Convert.ToString(depatureStationPanel.Entries[0].Number);
                arrivalLinetbx4.Text = Convert.ToString(depatureStationPanel.Entries[0].Number);
            }
            else
            {
                depatureLinetbx4.Text = Convert.ToString(depatureStationPanel.Entries[0].Name);
                arrivalLinetbx4.Text = Convert.ToString(depatureStationPanel.Entries[0].Name);
            }
        }
 
        // Event, wenn auf den Als Email versenden Knopf gedrückt wird
            private void emailbtn_Click(object sender, EventArgs e)
            {
            // Email wird versendet
                    Process.Start(
                    "mailto:" + emailtbx.Text +
                    "?subject=" + "Verbindung Teilen" +
                    "&body=" + 
                    "Verbindung 1 " + "Von: " + depatureStation1.Text + " Bis: " + arrivalStation1 + " Datum: " + depatureDatetbx1 + " Uhrzeit: " + depatureTimetbx1 + " Typ: " + depatureTypetbx1 + " Linie: " + depatureLinetbx1 + " Abfahrtsgleis: " + depatureStationNrtbx1 + "Ankunftsgleis" + arrivalStationNrtbx1 + "/n" +
                    "Verbindung 2 " + "Von: " + depatureStation2.Text + " Bis: " + arrivalStation2 + " Datum: " + depatureDatetbx2 + " Uhrzeit: " + depatureTimetbx2 + " Typ: " + depatureTypetbx2 + " Linie: " + depatureLinetbx2 + " Abfahrtsgleis: " + depatureStationNrtbx2 + "Ankunftsgleis" + arrivalStationNrtbx2 + "/n" +
                    "Verbindung 3 " + "Von: " + depatureStation3.Text + " Bis: " + arrivalStation3 + " Datum: " + depatureDatetbx3 + " Uhrzeit: " + depatureTimetbx3 + " Typ: " + depatureTypetbx3 + " Linie: " + depatureLinetbx3 + " Abfahrtsgleis: " + depatureStationNrtbx3 + "Ankunftsgleis" + arrivalStationNrtbx3 + "/n" +
                    "Verbindung 4 " + "Von: " + depatureStation4.Text + " Bis: " + arrivalStation4 + " Datum: " + depatureDatetbx4 + " Uhrzeit: " + depatureTimetbx4 + " Typ: " + depatureTypetbx4 + " Linie: " + depatureLinetbx4 + " Abfahrtsgleis: " + depatureStationNrtbx4 + "Ankunftsgleis" + arrivalStationNrtbx4 + "/n"
                    );
            // Meldung über den Erfolg
            MessageBox.Show("Email erfolgreich versendet");
        }
    }
    }

