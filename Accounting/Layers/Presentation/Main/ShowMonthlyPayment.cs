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
		List<MonthlyPaymentTable> notHandledMonthlyPayments;

		private void LoadNotHandledMonthlyPayments()
		{
			notHandledMonthlyPayments = Storage.LoadNotHandledMonthlyPayments();

			for (int i = 0; i < notHandledMonthlyPayments.Count; i++)
			{
				AddTransaction(notHandledMonthlyPayments[i].M_To, notHandledMonthlyPayments[i].M_From,
					notHandledMonthlyPayments[i].M_Amount.ToString(), notHandledMonthlyPayments[i].M_Description);

				notHandledMonthlyPayments[i].M_LastDate = DateTime.Now;
				notHandledMonthlyPayments[i].M_Status = "Не оплачено";

				Storage.UpdateMonthlyPayment(notHandledMonthlyPayments[i]);
			}
		}

		private void LoadMonthlyPayments()
		{
			LoadNotHandledMonthlyPayments();


			monthlyPaymentList = Storage.LoadMonthlyPayments(monthlyPaymentIndex);
			monthlyPaymentDataGridView.DataSource = monthlyPaymentList;



			if (monthlyPaymentDataGridView.ColumnCount == 8)
			{
				monthlyPaymentDataGridView.Columns[0].Visible = false;
				//monthlyPaymentDataGridView.Columns[0].HeaderText = "Id";

				monthlyPaymentDataGridView.Columns[1].HeaderText = "От кого";
				monthlyPaymentDataGridView.Columns[1].Width = 150;

				monthlyPaymentDataGridView.Columns[2].HeaderText = "Кому";
				monthlyPaymentDataGridView.Columns[2].Width = 150;

				monthlyPaymentDataGridView.Columns[3].HeaderText = "Сумма";
				monthlyPaymentDataGridView.Columns[3].Width = 150;

				monthlyPaymentDataGridView.Columns[4].HeaderText = "Число месяца";
				monthlyPaymentDataGridView.Columns[4].Width = 100;


                monthlyPaymentDataGridView.Columns[5].Visible = false;
                //monthlyPaymentDataGridView.Columns[5].HeaderText = "Last";

                monthlyPaymentDataGridView.Columns[6].HeaderText = "Описание";
				monthlyPaymentDataGridView.Columns[6].Width = 150;

				monthlyPaymentDataGridView.Columns[7].HeaderText = "Статус";
				monthlyPaymentDataGridView.Columns[7].Width = 200;
                monthlyPaymentDataGridView.Columns[7].HeaderCell.Style.Padding = new Padding(0, 5, 60, 5);
                monthlyPaymentDataGridView.Columns[7].DefaultCellStyle.Padding = new Padding(0, 5, 60, 5);


            }
        }
		private void MonthlyPaymentComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{


			switch (monthlyPaymentComboBox.SelectedIndex)
			{
				case 0:
					monthlyPaymentIndex = ((int)WhoComboBoxItems.All);
					break;
				case 1:
					monthlyPaymentIndex = ((int)WhoComboBoxItems.ToMe);
					break;
				case 2:
					monthlyPaymentIndex = ((int)WhoComboBoxItems.FromMe);
					break;
			}

			LoadMonthlyPayments();

			monthlyPaymentDataGridView.ClearSelection();
		}


		private void StatusMonthlyContextMenuItem_Click(object sender, EventArgs e)
		{
			var monthlyPayment = monthlyPaymentList[selectedMonthlyPaymentRow];

			if (monthlyPayment.M_Status == "Оплачено")
				monthlyPayment.M_Status = "Не оплачено";
			else if (monthlyPayment.M_Status == "Не оплачено")
				monthlyPayment.M_Status = "Оплачено";

			try
			{
				Storage.UpdateMonthlyPayment(monthlyPayment);
				LoadMonthlyPayments();
				LoadData();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void AddMonthlyContextMenuItem_Click(object sender, EventArgs e)
		{
			monthlyPaymentForm = new MonthlyPaymentForm();
			Hide();
			monthlyPaymentForm.ShowDialog();
			Show();

			if (monthlyPaymentForm.monthlyPaymentIsCorrect)
				AddMonthlyPayment(monthlyPaymentForm.fromText, monthlyPaymentForm.toText, monthlyPaymentForm.amountText,
					monthlyPaymentForm.dateText, monthlyPaymentForm.descriptionText, monthlyPaymentForm.statusText);


		}

		private void UpdateMonthlyContextMenuItem_Click(object sender, EventArgs e)
		{
			if (selectedMonthlyPaymentRow >= 0)
			{
				var monthlyPayment = monthlyPaymentList[selectedMonthlyPaymentRow];

				monthlyPaymentForm = new MonthlyPaymentForm();

				monthlyPaymentForm.fromText = monthlyPayment.M_From;
				monthlyPaymentForm.toText = monthlyPayment.M_To;
				monthlyPaymentForm.amountText = monthlyPayment.M_Amount.ToString();
				monthlyPaymentForm.descriptionText = monthlyPayment.M_Description;
				monthlyPaymentForm.dateText = monthlyPayment.M_Date.ToString();
				monthlyPaymentForm.statusText = monthlyPayment.M_Status;

				Hide();
				monthlyPaymentForm.ShowDialog();
				Show();

				if (monthlyPaymentForm.monthlyPaymentIsCorrect)
				{
					monthlyPayment.M_From = monthlyPaymentForm.fromText;
					monthlyPayment.M_To = monthlyPaymentForm.toText;
					monthlyPayment.M_Amount = Convert.ToInt32(monthlyPaymentForm.amountText);
					monthlyPayment.M_Description = monthlyPaymentForm.descriptionText;
					monthlyPayment.M_Date = Convert.ToInt32(monthlyPaymentForm.dateText);
					monthlyPayment.M_Status = monthlyPaymentForm.statusText;

					try
					{
						Storage.UpdateMonthlyPayment(monthlyPayment);
						LoadMonthlyPayments();
						LoadData();
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
				}
			}
		}

		private void DeleteMonthlyContextMenuItem_Click(object sender, EventArgs e)
		{
			if (selectedMonthlyPaymentRow >= 0)
			{
				int id = monthlyPaymentList[selectedMonthlyPaymentRow].M_Id;
				Storage.DeleteMonthlyPayment(id);
				LoadMonthlyPayments();
				LoadData();
			}
		}

		private void AddMonthlyPayment(string fromText, string toText, string amountText,
			string dateTimeText, string descriptionText, string statusText)
		{
			try
			{
				MonthlyPaymentTable monthlyPaymentTable = new MonthlyPaymentTable()
				{
					M_From = fromText,
					M_To = toText,
					M_Amount = Convert.ToInt32(amountText),
					M_Date = Convert.ToInt32(dateTimeText),
					M_Description = descriptionText,
					M_Status = statusText
				};

				if (statusText == "Оплачено")
					monthlyPaymentTable.M_LastDate = DateTime.Now;

				Storage.AddMonthlyPayment(monthlyPaymentTable);


				LoadMonthlyPayments();
				LoadData();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		DateTime CorrectDate(string date)
		{
			string[] buf = date.Split(' ', '\\', '/', '.', ',', '_');
			if (buf.Length < 3)
				return (DateTime.MinValue);
			int day = Convert.ToInt16(buf[0]);
			int month = Convert.ToInt16(buf[1]);
			int year = Convert.ToInt16(buf[2]);
			if (year < 2000)
				year += 2000;

			try
			{
				return (new DateTime(year, month, day));
			}
			catch (Exception ex)
			{
				throw ex;
			};
		}

		enum PaymentStatus
		{
			NotPayed = 0,
			Payed = 1
		}

		private void MonthlyPaymentDataGridView_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				var hit = monthlyPaymentDataGridView.HitTest(e.X, e.Y);
				if (hit.RowIndex >= 0)
				{
					monthlyPaymentDataGridView.ClearSelection();
					monthlyPaymentDataGridView.Rows[hit.RowIndex].Selected = true;
					selectedMonthlyPaymentRow = hit.RowIndex;
				}
			}
		}
	}
}
