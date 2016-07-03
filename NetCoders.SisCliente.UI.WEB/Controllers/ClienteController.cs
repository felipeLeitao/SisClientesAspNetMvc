﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetCoders.SisCliente.UI.WEB.Controllers
{
    //Pra uma controller ser uma controller, ela precisa de 2 coisas
    //1 -> Tem que herdar de Controller (já vem sozinho)
    //2 -> O Sufixo precisa ser Controller
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Cadastrar()
        {
            //Quando eu escrevo return View(); sem parametros, ele tenta procurar uma tela
            //Que tenha o mesmo nome do meu método
            return View("Cadastrar");
        }

    }
}