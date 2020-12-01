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
            var depatureDateTime1 = DateTime.Parse(connectionResult.ConnectionList[0].From.Departure);
            var arrivalDateTime1 = DateTime.Parse(connectionResult.ConnectionList[0].To.Arrival);

            var depatureDateTime2 = DateTime.Parse(connectionResult.ConnectionList[1].From.Departure);
            var arrivalDateTime2 = DateTime.Parse(connectionResult.ConnectionList[1].To.Arrival);

            var depatureDateTime3 = DateTime.Parse(connectionResult.ConnectionList[2].From.Departure);
            var arrivalDateTime3 = DateTime.Parse(connectionResult.ConnectionList[2].To.Arrival);

            var depatureDateTime4 = DateTime.Parse(connectionResult.ConnectionList[3].From.Departure);
            var arrivalDateTime4 = DateTime.Parse(connectionResult.ConnectionList[3].To.Arrival);


            depatureStation1.Text = Convert.ToString(connectionResult.ConnectionList[0].From.Station.Name);
            arrivalStation1.Text = Convert.ToString(connectionResult.ConnectionList[0].To.Station.Name);

            depatureDatetbx1.Text = depatureDateTime1.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
            arrivalDatetbx1.Text = arrivalDateTime1.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
            depatureTimetbx1.Text = depatureDateTime1.ToString("HH:mm", CultureInfo.InvariantCulture);
            arrivalTimetbx1.Text = arrivalDateTime1.ToString("HH:mm", CultureInfo.InvariantCulture);

            depatureStationNrtbx1.Text = Convert.ToString(connectionResult.ConnectionList[0].From.Platform);
            arrivalStationNrtbx1.Text = Convert.ToString(connectionResult.ConnectionList[0].To.Platform);



            depatureStation2.Text = Convert.ToString(connectionResult.ConnectionList[1].From.Station.Name);
            arrivalStation2.Text = Convert.ToString(connectionResult.ConnectionList[1].To.Station.Name);

            depatureDatetbx2.Text = depatureDateTime2.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
            arrivalDatetbx2.Text = arrivalDateTime2.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
            depatureTimetbx2.Text = depatureDateTime2.ToString("HH:mm", CultureInfo.InvariantCulture);
            arrivalTimetbx2.Text = arrivalDateTime2.ToString("HH:mm", CultureInfo.InvariantCulture);

            depatureStationNrtbx2.Text = Convert.ToString(connectionResult.ConnectionList[1].From.Platform);
            arrivalStationNrtbx2.Text = Convert.ToString(connectionResult.ConnectionList[1].To.Platform);



            depatureStation3.Text = Convert.ToString(connectionResult.ConnectionList[2].From.Station.Name);
            arrivalStation3.Text = Convert.ToString(connectionResult.ConnectionList[2].To.Station.Name);

            depatureDatetbx3.Text = depatureDateTime3.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
            arrivalDatetbx3.Text = arrivalDateTime3.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
            depatureTimetbx3.Text = depatureDateTime3.ToString("HH:mm", CultureInfo.InvariantCulture);
            arrivalTimetbx3.Text = arrivalDateTime3.ToString("HH:mm", CultureInfo.InvariantCulture);

            depatureStationNrtbx3.Text = Convert.ToString(connectionResult.ConnectionList[2].From.Platform);
            arrivalStationNrtbx3.Text = Convert.ToString(connectionResult.ConnectionList[2].To.Platform);



            depatureStation4.Text = Convert.ToString(connectionResult.ConnectionList[3].From.Station.Name);
            arrivalStation4.Text = Convert.ToString(connectionResult.ConnectionList[3].To.Station.Name);

            depatureDatetbx4.Text = depatureDateTime4.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
            arrivalDatetbx4.Text = arrivalDateTime4.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
            depatureTimetbx4.Text = depatureDateTime4.ToString("HH:mm", CultureInfo.InvariantCulture);
            arrivalTimetbx4.Text = arrivalDateTime4.ToString("HH:mm", CultureInfo.InvariantCulture);

            depatureStationNrtbx4.Text = Convert.ToString(connectionResult.ConnectionList[3].From.Platform);
            arrivalStationNrtbx4.Text = Convert.ToString(connectionResult.ConnectionList[3].To.Platform);
        }




      
    }
}
