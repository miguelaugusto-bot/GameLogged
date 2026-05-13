using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace back_end.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required] // Corresponde ao NN (Not Null)
        [MaxLength(50)] // Corresponde ao VARCHAR(50)
        public string nickname { get; set; }

        [Required]
        [MaxLength(100)] // Corresponde ao VARCHAR(100)
        public string nome { get; set; }

        [Required]
        [MaxLength(150)] // Corresponde ao VARCHAR(150)
        [EmailAddress] // Validação extra do C# para formato de e-mail
        public string email { get; set; }

        [Required]
        [MaxLength(255)] // Corresponde ao VARCHAR(255)
        public string password { get; set; }

        [Required]
        [Column(TypeName = "date")] // Garante que no MySQL seja DATE e não DATETIME
        public DateTime dt_nasc { get; set; }
    }
}