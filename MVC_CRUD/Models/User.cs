using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_CRUD.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public String Address { get; set; }

        [Required(ErrorMessage = "Course is required")]
        public String Course { get; set; }

        [Required, Range(18, 99)]
        public int Age { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public String Gender { get; set; }

        [StringLength(12, ErrorMessage = "Phone Number is required")]
        public String PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = " Email Address is required")]
        public String EmailAddress { get; set; }
       
    }
}
