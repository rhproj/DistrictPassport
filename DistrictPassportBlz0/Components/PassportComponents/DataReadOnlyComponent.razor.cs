using DistrictPassportBlz0.Models;
using DistrictPassportLibrary.Models;
using Microsoft.AspNetCore.Components;

namespace DistrictPassportBlz0.Components.PassportComponents
{
    public partial class DataReadOnlyComponent
    {
        [Parameter]
        public string DistrictName { get; set; }

        [Parameter]
        public string DistrictTable { get; set; }

        [Parameter]
        public string OverviewPage { get; set; }


        private int _selectedYear;
        public int SelectedYear
        {
            get { return _selectedYear; }
            set { _selectedYear = value; LoadDataYear(_selectedYear); }
        }

        private int _selectedQuater;
        public int SelectedQuater
        {
            get { return _selectedQuater; }
            set { _selectedQuater = value; LoadDataQuarter(_selectedQuater); }
        }

        private List<IPassportModel> passpCollection = new List<IPassportModel>();
        private IPassportModel passport = new DisplayPassportModel();

        protected override async Task OnParametersSetAsync()
        {
            SelectedYear = DateTime.Now.Year;
            SelectedQuater = 1;
            passpCollection = await passportData.QReadPassports(DistrictTable);
            passport = passpCollection.FirstOrDefault(p => p.YearInfo == SelectedYear && p.QuarterInfo == SelectedQuater) ?? new DisplayPassportModel() { YearInfo = SelectedYear, QuarterInfo = SelectedQuater };
        }

        private void LoadDataYear(int year)
        {
            passport = passpCollection.FirstOrDefault(p => p.YearInfo == year && p.QuarterInfo == SelectedQuater) ?? new DisplayPassportModel() { YearInfo = year, QuarterInfo = SelectedQuater };
        }

        private void LoadDataQuarter(int quarter)
        {
            passport = passpCollection.FirstOrDefault(p => p.YearInfo == SelectedYear && p.QuarterInfo == quarter) ?? new DisplayPassportModel() { YearInfo = SelectedYear, QuarterInfo = quarter };
        }

        private void GoToOverviewPage()
        {
            UriHelper.NavigateTo(OverviewPage);
        }
    }
}
