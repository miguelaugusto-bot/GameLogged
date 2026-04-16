using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace back_end.Models
{
    public class Usuario
    {
        [Key]
        public int idusers { get; set; }

        public string username { get; set; }

        public string email { get; set; }

        public string password { get; set; }
    }
}