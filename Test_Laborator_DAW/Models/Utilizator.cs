using System.Data;
using Test_Laborator_DAW.Models.Base;

namespace Test_Laborator_DAW.Models
{
    public class Utilizator:BaseEntity
    {
        public string username { get; set; }
        public int varsta { get; set; }
        
       
        public ICollection<Comanda>? comenzi { get; set; }
        
    }
}
