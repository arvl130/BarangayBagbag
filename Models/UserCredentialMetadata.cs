using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BarangayBagbag.Models
{
    [MetadataType(typeof(UserCredentialMetadata))]
    public partial class UserCredential { }
    public class UserCredentialMetadata
    {
        [Required(ErrorMessage = "Please enter your username.")]
        public string username { get; set; }

        [Required(ErrorMessage = "Please enter your password.")]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}