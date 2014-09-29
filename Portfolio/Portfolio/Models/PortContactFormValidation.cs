using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Step 1: Import Systems
using System.ComponentModel.DataAnnotations;
namespace Portfolio.Models
{
    //Step 2: create a partial class for the class we are trying to validate
    //Step 3: add the data annotation for the metadata type 
    [MetadataType(typeof(PortContactFormValidation))]
    public partial class ContactForm
    {
    }
    public class PortContactFormValidation
    {
        //Step 4: declare properties of the class you want to validate,
        //and set data annotations
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Message { get; set; }


    }
}