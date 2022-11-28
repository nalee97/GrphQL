using System.ComponentModel.DataAnnotations;

namespace GrphQL.Models
{
    public class UpdateSuperpowerInput
    {
        [Key]
        public Guid Id { get; set; }
        public string? SuperPower { get; set; }
        public string? Description { get; set; }
    }
}
