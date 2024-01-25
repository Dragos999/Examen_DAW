namespace Test_Laborator_DAW.Models
{
    public class ComandaProdus
    {
        public Guid id_comanda { get; set; }
        public Guid id_produs { get; set; }
        public Comanda? comanda { get; set; }
        public Produs? produs { get; set; }
    }
}
