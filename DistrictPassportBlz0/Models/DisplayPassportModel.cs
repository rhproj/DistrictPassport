using DistrictPassportLibrary.Models;
using System.ComponentModel.DataAnnotations;

namespace DistrictPassportBlz0.Models
{
    public class DisplayPassportModel : IPassportModel
    {
        const string msgNaturalNums = "Допустимы только натуральные числа";

        [Required]
        [Range(2000, 2100, ErrorMessage = "Год: за границами допустимого диапазона")]
        public int YearInfo { get; set; }
        public int QuarterInfo { get; set; }
        [DateTimeValidation]
        public DateTime EntryDate { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int DistrPopulation { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Население района не может = 0")]
        public int Marriages { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int Divorces { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int LargeFamilies { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int ParentsDeprivedPr { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int ParentsLimitedPr { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int ParentsRestoredPr { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int SopParents { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int SopChildren { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int AlimonyEP { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int AlimonyDebtors { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int AlimonySumm { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int OnPrevRecords { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int ChildPopulation { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int Newborns { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int NewbornsDeaths { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int ChildDeathsExternals { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int CdMva { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int CdDrowned { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int CdFire { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int ChildSuicides { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int ChildSuicideAttempts { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int SopMinors { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int DisabledChildren { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int Preschoolers { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int PreschoolEducationals { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int PreEdUnlicensed { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int ChildlinePreschool { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int Schools { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int SchUnlicensed { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int Graders1to4 { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int Graders5to11 { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int SelfEducated { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int SedAttached { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int Colleges { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int ClgsUnlicensed { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int CollegeStudents { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int ClgsForeigners { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int Universities { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int UnvUnlicensed { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int Students { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int StForeigners { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int Dormitories { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int Orphans { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int FosterFamilies { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int FosterKids { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int FosterKidsReturned { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int FkretByFamilies { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int Orphanages { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int LivingInOrphanages { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int RaisedByGuardians { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int Adopted { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int HomelessAt18 { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int HousingAt18 { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int CrimesByMinors { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int CrimesAgainstMinors { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int ConvictedMinors { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int AdmoffensesByMinors { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int PdnRegistered { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int RegisteredDrugs { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = msgNaturalNums)]
        public int RegisteredAlcohol { get; set; }
        [MaxLength(1000)]
        public string Comments { get; set; }
    }
}
