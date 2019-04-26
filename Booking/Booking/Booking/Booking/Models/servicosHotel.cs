using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.Models
{
    public class servicosHotel
    {
        
        public int IDServicos { get; set; }
        
        
        public long IDHotel { get; set; }

        [Required]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

    }
}
