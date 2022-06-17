using System;
using BusinessLayer;
using ServiceLayer;
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
    public partial class PlayersForm : Form
    {
        private DbManager<Player, int> playersDbManager;
        private DbManager<Country, int> countryDbManager;
        private Player selectedPlayer;
        private Country selectedCountry;
        private List<Player> players;
        int selectedRow = -1;

        public PlayersForm()
        {
            InitializeComponent();

            playersDbManager = new DbManager<Player, int>(DbContextManager.CreatePlayerContext(DbContextManager.CreateContext()));
            countryDbManager = new DbManager<Country, int>(DbContextManager.CreateCountryContext(DbContextManager.GetContext()));
            
            LoadHeaderRow();
            LoadPlayers();
            LoadCountries();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if(selectedPlayer != null)
                {
                    MessageBox.Show("You can't create duplicated player!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (ValidateData())
                {
                    string fName = txtFirstName.Text;
                    string lName = txtLastName.Text;
                    int age = (int)numAge.Value;

                    selectedCountry = countryDbManager.Read(CountryHelper.FindByName(lbCountries.Text));

                    int matches = (int)numMatches.Value;
                    int tournaments = (int)numTournaments.Value;

                    Player player = new Player(fName, lName, age, selectedCountry, matches, tournaments);
                    
                    playersDbManager.Create(player);
                    MessageBox.Show("Player created successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AddPlayerRow(player);
                    ClearData();

                    txtFirstName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateData() && selectedPlayer != null)
            {
                selectedPlayer.FirstName = txtFirstName.Text;
                selectedPlayer.LastName = txtLastName.Text;
                selectedPlayer.Age = (int)numAge.Value;
                selectedPlayer.Country = countryDbManager.Read(CountryHelper.FindByName(lbCountries.Text));
                selectedPlayer.MatchesPlayed = (int)numMatches.Value;
                selectedPlayer.TournamentsWon = (int)numTournaments.Value;

                playersDbManager.Update(selectedPlayer);

                MessageBox.Show("Player updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                UpdatePlayerRow();
                ClearData();
            }
            else
            {
                MessageBox.Show("Field given are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(selectedPlayer != null)
            {
                playersDbManager.Delete(selectedPlayer.Id);
                MessageBox.Show("Player deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DeletePlayerRow();
                ClearData();
            }
            else
            {
                MessageBox.Show("You must select a player!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPlayers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                players = playersDbManager.ReadAll().ToList();
                if(e.RowIndex < players.Count())
                {
                    int id = Convert.ToInt32(dgvPlayers.Rows[e.RowIndex].Cells[0].Value);
                    string fName = dgvPlayers.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string lName = dgvPlayers.Rows[e.RowIndex].Cells[2].Value.ToString();
                    int age = Convert.ToInt32(dgvPlayers.Rows[e.RowIndex].Cells[3].Value);
                    int countryId = Convert.ToInt32(dgvPlayers.Rows[e.RowIndex].Cells[4].Value);
                    string countryName = dgvPlayers.Rows[e.RowIndex].Cells[5].Value.ToString();
                    int matches = Convert.ToInt32(dgvPlayers.Rows[e.RowIndex].Cells[6].Value);
                    int tournaments = Convert.ToInt32(dgvPlayers.Rows[e.RowIndex].Cells[7].Value);

                    selectedPlayer = players.Find(p => p.Id == id);

                    txtFirstName.Text = fName;
                    txtLastName.Text = lName;
                    numAge.Value = age;
                    lbCountries.Text = countryName;
                    numMatches.Value = matches;
                    numTournaments.Value = tournaments;

                    selectedRow = e.RowIndex;
                }
                else
                {
                    ClearData();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void LoadPlayers()
        //{
        //    dgvPlayers.DataSource = playersDbManager.ReadAll();
        //}

        private void LoadCountries()
        {
            lbCountries.DataSource = countryDbManager.ReadAll();

            lbCountries.DisplayMember = "Name";
            lbCountries.ValueMember = "Id";
        }

        private void LoadHeaderRow()
        {
            dgvPlayers.Columns.Add("id", "ID");
            dgvPlayers.Columns.Add("firstName", "First Name");
            dgvPlayers.Columns.Add("lastName", "Last Name");
            dgvPlayers.Columns.Add("age", "Age");
            dgvPlayers.Columns.Add("countryId", "Country ID");
            dgvPlayers.Columns.Add("country", "Country");
            dgvPlayers.Columns.Add("matchesPlayed", "Matches Played");
            dgvPlayers.Columns.Add("tournamentsWon", "Tournaments Won");
            dgvPlayers.Columns.Add("tournamentParticipatingIn", "Active Tournaments");
        }

        private void LoadPlayers()
        {
            players = playersDbManager.ReadAll().ToList();

            foreach (Player item in players)
            {
                DataGridViewRow row = (DataGridViewRow)dgvPlayers.Rows[0].Clone();

                row.Cells[0].Value = item.Id;
                row.Cells[1].Value = item.FirstName;
                row.Cells[2].Value = item.LastName;
                row.Cells[3].Value = item.Age;
                row.Cells[4].Value = item.CountryId;
                row.Cells[5].Value = countryDbManager.Read(item.CountryId).Name;
                row.Cells[6].Value = item.MatchesPlayed;
                row.Cells[7].Value = item.TournamentsWon;

                if(item.TournamentsWon != null)
                {
                    row.Cells[8].Value = string.Join(", ", item.Tournaments.Select(p => p.Name));
                }

                dgvPlayers.Rows.Add(row);
            }
        }

        private void AddPlayerRow(Player item)
        {
            DataGridViewRow row = (DataGridViewRow)dgvPlayers.Rows[0].Clone();

            row.Cells[0].Value = item.Id;
            row.Cells[1].Value = item.FirstName;
            row.Cells[2].Value = item.LastName;
            row.Cells[3].Value = item.Age;
            row.Cells[4].Value = item.CountryId;
            row.Cells[5].Value = countryDbManager.Read(item.CountryId).Name;
            row.Cells[6].Value = item.MatchesPlayed;
            row.Cells[7].Value = item.TournamentsWon;

            dgvPlayers.Rows.Add(row);
        }

        private void UpdatePlayerRow()
        {
            dgvPlayers.Rows[selectedRow].Cells[0].Value = selectedPlayer.Id;
            dgvPlayers.Rows[selectedRow].Cells[1].Value = selectedPlayer.FirstName;
            dgvPlayers.Rows[selectedRow].Cells[2].Value = selectedPlayer.LastName;
            dgvPlayers.Rows[selectedRow].Cells[3].Value = selectedPlayer.Age;
            dgvPlayers.Rows[selectedRow].Cells[4].Value = selectedPlayer.CountryId;
            dgvPlayers.Rows[selectedRow].Cells[5].Value = selectedPlayer.Country.Name;
            dgvPlayers.Rows[selectedRow].Cells[6].Value = selectedPlayer.MatchesPlayed;
            dgvPlayers.Rows[selectedRow].Cells[7].Value = selectedPlayer.TournamentsWon;
        }

        private void DeletePlayerRow()
        {
            dgvPlayers.Rows.RemoveAt(selectedRow);
        }

        private bool ValidateData()
        {
            if(txtFirstName.Text != string.Empty && txtLastName.Text != string.Empty)
            {
                return true;
            }

            return false;
        }

        private void ClearData()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            numAge.Value = numAge.Minimum;
            lbCountries.Text = string.Empty;
            numMatches.Value = numMatches.Minimum;
            numTournaments.Value = numMatches.Minimum;

            selectedPlayer = null;
            selectedRow = -1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}
