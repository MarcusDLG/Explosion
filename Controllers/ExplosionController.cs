using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Explosion.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ExplosionController : ControllerBase
  {
    [HttpGet]
    public string Explode(string s)
    {
      var answerString = "";
      foreach (var letter in s)
      {
        var number = int.Parse(letter.ToString());
        for (var i = 0; i < number; i++)
        {
          answerString += letter;
        }
      }
      return answerString;
    }

  }
}