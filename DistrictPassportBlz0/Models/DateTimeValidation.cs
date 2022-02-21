using System.ComponentModel.DataAnnotations;

namespace DistrictPassportBlz0.Models
{
    public class DateTimeValidation : ValidationAttribute
    {
        public string GetErrorMessage() => "Дата за границами допустимого диапазона";

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var date = (DateTime)value;

            if (DateTime.Compare(date, new DateTime(2000,1,1)) < 0) return new ValidationResult(GetErrorMessage());
            else return ValidationResult.Success;
        }

    }
}
