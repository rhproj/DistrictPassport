using DistrictPassportLibrary.DataAccess;
using DistrictPassportLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistrictPassportLibrary.DataService
{
    public class PassportSqlDataService : IPassportDataService
    {
        private readonly ISqlDataAccess _dataAccess;
        public PassportSqlDataService(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<List<IPassportModel>> QReadPassports(string district)
        {
            var passports = await _dataAccess.QLoadData<PassportModel, dynamic>(
                $"SELECT [YearInfo],[QuarterInfo],[EntryDate],[DistrPopulation],[Marriages],[Divorces],[LargeFamilies] from {district} order by [YearInfo],[QuarterInfo]",
                new { }, "SQLDataConnection"); 
            return passports.ToList<IPassportModel>(); 
        }

        //public async Task<IPassportModel> QReadPasspQuarterly(string district, int quart, int year)
        //{
        //    var passports = await _dataAccess.QLoadData<PassportModel, dynamic>(
        //        $"SELECT [YearInfo],[QuarterInfo],[DistrPopulation],[Marriages],[Divorces] from {district} WHERE [QuarterInfo] = {quart} and [YearInfo] = {year}",
        //        new { }, "SQLDataConnection");
        //    return passports.FirstOrDefault<IPassportModel>();
        //}

        public async Task QAddData(IPassportModel passport, string district)
        {
            var passp = new
            {
                passport.YearInfo,
                passport.QuarterInfo,
                passport.EntryDate,
                passport.DistrPopulation,
                passport.Marriages,
                passport.Divorces,
                passport.LargeFamilies
            };

            string querry = Querry_Save(district, passp.YearInfo, passp.QuarterInfo, passp.EntryDate, passp.DistrPopulation, passp.Marriages, passp.Divorces, passp.LargeFamilies);

            await _dataAccess.QSaveData(querry, passp, "SQLDataConnection");
        }

        private string Querry_Save(string district, int year, int qtr, DateTime entrydate, int population, int marriages, int divorces, int largefamilies)
        {
            return @$"MERGE {district} WITH (SERIALIZABLE) AS T
                    USING(VALUES({year}, {qtr}, '{entrydate}', {population}, {marriages}, {divorces},{largefamilies})) AS U([YearInfo],[QuarterInfo],[EntryDate],[DistrPopulation],[Marriages],[Divorces],[LargeFamilies])
                        ON(U.[YearInfo] = T.[YearInfo] and U.[QuarterInfo] = T.[QuarterInfo])
                    WHEN MATCHED THEN
                        UPDATE SET T.[EntryDate] = U.[EntryDate],
                                    T.[DistrPopulation] = U.[DistrPopulation], 
                    				T.[Marriages] = U.[Marriages],
                    				T.[Divorces] = U.[Divorces],
                                    T.[LargeFamilies] = U.[LargeFamilies]
                    WHEN NOT MATCHED THEN
                        INSERT([YearInfo],[QuarterInfo],[EntryDate],[DistrPopulation],[Marriages],[Divorces],[LargeFamilies]) 
                        VALUES({year}, {qtr}, '{entrydate}', {population}, {marriages}, {divorces},{largefamilies});";
        }
    }
}
