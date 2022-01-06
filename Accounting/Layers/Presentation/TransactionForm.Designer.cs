
namespace Accounting
{
    partial class TransactionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.descriptionTextBoxLabel = new System.Windows.Forms.TextBox();
            this.amountTextBoxLabel = new System.Windows.Forms.TextBox();
            this.toTextBoxLabel = new System.Windows.Forms.TextBox();
            this.fromTextBoxLabel = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(9)))), ((int)(((byte)(44)))));
            this.descriptionTextBox.Location = new System.Drawing.Point(477, 60);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(150, 30);
            this.descriptionTextBox.TabIndex = 5;
            this.descriptionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.FromTextBox_TextChanged);
            // 
            // amountTextBox
            // 
            this.amountTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.amountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(9)))), ((int)(((byte)(44)))));
            this.amountTextBox.Location = new System.Drawing.Point(328, 60);
            this.amountTextBox.Multiline = true;
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(150, 30);
            this.amountTextBox.TabIndex = 4;
            this.amountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amountTextBox.TextChanged += new System.EventHandler(this.FromTextBox_TextChanged);
            // 
            // toTextBox
            // 
            this.toTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.toTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(9)))), ((int)(((byte)(44)))));
            this.toTextBox.Location = new System.Drawing.Point(179, 60);
            this.toTextBox.Multiline = true;
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(150, 30);
            this.toTextBox.TabIndex = 3;
            this.toTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toTextBox.TextChanged += new System.EventHandler(this.FromTextBox_TextChanged);
            // 
            // fromTextBox
            // 
            this.fromTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.fromTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fromTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fromTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(9)))), ((int)(((byte)(44)))));
            this.fromTextBox.Location = new System.Drawing.Point(30, 60);
            this.fromTextBox.Multiline = true;
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(150, 30);
            this.fromTextBox.TabIndex = 2;
            this.fromTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fromTextBox.TextChanged += new System.EventHandler(this.FromTextBox_TextChanged);
            // 
            // okButton
            // 
            this.okButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.okButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.okButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Wingdings 2", 26.25F);
            this.okButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(81)))), ((int)(((byte)(219)))));
            this.okButton.Location = new System.Drawing.Point(247, 439);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(37, 36);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "P";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            this.okButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OkButton_MouseDown);
            this.okButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OkButton_MouseUp);
            // 
            // descriptionTextBoxLabel
            // 
            this.descriptionTextBoxLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(10)))), ((int)(((byte)(150)))));
            this.descriptionTextBoxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionTextBoxLabel.Enabled = false;
            this.descriptionTextBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionTextBoxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.descriptionTextBoxLabel.Location = new System.Drawing.Point(477, 30);
            this.descriptionTextBoxLabel.Multiline = true;
            this.descriptionTextBoxLabel.Name = "descriptionTextBoxLabel";
            this.descriptionTextBoxLabel.Size = new System.Drawing.Size(150, 30);
            this.descriptionTextBoxLabel.TabIndex = 12;
            this.descriptionTextBoxLabel.Text = "Описание";
            this.descriptionTextBoxLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.descriptionTextBoxLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TransactionForm_MouseDown);
            // 
            // amountTextBoxLabel
            // 
            this.amountTextBoxLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(10)))), ((int)(((byte)(150)))));
            this.amountTextBoxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amountTextBoxLabel.Enabled = false;
            this.amountTextBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountTextBoxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.amountTextBoxLabel.Location = new System.Drawing.Point(328, 30);
            this.amountTextBoxLabel.Multiline = true;
            this.amountTextBoxLabel.Name = "amountTextBoxLabel";
            this.amountTextBoxLabel.Size = new System.Drawing.Size(150, 30);
            this.amountTextBoxLabel.TabIndex = 11;
            this.amountTextBoxLabel.Text = "Сумма";
            this.amountTextBoxLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amountTextBoxLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TransactionForm_MouseDown);
            // 
            // toTextBoxLabel
            // 
            this.toTextBoxLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(10)))), ((int)(((byte)(150)))));
            this.toTextBoxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toTextBoxLabel.Enabled = false;
            this.toTextBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toTextBoxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.toTextBoxLabel.Location = new System.Drawing.Point(179, 30);
            this.toTextBoxLabel.Multiline = true;
            this.toTextBoxLabel.Name = "toTextBoxLabel";
            this.toTextBoxLabel.Size = new System.Drawing.Size(150, 30);
            this.toTextBoxLabel.TabIndex = 10;
            this.toTextBoxLabel.Text = "Кому";
            this.toTextBoxLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toTextBoxLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TransactionForm_MouseDown);
            // 
            // fromTextBoxLabel
            // 
            this.fromTextBoxLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(10)))), ((int)(((byte)(150)))));
            this.fromTextBoxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fromTextBoxLabel.Enabled = false;
            this.fromTextBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fromTextBoxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.fromTextBoxLabel.Location = new System.Drawing.Point(30, 30);
            this.fromTextBoxLabel.Multiline = true;
            this.fromTextBoxLabel.Name = "fromTextBoxLabel";
            this.fromTextBoxLabel.Size = new System.Drawing.Size(150, 30);
            this.fromTextBoxLabel.TabIndex = 1;
            this.fromTextBoxLabel.Text = "От кого";
            this.fromTextBoxLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fromTextBoxLabel.TextChanged += new System.EventHandler(this.fromTextBoxLabel_TextChanged);
            this.fromTextBoxLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TransactionForm_MouseDown);
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Wingdings 2", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(81)))), ((int)(((byte)(219)))));
            this.exitButton.Location = new System.Drawing.Point(387, 439);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(37, 36);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "O";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.exitButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExitButton_MouseDown);
            this.exitButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ExitButton_MouseUp);
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(660, 531);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.descriptionTextBoxLabel);
            this.Controls.Add(this.amountTextBoxLabel);
            this.Controls.Add(this.toTextBoxLabel);
            this.Controls.Add(this.fromTextBoxLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TransactionForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox descriptionTextBoxLabel;
        private System.Windows.Forms.TextBox amountTextBoxLabel;
        private System.Windows.Forms.TextBox toTextBoxLabel;
        private System.Windows.Forms.TextBox fromTextBoxLabel;
        private System.Windows.Forms.Button exitButton;
    }
}