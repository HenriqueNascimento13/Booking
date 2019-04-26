using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.Models
{
    public class Especificacoes
    {
        public int IDEspecificacao { get; set; }
        public long IDTipoQuarto { get; set; }

        [Required]
        public string Descricao { get; set; }
    }
}
