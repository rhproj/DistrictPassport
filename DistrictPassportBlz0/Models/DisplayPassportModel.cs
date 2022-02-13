using DistrictPassportLibrary.Models;
using System.ComponentModel.DataAnnotations;

namespace DistrictPassportBlz0.Models
{
    public class DisplayPassportModel : IPassportModel
    {
        //public int Id { get; set; }
        //[Required]
        //[Range(2000, 2100, ErrorMessage = "Год: за границами диапазона")]
        //public int YearInfo { get; set; }
        //[Required]
        //[Range(1, 4, ErrorMessage = "Выберите квартал")]
        //public int Quarter { get; set; }
        //public DateTime Date { get; set; }
        //public int Population { get; set; }
        //public int Marriages { get; set; }
        //public int Divorces { get; set; }

        public int Id { get; set; }
        [Required]
        [Range(2000, 2100, ErrorMessage = "Год: за границами диапазона")]
        public int YearInfo { get; set; }
        public int QuarterInfo { get; set; }
        public DateTime EntryDate { get; set; }
        public int DistrPopulation { get; set; }
        public int Marriages { get; set; }
        public int Divorces { get; set; }
        public int LargeFamilies { get; set; }
        public int ParentsDeprivedPr { get; set; }
        public int ParentsLimitedPr { get; set; }
        public int ParentsRestoredPr { get; set; }
        public int SopParents { get; set; }
        public int SopChildren { get; set; }
        public int AlimonyDebtors { get; set; }
        public int AlimonySumm { get; set; }
        public int OnPrevRecords { get; set; }
        public int ChildPopulation { get; set; }
        public int Newborns { get; set; }
        public int NewbornsDeaths { get; set; }
        public int ChildDeathsExternals { get; set; }
        public int CdMva { get; set; }
        public int CdDrowned { get; set; }
        public int CdFire { get; set; }
        public int ChildSuicides { get; set; }
        public int ChildSuicideAttempts { get; set; }
        public int ChildMinors { get; set; }
        public int DisabledChildren { get; set; }
        public int Preschoolers { get; set; }
        public int PreschoolEducationals { get; set; }
        public int PreEdUnlicensed { get; set; }
        public int ChildlinePreschool { get; set; }
        public int Schools { get; set; }
        public int SchUnlicensed { get; set; }
        public int Graders1to4 { get; set; }
        public int Graders5to11 { get; set; }
        public int SelfEducated { get; set; }
        public int SedAttached { get; set; }
        public int Colleges { get; set; }
        public int ClgsUnlicensed { get; set; }
        public int CollegeStudents { get; set; }
        public int ClgsForeigners { get; set; }
        public int Universities { get; set; }
        public int UnvUnlicensed { get; set; }
        public int Students { get; set; }
        public int StForeigners { get; set; }
        public int Dormitories { get; set; }
        public int Orphans { get; set; }
        public int FosterFamilies { get; set; }
        public int FosterKids { get; set; }
        public int FosterKidsReturned { get; set; }
        public int FkretByFamilies { get; set; }
        public int Orphanages { get; set; }
        public int LivingInOrphanages { get; set; }
        public int RaisedByGuardians { get; set; }
        public int Adopted { get; set; }
        public int HomelessAt18 { get; set; }
        public int HousingAt18 { get; set; }
        public int CrimesByMinors { get; set; }
        public int CrimesAgainstMinors { get; set; }
        public int ConvictedMinors { get; set; }
        public int AdmoffensesByMinors { get; set; }
        public int PdnRegistered { get; set; }
        public int RegisteredDrugs { get; set; }
        public int RegisteredAlcohol { get; set; }

        public string DistrPopulationC { get; set; }
        public string MarriagesC { get; set; }
        public string DivorcesC { get; set; }
        public string LargeFamiliesC { get; set; }
        public string ParentsDeprivedPrC { get; set; }
        public string ParentsLimitedPrC { get; set; }
        public string ParentsRestoredPrC { get; set; }
        public string SopParentsC { get; set; }
        public string SopChildrenC { get; set; }
        public string AlimonyDebtorsC { get; set; }
        public string AlimonySummC { get; set; }
        public string OnPrevRecordsC { get; set; }
        public string ChildPopulationC { get; set; }
        public string NewbornsC { get; set; }
        public string NewbornsDeathsC { get; set; }
        public string ChildDeathsExternalsC { get; set; }
        public string CdMvaC { get; set; }
        public string CdDrownedC { get; set; }
        public string CdFireC { get; set; }
        public string ChildSuicidesC { get; set; }
        public string ChildSuicideAttemptsC { get; set; }
        public string ChildMinorsC { get; set; }
        public string DisabledChildrenC { get; set; }
        public string PreschoolersC { get; set; }
        public string PreschoolEducationalsC { get; set; }
        public string PreEdUnlicensedC { get; set; }
        public string ChildlinePreschoolC { get; set; }
        public string SchoolsC { get; set; }
        public string SchUnlicensedC { get; set; }
        public string Graders1to4C { get; set; }
        public string Graders5to11C { get; set; }
        public string SelfEducatedC { get; set; }
        public string SedAttachedC { get; set; }
        public string CollegesC { get; set; }
        public string ClgsUnlicensedC { get; set; }
        public string CollegeStudentsC { get; set; }
        public string ClgsForeignersC { get; set; }
        public string UniversitiesC { get; set; }
        public string UnvUnlicensedC { get; set; }
        public string StudentsC { get; set; }
        public string StForeignersC { get; set; }
        public string DormitoriesC { get; set; }
        public string OrphansC { get; set; }
        public string FosterFamiliesC { get; set; }
        public string FosterKidsC { get; set; }
        public string FosterKidsReturnedC { get; set; }
        public string FkretByFamiliesC { get; set; }
        public string OrphanagesC { get; set; }
        public string LivingInOrphanagesC { get; set; }
        public string RaisedByGuardiansC { get; set; }
        public string AdoptedC { get; set; }
        public string HomelessAt18C { get; set; }
        public string HousingAt18C { get; set; }
        public string CrimesByMinorsC { get; set; }
        public string CrimesAgainstMinorsC { get; set; }
        public string ConvictedMinorsC { get; set; }
        public string AdmoffensesByMinorsC { get; set; }
        public string PdnRegisteredC { get; set; }
        public string RegisteredDrugsC { get; set; }
        public string RegisteredAlcoholC { get; set; }
        public string Comments { get; set; }
    }
}
