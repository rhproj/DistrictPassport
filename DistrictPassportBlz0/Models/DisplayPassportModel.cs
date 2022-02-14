using DistrictPassportLibrary.Models;
using System.ComponentModel.DataAnnotations;

namespace DistrictPassportBlz0.Models
{
    public class DisplayPassportModel : IPassportModel
    {
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
        public int SopMinors { get; set; }
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
        public string Comments { get; set; }
    }
}
