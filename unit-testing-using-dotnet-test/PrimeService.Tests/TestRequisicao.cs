using System;
using Xunit;
using SoftplanDev.Controllers;

namespace PrimeService.Tests
{
    public class TestRequisicao
    {
    
        [Fact]
        public void verificarResultadoGetEsperadoTrue()
        {
            var teste = new calculadorTaxaController();
            double result = teste.Get();

            Assert.Equal(0.01, result);
        }


        [Fact]
        public void verificarResultadoEsperadoJurosTrue()
        {
            var teste = new calculadorTaxaController();
            double result = teste.CalcularJuros(100,5);

            Assert.Equal(105.1, result);
        }
        
    }
}
