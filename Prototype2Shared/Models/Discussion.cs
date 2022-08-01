using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prototype2WebApi.Models
{
    public class Discussion
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DiscussionsId { get; set; }

        [ForeignKey("UserInfoData")]
        public int UserId { get; set; }
    }
}
