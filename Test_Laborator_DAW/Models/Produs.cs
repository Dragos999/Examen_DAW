using Test_Laborator_DAW.Models.Base;

namespace Test_Laborator_DAW.Models
{
    public class Produs:BaseEntity
    {
       

        public int pret { get; set; }
        public string nume { get; set; }
        public ICollection<ComandaProdus>? comenzi { get; set; }

        
    }
}
