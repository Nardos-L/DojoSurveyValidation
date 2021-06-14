using System.ComponentModel.DataAnnotations;

namespace DojoSurveyValidation.Models
{
    public class Survey
    {
        [Display(Name = "Your Name")]
        [MinLength(2)]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Dojo Location")]
        [Required]
        public string Location { get; set; }

        [Display(Name = "Favorite Language")]
        [Required]
        public string Language { get; set; }

        [Display(Name = "Comment (optional)")]
        [MinLength(20)]
        public string Comment { get; set;}
    }
    


}