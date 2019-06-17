using System;
using System.ComponentModel.DataAnnotations;

namespace SS.Annotator.Models
{
    public class TextResource
    {
        [Key]
        [Display(Name = "Id")]
        public Guid TextResourceId { get; set; }

        [Required]
        public string Text { get; set; }

        //[Display("Mod adnotare")]
        [Display(Name = "Annotation Mode")]
        public string AnnotationMode { get; set; }

        public string Language { get; set; }
    }
}
