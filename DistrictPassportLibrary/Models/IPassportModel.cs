
namespace DistrictPassportLibrary.Models
{
    public interface IPassportModel
    {
        int Id { get; set; }
        int YearInfo { get; set; }
        int QuarterInfo { get; set; }
        DateTime EntryDate { get; set; }
        int DistrPopulation { get; set; }
        int Marriages { get; set; }
        int Divorces { get; set; }
        int LargeFamilies { get; set; }
        int ParentsDeprivedPr { get; set; }
        int ParentsLimitedPr { get; set; }
        int ParentsRestoredPr { get; set; }
        int SopParents { get; set; }
        int SopChildren { get; set; }
        int AlimonyDebtors { get; set; }
        int AlimonySumm { get; set; }
        int OnPrevRecords { get; set; }
        int ChildPopulation { get; set; }
        int Newborns { get; set; }
        int NewbornsDeaths { get; set; }
        int ChildDeathsExternals { get; set; }
        int CdMva { get; set; }
        int CdDrowned { get; set; }
        int CdFire { get; set; }
        int ChildSuicides { get; set; }
        int ChildSuicideAttempts { get; set; }
        int SopMinors { get; set; }
        int DisabledChildren { get; set; }
        int Preschoolers { get; set; }
        int PreschoolEducationals { get; set; }
        int PreEdUnlicensed { get; set; }
        int ChildlinePreschool { get; set; }
        int Schools { get; set; }
        int SchUnlicensed { get; set; }
        int Graders1to4 { get; set; }
        int Graders5to11 { get; set; }
        int SelfEducated { get; set; }
        int SedAttached { get; set; }
        int Colleges { get; set; }
        int ClgsUnlicensed { get; set; }
        int CollegeStudents { get; set; }
        int ClgsForeigners { get; set; }
        int Universities { get; set; }
        int UnvUnlicensed { get; set; }
        int Students { get; set; }
        int StForeigners { get; set; }
        int Dormitories { get; set; }
        int Orphans { get; set; }
        int FosterFamilies { get; set; }
        int FosterKids { get; set; }
        int FosterKidsReturned { get; set; }
        int FkretByFamilies { get; set; }
        int Orphanages { get; set; }
        int LivingInOrphanages { get; set; }
        int RaisedByGuardians { get; set; }
        int Adopted { get; set; }
        int HomelessAt18 { get; set; }
        int HousingAt18 { get; set; }
        int CrimesByMinors { get; set; }
        int CrimesAgainstMinors { get; set; }
        int ConvictedMinors { get; set; }
        int AdmoffensesByMinors { get; set; }
        int PdnRegistered { get; set; }
        int RegisteredDrugs { get; set; }
        int RegisteredAlcohol { get; set; }
        string Comments { get; set; }

    }
}