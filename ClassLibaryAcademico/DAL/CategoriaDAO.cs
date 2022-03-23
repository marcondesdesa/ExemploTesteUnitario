using ClassLibaryAcademico.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;

namespace ClassLibaryAcademico.DAL
{
    internal class CategoriaDAO : Banco
    {
        private List<Categoria> TableToList(DataTable dt)
        {
            List<Categoria> dados = null;
            if (dt != null && dt.Rows.Count > 0)
                dados = (from DataRow linha in dt.Rows
                         select new Categoria()
                         {
                             Cat_codigo = int.Parse(linha["cat_codigo"].ToString()),
                             Cat_nome = linha["cat_nome"].ToString()
                         }).ToList();
            return dados;
        }

        internal List<Categoria> Obter()
        {
            ComandoSQL.Parameters.Clear();
            ComandoSQL.CommandText = @"select cat_codigo, cat_nome 
                    from Categorias
                    order by cat_nome";
            DataTable dt = ExecutaSelect();
            return TableToList(dt);
        }

        internal Categoria Obter(int cat_codigo)
        {
            ComandoSQL.Parameters.Clear();
            ComandoSQL.CommandText = @"select cat_codigo, cat_nome 
                    from Categorias
                    where cat_codigo = @cat_codigo";
            ComandoSQL.Parameters.AddWithValue("@cat_codigo", cat_codigo);
            DataTable dt = ExecutaSelect();
            var dados = TableToList(dt);
            return dados == null ? null : dados.FirstOrDefault();
        }

        
    }
}
