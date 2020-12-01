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

    public partial class Form2 : Form
    {
        ITransport _transport = new Transport();
        public Form2(Connections connectionResult)
        {
            InitializeComponent();
            var depatureDateTime = DateTime.Parse(connectionResult.ConnectionList[0].From.Departure);
            var arrivalDateTime = DateTime.Parse(connectionResult.ConnectionList[0].To.Arrival);

            depatureStation.Text = Convert.ToString(connectionResult.ConnectionList[0].From.Station.Name);
            arrivalStation.Text = Convert.ToString(connectionResult.ConnectionList[0].To.Station.Name);

            depatureDatetbx.Text = depatureDateTime.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
            arrivalDatetbx.Text = arrivalDateTime.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
            depatureTimetbx.Text = depatureDateTime.ToString("HH:mm", CultureInfo.InvariantCulture);
            arrivalTimetbx.Text = arrivalDateTime.ToString("HH:mm", CultureInfo.InvariantCulture);

            depatureStationNrtbx.Text = Convert.ToString(connectionResult.ConnectionList[0].From.Platform);
            arrivalStationNrtbx.Text = Convert.ToString(connectionResult.ConnectionList[0].To.Platform);
        }




      
    }
}
