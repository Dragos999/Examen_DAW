using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test_Laborator_DAW.Data;
using Test_Laborator_DAW.Models;

namespace Test_Laborator_DAW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComandaController : ControllerBase
    {
        protected readonly myContext _db;
        protected readonly DbSet<Comanda> _t;

        public ComandaController(myContext context)
        {
            _db = context;
            _t = context.Set<Comanda>();
        }
        [HttpGet]
        public async Task<List<Comanda>> Get()
        {
            return await _t.ToListAsync();

        }

        [HttpPost]
        public string Add(Comanda comanda)
        {
            var u = _t.Find(comanda.Id);
            if (u == null)
            {
                _t.Add(comanda);
                _db.SaveChanges();
                return "Added successfully!";
            }
            else
            {
                return "Failed!";
            }
        }
    }
}
