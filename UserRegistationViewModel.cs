using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CosmoApp.Models
{
    [NotMapped]
    public class UserRegistationViewModel
    {
        //public int SelectedTestTypeId { get; set; }
        //public int SelectedProgressId { get; set; }           

        //public IEnumerable<SelectListItem> TestTypeDetails { get; set; }
        //public IEnumerable<SelectListItem> ReleaseProgressStatus { get; set; }
        //}
     
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        [Required]
        public string Sex;

        [Display(Name = "DateTime of Birth")]
        [Required]
        public DateTime dateofBirth;

        [Display(Name = "Address Line1")]
        [Required]
        public string Address_Line1;

        [Display(Name = "Address Line2")]
        [Required]
        public string Address_Line2;

        [Display(Name = "Address Line3")]        
        public string Address_Line3;
        
        [Required]
        public string City;
       
        [Required]
        public string Country;
                
        [Required]
        public string PostCode;

        [Display(Name = "Emaild Id")]
        [Required]
        public string EmailID;

        [Display(Name = "Personal Phone No")]
        [Required]
        public string PersonalPhone;

        [Display(Name = "Work Phone No")]       
        public string WorkPhone;

        [Display(Name = "Start Date")]
        [Required]
        public DateTime Begin_date;

        [Display(Name = "End Date")]        
        public DateTime End_Date;

    }
}