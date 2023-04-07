using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BarangayBagbag.Models
{
    [MetadataType(typeof(AnnouncementMetadata))]
    public partial class Announcement { }
    public class AnnouncementMetadata
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Please enter a title.")]
        [DisplayName("Title")]
        public string title { get; set; }
        [Required(ErrorMessage = "Please enter a description.")]
        [DisplayName("Description")]
        [DataType(DataType.MultilineText)]
        public string description { get; set; }
        [Required(ErrorMessage = "Please enter an image URL.")]
        [DisplayName("Image URL")]
        public string imgUrl { get; set; }
        public System.DateTime createdAt { get; set; }
    }
}