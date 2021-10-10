using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting
{
    public partial class Presentation : Form
    {

        public Presentation()
        {
            InitializeComponent();
        }

        
        private void PresentationForm_Load(object sender, EventArgs e)
        {
            LoadHistory();
            LoadTotal();


        }



        private void LoadHistory()
        {
            historyDataGridView.DataSource = Logic.Load();

            historyDataGridView.Columns[0].Visible = false;

            historyDataGridView.Columns[1].HeaderText = "От кого";
            historyDataGridView.Columns[2].HeaderText = "Кому";
            historyDataGridView.Columns[3].HeaderText = "Сумма";
            historyDataGridView.Columns[4].HeaderText = "Описание";
            historyDataGridView.Columns[5].HeaderText = "Дата";
        }

        private void LoadTotal()
        {

        }



        private void AddButton_Click(object sender, EventArgs e)
        {
            bool textboxesAreEmpty = false;
            if (string.IsNullOrWhiteSpace(fromTextbox.Text))
                textboxesAreEmpty = true;
            else if (string.IsNullOrWhiteSpace(toTextbox.Text))
                textboxesAreEmpty = true;
            else if (string.IsNullOrWhiteSpace(amountTextbox.Text))
                textboxesAreEmpty = true;
            else if (string.IsNullOrWhiteSpace(descriptionTextbox.Text))
                textboxesAreEmpty = true;

            if (textboxesAreEmpty)
                MessageBox.Show("Заполните все поля!");

            AddTransaction();
        }

        private void AddTransaction()
        {
            try
            {
                Logic.Add(new TransactionsTable()
                {
                    From = fromTextbox.Text,
                    To = toTextbox.Text,
                    Amount = Convert.ToInt32(amountTextbox.Text),
                    Description = descriptionTextbox.Text,
                    Date = DateTime.Now.ToString()
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
