using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projeto.LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.LogicaNegocio.Tests
{
    [TestClass()]
    public class ValidadorTests
    {
        [TestMethod()]
        public void DeveValidarSeTem9Caracteres()
        {
            //Arrange - Preparacao
            var nifExemplo = "223456789";

            //Act - Ação 
            var validador = new Validador();
            var resultadoObtido = validador.ValidarNif(nifExemplo);

            //Assert - Validacao
            Assert.IsTrue(resultadoObtido);
        }


      

        [TestMethod]
        public void NaoDeveAceitarNifComecandoCom1()
        {
            //Arrange
            var nifExemplo = "123456789";

            //Act
            var validador = new Validador();
            var resultadoObtido = validador.ValidarNif(nifExemplo);

            //Assert
            Assert.IsFalse(resultadoObtido);
        }
    }
}