using System.ComponentModel.DataAnnotations;

namespace JosueAyalaExamen.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Range(18, 100)]
        public int Edad { get; set; }

        [DataType(DataType.Currency)]
        public decimal Saldo { get; set; }

        [Display]
        public bool Miembro { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaRegistro { get; set; }

    }
}