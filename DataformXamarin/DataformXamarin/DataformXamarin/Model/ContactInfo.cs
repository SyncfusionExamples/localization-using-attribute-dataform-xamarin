using DataformXamarin.Rex;
using Syncfusion.XForms.DataForm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataformXamarin
{
    public class ContactInfo
    {
        [Display(Name = "FirstName", Prompt = "EnterFirstName", GroupName = "Name", ResourceType = typeof(Localization))]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceType = typeof(Localization), ErrorMessageResourceName = "FirstNameEmpty")]
        [StringLength(25, MinimumLength = 5, ErrorMessageResourceType = typeof(Localization), ErrorMessageResourceName = "FirstNameLength")]
        public String FirstName { get; set; }

        [Display(Name = "LastName", Prompt = "EnterLastName", GroupName = "Name", ResourceType = typeof(Localization))]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceType = typeof(Localization), ErrorMessageResourceName = "LastNameEmpty")]
        [StringLength(25, MinimumLength = 5, ErrorMessageResourceType = typeof(Localization), ErrorMessageResourceName = "LastNameLength")]
        public String LastName { get; set; }

        [Display(Name = "Address", Prompt = "EnterAddress", GroupName = "Details", ResourceType = typeof(Localization))]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceType = typeof(Localization), ErrorMessageResourceName = "AddressEmptyString")]
        public String Address { get; set; }

        [Display(Name = "ContactNo", GroupName = "Details", ResourceType = typeof(Localization))]
        public int? ContactNo { get; set; }

        public ContactInfo()
        {
        }
    }
}