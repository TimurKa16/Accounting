
namespace Accounting
{
    partial class PresentationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.historyContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.totalTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.debtComboBox = new System.Windows.Forms.ComboBox();
            this.debtDataGridView = new System.Windows.Forms.DataGridView();
            this.historyTab = new System.Windows.Forms.TabPage();
            this.historyComboBox = new System.Windows.Forms.ComboBox();
            this.historyDataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MonthlyPay = new System.Windows.Forms.TabPage();
            this.monthlyPaymentComboBox = new System.Windows.Forms.ComboBox();
            this.monthlyPaymentDataGridView = new System.Windows.Forms.DataGridView();
            this.monthlyPaymentContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.historyLable = new System.Windows.Forms.Label();
            this.monthlyPaymentLabel = new System.Windows.Forms.Label();
            this.debtLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.historyContextMenuStrip.SuspendLayout();
            this.totalTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.debtDataGridView)).BeginInit();
            this.historyTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.MonthlyPay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyPaymentDataGridView)).BeginInit();
            this.monthlyPaymentContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // historyContextMenuStrip
            // 
            this.historyContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.удалитьToolStripMenuItem1});
            this.historyContextMenuStrip.Name = "historyContextMenuStrip";
            this.historyContextMenuStrip.Size = new System.Drawing.Size(155, 70);
            this.historyContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.HistoryContextMenuStrip_Opening);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.AddHistoryContextMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.удалитьToolStripMenuItem.Text = "Редактировать";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.UpdateHistoryContextMenuItem_Click);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.DeleteHistoryContextMenuItem_Click);
            // 
            // totalTab
            // 
            this.totalTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.totalTab.Controls.Add(this.label1);
            this.totalTab.Controls.Add(this.debtComboBox);
            this.totalTab.Controls.Add(this.debtDataGridView);
            this.totalTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(9)))), ((int)(((byte)(44)))));
            this.totalTab.Location = new System.Drawing.Point(4, 25);
            this.totalTab.Name = "totalTab";
            this.totalTab.Size = new System.Drawing.Size(892, 707);
            this.totalTab.TabIndex = 101;
            this.totalTab.Text = "Итог";
            this.totalTab.ToolTipText = "Кто кому остался должен";
            this.totalTab.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PresentationForm_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(331, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 16);
            this.label1.TabIndex = 102;
            this.label1.Text = "Кто кому остался должен";
            // 
            // debtComboBox
            // 
            this.debtComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Все",
            "Мне",
            "От меня"});
            this.debtComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(10)))), ((int)(((byte)(150)))));
            this.debtComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.debtComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.debtComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.debtComboBox.FormattingEnabled = true;
            this.debtComboBox.Items.AddRange(new object[] {
            "Все",
            "Мне",
            "От меня"});
            this.debtComboBox.Location = new System.Drawing.Point(16, 9);
            this.debtComboBox.Name = "debtComboBox";
            this.debtComboBox.Size = new System.Drawing.Size(121, 23);
            this.debtComboBox.TabIndex = 103;
            this.debtComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DebtComboBox_DrawItem);
            this.debtComboBox.DropDown += new System.EventHandler(this.DebtComboBox_DropDown);
            this.debtComboBox.SelectedIndexChanged += new System.EventHandler(this.DebtComboBox_SelectedIndexChanged);
            this.debtComboBox.DropDownClosed += new System.EventHandler(this.DebtComboBox_DropDownClosed);
            this.debtComboBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DebtComboBox_MouseDown);
            this.debtComboBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DebtComboBox_MouseMove);
            // 
            // debtDataGridView
            // 
            this.debtDataGridView.AllowUserToAddRows = false;
            this.debtDataGridView.AllowUserToDeleteRows = false;
            this.debtDataGridView.AllowUserToResizeColumns = false;
            this.debtDataGridView.AllowUserToResizeRows = false;
            this.debtDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.debtDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.debtDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.debtDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(10)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(10)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.debtDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.debtDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(9)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(81)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(9)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.debtDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.debtDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.debtDataGridView.EnableHeadersVisualStyles = false;
            this.debtDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.debtDataGridView.Location = new System.Drawing.Point(240, 66);
            this.debtDataGridView.Name = "debtDataGridView";
            this.debtDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.debtDataGridView.RowHeadersVisible = false;
            this.debtDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.debtDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.debtDataGridView.Size = new System.Drawing.Size(450, 635);
            this.debtDataGridView.TabIndex = 104;
            this.debtDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.debtDataGridView_RowsAdded);
            this.debtDataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.debtDataGridView_RowsRemoved);
            // 
            // historyTab
            // 
            this.historyTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.historyTab.Controls.Add(this.historyComboBox);
            this.historyTab.Controls.Add(this.historyDataGridView);
            this.historyTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(9)))), ((int)(((byte)(44)))));
            this.historyTab.Location = new System.Drawing.Point(4, 25);
            this.historyTab.Name = "historyTab";
            this.historyTab.Padding = new System.Windows.Forms.Padding(3);
            this.historyTab.Size = new System.Drawing.Size(892, 707);
            this.historyTab.TabIndex = 104;
            this.historyTab.Text = "История";
            this.historyTab.ToolTipText = "История всех переводов";
            this.historyTab.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PresentationForm_MouseDown);
            this.historyTab.MouseEnter += new System.EventHandler(this.HistoryTab_MouseEnter);
            // 
            // historyComboBox
            // 
            this.historyComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(10)))), ((int)(((byte)(150)))));
            this.historyComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.historyComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historyComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.historyComboBox.FormattingEnabled = true;
            this.historyComboBox.Items.AddRange(new object[] {
            "Всё время",
            "Год",
            "Месяц",
            "Неделю",
            "День"});
            this.historyComboBox.Location = new System.Drawing.Point(16, 9);
            this.historyComboBox.Name = "historyComboBox";
            this.historyComboBox.Size = new System.Drawing.Size(121, 23);
            this.historyComboBox.TabIndex = 106;
            this.historyComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.HistoryComboBox_DrawItem);
            this.historyComboBox.DropDown += new System.EventHandler(this.HistoryComboBox_DropDown);
            this.historyComboBox.SelectedIndexChanged += new System.EventHandler(this.HistoryComboBox_SelectedIndexChanged);
            this.historyComboBox.DropDownClosed += new System.EventHandler(this.HistoryComboBox_DropDownClosed);
            this.historyComboBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HistoryComboBox_MouseDown);
            this.historyComboBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HistoryComboBox_MouseMove);
            // 
            // historyDataGridView
            // 
            this.historyDataGridView.AllowUserToAddRows = false;
            this.historyDataGridView.AllowUserToDeleteRows = false;
            this.historyDataGridView.AllowUserToResizeColumns = false;
            this.historyDataGridView.AllowUserToResizeRows = false;
            this.historyDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.historyDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.historyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.historyDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.historyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(10)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(10)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.historyDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.historyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyDataGridView.ContextMenuStrip = this.historyContextMenuStrip;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(9)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(81)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(9)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.historyDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.historyDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.historyDataGridView.EnableHeadersVisualStyles = false;
            this.historyDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.historyDataGridView.Location = new System.Drawing.Point(48, 69);
            this.historyDataGridView.Name = "historyDataGridView";
            this.historyDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.historyDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.historyDataGridView.RowHeadersVisible = false;
            this.historyDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.historyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.historyDataGridView.Size = new System.Drawing.Size(800, 635);
            this.historyDataGridView.TabIndex = 107;
            this.historyDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.historyDataGridView_RowsAdded);
            this.historyDataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.historyDataGridView_RowsRemoved);
            this.historyDataGridView.MouseEnter += new System.EventHandler(this.HistoryTab_MouseEnter);
            this.historyDataGridView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HistoryDataGridView_MouseUp);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.historyTab);
            this.tabControl1.Controls.Add(this.MonthlyPay);
            this.tabControl1.Controls.Add(this.totalTab);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(12, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(900, 736);
            this.tabControl1.TabIndex = 108;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            this.tabControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PresentationForm_MouseDown);
            this.tabControl1.MouseEnter += new System.EventHandler(this.HistoryTab_MouseEnter);
            // 
            // MonthlyPay
            // 
            this.MonthlyPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.MonthlyPay.Controls.Add(this.monthlyPaymentComboBox);
            this.MonthlyPay.Controls.Add(this.monthlyPaymentDataGridView);
            this.MonthlyPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(9)))), ((int)(((byte)(44)))));
            this.MonthlyPay.Location = new System.Drawing.Point(4, 25);
            this.MonthlyPay.Name = "MonthlyPay";
            this.MonthlyPay.Padding = new System.Windows.Forms.Padding(3);
            this.MonthlyPay.Size = new System.Drawing.Size(892, 707);
            this.MonthlyPay.TabIndex = 109;
            this.MonthlyPay.Text = "Ежемесячные платежи";
            this.MonthlyPay.ToolTipText = "Ежемесячные платежи";
            this.MonthlyPay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PresentationForm_MouseDown);
            // 
            // monthlyPaymentComboBox
            // 
            this.monthlyPaymentComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Все",
            "Мне",
            "От меня"});
            this.monthlyPaymentComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(10)))), ((int)(((byte)(150)))));
            this.monthlyPaymentComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.monthlyPaymentComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monthlyPaymentComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.monthlyPaymentComboBox.FormattingEnabled = true;
            this.monthlyPaymentComboBox.Items.AddRange(new object[] {
            "Все",
            "Мне",
            "От меня"});
            this.monthlyPaymentComboBox.Location = new System.Drawing.Point(16, 9);
            this.monthlyPaymentComboBox.Name = "monthlyPaymentComboBox";
            this.monthlyPaymentComboBox.Size = new System.Drawing.Size(121, 23);
            this.monthlyPaymentComboBox.TabIndex = 110;
            this.monthlyPaymentComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.MonthlyPaymentComboBox_DrawItem);
            this.monthlyPaymentComboBox.DropDown += new System.EventHandler(this.MonthlyPaymentComboBox_DropDown);
            this.monthlyPaymentComboBox.SelectedIndexChanged += new System.EventHandler(this.MonthlyPaymentComboBox_SelectedIndexChanged);
            this.monthlyPaymentComboBox.DropDownClosed += new System.EventHandler(this.MonthlyPaymentComboBox_DropDownClosed);
            this.monthlyPaymentComboBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MonthlyPaymentComboBox_MouseDown);
            this.monthlyPaymentComboBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MonthlyPaymentComboBox_MouseMove);
            // 
            // monthlyPaymentDataGridView
            // 
            this.monthlyPaymentDataGridView.AllowUserToAddRows = false;
            this.monthlyPaymentDataGridView.AllowUserToDeleteRows = false;
            this.monthlyPaymentDataGridView.AllowUserToResizeColumns = false;
            this.monthlyPaymentDataGridView.AllowUserToResizeRows = false;
            this.monthlyPaymentDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.monthlyPaymentDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.monthlyPaymentDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.monthlyPaymentDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(10)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(10)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.monthlyPaymentDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.monthlyPaymentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monthlyPaymentDataGridView.ContextMenuStrip = this.monthlyPaymentContextMenuStrip;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(9)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(81)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(9)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.monthlyPaymentDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.monthlyPaymentDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.monthlyPaymentDataGridView.EnableHeadersVisualStyles = false;
            this.monthlyPaymentDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.monthlyPaymentDataGridView.Location = new System.Drawing.Point(16, 66);
            this.monthlyPaymentDataGridView.Name = "monthlyPaymentDataGridView";
            this.monthlyPaymentDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.monthlyPaymentDataGridView.RowHeadersVisible = false;
            this.monthlyPaymentDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.monthlyPaymentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.monthlyPaymentDataGridView.Size = new System.Drawing.Size(850, 635);
            this.monthlyPaymentDataGridView.TabIndex = 111;
            this.monthlyPaymentDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.monthlyPaymentDataGridView_RowsAdded);
            this.monthlyPaymentDataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.monthlyPaymentDataGridView_RowsRemoved);
            this.monthlyPaymentDataGridView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MonthlyPaymentDataGridView_MouseUp);
            // 
            // monthlyPaymentContextMenuStrip
            // 
            this.monthlyPaymentContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusContextMenuItem,
            this.addContextMenuItem,
            this.updateContextMenuItem,
            this.deleteContextMenuItem});
            this.monthlyPaymentContextMenuStrip.Name = "historyContextMenuStrip";
            this.monthlyPaymentContextMenuStrip.Size = new System.Drawing.Size(155, 92);
            // 
            // statusContextMenuItem
            // 
            this.statusContextMenuItem.Name = "statusContextMenuItem";
            this.statusContextMenuItem.Size = new System.Drawing.Size(154, 22);
            this.statusContextMenuItem.Text = "Статус";
            this.statusContextMenuItem.Click += new System.EventHandler(this.StatusMonthlyContextMenuItem_Click);
            // 
            // addContextMenuItem
            // 
            this.addContextMenuItem.Name = "addContextMenuItem";
            this.addContextMenuItem.Size = new System.Drawing.Size(154, 22);
            this.addContextMenuItem.Text = "Добавить";
            this.addContextMenuItem.Click += new System.EventHandler(this.AddMonthlyContextMenuItem_Click);
            // 
            // updateContextMenuItem
            // 
            this.updateContextMenuItem.Name = "updateContextMenuItem";
            this.updateContextMenuItem.Size = new System.Drawing.Size(154, 22);
            this.updateContextMenuItem.Text = "Редактировать";
            this.updateContextMenuItem.Click += new System.EventHandler(this.UpdateMonthlyContextMenuItem_Click);
            // 
            // deleteContextMenuItem
            // 
            this.deleteContextMenuItem.Name = "deleteContextMenuItem";
            this.deleteContextMenuItem.Size = new System.Drawing.Size(154, 22);
            this.deleteContextMenuItem.Text = "Удалить";
            this.deleteContextMenuItem.Click += new System.EventHandler(this.DeleteMonthlyContextMenuItem_Click);
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Wingdings 2", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(81)))), ((int)(((byte)(219)))));
            this.exitButton.Location = new System.Drawing.Point(818, 14);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(37, 36);
            this.exitButton.TabIndex = 112;
            this.exitButton.Text = "O";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.exitButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExitButton_MouseDown);
            this.exitButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ExitButton_MouseUp);
            // 
            // historyLable
            // 
            this.historyLable.AutoSize = true;
            this.historyLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.historyLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.historyLable.Location = new System.Drawing.Point(203, 22);
            this.historyLable.Name = "historyLable";
            this.historyLable.Size = new System.Drawing.Size(86, 24);
            this.historyLable.TabIndex = 90;
            this.historyLable.Text = "История";
            this.historyLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.historyLable.Click += new System.EventHandler(this.HistoryLable_Click);
            this.historyLable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HistoryLabel_MouseDown);
            this.historyLable.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HistoryLabel_MouseUp);
            // 
            // monthlyPaymentLabel
            // 
            this.monthlyPaymentLabel.AutoSize = true;
            this.monthlyPaymentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.monthlyPaymentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(81)))), ((int)(((byte)(219)))));
            this.monthlyPaymentLabel.Location = new System.Drawing.Point(295, 22);
            this.monthlyPaymentLabel.Name = "monthlyPaymentLabel";
            this.monthlyPaymentLabel.Size = new System.Drawing.Size(219, 24);
            this.monthlyPaymentLabel.TabIndex = 91;
            this.monthlyPaymentLabel.Text = "Ежемесячные платежи";
            this.monthlyPaymentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.monthlyPaymentLabel.Click += new System.EventHandler(this.MonthlyPaymentLabel_Click);
            this.monthlyPaymentLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MonthlyPaymentLabel_MouseDown);
            this.monthlyPaymentLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MonthlyPaymentLabel_MouseUp);
            // 
            // debtLabel
            // 
            this.debtLabel.AutoSize = true;
            this.debtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.debtLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(81)))), ((int)(((byte)(219)))));
            this.debtLabel.Location = new System.Drawing.Point(520, 22);
            this.debtLabel.Name = "debtLabel";
            this.debtLabel.Size = new System.Drawing.Size(53, 24);
            this.debtLabel.TabIndex = 92;
            this.debtLabel.Text = "Итог";
            this.debtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.debtLabel.Click += new System.EventHandler(this.DebtLabel_Click);
            this.debtLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DebtLabel_MouseDown);
            this.debtLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DebtLabel_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.label2.Location = new System.Drawing.Point(9, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 113;
            this.label2.Text = "!!!!!!!!!!!!!!!!!!!!!!";
            // 
            // PresentationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(925, 800);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.debtLabel);
            this.Controls.Add(this.monthlyPaymentLabel);
            this.Controls.Add(this.historyLable);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PresentationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PresentationForm_Load);
            this.Shown += new System.EventHandler(this.PresentationForm_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PresentationForm_MouseDown);
            this.MouseEnter += new System.EventHandler(this.HistoryTab_MouseEnter);
            this.historyContextMenuStrip.ResumeLayout(false);
            this.totalTab.ResumeLayout(false);
            this.totalTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.debtDataGridView)).EndInit();
            this.historyTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.MonthlyPay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.monthlyPaymentDataGridView)).EndInit();
            this.monthlyPaymentContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip historyContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.TabPage totalTab;
        private System.Windows.Forms.DataGridView debtDataGridView;
        private System.Windows.Forms.TabPage historyTab;
        private System.Windows.Forms.ComboBox historyComboBox;
        private System.Windows.Forms.DataGridView historyDataGridView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ComboBox debtComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage MonthlyPay;
        private System.Windows.Forms.DataGridView monthlyPaymentDataGridView;
        private System.Windows.Forms.ComboBox monthlyPaymentComboBox;
        private System.Windows.Forms.ContextMenuStrip monthlyPaymentContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem statusContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteContextMenuItem;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label historyLable;
        private System.Windows.Forms.Label monthlyPaymentLabel;
        private System.Windows.Forms.Label debtLabel;
        private System.Windows.Forms.Label label2;
    }
}

