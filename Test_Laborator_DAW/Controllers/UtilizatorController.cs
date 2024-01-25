using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test_Laborator_DAW.Data;
using Test_Laborator_DAW.Models;

namespace Test_Laborator_DAW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilizatorController : ControllerBase
    {
        protected readonly myContext _db;
        protected readonly DbSet<Utilizator> _t;

        public UtilizatorController(myContext context)
        {
            _db = context;
            _t = context.Set<Utilizator>();
        }

        [HttpGet]
        public async Task<List<Utilizator>> Get()
        {
            return await _t.ToListAsync();

        }

        [HttpPost]
        public string Add(Utilizator utilizator)
        {
            var u = _t.Find(utilizator.Id);
            if (u == null)
            {
                _t.Add(utilizator);
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
