using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobPoratal_MVC.Models
{
    public class UserDetails
    {
        
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Please enter First Name")]
        [DisplayName("First Name")]
        [StringLength(100)]

        
        public string FirstName { get; set; }

        [Required(ErrorMessage ="Please enter your Last Name")]
        [DisplayName("Last Name")]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required(ErrorMessage="Please provide your DateofBirth")]
        [DisplayName("Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [StringLength(300)]
        public string Address { get; set; }

        [Required(ErrorMessage ="Please Provide your Valid Mobile Number")]
        [DisplayName("Mobile Number" )]
        [StringLength(10)]
        [Phone]
        public string MobileNumber { get; set; }

        [Required(ErrorMessage ="Please enter your Email")]
        [StringLength(50)]
        [EmailAddress(ErrorMessage ="Email is not in the correct format")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",ErrorMessage ="Please enter the correct format")]
        public string Email { get; set; }

        [Required]

        public string Gender { get; set; }

        [Required(ErrorMessage ="Please Enter your Qualification")]
        public string Qualification { get; set; }
        public int Experience { get; set; }
        public DateTime AppliedDate { get; set; }
        
        //public byte[] UploadResume { get; set; }
    }
}