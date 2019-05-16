using LiveCharts;
using LiveCharts.Wpf;
using System.Collections.Generic;
using System.Windows;


// CTRL+K,CTRL+D to reformat code and remove unused using lines

// Open the NuGet package manager
// Search for LiveCharts
// Install the LiveCharts.WPF

namespace WPF_LiveCharts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SeriesCollection LineChartData;
        public SeriesCollection ColumnChartData;
        public SeriesCollection PieChartData;


        public MainWindow()
        {
            InitializeComponent();
            DisplayLineChart();
            DisplayPieChart();
            DisplayColumnChart();
        }

        public void DisplayLineChart()
        {
            int[] data = { 5, 10, -1, 12, 4};

            // Add the data array values to the chart
            LineChartData = new SeriesCollection();
            LineSeries ChartPoints = new LineSeries();
            LineChartData.Add(ChartPoints);

            LineChartData[0].Values = new ChartValues<int>(data);
            LineChartDemo.Series = LineChartData;

            ChartPoints.Title = "Days";
            ChartPoints.LineSmoothness= 0.8;
            ChartPoints.PointGeometry= DefaultGeometries.Diamond;
            ChartPoints.PointGeometrySize = 10;

        } // end Display Chart


        public void DisplayPieChart()
        {

            PieChartData = new SeriesCollection();

            PieChartDemo.Series = PieChartData;
            int[] data = { 5, 10, 3, 7, 4 };

            foreach (int item in data)
            {
                PieChartDemo.Series.Add(
                    new PieSeries
                    {
                        Values = new ChartValues<int> { item },
                    });
            }

        } // end of Display Pie Chart



        public void DisplayColumnChart()
        {
            List<int> data = new List<int> { 3, 7, 2, 9, 11 };

            // Add the data array values to the chart
            ColumnChartData = new SeriesCollection();
            ColumnSeries ChartPoints = new ColumnSeries();
            ColumnChartData.Add(ChartPoints);

            ColumnChartData[0].Values = new ChartValues<int>(data);
            ColumnChartDemo.Series = ColumnChartData;

        } // end Display Chart


    }
}
