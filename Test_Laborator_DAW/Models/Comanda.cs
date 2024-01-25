using Test_Laborator_DAW.Models.Base;

namespace Test_Laborator_DAW.Models
{
    public class Comanda:BaseEntity
    {
        public Guid? id_utilizator { get; set; }
        public string adresa { get; set; }
        public Utilizator? utilizator { get; set; }
        public ICollection<ComandaProdus>? produse { get; set; }
    }
}
