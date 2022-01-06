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
		private void LoadDebts()
		{
			debtList = Storage.LoadDebts(debtIndex);
			debtDataGridView.DataSource = debtList;

			if (debtDataGridView.ColumnCount == 3)
			{
				debtDataGridView.Columns[0].HeaderText = "От кого";
				debtDataGridView.Columns[0].Width = 150;

				debtDataGridView.Columns[1].HeaderText = "Кому";
				debtDataGridView.Columns[1].Width = 150;

				debtDataGridView.Columns[2].HeaderText = "Сумма";
				debtDataGridView.Columns[2].Width = 150;
				debtDataGridView.Columns[2].HeaderCell.Style.Padding = new Padding(0, 5, 10, 5);
				debtDataGridView.Columns[2].DefaultCellStyle.Padding = new Padding(0, 5, 10, 5);
			}
		}

		private void DebtComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{


			switch (debtComboBox.SelectedIndex)
			{
				case 0:
					debtIndex = ((int)WhoComboBoxItems.All);
					break;
				case 1:
					debtIndex = ((int)WhoComboBoxItems.ToMe);
					break;
				case 2:
					debtIndex = ((int)WhoComboBoxItems.FromMe);
					break;
			}

			LoadDebts();

			debtDataGridView.ClearSelection();
		}

		enum WhoComboBoxItems
		{
			All = 0,
			ToMe = 1,
			FromMe = 2
		}
	}
}
