using Microsoft.AspNetCore.Mvc;
using Xablau.Data;

namespace Xablau.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonagemController : ControllerBase
    {
        private readonly AppDbContext _appDbContext; //Chamar o banco de dados para o controller

        public PersonagemController(AppDbContext appDbContext) 
        {
            _appDbContext = appDbContext;
        }

        

    }
}