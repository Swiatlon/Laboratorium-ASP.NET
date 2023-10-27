namespace Laboratorium2.Models
{
    public class Birth
    {
        public string Name { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public bool IsValid()
        {
            return !string.IsNullOrEmpty(Name) && DateOfBirth.HasValue && DateOfBirth < DateTime.Now;
        }

        public int CalculateAge()
        {
            if (DateOfBirth.HasValue)
            {
                DateTime currentDate = DateTime.Now;
                int age = currentDate.Year - DateOfBirth.Value.Year;

                if (DateOfBirth.Value.Date > currentDate.AddYears(-age))
                {
                    age--;
                }

                return age;
            }

            return 0; // Or handle the case where DateOfBirth is null
        }
    }
}
