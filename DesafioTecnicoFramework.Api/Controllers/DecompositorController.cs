using Microsoft.AspNetCore.Mvc;
using DesafioTecnicoFramework.Api.Domain;
using DesafioTecnicoFramework.Api.Helper;

namespace DesafioTecnicoFramework.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class DecompositorController : ControllerBase
{
    /// <summary>
    /// Método responsável por enviar um numero e fazer a decomposição
    /// </summary>
    [HttpPost]
    public ActionResult<Decompose> DecomposeNumber([FromBody] string number)
    {
        var decompose = new Decompose();

        if (!int.TryParse(number, out int a))
        {
            return BadRequest("Não é um numero inteiro");
        }
        
        for(var i = 1; i <= a; i++)
        {
            var valor = (double) a / i;

            if (int.TryParse(valor.ToString(), out _))
            {
                decompose.Divisores.Add(i);

                if (i.IsPrimeNumber())
                {
                    decompose.Primos.Add(i);
                }
            }
        }

        return decompose;
    }
}