using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AnigramsProductionsV2.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "Required*")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Required*")]
        [RegularExpression(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$", ErrorMessage = "Invalid*")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Required*")]
        public string Subject { get; set; }

        [DataType(DataType.MultilineText)]
        public string Message { get; set; }
    }
}