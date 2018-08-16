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
            this.Basis.TextChanged += new System.EventHandler(this.Basis_TextChanged);
            // 
            // Quote
            // 
            this.Quote.Location = new System.Drawing.Point(165, 45);
            this.Quote.Name = "Quote";
            this.Quote.Size = new System.Drawing.Size(100, 20);
            this.Quote.TabIndex = 2;
            this.Quote.TextChanged += new System.EventHandler(this.Quote_TextChanged);
            // 
            // Rate
            // 
            this.Rate.Location = new System.Drawing.Point(48, 109);
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(100, 20);
            this.Rate.TabIndex = 3;
            this.Rate.TextChanged += new System.EventHandler(this.Rate_TextChanged);
            // 
            // Per_Pip
            // 
            this.Per_Pip.Location = new System.Drawing.Point(305, 342);
            this.Per_Pip.Name = "Per_Pip";
            this.Per_Pip.Size = new System.Drawing.Size(100, 20);
            this.Per_Pip.TabIndex = 4;
            // 
            // Per_100_Pip
            // 
            this.Per_100_Pip.Location = new System.Drawing.Point(305, 387);
            this.Per_100_Pip.Name = "Per_100_Pip";
            this.Per_100_Pip.Size = new System.Drawing.Size(100, 20);
            this.Per_100_Pip.TabIndex = 5;
            // 
            // LotSize
            // 
            this.LotSize.Location = new System.Drawing.Point(165, 109);
            this.LotSize.Name = "LotSize";
            this.LotSize.Size = new System.Drawing.Size(100, 20);
            this.LotSize.TabIndex = 6;
            this.LotSize.TextChanged += new System.EventHandler(this.LotSize_TextChanged);
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
            this.RateLabel.Location = new System.Drawing.Point(80, 93);
            this.RateLabel.Name = "RateLabel";
            this.RateLabel.Size = new System.Drawing.Size(30, 13);
            this.RateLabel.TabIndex = 9;
            this.RateLabel.Text = "Rate";
            // 
            // LotSizeLabel
            // 
            this.LotSizeLabel.AutoSize = true;
            this.LotSizeLabel.Location = new System.Drawing.Point(197, 93);
            this.LotSizeLabel.Name = "LotSizeLabel";
            this.LotSizeLabel.Size = new System.Drawing.Size(42, 13);
            this.LotSizeLabel.TabIndex = 10;
            this.LotSizeLabel.Text = "LotSize";
            // 
            // PerPipLabel
            // 
            this.PerPipLabel.AutoSize = true;
            this.PerPipLabel.Location = new System.Drawing.Point(334, 326);
            this.PerPipLabel.Name = "PerPipLabel";
            this.PerPipLabel.Size = new System.Drawing.Size(38, 13);
            this.PerPipLabel.TabIndex = 11;
            this.PerPipLabel.Text = "PerPip";
            // 
            // Per100PipLabel
            // 
            this.Per100PipLabel.AutoSize = true;
            this.Per100PipLabel.Location = new System.Drawing.Point(325, 371);
            this.Per100PipLabel.Name = "Per100PipLabel";
            this.Per100PipLabel.Size = new System.Drawing.Size(56, 13);
            this.Per100PipLabel.TabIndex = 12;
            this.Per100PipLabel.Text = "Per100Pip";
            // 
            // CurrencyPair
            // 
            this.CurrencyPair.Location = new System.Drawing.Point(305, 286);
            this.CurrencyPair.Name = "CurrencyPair";
            this.CurrencyPair.Size = new System.Drawing.Size(100, 20);
            this.CurrencyPair.TabIndex = 13;
            // 
            // CurrencyPairLabel
            // 
            this.CurrencyPairLabel.AutoSize = true;
            this.CurrencyPairLabel.Location = new System.Drawing.Point(324, 266);
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
            this.LeverageUsed.Location = new System.Drawing.Point(305, 438);
            this.LeverageUsed.Name = "LeverageUsed";
            this.LeverageUsed.Size = new System.Drawing.Size(100, 20);
            this.LeverageUsed.TabIndex = 17;
            // 
            // LeverageLabel
            // 
            this.LeverageLabel.AutoSize = true;
            this.LeverageLabel.Location = new System.Drawing.Point(314, 422);
            this.LeverageLabel.Name = "LeverageLabel";
            this.LeverageLabel.Size = new System.Drawing.Size(80, 13);
            this.LeverageLabel.TabIndex = 19;
            this.LeverageLabel.Text = "Leverage Used";
            // 
            // LotAmountLabel
            // 
            this.LotAmountLabel.AutoSize = true;
            this.LotAmountLabel.Location = new System.Drawing.Point(325, 93);
            this.LotAmountLabel.Name = "LotAmountLabel";
            this.LotAmountLabel.Size = new System.Drawing.Size(58, 13);
            this.LotAmountLabel.TabIndex = 21;
            this.LotAmountLabel.Text = "LotAmount";
            // 
            // LotAmount
            // 
            this.LotAmount.Location = new System.Drawing.Point(305, 109);
            this.LotAmount.Name = "LotAmount";
            this.LotAmount.Size = new System.Drawing.Size(100, 20);
            this.LotAmount.TabIndex = 20;
            // 
            // MarginLabel
            // 
            this.MarginLabel.AutoSize = true;
            this.MarginLabel.Location = new System.Drawing.Point(324, 25);
            this.MarginLabel.Name = "MarginLabel";
            this.MarginLabel.Size = new System.Drawing.Size(56, 13);
            this.MarginLabel.TabIndex = 23;
            this.MarginLabel.Text = "Margin (%)";
            // 
            // Margin
            // 
            this.Margin.Location = new System.Drawing.Point(305, 45);
            this.Margin.Name = "Margin";
            this.Margin.Size = new System.Drawing.Size(100, 20);
            this.Margin.TabIndex = 22;
            // 
            // EquityLabel
            // 
            this.EquityLabel.AutoSize = true;
            this.EquityLabel.Location = new System.Drawing.Point(76, 147);
            this.EquityLabel.Name = "EquityLabel";
            this.EquityLabel.Size = new System.Drawing.Size(36, 13);
            this.EquityLabel.TabIndex = 25;
            this.EquityLabel.Text = "Equity";
            // 
            // Equity
            // 
            this.Equity.Location = new System.Drawing.Point(48, 163);
            this.Equity.Name = "Equity";
            this.Equity.Size = new System.Drawing.Size(100, 20);
            this.Equity.TabIndex = 24;
            // 
            // CurrencyConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 519);
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
            this.Load += new System.EventHandler(this.CurrencyConvert_Load);
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
    }
}

