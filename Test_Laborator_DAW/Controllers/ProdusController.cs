using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test_Laborator_DAW.Data;
using Test_Laborator_DAW.Models;

namespace Test_Laborator_DAW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdusController : ControllerBase
    {
        protected readonly myContext _db;
        protected readonly DbSet<Produs> _t;

        public ProdusController(myContext context)
        {
            _db = context;
            _t = context.Set<Produs>();
        }
        [HttpGet]
        public async Task<List<Produs>> Get()
        {
            return await _t.ToListAsync();

        }

        [HttpPost]
        public string Add(Produs produs)
        {
            
                _t.Add(produs);
                _db.SaveChanges();
                return "Added successfully!";
          
            
        }
    }
}
