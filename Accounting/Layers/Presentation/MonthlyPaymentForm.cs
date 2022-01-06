using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Accounting
{
	public partial class MonthlyPaymentForm : Form
	{
		public string fromText;
		public string toText;
		public string amountText;
		public string descriptionText;
		public string dateText;
		public string statusText;
		bool status;

		public bool monthlyPaymentIsCorrect = false;

		public MonthlyPaymentForm()
		{
			InitializeComponent();
			

			FormBorderStyle = FormBorderStyle.None;
			Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
		}

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


		private void MonthlyPaymentForm_Load(object sender, EventArgs e)
		{

			fromTextBox.Text = fromText;
			toTextBox.Text = toText;
			amountTextBox.Text = amountText;
			dateTextBox.Text = dateText;
			descriptionTextBox.Text = descriptionText;
			
			if (statusText == "Оплачено")
			{
				status = true;
				statusTextBox.Text = statusText;
				statusTextBox.BackColor = Color.Green;
			}
			else
			{
				status = false;
				statusText = "Не оплачено";
				statusTextBox.Text = statusText;
				statusTextBox.BackColor = Color.Red;
			}

			DrawForm();
		}

		



		private void StatusTextBox_MouseClick(object sender, MouseEventArgs e)
		{
			if (statusTextBox.Text == "Не оплачено")
			{
				status = true;
				statusText = "Оплачено";
				statusTextBox.Text = statusText;
				statusTextBox.BackColor = Color.Green;
			}
			else if (statusTextBox.Text == "Оплачено")
			{
				status = false;
				statusText = "Не оплачено";
				statusTextBox.Text = statusText;
				statusTextBox.BackColor = Color.Red;
			}
		}

		private void button1_MouseDown(object sender, MouseEventArgs e)
		{
			if (status)
			{
				this.statusTextBox.FlatAppearance.MouseDownBackColor = Color.Green;
			}
			else
				this.statusTextBox.FlatAppearance.MouseDownBackColor = Color.Red;

			this.statusTextBox.FlatAppearance.BorderSize = 1;
		}


		private void statusTextBox_MouseMove(object sender, MouseEventArgs e)
		{
			if (status)
			{
				this.statusTextBox.FlatAppearance.MouseOverBackColor = Color.Green;
				this.statusTextBox.FlatAppearance.MouseDownBackColor = Color.Green;

			}
			else
			{
				this.statusTextBox.FlatAppearance.MouseOverBackColor = Color.Red;
				this.statusTextBox.FlatAppearance.MouseDownBackColor = Color.Red;
			}

		}

		private void OkLabel_Click(object sender, EventArgs e)
		{
			
		}



        private void ExitLabel_Click(object sender, EventArgs e)
        {
			Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
			try
			{
				bool textboxesAreEmpty = false;

				if (string.IsNullOrWhiteSpace(fromTextBox.Text))
					textboxesAreEmpty = true;
				else if (string.IsNullOrWhiteSpace(toTextBox.Text))
					textboxesAreEmpty = true;
				else if (string.IsNullOrWhiteSpace(amountTextBox.Text))
					textboxesAreEmpty = true;
				else if (string.IsNullOrWhiteSpace(dateTextBox.Text))
					textboxesAreEmpty = true;

				if (textboxesAreEmpty)
					MessageBox.Show("Заполните все поля!");
				else
				{
					fromText = fromTextBox.Text;
					toText = toTextBox.Text;
					amountText = amountTextBox.Text;
					dateText = dateTextBox.Text;
					descriptionText = descriptionTextBox.Text;


					monthlyPaymentIsCorrect = true;

					Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

        private void OkButton_MouseDown(object sender, MouseEventArgs e)
        {
			okButton.Font = new Font("Wingdings 2", 23F);
			okButton.Location = new Point(okButton.Location.X - 1, okButton.Location.Y + 2);
		}

        private void OkButton_MouseUp(object sender, MouseEventArgs e)
        {
			okButton.Font = new Font("Wingdings 2", 26F);
			okButton.Location = new Point(okButton.Location.X + 1, okButton.Location.Y - 2);
		}

        private void ExitButton_Click(object sender, EventArgs e)
        {
			Close();
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

        private void MonthlyPaymentForm_MouseDown(object sender, MouseEventArgs e)
        {
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

        private void statusTextBoxLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void descriptionTextBoxLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void fromTextBox_TextChanged(object sender, EventArgs e)
        {
			
		}

		private void DrawForm()
        {
			int maxLinesLength = 1;

			if (fromTextBox.Lines.Length > maxLinesLength)
				maxLinesLength = fromTextBox.Lines.Length;
			if (toTextBox.Lines.Length > maxLinesLength)
				maxLinesLength = toTextBox.Lines.Length;
			if (amountTextBox.Lines.Length > maxLinesLength)
				maxLinesLength = amountTextBox.Lines.Length;
			if (descriptionTextBox.Lines.Length > maxLinesLength)
				maxLinesLength = descriptionTextBox.Lines.Length;


			fromTextBox.Height = 20 * maxLinesLength + 10;
			toTextBox.Height = 20 * maxLinesLength + 10;
			amountTextBox.Height = 20 * maxLinesLength + 10;
			descriptionTextBox.Height = 20 * maxLinesLength + 10;

			okButton.Location = new Point(okButton.Location.X, fromTextBox.Location.Y + fromTextBox.Height + 10 + 10);
			exitButton.Location = new Point(exitButton.Location.X, fromTextBox.Location.Y + fromTextBox.Height + 10 + 10);
			Height = 120 + 10 + fromTextBox.Height;
			Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
		}

        private void MonthlyPaymentForm_Shown(object sender, EventArgs e)
        {
			//label1.BackColor = Color.White;
			label1.Focus();
        }

    }
}
