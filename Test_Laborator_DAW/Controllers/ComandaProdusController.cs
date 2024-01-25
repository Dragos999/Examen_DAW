using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using Test_Laborator_DAW.Data;
using Test_Laborator_DAW.Models;

namespace Test_Laborator_DAW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComandaProdusController : ControllerBase
    {
        protected readonly myContext _db;
        protected readonly DbSet<ComandaProdus> _t;

        public ComandaProdusController(myContext context)
        {
            _db = context;
            _t = context.Set<ComandaProdus>();
        }

        [HttpGet]
        public async Task<List<ComandaProdus>> Get()
        {
            return await _t.ToListAsync();

        }

        [HttpPost]
        public string Add(Guid id_com, Guid id_prod)
        {
            var com = _db.Comanda.Find(id_com);
            var prod = _db.Produs.Find(id_prod);
            if (com != null && prod != null)
            {
                var newComProd = new ComandaProdus
                {
                    comanda = com,
                    produs = prod,
                    id_comanda = id_com,
                    id_produs = id_prod
                  
                };

                
                 _t.Add(newComProd);
                _db.SaveChanges();
                return "Order assigned";
            }
            else
            {
                return "Produs sau comanda inexistente!";
            }

        }

    }
}
