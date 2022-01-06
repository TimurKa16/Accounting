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
using System.Threading;

namespace Accounting
{
	public partial class PresentationForm : Form
	{


		int selectedTransactionRow = -1;
		TransactionForm transactionForm;

		List<TransactionsTable> transactionList = new List<TransactionsTable>();
		int numberOfDays = 0;

		List<Debt> debtList = new List<Debt>();
		int debtIndex = 0;

		int selectedMonthlyPaymentRow = -1;
		MonthlyPaymentForm monthlyPaymentForm;


		List<MonthlyPaymentTable> monthlyPaymentList = new List<MonthlyPaymentTable>();
		int monthlyPaymentIndex = 0;


		public PresentationForm()
		{
			InitializeComponent();
			Init();
		}


		private void PresentationForm_Load(object sender, EventArgs e)
		{


			//LoadMonthlyPayments(); - Здесь убрал, т.к. Необработанные ежемесячные платежи обрабатываются 2 раза
			LoadData();
			VisualChanges();

		}





		void VisualChanges()
		{

			historyDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			monthlyPaymentDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			debtDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

			historyDataGridView.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			monthlyPaymentDataGridView.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			debtDataGridView.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

			monthlyPaymentDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			monthlyPaymentDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

			debtDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			debtDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

			FormBorderStyle = FormBorderStyle.None;
			Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));

			historyDataGridView.MouseWheel += new MouseEventHandler(this.DatagridView_MouseWheel);
			monthlyPaymentDataGridView.MouseWheel += new MouseEventHandler(this.DatagridView_MouseWheel);
			debtDataGridView.MouseWheel += new MouseEventHandler(this.DatagridView_MouseWheel);

			if (historyDataGridView.Rows.Count > 0)
				historyDataGridView.Rows[0].Selected = true;

			if (monthlyPaymentDataGridView.Rows.Count > 0)
				monthlyPaymentDataGridView.Rows[0].Selected = true;

			if (debtDataGridView.Rows.Count > 0)
				debtDataGridView.Rows[0].Selected = true;

			ClearDataGridSelection();


			HideTabControl();
		}


		private void HideTabControl()
		{
			DrawButton(tabControl1.Location.X, tabControl1.Location.Y, 5, tabControl1.Height);
			DrawButton(tabControl1.Location.X, tabControl1.Location.Y, tabControl1.Width, 25);
			DrawButton(tabControl1.Location.X + tabControl1.Width - 5, tabControl1.Location.Y, 5, tabControl1.Height);
			DrawButton(tabControl1.Location.X, tabControl1.Height + 45, tabControl1.Width, 5);
		}

		private void DrawButton(int X, int Y, int width, int height)
		{
			Button button = new Button();
			button.Location = new Point(X, Y);
			button.Width = width;
			button.Height = height;

			Controls.Add(button);
			button.BringToFront();
			button.FlatStyle = FlatStyle.Flat;
			button.FlatAppearance.BorderColor = Color.FromArgb(14, 14, 14);
			button.FlatAppearance.MouseDownBackColor = Color.FromArgb(14, 14, 14);
			button.FlatAppearance.MouseOverBackColor = Color.FromArgb(14, 14, 14);
		}

		private void ClearDataGridSelection()
		{
			historyDataGridView.ClearSelection();
			monthlyPaymentDataGridView.ClearSelection();
			debtDataGridView.ClearSelection();
		}

		private void PresentationForm_Shown(object sender, EventArgs e)
		{
			historyDataGridView.Focus();
		}
		void Init()
		{
			SetHook();

			historyComboBox.SelectedIndex = 0;
			debtComboBox.SelectedIndex = 0;
			monthlyPaymentComboBox.SelectedIndex = 0;

			Storage.Init();
		}

		private void LoadData()
		{
			LoadHistory();
			LoadDebts();

			ClearDataGridSelection();
		}


		private void HistoryTab_MouseEnter(object sender, EventArgs e)
		{
			label2.Focus();
		}
	}
}
