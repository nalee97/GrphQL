using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GrphQL.Models
{
    public class AddSuperpowerInput
    {
        [Key]
       
        [Required(ErrorMessage = "Please specify a name for the Superpower")]
        public string? SuperPower { get; set; }
        public string? Description { get; set; }

       
    }
}
