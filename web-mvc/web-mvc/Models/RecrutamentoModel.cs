using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace web_mvc.Models
{
    public class RecrutamentoModel
    {
        [Required]
        [StringLength(30)]
        public string Nome  { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        [StringLength(30)]
        public string Telefone { get; set; }
        [Required]
        [StringLength(250)]
        public string Mensagem { get; set; }
    }
}