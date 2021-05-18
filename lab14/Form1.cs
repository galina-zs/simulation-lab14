using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab14
{
    public partial class Form1 : Form
    {
        private class Interval
        {
            public Interval(int begin, int end)
            {
                this.begin = begin;
                this.end = end;
                events = 0;
            }
            public int begin;
            public int end;
            public int events;
        }
        double mean;
        double variance;
        int numberOfExperiments;
        int intervalsNumber, intervalSize;
        double minValue, maxValue;
        List<double> stat = new List<double>();
        List<Interval> intervals = new List<Interval>();
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            stat.Clear();
            intervals.Clear();
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            mean = (double)meanNumericUpDown.Value;
            variance = (double)varianceNumericUpDown.Value;
            numberOfExperiments = (int)numberOfExperimentsNumericUpDown.Value;

            minValue = mean;
            maxValue = mean;
            intervalsNumber = (int)Math.Log(numberOfExperiments) + 1;
            FindStatistic();
            intervalSize = (int)(maxValue - minValue) / intervalsNumber;

            int startValue = (int)Math.Floor(minValue);
            int endValue = startValue + intervalSize - 1;
            for (int i = 0; i < intervalsNumber;i++)
            {
                intervals.Add(new Interval(startValue, endValue));
                startValue = endValue;
                endValue = startValue + intervalSize - 1;

                for (int j=0;j<stat.Count;j++)
                {
                    if (stat[j] >= intervals[i].begin && stat[j] < intervals[i].end)
                    {
                        intervals[i].events++;
                    }
                }
            }



            for (int i =0;i<stat.Count;i++)
            {
                chart1.Series[0].Points.AddXY(stat[i], 1);
            }
        }

        private void FindStatistic()
        {
            for (int i=0;i<numberOfExperiments;i++)
            {
                Generator();
                stat.Add(RV);
                if (RV < minValue)
                    minValue = RV;
                if (RV > maxValue)
                    maxValue = RV;
            }
        }

        double U = 1;
        const int p = 5087; // большое простое число
        int M = 2900;       // M = p - 3^n. Берем n = 7, потому что 3^8 > p
        double R;
        double RV;
        private void Generator() // метод вычетов. Модификация Коробова
        {
            double tempR;
            R = U / p;
            U = (U * M) % p;

            tempR = R;
            R = U / p;
            U = (U * M) % p;

            RV = Math.Sqrt(variance) * (Math.Sqrt(-2 * Math.Log(tempR)) * Math.Cos(2 * Math.PI * R));
        }
    }
}
