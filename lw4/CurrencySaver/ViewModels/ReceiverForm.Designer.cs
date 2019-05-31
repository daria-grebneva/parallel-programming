namespace CurrencyExchangeReceiver
{
    partial class ReceiverForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._currencyNamesUriLabel = new System.Windows.Forms.Label();
            this._currencyInfosUriLabel = new System.Windows.Forms.Label();
            this._currencyNamesUriBox = new System.Windows.Forms.TextBox();
            this._currencyInfosUriBox = new System.Windows.Forms.TextBox();
            this._avgUpdateTimeDescriptionLabel = new System.Windows.Forms.Label();
            this._avgUpdateTimeLabel = new System.Windows.Forms.Label();
            this._asyncUsingRadioButton = new System.Windows.Forms.RadioButton();
            this._syncUsingRadioButton = new System.Windows.Forms.RadioButton();
            this._saveCurrenciesButton = new System.Windows.Forms.Button();
            this._updateTimesList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _currencyNamesUriLabel
            // 
            this._currencyNamesUriLabel.AutoSize = true;
            this._currencyNamesUriLabel.Location = new System.Drawing.Point(16, 21);
            this._currencyNamesUriLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._currencyNamesUriLabel.Name = "_currencyNamesUriLabel";
            this._currencyNamesUriLabel.Size = new System.Drawing.Size(115, 13);
            this._currencyNamesUriLabel.TabIndex = 0;
            this._currencyNamesUriLabel.Text = "Выберите input-файл:";
            // 
            // _currencyInfosUriLabel
            // 
            this._currencyInfosUriLabel.AutoSize = true;
            this._currencyInfosUriLabel.Location = new System.Drawing.Point(232, 21);
            this._currencyInfosUriLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._currencyInfosUriLabel.Name = "_currencyInfosUriLabel";
            this._currencyInfosUriLabel.Size = new System.Drawing.Size(122, 13);
            this._currencyInfosUriLabel.TabIndex = 1;
            this._currencyInfosUriLabel.Text = "Выберите output-файл:";
            // 
            // _currencyNamesUriBox
            // 
            this._currencyNamesUriBox.Location = new System.Drawing.Point(18, 41);
            this._currencyNamesUriBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._currencyNamesUriBox.Name = "_currencyNamesUriBox";
            this._currencyNamesUriBox.Size = new System.Drawing.Size(202, 20);
            this._currencyNamesUriBox.TabIndex = 2;
            // 
            // _currencyInfosUriBox
            // 
            this._currencyInfosUriBox.Location = new System.Drawing.Point(234, 41);
            this._currencyInfosUriBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._currencyInfosUriBox.Name = "_currencyInfosUriBox";
            this._currencyInfosUriBox.Size = new System.Drawing.Size(202, 20);
            this._currencyInfosUriBox.TabIndex = 3;
            // 
            // _avgUpdateTimeDescriptionLabel
            // 
            this._avgUpdateTimeDescriptionLabel.AutoSize = true;
            this._avgUpdateTimeDescriptionLabel.Location = new System.Drawing.Point(231, 170);
            this._avgUpdateTimeDescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._avgUpdateTimeDescriptionLabel.Name = "_avgUpdateTimeDescriptionLabel";
            this._avgUpdateTimeDescriptionLabel.Size = new System.Drawing.Size(156, 13);
            this._avgUpdateTimeDescriptionLabel.TabIndex = 4;
            this._avgUpdateTimeDescriptionLabel.Text = "Среднее время выполнения: ";
            // 
            // _avgUpdateTimeLabel
            // 
            this._avgUpdateTimeLabel.AutoSize = true;
            this._avgUpdateTimeLabel.Location = new System.Drawing.Point(393, 170);
            this._avgUpdateTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._avgUpdateTimeLabel.Name = "_avgUpdateTimeLabel";
            this._avgUpdateTimeLabel.Size = new System.Drawing.Size(13, 13);
            this._avgUpdateTimeLabel.TabIndex = 5;
            this._avgUpdateTimeLabel.Text = "0";
            // 
            // _asyncUsingRadioButton
            // 
            this._asyncUsingRadioButton.AutoSize = true;
            this._asyncUsingRadioButton.Location = new System.Drawing.Point(19, 108);
            this._asyncUsingRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._asyncUsingRadioButton.Name = "_asyncUsingRadioButton";
            this._asyncUsingRadioButton.Size = new System.Drawing.Size(84, 17);
            this._asyncUsingRadioButton.TabIndex = 7;
            this._asyncUsingRadioButton.TabStop = true;
            this._asyncUsingRadioButton.Text = "асинхронно";
            this._asyncUsingRadioButton.UseVisualStyleBackColor = true;
            this._asyncUsingRadioButton.CheckedChanged += new System.EventHandler(this._asyncUsingRadioButton_CheckedChanged);
            // 
            // _syncUsingRadioButton
            // 
            this._syncUsingRadioButton.AutoSize = true;
            this._syncUsingRadioButton.Location = new System.Drawing.Point(18, 134);
            this._syncUsingRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._syncUsingRadioButton.Name = "_syncUsingRadioButton";
            this._syncUsingRadioButton.Size = new System.Drawing.Size(78, 17);
            this._syncUsingRadioButton.TabIndex = 8;
            this._syncUsingRadioButton.TabStop = true;
            this._syncUsingRadioButton.Text = "синхронно";
            this._syncUsingRadioButton.UseVisualStyleBackColor = true;
            this._syncUsingRadioButton.CheckedChanged += new System.EventHandler(this._syncUsingRadioButton_CheckedChanged);
            // 
            // _saveCurrenciesButton
            // 
            this._saveCurrenciesButton.Location = new System.Drawing.Point(316, 128);
            this._saveCurrenciesButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._saveCurrenciesButton.Name = "_saveCurrenciesButton";
            this._saveCurrenciesButton.Size = new System.Drawing.Size(119, 29);
            this._saveCurrenciesButton.TabIndex = 9;
            this._saveCurrenciesButton.Text = "обработать";
            this._saveCurrenciesButton.UseVisualStyleBackColor = true;
            this._saveCurrenciesButton.Click += new System.EventHandler(this._saveCurrenciesButton_Click_1);
            // 
            // _updateTimesList
            // 
            this._updateTimesList.FormattingEnabled = true;
            this._updateTimesList.Location = new System.Drawing.Point(18, 201);
            this._updateTimesList.Margin = new System.Windows.Forms.Padding(2);
            this._updateTimesList.Name = "_updateTimesList";
            this._updateTimesList.Size = new System.Drawing.Size(418, 160);
            this._updateTimesList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Выберите вариант обработки:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Время выполнений";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(414, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "мс";
            // 
            // ReceiverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 375);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._updateTimesList);
            this.Controls.Add(this._saveCurrenciesButton);
            this.Controls.Add(this._syncUsingRadioButton);
            this.Controls.Add(this._asyncUsingRadioButton);
            this.Controls.Add(this._avgUpdateTimeLabel);
            this.Controls.Add(this._avgUpdateTimeDescriptionLabel);
            this.Controls.Add(this._currencyInfosUriBox);
            this.Controls.Add(this._currencyNamesUriBox);
            this.Controls.Add(this._currencyInfosUriLabel);
            this.Controls.Add(this._currencyNamesUriLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReceiverForm";
            this.Text = "CurrencyExchangeReceiver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _currencyNamesUriLabel;
        private System.Windows.Forms.Label _currencyInfosUriLabel;
        private System.Windows.Forms.TextBox _currencyNamesUriBox;
        private System.Windows.Forms.TextBox _currencyInfosUriBox;
        private System.Windows.Forms.Label _avgUpdateTimeDescriptionLabel;
        private System.Windows.Forms.Label _avgUpdateTimeLabel;
        private System.Windows.Forms.RadioButton _asyncUsingRadioButton;
        private System.Windows.Forms.RadioButton _syncUsingRadioButton;
        private System.Windows.Forms.Button _saveCurrenciesButton;
        private System.Windows.Forms.ListBox _updateTimesList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
    }
}

