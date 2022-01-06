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
		//@ Закругление углов формы
		//_______________________________________________________________________________________________
		int selectedIndex = -1;

		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
		private static extern IntPtr CreateRoundRectRgn
		(
			int nLeftRect,     // x-coordinate of upper-left corner
			int nTopRect,      // y-coordinate of upper-left corner
			int nRightRect,    // x-coordinate of lower-right corner
			int nBottomRect,   // y-coordinate of lower-right corner
			int nWidthEllipse, // height of ellipse
			int nHeightEllipse // width of ellipse
		);

		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
		//_______________________________________________________________________________________________


		//@ Скрытие ScrollBar'a у datagridView
		//_______________________________________________________________________________________________
		private void DatagridView_MouseWheel(object sender, MouseEventArgs e)
		{
			if (e.Delta > 0)
			{

			}
			else if (e.Delta < 0)
			{
			}
		}
		//_______________________________________________________________________________________________


		//@ Перетаскивание формы
		//_______________________________________________________________________________________________
		private void PresentationForm_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		//_______________________________________________________________________________________________



		//@ Прорисовка ComboBox'ов
		//_______________________________________________________________________________________________
		private void HistoryComboBox_DrawItem(object sender, DrawItemEventArgs e)
		{
			ComboBox_DrawItem(sender, e, ref historyComboBox);
		}

		private void MonthlyPaymentComboBox_DrawItem(object sender, DrawItemEventArgs e)
		{
			ComboBox_DrawItem(sender, e, ref monthlyPaymentComboBox);
		}

		private void DebtComboBox_DrawItem(object sender, DrawItemEventArgs e)
		{
			ComboBox_DrawItem(sender, e, ref debtComboBox);
		}

		private void ComboBox_DrawItem(object sender, DrawItemEventArgs e, ref ComboBox comboBox)
		{
			e.DrawBackground();
			//if (e.Index == 0)
			int a = 0;
			//label1.Text = e.Index.ToString();
			if (e.Index == -1)
			{

			}
			if (comboBox.DroppedDown)
			{
				if (e.Index >= 0)
				{
					if (comboBox.Focused == false)
					{
						comboBox.BackColor = Color.FromArgb(127, 10, 150);
						comboBox.ForeColor = Color.FromArgb(248, 226, 255);

					}
					else
					{
					}

					{

						//if (e.Index > 0)
						{
							if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
							{

								e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(196, 81, 219)), e.Bounds);

								e.Graphics.DrawString(comboBox.Items[e.Index].ToString(), comboBox.Font,
									new SolidBrush(Color.FromArgb(0,0,0)),
									new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
							}
							else
							{
								// 248; 226; 255
								// 39; 9; 44
								e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(248, 226, 255)), e.Bounds);

								e.Graphics.DrawString(comboBox.Items[e.Index].ToString(), comboBox.Font,
									new SolidBrush(Color.FromArgb(0,0,0)),
									new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));

							}
						}
					}
				}
			}
		}
		//_______________________________________________________________________________________________



		//@ Убираем лишние выделения comboBox'ов
		//_______________________________________________________________________________________________
		private void HistoryComboBox_DropDown(object sender, EventArgs e)
		{
			ComboBox_DropDown(sender, e, ref historyComboBox);
		}

		private void MonthlyPaymentComboBox_DropDown(object sender, EventArgs e)
		{
			ComboBox_DropDown(sender, e, ref monthlyPaymentComboBox);
		}

		private void DebtComboBox_DropDown(object sender, EventArgs e)
		{
			ComboBox_DropDown(sender, e, ref debtComboBox);
		}

		private void ComboBox_DropDown(object sender, EventArgs e, ref ComboBox comboBox)
		{
			comboBox.SelectionLength = 0;
			label2.Focus();
		}

		private void HistoryComboBox_DropDownClosed(object sender, EventArgs e)
		{
			ComboBox_DropDownClosed(sender, e, ref historyComboBox);
		}

		private void MonthlyPaymentComboBox_DropDownClosed(object sender, EventArgs e)
		{
			ComboBox_DropDownClosed(sender, e, ref monthlyPaymentComboBox);
		}

		private void DebtComboBox_DropDownClosed(object sender, EventArgs e)
		{
			ComboBox_DropDownClosed(sender, e, ref debtComboBox);
		}

		private void ComboBox_DropDownClosed(object sender, EventArgs e, ref ComboBox comboBox)
		{
			if (selectedIndex >= 0)
			{
				comboBox.Text = comboBox.Items[selectedIndex].ToString();
			}
			comboBox.SelectionLength = 0;
			label2.Focus();
		}

		private void HistoryComboBox_MouseDown(object sender, MouseEventArgs e)
		{
			ComboBox_MouseDown(sender, e, ref historyComboBox);
		}

		private void MonthlyPaymentComboBox_MouseDown(object sender, MouseEventArgs e)
		{
			ComboBox_MouseDown(sender, e, ref monthlyPaymentComboBox);
		}

		private void DebtComboBox_MouseDown(object sender, MouseEventArgs e)
		{
			ComboBox_MouseDown(sender, e, ref debtComboBox);
		}

		private void ComboBox_MouseDown(object sender, MouseEventArgs e, ref ComboBox comboBox)
		{
			comboBox.SelectionLength = 0;
		}

		private void HistoryComboBox_MouseMove(object sender, MouseEventArgs e)
		{
			ComboBox_MouseMove(sender, e, ref historyComboBox);

		}

		private void MonthlyPaymentComboBox_MouseMove(object sender, MouseEventArgs e)
		{
			ComboBox_MouseMove(sender, e, ref monthlyPaymentComboBox);

		}

		private void DebtComboBox_MouseMove(object sender, MouseEventArgs e)
		{
			ComboBox_MouseMove(sender, e, ref debtComboBox);
		}

		private void ComboBox_MouseMove(object sender, MouseEventArgs e, ref ComboBox comboBox)
		{
			comboBox.SelectionLength = 0;
		}
		//_______________________________________________________________________________________________

		

		//@ Закрытие формы
		private void ExitButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void ExitButton_MouseDown(object sender, MouseEventArgs e)
		{
			
			exitButton.Font = new Font("Wingdings 2", 23F);
			exitButton.Location = new Point(exitButton.Location.X - 1, exitButton.Location.Y + 2);
		}

		private void ExitButton_MouseUp(object sender, MouseEventArgs e)
		{
			exitButton.Font = new Font("Wingdings 2", 26F);
			exitButton.Location = new Point(exitButton.Location.X + 1, exitButton.Location.Y - 2);
		}
		//_______________________________________________________________________________________________



		//@ Убираем лишние выделения DataGridView
		private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			ClearDataGridSelection();
			label2.Focus();
		}
		//_______________________________________________________________________________________________



		//@ Настраиваем ScrollBar
		
		private void HistoryScrollBar_Scroll(object sender, ScrollEventArgs e)
		{
			if (e.NewValue > -1 && e.NewValue < historyDataGridView.Rows.Count)
			{
				historyDataGridView.FirstDisplayedScrollingRowIndex = e.NewValue;
			}
		}
		private void historyDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			//historyScrollBar.Maximum = historyDataGridView.RowCount;
			//historyScrollBar.Value = 0;
		}

		private void historyDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			//historyScrollBar.Maximum = historyDataGridView.RowCount;
			//historyScrollBar.Value = 0;
		}

		

		private void MonthlyPaymentScrollBar_Scroll(object sender, ScrollEventArgs e)
		{
			if (e.NewValue > -1 && e.NewValue < monthlyPaymentDataGridView.Rows.Count)
			{
				monthlyPaymentDataGridView.FirstDisplayedScrollingRowIndex = e.NewValue;
			}
		}

		private void monthlyPaymentDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			//monthlyPaymentScrollBar.Maximum = monthlyPaymentDataGridView.RowCount;
			//monthlyPaymentScrollBar.Value = 0;
		}

		private void monthlyPaymentDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			//monthlyPaymentScrollBar.Maximum = monthlyPaymentDataGridView.RowCount;
			//monthlyPaymentScrollBar.Value = 0;
		}

		private void DebtScrollBar_Scroll(object sender, ScrollEventArgs e)
		{
			if (e.NewValue > -1 && e.NewValue < debtDataGridView.Rows.Count)
			{
				debtDataGridView.FirstDisplayedScrollingRowIndex = e.NewValue;
			}
		}

		private void debtDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			//debtScrollBar.Maximum = debtDataGridView.RowCount;
			//debtScrollBar.Value = 0;
		}

		private void debtDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			//debtScrollBar.Maximum = debtDataGridView.RowCount;
			//debtScrollBar.Value = 0;
		}

		//@ Обработка кнопок на главном меню
		//_________________________________________________________________________________________
		private void HistoryLabel_MouseDown(object sender, MouseEventArgs e)
		{
			MenuLabel_MouseDown(historyLable);
		}

		private void HistoryLabel_MouseUp(object sender, MouseEventArgs e)
		{
			MenuLabel_MouseUp(historyLable);
		}

		private void HistoryLable_Click(object sender, EventArgs e)
		{
			tabControl1.SelectTab(0);

			historyLable.ForeColor = Color.FromArgb(248, 226, 255);
			monthlyPaymentLabel.ForeColor = Color.FromArgb(127, 10, 150);
			debtLabel.ForeColor = Color.FromArgb(127, 10, 150);
		}

		private void MonthlyPaymentLabel_MouseDown(object sender, MouseEventArgs e)
		{
			MenuLabel_MouseDown(monthlyPaymentLabel);
		}


		private void MonthlyPaymentLabel_MouseUp(object sender, MouseEventArgs e)
		{
			MenuLabel_MouseUp(monthlyPaymentLabel);
		}

		private void MonthlyPaymentLabel_Click(object sender, EventArgs e)
		{
			tabControl1.SelectTab(1);

			historyLable.ForeColor = Color.FromArgb(127, 10, 150);
			monthlyPaymentLabel.ForeColor = Color.FromArgb(248, 226, 255);
			debtLabel.ForeColor = Color.FromArgb(127, 10, 150);
		}

		private void DebtLabel_MouseDown(object sender, MouseEventArgs e)
		{
			MenuLabel_MouseDown(debtLabel);
		}

		private void DebtLabel_MouseUp(object sender, MouseEventArgs e)
		{
			MenuLabel_MouseUp(debtLabel);
		}

		private void DebtLabel_Click(object sender, EventArgs e)
		{
			tabControl1.SelectTab(2);

			historyLable.ForeColor = Color.FromArgb(127, 10, 150);
			monthlyPaymentLabel.ForeColor = Color.FromArgb(127, 10, 150);
			debtLabel.ForeColor = Color.FromArgb(248, 226, 255);
		}


		private void MenuLabel_MouseDown(Label label)
		{
			label.Font = new Font("Microsoft Sans Serif", 13.5F);
			label.Location = new Point(label.Location.X + 2, label.Location.Y + 1);
		}

		private void MenuLabel_MouseUp(Label label)
		{
			label.Font = new Font("Microsoft Sans Serif", 14F);
			label.Location = new Point(label.Location.X - 2, label.Location.Y - 1);
		}




		//_______________________________________________________________________________________________
	}
}
