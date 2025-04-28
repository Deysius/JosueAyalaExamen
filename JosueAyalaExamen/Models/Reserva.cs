using System.ComponentModel.DataAnnotations;

namespace JosueAyalaExamen.Models
{
    public class Reserva
    {
        [Key]
        public int ReservaId { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime FechaEntrada { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime FechaSalida { get; set; }
        [DataType(DataType.Currency)]
        [Required]
        public decimal ValorPagar { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}