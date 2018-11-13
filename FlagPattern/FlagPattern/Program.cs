using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FlagPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            double retraceRangeLow = 0.4;
            double retraceRangeHigh = 0.6;

            File.Delete(@"C:\Users\Chris\Documents\MT4\chartdata.txt");
            bool Uptrend = false;
            bool Retrace = false;
            bool Breakout = false;
            double trendlowindex = 0;
            double trendhighindex = 0;
            double retracelowindex = 0;
            double retracehighindex= 0;
            double breakoutlowindex = 0;
            double breakouthighindex = 0;
            double retracetotal= 0;
            double trendtotal = 0;
            double retracepercent = 0;

            double[] UptrendArray;
            double[] RetraceArray;
            double[] BreakoutArray;
            double[] close_values = new double[21];
            List<string> resultList = new List<string>();
            Random RandGenerator = new Random();



            for (int j = 0; j < 10000; j++)
            {
                Uptrend = false;
                Retrace = false;
                Breakout = false;
                trendlowindex = 0;
                trendhighindex = 0;
                retracelowindex = 0;
                retracehighindex = 0;
                breakoutlowindex = 0;
                breakouthighindex = 0;

                close_values[20] = RandGenerator.Next(1, 20);
                for (int i = 19; i >= 0; i--)
                {
                    close_values[i] = close_values[i + 1] + RandGenerator.Next(-5, 5);
                }

                //Stage One: Find Trend
                UptrendArray = DetermineTrend(close_values, out Uptrend, out trendlowindex, out trendhighindex);

                //Stage Two: Find Retrace: Default 40% to 60% of trend
                if (Uptrend)
                {
                    RetraceArray = DetermineRetrace(close_values, trendhighindex, out Retrace, out retracelowindex, out retracehighindex);
                }

                if (Retrace)
                {
                    retracetotal = close_values[Int32.Parse(retracehighindex.ToString())] - close_values[Int32.Parse(retracelowindex.ToString())];
                    trendtotal = close_values[Int32.Parse(trendhighindex.ToString())] - close_values[Int32.Parse(trendlowindex.ToString())];
                }

                //Stage Three:
                if (Retrace && trendtotal * retraceRangeHigh >= retracetotal && trendtotal * retraceRangeLow <= retracetotal)
                {
                    retracepercent = retracetotal / trendtotal;
                    BreakoutArray = DetermineBreakout(close_values, retracehighindex, retracelowindex, out Breakout, out breakoutlowindex, out breakouthighindex);
                }

                if (!Uptrend || !Retrace || !Breakout)
                {
                    Console.WriteLine("No Flag");
                }
                else
                {
                    string result = "";
                    Console.Write("Flag: {");
                    foreach (double item in close_values)
                    {
                        result += item + ",";
                        Console.Write(item + ",");
                    }
                    Console.WriteLine("}");
                    result += "[RetracePercent]: " + retracepercent + ",";
                    result += "[TrendStart]: " + trendlowindex + " [TrendEnd]: " + trendhighindex + ",";
                    result += "[RetraceStart]: " + retracehighindex + " [RetraceEnd]: " + retracelowindex + ",";
                    result += "[TrendStart]: " + breakoutlowindex + " [TrendEnd]: " + breakouthighindex + ",";
                    resultList.Add(result);
                }
            }
            File.AppendAllLines(@"C:\Users\Chris\Documents\MT4\chartdata.txt", resultList);
            Console.ReadKey();
        }


        static double[] DetermineTrend(double[] data, out bool IsUptrend, out double trend_low_index, out double trend_high_index)
        {
            IsUptrend = false;
            trend_low_index = 100;
            trend_high_index = 100;
            double high = 0;
            double high_index = 100;
            double low = 100;
            double low_index = 100;

            // low number to high number, get the indexes (from 0 to 20)
            // low number index should always be less than high number index
            for(int i = 2; i < 21; i++)
            {
                if(data[i] < low)
                {
                    low = data[i];
                    low_index = i;
                    trend_low_index = i;
                }
            }
            for (int i = 2; i < 21; i++)
            {
                if (data[i] >= high && i <= low_index)
                {
                    high = data[i];
                    high_index = i;
                    trend_high_index = i;
                }
            }
            if (low_index - high_index > 3)
            {
                double[] returnarray = new double[21];
                for (int i = 0; i < 21; i++)
                {
                    if (i >= high_index && i <= low_index)
                    {
                        returnarray[i] = data[i];
                    }
                    else
                    {
                        returnarray[i] = 0;
                    }
                }
                IsUptrend = true;
                return returnarray;
            }
            else
            {
                IsUptrend = false;
                return null;
            }
        }

        static double[] DetermineRetrace(double[] data, double trend_high_index, out bool IsRetrace, out double retrace_low_index, out double retrace_high_index)
        {
            IsRetrace = false;
            retrace_low_index = 100;
            retrace_high_index = 100;
            double high = 0;
            double high_index = 100;
            double low = 100;
            double low_index = 100;

            high = data[Int32.Parse(trend_high_index.ToString())];
            high_index = trend_high_index;

            for(int i = Int32.Parse(trend_high_index.ToString()); i > 0; i--)
            {
                if (data[i] < low)
                {
                    low = data[i];
                    low_index = i;
                }
            }

            if (high_index - low_index > 2)
            {
                double[] returnarray = new double[21];
                for (int i = 0; i < 21; i++)
                {
                    if (i >= low_index && i <= high_index)
                    {
                        returnarray[i] = data[i];
                    }
                    else
                    {
                        returnarray[i] = 0;
                    }
                }
                IsRetrace = true;
                retrace_high_index = high_index;
                retrace_low_index = low_index;
                return returnarray;
            }
            else
            {
                IsRetrace = false;
                return null;
            }

        }

        static double[] DetermineBreakout(double[] data, double retrace_high_index, double retrace_low_index, out bool IsBreakout, out double breakout_low_index, out double breakout_high_index)
        {
            IsBreakout = false;
            breakout_low_index = 0;
            breakout_high_index = 0;
            double high = 0;
            double high_index = 100;
            double low = 100;
            double low_index = 100;

            high = data[Int32.Parse(retrace_high_index.ToString())];
            low = data[Int32.Parse(retrace_low_index.ToString())];
            low_index = retrace_low_index;

            for (int i = Int32.Parse(low_index.ToString()); i > 0; i--)
            {
                if (data[i] >= high)
                {
                    high = data[i];
                    high_index = i;
                    break;
                }
            }

            if (low_index - high_index > 2)
            {
                double[] returnarray = new double[21];
                for (int i = 0; i < 21; i++)
                {
                    if (i <= low_index && i >= high_index)
                    {
                        returnarray[i] = data[i];
                    }
                    else
                    {
                        returnarray[i] = 0;
                    }
                }

                if(high >= data[Int32.Parse(retrace_high_index.ToString())])
                {
                    IsBreakout = true;
                    breakout_high_index = high_index;
                    breakout_low_index = low_index;
                    return returnarray;
                }
                else
                {
                    IsBreakout = false;
                    return null;
                }
            }
            else
            {
                IsBreakout = false;
                return null;
            }
        }


    }
}
