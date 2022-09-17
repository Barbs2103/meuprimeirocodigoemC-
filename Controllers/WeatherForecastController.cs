using Microsoft.AspNetCore.Mvc;

namespace meuprimeirocodigoemC_.Controllers;

[ApiController]
[Route("test")]
public class TestController : ControllerBase
{
  [HttpGet("oi")]
  public ActionResult OutroTest()
  {
    return Content(@" 
        <marquee>
        <h1>
            Hello World
            </h1>
        </marquee>",
        "text/html");
  }
}
