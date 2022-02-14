using DistrictPassportLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistrictPassportLibrary.DataService
{
    public interface IPassportDataService
    {
        Task<List<IPassportModel>> QReadPassports(string district);
        Task QAddData(IPassportModel passport, string district);
        //Task<IPassportModel> QReadPasspQuarterly(string district, int quart, int year);
    }
}
