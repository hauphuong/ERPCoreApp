using System.ComponentModel.DataAnnotations;

namespace StdCoreApp.Models.AccountViewModels
{
    public class ExternalLoginViewModel
    {
        public string FullName { get; set; }

        [Required]
        public string DOB { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
    }
}