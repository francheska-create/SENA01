using ControlAsistencia.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

  namespace ControlAsistencia.Models
{
    public class Programa
    {
        public int ProgramaId { get; set; }
       [Required]
       [MaxLength(512)]

        public string Nombre{ get; set; }
        [Required]
        [MaxLength(4,ErrorMessage ="{0}Maximo  de {1} Caracteres.")]
        public string Version { get; set; }
        [Required]
        [MaxLength(8)]
        public string Codigo { get; set; }
        public bool Estado { get; internal set; }

        internal static ApplicationDbContext Tolist()
        {
            throw new NotImplementedException();
        }
    }
}
