using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class CurrencyConvert : Form
    {
        public string Basis_string;
        public string Quote_string;
        public decimal Rate_num;
        public decimal LotSize_num;

        public decimal PerPip_num;
        public decimal Per100Pip_num;

        public decimal LotAmount_num;
        public decimal LeverageUsed_num;

        public decimal MarginP;
        public decimal Equity_num;

        public decimal StopLoss;
        public decimal StopLossPips;
        public decimal StopLossLevel;

        public decimal TakeProfitLevel_num;
        public decimal RewardRatio_num;

        public string CurrencyPair_string;

        public bool Long_B;
        public bool Short_B;

        public CurrencyConvert()
        {
            InitializeComponent();
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            Basis_string = Basis.Text;
            Quote_string = Quote.Text;
            decimal.TryParse(this.Rate.Text, out Rate_num);
            decimal.TryParse(this.LotSize.Text, out LotSize_num);
            decimal.TryParse(LotAmount.Text, out LotAmount_num);
            decimal.TryParse(Margin.Text, out MarginP);
            decimal.TryParse(Equity.Text, out Equity_num);
            decimal.TryParse(Stop_Loss.Text, out StopLoss);
            decimal.TryParse(RewardRatio.Text, out RewardRatio_num);

            if (Quote.Text == "JPY") { PerPip_num = ((decimal).01 / Rate_num) * LotSize_num * LotAmount_num; }
            else if (Basis.Text == "USD") { PerPip_num = ((decimal).0001 / Rate_num) * LotSize_num * LotAmount_num; }
            else if (Quote.Text == "USD") { PerPip_num = ((decimal).0001 / Rate_num) * LotSize_num * LotAmount_num * Rate_num; }
            Per100Pip_num = PerPip_num * 100;
            Per_Pip.Text = PerPip_num.ToString();
            Per_100_Pip.Text = Per100Pip_num.ToString();
            CurrencyPair.Text = Basis_string + "/" + Quote_string;

            StopLossPips = (StopLoss * (decimal)0.01 * Equity_num) / PerPip_num;

            if (Long_B)
            {
                if (Quote.Text == "JPY" )
                {
                    StopLossLevel = Rate_num - (StopLossPips * (decimal)0.01);
                    TakeProfitLevel_num = Rate_num + (StopLossPips * (decimal)0.01 * RewardRatio_num);
                }
                else
                {
                    StopLossLevel = Rate_num - (StopLossPips * (decimal)0.0001);
                    TakeProfitLevel_num = Rate_num + (StopLossPips * (decimal)0.0001 * RewardRatio_num);
                }
            } else if(Short_B)
            {
                if (Quote.Text == "JPY" && Basis.Text == "USD")
                {
                    StopLossLevel = Rate_num + (StopLossPips * (decimal)0.01);
                    TakeProfitLevel_num = Rate_num - (StopLossPips * (decimal)0.01 * RewardRatio_num);
                }
                else
                {
                    StopLossLevel = Rate_num + (StopLossPips * (decimal)0.0001);
                    TakeProfitLevel_num = Rate_num - (StopLossPips * (decimal)0.0001 * RewardRatio_num);
                }
            }
            StopPip.Text = StopLossPips.ToString();
            StopPipLevel.Text = StopLossLevel.ToString();
            TakeProfitLevel.Text = TakeProfitLevel_num.ToString();

            LeverageUsed_num = LotAmount_num * LotSize_num / Equity_num;
            LeverageUsed.Text = LeverageUsed_num.ToString(); 



                 
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Basis_string = "";
            Quote_string = "";
            Rate_num = 0;
            LotSize_num = 0;

            PerPip_num = 0;
            Per100Pip_num = 0;

            CurrencyPair_string = "";

            Basis.Text = "";
            Quote.Text = "";
            Rate.Text = "";
            Per_Pip.Text = "";
            Per_100_Pip.Text = "";



            LotAmount_num = 0;
            LeverageUsed_num = 0;

            MarginP = 0;
            Equity_num = 0;

            StopLoss = 0;
            StopLossPips = 0;
            StopLossLevel = 0;

            TakeProfitLevel_num = 0;
            RewardRatio_num = 0;

            CurrencyPair_string = "";

         }

        private void Long_CheckedChanged(object sender, EventArgs e)
        {
            Long_B = true;
            Short_B = false;
        }

        private void Short_CheckedChanged(object sender, EventArgs e)
        {
            Long_B = false;
            Short_B = true;
        }
    }
}
