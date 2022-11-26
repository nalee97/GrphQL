using System.ComponentModel.DataAnnotations;

namespace GrphQL.Models
{
    public class UpdateSuperheroInput
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Height { get; set; }
    }
}
