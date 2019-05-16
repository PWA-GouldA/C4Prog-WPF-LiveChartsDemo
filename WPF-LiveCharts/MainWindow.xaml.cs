using LiveCharts;
using LiveCharts.Wpf;
using System;
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
        public SeriesCollection ChartData;
        public SeriesCollection PieChartData;
        public string[] Labels;


        public MainWindow()
        {
            InitializeComponent();
            DisplayChart();
            DisplayPieChart();
        }

        public void DisplayChart()
        {
            ChartData = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<int> { 3, 9, 2, 7 },
                    Title="Small",
                    LineSmoothness=0,
                },
                new LineSeries
                {
                    Values = new ChartValues<int> { 5, 11, 4, 9 },
                    Title="Big",
                    LineSmoothness=.5,
                }
            };

            Labels = new[] { "Jan", "Feb", "Mar", "Apr" };

            ChartDemo.Series = ChartData;

            ChartData.Add(new LineSeries
            {
                Values = new ChartValues<int> { 1, 7, -1, 5 },
                Title = "Medium",
                LineSmoothness = 1,
                PointGeometry = DefaultGeometries.Square,
                PointGeometrySize = 15,
            });

            ChartData[0].Values.Add(0);
            ChartData[1].Values.Add(10);
            ChartData[2].Values.Add(12);

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

    }
}
