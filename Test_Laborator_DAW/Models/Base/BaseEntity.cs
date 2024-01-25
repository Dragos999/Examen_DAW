using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Test_Laborator_DAW.Models.Base
{
    public class BaseEntity:IBaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { set; get; } = Guid.NewGuid();
    }
}
