using System.ComponentModel.DataAnnotations.Schema;

namespace EdunovaAPP.Models
{
    public class Smjer : Entitet
    {

        public string? Naziv { get; set; }
        [Column("brojsati")]
        public int? Trajanje { get; set; }
        public decimal? Cijena { get; set; }
        public DateTime? IzvodiSeOd { get; set; }
        public bool? Vaucer { get; set; }

    }
}
