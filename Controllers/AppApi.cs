using Microsoft.AspNetCore.Mvc;

namespace homePage2.Controllers;

[ApiController]
//[Route("api/[controller]")]
//[Route("GetFormatedText")]
public class AppApi : ControllerBase
{
    [HttpGet("GetFormatedText")]
    public string Get(string data1, string data2)
    {
        var returnData = data1.ToCharArray();
        Array.Reverse(returnData);
        return new String(returnData) + " | " + data2;
    }

    [HttpGet("FormatSingleText")]
    public string GetSingle()
    {
        var data1 = Request.Query.Keys.ToArray<string>()[0];
        var returnData = data1.ToCharArray();
        Array.Reverse(returnData);
        return new String(returnData);
    }

    [HttpPost("PostFormatedText")]
    public string Post()
    {
        string data = Request.Form["text1"];
        string data2 = Request.Form["text2"];
        var returnData = data.ToCharArray();
        Array.Reverse(returnData);
        return new String(returnData) + " | " + data2;
    }
}