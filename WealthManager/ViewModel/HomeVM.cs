using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using WeathManager.Model;
using System.Collections.ObjectModel;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveCharts.Configurations;

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

                Values = UserModel.ListAmounts
                
            }
        };

        public HomeVM()
        {
            _pageModel = new PageModel();
        }
    }
}
