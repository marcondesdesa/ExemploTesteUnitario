using ClassLibaryAcademico.DAL;
using System;
using System.Collections.Generic;
using System.Text;



namespace ClassLibaryAcademico.Models
{
    internal class Curso
    {

        private int _cur_codigo;
        private string _cur_nome;
        private string _cur_ativo;
        private int _cat_codigo;

        public int Cur_codigo { get => _cur_codigo; set => _cur_codigo = value; }
        public string Cur_nome { get => _cur_nome; set => _cur_nome = value; }
        public string Cur_ativo { get => _cur_ativo; set => _cur_ativo = value; }
        public int Cat_codigo { get => _cat_codigo; set => _cat_codigo = value; }

        internal int Gravar()
        {
            if (_cur_nome.Trim().Length >= 2 && _cat_codigo >0 )
            {
                return new CursoDAO().Gravar(this);
            }
            else
                return -10;
        }
    
    }
}


