namespace CurrencyConverter
{
    partial class CurrencyConvert
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
            this.Convert = new System.Windows.Forms.Button();
            this.Basis = new System.Windows.Forms.TextBox();
            this.Quote = new System.Windows.Forms.TextBox();
            this.Rate = new System.Windows.Forms.TextBox();
            this.Per_Pip = new System.Windows.Forms.TextBox();
            this.Per_100_Pip = new System.Windows.Forms.TextBox();
            this.LotSize = new System.Windows.Forms.TextBox();
            this.BasisLabel = new System.Windows.Forms.Label();
            this.QuoteLabel = new System.Windows.Forms.Label();
            this.RateLabel = new System.Windows.Forms.Label();
            this.LotSizeLabel = new System.Windows.Forms.Label();
            this.PerPipLabel = new System.Windows.Forms.Label();
            this.Per100PipLabel = new System.Windows.Forms.Label();
            this.CurrencyPair = new System.Windows.Forms.TextBox();
            this.CurrencyPairLabel = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.LeverageUsed = new System.Windows.Forms.TextBox();
            this.LeverageLabel = new System.Windows.Forms.Label();
            this.LotAmountLabel = new System.Windows.Forms.Label();
            this.LotAmount = new System.Windows.Forms.TextBox();
            this.MarginLabel = new System.Windows.Forms.Label();
            this.Margin = new System.Windows.Forms.TextBox();
            this.EquityLabel = new System.Windows.Forms.Label();
            this.Equity = new System.Windows.Forms.TextBox();
            this.Stop_Losslabel = new System.Windows.Forms.Label();
            this.Stop_Loss = new System.Windows.Forms.TextBox();
            this.StopPipLabel = new System.Windows.Forms.Label();
            this.StopPip = new System.Windows.Forms.TextBox();
            this.StopPipLevelLabel = new System.Windows.Forms.Label();
            this.StopPipLevel = new System.Windows.Forms.TextBox();
            this.RewardRatioLabel = new System.Windows.Forms.Label();
            this.RewardRatio = new System.Windows.Forms.TextBox();
            this.TakeProfitLevelLabel = new System.Windows.Forms.Label();
            this.TakeProfitLevel = new System.Windows.Forms.TextBox();
            this.Short = new System.Windows.Forms.RadioButton();
            this.Long = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(48, 236);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(75, 23);
            this.Convert.TabIndex = 0;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // Basis
            // 
            this.Basis.Location = new System.Drawing.Point(48, 45);
            this.Basis.Name = "Basis";
            this.Basis.Size = new System.Drawing.Size(100, 20);
            this.Basis.TabIndex = 1;
            // 
            // Quote
            // 
            this.Quote.Location = new System.Drawing.Point(165, 45);
            this.Quote.Name = "Quote";
            this.Quote.Size = new System.Drawing.Size(100, 20);
            this.Quote.TabIndex = 2;
            // 
            // Rate
            // 
            this.Rate.Location = new System.Drawing.Point(48, 92);
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(100, 20);
            this.Rate.TabIndex = 3;
            // 
            // Per_Pip
            // 
            this.Per_Pip.Location = new System.Drawing.Point(305, 348);
            this.Per_Pip.Name = "Per_Pip";
            this.Per_Pip.Size = new System.Drawing.Size(100, 20);
            this.Per_Pip.TabIndex = 4;
            // 
            // Per_100_Pip
            // 
            this.Per_100_Pip.Location = new System.Drawing.Point(305, 393);
            this.Per_100_Pip.Name = "Per_100_Pip";
            this.Per_100_Pip.Size = new System.Drawing.Size(100, 20);
            this.Per_100_Pip.TabIndex = 5;
            // 
            // LotSize
            // 
            this.LotSize.Location = new System.Drawing.Point(165, 92);
            this.LotSize.Name = "LotSize";
            this.LotSize.Size = new System.Drawing.Size(100, 20);
            this.LotSize.TabIndex = 6;
            // 
            // BasisLabel
            // 
            this.BasisLabel.AutoSize = true;
            this.BasisLabel.Location = new System.Drawing.Point(80, 29);
            this.BasisLabel.Name = "BasisLabel";
            this.BasisLabel.Size = new System.Drawing.Size(32, 13);
            this.BasisLabel.TabIndex = 7;
            this.BasisLabel.Text = "Basis";
            // 
            // QuoteLabel
            // 
            this.QuoteLabel.AutoSize = true;
            this.QuoteLabel.Location = new System.Drawing.Point(193, 29);
            this.QuoteLabel.Name = "QuoteLabel";
            this.QuoteLabel.Size = new System.Drawing.Size(36, 13);
            this.QuoteLabel.TabIndex = 8;
            this.QuoteLabel.Text = "Quote";
            // 
            // RateLabel
            // 
            this.RateLabel.AutoSize = true;
            this.RateLabel.Location = new System.Drawing.Point(80, 76);
            this.RateLabel.Name = "RateLabel";
            this.RateLabel.Size = new System.Drawing.Size(30, 13);
            this.RateLabel.TabIndex = 9;
            this.RateLabel.Text = "Rate";
            // 
            // LotSizeLabel
            // 
            this.LotSizeLabel.AutoSize = true;
            this.LotSizeLabel.Location = new System.Drawing.Point(197, 76);
            this.LotSizeLabel.Name = "LotSizeLabel";
            this.LotSizeLabel.Size = new System.Drawing.Size(42, 13);
            this.LotSizeLabel.TabIndex = 10;
            this.LotSizeLabel.Text = "LotSize";
            // 
            // PerPipLabel
            // 
            this.PerPipLabel.AutoSize = true;
            this.PerPipLabel.Location = new System.Drawing.Point(334, 332);
            this.PerPipLabel.Name = "PerPipLabel";
            this.PerPipLabel.Size = new System.Drawing.Size(38, 13);
            this.PerPipLabel.TabIndex = 11;
            this.PerPipLabel.Text = "PerPip";
            // 
            // Per100PipLabel
            // 
            this.Per100PipLabel.AutoSize = true;
            this.Per100PipLabel.Location = new System.Drawing.Point(325, 377);
            this.Per100PipLabel.Name = "Per100PipLabel";
            this.Per100PipLabel.Size = new System.Drawing.Size(56, 13);
            this.Per100PipLabel.TabIndex = 12;
            this.Per100PipLabel.Text = "Per100Pip";
            // 
            // CurrencyPair
            // 
            this.CurrencyPair.Location = new System.Drawing.Point(305, 303);
            this.CurrencyPair.Name = "CurrencyPair";
            this.CurrencyPair.Size = new System.Drawing.Size(100, 20);
            this.CurrencyPair.TabIndex = 13;
            // 
            // CurrencyPairLabel
            // 
            this.CurrencyPairLabel.AutoSize = true;
            this.CurrencyPairLabel.Location = new System.Drawing.Point(324, 283);
            this.CurrencyPairLabel.Name = "CurrencyPairLabel";
            this.CurrencyPairLabel.Size = new System.Drawing.Size(67, 13);
            this.CurrencyPairLabel.TabIndex = 14;
            this.CurrencyPairLabel.Text = "CurrencyPair";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(48, 284);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 15;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // LeverageUsed
            // 
            this.LeverageUsed.Location = new System.Drawing.Point(305, 444);
            this.LeverageUsed.Name = "LeverageUsed";
            this.LeverageUsed.Size = new System.Drawing.Size(100, 20);
            this.LeverageUsed.TabIndex = 17;
            // 
            // LeverageLabel
            // 
            this.LeverageLabel.AutoSize = true;
            this.LeverageLabel.Location = new System.Drawing.Point(314, 428);
            this.LeverageLabel.Name = "LeverageLabel";
            this.LeverageLabel.Size = new System.Drawing.Size(80, 13);
            this.LeverageLabel.TabIndex = 19;
            this.LeverageLabel.Text = "Leverage Used";
            // 
            // LotAmountLabel
            // 
            this.LotAmountLabel.AutoSize = true;
            this.LotAmountLabel.Location = new System.Drawing.Point(301, 76);
            this.LotAmountLabel.Name = "LotAmountLabel";
            this.LotAmountLabel.Size = new System.Drawing.Size(58, 13);
            this.LotAmountLabel.TabIndex = 21;
            this.LotAmountLabel.Text = "LotAmount";
            // 
            // LotAmount
            // 
            this.LotAmount.Location = new System.Drawing.Point(281, 92);
            this.LotAmount.Name = "LotAmount";
            this.LotAmount.Size = new System.Drawing.Size(100, 20);
            this.LotAmount.TabIndex = 20;
            // 
            // MarginLabel
            // 
            this.MarginLabel.AutoSize = true;
            this.MarginLabel.Location = new System.Drawing.Point(300, 25);
            this.MarginLabel.Name = "MarginLabel";
            this.MarginLabel.Size = new System.Drawing.Size(56, 13);
            this.MarginLabel.TabIndex = 23;
            this.MarginLabel.Text = "Margin (%)";
            // 
            // Margin
            // 
            this.Margin.Location = new System.Drawing.Point(281, 45);
            this.Margin.Name = "Margin";
            this.Margin.Size = new System.Drawing.Size(100, 20);
            this.Margin.TabIndex = 22;
            // 
            // EquityLabel
            // 
            this.EquityLabel.AutoSize = true;
            this.EquityLabel.Location = new System.Drawing.Point(76, 124);
            this.EquityLabel.Name = "EquityLabel";
            this.EquityLabel.Size = new System.Drawing.Size(36, 13);
            this.EquityLabel.TabIndex = 25;
            this.EquityLabel.Text = "Equity";
            // 
            // Equity
            // 
            this.Equity.Location = new System.Drawing.Point(48, 140);
            this.Equity.Name = "Equity";
            this.Equity.Size = new System.Drawing.Size(100, 20);
            this.Equity.TabIndex = 24;
            // 
            // Stop_Losslabel
            // 
            this.Stop_Losslabel.AutoSize = true;
            this.Stop_Losslabel.Location = new System.Drawing.Point(180, 124);
            this.Stop_Losslabel.Name = "Stop_Losslabel";
            this.Stop_Losslabel.Size = new System.Drawing.Size(71, 13);
            this.Stop_Losslabel.TabIndex = 27;
            this.Stop_Losslabel.Text = "Stop-Loss (%)";
            // 
            // Stop_Loss
            // 
            this.Stop_Loss.Location = new System.Drawing.Point(165, 140);
            this.Stop_Loss.Name = "Stop_Loss";
            this.Stop_Loss.Size = new System.Drawing.Size(100, 20);
            this.Stop_Loss.TabIndex = 26;
            // 
            // StopPipLabel
            // 
            this.StopPipLabel.AutoSize = true;
            this.StopPipLabel.Location = new System.Drawing.Point(197, 283);
            this.StopPipLabel.Name = "StopPipLabel";
            this.StopPipLabel.Size = new System.Drawing.Size(83, 13);
            this.StopPipLabel.TabIndex = 29;
            this.StopPipLabel.Text = "Stop-Loss (Pips)";
            // 
            // StopPip
            // 
            this.StopPip.Location = new System.Drawing.Point(183, 303);
            this.StopPip.Name = "StopPip";
            this.StopPip.Size = new System.Drawing.Size(100, 20);
            this.StopPip.TabIndex = 28;
            // 
            // StopPipLevelLabel
            // 
            this.StopPipLevelLabel.AutoSize = true;
            this.StopPipLevelLabel.Location = new System.Drawing.Point(197, 328);
            this.StopPipLevelLabel.Name = "StopPipLevelLabel";
            this.StopPipLevelLabel.Size = new System.Drawing.Size(83, 13);
            this.StopPipLevelLabel.TabIndex = 31;
            this.StopPipLevelLabel.Text = "Stop-Loss Level";
            // 
            // StopPipLevel
            // 
            this.StopPipLevel.Location = new System.Drawing.Point(183, 348);
            this.StopPipLevel.Name = "StopPipLevel";
            this.StopPipLevel.Size = new System.Drawing.Size(100, 20);
            this.StopPipLevel.TabIndex = 30;
            // 
            // RewardRatioLabel
            // 
            this.RewardRatioLabel.AutoSize = true;
            this.RewardRatioLabel.Location = new System.Drawing.Point(295, 120);
            this.RewardRatioLabel.Name = "RewardRatioLabel";
            this.RewardRatioLabel.Size = new System.Drawing.Size(72, 13);
            this.RewardRatioLabel.TabIndex = 33;
            this.RewardRatioLabel.Text = "Reward Ratio";
            // 
            // RewardRatio
            // 
            this.RewardRatio.Location = new System.Drawing.Point(281, 140);
            this.RewardRatio.Name = "RewardRatio";
            this.RewardRatio.Size = new System.Drawing.Size(100, 20);
            this.RewardRatio.TabIndex = 32;
            // 
            // TakeProfitLevelLabel
            // 
            this.TakeProfitLevelLabel.AutoSize = true;
            this.TakeProfitLevelLabel.Location = new System.Drawing.Point(192, 377);
            this.TakeProfitLevelLabel.Name = "TakeProfitLevelLabel";
            this.TakeProfitLevelLabel.Size = new System.Drawing.Size(88, 13);
            this.TakeProfitLevelLabel.TabIndex = 35;
            this.TakeProfitLevelLabel.Text = "Take Profit Level";
            // 
            // TakeProfitLevel
            // 
            this.TakeProfitLevel.Location = new System.Drawing.Point(183, 393);
            this.TakeProfitLevel.Name = "TakeProfitLevel";
            this.TakeProfitLevel.Size = new System.Drawing.Size(100, 20);
            this.TakeProfitLevel.TabIndex = 34;
            // 
            // Short
            // 
            this.Short.AutoSize = true;
            this.Short.Location = new System.Drawing.Point(197, 214);
            this.Short.Name = "Short";
            this.Short.Size = new System.Drawing.Size(85, 17);
            this.Short.TabIndex = 36;
            this.Short.TabStop = true;
            this.Short.Text = "Short";
            this.Short.UseVisualStyleBackColor = true;
            this.Short.CheckedChanged += new System.EventHandler(this.Short_CheckedChanged);
            // 
            // Long
            // 
            this.Long.AutoSize = true;
            this.Long.Location = new System.Drawing.Point(317, 214);
            this.Long.Name = "Long";
            this.Long.Size = new System.Drawing.Size(49, 17);
            this.Long.TabIndex = 37;
            this.Long.TabStop = true;
            this.Long.Text = "Long";
            this.Long.UseVisualStyleBackColor = true;
            this.Long.CheckedChanged += new System.EventHandler(this.Long_CheckedChanged);
            // 
            // CurrencyConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 519);
            this.Controls.Add(this.Long);
            this.Controls.Add(this.Short);
            this.Controls.Add(this.TakeProfitLevelLabel);
            this.Controls.Add(this.TakeProfitLevel);
            this.Controls.Add(this.RewardRatioLabel);
            this.Controls.Add(this.RewardRatio);
            this.Controls.Add(this.StopPipLevelLabel);
            this.Controls.Add(this.StopPipLevel);
            this.Controls.Add(this.StopPipLabel);
            this.Controls.Add(this.StopPip);
            this.Controls.Add(this.Stop_Losslabel);
            this.Controls.Add(this.Stop_Loss);
            this.Controls.Add(this.EquityLabel);
            this.Controls.Add(this.Equity);
            this.Controls.Add(this.MarginLabel);
            this.Controls.Add(this.Margin);
            this.Controls.Add(this.LotAmountLabel);
            this.Controls.Add(this.LotAmount);
            this.Controls.Add(this.LeverageLabel);
            this.Controls.Add(this.LeverageUsed);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.CurrencyPairLabel);
            this.Controls.Add(this.CurrencyPair);
            this.Controls.Add(this.Per100PipLabel);
            this.Controls.Add(this.PerPipLabel);
            this.Controls.Add(this.LotSizeLabel);
            this.Controls.Add(this.RateLabel);
            this.Controls.Add(this.QuoteLabel);
            this.Controls.Add(this.BasisLabel);
            this.Controls.Add(this.Per_100_Pip);
            this.Controls.Add(this.Per_Pip);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.Quote);
            this.Controls.Add(this.Basis);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.LotSize);
            this.Name = "CurrencyConvert";
            this.Text = "CurrencyConvert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.TextBox Basis;
        private System.Windows.Forms.TextBox Quote;
        private System.Windows.Forms.TextBox Rate;
        private System.Windows.Forms.TextBox Per_Pip;
        private System.Windows.Forms.TextBox Per_100_Pip;
        private System.Windows.Forms.TextBox LotSize;
        private System.Windows.Forms.Label BasisLabel;
        private System.Windows.Forms.Label QuoteLabel;
        private System.Windows.Forms.Label RateLabel;
        private System.Windows.Forms.Label LotSizeLabel;
        private System.Windows.Forms.Label PerPipLabel;
        private System.Windows.Forms.Label Per100PipLabel;
        private System.Windows.Forms.TextBox CurrencyPair;
        private System.Windows.Forms.Label CurrencyPairLabel;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TextBox LeverageUsed;
        private System.Windows.Forms.Label LeverageLabel;
        private System.Windows.Forms.Label LotAmountLabel;
        private System.Windows.Forms.TextBox LotAmount;
        private System.Windows.Forms.Label MarginLabel;
        private System.Windows.Forms.TextBox Margin;
        private System.Windows.Forms.Label EquityLabel;
        private System.Windows.Forms.TextBox Equity;
        private System.Windows.Forms.Label Stop_Losslabel;
        private System.Windows.Forms.TextBox Stop_Loss;
        private System.Windows.Forms.Label StopPipLabel;
        private System.Windows.Forms.TextBox StopPip;
        private System.Windows.Forms.Label StopPipLevelLabel;
        private System.Windows.Forms.TextBox StopPipLevel;
        private System.Windows.Forms.Label RewardRatioLabel;
        private System.Windows.Forms.TextBox RewardRatio;
        private System.Windows.Forms.Label TakeProfitLevelLabel;
        private System.Windows.Forms.TextBox TakeProfitLevel;
        private System.Windows.Forms.RadioButton Short;
        private System.Windows.Forms.RadioButton Long;
    }
}

