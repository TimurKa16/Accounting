using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Accounting
{
    public partial class PresentationForm
    {
		private void LoadHistory()
		{
			transactionList = Storage.LoadHistory(numberOfDays);

			historyDataGridView.DataSource = transactionList;

			if (historyDataGridView.ColumnCount == 6)
			{
				historyDataGridView.Columns[0].Visible = false;
				//historyDataGridView.Columns[0].HeaderText = "Id";

				historyDataGridView.Columns[1].HeaderText = "От кого";
				historyDataGridView.Columns[1].Width = 150;

				historyDataGridView.Columns[2].HeaderText = "Кому";
				historyDataGridView.Columns[2].Width = 150;

				historyDataGridView.Columns[3].HeaderText = "Сумма";
				historyDataGridView.Columns[3].Width = 150;

				historyDataGridView.Columns[4].HeaderText = "Описание";
				historyDataGridView.Columns[4].Width = 200;

				historyDataGridView.Columns[5].HeaderText = "Дата";
				historyDataGridView.Columns[5].Width = 150;
				historyDataGridView.Columns[5].HeaderCell.Style.Padding = new Padding(0, 5, 60, 5);
				historyDataGridView.Columns[5].DefaultCellStyle.Padding = new Padding(0, 5, 60, 5);


				//historyDataGridView.DefaultCellStyle.Padding = new Padding(0, 20, 3, 20);
			}
		}





		private void AddTransaction(string fromText, string toText, string amountText, string descriptionText)
		{
			try
			{
				Storage.AddHistory(new TransactionsTable()
				{
					T_From = fromText,
					T_To = toText,
					T_Amount = Convert.ToInt32(amountText),
					T_Description = descriptionText,
					T_Date = DateTime.Now
				});
				LoadData();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void HistoryContextMenuStrip_Opening(object sender, CancelEventArgs e)
		{

		}

		private void HistoryDataGridView_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				var hit = historyDataGridView.HitTest(e.X, e.Y);
				if (hit.RowIndex >= 0)
				{
					historyDataGridView.ClearSelection();
					historyDataGridView.Rows[hit.RowIndex].Selected = true;
					selectedTransactionRow = hit.RowIndex;
				}
			}
		}

		private void AddHistoryContextMenuItem_Click(object sender, EventArgs e)
		{
			transactionForm = new TransactionForm();
			Hide();
			transactionForm.ShowDialog();
			Show();

			if (transactionForm.transactionIsCorrect)
				AddTransaction(transactionForm.fromText, transactionForm.toText, transactionForm.amountText, transactionForm.descriptionText);

			historyDataGridView.Rows[0].Selected = true;

		}

		private void DeleteHistoryContextMenuItem_Click(object sender, EventArgs e)
		{
			if (selectedTransactionRow >= 0)
			{
				int id = transactionList[selectedTransactionRow].T_Id;
				Storage.DeleteHistory(id);
				LoadData();
			}
		}

		private void UpdateHistoryContextMenuItem_Click(object sender, EventArgs e)
		{
			if (selectedTransactionRow >= 0)
			{
				var transaction = transactionList[selectedTransactionRow];

				transactionForm = new TransactionForm();

				transactionForm.fromText = transaction.T_From;
				transactionForm.toText = transaction.T_To;
				transactionForm.amountText = transaction.T_Amount.ToString();
				transactionForm.descriptionText = transaction.T_Description;

				Hide();
				transactionForm.ShowDialog();
				Show();

				if (transactionForm.transactionIsCorrect)
				{
					transaction.T_From = transactionForm.fromText;
					transaction.T_To = transactionForm.toText;
					transaction.T_Amount = Convert.ToInt32(transactionForm.amountText);
					transaction.T_Description = transactionForm.descriptionText;

					try
					{
						Storage.UpdateHistory(transaction);
						LoadData();
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
				}
			}
		}

		private void HistoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (historyComboBox.SelectedIndex)
			{
				case 0:
					numberOfDays = ((int)HistoryComboBoxItems.AllTime);
					break;
				case 1:
					numberOfDays = ((int)HistoryComboBoxItems.Year);
					break;
				case 2:
					numberOfDays = ((int)HistoryComboBoxItems.Month);
					break;
				case 3:
					numberOfDays = ((int)HistoryComboBoxItems.Week);
					break;
				case 4:
					numberOfDays = ((int)HistoryComboBoxItems.Day);
					break;
			}

			LoadHistory();

			historyDataGridView.ClearSelection();

			label2.Focus();
		}

		enum HistoryComboBoxItems
		{
			AllTime = 0,
			Day = 1,
			Week = 7,
			Month = 31,
			Year = 366
		}
	}
}
