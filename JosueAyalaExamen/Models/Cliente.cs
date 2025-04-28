using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [Column(TypeName = "decimal(18,2)")]
        [DataType(DataType.Currency)]
        public decimal Saldo { get; set; }

        [Display]
        public bool Miembro { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaRegistro { get; set; }
        public Recompensa Recompensa { get; set; }
    }
}