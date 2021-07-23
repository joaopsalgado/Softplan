using Microsoft.AspNetCore.Mvc;
using System;


namespace SoftplanDev.Controllers
{
 
    [Route("api/[controller]")]
    [ApiController]
    public class calculadorTaxaController : ControllerBase
    {
        // GET api/taxaJuros"
        [HttpGet]
        [Route("taxaJuros")]
        public double Get()
        {
            return 0.01;
        }
       
        [HttpGet]
        [Route("calculajuros")]
        public double CalcularJuros([FromQuery(Name = "valorinicial")] decimal valorinicial,[FromQuery(Name = "meses")] int meses)
        {
         
         double calculoInicial = Math.Pow(1 + Get(), meses);
         double calculoFinal = Convert.ToDouble(valorinicial) * calculoInicial;
         
          return (Math.Truncate(calculoFinal * 100) / 100);
        }

        [HttpGet]
        [Route("showmethecode")]
        public string GithubUrl()
        {
          return "https://github.com/joaopsalgado/Softplan";
        }

    }

}
