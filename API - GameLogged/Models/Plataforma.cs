using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace back_end.Models
{
    public class Plataforma
    {
        // Campo Id
        // Identificador único da plataforma
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // Nome da plataforma
        public string Nome { get; set; }

        // Descrição da plataforma
        public string Descricao { get; set; }

        // Define se a plataforma está ativa
        // true = ativa
        // false = inativa
        public bool Ativo { get; set; }
    }
}