using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using web_mvc.Models;
using Recaptcha.Web;
using Recaptcha.Web.Mvc;
using System.Threading.Tasks;
using ReCaptcha.Mvc5;

namespace web_mvc.Controllers
{
    public class RecrutamentoController : Controller
    {
        // GET: Recrutamento
        public ActionResult Index()
        {
            ViewBag.Erro = false;
            ViewBag.Mensagem = string.Empty;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> Alistarse(RecrutamentoModel model)
        {
            ViewBag.Erro = false;
            ViewBag.Mensagem = string.Empty;
            if (ModelState.IsValid)
            {
                // Verify the recaptcha response.
                ReCaptchaResponse response = await this.verifyReCAPTCHA(model, "6LfKyxsTAAAAAOWxz6s77gdm8aqoGfA0Gzq6fCgb", true);
                if (response.Success)
                {
                    try
                    {
                        if (model.Mensagem != null && model.Email != null && model.Nome != null && model.Telefone != null)
                        {


                            MailMessage mail = new MailMessage("barbaroswarsite@gmail.com", "barbaroswarsite@gmail.com");
                            SmtpClient client = new SmtpClient();
                            client.Port = 25;
                            client.DeliveryMethod = SmtpDeliveryMethod.Network;
                            client.UseDefaultCredentials = false;
                            client.Host = "smtp.gmail.com";
                            mail.Subject = "Nova solicitação de recrutamento";
                            mail.Body = "Olá, o clasher: " + model.Nome.ToString() + "\r\n" +
                                        "Telefone: " + model.Telefone.ToString() + "\r\n" +
                                        "E-mail: " + model.Email.ToString() + "\r\n" +
                                        "Solicitou entrar no clãn assim: " + model.Mensagem.ToString() + "\r\n";

                            client.EnableSsl = true;
                            client.Credentials = new System.Net.NetworkCredential("barbaroswarsite@gmail.com", "juliajael086");

                            client.Send(mail);

                            ViewBag.Mensagem = "Alistamento concluido - aguarde que entraremos em contato.";
                        }


                    }
                    catch (Exception ex)
                    {
                        ViewBag.Erro = true;
                        ViewBag.Mensagem = "Ooops... Ocorreu um problema, tente novamente mais tarde.";
                    }


                    return View("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Pare de spamar, vá ler um livro!");
                }
            }

            // If we got this far, something failed, redisplay form
            return View("Index");
        }
    }
}
