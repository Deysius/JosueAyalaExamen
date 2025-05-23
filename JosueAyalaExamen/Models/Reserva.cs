﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Column(TypeName = "decimal(18,2)")]
        [DataType(DataType.Currency)]
        [Required]
        public decimal ValorPagar { get; set; }
        public int ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        public Cliente? Cliente { get; set; }
    }
}
