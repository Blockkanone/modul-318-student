using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBBTopSecretFormsApp
{
    public partial class Form1 : Form
    {
        // Membervariable _transport wird erstellt
        ITransport _transport = new Transport();


        public Form1()
        {
            InitializeComponent();
            // Das aktuelle Datum wird in das Datumtext feld eingefügt
            dateSearch.Text = DateTime.Now.ToShortDateString();
            timeSearch.Text = DateTime.Now.ToShortTimeString();
        }

        // Array für den Verlauf wird erstellt
        string[] depatureHistory = new string[200];
        string[] arrivalHistory = new string[200];
        int counter = 199;

        // Event, wenn der Suchen Knopf gedrückt wird
        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {

                // StationsBoard wird vorbereitet um als Parameter zu übergeben
                var StationId = _transport.GetStations(query: depatureStation.Text);
                var depatureStationPanel = _transport.GetStationBoard(station: depatureStation.Text, id: StationId.StationList[0].Id);


                // Abfrage ob alles ausgefüllt wurde
                if (depatureStation.Text != "" && arrivalStation.Text != "")
                {
                    // Textfelder werden ausgelesen
                    var depatureTextResult = _transport.GetStations(query: depatureStation.Text);
                    var arrivalTextResult = _transport.GetStations(query: arrivalStation.Text);

                    try
                    {
                        // Datum wird in das Richtige Format Jahr-Monat-Tag umgewandelt
                        DateTime dateSearchConnection = DateTime.Parse(dateSearch.Text);
                        string YearSearch = dateSearchConnection.Year.ToString();
                        string MonthSearch = dateSearchConnection.Month.ToString();
                        string DaySearch = dateSearchConnection.Day.ToString();

                        if (MonthSearch == "1" || MonthSearch == "2" || MonthSearch == "3" || MonthSearch == "4" || MonthSearch == "5" || MonthSearch == "6" || MonthSearch == "7" || MonthSearch == "8" || MonthSearch == "9")
                        {
                            MonthSearch = "0" + MonthSearch;
                        }

                        if (DaySearch == "1" || DaySearch == "2" || DaySearch == "3" || DaySearch == "4" || DaySearch == "5" || DaySearch == "6" || DaySearch == "7" || DaySearch == "8" || DaySearch == "9")
                        {
                            DaySearch = "0" + DaySearch;
                        }

                        string DateTimeSearchConnection = YearSearch + "-" + MonthSearch + "-" + DaySearch;
                        // Abfrage für die Verbindung wird erstellt
                        var connectionResult = _transport.GetConnections(fromStation: depatureStation.Text, toStattion: arrivalStation.Text, date: DateTimeSearchConnection, time: timeSearch.Text);


                        try
                        {
                            // Suchverlauf wird gespeichert
                            depatureHistory[counter] = connectionResult.ConnectionList[0].From.Station.Name;
                            arrivalHistory[counter] = connectionResult.ConnectionList[0].To.Station.Name;
                            counter--;
                        }
                        // Bei fehler beginnt der Suchverlauf von neuem
                        catch (IndexOutOfRangeException)
                        {
                            depatureHistory = new string[] { connectionResult.ConnectionList[0].From.Station.Name };
                            arrivalHistory = new string[] { connectionResult.ConnectionList[0].To.Station.Name };
                        }

                        // Suchverlauf wird der vorgeschlagenen Liste eingefügt
                        int condit = 0;

                        depatureStation.Items.Clear();
                        arrivalStation.Items.Clear();

                        while (condit < depatureHistory.Length)
                        {
                            try
                            {
                                depatureStation.Items.Add(depatureHistory[condit]);
                            }
                            catch (ArgumentNullException) { }
                            condit++;
                        }

                        condit = 0;

                        while (condit < arrivalHistory.Length)
                        {
                            try
                            {
                                arrivalStation.Items.Add(arrivalHistory[condit]);
                            }
                            catch (ArgumentNullException) { }
                            condit++;
                        }

                        // Form2 wird erstellt. Parameter connectionResult und depatureStationPanel wird übertragen
                        Form form2 = new Form2(connectionResult, depatureStationPanel);
                        // Form2 wird angezeigt und fokussiert
                        form2.Show();
                        form2.Focus();

                    }
                    // Sollte keine Station gefunden werden
                    catch (ArgumentOutOfRangeException)
                    {
                        MessageBox.Show("Es wurde keine Station gefunden");
                    }
                }
                // Sollte eingabe nicht vollständig sein, wird darauf hingewiesen
                else
                {
                    MessageBox.Show("Es müssen zwei Stationen eingegeben werden, um eine Verbindung herzustellen");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Es wurde keine Station gefunden");
            }

        }
        
        // Event, wenn auf den Abfahrtstafel Knopf gedrückt wird
        private void departurePanelButton_Click(object sender, EventArgs e)
        {
            try
            {
                // überprüfung, ob etwas ausgefüllt wurde
                if (depatureStation.Text != "")
            {
            // GetStationBoard wird erstellt         
                var StationId = _transport.GetStations(query: depatureStation.Text);
                var Station = StationId.StationList[0].Name;
                var depatureStationPanel = _transport.GetStationBoard(station: depatureStation.Text, id: StationId.StationList[0].Id);
         
          
                // Für Abfrage wird richtiges Datum format erstellt
                DateTime dateSearchConnection = DateTime.Parse(dateSearch.Text);
                string YearSearch = dateSearchConnection.Year.ToString();
                string MonthSearch = dateSearchConnection.Month.ToString();
                string DaySearch = dateSearchConnection.Day.ToString();

                if (MonthSearch == "1" || MonthSearch == "2" || MonthSearch == "3" || MonthSearch == "4" || MonthSearch == "5" || MonthSearch == "6" || MonthSearch == "7" || MonthSearch == "8" || MonthSearch == "9")
                {
                    MonthSearch = "0" + MonthSearch;
                }

                if (DaySearch == "1" || DaySearch == "2" || DaySearch == "3" || DaySearch == "4" || DaySearch == "5" || DaySearch == "6" || DaySearch == "7" || DaySearch == "8" || DaySearch == "9")
                {
                    DaySearch = "0" + DaySearch;
                }

                // Abfrage für die ersten 4 ergebnisseerfolgen
                string DateTimeSearchConnection = YearSearch + "-" + MonthSearch + "-" + DaySearch;
                var connectionResult1 = _transport.GetConnections(fromStation: depatureStation.Text, toStattion: depatureStationPanel.Entries[0].To, date: DateTimeSearchConnection, time: timeSearch.Text);
                var connectionResult2 = _transport.GetConnections(fromStation: depatureStation.Text, toStattion: depatureStationPanel.Entries[1].To, date: DateTimeSearchConnection, time: timeSearch.Text);
                var connectionResult3 = _transport.GetConnections(fromStation: depatureStation.Text, toStattion: depatureStationPanel.Entries[2].To, date: DateTimeSearchConnection, time: timeSearch.Text);
                var connectionResult4 = _transport.GetConnections(fromStation: depatureStation.Text, toStattion: depatureStationPanel.Entries[3].To, date: DateTimeSearchConnection, time: timeSearch.Text);

                
                // Form3 wird erstellt und depatureStationPanel, Station, connectionResult1 - 4 werden als Parameter übertragen
                Form form3 = new Form3(depatureStationPanel, Station, connectionResult1, connectionResult2, connectionResult3, connectionResult4);
               // Form3 wird angezeigt und Fokussiert
                form3.Show();
                form3.Focus();

            }
            // Fehlermeldung sollte keine Eingabe erfolgen
            else {
                MessageBox.Show("Um auf die Abfahrtstafel zuzugreifen, muss bei 'Von' eine Station eingegeben werden");
                    }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Es wurde keine Station gefunden");
            }

        }


        // Event, sollte beim Von Textfeld der Text sich ändert
       private void depatureStation_TextUpdate(object sender, EventArgs e)
        {
         
            // Comboboxliste wird geleert
            if (depatureStation.Items.Count != 0)
            {
                depatureStation.Items.Clear();
            }

            // Cursor wird an den anfang gesetzt
            depatureStation.SelectionStart = depatureStation.Text.Length;

            // Stationen werden abgerufen und in der Liste eingfügt
            var Station = _transport.GetStations(query: depatureStation.Text);
            int condition = 0;
            while (condition < 5)
            {
                try { 
                    try { 
                    depatureStation.Items.Add(Station.StationList[condition].Name);
                        // Fehler behandlung sollte nichts drinstehen
                    } catch(ArgumentNullException) { }
                    // Fehlerbehandlung sollte keine Station gefunden werden
                    } catch (ArgumentOutOfRangeException) { }
                condition++;

            }
           
            }

        // Event, sollte beim Bis Textfeld der Text sich ändert
        private void arrivalStation_TextUpdate(object sender, EventArgs e)
        {

            // Combobox wird geleert
            if (arrivalStation.Items.Count != 0)
            {
                arrivalStation.Items.Clear();
            }

            // Stationen werden abgerufen und in der Liste eingfügt
            var Station = _transport.GetStations(query: arrivalStation.Text);
            int condition = 0;
            while (condition < 5)
            {
                try
                {
                    try
                    {
                        arrivalStation.Items.Add(Station.StationList[condition].Name);
                }
                    // Fehler behandlung sollte nichts drinstehen
                    catch (ArgumentNullException) { }
                    // Fehlerbehandlung sollte keine Station gefunden werden
                }
                catch (ArgumentOutOfRangeException) { }
            condition++;
                // Cursor wird an anfang gesetzt
                arrivalStation.SelectionStart = arrivalStation.Text.Length;
            } 
        }

        // Event, wenn auf den Suchverlauf laden Knopf gedrückt wird
        private void historyLoad_Click(object sender, EventArgs e)
        {
            // Items werden aus der Combobox entfernt
            depatureStation.Items.Clear();
            arrivalStation.Items.Clear();

            // Suchverlauf wird eingefügt
            for(int i = 199; i > counter; i--)
            {
                try
                {
                    depatureStation.Items.Add(depatureHistory[i]);
                    arrivalStation.Items.Add(arrivalHistory[i]);
                }
                // Fehlerbehandlung sollte nichts im Suchverlauf stehen
                catch (IndexOutOfRangeException) { }
            }
        }

        // Event, wenn auf den Suchverlauf löschen Knopf gedrückt wird
        private void historyDelete_Click(object sender, EventArgs e)
        {
            // Suchverlauf wird leer überschrieben
            depatureHistory = new string[] { "" };
            arrivalHistory = new string[] { "" };
            // Liste wird geleert
            depatureStation.Items.Clear();
            arrivalStation.Items.Clear();
        }
    }
}
