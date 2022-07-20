using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prototype2WebApi.Models
{
    public class Acheivement
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AcheivementsId { get; set; }
        public string Descriptions { get; set; }
    }
}
