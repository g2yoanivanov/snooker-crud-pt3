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
    public partial class CountriesForm : Form
    {
        private DbManager<Country, int> countryDbManager;
        private Country selectedCountry;

        public CountriesForm()
        {
            InitializeComponent();

            countryDbManager = new DbManager<Country, int>(DbContextManager.CreateCountryContext(DbContextManager.CreateContext()));

            LoadCountries();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedCountry != null)
                {
                    MessageBox.Show("You can't create duplicates country!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (ValidateData())
                {
                    string name = txtName.Text;

                    Country country = new Country(name);

                    countryDbManager.Create(country);
                    MessageBox.Show("Country created successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadCountries();
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
            if (ValidateData() && selectedCountry != null)
            {
                selectedCountry.Name = txtName.Text;

                countryDbManager.Update(selectedCountry);

                MessageBox.Show("Country updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadCountries();

                ClearData();
            }
            else
            {
                MessageBox.Show("Name is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCountry != null)
            {
                countryDbManager.Delete(selectedCountry.Id);
                MessageBox.Show("Country deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadCountries();

                ClearData();
            }
            else
            {
                MessageBox.Show("You must select country!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCountries_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dgvCountries.Rows[e.RowIndex];

                selectedCountry = row.DataBoundItem as Country;

                txtName.Text = selectedCountry.Name;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadCountries()
        {
            dgvCountries.DataSource = countryDbManager.ReadAll();
        }

        private bool ValidateData()
        {
            if (txtName.Text != string.Empty)
            {
                return true;
            }

            return false;
        }

        private void ClearData()
        {
            txtName.Text = string.Empty;

            selectedCountry = null;
        }
    }
}
