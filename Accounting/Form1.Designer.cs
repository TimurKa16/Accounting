
namespace Accounting
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.newTab = new System.Windows.Forms.TabPage();
            this.historyTab = new System.Windows.Forms.TabPage();
            this.totalTab = new System.Windows.Forms.TabPage();
            this.historyDataGridView = new System.Windows.Forms.DataGridView();
            this.TotalDataGridView = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.fromTextboxLabel = new System.Windows.Forms.TextBox();
            this.toTextboxLabel = new System.Windows.Forms.TextBox();
            this.amountTextboxLabel = new System.Windows.Forms.TextBox();
            this.descriptionTextboxLabel = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.fromTextbox = new System.Windows.Forms.TextBox();
            this.toTextbox = new System.Windows.Forms.TextBox();
            this.amountTextbox = new System.Windows.Forms.TextBox();
            this.descriptionTextbox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.newTab.SuspendLayout();
            this.historyTab.SuspendLayout();
            this.totalTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.newTab);
            this.tabControl1.Controls.Add(this.historyTab);
            this.tabControl1.Controls.Add(this.totalTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 400);
            this.tabControl1.TabIndex = 0;
            // 
            // newTab
            // 
            this.newTab.Controls.Add(this.descriptionTextbox);
            this.newTab.Controls.Add(this.amountTextbox);
            this.newTab.Controls.Add(this.toTextbox);
            this.newTab.Controls.Add(this.fromTextbox);
            this.newTab.Controls.Add(this.addButton);
            this.newTab.Controls.Add(this.descriptionTextboxLabel);
            this.newTab.Controls.Add(this.amountTextboxLabel);
            this.newTab.Controls.Add(this.toTextboxLabel);
            this.newTab.Controls.Add(this.fromTextboxLabel);
            this.newTab.Location = new System.Drawing.Point(4, 22);
            this.newTab.Name = "newTab";
            this.newTab.Padding = new System.Windows.Forms.Padding(3);
            this.newTab.Size = new System.Drawing.Size(768, 374);
            this.newTab.TabIndex = 0;
            this.newTab.Text = "Новая транзакция";
            this.newTab.UseVisualStyleBackColor = true;
            // 
            // historyTab
            // 
            this.historyTab.Controls.Add(this.comboBox1);
            this.historyTab.Controls.Add(this.historyDataGridView);
            this.historyTab.Location = new System.Drawing.Point(4, 22);
            this.historyTab.Name = "historyTab";
            this.historyTab.Padding = new System.Windows.Forms.Padding(3);
            this.historyTab.Size = new System.Drawing.Size(768, 374);
            this.historyTab.TabIndex = 1;
            this.historyTab.Text = "История";
            this.historyTab.UseVisualStyleBackColor = true;
            // 
            // totalTab
            // 
            this.totalTab.Controls.Add(this.TotalDataGridView);
            this.totalTab.Location = new System.Drawing.Point(4, 22);
            this.totalTab.Name = "totalTab";
            this.totalTab.Size = new System.Drawing.Size(768, 374);
            this.totalTab.TabIndex = 2;
            this.totalTab.Text = "Итог";
            this.totalTab.UseVisualStyleBackColor = true;
            // 
            // historyDataGridView
            // 
            this.historyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyDataGridView.Location = new System.Drawing.Point(6, 47);
            this.historyDataGridView.Name = "historyDataGridView";
            this.historyDataGridView.Size = new System.Drawing.Size(693, 317);
            this.historyDataGridView.TabIndex = 1;
            // 
            // TotalDataGridView
            // 
            this.TotalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TotalDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalDataGridView.Location = new System.Drawing.Point(0, 0);
            this.TotalDataGridView.Name = "TotalDataGridView";
            this.TotalDataGridView.Size = new System.Drawing.Size(768, 374);
            this.TotalDataGridView.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "за всё время",
            "за год",
            "за месяц",
            "за неделю",
            "за день"});
            this.comboBox1.Location = new System.Drawing.Point(17, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // fromTextboxLabel
            // 
            this.fromTextboxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fromTextboxLabel.Enabled = false;
            this.fromTextboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fromTextboxLabel.Location = new System.Drawing.Point(61, 91);
            this.fromTextboxLabel.Multiline = true;
            this.fromTextboxLabel.Name = "fromTextboxLabel";
            this.fromTextboxLabel.Size = new System.Drawing.Size(100, 23);
            this.fromTextboxLabel.TabIndex = 0;
            this.fromTextboxLabel.Text = "От кого";
            this.fromTextboxLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toTextboxLabel
            // 
            this.toTextboxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toTextboxLabel.Enabled = false;
            this.toTextboxLabel.Location = new System.Drawing.Point(167, 91);
            this.toTextboxLabel.Multiline = true;
            this.toTextboxLabel.Name = "toTextboxLabel";
            this.toTextboxLabel.Size = new System.Drawing.Size(100, 23);
            this.toTextboxLabel.TabIndex = 1;
            this.toTextboxLabel.Text = "Кому";
            this.toTextboxLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // amountTextboxLabel
            // 
            this.amountTextboxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amountTextboxLabel.Enabled = false;
            this.amountTextboxLabel.Location = new System.Drawing.Point(282, 91);
            this.amountTextboxLabel.Multiline = true;
            this.amountTextboxLabel.Name = "amountTextboxLabel";
            this.amountTextboxLabel.Size = new System.Drawing.Size(100, 23);
            this.amountTextboxLabel.TabIndex = 2;
            this.amountTextboxLabel.Text = "Сумма";
            this.amountTextboxLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // descriptionTextboxLabel
            // 
            this.descriptionTextboxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionTextboxLabel.Enabled = false;
            this.descriptionTextboxLabel.Location = new System.Drawing.Point(388, 91);
            this.descriptionTextboxLabel.Multiline = true;
            this.descriptionTextboxLabel.Name = "descriptionTextboxLabel";
            this.descriptionTextboxLabel.Size = new System.Drawing.Size(100, 23);
            this.descriptionTextboxLabel.TabIndex = 3;
            this.descriptionTextboxLabel.Text = "Описание";
            this.descriptionTextboxLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(494, 91);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // fromTextbox
            // 
            this.fromTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fromTextbox.Location = new System.Drawing.Point(61, 120);
            this.fromTextbox.Multiline = true;
            this.fromTextbox.Name = "fromTextbox";
            this.fromTextbox.Size = new System.Drawing.Size(100, 23);
            this.fromTextbox.TabIndex = 5;
            this.fromTextbox.Text = "Описание";
            this.fromTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toTextbox
            // 
            this.toTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toTextbox.Location = new System.Drawing.Point(167, 120);
            this.toTextbox.Multiline = true;
            this.toTextbox.Name = "toTextbox";
            this.toTextbox.Size = new System.Drawing.Size(100, 23);
            this.toTextbox.TabIndex = 6;
            this.toTextbox.Text = "Описание";
            this.toTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // amountTextbox
            // 
            this.amountTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amountTextbox.Location = new System.Drawing.Point(282, 120);
            this.amountTextbox.Multiline = true;
            this.amountTextbox.Name = "amountTextbox";
            this.amountTextbox.Size = new System.Drawing.Size(100, 23);
            this.amountTextbox.TabIndex = 7;
            this.amountTextbox.Text = "Описание";
            this.amountTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionTextbox.Location = new System.Drawing.Point(388, 120);
            this.descriptionTextbox.Multiline = true;
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.Size = new System.Drawing.Size(100, 23);
            this.descriptionTextbox.TabIndex = 8;
            this.descriptionTextbox.Text = "Описание";
            this.descriptionTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.newTab.ResumeLayout(false);
            this.newTab.PerformLayout();
            this.historyTab.ResumeLayout(false);
            this.totalTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage newTab;
        private System.Windows.Forms.TabPage historyTab;
        private System.Windows.Forms.DataGridView historyDataGridView;
        private System.Windows.Forms.TabPage totalTab;
        private System.Windows.Forms.DataGridView TotalDataGridView;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox fromTextboxLabel;
        private System.Windows.Forms.TextBox amountTextboxLabel;
        private System.Windows.Forms.TextBox toTextboxLabel;
        private System.Windows.Forms.TextBox descriptionTextbox;
        private System.Windows.Forms.TextBox amountTextbox;
        private System.Windows.Forms.TextBox toTextbox;
        private System.Windows.Forms.TextBox fromTextbox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox descriptionTextboxLabel;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

