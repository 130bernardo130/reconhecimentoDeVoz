using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using reconhecimentoDeVoz;

namespace TesteReconhecimentoDeVoz {
    [TestClass]
    public class UnitTest1 {

        [TestMethod]
        public void TestFacebook() {
            Voz voz = new Voz();
            voz.ouvir();
            System.Threading.Thread.Sleep(3000);
            voz.parar();
            Assert.AreEqual("facebook", voz.ultimoComando);
        }


        [TestMethod]
        public void TestGoogle() {
            Voz voz = new Voz();
            voz.ouvir();
            System.Threading.Thread.Sleep(3000);
            voz.parar();
            Assert.AreEqual("google", voz.ultimoComando);
        }

        [TestMethod]
        public void Testavancar() {
            Voz voz = new Voz();
            voz.ouvir();
            System.Threading.Thread.Sleep(3000);
            voz.parar();
            Assert.AreEqual("avançar", voz.ultimoComando);
        }

        [TestMethod]
        public void TestVoltar() {
            Voz voz = new Voz();
            voz.ouvir();
            System.Threading.Thread.Sleep(3000);
            voz.parar();
            Assert.AreEqual("voltar", voz.ultimoComando);
        }
        


    }
}
