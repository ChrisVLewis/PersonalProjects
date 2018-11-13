using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace ChartingData
{
    public partial class Form1 : Form
    {
        List<string> DataSets = new List<string>();
        int i = 0;

        public Form1()
        {
            InitializeComponent();
            DataSets = File.ReadLines(@"C:\Users\Chris\Documents\MT4\chartdata.txt").ToList();
            Series MainSeries = this.chart1.Series.First();
            this.chart1.ChartAreas.First().AxisX.Interval = 1;
            this.chart1.ChartAreas.First().AxisY.Interval = 1;
            this.chart1.ChartAreas.First().AxisX.IsStartedFromZero = false;
            this.chart1.ChartAreas.First().AxisX.Maximum = 20;
            this.chart1.ChartAreas.First().AxisX.Minimum = 0;
            this.chart1.ChartAreas.First().AxisX.IsReversed = true;

            string[] data = DataSets[i].Split(',');
            for(int j = data.Count() - 4; j < data.Count(); j++)
            {
                this.richTextBox1.Text += data[j] + "\n";
            }

            for(int j = 0; j < data.Count() - 4; j++)
            {
                //flipping dataset to look correct
                DataPoint item = new DataPoint(j, data[j]);
                MainSeries.Points.Insert(0, item);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            Series MainSeries = this.chart1.Series.First();

            string[] data = DataSets[i].Split(',');

            MainSeries.Points.Clear();
            this.richTextBox1.Text = "";

            for (int j = data.Count() - 4; j < data.Count(); j++)
            {
                this.richTextBox1.Text += data[j] + "\n";
            }

            for (int j = 0; j < data.Count() - 4; j++)
            {
                //flipping dataset to look correct
                DataPoint item = new DataPoint(j, data[j]);
                MainSeries.Points.Insert(0, item);
            }

        }
    }
}
