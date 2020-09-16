using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Cadastro_e_Acesso.Controllers
{
    public class CadastroeAcessoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Tentativa()
        {
            var list = new List<string>() {"Rio Grande do Sul", "Santa Catarina", "Paraná", "São Paulo", "Rio de Janeiro", "Espírito Santo", "Minas Gerais"};
            ViewBag.list = list;
            return View();
        }

    }
}
