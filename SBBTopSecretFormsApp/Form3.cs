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

namespace SBBTopSecretFormsApp
{
    public partial class Form3 : Form
    {
        public Form3(StationBoardRoot depatureStationPanel, string station, Connections connectionResult1, Connections connectionResult2, Connections connectionResult3, Connections connectionResult4)
        {
            InitializeComponent();
            var test = depatureStationPanel.Entries[0].Stop.Departure;
            var depatureDateTime1 = DateTime.Parse(depatureStationPanel.Entries[0].Stop.Departure.ToString());
           var arrivalDateTime1 = DateTime.Parse(depatureStationPanel.Entries[0].Stop.Departure.ToString());

            var depatureDateTime2 = DateTime.Parse(depatureStationPanel.Entries[1].Stop.Departure.ToString());
            var arrivalDateTime2 = DateTime.Parse(depatureStationPanel.Entries[1].Stop.Departure.ToString());

            var depatureDateTime3 = DateTime.Parse(depatureStationPanel.Entries[2].Stop.Departure.ToString());
            var arrivalDateTime3 = DateTime.Parse(depatureStationPanel.Entries[2].Stop.Departure.ToString());

            var depatureDateTime4 = DateTime.Parse(depatureStationPanel.Entries[3].Stop.Departure.ToString());
            var arrivalDateTime4 = DateTime.Parse(depatureStationPanel.Entries[3].Stop.Departure.ToString()); 


            depatureStation.Text = Convert.ToString(station);

            
            arrivalStationtbx1.Text = Convert.ToString(depatureStationPanel.Entries[0].To);

            depatureDatetbx1.Text = depatureDateTime1.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
            depatureTimetbx1.Text = depatureDateTime1.ToString("HH:mm", CultureInfo.InvariantCulture);

            depatureStationNrtbx1.Text = Convert.ToString(connectionResult1.ConnectionList[0].From.Platform);



            arrivalStationtbx2.Text = Convert.ToString(depatureStationPanel.Entries[1].To);

            depatureDatetbx2.Text = depatureDateTime2.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
            depatureTimetbx2.Text = depatureDateTime2.ToString("HH:mm", CultureInfo.InvariantCulture);

            depatureStationNrtbx2.Text = Convert.ToString(connectionResult2.ConnectionList[0].From.Platform);



            arrivalStationtbx3.Text = Convert.ToString(depatureStationPanel.Entries[2].To);

            depatureDatetbx3.Text = depatureDateTime3.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
             depatureTimetbx3.Text = depatureDateTime3.ToString("HH:mm", CultureInfo.InvariantCulture);

            depatureStationNrtbx3.Text = Convert.ToString(connectionResult3.ConnectionList[0].From.Platform);



            arrivalStationtbx4.Text = Convert.ToString(depatureStationPanel.Entries[3].To);

            depatureDatetbx4.Text = depatureDateTime4.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
            depatureTimetbx4.Text = depatureDateTime4.ToString("HH:mm", CultureInfo.InvariantCulture);

            depatureStationNrtbx4.Text = Convert.ToString(connectionResult4.ConnectionList[0].From.Platform);
        }
    }
}
