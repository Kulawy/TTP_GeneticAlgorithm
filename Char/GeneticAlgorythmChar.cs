using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using rtChart;
using TravellingThiefProblemSolver;
using TravellingThiefProblemSolver.Loaders;
using TravellingThiefProblemSolver.TravellingSalesmanProblem;

namespace Char
{
    public partial class GeneticAlgorythmChar : Form
    {
        public GeneticAlgorythmChar()
        {
            InitializeComponent();
           
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            this.chart1.Series["max"].Points.Clear();
            this.chart1.Series["min"].Points.Clear();
            this.chart1.Series["avg"].Points.Clear();
            DisplayGeneticParameters();
            //SerialPort serialPort = new SerialPort();
            StartDrawing();
            //StartDrawingRealTime();

            //var cpuThread = new Thread(new ThreadStart(this.StartDrawing));
            //cpuThread.IsBackground = true;
            //cpuThread.Start();
        }

        private void StartDrawingRealTime()
        {
            kayChart serialData = new kayChart(chart1, 60);
            serialData.serieName = "max";
            Task.Factory.StartNew(() =>
            {

                serialData.updateChart( updateChartWithCpu, 100);
            });
        }

        PerformanceCounter cpu = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        private double updateChartWithCpu()
        {
            return cpu.NextValue();
        }

        private void GeneticAlgorythmChar_Load(object sender, EventArgs e)
        {
            

        }

        private void StartDrawing()
        {
            string fileName = ChoseFileToLoad();
            var crossTypeNumber = this.CrossingMethod.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).TabIndex;

            var _fileLoader = new FileLoader(fileName);
            DataParser dataParser = new DataParser();
            dataParser.ParseDataFromFileStream(_fileLoader.GetFileStream());

            var oTTP = new TTP();
            oTTP.StartTTP(Env.POP_SIZE, Env.GENERATION_COUNT, Env.SORT_TYPE, Env.MUT_RATE, crossTypeNumber);
            //oTTP._generationFittnesMap;
            foreach(KeyValuePair<int, double> pair in oTTP._generationMaxFittnesMap)
            {
                this.chart1.Series["max"].Points.AddXY(pair.Key, pair.Value);
            }
            foreach (KeyValuePair<int, double> pair in oTTP._generationMinFittnesMap)
            {
                this.chart1.Series["min"].Points.AddXY(pair.Key, pair.Value);
            }
            foreach (KeyValuePair<int, double> pair in oTTP._generationAvgFittnesMap)
            {
                this.chart1.Series["avg"].Points.AddXY(pair.Key, pair.Value);
            }
            this.MaxValue.Text = oTTP._bestG.ToString();
            this.MinValue.Text = oTTP._worstG.ToString();
            
        }

        private string ChoseFileToLoad()
        {
            string fileName;
            if (this.EasyRadioButton1.Checked)
            {
                fileName = "easy_1.ttp";
            }
            else if(this.EasyRadioButton2.Checked)
            {
                fileName = "easy_2.ttp";
            }
            else if (this.EasyRadioButton3.Checked)
            {
                fileName = "easy_3.ttp";
            }
            else if (this.MediumRadioButton1.Checked)
            {
                fileName = "medium_1.ttp";
            }
            else if (this.MediumRadioButton2.Checked)
            {
                fileName = "medium_2.ttp";
            }

            else if(this.HardRadioButton1.Checked)
            {
                fileName = "hard_1.ttp";
            }
            else if (this.HardRadioButton2.Checked)
            {
                fileName = "hard_2.ttp";
            }
            else if (this.HardRadioButton3.Checked)
            {
                fileName = "hard_3.ttp";
            }
            else
            {
                fileName = Env.FILE_NAME;
            }
            return fileName;
        }

        private void DisplayGeneticParameters()
        {
            this.PopCount.Text = Env.POP_SIZE.ToString();
            this.GenSize.Text = Env.GENERATION_COUNT.ToString();
            this.MutRatio.Text = Env.MUT_RATE.ToString();
            this.CrossRatio.Text = Env.CROSS_RATE.ToString();
        }

    }
}
