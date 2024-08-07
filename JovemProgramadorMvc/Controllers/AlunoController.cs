using Microsoft.AspNetCore.Mvc;

namespace JovemProgramadorMvc.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
