using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserIntraction.Models.ViewModel
{
    public class UserViewModel
    {
        [MaxLength(20, ErrorMessage = "Maximum length is 20")]
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }

        [MaxLength(20, ErrorMessage = "Maximum length is 20")]
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }

        [MaxLength(250, ErrorMessage = "Maximum length is 250")]
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Invalid phone")]
        [Required(ErrorMessage = "Phone is required")]
        public string Phone { get; set; }

        [MaxLength(250, ErrorMessage = "Maximum length is 250")]
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [MaxLength(50, ErrorMessage = "Maximum length is 50")]
        [Required(ErrorMessage = "Country is required")]
        public string Country { get; set; }

        [MaxLength(50, ErrorMessage = "Maximum length is 50")]
        [Required(ErrorMessage = "State is required")]
        public string State { get; set; }

        [MaxLength(6,ErrorMessage = "Maximum length is 6")]
        [Required(ErrorMessage = "Pincode is required")]
        public int Pincode { get; set; }

    }
}
