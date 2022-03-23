using System;
using System.Collections.Generic;
using System.Text;


namespace ClassLibaryAcademico.ViewModels
{
    public class UsuarioViewModel
    {
        public int Fun_codigo { get; set; }
        public DateTime Usu_ultimaacesso { get; set; }
        public string Usu_senha { get; set; }
        public string Usu_nivel { get; set; }
    }
}
