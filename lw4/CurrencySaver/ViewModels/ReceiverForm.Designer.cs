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
            this.inputFileLabel = new System.Windows.Forms.Label();
            this.outputFileLabel = new System.Windows.Forms.Label();
            this.inputFileBox = new System.Windows.Forms.TextBox();
            this.outputFileBox = new System.Windows.Forms.TextBox();
            this.averageTimeLabel = new System.Windows.Forms.Label();
            this.asyncRadioButton = new System.Windows.Forms.RadioButton();
            this.syncRadioButton = new System.Windows.Forms.RadioButton();
            this.processButton = new System.Windows.Forms.Button();
            this.timesList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputFileLabel
            // 
            this.inputFileLabel.AutoSize = true;
            this.inputFileLabel.Location = new System.Drawing.Point(16, 21);
            this.inputFileLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inputFileLabel.Name = "inputFileLabel";
            this.inputFileLabel.Size = new System.Drawing.Size(115, 13);
            this.inputFileLabel.TabIndex = 0;
            this.inputFileLabel.Text = "Выберите input-файл:";
            // 
            // outputFileLabel
            // 
            this.outputFileLabel.AutoSize = true;
            this.outputFileLabel.Location = new System.Drawing.Point(232, 21);
            this.outputFileLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outputFileLabel.Name = "outputFileLabel";
            this.outputFileLabel.Size = new System.Drawing.Size(122, 13);
            this.outputFileLabel.TabIndex = 1;
            this.outputFileLabel.Text = "Выберите output-файл:";
            // 
            // inputFileBox
            // 
            this.inputFileBox.Location = new System.Drawing.Point(18, 41);
            this.inputFileBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputFileBox.Name = "inputFileBox";
            this.inputFileBox.Size = new System.Drawing.Size(202, 20);
            this.inputFileBox.TabIndex = 2;
            // 
            // outputFileBox
            // 
            this.outputFileBox.Location = new System.Drawing.Point(234, 41);
            this.outputFileBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.outputFileBox.Name = "outputFileBox";
            this.outputFileBox.Size = new System.Drawing.Size(202, 20);
            this.outputFileBox.TabIndex = 3;
            // 
            // averageTimeLabel
            // 
            this.averageTimeLabel.AutoSize = true;
            this.averageTimeLabel.Location = new System.Drawing.Point(231, 170);
            this.averageTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.averageTimeLabel.Name = "averageTimeLabel";
            this.averageTimeLabel.Size = new System.Drawing.Size(156, 13);
            this.averageTimeLabel.TabIndex = 4;
            this.averageTimeLabel.Text = "Среднее время выполнения: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "0";
            // 
            // asyncRadioButton
            // 
            this.asyncRadioButton.AutoSize = true;
            this.asyncRadioButton.Location = new System.Drawing.Point(19, 108);
            this.asyncRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.asyncRadioButton.Name = "asyncRadioButton";
            this.asyncRadioButton.Size = new System.Drawing.Size(84, 17);
            this.asyncRadioButton.TabIndex = 7;
            this.asyncRadioButton.TabStop = true;
            this.asyncRadioButton.Text = "асинхронно";
            this.asyncRadioButton.UseVisualStyleBackColor = true;
            this.asyncRadioButton.CheckedChanged += new System.EventHandler(this._asyncUsingRadioButton_CheckedChanged);
            // 
            // syncRadioButton
            // 
            this.syncRadioButton.AutoSize = true;
            this.syncRadioButton.Location = new System.Drawing.Point(18, 134);
            this.syncRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.syncRadioButton.Name = "syncRadioButton";
            this.syncRadioButton.Size = new System.Drawing.Size(78, 17);
            this.syncRadioButton.TabIndex = 8;
            this.syncRadioButton.TabStop = true;
            this.syncRadioButton.Text = "синхронно";
            this.syncRadioButton.UseVisualStyleBackColor = true;
            this.syncRadioButton.CheckedChanged += new System.EventHandler(this._syncUsingRadioButton_CheckedChanged);
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(316, 128);
            this.processButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(119, 29);
            this.processButton.TabIndex = 9;
            this.processButton.Text = "обработать";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this._saveCurrenciesButton_Click_1);
            // 
            // timesList
            // 
            this.timesList.FormattingEnabled = true;
            this.timesList.Location = new System.Drawing.Point(18, 201);
            this.timesList.Margin = new System.Windows.Forms.Padding(2);
            this.timesList.Name = "timesList";
            this.timesList.Size = new System.Drawing.Size(418, 160);
            this.timesList.TabIndex = 0;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "мс";
            // 
            // ReceiverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 375);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timesList);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.syncRadioButton);
            this.Controls.Add(this.asyncRadioButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.averageTimeLabel);
            this.Controls.Add(this.outputFileBox);
            this.Controls.Add(this.inputFileBox);
            this.Controls.Add(this.outputFileLabel);
            this.Controls.Add(this.inputFileLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReceiverForm";
            this.Text = "CurrencyExchangeReceiver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputFileLabel;
        private System.Windows.Forms.Label outputFileLabel;
        private System.Windows.Forms.TextBox inputFileBox;
        private System.Windows.Forms.TextBox outputFileBox;
        private System.Windows.Forms.Label averageTimeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton asyncRadioButton;
        private System.Windows.Forms.RadioButton syncRadioButton;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.ListBox timesList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

