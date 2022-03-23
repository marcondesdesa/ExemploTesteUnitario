using ClassLibaryAcademico.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;

namespace ClassLibaryAcademico.DAL
{
    internal class CursoDAO : Banco
    {
       
        internal int Gravar(Curso c)
        {
            ComandoSQL.Parameters.Clear();
            if (c.Cur_codigo == 0)
                ComandoSQL.CommandText = @"insert into Cursos (cur_nome, cur_ativo,cat_codigo) 
                                          values (@cur_nome,@cur_ativo,@cat_codigo)";
            else
            {
                ComandoSQL.CommandText = @"update Cursos 
                    set cur_nome = @cur_nome,
                        cur_ativo = @cur_ativo,
                        cat_codigo = @cat_codigo
                    where (cur_codigo = @cur_codigo)";
                ComandoSQL.Parameters.AddWithValue("@cur_codigo", c.Cur_codigo);
            }
            ComandoSQL.Parameters.AddWithValue("@cur_nome", c.Cur_nome);
            ComandoSQL.Parameters.AddWithValue("@cur_ativo", c.Cur_ativo);
            ComandoSQL.Parameters.AddWithValue("@cat_codigo", c.Cat_codigo);

            return ExecutaComando();
        }

    }
}
