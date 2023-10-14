namespace Laboratorium2.Models
{
    public class Birth
    {
        public string? Name { get; set; }
        public DateTime? Date { get; }

        public bool? isValid()
        {
            DateTime now = DateTime.Today;
            return Name != null && Date != null  && Date < now;
        }

        public double getAge()
        {
            DateTime now = DateTime.Today;
            int age = now.Year - Date
            if (DOB > now.AddYears(-age)) age--;
            return age;
            return Name -
        }
    }
}
