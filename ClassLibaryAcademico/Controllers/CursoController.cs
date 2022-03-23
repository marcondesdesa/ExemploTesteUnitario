using ClassLibaryAcademico.Models;
using ClassLibaryAcademico.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibaryAcademico.Controllers
{
   public  class CursoController
    {
        public int Gravar(CursoViewModel curso)
        {
            if (curso != null)
            {
                Curso c = new Curso()
                {
                    Cur_codigo = curso.Cur_codigo,
                    Cur_nome = curso.Cur_nome,
                    Cur_ativo = curso.Cur_ativo,
                    Cat_codigo = curso.Cat_codigo
                };
                return c.Gravar();
            }
            else
                return -1;
        }
    }
}
