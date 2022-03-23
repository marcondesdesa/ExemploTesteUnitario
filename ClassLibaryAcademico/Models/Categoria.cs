using ClassLibaryAcademico.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibaryAcademico.Models
{
    internal class Categoria
    {
        private int _cat_codigo;
        private string _cat_nome;

        internal int Cat_codigo { get => _cat_codigo; set => _cat_codigo = value; }
        internal string Cat_nome { get => _cat_nome; set => _cat_nome = value; }

        internal Categoria Obter(int id)
        {
            return id > 0 ? new CategoriaDAO().Obter(id) : null;
        }

        internal List<Categoria> Obter()
        {
            return new CategoriaDAO().Obter();
        }
    }
}
