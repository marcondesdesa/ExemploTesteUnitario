using System;
using System.Collections.Generic;
using System.Text;
using ClassLibaryAcademico.Models;
using System.Data;
using System.Linq;

namespace ClassLibaryAcademico.DAL
{
   internal class UsuarioDAO : Banco
    {


        private List<Usuario> TableToList(DataTable dt)
        {
            List<Usuario> dados = null;
            if (dt != null && dt.Rows.Count > 0)
                dados = (from DataRow linha in dt.Rows
                         select new Usuario()
                         {
                             Fun_codigo = int.Parse(linha["fun_codigo"].ToString()),
                             Usu_ultimaacesso = DateTime.Parse(linha["usu_ultimaacesso"].ToString()),
                             Usu_nivel = linha["usu_nivel"].ToString(),
                             Usu_senha = linha["usu_senha"].ToString()
                         }).ToList();
            return dados;
        }
        internal bool Autenticar(int fun_codigo, string usu_senha)
        {
            ComandoSQL.Parameters.Clear();        
            ComandoSQL.CommandText = @"select * from  Usuario 
                                        where (fun_codigo = @fun_codigo) and
                                            (usu_senha = @usu_senha)        ";          
            ComandoSQL.Parameters.AddWithValue("@fun_codigo",fun_codigo);
            ComandoSQL.Parameters.AddWithValue("@usu_senha", usu_senha);
            DataTable dt = ExecutaSelect();
            var dados = TableToList(dt);
            return dados == null ? false : true;              
        }


           
    }
}
