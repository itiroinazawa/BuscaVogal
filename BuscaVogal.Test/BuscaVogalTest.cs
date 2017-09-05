using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BuscaVogal.Test
{
    [TestClass]
    public class BuscaVogalTest
    {
        [TestMethod]
        public void BuscaVogalContemVogal_Sucesso_Test()
        {
            Stream stream = new Stream();
            stream.setMock("aAbBABacfe");

            var resultado = Business.firstChar(stream);
            
            var expected = 'e';
            Assert.AreEqual(expected, resultado);
        }

        [TestMethod]
        public void BuscaVogalNaoContemVogal_Sucesso_Test()
        {
            Stream stream = new Stream();
            stream.setMock("aAbBABacf");

            var resultado = Business.firstChar(stream);

            Assert.AreEqual(null, resultado);
        }

        [TestMethod]
        public void BuscaVogalContemVogal2_Sucesso_Test()
        {
            Stream stream = new Stream();
            stream.setMock("aAbBABeacf");

            var resultado = Business.firstChar(stream);

            Assert.AreEqual('e', resultado);
        }
    }
}
