using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using ServiceLayer;

namespace PresentationLayer
{
    public partial class TournamentsForm : Form
    {
        private DbManager<Tournament, int> tournamentDbManager;
        private DbManager<Player, int> playerDbManager;
        private Tournament selectedTournament;
        private Player selectedPlayer;

        private List<Tournament> tournaments;
        int selectedRow = -1;

        public TournamentsForm()
        {
            InitializeComponent();

            tournamentDbManager = new DbManager<Tournament, int>(DbContextManager.CreateTournamentContext(DbContextManager.CreateContext()));
            playerDbManager = new DbManager<Player, int>(DbContextManager.CreatePlayerContext(DbContextManager.GetContext()));

            LoadHeaderRow();
            LoadTournaments();
            LoadPlayers();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if(selectedTournament != null)
                {
                    MessageBox.Show("You cannot create dublicated tournament!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (ValidateData())
                {
                    string name = txtName.Text;
                    string location = txtLocation.Text;
                    decimal prizePool = numPrize.Value;

                    Tournament tournament = new Tournament(name, location, prizePool);

                    tournamentDbManager.Create(tournament);
                    MessageBox.Show("Tournament created successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AddTournamentRow(tournament);
                    ClearData();

                    txtName.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(ValidateData() && selectedTournament != null)
            {
                string[] name = lbWinner.Text.Split(" ");

                selectedTournament.Name = txtName.Text;
                selectedTournament.Location = txtLocation.Text;
                selectedTournament.PrizePool = numPrize.Value;
                selectedTournament.Winner = playerDbManager.Read(PlayerHelper.FindByName(name[0], name[1]));

                tournamentDbManager.Update(selectedTournament);

                MessageBox.Show("Tournament updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                UpdateTournamentRow();
                ClearData();
            }

            else
            {
                MessageBox.Show("Fields given are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(selectedTournament != null)
            {
                tournamentDbManager.Delete(selectedTournament.Id);

                DeleteTournamentRow();
                ClearData();
            }

            else
            {
                MessageBox.Show("You must select a tournament", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(selectedTournament != null && selectedPlayer != null)
                {
                    if(!((HashSet<Player>)selectedTournament.Players).Contains(selectedPlayer))
                    {
                        ((HashSet<Player>)selectedTournament.Players).Add(selectedPlayer);

                        tournamentDbManager.Update(selectedTournament);

                        MessageBox.Show(string.Format("{0} added successfully!", selectedPlayer.FirstName + " " + selectedPlayer.LastName), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("This player is already participating in the tournament!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("You must choose tournament and player!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTournaments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                int id = Convert.ToInt32(dgvTournaments.Rows[e.RowIndex].Cells[0].Value);
                string name = dgvTournaments.Rows[e.RowIndex].Cells[1].Value.ToString();
                string location = dgvTournaments.Rows[e.RowIndex].Cells[2].Value.ToString(); ;
                decimal prizePool = Convert.ToDecimal(dgvTournaments.Rows[e.RowIndex].Cells[0].Value);
                int winnerId = Convert.ToInt32(dgvTournaments.Rows[e.RowIndex].Cells[0].Value);
                string winner = dgvTournaments.Rows[e.RowIndex].Cells[0].Value.ToString(); ;

                txtName.Text = name;
                txtLocation.Text = location;
                numPrize.Value = prizePool;
                lbWinner.Text = winner;

                selectedRow = e.RowIndex;
            }
        }

        private void LoadHeaderRow()
        {
            dgvTournaments.Columns.Add("id", "ID");
            dgvTournaments.Columns.Add("name", "Name");
            dgvTournaments.Columns.Add("location", "Location");
            dgvTournaments.Columns.Add("prizePool", "Prize Pool");
            dgvTournaments.Columns.Add("winnerId", "Winner ID");
            dgvTournaments.Columns.Add("winner", "Winner's Name");
            dgvTournaments.Columns.Add("players", "Players");
        }

        private void LoadPlayers()
        {
            lbPlayers.DataSource = playerDbManager.ReadAll();

            lbPlayers.DisplayMember = "Name";
            lbPlayers.ValueMember = "Id";
        }

        private void LoadTournaments()
        {
            tournaments = tournamentDbManager.ReadAll().ToList();

            foreach (Tournament item in tournaments)
            {
                DataGridViewRow row = (DataGridViewRow)dgvTournaments.Rows[0].Clone();

                row.Cells[0].Value = item.Id;
                row.Cells[1].Value = item.Name;
                row.Cells[2].Value = item.Location;
                row.Cells[3].Value = item.PrizePool;
                if(item.WinnerId == null)
                {
                    row.Cells[4].Value = null;
                    row.Cells[5].Value = null;
                }
                else
                {
                    row.Cells[4].Value = item.WinnerId;
                    row.Cells[5].Value = playerDbManager.Read(item.WinnerId).FirstName + " " + playerDbManager.Read(item.WinnerId).LastName;
                }
                row.Cells[6].Value = item.Players;

                dgvTournaments.Rows.Add(row);
            }
        }

        private void AddTournamentRow(Tournament item)
        {
            DataGridViewRow row = (DataGridViewRow)dgvTournaments.Rows[0].Clone();

            row.Cells[0].Value = item.Id;
            row.Cells[1].Value = item.Name;
            row.Cells[2].Value = item.Location;
            row.Cells[3].Value = item.PrizePool;
            row.Cells[4].Value = item.WinnerId;
            row.Cells[5].Value = playerDbManager.Read(item.WinnerId).FirstName + " " + playerDbManager.Read(item.WinnerId).LastName;
            row.Cells[6].Value = item.Players;

            dgvTournaments.Rows.Add(row);
        }

        private void UpdateTournamentRow()
        {
            dgvTournaments.Rows[selectedRow].Cells[0].Value = selectedTournament.Id;
            dgvTournaments.Rows[selectedRow].Cells[1].Value = selectedTournament.Name;
            dgvTournaments.Rows[selectedRow].Cells[2].Value = selectedTournament.Location;
            dgvTournaments.Rows[selectedRow].Cells[3].Value = selectedTournament.PrizePool;
            dgvTournaments.Rows[selectedRow].Cells[4].Value = selectedTournament.WinnerId;
            dgvTournaments.Rows[selectedRow].Cells[5].Value = selectedTournament.Winner.FirstName + " " + selectedTournament.Winner.LastName;
            dgvTournaments.Rows[selectedRow].Cells[6].Value = selectedTournament.Players;
        }

        private void DeleteTournamentRow()
        {
            dgvTournaments.Rows.RemoveAt(selectedRow);
        }

        private bool ValidateData()
        {
            if(txtName.Text != string.Empty && txtName.Text != string.Empty && numPrize.Value > 0)
            {
                return true;
            }

            return false;
        }

        private void ClearData()
        {
            txtName.Text = string.Empty;
            txtLocation.Text = string.Empty;
            numPrize.Value = numPrize.Minimum;

            selectedTournament = null;
            selectedRow = -1;
        }
    }
}
