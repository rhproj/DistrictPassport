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
                $"SELECT [YearInfo],[QuarterInfo],[EntryDate],[DistrPopulation],[Marriages],[Divorces],[LargeFamilies],[ParentsDeprivedPr],[ParentsLimitedPr],[ParentsRestoredPr],[SopParents],[SopChildren],[AlimonyDebtors],[AlimonySumm],[OnPrevRecords],[ChildPopulation],[Newborns],[NewbornsDeaths],[ChildDeathsExternals],[CdMva],[CdDrowned],[CdFire],[ChildSuicides],[ChildSuicideAttempts],[SopMinors],[DisabledChildren],[Preschoolers],[PreschoolEducationals],[PreEdUnlicensed],[ChildlinePreschool],[Schools],[SchUnlicensed],[Graders1to4],[Graders5to11],[SelfEducated],[SedAttached],[Colleges],[ClgsUnlicensed],[CollegeStudents],[ClgsForeigners],[Universities],[UnvUnlicensed],[Students],[StForeigners],[Dormitories],[Orphans],[FosterFamilies],[FosterKids],[FosterKidsReturned],[FkretByFamilies],[Orphanages],[LivingInOrphanages],[RaisedByGuardians],[Adopted],[HomelessAt18],[HousingAt18],[CrimesByMinors],[CrimesAgainstMinors],[ConvictedMinors],[AdmoffensesByMinors],[PdnRegistered],[RegisteredDrugs],[RegisteredAlcohol],[Comments] from {district} order by [YearInfo],[QuarterInfo]",
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
                passport.LargeFamilies,
                passport.ParentsDeprivedPr,
                passport.ParentsLimitedPr,
                passport.ParentsRestoredPr,
                passport.SopParents,
                passport.SopChildren,
                passport.AlimonyDebtors,
                passport.AlimonySumm,
                passport.OnPrevRecords,
                passport.ChildPopulation,
                passport.Newborns,
                passport.NewbornsDeaths,
                passport.ChildDeathsExternals,
                passport.CdMva,
                passport.CdDrowned,
                passport.CdFire,
                passport.ChildSuicides,
                passport.ChildSuicideAttempts,
                passport.SopMinors,
                passport.DisabledChildren,
                passport.Preschoolers,
                passport.PreschoolEducationals,
                passport.PreEdUnlicensed,
                passport.ChildlinePreschool,
                passport.Schools,
                passport.SchUnlicensed,
                passport.Graders1to4,
                passport.Graders5to11,
                passport.SelfEducated,
                passport.SedAttached,
                passport.Colleges,
                passport.ClgsUnlicensed,
                passport.CollegeStudents,
                passport.ClgsForeigners,
                passport.Universities,
                passport.UnvUnlicensed,
                passport.Students,
                passport.StForeigners,
                passport.Dormitories,
                passport.Orphans,
                passport.FosterFamilies,
                passport.FosterKids,
                passport.FosterKidsReturned,
                passport.FkretByFamilies,
                passport.Orphanages,
                passport.LivingInOrphanages,
                passport.RaisedByGuardians,
                passport.Adopted,
                passport.HomelessAt18,
                passport.HousingAt18,
                passport.CrimesByMinors,
                passport.CrimesAgainstMinors,
                passport.ConvictedMinors,
                passport.AdmoffensesByMinors,
                passport.PdnRegistered,
                passport.RegisteredDrugs,
                passport.RegisteredAlcohol,
                passport.Comments
            };

            string querry = Querry_Save(district, passp.YearInfo, passp.QuarterInfo, passp.EntryDate, passp.DistrPopulation, passp.Marriages, passp.Divorces, passp.LargeFamilies,
                passp.ParentsDeprivedPr,
                passp.ParentsLimitedPr,
                passp.ParentsRestoredPr,
                passp.SopParents,
                passp.SopChildren,
                passp.AlimonyDebtors,
                passp.AlimonySumm,
                passp.OnPrevRecords,
                passp.ChildPopulation,
                passp.Newborns,
                passp.NewbornsDeaths,
                passp.ChildDeathsExternals,
                passp.CdMva,
                passp.CdDrowned,
                passp.CdFire,
                passp.ChildSuicides,
                passp.ChildSuicideAttempts,
                passp.SopMinors,
                passp.DisabledChildren,
                passp.Preschoolers,
                passp.PreschoolEducationals,
                passp.PreEdUnlicensed,
                passp.ChildlinePreschool,
                passp.Schools,
                passp.SchUnlicensed,
                passp.Graders1to4,
                passp.Graders5to11,
                passp.SelfEducated,
                passp.SedAttached,
                passp.Colleges,
                passp.ClgsUnlicensed,
                passp.CollegeStudents,
                passp.ClgsForeigners,
                passp.Universities,
                passp.UnvUnlicensed,
                passp.Students,
                passp.StForeigners,
                passp.Dormitories,
                passp.Orphans,
                passp.FosterFamilies,
                passp.FosterKids,
                passp.FosterKidsReturned,
                passp.FkretByFamilies,
                passp.Orphanages,
                passp.LivingInOrphanages,
                passp.RaisedByGuardians,
                passp.Adopted,
                passp.HomelessAt18,
                passp.HousingAt18,
                passp.CrimesByMinors,
                passp.CrimesAgainstMinors,
                passp.ConvictedMinors,
                passp.AdmoffensesByMinors,
                passp.PdnRegistered,
                passp.RegisteredDrugs,
                passp.RegisteredAlcohol,
                passp.Comments);

            await _dataAccess.QSaveData(querry, passp, "SQLDataConnection");
        }

        private string Querry_Save(string district, int year, int qtr, DateTime entrydate, 
            int population, int marriages, int divorces, int largefamilies, int parentsdeprivedpr,
            int parentslimitedpr, int parentsrestoredpr, int sopparents, int sopchildren, int alimonydebtors,
            int alimonysumm, int onprevrecords, int childpopulation, int newborns, int newbornsdeaths,
            int childdeathsexternals, int cdmva, int cddrowned,
            int cdfire,
            int childsuicides,
            int childsuicideattempts,
            int sopminors,
            int disabledchildren,
            int preschoolers,
            int preschooleducationals,
            int preedunlicensed,
            int childlinepreschool,
            int schools,
            int schunlicensed,
            int graders1to4,
            int graders5to11,
            int selfeducated,
            int sedattached,
            int colleges,
            int clgsunlicensed,
            int collegestudents,
            int clgsforeigners,
            int universities,
            int unvunlicensed,
            int students,
            int stforeigners,
            int dormitories,
            int orphans,
            int fosterfamilies,
            int fosterkids,
            int fosterkidsreturned,
            int fkretbyfamilies,
            int orphanages,
            int livinginorphanages,
            int raisedbyguardians,
            int adopted,
            int homelessat18,
            int housingat18,
            int crimesbyminors,
            int crimesagainstminors,
            int convictedminors,
            int admoffensesbyminors,
            int pdnregistered,
            int registereddrugs,
            int registeredalcohol,
            string comments)
        {
            return @$"MERGE {district} WITH (SERIALIZABLE) AS T
                    USING(VALUES({year}, {qtr}, '{entrydate}', {population}, {marriages}, {divorces},{largefamilies},{parentsdeprivedpr},{parentslimitedpr},{parentsrestoredpr},{sopparents},{sopchildren},{alimonydebtors},{alimonysumm},{onprevrecords},{childpopulation},{newborns},{newbornsdeaths},{childdeathsexternals},{cdmva},{cddrowned},{cdfire},{childsuicides},{childsuicideattempts})) 
                    AS U([YearInfo],[QuarterInfo],[EntryDate],[DistrPopulation],[Marriages],[Divorces],[LargeFamilies],[ParentsDeprivedPr],[ParentsLimitedPr],[ParentsRestoredPr],[SopParents],[SopChildren],[AlimonyDebtors],[AlimonySumm],[OnPrevRecords],[ChildPopulation],[Newborns],[NewbornsDeaths],[ChildDeathsExternals],[CdMva],[CdDrowned],[CdFire],[ChildSuicides],[ChildSuicideAttempts])
                        ON(U.[YearInfo] = T.[YearInfo] and U.[QuarterInfo] = T.[QuarterInfo])
                    WHEN MATCHED THEN
                        UPDATE SET T.[EntryDate] = U.[EntryDate],
                                    T.[DistrPopulation] = U.[DistrPopulation], 
                    				T.[Marriages] = U.[Marriages],
                    				T.[Divorces] = U.[Divorces],
                                    T.[LargeFamilies] = U.[LargeFamilies],
                                    T.[ParentsDeprivedPr] = U.[ParentsDeprivedPr], 
                                    T.[ParentsLimitedPr] = U.[ParentsLimitedPr], 
                                    T.[ParentsRestoredPr] = U.[ParentsRestoredPr],
                                    T.[SopParents] = U.[SopParents], 
                                    T.[SopChildren] = U.[SopChildren], 
                                    T.[AlimonyDebtors] = U.[AlimonyDebtors], 
                                    T.[AlimonySumm] = U.[AlimonySumm], 
                                    T.[OnPrevRecords] = U.[OnPrevRecords], 
                                    T.[ChildPopulation] = U.[ChildPopulation], 
                                    T.[Newborns] = U.[Newborns], 
                                    T.[NewbornsDeaths] = U.[NewbornsDeaths], 
                                    T.[ChildDeathsExternals] = U.[ChildDeathsExternals], 
                                    T.[CdMva] = U.[CdMva], 
                                    T.[CdDrowned] = U.[CdDrowned], 
                                    T.[CdFire] = U.[CdFire], 
                                    T.[ChildSuicides] = U.[ChildSuicides], 
                                    T.[ChildSuicideAttempts] = U.[ChildSuicideAttempts]
                    WHEN NOT MATCHED THEN
                        INSERT([YearInfo],[QuarterInfo],[EntryDate],[DistrPopulation],[Marriages],[Divorces],[LargeFamilies],[ParentsDeprivedPr],[ParentsLimitedPr],[ParentsRestoredPr],[SopParents],[SopChildren],[AlimonyDebtors],[AlimonySumm],[OnPrevRecords],[ChildPopulation],[Newborns],[NewbornsDeaths],[ChildDeathsExternals],[CdMva],[CdDrowned],[CdFire],[ChildSuicides],[ChildSuicideAttempts]) 
                        VALUES({year}, {qtr}, '{entrydate}', {population}, {marriages}, {divorces},{largefamilies},{parentsdeprivedpr},{parentslimitedpr},{parentsrestoredpr},{sopparents},{sopchildren},{alimonydebtors},{alimonysumm},{onprevrecords},{childpopulation},{newborns},{newbornsdeaths},{childdeathsexternals},{cdmva},{cddrowned},{cdfire},{childsuicides},{childsuicideattempts});";
        }
    }
}
