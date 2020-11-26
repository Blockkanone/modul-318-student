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
            // form2 = new Form2(/*this, form2 */);
        }
        Form form2 = new Form2();


        private void searchButton_Click(object sender, EventArgs e)
        {
            var result = _transport.GetStations(query: depatureStation.Text);
            try { 
            MessageBox.Show(result.StationList[0].Name);

            }
            catch(ArgumentOutOfRangeException) 
            { 
                MessageBox.Show("Es wurde keine Station gefunden");
            }

            
            form2.Show();
            form2.Focus();
        }
    }
}
