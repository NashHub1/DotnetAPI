
using Microsoft.AspNetCore.Mvc;

namespace DotnetAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    DataContextDapper _dapper;

    public UserController(IConfiguration config)
    {
        _dapper = new DataContextDapper(config);
    }

    [HttpGet("TestConnection")]
    public DateTime TestConnection()
    {
        return _dapper.LoadDataSingle<DateTime>("SELECT GETDATE()");
    }



    [HttpGet("GetUsers/{testValue}")]
    // [HttpGet("test")]
    // public IActionResult Test()
    public string[] GetUserstest(string testValue)
    {
        string[] responseArray = new string[] {
            "test1",
            "test2",
            testValue
        };
        return responseArray;
    }
    // public string[] Test()
    // {
    //     string[] responseArray = new string[] {
    //         "test1",
    //         "test2",            
    //     };
    //     return responseArray;
    // }
}