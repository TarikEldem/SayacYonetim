using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SayacApi.Data;
using SayacApi.Models;


namespace SayacApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SayacController : ControllerBase
    {
        private readonly UygDbContext _dbContext;
        
        
    }
}
