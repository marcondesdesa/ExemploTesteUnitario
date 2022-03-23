using ClassLibaryAcademico.Models;
using ClassLibaryAcademico.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ClassLibaryAcademico.Controllers
{
   public class CategoriaController
    {
        public List<CategoriaViewModel> Obter()
        {
            var dados = new Categoria().Obter();
            if (dados != null && dados.Count > 0)
                return (from categoria in dados
                        select new CategoriaViewModel()
                        {
                            Cat_codigo = categoria.Cat_codigo,
                            Cat_senha = categoria.Cat_nome
                        }).ToList();
            else
                return null;
        }

        public CategoriaViewModel Obter(int id)
        {
            var dados = new Categoria().Obter(id);
            if (dados != null)
                return new CategoriaViewModel()
                {
                    Cat_codigo = dados.Cat_codigo,
                    Cat_senha = dados.Cat_nome
                };
            else
                return null;
        }
    }
}
