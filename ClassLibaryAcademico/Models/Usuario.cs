using System;
using System.Collections.Generic;
using System.Text;
using ClassLibaryAcademico.DAL;

namespace ClassLibaryAcademico.Models
{
    internal class Usuario
    {
          
        private int _fun_codigo;
        private DateTime _usu_ultimaacesso;
        private string _usu_senha;
        private string _usu_nivel;

         internal int Fun_codigo { get => _fun_codigo; set => _fun_codigo = value; }
         internal DateTime Usu_ultimaacesso { get => _usu_ultimaacesso; set => _usu_ultimaacesso = value; }
         internal string Usu_senha { get => _usu_senha; set => _usu_senha = value; }
         internal string Usu_nivel { get => _usu_nivel; set => _usu_nivel = value; }


         internal bool Autenticar(int fun_codigo, string usu_senha)
        {
            if (fun_codigo > 0 && usu_senha.Trim().Length > 0)
            {           
                return new UsuarioDAO().Autenticar(fun_codigo, usu_senha);
            }
            else
                return false;
        }
      
    }
}
