namespace midterm
{
    partial class CurrencyConverter
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
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.LineShape = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label1 = new System.Windows.Forms.Label();
            this.MoneyIhaveGroupBox = new System.Windows.Forms.GroupBox();
            this.AmountIhaveTextBox = new System.Windows.Forms.TextBox();
            this.EUROIhaveRadioButton = new System.Windows.Forms.RadioButton();
            this.IhaveAmount = new System.Windows.Forms.Label();
            this.USDIhaveRadioButton = new System.Windows.Forms.RadioButton();
            this.CADIhaveRadioButton = new System.Windows.Forms.RadioButton();
            this.MoneyIwantGroupBox2 = new System.Windows.Forms.GroupBox();
            this.ExchangeFeeCheckBox = new System.Windows.Forms.CheckBox();
            this.AmountIwantTextBox = new System.Windows.Forms.TextBox();
            this.IwantAmount = new System.Windows.Forms.Label();
            this.USDIwantRadioButton = new System.Windows.Forms.RadioButton();
            this.CADIwantRadioButton = new System.Windows.Forms.RadioButton();
            this.EUROIwantRadioButton = new System.Windows.Forms.RadioButton();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MoneyIhaveGroupBox.SuspendLayout();
            this.MoneyIwantGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.LineShape});
            this.shapeContainer1.Size = new System.Drawing.Size(480, 419);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // LineShape
            // 
            this.LineShape.Name = "LineShape";
            this.LineShape.X1 = -1;
            this.LineShape.X2 = 484;
            this.LineShape.Y1 = 394;
            this.LineShape.Y2 = 394;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Currency Converter";
            // 
            // MoneyIhaveGroupBox
            // 
            this.MoneyIhaveGroupBox.Controls.Add(this.AmountIhaveTextBox);
            this.MoneyIhaveGroupBox.Controls.Add(this.EUROIhaveRadioButton);
            this.MoneyIhaveGroupBox.Controls.Add(this.IhaveAmount);
            this.MoneyIhaveGroupBox.Controls.Add(this.USDIhaveRadioButton);
            this.MoneyIhaveGroupBox.Controls.Add(this.CADIhaveRadioButton);
            this.MoneyIhaveGroupBox.Location = new System.Drawing.Point(27, 70);
            this.MoneyIhaveGroupBox.Name = "MoneyIhaveGroupBox";
            this.MoneyIhaveGroupBox.Size = new System.Drawing.Size(166, 234);
            this.MoneyIhaveGroupBox.TabIndex = 0;
            this.MoneyIhaveGroupBox.TabStop = false;
            this.MoneyIhaveGroupBox.Text = "Currency I Have";
            // 
            // AmountIhaveTextBox
            // 
            this.AmountIhaveTextBox.Location = new System.Drawing.Point(11, 174);
            this.AmountIhaveTextBox.Name = "AmountIhaveTextBox";
            this.AmountIhaveTextBox.Size = new System.Drawing.Size(100, 20);
            this.AmountIhaveTextBox.TabIndex = 4;
            // 
            // EUROIhaveRadioButton
            // 
            this.EUROIhaveRadioButton.AutoSize = true;
            this.EUROIhaveRadioButton.Location = new System.Drawing.Point(11, 110);
            this.EUROIhaveRadioButton.Name = "EUROIhaveRadioButton";
            this.EUROIhaveRadioButton.Size = new System.Drawing.Size(47, 17);
            this.EUROIhaveRadioButton.TabIndex = 2;
            this.EUROIhaveRadioButton.TabStop = true;
            this.EUROIhaveRadioButton.Text = "Euro";
            this.EUROIhaveRadioButton.UseVisualStyleBackColor = true;
            // 
            // IhaveAmount
            // 
            this.IhaveAmount.AutoSize = true;
            this.IhaveAmount.Location = new System.Drawing.Point(8, 158);
            this.IhaveAmount.Name = "IhaveAmount";
            this.IhaveAmount.Size = new System.Drawing.Size(46, 13);
            this.IhaveAmount.TabIndex = 3;
            this.IhaveAmount.Text = "Amount:";
            // 
            // USDIhaveRadioButton
            // 
            this.USDIhaveRadioButton.AutoSize = true;
            this.USDIhaveRadioButton.Location = new System.Drawing.Point(11, 70);
            this.USDIhaveRadioButton.Name = "USDIhaveRadioButton";
            this.USDIhaveRadioButton.Size = new System.Drawing.Size(70, 17);
            this.USDIhaveRadioButton.TabIndex = 1;
            this.USDIhaveRadioButton.TabStop = true;
            this.USDIhaveRadioButton.Text = "US Dollar";
            this.USDIhaveRadioButton.UseVisualStyleBackColor = true;
            // 
            // CADIhaveRadioButton
            // 
            this.CADIhaveRadioButton.AutoSize = true;
            this.CADIhaveRadioButton.Location = new System.Drawing.Point(11, 32);
            this.CADIhaveRadioButton.Name = "CADIhaveRadioButton";
            this.CADIhaveRadioButton.Size = new System.Drawing.Size(100, 17);
            this.CADIhaveRadioButton.TabIndex = 0;
            this.CADIhaveRadioButton.TabStop = true;
            this.CADIhaveRadioButton.Text = "Canadian Dollar";
            this.CADIhaveRadioButton.UseVisualStyleBackColor = true;
            // 
            // MoneyIwantGroupBox2
            // 
            this.MoneyIwantGroupBox2.Controls.Add(this.ExchangeFeeCheckBox);
            this.MoneyIwantGroupBox2.Controls.Add(this.AmountIwantTextBox);
            this.MoneyIwantGroupBox2.Controls.Add(this.IwantAmount);
            this.MoneyIwantGroupBox2.Controls.Add(this.USDIwantRadioButton);
            this.MoneyIwantGroupBox2.Controls.Add(this.CADIwantRadioButton);
            this.MoneyIwantGroupBox2.Controls.Add(this.EUROIwantRadioButton);
            this.MoneyIwantGroupBox2.Location = new System.Drawing.Point(284, 70);
            this.MoneyIwantGroupBox2.Name = "MoneyIwantGroupBox2";
            this.MoneyIwantGroupBox2.Size = new System.Drawing.Size(166, 234);
            this.MoneyIwantGroupBox2.TabIndex = 1;
            this.MoneyIwantGroupBox2.TabStop = false;
            this.MoneyIwantGroupBox2.Text = "Currency I Want";
            // 
            // ExchangeFeeCheckBox
            // 
            this.ExchangeFeeCheckBox.AutoSize = true;
            this.ExchangeFeeCheckBox.Location = new System.Drawing.Point(12, 191);
            this.ExchangeFeeCheckBox.Name = "ExchangeFeeCheckBox";
            this.ExchangeFeeCheckBox.Size = new System.Drawing.Size(115, 17);
            this.ExchangeFeeCheckBox.TabIndex = 5;
            this.ExchangeFeeCheckBox.Text = "-2% Exchange Fee";
            this.ExchangeFeeCheckBox.UseVisualStyleBackColor = true;
            // 
            // AmountIwantTextBox
            // 
            this.AmountIwantTextBox.Location = new System.Drawing.Point(12, 165);
            this.AmountIwantTextBox.Name = "AmountIwantTextBox";
            this.AmountIwantTextBox.ReadOnly = true;
            this.AmountIwantTextBox.Size = new System.Drawing.Size(100, 20);
            this.AmountIwantTextBox.TabIndex = 4;
            // 
            // IwantAmount
            // 
            this.IwantAmount.AutoSize = true;
            this.IwantAmount.Location = new System.Drawing.Point(9, 149);
            this.IwantAmount.Name = "IwantAmount";
            this.IwantAmount.Size = new System.Drawing.Size(46, 13);
            this.IwantAmount.TabIndex = 3;
            this.IwantAmount.Text = "Amount:";
            // 
            // USDIwantRadioButton
            // 
            this.USDIwantRadioButton.AutoSize = true;
            this.USDIwantRadioButton.Location = new System.Drawing.Point(12, 32);
            this.USDIwantRadioButton.Name = "USDIwantRadioButton";
            this.USDIwantRadioButton.Size = new System.Drawing.Size(70, 17);
            this.USDIwantRadioButton.TabIndex = 0;
            this.USDIwantRadioButton.TabStop = true;
            this.USDIwantRadioButton.Text = "US Dollar";
            this.USDIwantRadioButton.UseVisualStyleBackColor = true;
            // 
            // CADIwantRadioButton
            // 
            this.CADIwantRadioButton.AutoSize = true;
            this.CADIwantRadioButton.Location = new System.Drawing.Point(12, 70);
            this.CADIwantRadioButton.Name = "CADIwantRadioButton";
            this.CADIwantRadioButton.Size = new System.Drawing.Size(100, 17);
            this.CADIwantRadioButton.TabIndex = 1;
            this.CADIwantRadioButton.TabStop = true;
            this.CADIwantRadioButton.Text = "Canadian Dollar";
            this.CADIwantRadioButton.UseVisualStyleBackColor = true;
            // 
            // EUROIwantRadioButton
            // 
            this.EUROIwantRadioButton.AutoSize = true;
            this.EUROIwantRadioButton.Location = new System.Drawing.Point(12, 110);
            this.EUROIwantRadioButton.Name = "EUROIwantRadioButton";
            this.EUROIwantRadioButton.Size = new System.Drawing.Size(47, 17);
            this.EUROIwantRadioButton.TabIndex = 2;
            this.EUROIwantRadioButton.TabStop = true;
            this.EUROIwantRadioButton.Text = "Euro";
            this.EUROIwantRadioButton.UseVisualStyleBackColor = true;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(27, 338);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(75, 23);
            this.ConvertButton.TabIndex = 2;
            this.ConvertButton.Text = "C&onvert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ResetButton.Location = new System.Drawing.Point(201, 338);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 3;
            this.ResetButton.Text = "&Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Location = new System.Drawing.Point(375, 338);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CurrencyConverter
            // 
            this.AcceptButton = this.ConvertButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ResetButton;
            this.ClientSize = new System.Drawing.Size(480, 419);
            this.Controls.Add(this.MoneyIwantGroupBox2);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.MoneyIhaveGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CurrencyConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Converter";
            this.Load += new System.EventHandler(this.CurrencyConverter_Load);
            this.MoneyIhaveGroupBox.ResumeLayout(false);
            this.MoneyIhaveGroupBox.PerformLayout();
            this.MoneyIwantGroupBox2.ResumeLayout(false);
            this.MoneyIwantGroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape LineShape;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox MoneyIhaveGroupBox;
        private System.Windows.Forms.RadioButton EUROIhaveRadioButton;
        private System.Windows.Forms.RadioButton USDIhaveRadioButton;
        private System.Windows.Forms.RadioButton CADIhaveRadioButton;
        private System.Windows.Forms.GroupBox MoneyIwantGroupBox2;
        private System.Windows.Forms.RadioButton USDIwantRadioButton;
        private System.Windows.Forms.RadioButton CADIwantRadioButton;
        private System.Windows.Forms.RadioButton EUROIwantRadioButton;
        private System.Windows.Forms.TextBox AmountIhaveTextBox;
        private System.Windows.Forms.Label IhaveAmount;
        private System.Windows.Forms.CheckBox ExchangeFeeCheckBox;
        private System.Windows.Forms.TextBox AmountIwantTextBox;
        private System.Windows.Forms.Label IwantAmount;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

