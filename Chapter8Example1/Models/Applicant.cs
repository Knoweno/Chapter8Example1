using System.ComponentModel.DataAnnotations;

namespace Chapter8Example1.Models
{
    public class Applicant
    {

        public int ApplicantId {  get; set; }
        [Required,Display(Name ="Your Nmae")]
        public string ApplicantName { get; set; }
        [Required]
        public int ACTScore { get; set; }
        public string DecisionNote {  get; set; }

    }
}
