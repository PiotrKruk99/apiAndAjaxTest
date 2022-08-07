using Microsoft.AspNetCore.Mvc;

namespace webApiTest.Controllers;

public class Test : Controller
{
    public string GetTest()
    {
        return "test output";
    }
}