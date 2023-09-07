using System.ComponentModel.DataAnnotations;

namespace ExtraPoints_Grillino.Models
{
    public class Service
    {
        [Key] public required string Name { get; set; }
        public required string Description { get; set; }
        public string? ImagePath { get; set; }
    }
}
