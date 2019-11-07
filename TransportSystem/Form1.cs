using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace TransportSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Database db = new Database();
            var result = from c in db.Types select c.Type1;
            cbType.DataSource = result.ToList();
            dtgvDataset.DataSource = db.cities.ToList();
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = cbType.Text;
            Database db = new Database();
            switch (type)
            {
                case "cities":
                    dtgvDataset.DataSource = db.cities.ToList(); break;
                case "lines":
                    dtgvDataset.DataSource = db.lines.ToList(); break;
                case "station_lines":
                    dtgvDataset.DataSource = db.station_lines.ToList(); break;
                case "stations":
                    dtgvDataset.DataSource = db.stations.ToList(); break;
                case "systems":
                    dtgvDataset.DataSource = db.systems.ToList(); break;
                case "track_lines":
                    dtgvDataset.DataSource = db.track_lines.ToList(); break;
                case "tracks":
                    dtgvDataset.DataSource = db.tracks.ToList(); break;
                default: break;
            }
        }

        private void txtCommandLine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                processCommandLine(txtCommandLine.Text);
                txtResult.Focus();
            }
            return;
        }

        private void btRun_Click(object sender, EventArgs e)
        {
            processCommandLine(txtCommandLine.Text);
            txtResult.Focus();
        }

        private void processCommandLine(string req)
        {
            //TODO
            txtResult.Text = "Processing...";      //Delete this
        }

    }

}
