using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCountries_Click(object sender, EventArgs e)
        {
            CountriesForm countriesForm = new CountriesForm();
            countriesForm.ShowDialog();
        }

        private void btnPlayers_Click(object sender, EventArgs e)
        {
            PlayersForm playersForm = new PlayersForm();
            playersForm.ShowDialog();
        }

        private void btnTournaments_Click(object sender, EventArgs e)
        {
            TournamentsForm tournamentsForm = new TournamentsForm();
            tournamentsForm.ShowDialog();
        }
    }
}
