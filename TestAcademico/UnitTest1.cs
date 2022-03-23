using ClassLibaryAcademico.Controllers;
using ClassLibaryAcademico.ViewModels;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAcademico
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Teste()
        {

            //Autenticação
            UsuarioController usuarioCtl = new UsuarioController();
            Assert.AreEqual(1, usuarioCtl.Autenticar(1, "12345"));

            //Consultar Categoria
            CategoriaController categoriaCtl = new CategoriaController();
            Assert.AreEqual(1, categoriaCtl.Obter());

            //consultar Categoria
            CategoriaController categoriaCtl2 = new CategoriaController();
            Assert.AreEqual(1, categoriaCtl2.Obter(1));



            CursoViewModel cursoVM = new CursoViewModel();
            cursoVM.Cat_codigo = 1;
            cursoVM.Cur_ativo = "A";
            cursoVM.Cur_nome = "Sistemas para Internet";
            
            //Gravar um curso
            CursoController cursoCtl = new CursoController();
            Assert.AreEqual(1, cursoCtl.Gravar(cursoVM));

        }


    }
}
