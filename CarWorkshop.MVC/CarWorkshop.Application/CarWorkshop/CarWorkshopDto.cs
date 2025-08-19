using System.ComponentModel.DataAnnotations;

namespace CarWorkshop.Application.DTOs
{
    public class CarWorkshopDto
    {
        public string Name { get; set; } = default!;

        public string? Description { get; set; }
        public string? About { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }

        public string? CreatedById { get; set; }
        public bool IsEditable { get; set; }
    }
}

