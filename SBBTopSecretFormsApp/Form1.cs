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
        ITransport _transport = new Transport();
        public Form1()
        {
            InitializeComponent();
            dateSearch.Text = DateTime.Now.ToShortDateString();
            timeSearch.Text = DateTime.Now.ToShortTimeString();
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            
            if (depatureStation.Text != "" && arrivalStation.Text != "") { 
            var depatureTextResult = _transport.GetStations(query: depatureStation.Text);
            var arrivalTextResult = _transport.GetStations(query: arrivalStation.Text);

                try
                {
               string depatureText = depatureTextResult.StationList[0].Name;
                    string arrivalText = arrivalTextResult.StationList[0].Name;

                    DateTime dateSearchConnection = DateTime.Parse(dateSearch.Text);
                    string YearSearch = dateSearchConnection.Year.ToString();
                    string MonthSearch = dateSearchConnection.Month.ToString();
                    string DaySearch = dateSearchConnection.Day.ToString();

                    if (MonthSearch == "1" || MonthSearch == "2" || MonthSearch == "3" || MonthSearch == "4" || MonthSearch == "5" || MonthSearch == "6" || MonthSearch == "7" || MonthSearch == "8" || MonthSearch == "9" )
                    {
                        MonthSearch = "0" + MonthSearch;
                    }

                    if (DaySearch == "1" || DaySearch == "2" || DaySearch == "3" || DaySearch == "4" || DaySearch == "5" || DaySearch == "6" || DaySearch == "7" || DaySearch == "8" || DaySearch == "9")
                    {
                        DaySearch = "0" + DaySearch;
                    }

                    string DateTimeSearchConnection = YearSearch + "-" + MonthSearch + "-" + DaySearch;
                    var connectionResult = _transport.GetConnections(fromStation: depatureStation.Text, toStattion: arrivalStation.Text, date: DateTimeSearchConnection, time: timeSearch.Text);
                    Form form2 = new Form2(connectionResult);
                    form2.Show();
                form2.Focus();
            }
            catch(ArgumentOutOfRangeException) 
            { 
                MessageBox.Show("Es wurde keine Station gefunden");
            }
            }
            else
            {
                MessageBox.Show("Es müssen zwei Stationen eingegeben werden, um eine Verbindung herzustellen");
            }
        }

        private void departurePanelButton_Click(object sender, EventArgs e)
        {
            Form form3 = new Form3();
            form3.Show();
            form3.Focus();
        }
    }
}
