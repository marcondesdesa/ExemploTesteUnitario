using ClassLibaryAcademico.Models;
using ClassLibaryAcademico.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibaryAcademico.Controllers
{
   public  class UsuarioController
    {
        public bool Autenticar(int fun_codigo, string usu_senha)
        {
            return new Usuario().Autenticar(fun_codigo, usu_senha) ? true : false;
        }
    }
}
