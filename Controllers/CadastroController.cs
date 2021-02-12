using Microsoft.AspNetCore.Mvc;

namespace instaDev.Controllers
{
     
    [Route("Cadastro")]
     public class CadastroController : Controller
    {
        public IActionResult Index() 
        {
            return View();
        } 
    }
}