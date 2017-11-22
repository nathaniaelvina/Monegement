using CrossPieCharts.UWP.PieCharts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Monegement
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class chartPage : Page
    {
        public List<PieChartArgs> PieChartCollection { get; set; }

        public chartPage()
        {
            this.InitializeComponent();
            LoadChartContents();
        }
        public void LoadChartContents()
        {

            PieChartCollection = new List<PieChartArgs>
            {
                new PieChartArgs
                {
                    Percentage = 44,
                    ColorBrush = new SolidColorBrush(Colors.LightBlue)

                },
                new PieChartArgs
                {
                    Percentage = 10,
                    ColorBrush = new SolidColorBrush(Colors.LightYellow)
                },
                new PieChartArgs
                {
                    Percentage = 22,
                    ColorBrush = new SolidColorBrush(Colors.LightGreen)
                },
                new PieChartArgs
                {
                    Percentage = 13,
                    ColorBrush = new SolidColorBrush(Colors.LightPink)
                },
                new PieChartArgs
                {
                    Percentage = 11,
                    ColorBrush = new SolidColorBrush(Colors.LightGoldenrodYellow)
                }
            };
        }
    }
}
