using System.ComponentModel.DataAnnotations;

namespace dcm_azure_app_dev.Data
{
    public class Person
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string? FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        [Display(Name = "DOB")]
        public DateTime DateOfBirth { get; set; }
    }
}