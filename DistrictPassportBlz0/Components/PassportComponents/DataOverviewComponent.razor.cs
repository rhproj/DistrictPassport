using DistrictPassportLibrary.Models;
using Microsoft.AspNetCore.Components;

namespace DistrictPassportBlz0.Components.PassportComponents
{
    public partial class DataOverviewComponent
    {
        [Parameter]
        public string DistrictName { get; set; }

        [Parameter]
        public string DistrictTable { get; set; }

        private List<IPassportModel> passports;

        protected override async Task OnParametersSetAsync()
        {
            passports = await passportData.QReadPassportsInOrder(DistrictTable);
        }
    }
}
