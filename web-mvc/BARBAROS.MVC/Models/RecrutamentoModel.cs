using System.ComponentModel.DataAnnotations;


namespace BARBAROS.MVC.Models
{
    public class RecrutamentoModel : ReCaptcha.Mvc5.Model.ReCaptchaViewModel
    {
        [Required(ErrorMessage = "Nome in-game")]
        [StringLength(30)]
        public string Nome  { get; set; }

        [Required(ErrorMessage = "E-mail obrigatório")]
        [StringLength(50)]
        public string Email { get; set; }

        [Required(ErrorMessage="Zapzap obrigatório")]
        [StringLength(30)]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Mensagem de recrutamento obrigatória")]
        [StringLength(250)]
        public string Mensagem { get; set; }

        [Required(ErrorMessage = "Stop spammig. Read books !")]
        public override string recaptcha_response_field { get; set; }
    }
}