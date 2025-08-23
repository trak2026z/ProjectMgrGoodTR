using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Application.CarWorkshop
{
    public class CarWorkshopServiceDto
    {
        public int Id { get; set; }
        public string Description { get; set; } = default!;
        public decimal Cost { get; set; }
    }
}
