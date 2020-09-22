using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cadastro_e_Acesso.Data;
using Cadastro_e_Acesso.Models;


namespace Cadastro_e_Acesso.Controllers
{
    public class LoginController : Controller
    {
        private readonly CadastroeAcessoContext db;

            public LoginController(CadastroeAcessoContext context)
            {
                db = context;
            }

            public IActionResult Index()
            {
                return View();
            }

            [HttpPost]
            public ActionResult Index(Acesso usuario)
            {
                var user = db.Usuario.Where(x => x.Login == usuario.Login && x.Password == usuario.Password).FirstOrDefault();

                if (user == null)
                {
                    //usuário não identificado
                    ViewData["msgUsuario"] = "usuario nao identificado";
                }
                else
                {
                    var usuariobanco = user;

                    return RedirectToAction("Index", "Home");
                }

                return View();
            }
        
        }
}
