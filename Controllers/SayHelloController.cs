//Jessie Lamzon
//10/25/22
//Say Hello - Endpoint
//webapi application that has endpoints configured to complete Mini Challenge # 
//Peer review:Reed Goodwin- Good program that follows the directions very well and provides a good user exoerience!

using Microsoft.AspNetCore.Mvc;

namespace lamzonJ_SayHelloEndPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class SayHelloController : ControllerBase
{
    [HttpGet]
    [Route("Hello/{name}")]

    public string Hello(string name)
    {
        return $"Hello {name}!  Thanks for checking in, Have a good day!";
    }
}
