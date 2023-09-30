using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using WeathManager.Model;
using System.Collections.ObjectModel;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveCharts.Configurations;
using LiveChartsCore.SkiaSharpView.Extensions;
using System.Collections.Generic;
using SkiaSharp;

namespace WealthManager.ViewModel
{
    class HomeVM
    {
        private readonly PageModel _pageModel;
        int i = 0;

        public ISeries[] Series { get; set; } = new ISeries[]
        {

            new LineSeries<decimal>
            {
                Name = "Income",
                Values = new ObservableCollection<decimal> {800,100,450,120,300}
            },

            new LineSeries<decimal>
            {
                Name = "Expense",
                Values = new ObservableCollection<decimal> {500,288,300,100,51}
            }
        };

        public IEnumerable<ISeries> PieSeries { get; set; } =
            new[] { 2, 4, 1, 4, 3 }.AsPieSeries((value, series) =>
            {
                series.InnerRadius = 50;
            });

        public Axis[] XAxes { get; set; } =
        {
            new Axis
            {
                CrosshairLabelsBackground = SKColors.Transparent.AsLvcColor(),
                CrosshairLabelsPaint = new SolidColorPaint(SKColors.DarkGray, 1),
                CrosshairPaint = new SolidColorPaint(SKColors.DarkGray, 1),
                Labeler = value => value.ToString("N1")
            }
        };

        public Axis[] YAxes { get; set; } =
        {
            new Axis
            {
                CrosshairLabelsBackground = SKColors.Transparent.AsLvcColor(),
                CrosshairLabelsPaint = new SolidColorPaint(SKColors.DarkGray, 1),
                CrosshairPaint = new SolidColorPaint(SKColors.DarkGray, 1),
                CrosshairSnapEnabled = true // snapping is also supported
            }
        };

        public HomeVM()
        {
            _pageModel = new PageModel();
        }
    }
}
