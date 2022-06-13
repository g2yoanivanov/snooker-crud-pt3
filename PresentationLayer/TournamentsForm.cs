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
        private Tournament? selectedTournament;
        private Player selectedPlayer;

        public TournamentsForm()
        {
            InitializeComponent();

            tournamentDbManager = new DbManager<Tournament, int>(DbContextManager.CreateTournamentContext(DbContextManager.CreateContext()));
            playerDbManager = new DbManager<Player, int>(DbContextManager.CreatePlayerContext(DbContextManager.GetContext()));

            LoadTournaments();
            LoadPlayers();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if(selectedTournament != null)
                {
                    MessageBox.Show("You can't create duplicated tournament!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (ValidateData())
                {
                    string name = txtName.Text;
                    string location = txtLocation.Text;
                    decimal prizePool = numPrize.Value;

                    Tournament tournament = new Tournament(name, location, prizePool);

                    tournamentDbManager.Create(tournament);
                    MessageBox.Show("Tournament created successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadTournaments();
                    ClearData();

                   txtName.Focus();
                }
                else
                {
                    MessageBox.Show("Name, Location and PrizePool are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                selectedTournament.Name = txtName.Text;
                selectedTournament.Location = txtLocation.Text;
                selectedTournament.PrizePool = numPrize.Value;

                tournamentDbManager.Update(selectedTournament);
                MessageBox.Show("Tournament updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadTournaments();
                ClearData();
           }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(selectedTournament != null)
            {
                tournamentDbManager.Delete(selectedTournament.Id);
                MessageBox.Show("Tournament deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadTournaments();
                ClearData();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(selectedTournament != null && selectedPlayer != null)
                {
                    if (!((HashSet<Player>)selectedTournament.Players).Contains(selectedPlayer))
                    {
                        ((HashSet<Player>)selectedTournament.Players).Add(selectedPlayer);

                        tournamentDbManager.Update(selectedTournament);

                        MessageBox.Show(string.Format("{0} added successfully!", (selectedPlayer.FirstName + " " + selectedPlayer.LastName)), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            catch (Exception)
            {
                throw;
            }
        }

        private void dgvTournaments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dgvTournaments.Rows[e.RowIndex];

                selectedTournament = (Tournament)row.DataBoundItem;

                txtName.Text = selectedTournament.Name;
                txtLocation.Text = selectedTournament.Location;
                numPrize.Value = selectedTournament.PrizePool;
            }
        }

        private void lbPlayers_SelectedValueChanged(object sender, EventArgs e)
        {
            if(lbPlayers.SelectedValue != null)
            {
                selectedPlayer = (Player)lbPlayers.SelectedItem;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadTournaments()
        {
            dgvTournaments.DataSource = tournamentDbManager.ReadAll();
        }

        private void LoadPlayers()
        {
            lbPlayers.DataSource = playerDbManager.ReadAll();

            lbPlayers.DisplayMember = "FirstName";
            lbPlayers.ValueMember = "Id";
        }

        private bool ValidateData()
        {
            if(txtName.Text != string.Empty && txtLocation.Text != string.Empty)
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
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}
