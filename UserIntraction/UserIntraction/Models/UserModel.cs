using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UserIntraction.Models
{
    public class UserModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [MaxLength(20), MinLength(2)]
        [Required]
        public string FirstName { get; set; }

        [MaxLength(20), MinLength(2)]
        [Required]
        public string LastName { get; set; }

        [MaxLength(250)]
        [Required]
        public string Email { get; set; }

        
        [Required]
        public string Phone { get; set; }

        [MaxLength(250)]
        [Required]
        public string Address { get; set; }

        [MaxLength(50)]
        [Required]
        public string Country { get; set; }

        [MaxLength(50)]
        [Required]
        public string State { get; set; }

        
        [Required]
        public int Pincode { get; set; }
       

    }
}
